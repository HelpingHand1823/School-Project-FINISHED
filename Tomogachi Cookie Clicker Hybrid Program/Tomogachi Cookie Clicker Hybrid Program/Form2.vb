Public Class Form2
    Dim Test As Boolean

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If Form1.Cookies >= 5000 Then
            Form1.MultiplierActive = True
            Form1.Cookies -= 5000
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Form3.Show()
		If Form1.FontChangedGame = True Then

			Form3.Button5.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)
			Form3.Button4.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)
			Form3.Button3.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)
			Form3.Button6.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)
		End If
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		If Form1.Cookies >= 100000 Then
			Form1.Cookies -= 100000

			Form1.FontChangedGame = True


			Button1.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)
			Button2.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)
			Button3.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)

			Form1.Button6.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)
			Form1.Button3.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)
			Form1.Button5.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)
			Form1.Button4.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)
			Form1.Button1.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)
			Form1.Button2.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)
			Form1.Button7.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)
			Form1.Button8.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)
			Form1.Button9.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)
			Form1.Button11.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)
			Form1.Label4.Font = New Font("Comic Sans", 10.0, FontStyle.Regular)

			Button4.Visible = True
			Button5.Visible = True
		End If




	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		Form1.FontChangedGame = True
	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		Form1.FontChangedGame = False
	End Sub
End Class