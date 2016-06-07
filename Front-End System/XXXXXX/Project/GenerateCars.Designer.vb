<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerateCars
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
        Me.CarTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarTableTableAdapter = New Project.group2DataSetTableAdapters.CarTableTableAdapter()
        Me.TableAdapterManager = New Project.group2DataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GCARV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GCars11 = New Project.GCars1()
        Me.GCARD = New Project.GCars1()
        CType(Me.Group2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Group2DataSet
        '
        Me.Group2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CarTableBindingSource
        '
        Me.CarTableBindingSource.DataMember = "CarTable"
        Me.CarTableBindingSource.DataSource = Me.Group2DataSet
        '
        'CarTableTableAdapter
        '
        Me.CarTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CarTableTableAdapter = Me.CarTableTableAdapter
        Me.TableAdapterManager.CustomerTableTableAdapter = Nothing
        Me.TableAdapterManager.DamageDetailsTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableTableAdapter = Nothing
        Me.TableAdapterManager.InsuranceTableAdapter = Nothing
        Me.TableAdapterManager.ReservationTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Project.group2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(488, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Generate Car"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(209, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Car ID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(346, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'GCARV
        '
        Me.GCARV.ActiveViewIndex = 0
        Me.GCARV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GCARV.DisplayStatusBar = False
        Me.GCARV.DisplayToolbar = False
        Me.GCARV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GCARV.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GCARV.Location = New System.Drawing.Point(0, 92)
        Me.GCARV.Name = "GCARV"
        Me.GCARV.ReportSource = Me.GCars11
        Me.GCARV.Size = New System.Drawing.Size(843, 416)
        Me.GCARV.TabIndex = 0
        Me.GCARV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'GenerateCars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(843, 508)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GCARV)
        Me.Name = "GenerateCars"
        Me.Text = "GenerateCars"
        CType(Me.Group2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Group2DataSet As Project.group2DataSet
    Friend WithEvents CarTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CarTableTableAdapter As Project.group2DataSetTableAdapters.CarTableTableAdapter
    Friend WithEvents TableAdapterManager As Project.group2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents GCARD As Project.GCars1
    Friend WithEvents GCARV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GCars11 As Project.GCars1
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
