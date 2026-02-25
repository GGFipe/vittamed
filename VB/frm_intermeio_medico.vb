Public Class frm_intermeio_medico

    Private Sub btn_prontuarios_Click(sender As Object, e As EventArgs) Handles btn_prontuarios.Click
        frm_prontuario.Show()
    End Sub

    Private Sub btn_pacientes_Click(sender As Object, e As EventArgs) Handles btn_pacientes.Click
        frm_pacientes.Show()
    End Sub

    Private Sub btn_agenda_Click(sender As Object, e As EventArgs) Handles btn_agenda.Click
        frm_agendas.Show()
    End Sub
End Class