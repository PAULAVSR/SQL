Public Class EVENTUS_GmbH


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Form2 As New Form2
        Form2.Server = com_bx_Server.Text
        Form2.DB = com_bx_database.Text
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form7 As New Form7
        Form7.Server = com_bx_Server.Text
        Form7.DB = com_bx_database.Text
        Form7.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Mitarbeiterübersicht As New Mitarbeiterübersicht
        Mitarbeiterübersicht.Server = com_bx_Server.Text
        Mitarbeiterübersicht.DB = com_bx_database.Text
        Mitarbeiterübersicht.Show()
    End Sub

    Private Sub EVENTUS_GmbH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        com_bx_Server.Items.Add("PAULSPC")
        com_bx_Server.Text = "PAULSPC"
        com_bx_database.Items.Add("Projekt_III")
        com_bx_database.Text = "Projekt_III"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True

    End Sub


End Class