Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox11.Text = txtnumero.Text
        TextBox12.Text = txtnumero.Text
        TextBox13.Text = txtnumero.Text
        TextBox14.Text = txtnumero.Text
        TextBox15.Text = txtnumero.Text
        TextBox16.Text = txtnumero.Text
        TextBox17.Text = txtnumero.Text
        TextBox18.Text = txtnumero.Text
        TextBox19.Text = txtnumero.Text
        TextBox20.Text = txtnumero.Text

        txtR1.Text = Val(txt1.Text) * Val(TextBox11.Text)
        txtR2.Text = Val(txt2.Text) * Val(TextBox12.Text)
        txtR3.Text = Val(txt3.Text) * Val(TextBox13.Text)
        txtR4.Text = Val(txt4.Text) * Val(TextBox14.Text)
        txtR5.Text = Val(txt5.Text) * Val(TextBox15.Text)
        txtR6.Text = Val(txt6.Text) * Val(TextBox16.Text)
        txtR7.Text = Val(txt7.Text) * Val(TextBox17.Text)
        txtR8.Text = Val(txt8.Text) * Val(TextBox18.Text)
        txtR9.Text = Val(txt9.Text) * Val(TextBox19.Text)
        txtR10.Text = Val(txt10.Text) * Val(TextBox20.Text)
    End Sub

   
End Class
