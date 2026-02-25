Imports System.Net.Mime.MediaTypeNames
Imports System.Runtime.Remoting.Messaging
Imports System.Security.Policy

Public Class frm_pacientes

    Private Sub frm_pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_bancodados_pacientes()
        carregar_tipo_campo_pacientes()
    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto do paciente"

                ' Começou a dar erro do nada???
                '.InitialDirectory = Application.StartupPath & "\image"

                .ShowDialog()
                Diretorio = .FileName
                Diretorio = Diretorio.Replace("\", "/")
                img_foto.Load(Diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    ' Programação do cadastro de pacientes
    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            If chk_feminino.Checked = False And chk_masculino.Checked = False And chk_nbinario.Checked = False Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            End If

            ' Transcrever CheckBox para uma string no MySQL
            If chk_feminino.Checked Then
                GeneroSelecionado = "Feminino"
            ElseIf chk_masculino.Checked Then
                GeneroSelecionado = "Masculino"
            ElseIf chk_nbinario.Checked Then
                GeneroSelecionado = "Não Binário"
            Else
                GeneroSelecionado = "???"
            End If

            ' CPF é a PRIMARY KEY da tb_pacientes
            SQL = $"select * from tb_pacientes where cpf='{txt_cpf.Text}'"
            rs = db.Execute(SQL)

            NomePaciente = txt_nome.Text

            If rs.EOF = True Then
                SQL = $"insert into tb_pacientes (cpf,telefone,nome,email,genero,data_nasc,idade,foto) values ('{txt_cpf.Text}', '{txt_telefone.Text}', '{txt_nome.Text}', '{txt_email.Text}', '{GeneroSelecionado}', '{cmb_data_nasc.Value.ToShortDateString}', '{txt_idade.Text}', '{Diretorio}')"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastro_pacientes()
                frm_agendas.Show()
            Else
                SQL = $"update tb_pacientes set telefone='{txt_telefone.Text}', nome='{txt_nome.Text}', email='{txt_email.Text}', genero='{GeneroSelecionado}', data_nasc='{cmb_data_nasc.Value.ToShortDateString}', idade='{txt_idade.Text}', foto='{Diretorio}' where cpf='{txt_cpf.Text}'"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastro_pacientes()
            End If
            carregar_bancodados_pacientes()
        Catch ex As Exception
            MsgBox("Erro ao gravar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    ' Programação do sistema de busca
    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            If cmb_campo.Text <> "E-Mail" Then
                SQL = $"select * from tb_pacientes where {cmb_campo.Text} like '{txt_buscar.Text}%' order by nome asc"
            Else
                SQL = $"select * from tb_pacientes where email like '{txt_buscar.Text}%' order by nome asc"
            End If
            rs = db.Execute(SQL)
            With dgv_dados
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop

            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            ' Função quando aperta-se em EDITAR
            ' (Update do SQL)
            With dgv_dados
                If .CurrentRow.Cells(7).Selected = True Then
                    AuxItem = .CurrentRow.Cells(0).Value
                    SQL = $"select * from tb_pacientes where cpf='{AuxItem}'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        txt_cpf.Text = rs.Fields(0).Value
                        txt_telefone.Text = rs.Fields(1).Value
                        txt_nome.Text = rs.Fields(2).Value
                        txt_email.Text = rs.Fields(3).Value

                        ' Transcrever da string do MySQL para CheckBox
                        If GeneroSelecionado = "Feminino" Then
                            chk_nbinario.Checked = False
                            chk_masculino.Checked = False
                            chk_feminino.Checked = True
                        ElseIf GeneroSelecionado = "Masculino" Then
                            chk_nbinario.Checked = False
                            chk_masculino.Checked = True
                            chk_feminino.Checked = False
                        ElseIf GeneroSelecionado = "Não Binário" Then
                            chk_nbinario.Checked = True
                            chk_masculino.Checked = False
                            chk_feminino.Checked = False
                        Else
                            chk_nbinario.Checked = False
                            chk_masculino.Checked = False
                            chk_feminino.Checked = False
                        End If

                        cmb_data_nasc.Value = rs.Fields(5).Value
                        txt_idade.Text = rs.Fields(6).Value
                        img_foto.Load(rs.Fields(7).Value)
                    End If
                    ' Função quando aperta-se em EXCLUIR
                    ' (Delete do SQL)
                ElseIf .CurrentRow.Cells(8).Selected = True Then
                    AuxItem = .CurrentRow.Cells(0).Value
                    SQL = $"select * from tb_pacientes where cpf='{AuxItem}'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        Resposta = MsgBox("Deseja realmente excluir o " + vbNewLine &
                                      "CPF: " & AuxItem & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If Resposta = MsgBoxResult.Yes Then
                            SQL = $"delete from tb_pacientes where cpf='{AuxItem}'"
                            rs = db.Execute(SQL)
                        End If
                    End If
                Else
                    Exit Sub
                End If
                carregar_bancodados_pacientes()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    ' Após o campo txt_cpf perder o foco do curso, testar se já há este CPF digitado em tb_pacientes
    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            SQL = $"select * from tb_pacientes where cpf='{txt_cpf.Text}'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then
                MsgBox("CPF já cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                limpar_cadastro_pacientes()
                txt_cpf.Focus()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub cmb_data_nasc_ValueChanged(sender As Object, e As EventArgs) Handles cmb_data_nasc.ValueChanged

        ' Calcular idade confome data de nascimento
        Dim DataNascimento As Date
        DataNascimento = cmb_data_nasc.Value

        Dim DataAtual As Date = Now

        Dim idade As Integer = DataAtual.Year - DataNascimento.Year

        If DataNascimento.Date > DataAtual.AddYears(-idade).Date Then
            idade -= 1
        End If

        txt_idade.Text = idade.ToString()
    End Sub
End Class
