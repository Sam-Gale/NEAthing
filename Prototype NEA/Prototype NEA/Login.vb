Public Class SignIn

    Dim conn As New System.Data.Odbc.OdbcConnection("DRIVER={MySQL ODBC 5.3 ANSI Driver};SERVER=localhost;PORT=3306;DATABASE=prototype nea;USER=root;PASSWORD=root;OPTION=3;")
    Dim rs As Odbc.OdbcDataReader


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim sql As New Odbc.OdbcCommand("SELECT Password FROM member WHERE Username = '" & UsernameBox.Text & "' AND Password = '" & PasswordBox.Text & "' ", conn)

        conn.Open()
        rs = sql.ExecuteReader
        If rs.Read() Then
            TestSetup.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Username or Password.")
            UsernameBox.Text = ""
            PasswordBox.Text = ""
        End If
        conn.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
