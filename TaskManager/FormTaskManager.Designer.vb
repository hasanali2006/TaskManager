<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTaskManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTaskManager))
        lblTitle = New Label()
        Panel1 = New Panel()
        btnDeleteTask = New Button()
        btnUpdateTask = New Button()
        btnAddTask = New Button()
        dtDueDate = New DateTimePicker()
        cmbStatus = New ComboBox()
        cmbPriority = New ComboBox()
        txtDescription = New TextBox()
        txtTaskName = New TextBox()
        lblStatus = New Label()
        lblDueDate = New Label()
        lblPriority = New Label()
        lblDescription = New Label()
        lblTaskName = New Label()
        lvTasks = New ListView()
        taskname = New ColumnHeader()
        description = New ColumnHeader()
        priority = New ColumnHeader()
        duedate = New ColumnHeader()
        status = New ColumnHeader()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.Dock = DockStyle.Top
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(0, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(450, 44)
        lblTitle.TabIndex = 5
        lblTitle.Text = "Task Manager"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnDeleteTask)
        Panel1.Controls.Add(btnUpdateTask)
        Panel1.Controls.Add(btnAddTask)
        Panel1.Controls.Add(dtDueDate)
        Panel1.Controls.Add(cmbStatus)
        Panel1.Controls.Add(cmbPriority)
        Panel1.Controls.Add(txtDescription)
        Panel1.Controls.Add(txtTaskName)
        Panel1.Controls.Add(lblStatus)
        Panel1.Controls.Add(lblDueDate)
        Panel1.Controls.Add(lblPriority)
        Panel1.Controls.Add(lblDescription)
        Panel1.Controls.Add(lblTaskName)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 44)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(450, 242)
        Panel1.TabIndex = 7
        ' 
        ' btnDeleteTask
        ' 
        btnDeleteTask.Anchor = AnchorStyles.None
        btnDeleteTask.Location = New Point(309, 198)
        btnDeleteTask.Name = "btnDeleteTask"
        btnDeleteTask.Size = New Size(75, 38)
        btnDeleteTask.TabIndex = 7
        btnDeleteTask.Text = "Delete"
        btnDeleteTask.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateTask
        ' 
        btnUpdateTask.Anchor = AnchorStyles.None
        btnUpdateTask.Location = New Point(224, 198)
        btnUpdateTask.Name = "btnUpdateTask"
        btnUpdateTask.Size = New Size(75, 38)
        btnUpdateTask.TabIndex = 6
        btnUpdateTask.Text = "Update"
        btnUpdateTask.UseVisualStyleBackColor = True
        ' 
        ' btnAddTask
        ' 
        btnAddTask.Anchor = AnchorStyles.None
        btnAddTask.Location = New Point(139, 198)
        btnAddTask.Name = "btnAddTask"
        btnAddTask.Size = New Size(75, 38)
        btnAddTask.TabIndex = 5
        btnAddTask.Text = "Add"
        btnAddTask.UseVisualStyleBackColor = True
        ' 
        ' dtDueDate
        ' 
        dtDueDate.Anchor = AnchorStyles.None
        dtDueDate.Location = New Point(139, 140)
        dtDueDate.Name = "dtDueDate"
        dtDueDate.Size = New Size(245, 23)
        dtDueDate.TabIndex = 3
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Anchor = AnchorStyles.None
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(139, 169)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(245, 23)
        cmbStatus.TabIndex = 4
        ' 
        ' cmbPriority
        ' 
        cmbPriority.Anchor = AnchorStyles.None
        cmbPriority.FormattingEnabled = True
        cmbPriority.Location = New Point(139, 111)
        cmbPriority.Name = "cmbPriority"
        cmbPriority.Size = New Size(245, 23)
        cmbPriority.TabIndex = 2
        ' 
        ' txtDescription
        ' 
        txtDescription.Anchor = AnchorStyles.None
        txtDescription.Location = New Point(139, 36)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(245, 69)
        txtDescription.TabIndex = 1
        ' 
        ' txtTaskName
        ' 
        txtTaskName.Anchor = AnchorStyles.None
        txtTaskName.Location = New Point(139, 7)
        txtTaskName.Name = "txtTaskName"
        txtTaskName.Size = New Size(245, 23)
        txtTaskName.TabIndex = 0
        ' 
        ' lblStatus
        ' 
        lblStatus.Anchor = AnchorStyles.None
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(66, 172)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(39, 15)
        lblStatus.TabIndex = 5
        lblStatus.Text = "Status"
        ' 
        ' lblDueDate
        ' 
        lblDueDate.Anchor = AnchorStyles.None
        lblDueDate.AutoSize = True
        lblDueDate.Location = New Point(66, 146)
        lblDueDate.Name = "lblDueDate"
        lblDueDate.Size = New Size(55, 15)
        lblDueDate.TabIndex = 6
        lblDueDate.Text = "Due Date"
        ' 
        ' lblPriority
        ' 
        lblPriority.Anchor = AnchorStyles.None
        lblPriority.AutoSize = True
        lblPriority.Location = New Point(66, 114)
        lblPriority.Name = "lblPriority"
        lblPriority.Size = New Size(45, 15)
        lblPriority.TabIndex = 7
        lblPriority.Text = "Priority"
        ' 
        ' lblDescription
        ' 
        lblDescription.Anchor = AnchorStyles.None
        lblDescription.AutoSize = True
        lblDescription.Location = New Point(66, 39)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(67, 15)
        lblDescription.TabIndex = 8
        lblDescription.Text = "Description"
        ' 
        ' lblTaskName
        ' 
        lblTaskName.Anchor = AnchorStyles.None
        lblTaskName.AutoSize = True
        lblTaskName.Location = New Point(66, 10)
        lblTaskName.Name = "lblTaskName"
        lblTaskName.Size = New Size(64, 15)
        lblTaskName.TabIndex = 9
        lblTaskName.Text = "Task Name"
        ' 
        ' lvTasks
        ' 
        lvTasks.Columns.AddRange(New ColumnHeader() {taskname, description, priority, duedate, status})
        lvTasks.Dock = DockStyle.Fill
        lvTasks.FullRowSelect = True
        lvTasks.GridLines = True
        lvTasks.Location = New Point(0, 286)
        lvTasks.Name = "lvTasks"
        lvTasks.Size = New Size(450, 114)
        lvTasks.TabIndex = 8
        lvTasks.TabStop = False
        lvTasks.UseCompatibleStateImageBehavior = False
        lvTasks.View = View.Details
        ' 
        ' taskname
        ' 
        taskname.Text = "Task Name"
        taskname.Width = 150
        ' 
        ' description
        ' 
        description.Text = "Description"
        description.Width = 200
        ' 
        ' priority
        ' 
        priority.Text = "Priority"
        priority.Width = 100
        ' 
        ' duedate
        ' 
        duedate.Text = "Due Date"
        duedate.Width = 150
        ' 
        ' status
        ' 
        status.Text = "Status"
        status.Width = 200
        ' 
        ' FormTaskManager
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(450, 400)
        Controls.Add(lvTasks)
        Controls.Add(Panel1)
        Controls.Add(lblTitle)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormTaskManager"
        Text = "Task Manager"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)


    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDeleteTask As Button
    Friend WithEvents btnUpdateTask As Button
    Friend WithEvents btnAddTask As Button
    Friend WithEvents dtDueDate As DateTimePicker
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents cmbPriority As ComboBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtTaskName As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblDueDate As Label
    Friend WithEvents lblPriority As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblTaskName As Label
    Friend WithEvents lvTasks As ListView
    Friend WithEvents taskname As ColumnHeader
    Friend WithEvents description As ColumnHeader
    Friend WithEvents priority As ColumnHeader
    Friend WithEvents duedate As ColumnHeader
    Friend WithEvents status As ColumnHeader

End Class
