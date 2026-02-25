Public Class frm_intermeio_gerente

    Private Sub btn_pacientes_Click(sender As Object, e As EventArgs) Handles btn_pacientes.Click
        frm_pacientes.Show()
    End Sub

    Private Sub btn_prontuario_Click(sender As Object, e As EventArgs) Handles btn_prontuario.Click
        frm_consulta_prontuarios.Show()
    End Sub

    Private Sub btn_cadastrar_equipamento_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_equipamento.Click
        frm_cad_equipamentos.Show()
    End Sub

    Private Sub btn_agenda_Click(sender As Object, e As EventArgs) Handles btn_agenda.Click
        frm_agendas.Show()
    End Sub

    Private Sub btn_banco_equipamentos_Click(sender As Object, e As EventArgs) Handles btn_banco_equipamentos.Click
        frm_consulta_equipa.Show()
    End Sub
End Class