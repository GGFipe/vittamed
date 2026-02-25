Public Class frm_consulta_prontuarios
    Private Sub frm_consulta_prontuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SQL = "select * from tb_prontuarios"
            rs = db.Execute(SQL)
            With dgv_dados
                .Rows.Clear() 'Limpar as linhas do datagridview
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value, Nothing, Nothing)
                    rs.MoveNext() 'Mover o registro para a próxima linhda do datagridview
                Loop

            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class