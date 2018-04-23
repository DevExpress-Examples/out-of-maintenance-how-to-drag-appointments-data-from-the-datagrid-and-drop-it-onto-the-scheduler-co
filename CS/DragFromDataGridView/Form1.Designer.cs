namespace DragFromDataGridView {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.carSchedulingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsDBDataSet = new DragFromDataGridView.CarsDBDataSet();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trademarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.literDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cylDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmissSpeedCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmissAutomaticDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPGCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPGHighwayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hyperlinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtfContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carSchedulingTableAdapter = new DragFromDataGridView.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter();
            this.carsTableAdapter = new DragFromDataGridView.CarsDBDataSetTableAdapters.CarsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSchedulingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(746, 321);
            this.schedulerControl1.Start = new System.DateTime(2008, 11, 19, 0, 0, 0, 0);
            this.schedulerControl1.Storage = this.schedulerStorage1;
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.DragEnter += new System.Windows.Forms.DragEventHandler(this.schedulerControl1_DragEnter);
            this.schedulerControl1.DragDrop += new System.Windows.Forms.DragEventHandler(this.schedulerControl1_DragDrop);
            // 
            // schedulerStorage1
            // 
            this.schedulerStorage1.Appointments.DataSource = this.carSchedulingBindingSource;
            this.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay";
            this.schedulerStorage1.Appointments.Mappings.Description = "Description";
            this.schedulerStorage1.Appointments.Mappings.End = "EndTime";
            this.schedulerStorage1.Appointments.Mappings.Label = "Label";
            this.schedulerStorage1.Appointments.Mappings.Location = "Location";
            this.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            this.schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            this.schedulerStorage1.Appointments.Mappings.ResourceId = "CarId";
            this.schedulerStorage1.Appointments.Mappings.Start = "StartTime";
            this.schedulerStorage1.Appointments.Mappings.Status = "Status";
            this.schedulerStorage1.Appointments.Mappings.Subject = "Subject";
            this.schedulerStorage1.Appointments.Mappings.Type = "EventType";
            this.schedulerStorage1.Resources.DataSource = this.carsBindingSource;
            this.schedulerStorage1.Resources.Mappings.Caption = "Model";
            this.schedulerStorage1.Resources.Mappings.Id = "ID";
            this.schedulerStorage1.Resources.Mappings.Image = "Picture";
            this.schedulerStorage1.AppointmentsChanged += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.OnApptChangedInsertedDeleted);
            this.schedulerStorage1.AppointmentsInserted += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.OnApptChangedInsertedDeleted);
            this.schedulerStorage1.AppointmentsDeleted += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.OnApptChangedInsertedDeleted);
            // 
            // carSchedulingBindingSource
            // 
            this.carSchedulingBindingSource.DataMember = "CarScheduling";
            this.carSchedulingBindingSource.DataSource = this.carsDBDataSet;
            // 
            // carsDBDataSet
            // 
            this.carsDBDataSet.DataSetName = "CarsDBDataSet";
            this.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.carsDBDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.trademarkDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.hPDataGridViewTextBoxColumn,
            this.literDataGridViewTextBoxColumn,
            this.cylDataGridViewTextBoxColumn,
            this.transmissSpeedCountDataGridViewTextBoxColumn,
            this.transmissAutomaticDataGridViewTextBoxColumn,
            this.mPGCityDataGridViewTextBoxColumn,
            this.mPGHighwayDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.hyperlinkDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn,
            this.priceDataGridViewTextBoxColumn,
            this.rtfContentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 151);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseMove);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            this.dataGridView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragEnter);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // trademarkDataGridViewTextBoxColumn
            // 
            this.trademarkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.trademarkDataGridViewTextBoxColumn.DataPropertyName = "Trademark";
            this.trademarkDataGridViewTextBoxColumn.HeaderText = "Trademark";
            this.trademarkDataGridViewTextBoxColumn.Name = "trademarkDataGridViewTextBoxColumn";
            this.trademarkDataGridViewTextBoxColumn.Width = 83;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 61;
            // 
            // hPDataGridViewTextBoxColumn
            // 
            this.hPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.hPDataGridViewTextBoxColumn.DataPropertyName = "HP";
            this.hPDataGridViewTextBoxColumn.HeaderText = "HP";
            this.hPDataGridViewTextBoxColumn.Name = "hPDataGridViewTextBoxColumn";
            this.hPDataGridViewTextBoxColumn.Width = 47;
            // 
            // literDataGridViewTextBoxColumn
            // 
            this.literDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.literDataGridViewTextBoxColumn.DataPropertyName = "Liter";
            this.literDataGridViewTextBoxColumn.HeaderText = "Liter";
            this.literDataGridViewTextBoxColumn.Name = "literDataGridViewTextBoxColumn";
            this.literDataGridViewTextBoxColumn.Width = 52;
            // 
            // cylDataGridViewTextBoxColumn
            // 
            this.cylDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cylDataGridViewTextBoxColumn.DataPropertyName = "Cyl";
            this.cylDataGridViewTextBoxColumn.HeaderText = "Cyl";
            this.cylDataGridViewTextBoxColumn.Name = "cylDataGridViewTextBoxColumn";
            this.cylDataGridViewTextBoxColumn.Width = 46;
            // 
            // transmissSpeedCountDataGridViewTextBoxColumn
            // 
            this.transmissSpeedCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.transmissSpeedCountDataGridViewTextBoxColumn.DataPropertyName = "TransmissSpeedCount";
            this.transmissSpeedCountDataGridViewTextBoxColumn.HeaderText = "TransmissSpeedCount";
            this.transmissSpeedCountDataGridViewTextBoxColumn.Name = "transmissSpeedCountDataGridViewTextBoxColumn";
            this.transmissSpeedCountDataGridViewTextBoxColumn.Width = 21;
            // 
            // transmissAutomaticDataGridViewTextBoxColumn
            // 
            this.transmissAutomaticDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.transmissAutomaticDataGridViewTextBoxColumn.DataPropertyName = "TransmissAutomatic";
            this.transmissAutomaticDataGridViewTextBoxColumn.HeaderText = "TransmissAutomatic";
            this.transmissAutomaticDataGridViewTextBoxColumn.Name = "transmissAutomaticDataGridViewTextBoxColumn";
            this.transmissAutomaticDataGridViewTextBoxColumn.Width = 21;
            // 
            // mPGCityDataGridViewTextBoxColumn
            // 
            this.mPGCityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.mPGCityDataGridViewTextBoxColumn.DataPropertyName = "MPG_City";
            this.mPGCityDataGridViewTextBoxColumn.HeaderText = "MPG_City";
            this.mPGCityDataGridViewTextBoxColumn.Name = "mPGCityDataGridViewTextBoxColumn";
            this.mPGCityDataGridViewTextBoxColumn.Width = 21;
            // 
            // mPGHighwayDataGridViewTextBoxColumn
            // 
            this.mPGHighwayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.mPGHighwayDataGridViewTextBoxColumn.DataPropertyName = "MPG_Highway";
            this.mPGHighwayDataGridViewTextBoxColumn.HeaderText = "MPG_Highway";
            this.mPGHighwayDataGridViewTextBoxColumn.Name = "mPGHighwayDataGridViewTextBoxColumn";
            this.mPGHighwayDataGridViewTextBoxColumn.Width = 21;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 74;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // hyperlinkDataGridViewTextBoxColumn
            // 
            this.hyperlinkDataGridViewTextBoxColumn.DataPropertyName = "Hyperlink";
            this.hyperlinkDataGridViewTextBoxColumn.HeaderText = "Hyperlink";
            this.hyperlinkDataGridViewTextBoxColumn.Name = "hyperlinkDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // rtfContentDataGridViewTextBoxColumn
            // 
            this.rtfContentDataGridViewTextBoxColumn.DataPropertyName = "RtfContent";
            this.rtfContentDataGridViewTextBoxColumn.HeaderText = "RtfContent";
            this.rtfContentDataGridViewTextBoxColumn.Name = "rtfContentDataGridViewTextBoxColumn";
            // 
            // carSchedulingTableAdapter
            // 
            this.carSchedulingTableAdapter.ClearBeforeFill = true;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 472);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.schedulerControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSchedulingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CarsDBDataSet carsDBDataSet;
        private System.Windows.Forms.BindingSource carSchedulingBindingSource;
        private DragFromDataGridView.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter carSchedulingTableAdapter;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private DragFromDataGridView.CarsDBDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trademarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn literDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cylDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmissSpeedCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmissAutomaticDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPGCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPGHighwayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hyperlinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtfContentDataGridViewTextBoxColumn;
    }
}

