Imports Microsoft.VisualBasic
Imports System
Namespace DragFromDataGridView
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
			Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.carSchedulingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.carsDBDataSet = New DragFromDataGridView.CarsDBDataSet()
			Me.carsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			Me.iDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.trademarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.modelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.hPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.literDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.cylDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.transmissSpeedCountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.transmissAutomaticDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.mPGCityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.mPGHighwayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.categoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.descriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.hyperlinkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.pictureDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
			Me.priceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.rtfContentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.carSchedulingTableAdapter = New DragFromDataGridView.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter()
			Me.carsTableAdapter = New DragFromDataGridView.CarsDBDataSetTableAdapters.CarsTableAdapter()
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carSchedulingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' schedulerControl1
			' 
			Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
			Me.schedulerControl1.Name = "schedulerControl1"
			Me.schedulerControl1.Size = New System.Drawing.Size(746, 321)
			Me.schedulerControl1.Start = New System.DateTime(2008, 11, 19, 0, 0, 0, 0)
			Me.schedulerControl1.Storage = Me.schedulerStorage1
			Me.schedulerControl1.TabIndex = 0
			Me.schedulerControl1.Text = "schedulerControl1"
			Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
'			Me.schedulerControl1.DragEnter += New System.Windows.Forms.DragEventHandler(Me.schedulerControl1_DragEnter);
'			Me.schedulerControl1.DragDrop += New System.Windows.Forms.DragEventHandler(Me.schedulerControl1_DragDrop);
			' 
			' schedulerStorage1
			' 
			Me.schedulerStorage1.Appointments.DataSource = Me.carSchedulingBindingSource
			Me.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
			Me.schedulerStorage1.Appointments.Mappings.Description = "Description"
			Me.schedulerStorage1.Appointments.Mappings.End = "EndTime"
			Me.schedulerStorage1.Appointments.Mappings.Label = "Label"
			Me.schedulerStorage1.Appointments.Mappings.Location = "Location"
			Me.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
			Me.schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
			Me.schedulerStorage1.Appointments.Mappings.ResourceId = "CarId"
			Me.schedulerStorage1.Appointments.Mappings.Start = "StartTime"
			Me.schedulerStorage1.Appointments.Mappings.Status = "Status"
			Me.schedulerStorage1.Appointments.Mappings.Subject = "Subject"
			Me.schedulerStorage1.Appointments.Mappings.Type = "EventType"
			Me.schedulerStorage1.Resources.DataSource = Me.carsBindingSource
			Me.schedulerStorage1.Resources.Mappings.Caption = "Model"
			Me.schedulerStorage1.Resources.Mappings.Id = "ID"
			Me.schedulerStorage1.Resources.Mappings.Image = "Picture"
'			Me.schedulerStorage1.AppointmentsChanged += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.OnApptChangedInsertedDeleted);
'			Me.schedulerStorage1.AppointmentsInserted += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.OnApptChangedInsertedDeleted);
'			Me.schedulerStorage1.AppointmentsDeleted += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.OnApptChangedInsertedDeleted);
			' 
			' carSchedulingBindingSource
			' 
			Me.carSchedulingBindingSource.DataMember = "CarScheduling"
			Me.carSchedulingBindingSource.DataSource = Me.carsDBDataSet
			' 
			' carsDBDataSet
			' 
			Me.carsDBDataSet.DataSetName = "CarsDBDataSet"
			Me.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' carsBindingSource
			' 
			Me.carsBindingSource.DataMember = "Cars"
			Me.carsBindingSource.DataSource = Me.carsDBDataSet
			' 
			' dataGridView1
			' 
			Me.dataGridView1.AllowUserToOrderColumns = True
			Me.dataGridView1.AutoGenerateColumns = False
			Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() { Me.iDDataGridViewTextBoxColumn, Me.trademarkDataGridViewTextBoxColumn, Me.modelDataGridViewTextBoxColumn, Me.hPDataGridViewTextBoxColumn, Me.literDataGridViewTextBoxColumn, Me.cylDataGridViewTextBoxColumn, Me.transmissSpeedCountDataGridViewTextBoxColumn, Me.transmissAutomaticDataGridViewTextBoxColumn, Me.mPGCityDataGridViewTextBoxColumn, Me.mPGHighwayDataGridViewTextBoxColumn, Me.categoryDataGridViewTextBoxColumn, Me.descriptionDataGridViewTextBoxColumn, Me.hyperlinkDataGridViewTextBoxColumn, Me.pictureDataGridViewImageColumn, Me.priceDataGridViewTextBoxColumn, Me.rtfContentDataGridViewTextBoxColumn})
			Me.dataGridView1.DataSource = Me.carsBindingSource
			Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dataGridView1.Location = New System.Drawing.Point(0, 321)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.Size = New System.Drawing.Size(746, 151)
			Me.dataGridView1.TabIndex = 1
