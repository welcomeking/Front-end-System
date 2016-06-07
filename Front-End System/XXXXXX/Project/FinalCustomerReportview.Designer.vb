<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalCustomerReportview
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
        Me.Group2DataSet = New Project.group2DataSet()
        Me.ReservationTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationTableTableAdapter = New Project.group2DataSetTableAdapters.ReservationTableTableAdapter()
        Me.TableAdapterManager = New Project.group2DataSetTableAdapters.TableAdapterManager()
        Me.CarTableTableAdapter = New Project.group2DataSetTableAdapters.CarTableTableAdapter()
        Me.CustomerTableTableAdapter = New Project.group2DataSetTableAdapters.CustomerTableTableAdapter()
        Me.CarTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FRCD = New Project.FinalCustomerReport()
        Me.FRCV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.FinalCustomerReport1 = New Project.FinalCustomerReport()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Group2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.CarTableTableAdapter = Me.CarTableTableAdapter
        Me.TableAdapterManager.CustomerTableTableAdapter = Me.CustomerTableTableAdapter
        Me.TableAdapterManager.DamageDetailsTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableTableAdapter = Nothing
        Me.TableAdapterManager.InsuranceTableAdapter = Nothing
        Me.TableAdapterManager.ReservationTableTableAdapter = Me.ReservationTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = Project.group2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CarTableTableAdapter
        '
        Me.CarTableTableAdapter.ClearBeforeFill = True
        '
        'CustomerTableTableAdapter
        '
        Me.CustomerTableTableAdapter.ClearBeforeFill = True
        '
        'CarTableBindingSource
        '
        Me.CarTableBindingSource.DataMember = "CarTable"
        Me.CarTableBindingSource.DataSource = Me.Group2DataSet
        '
        'CustomerTableBindingSource
        '
        Me.CustomerTableBindingSource.DataMember = "CustomerTable"
        Me.CustomerTableBindingSource.DataSource = Me.Group2DataSet
        '
        'FRCV
        '
        Me.FRCV.ActiveViewIndex = 0
        Me.FRCV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FRCV.Cursor = System.Windows.Forms.Cursors.Default
        Me.FRCV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FRCV.Location = New System.Drawing.Point(0, 143)
        Me.FRCV.Name = "FRCV"
        Me.FRCV.ReportSource = Me.FinalCustomerReport1
        Me.FRCV.Size = New System.Drawing.Size(782, 432)
        Me.FRCV.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(467, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ShortcutsEnabled = False
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(587, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Generate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FinalCustomerReportview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 575)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FRCV)
        Me.Name = "FinalCustomerReportview"
        Me.Text = "FinalCustomerReportview"
        CType(Me.Group2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Group2DataSet As Project.group2DataSet
    Friend WithEvents ReservationTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReservationTableTableAdapter As Project.group2DataSetTableAdapters.ReservationTableTableAdapter
    Friend WithEvents TableAdapterManager As Project.group2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CarTableTableAdapter As Project.group2DataSetTableAdapters.CarTableTableAdapter
    Friend WithEvents CarTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableTableAdapter As Project.group2DataSetTableAdapters.CustomerTableTableAdapter
    Friend WithEvents CustomerTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FRCD As Project.FinalCustomerReport
    Friend WithEvents FRCV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents FinalCustomerReport1 As Project.FinalCustomerReport
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
