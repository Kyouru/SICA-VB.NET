
Imports System.IO
Imports CsvHelper
Imports System.Data.SQLite
Public Class FormImportar

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Comma-separated Values|*.csv"}
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim dt As New DataTable("REPORTE_VALORADOS")
                Using csvConnection As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;" & "Data Source=" & Path.GetDirectoryName(ofd.FileName) & ";" &
                                                       "Extended Properties=""Text;HDR=Yes;FMT=Delimited;Format=Delimited(,)""")
                    csvConnection.Open()

                    Using csvAdapter As New OleDb.OleDbDataAdapter("SELECT * FROM " & Path.GetFileName(ofd.FileName), csvConnection)
                        dt.Columns.Add("CIP", System.Type.GetType("System.String"))
                        dt.Columns.Add("NOMBRE", System.Type.GetType("System.String"))
                        dt.Columns.Add("FECHAPROGRAMACION", System.Type.GetType("System.DateTime"))
                        dt.Columns.Add("MONTOPRESTAMO", System.Type.GetType("System.Double"))
                        dt.Columns.Add("NUMERO_DOCUMENTO", System.Type.GetType("System.String"))
                        dt.Columns.Add("PERIODO_SOLICITUD", System.Type.GetType("System.String"))
                        dt.Columns.Add("NUMERO_SOLICITUD", System.Type.GetType("System.String"))
                        dt.Columns.Add("NUMERO_CUENTA", System.Type.GetType("System.String"))
                        dt.Columns.Add("MONEDA", System.Type.GetType("System.String"))
                        dt.Columns.Add("MONTO_PRESTAMO", System.Type.GetType("System.String"))
                        dt.Columns.Add("SECTORISTA", System.Type.GetType("System.String"))
                        dt.Columns.Add("FECHA_OTORGADO", System.Type.GetType("System.DateTime"))
                        dt.Columns.Add("FECHA_CANCELACION", System.Type.GetType("System.DateTime"))
                        dt.Columns.Add("PAGARE", System.Type.GetType("System.String"))
                        dt.Columns.Add("EXPEDIENTE", System.Type.GetType("System.String"))
                        dt.Columns.Add("FECHA_ENTREGA", System.Type.GetType("System.DateTime"))
                        dt.Columns.Add("FECHA_DEVOLUCION", System.Type.GetType("System.DateTime"))
                        dt.Columns.Add("TIPO_PRESTAMO", System.Type.GetType("System.String"))
                        dt.Columns.Add("USUARIO_REGISTRO", System.Type.GetType("System.String"))
                        dt.Columns.Add("OBSERVACION", System.Type.GetType("System.String"))
                        Try
                            csvAdapter.Fill(dt)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            Exit Sub
                        End Try
                    End Using

                    csvConnection.Close()
                End Using

                Using sqliteConnection As New SQLiteConnection("Data Source=" + DBPath)
                    sqliteConnection.Open()

                    ''Uno por uno
                    Dim sqliteTransaction As SQLiteTransaction = sqliteConnection.BeginTransaction
                    Dim sqliteCmd As SQLiteCommand

                    For Each row In dt.Rows
                        sqliteCmd = New SQLiteCommand("INSERT INTO REPORTE_VALORADOS (CIP, NOMBRE, FECHAPROGRAMACION, MONTOPRESTAMO, NUMERO_DOCUMENTO, PERIODO_SOLICITUD, NUMERO_SOLICITUD, NUMERO_CUENTA, MONEDA, MONTO_PRESTAMO, SECTORISTA, FECHA_OTORGADO, FECHA_CANCELACION, PAGARE, EXPEDIENTE, FECHA_ENTREGA, FECHA_DEVOLUCION, TIPO_PRESTAMO, USUARIO_REGISTRO, OBSERVACION)" &
                                                      "VALUES('" & row(0) & "', '" & Replace(row(1), "'", "''") & "', '" & row(2) & "', " & row(3) & ", '" & row(4) & "', '" & row(5) & "', '" & row(6) & "', '" & row(7) & "', '" & row(8) & "', '" & row(9) & "', '" & row(10) & "', '" & row(11) & "', '" & row(12) & "', '" & row(13) & "', '" & row(14) & "', '" & row(15) & "', '" & row(16) & "', '" & row(17) & "', '" & row(18) & "', '" & row(19) & "')", sqliteConnection)
                        Try
                            sqliteCmd.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message & vbCrLf & sqliteCmd.CommandText)
                            Exit Sub
                        End Try
                    Next
                    sqliteTransaction.Commit()

                    sqliteConnection.Close()

                    dgvNDesembolsos.DataSource = dt
                End Using

            End If
        End Using
    End Sub

    Private Sub btPrestamosNuevos_Click(sender As Object, e As EventArgs) Handles btPrestamosNuevos.Click
        Dim dt As New DataTable("REPORTE_VALORADOS_IMPORTADO")
        Dim dt2 As New DataTable("REPORTE_VALORADOS_BD")
        Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Comma-separated Values|*.csv"}
            If ofd.ShowDialog() = DialogResult.OK Then
                Using csvConnection As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;" & "Data Source=" & Path.GetDirectoryName(ofd.FileName) & ";" &
                                                       "Extended Properties=""Text;HDR=Yes;FMT=Delimited;datetimeformat=CurrentCulture;Format=Delimited(,)""")
                    csvConnection.Open()

                    Using csvAdapter As New OleDb.OleDbDataAdapter("SELECT * FROM " & Path.GetFileName(ofd.FileName), csvConnection)
                        dt.Columns.Add("CIP", System.Type.GetType("System.String"))
                        dt.Columns.Add("NOMBRE", System.Type.GetType("System.String"))
                        dt.Columns.Add("FECHAPROGRAMACION", System.Type.GetType("System.DateTime"))
                        dt.Columns.Add("MONTOPRESTAMO", System.Type.GetType("System.Double"))
                        dt.Columns.Add("NUMERO_DOCUMENTO", System.Type.GetType("System.String"))
                        dt.Columns.Add("PERIODO_SOLICITUD", System.Type.GetType("System.String"))
                        dt.Columns.Add("NUMERO_SOLICITUD", System.Type.GetType("System.String"))
                        dt.Columns.Add("NUMERO_CUENTA", System.Type.GetType("System.String"))
                        dt.Columns.Add("MONEDA", System.Type.GetType("System.String"))
                        dt.Columns.Add("MONTO_PRESTAMO", System.Type.GetType("System.String"))
                        dt.Columns.Add("SECTORISTA", System.Type.GetType("System.String"))
                        dt.Columns.Add("FECHA_OTORGADO", System.Type.GetType("System.DateTime"))
                        dt.Columns.Add("FECHA_CANCELACION", System.Type.GetType("System.DateTime"))
                        dt.Columns.Add("PAGARE", System.Type.GetType("System.String"))
                        dt.Columns.Add("EXPEDIENTE", System.Type.GetType("System.String"))
                        dt.Columns.Add("FECHA_ENTREGA", System.Type.GetType("System.DateTime"))
                        dt.Columns.Add("FECHA_DEVOLUCION", System.Type.GetType("System.DateTime"))
                        dt.Columns.Add("TIPO_PRESTAMO", System.Type.GetType("System.String"))
                        dt.Columns.Add("USUARIO_REGISTRO", System.Type.GetType("System.String"))
                        dt.Columns.Add("OBSERVACION", System.Type.GetType("System.String"))
                        Try
                            csvAdapter.Fill(dt)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            Exit Sub
                        End Try
                    End Using

                    csvConnection.Close()
                End Using
            End If
        End Using

        Using sqliteConnection As New SQLiteConnection("Data Source=" + DBPath)
            sqliteConnection.Open()

            dt2.Columns.Add("CIP", System.Type.GetType("System.String"))
            dt2.Columns.Add("NOMBRE", System.Type.GetType("System.String"))
            dt2.Columns.Add("FECHAPROGRAMACION", System.Type.GetType("System.String"))
            dt2.Columns.Add("MONTOPRESTAMO", System.Type.GetType("System.Double"))
            dt2.Columns.Add("NUMERO_DOCUMENTO", System.Type.GetType("System.String"))
            dt2.Columns.Add("PERIODO_SOLICITUD", System.Type.GetType("System.String"))
            dt2.Columns.Add("NUMERO_SOLICITUD", System.Type.GetType("System.String"))
            dt2.Columns.Add("NUMERO_CUENTA", System.Type.GetType("System.String"))
            dt2.Columns.Add("MONEDA", System.Type.GetType("System.String"))
            dt2.Columns.Add("MONTO_PRESTAMO", System.Type.GetType("System.String"))
            dt2.Columns.Add("SECTORISTA", System.Type.GetType("System.String"))
            dt2.Columns.Add("FECHA_OTORGADO", System.Type.GetType("System.String"))
            dt2.Columns.Add("FECHA_CANCELACION", System.Type.GetType("System.String"))
            dt2.Columns.Add("PAGARE", System.Type.GetType("System.String"))
            dt2.Columns.Add("EXPEDIENTE", System.Type.GetType("System.String"))
            dt2.Columns.Add("FECHA_ENTREGA", System.Type.GetType("System.String"))
            dt2.Columns.Add("FECHA_DEVOLUCION", System.Type.GetType("System.String"))
            dt2.Columns.Add("TIPO_PRESTAMO", System.Type.GetType("System.String"))
            dt2.Columns.Add("USUARIO_REGISTRO", System.Type.GetType("System.String"))
            dt2.Columns.Add("OBSERVACION", System.Type.GetType("System.String"))

            Dim sqliteCmd As SQLiteCommand

            sqliteCmd = New SQLiteCommand("SELECT CIP, NOMBRE, FECHAPROGRAMACION, MONTOPRESTAMO, NUMERO_DOCUMENTO, PERIODO_SOLICITUD, NUMERO_SOLICITUD, NUMERO_CUENTA, MONEDA, MONTO_PRESTAMO, SECTORISTA, FECHA_OTORGADO, FECHA_CANCELACION, PAGARE, EXPEDIENTE, FECHA_ENTREGA, FECHA_DEVOLUCION, TIPO_PRESTAMO, USUARIO_REGISTRO, OBSERVACION FROM REPORTE_VALORADOS", sqliteConnection)
            Try
                sqliteCmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message & vbCrLf & sqliteCmd.CommandText)
                Exit Sub
            End Try

            Dim sqliteDataAdapter As SQLiteDataAdapter = New SQLiteDataAdapter(sqliteCmd)
            sqliteDataAdapter.Fill(dt2)

            'MsgBox(dt2.Rows(0)(1))

            sqliteConnection.Close()
            'From c1 In dt Join c2 In dt2 On c1.Field("PERIODO_SOLICITUD") Equals c2.Field("PERIODO_SOLICITUD")

            dgvNDesembolsos.DataSource = (From c1 In dt.AsEnumerable Group Join c2 In dt2.AsEnumerable On c1.Field(Of String)("NUMERO_SOLICITUD") Equals c2.Field(Of String)("NUMERO_SOLICITUD") And c1.Field(Of String)("PERIODO_SOLICITUD") Equals c2.Field(Of String)("PERIODO_SOLICITUD") Into j = Group From c2 In j.DefaultIfEmpty() Select New With {.PERIODO_SOLICITUD = c1.Field(Of String)("PERIODO_SOLICITUD"), .NUMERO_SOLICITUD = c1.Field(Of String)("NUMERO_SOLICITUD")}).ToList
            MsgBox(dgvNDesembolsos.Rows.Count)
        End Using
    End Sub
End Class