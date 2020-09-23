Imports System.Data.SQLite

Module Connection
    Public myconnection As SQLiteConnection
    Public cmd As New SQLiteCommand
    Public rdr As SQLite.SQLiteDataReader
    Public dt As New DataTable

    Sub OpenDB()
        myconnection = New SQLiteConnection("Data Source=" & DBPath & ";Version=3")
        myconnection.Open()

        cmd.Connection = myconnection

    End Sub

    Sub closeDB()
        rdr.Close()
        myconnection.Close()
    End Sub
End Module
