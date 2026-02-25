Public Class frm_intermeio_recepcionista
    Private Sub btn_pacientes_Click(sender As Object, e As EventArgs) Handles btn_pacientes.Click
        frm_pacientes.Show()
    End Sub

    Private Sub btn_equipamentos_Click(sender As Object, e As EventArgs) Handles btn_equipamentos.Click
        frm_consulta_equipa.Show()
    End Sub

    Private Sub btn_agendas_Click(sender As Object, e As EventArgs) Handles btn_agendas.Click
        frm_agendas.Show()
    End Sub
End Class