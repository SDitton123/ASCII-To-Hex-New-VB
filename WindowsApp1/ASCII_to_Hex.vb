Public Class ASCII_to_Hex
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call StrToHex(TextBox2.Text)
    End Sub
    Public Function StrToHex(ByVal Data As String) As String
        Dim sVal As String
        Dim sHex As String = ""
        While Data.Length > 0
            sVal = Conversion.Hex(Strings.Asc(Data.Substring(0, 1).ToString()))
            Data = Data.Substring(1)
            If sVal.Length < 2 Then
                sHex = sHex & "0" & sVal
            Else
                sHex = sHex & sVal
            End If
        End While
        TextBox1.Text = Mid$(sHex, 5, 4) & Mid$(sHex, 1, 4) & " / " & Mid$(sHex, 13, 4) & Mid$(sHex, 9, 4) & " / " & Mid$(sHex, 21, 4) & Mid$(sHex, 17, 4)
        Return sHex
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call HexToStr(TextBox3.Text)
    End Sub
    Public Function HexToStr(ByVal Data As String) As String
        Dim com As String = ""
        For x = 0 To Data.Length - 1 Step 2
            com &= ChrW(CInt("&H" & Data.Substring(x, 2)))
        Next
        TextBox4.Text = Mid$(com, 3, 2) & Mid$(com, 1, 2) & Mid$(com, 7, 2) & Mid$(com, 5, 2) & Mid$(com, 11, 2) & Mid$(com, 9, 2) & Mid$(com, 15, 2) & Mid$(com, 13, 2)  'reverse for OMRON
        Return com
    End Function
    Private Sub TextBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.Click
        TextBox2.Text = ""
    End Sub
    Private Sub TextBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.Click
        TextBox3.Text = ""
    End Sub
End Class
