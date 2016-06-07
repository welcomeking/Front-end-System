<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalCarPaymentReportView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Group2DataSet = New Project.group2DataSet()
        Me.ReservationTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationTableTableAdapter = New Project.group2DataSetTableAdapters.ReservationTableTableAdapter()
        Me.TableAdapterManager = New Project.group2DataSetTableAdapters.TableAdapterManager()
        Me.FCPRD = New Project.FinalCarPaymentReport()
        Me.FCPRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.FinalCarPaymentReport1 = New Project.FinalCarPaymentReport()
        CType(Me.Group2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(572, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(460, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Group2DataSet
        '
        Me.Group2DataSet.DataSetName = "group2DataSet"
        Me.Group2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationTableBindingSource
        '
        Me.ReservationTableBindingSource.DataMember = "ReservationTable"
        Me.ReservationTableBindingSource.DataSource = Me.Group2DataSet
        '
        'ReservationTableTableAdapter
        '
        Me.ReservationTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CarTableTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableTableAdapter = Nothing
        Me.TableAdapterManager.DamageDetailsTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableTableAdapter = Nothing
        Me.TableAdapterManager.InsuranceTableAdapter = Nothing
        Me.TableAdapterManager.ReservationTableTableAdapter = Me.ReservationTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = Project.group2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FCPRV
        '
        Me.FCPRV.ActiveViewIndex = 0
        Me.FCPRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FCPRV.Cursor = System.Windows.Forms.Cursors.Default
        Me.FCPRV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FCPRV.Location = New System.Drawing.Point(0, 0)
        Me.FCPRV.Name = "FCPRV"
        Me.FCPRV.ReportSource = Me.FinalCarPaymentReport1
        Me.FCPRV.Size = New System.Drawing.Size(667, 453)
        Me.FCPRV.TabIndex = 2
        '
        'FinalCarPaymentReportView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 453)
        Me.Controls.Add(Me.FCPRV)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FinalCarPaymentReportView"
        Me.Text = "FinalCarPaymentReportView"
        CType(Me.Group2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Group2DataSet As Project.group2DataSet
    Friend WithEvents ReservationTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReservationTableTableAdapter As Project.group2DataSetTableAdapters.ReservationTableTableAdapter
    Friend WithEvents TableAdapterManager As Project.group2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents FCPRD As Project.FinalCarPaymentReport
    Friend WithEvents FCPRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents FinalCarPaymentReport1 As Project.FinalCarPaymentReport
End Class
