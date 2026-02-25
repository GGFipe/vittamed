Public Class frm_consulta_equipa

    Private Sub frm_consulta_equipa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SQL = "select * from tb_equipamentos order by nome asc"
            rs = db.Execute(SQL)
            With dgv_dados
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields("disponibilidade").Value, rs.Fields("devolvido").Value, rs.Fields(6).Value, rs.Fields("pego").Value, rs.Fields(8).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop

            End With

            With cmb_campo.Items
                .Add("Nome")
                .Add("Categoria")
                .Add("Sala")
            End With
            cmb_campo.SelectedIndex = 0
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(9).Selected = True Then
                    AuxItem = .CurrentRow.Cells(1).Value
                    SQL = $"select * from tb_equipamentos where nome='{AuxItem}'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        txt_nome.Text = rs.Fields(1).Value
                        txt_categoria.Text = rs.Fields(2).Value
                        txt_sala.Text = rs.Fields(3).Value
                    End If
                    Exit Sub
                End If
                SQL = "select * from tb_equipamentos order by nome asc"
                rs = db.Execute(SQL)
                With dgv_dados
                    .Rows.Clear()
                    Do While rs.EOF = False
                        .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields("disponibilidade").Value, rs.Fields("devolvido").Value, rs.Fields(6).Value, rs.Fields("pego").Value, rs.Fields(8).Value, Nothing, Nothing)
                        rs.MoveNext()
                    Loop

                End With
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            SQL = $"select * from tb_equipamentos where {cmb_campo.Text} like '{txt_busca.Text}%' order by nome asc"
            rs = db.Execute(SQL)
            With dgv_dados
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields("disponibilidade").Value, rs.Fields("devolvido").Value, rs.Fields(6).Value, rs.Fields("pego").Value, rs.Fields(8).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop

            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            id_string = txt_id.Text

            Integer.TryParse(id_string, id_integer)

            SQL = $"select * from tb_equipamentos where nome='{txt_nome.Text}'"
            rs = db.Execute(SQL)

            If chk_disponibilidade.Checked Then
                SQL = $"update tb_equipamentos set disponibilidade=1 where nome='{txt_nome.Text}'"
            Else
                SQL = $"update tb_equipamentos set disponibilidade=0 where nome='{txt_nome.Text}'"
            End If
            rs = db.Execute(SQL)

            If chk_devolvido.Checked Then
                SQL = $"update tb_equipamentos set devolvido=1 where nome='{txt_nome.Text}'"
                rs = db.Execute(SQL)

                devolvido_horario_v(id_integer) = Now

                SQL = $"update tb_equipamentos set devolvido_horario='{devolvido_horario_v(id_integer)}' where nome='{txt_nome.Text}'"
            Else
                SQL = $"update tb_equipamentos set devolvido=0 where nome='{txt_nome.Text}'"
            End If
            rs = db.Execute(SQL)

            If chk_pego.Checked Then
                SQL = $"update tb_equipamentos set pego=1 where nome='{txt_nome.Text}'"
                rs = db.Execute(SQL)

                pego_horario_v(id_integer) = Now

                SQL = $"update tb_equipamentos set pego_horario='{pego_horario_v(id_integer)}' where nome='{txt_nome.Text}'"
            Else
                SQL = $"update tb_equipamentos set pego=0 where nome='{txt_nome.Text}'"
            End If
            rs = db.Execute(SQL)

            txt_nome.Clear()
            txt_categoria.Clear()
            txt_sala.Clear()

            SQL = "select * from tb_equipamentos order by nome asc"
            rs = db.Execute(SQL)
            With dgv_dados
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields("disponibilidade").Value, rs.Fields("devolvido").Value, rs.Fields(6).Value, rs.Fields("pego").Value, rs.Fields(8).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With

        Catch ex As Exception
            MsgBox("Erro ao gravar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub chk_devolvido_CheckedChanged(sender As Object, e As EventArgs) Handles chk_devolvido.CheckedChanged
        If chk_devolvido.Checked = True Then
            chk_pego.Enabled = False
            chk_pego.Checked = False
            chk_disponibilidade.Checked = True
            chk_disponibilidade.Enabled = False
        Else
            chk_pego.Enabled = True
            chk_disponibilidade.Enabled = True
            chk_disponibilidade.Checked = True
        End If
    End Sub

    Private Sub chk_pego_CheckedChanged(sender As Object, e As EventArgs) Handles chk_pego.CheckedChanged
        If chk_pego.Checked = True Then
            chk_devolvido.Checked = False
            chk_devolvido.Enabled = False
            chk_disponibilidade.Checked = False
            chk_disponibilidade.Enabled = False
        Else
            chk_devolvido.Enabled = True
            chk_disponibilidade.Enabled = True
            chk_disponibilidade.Checked = True
        End If
    End Sub
End Class