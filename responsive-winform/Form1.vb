﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSidemenu()
    End Sub

    Private Sub hideSidemenu()
        MenuPanel1.Visible = False
        MenuPanel2.Visible = False
    End Sub
    Private Sub showSidemenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSidemenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub Menu1_Click(sender As Object, e As EventArgs) Handles Menu1.Click
        showSidemenu(MenuPanel1)
    End Sub

    Private Sub Menu2_Click(sender As Object, e As EventArgs) Handles Menu2.Click
        showSidemenu(MenuPanel2)
    End Sub

    Private Sub SubMenu1_Click(sender As Object, e As EventArgs) Handles SubMenu1.Click
        hideSidemenu()
    End Sub

    Private Sub SubMenu2_Click(sender As Object, e As EventArgs) Handles SubMenu2.Click
        hideSidemenu()
    End Sub

    Private Sub SubMenu3_Click(sender As Object, e As EventArgs) Handles SubMenu3.Click
        hideSidemenu()
    End Sub

    Private Sub SubMenu4_Click(sender As Object, e As EventArgs) Handles SubMenu4.Click
        hideSidemenu()
    End Sub

    Private Sub SubMenu5_Click(sender As Object, e As EventArgs) Handles SubMenu5.Click
        hideSidemenu()
    End Sub

    Private Sub SubMenu6_Click(sender As Object, e As EventArgs) Handles SubMenu6.Click
        hideSidemenu()
    End Sub

    Private activeForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)
        If activeForm IsNot Nothing Then activeForm.Close()
        activeForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        mainChildForm.Controls.Add(childForm)
        mainChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        openChildForm(New Home)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openChildForm(New Form2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        openChildForm(New Form3)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
