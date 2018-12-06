Public Class Formlab2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsum.Click
        Dim vistra, computer, total, comissionVis, comissionCom, comission As Double
        vistra = txtVistra.Text
        computer = txtcomputer.Text

        total = vistra + computer

        comissionVis = Val(vistra * 5) / 100
        comissionCom = Val(computer * 10) / 100

        lbltotal.Text = total
        lblVistra.Text = comissionVis
        lblcomputer.Text = comissionCom
        lblComissionsum.Text = comissionVis + comissionCom

    End Sub
End Class