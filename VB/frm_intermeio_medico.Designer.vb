<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_intermeio_medico
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_intermeio_medico))
        Me.btn_pacientes = New System.Windows.Forms.Button()
        Me.btn_agenda = New System.Windows.Forms.Button()
        Me.btn_prontuarios = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_pacientes
        '
        Me.btn_pacientes.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_pacientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_pacientes.Location = New System.Drawing.Point(242, 109)
        Me.btn_pacientes.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_pacientes.Name = "btn_pacientes"
        Me.btn_pacientes.Size = New System.Drawing.Size(265, 65)
        Me.btn_pacientes.TabIndex = 0
        Me.btn_pacientes.Text = "Consultar Pacientes"
        Me.btn_pacientes.UseVisualStyleBackColor = False
        '
        'btn_agenda
        '
        Me.btn_agenda.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_agenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agenda.Location = New System.Drawing.Point(242, 182)
        Me.btn_agenda.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_agenda.Name = "btn_agenda"
        Me.btn_agenda.Size = New System.Drawing.Size(265, 65)
        Me.btn_agenda.TabIndex = 1
        Me.btn_agenda.Text = "Agenda de Consultas"
        Me.btn_agenda.UseVisualStyleBackColor = False
        '
        'btn_prontuarios
        '
        Me.btn_prontuarios.BackColor = System.Drawing.Color.PowderBlue
        Me.btn_prontuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_prontuarios.Location = New System.Drawing.Point(242, 255)
        Me.btn_prontuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_prontuarios.Name = "btn_prontuarios"
        Me.btn_prontuarios.Size = New System.Drawing.Size(265, 65)
        Me.btn_prontuarios.TabIndex = 2
        Me.btn_prontuarios.Text = "Cadastrar Prontuário"
        Me.btn_prontuarios.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(278, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Área do Médico"
        '
        'frm_intermeio_medico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.BackgroundImage = Global.prj_adsva2_25.My.Resources.Resources.VittaMed_removebg_preview__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_prontuarios)
        Me.Controls.Add(Me.btn_agenda)
        Me.Controls.Add(Me.btn_pacientes)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_intermeio_medico"
        Me.Text = "ÁREA DO MÉDICO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_pacientes As Button
    Friend WithEvents btn_agenda As Button
    Friend WithEvents btn_prontuarios As Button
    Friend WithEvents Label1 As Label
End Class
