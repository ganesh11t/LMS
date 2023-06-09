<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        Panel1 = New Panel()
        register = New Button()
        login = New Button()
        Label1 = New Label()
        password = New Label()
        username = New Label()
        passwordtxt = New TextBox()
        usernametxt = New TextBox()
        showpassword = New CheckBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(showpassword)
        Panel1.Controls.Add(register)
        Panel1.Controls.Add(login)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(password)
        Panel1.Controls.Add(username)
        Panel1.Controls.Add(passwordtxt)
        Panel1.Controls.Add(usernametxt)
        Panel1.Location = New Point(433, 20)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(305, 433)
        Panel1.TabIndex = 0
        ' 
        ' register
        ' 
        register.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        register.ForeColor = SystemColors.ControlText
        register.Location = New Point(89, 357)
        register.Name = "register"
        register.Size = New Size(133, 27)
        register.TabIndex = 6
        register.Text = "Register"
        register.UseVisualStyleBackColor = True
        ' 
        ' login
        ' 
        login.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        login.Location = New Point(89, 299)
        login.Name = "login"
        login.Size = New Size(133, 27)
        login.TabIndex = 5
        login.Text = "Login"
        login.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(89, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 32)
        Label1.TabIndex = 4
        Label1.Text = "Login Panel"
        ' 
        ' password
        ' 
        password.AutoSize = True
        password.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        password.Location = New Point(39, 208)
        password.Name = "password"
        password.Size = New Size(96, 25)
        password.TabIndex = 3
        password.Text = "Password"
        ' 
        ' username
        ' 
        username.AutoSize = True
        username.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        username.Location = New Point(34, 155)
        username.Name = "username"
        username.Size = New Size(101, 25)
        username.TabIndex = 2
        username.Text = "Username"
        ' 
        ' passwordtxt
        ' 
        passwordtxt.Location = New Point(147, 209)
        passwordtxt.Name = "passwordtxt"
        passwordtxt.Size = New Size(114, 23)
        passwordtxt.TabIndex = 1
        ' 
        ' usernametxt
        ' 
        usernametxt.Location = New Point(147, 155)
        usernametxt.Name = "usernametxt"
        usernametxt.Size = New Size(114, 23)
        usernametxt.TabIndex = 0
        ' 
        ' showpassword
        ' 
        showpassword.AutoSize = True
        showpassword.Location = New Point(102, 257)
        showpassword.Name = "showpassword"
        showpassword.Size = New Size(108, 19)
        showpassword.TabIndex = 7
        showpassword.Text = "Show Password"
        showpassword.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(749, 467)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents passwordtxt As TextBox
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents password As Label
    Friend WithEvents username As Label
    Friend WithEvents register As Button
    Friend WithEvents login As Button
    Friend WithEvents showpassword As CheckBox
End Class
