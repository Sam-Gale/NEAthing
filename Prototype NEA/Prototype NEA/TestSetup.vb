Public Class TestSetup
    'morning
    Dim conn As New System.Data.Odbc.OdbcConnection("DRIVER={MySQL ODBC 5.2 ANSI Driver};SERVER=localhost;PORT=3306;DATABASE=prototype nea;USER=root;PASSWORD=root;OPTION=3;")
    Dim rs As Odbc.OdbcDataReader


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sql As New Odbc.OdbcCommand("SELECT TopicName FROM topics", conn)
        Dim sql2 As New Odbc.OdbcCommand("SELECT DISTINCT Difficulty FROM questions", conn)
        conn.Open()
        rs = sql.ExecuteReader()
        Do While rs.Read
            TopicCombo.Items.Add(rs("TopicName"))
        Loop
        rs = sql2.ExecuteReader()
        Do While rs.Read
            DiffCombo.Items.Add(rs("Difficulty"))
        Loop
        conn.Close()

    End Sub


    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Topic = TopicCombo.SelectedItem
        Difficulty = DiffCombo.SelectedItem
        Form3.Show()
        Me.Hide()
    End Sub
End Class