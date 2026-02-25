Public Class frm_cad_equipamentos

    Private Sub frm_cad_equipamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_bancodados_equipamentos()

        With cmb_campo.Items
            .Add("Nome")
            .Add("Categoria")
            .Add("Sala")
        End With
        cmb_campo.SelectedIndex = 0
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            SQL = $"select * from tb_equipamentos where {cmb_campo.Text} like '{txt_busca.Text}%' order by nome asc"
            rs = db.Execute(SQL)
            With dgv_dados
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop

            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_graver.Click
        Try

            SQL = $"select * from tb_equipamentos where id_item='{txt_id.Text}'"
            rs = db.Execute(SQL)

            If rs.EOF = True Then
                SQL = $"insert into tb_equipamentos (nome,categoria,sala,disponibilidade,devolvido,devolvido_horario,pego,pego_horario) values ('{txt_nome.Text}', '{txt_categoria.Text}', '{txt_sala.Text}',1,0,'',0,'')"
                rs = db.Execute(UCase(SQL))

                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                SQL = $"update tb_equipamentos set nome='{txt_nome.Text}', categoria='{txt_categoria.Text}', sala='{txt_sala.Text}', disponibilidade=1, devolvido=0, devolvivo_horario='', pego=0, pego_horario=''"
                rs = db.Execute(UCase(SQL))

                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If

            txt_nome.Clear()
            txt_categoria.Clear()
            txt_sala.Clear()

            txt_id.Clear()

            txt_nome.Focus()

            carregar_bancodados_equipamentos()
        Catch ex As Exception
            MsgBox("Erro ao gravar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(4).Selected = True Then
                    AuxItem = .CurrentRow.Cells(0).Value

                    SQL = $"select * from tb_equipamentos where id_item='{AuxItem}'"
                    rs = db.Execute(SQL)

                    If rs.EOF = False Then
                        txt_id.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(1).Value
                        txt_categoria.Text = rs.Fields(2).Value
                        txt_sala.Text = rs.Fields(3).Value
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    AuxItem = .CurrentRow.Cells(0).Value

                    SQL = $"select * from tb_equipamentos where id_item='{AuxItem}'"
                    rs = db.Execute(SQL)

                    If rs.EOF = False Then
                        Resposta = MsgBox("Deseja realmente excluir este item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If Resposta = MsgBoxResult.Yes Then
                            SQL = $"delete from tb_equipamentos where id_item='{AuxItem}'"
                            rs = db.Execute(SQL)
                        End If
                    End If
                Else
                    Exit Sub
                End If
                carregar_bancodados_equipamentos()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class