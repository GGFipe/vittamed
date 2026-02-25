Public Class frm_login

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Efetuar conexão com o banco de dados MySQL portátil quando inicializar o sistema
        ConexaoDBMySQL()
    End Sub

    Private Sub btn_cad_usuario_Click(sender As Object, e As EventArgs) Handles btn_cad_usuario.Click
        frm_cad_usuario.Show()
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click

        ' Caso algum campo esteja vazio
        If txt_nome.Text = "" Or txt_senha.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub
        End If

        ' Testar se o usuário inputado existe
        SQL = $"select * from tb_login where senha='{txt_senha.Text}' and (nome='{txt_nome.Text}' or email='{txt_nome.Text}')"
        rs = db.Execute(SQL)

        If rs.EOF = False Then

            ' Conforme a coluna "tipo" em tb_login do usuário inputado, ir para a tela de intermeio respectiva

            Dim TipoUsuario As String = rs.Fields("tipo").Value.ToString()

            If TipoUsuario = "medico" Then
                frm_intermeio_medico.Show()
            ElseIf TipoUsuario = "recepcionista" Then
                frm_intermeio_recepcionista.Show()
            ElseIf TipoUsuario = "gerente" Then
                frm_intermeio_gerente.Show()
            End If
        Else

            ' Usuário não encontrado

            ' Por segurança da informação, "Usuário ou senha incorretos"
            ' Um hacker poderia usar força bruta na senha caso soubesse que a senha está incorreta (Adilson)
            MsgBox("Usuário ou senha incorretos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")

            ' Limpar cadastro e focar cursor no primeiro campo
            txt_nome.Clear()
            txt_senha.Clear()
            txt_nome.Focus()

        End If

    End Sub
End Class