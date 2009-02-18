<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.cmdExit = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.cmdCopyIP = New System.Windows.Forms.Button
        Me.txtTwitterName = New System.Windows.Forms.TextBox
        Me.txtTwitterPassword = New System.Windows.Forms.TextBox
        Me.grpGroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.lblLabel1 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.lblLabel3 = New System.Windows.Forms.Label
        Me.picPictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmdTweet = New System.Windows.Forms.Button
        Me.lstListBox1 = New System.Windows.Forms.ListBox
        Me.Panel1.SuspendLayout()
        Me.grpGroupBox1.SuspendLayout()
        CType(Me.picPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 217)
        Me.TextBox1.MaxLength = 140
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(349, 37)
        Me.TextBox1.TabIndex = 1
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(251, 262)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(110, 42)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(374, 50)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "TweetMyUptime"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "My External IP is : "
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(128, 195)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(55, 16)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Refresh"
        '
        'cmdCopyIP
        '
        Me.cmdCopyIP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCopyIP.Location = New System.Drawing.Point(251, 194)
        Me.cmdCopyIP.Name = "cmdCopyIP"
        Me.cmdCopyIP.Size = New System.Drawing.Size(18, 18)
        Me.cmdCopyIP.TabIndex = 7
        Me.cmdCopyIP.Text = "c"
        Me.cmdCopyIP.UseCompatibleTextRendering = True
        Me.cmdCopyIP.UseVisualStyleBackColor = True
        '
        'txtTwitterName
        '
        Me.txtTwitterName.Location = New System.Drawing.Point(57, 24)
        Me.txtTwitterName.Name = "txtTwitterName"
        Me.txtTwitterName.Size = New System.Drawing.Size(119, 20)
        Me.txtTwitterName.TabIndex = 8
        '
        'txtTwitterPassword
        '
        Me.txtTwitterPassword.Location = New System.Drawing.Point(57, 67)
        Me.txtTwitterPassword.Name = "txtTwitterPassword"
        Me.txtTwitterPassword.Size = New System.Drawing.Size(119, 20)
        Me.txtTwitterPassword.TabIndex = 9
        '
        'grpGroupBox1
        '
        Me.grpGroupBox1.Controls.Add(Me.btnClear)
        Me.grpGroupBox1.Controls.Add(Me.lblLabel1)
        Me.grpGroupBox1.Controls.Add(Me.btnSave)
        Me.grpGroupBox1.Controls.Add(Me.lblLabel3)
        Me.grpGroupBox1.Controls.Add(Me.txtTwitterPassword)
        Me.grpGroupBox1.Controls.Add(Me.txtTwitterName)
        Me.grpGroupBox1.Location = New System.Drawing.Point(179, 55)
        Me.grpGroupBox1.Name = "grpGroupBox1"
        Me.grpGroupBox1.Size = New System.Drawing.Size(182, 135)
        Me.grpGroupBox1.TabIndex = 10
        Me.grpGroupBox1.TabStop = False
        Me.grpGroupBox1.Text = "Twitter Login Credentials"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(101, 106)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(3, 71)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(53, 13)
        Me.lblLabel1.TabIndex = 11
        Me.lblLabel1.Text = "Password"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(6, 106)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Login/save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Location = New System.Drawing.Point(1, 28)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(55, 13)
        Me.lblLabel3.TabIndex = 10
        Me.lblLabel3.Text = "Username"
        '
        'picPictureBox1
        '
        Me.picPictureBox1.Image = Global.TweetMyUptime.My.Resources.Resources.icon_c
        Me.picPictureBox1.Location = New System.Drawing.Point(11, 62)
        Me.picPictureBox1.Name = "picPictureBox1"
        Me.picPictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.picPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picPictureBox1.TabIndex = 11
        Me.picPictureBox1.TabStop = False
        '
        'cmdTweet
        '
        Me.cmdTweet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.cmdTweet.Image = CType(resources.GetObject("cmdTweet.Image"), System.Drawing.Image)
        Me.cmdTweet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTweet.Location = New System.Drawing.Point(12, 261)
        Me.cmdTweet.Name = "cmdTweet"
        Me.cmdTweet.Size = New System.Drawing.Size(110, 42)
        Me.cmdTweet.TabIndex = 0
        Me.cmdTweet.Text = "Tweet"
        Me.cmdTweet.UseVisualStyleBackColor = True
        '
        'lstListBox1
        '
        Me.lstListBox1.FormattingEnabled = True
        Me.lstListBox1.Location = New System.Drawing.Point(12, 310)
        Me.lstListBox1.Name = "lstListBox1"
        Me.lstListBox1.Size = New System.Drawing.Size(348, 108)
        Me.lstListBox1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(372, 427)
        Me.Controls.Add(Me.lstListBox1)
        Me.Controls.Add(Me.picPictureBox1)
        Me.Controls.Add(Me.cmdCopyIP)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmdTweet)
        Me.Controls.Add(Me.grpGroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TweetMyUptime"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpGroupBox1.ResumeLayout(False)
        Me.grpGroupBox1.PerformLayout()
        CType(Me.picPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdTweet As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents cmdCopyIP As System.Windows.Forms.Button
    Friend WithEvents txtTwitterName As System.Windows.Forms.TextBox
    Friend WithEvents txtTwitterPassword As System.Windows.Forms.TextBox
    Friend WithEvents grpGroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLabel3 As System.Windows.Forms.Label
    Friend WithEvents lblLabel1 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents picPictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lstListBox1 As System.Windows.Forms.ListBox

End Class