'			Me.dataGridView1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.dataGridView1_MouseDown);
'			Me.dataGridView1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.dataGridView1_MouseMove);
'			Me.dataGridView1.MouseUp += New System.Windows.Forms.MouseEventHandler(Me.dataGridView1_MouseUp);
'			Me.dataGridView1.DragEnter += New System.Windows.Forms.DragEventHandler(Me.dataGridView1_DragEnter);
			' 
			' iDDataGridViewTextBoxColumn
			' 
			Me.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
			Me.iDDataGridViewTextBoxColumn.DataPropertyName = "ID"
			Me.iDDataGridViewTextBoxColumn.HeaderText = "ID"
			Me.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn"
			Me.iDDataGridViewTextBoxColumn.Width = 43
			' 
			' trademarkDataGridViewTextBoxColumn
			' 
			Me.trademarkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
			Me.trademarkDataGridViewTextBoxColumn.DataPropertyName = "Trademark"
			Me.trademarkDataGridViewTextBoxColumn.HeaderText = "Trademark"
			Me.trademarkDataGridViewTextBoxColumn.Name = "trademarkDataGridViewTextBoxColumn"
			Me.trademarkDataGridViewTextBoxColumn.Width = 83
			' 
			' modelDataGridViewTextBoxColumn
			' 
			Me.modelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
			Me.modelDataGridViewTextBoxColumn.DataPropertyName = "Model"
			Me.modelDataGridViewTextBoxColumn.HeaderText = "Model"
			Me.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn"
			Me.modelDataGridViewTextBoxColumn.Width = 61
			' 
			' hPDataGridViewTextBoxColumn
			' 
			Me.hPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
			Me.hPDataGridViewTextBoxColumn.DataPropertyName = "HP"
			Me.hPDataGridViewTextBoxColumn.HeaderText = "HP"
			Me.hPDataGridViewTextBoxColumn.Name = "hPDataGridViewTextBoxColumn"
			Me.hPDataGridViewTextBoxColumn.Width = 47
			' 
			' literDataGridViewTextBoxColumn
			' 
			Me.literDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
			Me.literDataGridViewTextBoxColumn.DataPropertyName = "Liter"
			Me.literDataGridViewTextBoxColumn.HeaderText = "Liter"
			Me.literDataGridViewTextBoxColumn.Name = "literDataGridViewTextBoxColumn"
			Me.literDataGridViewTextBoxColumn.Width = 52
			' 
			' cylDataGridViewTextBoxColumn
			' 
			Me.cylDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
			Me.cylDataGridViewTextBoxColumn.DataPropertyName = "Cyl"
			Me.cylDataGridViewTextBoxColumn.HeaderText = "Cyl"
			Me.cylDataGridViewTextBoxColumn.Name = "cylDataGridViewTextBoxColumn"
			Me.cylDataGridViewTextBoxColumn.Width = 46
			' 
			' transmissSpeedCountDataGridViewTextBoxColumn
			' 
			Me.transmissSpeedCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
			Me.transmissSpeedCountDataGridViewTextBoxColumn.DataPropertyName = "TransmissSpeedCount"
			Me.transmissSpeedCountDataGridViewTextBoxColumn.HeaderText = "TransmissSpeedCount"
			Me.transmissSpeedCountDataGridViewTextBoxColumn.Name = "transmissSpeedCountDataGridViewTextBoxColumn"
			Me.transmissSpeedCountDataGridViewTextBoxColumn.Width = 21
			' 
			' transmissAutomaticDataGridViewTextBoxColumn
			' 
			Me.transmissAutomaticDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
			Me.transmissAutomaticDataGridViewTextBoxColumn.DataPropertyName = "TransmissAutomatic"
			Me.transmissAutomaticDataGridViewTextBoxColumn.HeaderText = "TransmissAutomatic"
			Me.transmissAutomaticDataGridViewTextBoxColumn.Name = "transmissAutomaticDataGridViewTextBoxColumn"
			Me.transmissAutomaticDataGridViewTextBoxColumn.Width = 21
			' 
			' mPGCityDataGridViewTextBoxColumn
			' 
			Me.mPGCityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
			Me.mPGCityDataGridViewTextBoxColumn.DataPropertyName = "MPG_City"
			Me.mPGCityDataGridViewTextBoxColumn.HeaderText = "MPG_City"
			Me.mPGCityDataGridViewTextBoxColumn.Name = "mPGCityDataGridViewTextBoxColumn"
			Me.mPGCityDataGridViewTextBoxColumn.Width = 21
			' 
			' mPGHighwayDataGridViewTextBoxColumn
			' 
			Me.mPGHighwayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
			Me.mPGHighwayDataGridViewTextBoxColumn.DataPropertyName = "MPG_Highway"
			Me.mPGHighwayDataGridViewTextBoxColumn.HeaderText = "MPG_Highway"
			Me.mPGHighwayDataGridViewTextBoxColumn.Name = "mPGHighwayDataGridViewTextBoxColumn"
			Me.mPGHighwayDataGridViewTextBoxColumn.Width = 21
			' 
			' categoryDataGridViewTextBoxColumn
			' 
			Me.categoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
			Me.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
			Me.categoryDataGridViewTextBoxColumn.HeaderText = "Category"
			Me.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn"
			Me.categoryDataGridViewTextBoxColumn.Width = 74
			' 
			' descriptionDataGridViewTextBoxColumn
			' 
			Me.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
			Me.descriptionDataGridViewTextBoxColumn.HeaderText = "Description"
			Me.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn"
			' 
			' hyperlinkDataGridViewTextBoxColumn
			' 
			Me.hyperlinkDataGridViewTextBoxColumn.DataPropertyName = "Hyperlink"
			Me.hyperlinkDataGridViewTextBoxColumn.HeaderText = "Hyperlink"
			Me.hyperlinkDataGridViewTextBoxColumn.Name = "hyperlinkDataGridViewTextBoxColumn"
			' 
			' pictureDataGridViewImageColumn
			' 
			Me.pictureDataGridViewImageColumn.DataPropertyName = "Picture"
			Me.pictureDataGridViewImageColumn.HeaderText = "Picture"
			Me.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn"
			' 
			' priceDataGridViewTextBoxColumn
			' 
			Me.priceDataGridViewTextBoxColumn.DataPropertyName = "Price"
			Me.priceDataGridViewTextBoxColumn.HeaderText = "Price"
			Me.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn"
			' 
			' rtfContentDataGridViewTextBoxColumn
			' 
			Me.rtfContentDataGridViewTextBoxColumn.DataPropertyName = "RtfContent"
			Me.rtfContentDataGridViewTextBoxColumn.HeaderText = "RtfContent"
			Me.rtfContentDataGridViewTextBoxColumn.Name = "rtfContentDataGridViewTextBoxColumn"
			' 
			' carSchedulingTableAdapter
			' 
			Me.carSchedulingTableAdapter.ClearBeforeFill = True
			' 
			' carsTableAdapter
			' 
			Me.carsTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(746, 472)
			Me.Controls.Add(Me.dataGridView1)
			Me.Controls.Add(Me.schedulerControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carSchedulingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
		Private WithEvents schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
		Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
		Private carsDBDataSet As CarsDBDataSet
		Private carSchedulingBindingSource As System.Windows.Forms.BindingSource
		Private carSchedulingTableAdapter As DragFromDataGridView.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter
		Private carsBindingSource As System.Windows.Forms.BindingSource
		Private carsTableAdapter As DragFromDataGridView.CarsDBDataSetTableAdapters.CarsTableAdapter
		Private iDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private trademarkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private modelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private hPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private literDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private cylDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private transmissSpeedCountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private transmissAutomaticDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private mPGCityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private mPGHighwayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private categoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private descriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private hyperlinkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private pictureDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
		Private priceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private rtfContentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	End Class
End Namespace

