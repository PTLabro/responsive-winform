﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        sidePanel = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        Button1Panel = New Panel()
        SubMenu3 = New Button()
        SubMenu2 = New Button()
        SubMenu1 = New Button()
        Menu1 = New Button()
        Home = New Button()
        Panel1 = New Panel()
        sidePanel.SuspendLayout()
        Button1Panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' sidePanel
        ' 
        sidePanel.AutoScroll = True
        sidePanel.BackColor = Color.FromArgb(CByte(237), CByte(28), CByte(36))
        sidePanel.Controls.Add(Button2)
        sidePanel.Controls.Add(Button1)
        sidePanel.Controls.Add(Button1Panel)
        sidePanel.Controls.Add(Menu1)
        sidePanel.Controls.Add(Home)
        sidePanel.Controls.Add(Panel1)
        sidePanel.Dock = DockStyle.Left
        sidePanel.Location = New Point(0, 0)
        sidePanel.Name = "sidePanel"
        sidePanel.Size = New Size(250, 653)
        sidePanel.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.Dock = DockStyle.Top
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.White
        Button2.Location = New Point(0, 384)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(10, 0, 0, 0)
        Button2.Size = New Size(250, 45)
        Button2.TabIndex = 5
        Button2.Text = "Button2"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Dock = DockStyle.Top
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(0, 339)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(10, 0, 0, 0)
        Button1.Size = New Size(250, 45)
        Button1.TabIndex = 4
        Button1.Text = "Button1"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button1Panel
        ' 
        Button1Panel.BackColor = Color.White
        Button1Panel.Controls.Add(SubMenu3)
        Button1Panel.Controls.Add(SubMenu2)
        Button1Panel.Controls.Add(SubMenu1)
        Button1Panel.Dock = DockStyle.Top
        Button1Panel.Location = New Point(0, 215)
        Button1Panel.Name = "Button1Panel"
        Button1Panel.Size = New Size(250, 124)
        Button1Panel.TabIndex = 3
        ' 
        ' SubMenu3
        ' 
        SubMenu3.BackColor = Color.Silver
        SubMenu3.Dock = DockStyle.Top
        SubMenu3.FlatAppearance.BorderSize = 0
        SubMenu3.FlatStyle = FlatStyle.Flat
        SubMenu3.ForeColor = Color.White
        SubMenu3.Location = New Point(0, 80)
        SubMenu3.Name = "SubMenu3"
        SubMenu3.Padding = New Padding(35, 0, 0, 0)
        SubMenu3.Size = New Size(250, 40)
        SubMenu3.TabIndex = 2
        SubMenu3.Text = "SubMenu3"
        SubMenu3.TextAlign = ContentAlignment.MiddleLeft
        SubMenu3.UseVisualStyleBackColor = False
        ' 
        ' SubMenu2
        ' 
        SubMenu2.BackColor = Color.Silver
        SubMenu2.Dock = DockStyle.Top
        SubMenu2.FlatAppearance.BorderSize = 0
        SubMenu2.FlatStyle = FlatStyle.Flat
        SubMenu2.ForeColor = Color.White
        SubMenu2.Location = New Point(0, 40)
        SubMenu2.Name = "SubMenu2"
        SubMenu2.Padding = New Padding(35, 0, 0, 0)
        SubMenu2.Size = New Size(250, 40)
        SubMenu2.TabIndex = 1
        SubMenu2.Text = "SubMenu2"
        SubMenu2.TextAlign = ContentAlignment.MiddleLeft
        SubMenu2.UseVisualStyleBackColor = False
        ' 
        ' SubMenu1
        ' 
        SubMenu1.BackColor = Color.Silver
        SubMenu1.Dock = DockStyle.Top
        SubMenu1.FlatAppearance.BorderSize = 0
        SubMenu1.FlatStyle = FlatStyle.Flat
        SubMenu1.ForeColor = Color.White
        SubMenu1.Location = New Point(0, 0)
        SubMenu1.Name = "SubMenu1"
        SubMenu1.Padding = New Padding(35, 0, 0, 0)
        SubMenu1.Size = New Size(250, 40)
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
        Menu1.Location = New Point(0, 170)
        Menu1.Name = "Menu1"
        Menu1.Padding = New Padding(10, 0, 0, 0)
        Menu1.Size = New Size(250, 45)
        Menu1.TabIndex = 2
        Menu1.Text = "Menu1"
        Menu1.TextAlign = ContentAlignment.MiddleLeft
        Menu1.UseVisualStyleBackColor = True
        ' 
        ' Home
        ' 
        Home.Dock = DockStyle.Top
        Home.FlatAppearance.BorderSize = 0
        Home.FlatStyle = FlatStyle.Flat
        Home.ForeColor = Color.White
        Home.Location = New Point(0, 125)
        Home.Name = "Home"
        Home.Padding = New Padding(10, 0, 0, 0)
        Home.Size = New Size(250, 45)
        Home.TabIndex = 1
        Home.Text = "Home"
        Home.TextAlign = ContentAlignment.MiddleLeft
        Home.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 125)
        Panel1.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(982, 653)
        Controls.Add(sidePanel)
        Font = New Font("Segoe UI", 10F)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        sidePanel.ResumeLayout(False)
        Button1Panel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents sidePanel As Panel
    Friend WithEvents Home As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1Panel As Panel
    Friend WithEvents SubMenu3 As Button
    Friend WithEvents SubMenu2 As Button
    Friend WithEvents SubMenu1 As Button
    Friend WithEvents Menu1 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
