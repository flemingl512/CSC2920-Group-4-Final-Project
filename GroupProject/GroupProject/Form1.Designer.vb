<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.tabCreateAppointment = New System.Windows.Forms.TabPage()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.CreateAnAppLabel = New System.Windows.Forms.Label()
        Me.tabViewAppointment = New System.Windows.Forms.TabPage()
        Me.CreateAppointmentButton = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.tabHome = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.ViewAppointmentButton = New System.Windows.Forms.Button()
        Me.CreateUserSend = New System.Windows.Forms.Button()
        Me.ListOfUsers = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabCreateAppointment.SuspendLayout()
        Me.tabViewAppointment.SuspendLayout()
        Me.tabHome.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabCreateAppointment
        '
        Me.tabCreateAppointment.Controls.Add(Me.TextBox6)
        Me.tabCreateAppointment.Controls.Add(Me.TextBox3)
        Me.tabCreateAppointment.Controls.Add(Me.TextBox2)
        Me.tabCreateAppointment.Controls.Add(Me.ReturnButton)
        Me.tabCreateAppointment.Controls.Add(Me.timeLabel)
        Me.tabCreateAppointment.Controls.Add(Me.dateLabel)
        Me.tabCreateAppointment.Controls.Add(Me.CreateAnAppLabel)
        Me.tabCreateAppointment.Location = New System.Drawing.Point(4, 29)
        Me.tabCreateAppointment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabCreateAppointment.Name = "tabCreateAppointment"
        Me.tabCreateAppointment.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabCreateAppointment.Size = New System.Drawing.Size(992, 621)
        Me.tabCreateAppointment.TabIndex = 3
        Me.tabCreateAppointment.Text = "Create Appointment "
        Me.tabCreateAppointment.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(327, 59)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(534, 26)
        Me.TextBox6.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(327, 306)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(534, 26)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(327, 182)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(534, 26)
        Me.TextBox2.TabIndex = 4
        '
        'ReturnButton
        '
        Me.ReturnButton.Location = New System.Drawing.Point(327, 402)
        Me.ReturnButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(534, 62)
        Me.ReturnButton.TabIndex = 6
        Me.ReturnButton.Text = "Save and Return"
        Me.ReturnButton.UseVisualStyleBackColor = True
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.Location = New System.Drawing.Point(216, 306)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(39, 20)
        Me.timeLabel.TabIndex = 2
        Me.timeLabel.Text = "time"
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Location = New System.Drawing.Point(216, 189)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(45, 20)
        Me.dateLabel.TabIndex = 1
        Me.dateLabel.Text = "date "
        '
        'CreateAnAppLabel
        '
        Me.CreateAnAppLabel.AutoSize = True
        Me.CreateAnAppLabel.Location = New System.Drawing.Point(76, 59)
        Me.CreateAnAppLabel.Name = "CreateAnAppLabel"
        Me.CreateAnAppLabel.Size = New System.Drawing.Size(196, 20)
        Me.CreateAnAppLabel.TabIndex = 0
        Me.CreateAnAppLabel.Text = "create an appointment for "
        '
        'tabViewAppointment
        '
        Me.tabViewAppointment.Controls.Add(Me.CreateAppointmentButton)
        Me.tabViewAppointment.Controls.Add(Me.ListBox1)
        Me.tabViewAppointment.Location = New System.Drawing.Point(4, 29)
        Me.tabViewAppointment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabViewAppointment.Name = "tabViewAppointment"
        Me.tabViewAppointment.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabViewAppointment.Size = New System.Drawing.Size(992, 621)
        Me.tabViewAppointment.TabIndex = 1
        Me.tabViewAppointment.Text = "View Appointment"
        Me.tabViewAppointment.UseVisualStyleBackColor = True
        '
        'CreateAppointmentButton
        '
        Me.CreateAppointmentButton.Location = New System.Drawing.Point(27, 1054)
        Me.CreateAppointmentButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CreateAppointmentButton.Name = "CreateAppointmentButton"
        Me.CreateAppointmentButton.Size = New System.Drawing.Size(2464, 119)
        Me.CreateAppointmentButton.TabIndex = 1
        Me.CreateAppointmentButton.Text = "Create Appointment "
        Me.CreateAppointmentButton.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Items.AddRange(New Object() {"Existing Appointments:"})
        Me.ListBox1.Location = New System.Drawing.Point(27, 36)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(965, 444)
        Me.ListBox1.TabIndex = 0
        '
        'tabHome
        '
        Me.tabHome.Controls.Add(Me.Button3)
        Me.tabHome.Controls.Add(Me.Button2)
        Me.tabHome.Controls.Add(Me.Button1)
        Me.tabHome.Controls.Add(Me.AboutButton)
        Me.tabHome.Controls.Add(Me.ViewAppointmentButton)
        Me.tabHome.Controls.Add(Me.CreateUserSend)
        Me.tabHome.Controls.Add(Me.ListOfUsers)
        Me.tabHome.Controls.Add(Me.Label1)
        Me.tabHome.Location = New System.Drawing.Point(4, 29)
        Me.tabHome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabHome.Name = "tabHome"
        Me.tabHome.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabHome.Size = New System.Drawing.Size(992, 621)
        Me.tabHome.TabIndex = 0
        Me.tabHome.Text = "Home"
        Me.tabHome.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(429, 515)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 55)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "About"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(787, 515)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(172, 55)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "view app"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(43, 515)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 55)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "create app"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AboutButton
        '
        Me.AboutButton.Location = New System.Drawing.Point(983, 1070)
        Me.AboutButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(458, 98)
        Me.AboutButton.TabIndex = 4
        Me.AboutButton.Text = "About "
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'ViewAppointmentButton
        '
        Me.ViewAppointmentButton.Location = New System.Drawing.Point(2164, 1070)
        Me.ViewAppointmentButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ViewAppointmentButton.Name = "ViewAppointmentButton"
        Me.ViewAppointmentButton.Size = New System.Drawing.Size(314, 98)
        Me.ViewAppointmentButton.TabIndex = 3
        Me.ViewAppointmentButton.Text = "View Appointment"
        Me.ViewAppointmentButton.UseVisualStyleBackColor = True
        '
        'CreateUserSend
        '
        Me.CreateUserSend.Location = New System.Drawing.Point(54, 1070)
        Me.CreateUserSend.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CreateUserSend.Name = "CreateUserSend"
        Me.CreateUserSend.Size = New System.Drawing.Size(346, 98)
        Me.CreateUserSend.TabIndex = 2
        Me.CreateUserSend.Text = "Create User "
        Me.CreateUserSend.UseVisualStyleBackColor = True
        '
        'ListOfUsers
        '
        Me.ListOfUsers.FormattingEnabled = True
        Me.ListOfUsers.ItemHeight = 20
        Me.ListOfUsers.Location = New System.Drawing.Point(43, 46)
        Me.ListOfUsers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListOfUsers.Name = "ListOfUsers"
        Me.ListOfUsers.Size = New System.Drawing.Size(916, 444)
        Me.ListOfUsers.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose User "
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabHome)
        Me.TabControl1.Controls.Add(Me.tabViewAppointment)
        Me.TabControl1.Controls.Add(Me.tabCreateAppointment)
        Me.TabControl1.Location = New System.Drawing.Point(25, 28)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1000, 654)
        Me.TabControl1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 712)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tabCreateAppointment.ResumeLayout(False)
        Me.tabCreateAppointment.PerformLayout()
        Me.tabViewAppointment.ResumeLayout(False)
        Me.tabHome.ResumeLayout(False)
        Me.tabHome.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabCreateAppointment As TabPage
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ReturnButton As Button
    Friend WithEvents timeLabel As Label
    Friend WithEvents dateLabel As Label
    Friend WithEvents CreateAnAppLabel As Label
    Friend WithEvents tabViewAppointment As TabPage
    Friend WithEvents CreateAppointmentButton As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents tabHome As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents AboutButton As Button
    Friend WithEvents ViewAppointmentButton As Button
    Friend WithEvents CreateUserSend As Button
    Friend WithEvents ListOfUsers As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Button3 As Button
End Class
