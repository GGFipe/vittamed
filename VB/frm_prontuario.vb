Public Class frm_prontuario
    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            SQL = $"select * from tb_prontuarios where cid_11='{txt_cid11.Text}'"
            rs = db.Execute(SQL)
            If rs.EOF = True Then
                SQL = $"insert into tb_prontuarios (cid_11,cpf,crm,historico,anamnese,exames,diagnostico,tratamento,alta_e_trans) values ('{txt_cid11.Text}', '{txt_cpf.Text}', '{txt_crm.Text}', '{txt_historico.Text}', '{txt_anamnese.Text}', '{txt_exames.Text}', '{txt_diagnostico.Text}', '{txt_tratamento.Text}', '{txt_alta_e_trans.Text}')"
                rs = db.Execute(UCase(SQL))
                MsgBox("Prontuário gravado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                SQL = $"update tb_prontuarios set cid_11='{txt_cid11.Text}', cpf='{txt_cpf.Text}', crm='{txt_crm.Text}', historico='{txt_historico.Text}', anamnese='{txt_anamnese.Text}', exames='{txt_exames.Text}', diagnostico='{txt_diagnostico.Text}', tratamento='{txt_tratamento.Text}', alta_e_trans='{txt_alta_e_trans.Text}' where cid11='{txt_cid11.Text}'"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
            txt_cid11.Clear()
            txt_cpf.Clear()
            txt_crm.Clear()
            txt_historico.Clear()
            txt_anamnese.Clear()
            txt_exames.Clear()
            txt_diagnostico.Clear()
            txt_tratamento.Clear()
            txt_alta_e_trans.Clear()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class