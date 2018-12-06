Public Class Formlab1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click, lblNetSalary.Click, lbltex.Click, lbsalaryperyear.Click, Label5.Click, Label4.Click, Label3.Click, Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim salary, salaryperyear, tex As Double
        salary = txtsalary.Text
        salary = Val(salary * 12)

        salaryperyear = Val(salary * 5) / 100

        tex = Val(salary) - Val(salaryperyear)

        lbsalaryperyear.Text = salary
        lbltex.Text = salaryperyear
        lblNetSalary.Text = tex



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
