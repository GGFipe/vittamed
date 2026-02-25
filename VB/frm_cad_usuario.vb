Public Class frm_cad_usuario

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            ' Caso haja campos vazios ou ComboBox não tiver sido configurada
            If cmb_usuario.SelectedItem <> "Médico" Then
                If txt_nome.Text = "" Or txt_email.Text = "" Or txt_senha.Text = "" Or cmb_usuario.SelectedIndex < 0 Then
                    MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Exit Sub
                End If
            Else
                If txt_nome.Text = "" Or txt_email.Text = "" Or txt_senha.Text = "" Or txt_crm.Text = "" Or cmb_usuario.SelectedIndex < 0 Then
                    MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Exit Sub
                End If
            End If

            ' Checar se a senha inputada, que é PRIMARY KEY da tb_login, já foi usada por outro usuário.
            SQL = $"select * from tb_login where senha='{txt_senha.Text}'"
            rs = db.Execute(SQL)

            If rs.EOF = True Then

                ' Se a senha não for usada por outro usuário, gravar novo usuário
                If cmb_usuario.SelectedItem <> "Médico" Then
                    SQL = $"insert into tb_login (senha,nome,email,tipo,crm) values ('{txt_senha.Text}', '{txt_nome.Text}', '{txt_email.Text}', 'MEDICO', '-')"
                    rs = db.Execute(UCase(SQL))
                Else
                    SQL = $"insert into tb_login (senha,nome,email,tipo,crm) values ('{txt_senha.Text}', '{txt_nome.Text}', '{txt_email.Text}', '{cmb_usuario.Text}', '{txt_crm.Text}')"
                    rs = db.Execute(UCase(SQL))
                End If

                MsgBox("Usuário cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            Else

                ' Se a senha for usada por outro usuário, mostrar esta mensagem e não gravar usuário
                MsgBox("Senha em uso. Usuário já cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            End If

            txt_nome.Clear()
            txt_email.Clear()
            txt_senha.Clear()
            cmb_usuario.SelectedIndex = -1
            cmb_usuario.Text = "TIPO DE USUÁRIO"
            txt_nome.Focus()


        Catch ex As Exception
            MsgBox("Erro ao gravar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÂO")
        End Try
    End Sub

    Private Sub cmb_usuario_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_usuario.SelectedValueChanged

        ' Exibir opção para preencher CRM apenas quando a ComboBox estiver selecionada em Médico
        If cmb_usuario.Text = "Médico" Then
            txt_crm.Visible = True
            lbl_crm.Visible = True
        Else
            txt_crm.Visible = False
            lbl_crm.Visible = False
        End If
    End Sub
End Class