Public Class Form1

    Dim selUser As String = " "

    Private Sub CreateUserButton_Click(sender As Object, e As EventArgs)
        Dim id As Integer
        Dim name As String
        Dim address As String

        Dim x As String = id & "," & name & "," & address

        Dim wr As New System.IO.StreamWriter("user.txt", True)
        wr.WriteLine(x)
        wr.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        selUser = ListOfUsers.SelectedItem
        TabControl1.SelectedTab = tabCreateAppointment
        Dim s() As String = selUser.Split(",")

        TextBox6.Text = s(1)


    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        Dim name As String = TextBox6.Text
        Dim date1 As String = TextBox2.Text
        Dim time1 As String = TextBox3.Text

        Dim x As String = name & "," & date1 & "," & time1

        Dim wr As New System.IO.StreamWriter("app.txt", True)
        wr.WriteLine(x)
        wr.Close()

        TabControl1.SelectedTab = tabViewAppointment
        MessageBox.Show("When you click the button you will" & " be sent to the view appointments tab" & " click below the box to view appointments if any")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fd() As String = IO.File.ReadAllLines("user.txt")
        For Each line In fd
            ListOfUsers.Items.Add(line)
        Next
        MessageBox.Show("Click a user to select before pressing a button")
    End Sub



    Private Sub tabViewAppointment_MouseClick(sender As Object, e As MouseEventArgs) Handles tabViewAppointment.MouseClick
        Dim fd() As String = IO.File.ReadAllLines("app.txt")
        For Each line In fd
            ListBox1.Items.Add(line)
        Next
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedTab = tabViewAppointment
        MessageBox.Show("When you click the button you will" & " be sent to the view appointments tab" & " click below the box to view appointments if any")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Developed in Fall 2019 by" & vbCrLf & vbCrLf & "- Logan Craig" & vbCrLf & "- Gabriel Long" & vbCrLf & "- Luke Fleming" & vbCrLf & "- Daniel Kakwata" & vbCrLf & "- Gartrel Barnes" & vbCrLf & "- Gary Locklear" & vbCrLf & vbCrLf &
                        "This application is released under the terms of GNU General Public license version 3.0. The software comes with absolutely nowarranty.", "About This Application")
    End Sub
End Class
