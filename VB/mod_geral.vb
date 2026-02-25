Module mod_geral
    Public Diretorio, SQL, Resposta As String

    Public devolvido_horario, pego_horario, id_string As String

    Public id_integer As Integer

    Public devolvido_horario_v(255), pego_horario_v(255) As String

    Public AuxItem As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset

    Public cont As Integer

    Public GeneroSelecionado, NomePaciente As String

    Sub ConexaoDBMySQL()
        Try
            db = CreateObject("ADODB.connection")
            db.Open("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;DATABASE=db_vittamed;UID=root;PWD=usbw;port=3307;option=3;")
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tipo_campo_pacientes()
        Try
            With frm_pacientes.cmb_campo.Items
                .Add("CPF")
                .Add("Telefone")
                .Add("Nome")
                .Add("E-Mail")
            End With
            frm_pacientes.cmb_campo.SelectedIndex = 0
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub carregar_bancodados_pacientes()
        Try
            SQL = "select * from tb_pacientes order by nome asc"
            rs = db.Execute(SQL)
            With frm_pacientes.dgv_dados
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

    Sub carregar_bancodados_agendas()
        Try
            SQL = "select * from tb_agenda order by data_horario asc"
            rs = db.Execute(SQL)
            With frm_agendas.dgv_dados
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(2).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(0).Value, rs.Fields(4).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop

            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_bancodados_equipamentos()
        Try
            SQL = "select * from tb_equipamentos order by nome asc"
            rs = db.Execute(SQL)
            With frm_cad_equipamentos.dgv_dados
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

    Sub limpar_cadastro_pacientes()
        Try
            With frm_pacientes

                .txt_cpf.Clear()
                .txt_telefone.Clear()
                .txt_nome.Clear()
                .txt_email.Clear()

                .chk_feminino.Checked = False
                .chk_masculino.Checked = False
                .chk_nbinario.Checked = False

                .cmb_data_nasc.Value = Now
                .txt_idade.Clear()

                .img_foto.Load(Application.StartupPath & "\image\nova_foto.png")

                .txt_cpf.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Module
