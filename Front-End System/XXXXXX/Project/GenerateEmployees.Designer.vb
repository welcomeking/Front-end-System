<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerateEmployee
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
        Me.EmployeeTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableTableAdapter = New Project.group2DataSetTableAdapters.EmployeeTableTableAdapter()
        Me.TableAdapterManager = New Project.group2DataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GEV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GEmployees1 = New Project.GEmployees()
        Me.GED = New Project.GEmployees()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.Group2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Group2DataSet
        '
        Me.Group2DataSet.DataSetName = "group2DataSet"
        Me.Group2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeTableBindingSource
        '
        Me.EmployeeTableBindingSource.DataMember = "EmployeeTable"
        Me.EmployeeTableBindingSource.DataSource = Me.Group2DataSet
        '
        'EmployeeTableTableAdapter
        '
        Me.EmployeeTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CarTableTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableTableAdapter = Nothing
        Me.TableAdapterManager.DamageDetailsTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableTableAdapter = Me.EmployeeTableTableAdapter
        Me.TableAdapterManager.InsuranceTableAdapter = Nothing
        Me.TableAdapterManager.ReservationTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Project.group2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(643, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Press To Generate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(194, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Employee ID you want to Generate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "EMPLOYEE REPORTS"
        '
        'GEV
        '
        Me.GEV.ActiveViewIndex = -1
        Me.GEV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GEV.Cursor = System.Windows.Forms.Cursors.Default
        Me.GEV.DisplayStatusBar = False
        Me.GEV.DisplayToolbar = False
        Me.GEV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GEV.Location = New System.Drawing.Point(0, 85)
        Me.GEV.Name = "GEV"
        Me.GEV.Size = New System.Drawing.Size(860, 336)
        Me.GEV.TabIndex = 3
        Me.GEV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14"})
        Me.ComboBox1.Location = New System.Drawing.Point(512, 57)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'GenerateEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(860, 421)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GEV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "GenerateEmployee"
        Me.Text = "GenerateEmployees"
        CType(Me.Group2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Group2DataSet As Project.group2DataSet
    Friend WithEvents EmployeeTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableTableAdapter As Project.group2DataSetTableAdapters.EmployeeTableTableAdapter
    Friend WithEvents TableAdapterManager As Project.group2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GED As Project.GEmployees
    Friend WithEvents GEV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GEmployees1 As Project.GEmployees
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
