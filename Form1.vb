Public Class Fmr_Startseite

    Dim NeuesRezept As New ListViewItem("Pfannkuchen")

    Private Sub CmdNeuesRezept_Click(sender As Object, e As EventArgs) Handles CmdNeuesRezept.Click

        LstViewAllRezepte.Items.Add(NeuesRezept)

    End Sub


    Private Sub Fmr_Startseite_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NeuesRezept.SubItems.Add("Frühstück")
        NeuesRezept.SubItems.Add("350")

    End Sub

    Private Sub CmdExit_Click(sender As Object, e As EventArgs) Handles CmdExit.Click
        End
    End Sub
End Class
