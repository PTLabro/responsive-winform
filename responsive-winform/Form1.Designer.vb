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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        sidePanel = New Panel()
        ExitButton = New Button()
        Button2 = New Button()
        Button1 = New Button()
        MenuPanel2 = New Panel()
        SubMenu6 = New Button()
        SubMenu5 = New Button()
        SubMenu4 = New Button()
        Menu2 = New Button()
        MenuPanel1 = New Panel()
        SubMenu3 = New Button()
        SubMenu2 = New Button()
        SubMenu1 = New Button()
        Menu1 = New Button()
        Home = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        mainChildForm = New Panel()
        PictureBox2 = New PictureBox()
        sidePanel.SuspendLayout()
        MenuPanel2.SuspendLayout()
        MenuPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        mainChildForm.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' sidePanel
        ' 
        sidePanel.AutoScroll = True
        sidePanel.BackColor = Color.FromArgb(CByte(237), CByte(28), CByte(36))
        sidePanel.Controls.Add(ExitButton)
        sidePanel.Controls.Add(Button2)
        sidePanel.Controls.Add(Button1)
        sidePanel.Controls.Add(MenuPanel2)
        sidePanel.Controls.Add(Menu2)
        sidePanel.Controls.Add(MenuPanel1)
        sidePanel.Controls.Add(Menu1)
        sidePanel.Controls.Add(Home)
        sidePanel.Controls.Add(Panel1)
        sidePanel.Dock = DockStyle.Left
        sidePanel.Location = New Point(0, 0)
        sidePanel.Name = "sidePanel"
        sidePanel.Size = New Size(201, 461)
        sidePanel.TabIndex = 0
        ' 
        ' ExitButton
        ' 
        ExitButton.BackColor = Color.FromArgb(CByte(237), CByte(28), CByte(36))
        ExitButton.BackgroundImage = CType(resources.GetObject("ExitButton.BackgroundImage"), Image)
        ExitButton.BackgroundImageLayout = ImageLayout.None
        ExitButton.Dock = DockStyle.Bottom
        ExitButton.FlatAppearance.BorderSize = 0
        ExitButton.FlatStyle = FlatStyle.Flat
        ExitButton.ForeColor = Color.White
        ExitButton.Location = New Point(0, 510)
        ExitButton.Name = "ExitButton"
        ExitButton.Padding = New Padding(25, 0, 0, 0)
        ExitButton.Size = New Size(184, 35)
        ExitButton.TabIndex = 8
        ExitButton.Text = "Exit"
        ExitButton.TextAlign = ContentAlignment.MiddleLeft
        ExitButton.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(237), CByte(28), CByte(36))
        Button2.Dock = DockStyle.Top
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.White
        Button2.Location = New Point(0, 475)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(10, 0, 0, 0)
        Button2.Size = New Size(184, 35)
        Button2.TabIndex = 7
        Button2.Text = "GotoForm3"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(237), CByte(28), CByte(36))
        Button1.Dock = DockStyle.Top
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(0, 440)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(10, 0, 0, 0)
        Button1.Size = New Size(184, 35)
        Button1.TabIndex = 6
        Button1.Text = "GotoForm2"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' MenuPanel2
        ' 
        MenuPanel2.BackColor = Color.White
        MenuPanel2.Controls.Add(SubMenu6)
        MenuPanel2.Controls.Add(SubMenu5)
        MenuPanel2.Controls.Add(SubMenu4)
        MenuPanel2.Dock = DockStyle.Top
        MenuPanel2.Location = New Point(0, 335)
        MenuPanel2.Name = "MenuPanel2"
        MenuPanel2.Size = New Size(184, 105)
        MenuPanel2.TabIndex = 5
        ' 
        ' SubMenu6
        ' 
        SubMenu6.BackColor = Color.LightGray
        SubMenu6.Dock = DockStyle.Top
        SubMenu6.FlatAppearance.BorderSize = 0
        SubMenu6.FlatStyle = FlatStyle.Flat
        SubMenu6.ForeColor = Color.Black
        SubMenu6.Location = New Point(0, 70)
        SubMenu6.Name = "SubMenu6"
        SubMenu6.Padding = New Padding(35, 0, 0, 0)
        SubMenu6.Size = New Size(184, 35)
        SubMenu6.TabIndex = 2
        SubMenu6.Text = "SubMenu6"
        SubMenu6.TextAlign = ContentAlignment.MiddleLeft
        SubMenu6.UseVisualStyleBackColor = False
        ' 
        ' SubMenu5
        ' 
        SubMenu5.BackColor = Color.LightGray
        SubMenu5.Dock = DockStyle.Top
        SubMenu5.FlatAppearance.BorderSize = 0
        SubMenu5.FlatStyle = FlatStyle.Flat
        SubMenu5.ForeColor = Color.Black
        SubMenu5.Location = New Point(0, 35)
        SubMenu5.Name = "SubMenu5"
        SubMenu5.Padding = New Padding(35, 0, 0, 0)
        SubMenu5.Size = New Size(184, 35)
        SubMenu5.TabIndex = 1
        SubMenu5.Text = "SubMenu5"
        SubMenu5.TextAlign = ContentAlignment.MiddleLeft
        SubMenu5.UseVisualStyleBackColor = False
        ' 
        ' SubMenu4
        ' 
        SubMenu4.BackColor = Color.LightGray
        SubMenu4.Dock = DockStyle.Top
        SubMenu4.FlatAppearance.BorderSize = 0
        SubMenu4.FlatStyle = FlatStyle.Flat
        SubMenu4.ForeColor = Color.Black
        SubMenu4.Location = New Point(0, 0)
        SubMenu4.Name = "SubMenu4"
        SubMenu4.Padding = New Padding(35, 0, 0, 0)
        SubMenu4.Size = New Size(184, 35)
        SubMenu4.TabIndex = 0
        SubMenu4.Text = "SubMenu4"
        SubMenu4.TextAlign = ContentAlignment.MiddleLeft
        SubMenu4.UseVisualStyleBackColor = False
        ' 
        ' Menu2
        ' 
        Menu2.Dock = DockStyle.Top
        Menu2.FlatAppearance.BorderSize = 0
        Menu2.FlatStyle = FlatStyle.Flat
        Menu2.ForeColor = Color.White
        Menu2.Location = New Point(0, 300)
        Menu2.Name = "Menu2"
        Menu2.Padding = New Padding(10, 0, 0, 0)
        Menu2.Size = New Size(184, 35)
        Menu2.TabIndex = 4
        Menu2.Text = "Menu2"
        Menu2.TextAlign = ContentAlignment.MiddleLeft
        Menu2.UseVisualStyleBackColor = True
        ' 
        ' MenuPanel1
        ' 
        MenuPanel1.BackColor = Color.White
        MenuPanel1.Controls.Add(SubMenu3)
        MenuPanel1.Controls.Add(SubMenu2)
        MenuPanel1.Controls.Add(SubMenu1)
        MenuPanel1.Dock = DockStyle.Top
        MenuPanel1.Location = New Point(0, 195)
        MenuPanel1.Name = "MenuPanel1"
        MenuPanel1.Size = New Size(184, 105)
        MenuPanel1.TabIndex = 3
        ' 
        ' SubMenu3
        ' 
        SubMenu3.BackColor = Color.LightGray
        SubMenu3.Dock = DockStyle.Top
        SubMenu3.FlatAppearance.BorderSize = 0
        SubMenu3.FlatStyle = FlatStyle.Flat
        SubMenu3.ForeColor = Color.Black
        SubMenu3.Location = New Point(0, 70)
        SubMenu3.Name = "SubMenu3"
        SubMenu3.Padding = New Padding(35, 0, 0, 0)
        SubMenu3.Size = New Size(184, 35)
        SubMenu3.TabIndex = 2
        SubMenu3.Text = "SubMenu3"
        SubMenu3.TextAlign = ContentAlignment.MiddleLeft
        SubMenu3.UseVisualStyleBackColor = False
        ' 
        ' SubMenu2
        ' 
        SubMenu2.BackColor = Color.LightGray
        SubMenu2.Dock = DockStyle.Top
        SubMenu2.FlatAppearance.BorderSize = 0
        SubMenu2.FlatStyle = FlatStyle.Flat
        SubMenu2.ForeColor = Color.Black
        SubMenu2.Location = New Point(0, 35)
        SubMenu2.Name = "SubMenu2"
        SubMenu2.Padding = New Padding(35, 0, 0, 0)
        SubMenu2.Size = New Size(184, 35)
        SubMenu2.TabIndex = 1
        SubMenu2.Text = "SubMenu2"
        SubMenu2.TextAlign = ContentAlignment.MiddleLeft
        SubMenu2.UseVisualStyleBackColor = False
        ' 
        ' SubMenu1
        ' 
        SubMenu1.BackColor = Color.LightGray
        SubMenu1.Dock = DockStyle.Top
        SubMenu1.FlatAppearance.BorderSize = 0
        SubMenu1.FlatStyle = FlatStyle.Flat
        SubMenu1.ForeColor = Color.Black
        SubMenu1.Location = New Point(0, 0)
        SubMenu1.Name = "SubMenu1"
        SubMenu1.Padding = New Padding(35, 0, 0, 0)
        SubMenu1.Size = New Size(184, 35)
        SubMenu1.TabIndex = 0
        SubMenu1.Text = "SubMenu1"
        SubMenu1.TextAlign = ContentAlignment.MiddleLeft
        SubMenu1.UseVisualStyleBackColor = False
        ' 
        ' Menu1
        ' 
        Menu1.Dock = DockStyle.Top
        Menu1.FlatAppearance.BorderSize = 0
        Menu1.FlatStyle = FlatStyle.Flat
        Menu1.ForeColor = Color.White
        Menu1.Location = New Point(0, 160)
        Menu1.Name = "Menu1"
        Menu1.Padding = New Padding(10, 0, 0, 0)
        Menu1.Size = New Size(184, 35)
        Menu1.TabIndex = 2
        Menu1.Text = "Menu1"
        Menu1.TextAlign = ContentAlignment.MiddleLeft
        Menu1.UseVisualStyleBackColor = True
        ' 
        ' Home
        ' 
        Home.BackColor = Color.FromArgb(CByte(237), CByte(28), CByte(36))
        Home.Dock = DockStyle.Top
        Home.FlatAppearance.BorderSize = 0
        Home.FlatStyle = FlatStyle.Flat
        Home.ForeColor = Color.White
        Home.Location = New Point(0, 125)
        Home.Name = "Home"
        Home.Padding = New Padding(10, 0, 0, 0)
        Home.Size = New Size(184, 35)
        Home.TabIndex = 1
        Home.Text = "Home"
        Home.TextAlign = ContentAlignment.MiddleLeft
        Home.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(184, 125)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 121)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(184, 4)
        Panel2.TabIndex = 1
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(0, 0)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(184, 10)
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(0, 0)
        PictureBox3.Margin = New Padding(0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(184, 2)
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(48, 36)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(95, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' mainChildForm
        ' 
        mainChildForm.Controls.Add(PictureBox2)
        mainChildForm.Location = New Point(201, 0)
        mainChildForm.Name = "mainChildForm"
        mainChildForm.Size = New Size(433, 461)
        mainChildForm.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(116, 130)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(200, 200)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(634, 461)
        Controls.Add(mainChildForm)
        Controls.Add(sidePanel)
        Font = New Font("Segoe UI", 10F)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "City of Taguig"
        sidePanel.ResumeLayout(False)
        MenuPanel2.ResumeLayout(False)
        MenuPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        mainChildForm.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents sidePanel As Panel
    Friend WithEvents Home As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuPanel1 As Panel
    Friend WithEvents SubMenu3 As Button
    Friend WithEvents SubMenu2 As Button
    Friend WithEvents SubMenu1 As Button
    Friend WithEvents Menu1 As Button
    Friend WithEvents Menu2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents mainChildForm As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MenuPanel2 As Panel
    Friend WithEvents SubMenu6 As Button
    Friend WithEvents SubMenu5 As Button
    Friend WithEvents SubMenu4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox

End Class
