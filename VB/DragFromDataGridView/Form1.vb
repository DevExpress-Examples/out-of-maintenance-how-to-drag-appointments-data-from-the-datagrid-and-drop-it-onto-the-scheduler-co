Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Drawing

Namespace DragFromDataGridView
	Partial Public Class Form1
		Inherits Form

		' A drag box rectangle to check if it's necessary to start drag&drop.
		Private dragBox As Rectangle = Rectangle.Empty

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'carsDBDataSet.Cars' table. You can move, or remove it, as needed.
			Me.carsTableAdapter.Fill(Me.carsDBDataSet.Cars)
			' TODO: This line of code loads data into the 'carsDBDataSet.CarScheduling' table. You can move, or remove it, as needed.
			Me.carSchedulingTableAdapter.Fill(Me.carsDBDataSet.CarScheduling)

		End Sub

		Private Sub OnApptChangedInsertedDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage1.AppointmentsChanged, schedulerStorage1.AppointmentsInserted, schedulerStorage1.AppointmentsDeleted
			carSchedulingTableAdapter.Update(carsDBDataSet)
			carsDBDataSet.AcceptChanges()
		End Sub

		' Start drag&drop effects.
		#Region "#dragdropeffects"
		Private Sub schedulerControl1_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)  _
		Handles schedulerControl1.DragEnter
			e.Effect = DragDropEffects.Move
		End Sub

		Private Sub dataGridView1_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)  _
		Handles dataGridView1.DragEnter
			e.Effect = DragDropEffects.Move
		End Sub

		' Clear the drag box.
		Private Sub dataGridView1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) _
		Handles dataGridView1.MouseUp
			dragBox = Rectangle.Empty
		End Sub

		' Set the drag box.
		Private Sub dataGridView1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) _
		 Handles dataGridView1.MouseDown
			Dim dragSize As Size = SystemInformation.DragSize
			Me.dragBox = New Rectangle(e.X - dragSize.Width \ 2, e.Y - dragSize.Height \ 2,  _
		dragSize.Width, dragSize.Height)
		End Sub

		' Check if it's necessary to drag&drop.
		Private Sub dataGridView1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) _
		 Handles dataGridView1.MouseMove
			Dim pt As New Point(e.X, e.Y)
			If dragBox <> Rectangle.Empty AndAlso (Not dragBox.Contains(pt)) Then
				DoDrag()
				dragBox = Rectangle.Empty
			End If

		End Sub
		#End Region ' #dragdropeffects

		#Region "#dodrag"
		Private Sub DoDrag()
			' Initialize Car data.
			Dim row As DataRow = carsDBDataSet.Tables(0).Rows(dataGridView1.CurrentRow.Index)
			Dim data As New CarDragData()
			data.Model = row("Model").ToString()
			data.Description = row("Description").ToString()
			' Do drag&drop.
			dataGridView1.DoDragDrop(data, DragDropEffects.All)
		End Sub
		#End Region ' #dodrag

		#Region "#dragdrop"
		' Check if drag&drop info contains Car data and perform the drop action.
		Private Sub schedulerControl1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) _
 		Handles schedulerControl1.DragDrop
			If e.Data.GetDataPresent(GetType(CarDragData)) Then
				Dim pt As Point = schedulerControl1.PointToClient(New Point(e.X, e.Y))
				DoDrop(pt, CType(e.Data.GetData(GetType(CarDragData)), CarDragData))
			End If
		End Sub

		' Add a new appointment initialized with Car data.
		Private Sub DoDrop(ByVal point As Point, ByVal data As CarDragData)
			Dim hitInfo As SchedulerHitInfo =  _ 
		schedulerControl1.ActiveView.ViewInfo.CalcHitInfo(point, True)
			If hitInfo.HitTest = SchedulerHitTest.Cell Then

				' Obtain the time interval view info.
				Dim cell As SelectableIntervalViewInfo = hitInfo.ViewInfo

				' Add an appointment.
				Dim apt As New Appointment(cell.Interval.Start, TimeSpan.FromHours(4))
				apt.Subject = data.Model
				apt.Description = data.Description
				schedulerStorage1.Appointments.Add(apt)
			End If
		End Sub
		#End Region ' #dragdrop

	End Class

	#Region "#cardragdata"
	Public Class CarDragData
		Private model_Renamed As String = String.Empty
		Private description_Renamed As String = String.Empty

		Public Sub New()
		End Sub
		Public Property Model() As String
			Get
				Return model_Renamed
			End Get
			Set(ByVal value As String)
				model_Renamed = value
			End Set
		End Property
		Public Property Description() As String
		   Get
			   Return description_Renamed
		   End Get
		   Set(ByVal value As String)
			   description_Renamed = value
		   End Set
		End Property
	End Class
	#End Region ' #cardragdata

End Namespace