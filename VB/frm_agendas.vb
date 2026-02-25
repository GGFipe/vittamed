Public Class frm_agendas

    Private Sub frm_agendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_bancodados_agendas()
        With cmb_campo.Items
            .Add("Data")
            .Add("CRM")
            .Add("Paciente")
            .Add("Sala")
        End With
        cmb_campo.SelectedIndex = 0

        Dim nomeDoFormParaVerificar As String = "frm_pacientes"

        ' Verificar se há um frm_pacientes estiver aberto.
        ' Se estiver, preencher nome com o nome do paciente inputado no formulário de pacientes.

        ' Ou seja, este teste é efetuado após um paciente ser cadastrado e o sistema direcionar para a tela de agendamento de consulta.
        If IsFormOpen(nomeDoFormParaVerificar) Then
            txt_nome.Text = NomePaciente
        End If

    End Sub

    Private Function IsFormOpen(frm_pacientes As String) As Boolean
        For Each frm As Form In Application.OpenForms
            If frm.Name = frm_pacientes Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                ' Editar item na agenda
                If .CurrentRow.Cells(4).Selected = True Then
                    AuxItem = .CurrentRow.Cells(1).Value
                    SQL = $"select * from tb_agenda where crm='{AuxItem}'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        txt_nome.Text = rs.Fields(2).Value
                        txt_crm.Text = rs.Fields(1).Value
                        txt_sala.Text = rs.Fields(3).Value
                        cmb_data.Value = rs.Fields(2).Value
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    ' Excluir item na agenda
                    AuxItem = .CurrentRow.Cells(1).Value
                    SQL = $"select * from tb_agenda where crm='{AuxItem}'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        Resposta = MsgBox("Deseja realmente excluir este item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If Resposta = MsgBoxResult.Yes Then
                            SQL = $"delete from tb_agenda where crm='{AuxItem}'"
                            rs = db.Execute(SQL)
                        End If
                    End If
                Else
                    Exit Sub
                End If
                carregar_bancodados_agendas()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            If cmb_campo.Text <> "Data" Then
                SQL = $"select * from tb_agenda where {cmb_campo.Text} like '{txt_busca.Text}%' order by data_horario asc"
            Else
                SQL = $"select * from tb_agenda where data_horario like '{txt_busca.Text}%' order by data_horario asc"
            End If
            rs = db.Execute(SQL)
            With dgv_dados
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(2).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(0).Value, rs.Fields(4).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop

            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try

            Dim atendidoBoolean As Integer

            If txt_nome.Text = "" Or txt_crm.Text = "" Or txt_sala.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            End If

            If chk_atendido.Checked Then
                atendidoBoolean = 1
            Else
                atendidoBoolean = 0
            End If

            SQL = $"select * from tb_agenda where data_horario='{cmb_data.Value}'"
            rs = db.Execute(SQL)

            If rs.EOF = True Then
                SQL = $"insert into tb_agenda (data_horario,crm,paciente,sala,atendido) values ('{cmb_data.Value}', '{txt_crm.Text}', '{txt_nome.Text}', '{txt_sala.Text}', 1)"
                rs = db.Execute(SQL)

                If atendidoBoolean = 1 Then
                    SQL = $"update tb_agenda set atendido=1 where data_horario='{cmb_data.Value}'"
                Else
                    SQL = $"update tb_agenda set atendido=0 where data_horario='{cmb_data.Value}'"
                End If
                rs = db.Execute(SQL)

                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                SQL = $"update tb_agenda set data_horario='{cmb_data.Value}', crm='{txt_crm.Text}', paciente='{txt_nome.Text}', sala='{txt_sala.Text}' where data_horario='{cmb_data.Value}'"
                rs = db.Execute(SQL)
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If

            txt_nome.Clear()
            txt_crm.Clear()
            txt_nome.Clear()
            txt_sala.Clear()
            txt_nome.Focus()

            carregar_bancodados_agendas()

        Catch ex As Exception
            MsgBox("Erro ao gravar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_hoje_Click(sender As Object, e As EventArgs) Handles txt_hoje.Click
        cmb_campo.Text = "Data"
        txt_busca.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub
End Class