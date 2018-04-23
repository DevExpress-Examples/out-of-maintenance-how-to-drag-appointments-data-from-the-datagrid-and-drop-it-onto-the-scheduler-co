using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;

namespace DragFromDataGridView {
    public partial class Form1 : Form {

        // A drag box rectangle to check if it's necessary to start drag&drop.
        Rectangle dragBox = Rectangle.Empty;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'carsDBDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.carsDBDataSet.Cars);
            // TODO: This line of code loads data into the 'carsDBDataSet.CarScheduling' table. You can move, or remove it, as needed.
            this.carSchedulingTableAdapter.Fill(this.carsDBDataSet.CarScheduling);

        }

        private void OnApptChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e) {
            carSchedulingTableAdapter.Update(carsDBDataSet);
            carsDBDataSet.AcceptChanges();
        }

        // Start drag&drop effects.
        #region #dragdropeffects
        private void schedulerControl1_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Move;
        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Move;
        }

        // Clear the drag box.
        private void dataGridView1_MouseUp(object sender, MouseEventArgs e) {
            dragBox = Rectangle.Empty;
        }

        // Set the drag box.
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e) {
            Size dragSize = SystemInformation.DragSize;
            this.dragBox = new Rectangle(e.X - dragSize.Width / 2,
 e.Y - dragSize.Height / 2, dragSize.Width, dragSize.Height);
        }

        // Check if it's necessary to drag&drop.
        private void dataGridView1_MouseMove(object sender, MouseEventArgs e) {
            Point pt = new Point(e.X, e.Y);
            if (dragBox != Rectangle.Empty && !dragBox.Contains(pt)) {
                DoDrag();
                dragBox = Rectangle.Empty;
            }

        }
        #endregion #dragdropeffects

        #region #dodrag
        private void DoDrag() {
            // Initialize Car data.
            DataRow row = carsDBDataSet.Tables[0].Rows[dataGridView1.CurrentRow.Index];
            CarDragData data = new CarDragData();
            data.Model = row["Model"].ToString();
            data.Description = row["Description"].ToString();
            // Do drag&drop.
            dataGridView1.DoDragDrop(data, DragDropEffects.All);
        }
        #endregion #dodrag

        #region #dragdrop
        // Check if drag&drop info contains Car data and perform the drop action.
        private void schedulerControl1_DragDrop(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(typeof(CarDragData))) {
                Point pt = schedulerControl1.PointToClient(new Point(e.X, e.Y));
                DoDrop(pt, (CarDragData)e.Data.GetData(typeof(CarDragData)));
            }
        }

        // Add a new appointment initialized with Car data.
        private void DoDrop(Point point, CarDragData data) {
            SchedulerHitInfo hitInfo =
 schedulerControl1.ActiveView.ViewInfo.CalcHitInfo(point, true);
            if (hitInfo.HitTest == SchedulerHitTest.Cell) {

                // Obtain the time interval view info.
                SelectableIntervalViewInfo cell = hitInfo.ViewInfo;

                // Add an appointment.
                Appointment apt = schedulerStorage1.CreateAppointment(AppointmentType.Normal, cell.Interval.Start, TimeSpan.FromHours(4));
                apt.Subject = data.Model;
                apt.Description = data.Description;
                schedulerStorage1.Appointments.Add(apt);
            }
        }
        #endregion #dragdrop

    }

    #region #cardragdata
    public class CarDragData {
        string model = String.Empty;
        string description = String.Empty;

        public CarDragData() {
        }
        public string Model{
            get { return model; }
            set { model = value;}
        }
        public string Description { 
           get { return description; }
           set { description = value; }
        }
    #endregion #cardragdata
    }


}