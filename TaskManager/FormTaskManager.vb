Public Class FormTaskManager
    Private Sub FillCBX()
        cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList

        cmbPriority.Items.AddRange({"High", "Medium", "Low"})
        cmbStatus.Items.AddRange({"To Do", "In Progress", "Done"})

        cmbPriority.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1

    End Sub
    Private Sub ClearControls()
        txtTaskName.Clear()
        txtDescription.Clear()
        cmbPriority.SelectedIndex = -1
        dtDueDate.Value = DateTime.Now
        cmbStatus.SelectedIndex = -1
    End Sub
    Private Sub PopulateListView()
        lvTasks.Items.Clear()
        Dim TaskTable As DataTable = TaskRepository.GetAllTasks()

        For Each row As DataRow In TaskTable.Rows
            Dim item As New ListViewItem(row("TaskName").ToString())
            item.SubItems.Add(row("Description").ToString())
            item.SubItems.Add(row("Priority").ToString())
            item.SubItems.Add(row("DueDate").ToString())
            item.SubItems.Add(row("Status").ToString())

            ' Store the TaskID in the Tag property of the ListViewItem
            item.Tag = row("Id")

            lvTasks.Items.Add(item)
        Next

    End Sub
    Private Sub FormTaskManager_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillCBX()
        PopulateListView()

    End Sub
    Private Sub btnAddTask_Click(sender As Object, e As EventArgs) Handles btnAddTask.Click

        If validatedata() Then
            TaskRepository.AddTask(txtTaskName.Text, txtDescription.Text, cmbPriority.Text, dtDueDate.Value, cmbStatus.Text)
            ClearControls()
        End If

        PopulateListView()
    End Sub
    Private Function validatedata() As Boolean
        Dim b As Boolean
        If String.IsNullOrEmpty(txtTaskName.Text) Or String.IsNullOrEmpty(txtDescription.Text) Or String.IsNullOrEmpty(cmbPriority.Text) Or String.IsNullOrEmpty(cmbStatus.Text) Or String.IsNullOrEmpty(dtDueDate.Value.ToString) Then
            b = False
            MessageBox.Show("All Fields are required")
        Else
            b = True
        End If
        Return b
    End Function
    Private Sub btnDeleteTask_Click(sender As Object, e As EventArgs) Handles btnDeleteTask.Click
        If lvTasks.SelectedItems.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected tasks?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                For Each selectedItem As ListViewItem In lvTasks.SelectedItems
                    Dim taskID As Integer = CInt(selectedItem.Tag)
                    TaskRepository.DeleteTask(taskID)
                Next

                PopulateListView()
            End If
        Else
            MessageBox.Show("Please select one or more tasks to delete.", "Delete Task", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnUpdateTask_Click(sender As Object, e As EventArgs) Handles btnUpdateTask.Click
        If lvTasks.SelectedItems.Count > 0 Then
            Dim selectedTask As ListViewItem = lvTasks.SelectedItems(0)
            Dim taskID As Integer = CInt(selectedTask.Tag) ' Retrieve TaskID from Tag property

            If validatedata() Then
                TaskRepository.UpdateTask(taskID, txtTaskName.Text, txtDescription.Text, cmbPriority.Text, dtDueDate.Value, cmbStatus.Text)
                PopulateListView()
            End If
        Else
            MessageBox.Show("Please select a task to update.", "Update Task", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub lvTasks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvTasks.SelectedIndexChanged
        If lvTasks.SelectedItems.Count > 0 Then
            Dim selectedTask As ListViewItem = lvTasks.SelectedItems(0)
            txtTaskName.Text = selectedTask.SubItems(0).Text
            txtDescription.Text = selectedTask.SubItems(1).Text
            cmbPriority.Text = selectedTask.SubItems(2).Text
            dtDueDate.Value = DateTime.Parse(selectedTask.SubItems(3).Text)
            cmbStatus.Text = selectedTask.SubItems(4).Text
        Else
            ' Clear controls if no item is selected
            ClearControls()
        End If
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs)
        PopulateListView()
    End Sub

End Class
