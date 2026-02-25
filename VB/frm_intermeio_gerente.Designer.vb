<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_intermeio_gerente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_intermeio_gerente))
        Me.btn_pacientes = New System.Windows.Forms.Button()
        Me.btn_prontuario = New System.Windows.Forms.Button()
        Me.btn_cadastrar_equipamento = New System.Windows.Forms.Button()
        Me.btn_agenda = New System.Windows.Forms.Button()
        Me.btn_banco_equipamentos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_pacientes
        '
        Me.btn_pacientes.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_pacientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_pacientes.Location = New System.Drawing.Point(100, 105)
        Me.btn_pacientes.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_pacientes.Name = "btn_pacientes"
        Me.btn_pacientes.Size = New System.Drawing.Size(235, 55)
        Me.btn_pacientes.TabIndex = 0
        Me.btn_pacientes.Text = "Cadastrar ou Consultar Pacientes"
        Me.btn_pacientes.UseVisualStyleBackColor = False
        '
        'btn_prontuario
        '
        Me.btn_prontuario.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_prontuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_prontuario.Location = New System.Drawing.Point(392, 105)
        Me.btn_prontuario.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_prontuario.Name = "btn_prontuario"
        Me.btn_prontuario.Size = New System.Drawing.Size(235, 55)
        Me.btn_prontuario.TabIndex = 1
        Me.btn_prontuario.Text = "Consultar Prontuários"
        Me.btn_prontuario.UseVisualStyleBackColor = False
        '
        'btn_cadastrar_equipamento
        '
        Me.btn_cadastrar_equipamento.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btn_cadastrar_equipamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cadastrar_equipamento.Location = New System.Drawing.Point(249, 187)
        Me.btn_cadastrar_equipamento.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cadastrar_equipamento.Name = "btn_cadastrar_equipamento"
        Me.btn_cadastrar_equipamento.Size = New System.Drawing.Size(235, 55)
        Me.btn_cadastrar_equipamento.TabIndex = 2
        Me.btn_cadastrar_equipamento.Text = "Cadastrar Equipamentos"
        Me.btn_cadastrar_equipamento.UseVisualStyleBackColor = False
        '
        'btn_agenda
        '
        Me.btn_agenda.BackColor = System.Drawing.Color.LightBlue
        Me.btn_agenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agenda.Location = New System.Drawing.Point(100, 270)
        Me.btn_agenda.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_agenda.Name = "btn_agenda"
        Me.btn_agenda.Size = New System.Drawing.Size(235, 55)
        Me.btn_agenda.TabIndex = 3
        Me.btn_agenda.Text = "Agenda de Consultas"
        Me.btn_agenda.UseVisualStyleBackColor = False
        '
        'btn_banco_equipamentos
        '
        Me.btn_banco_equipamentos.BackColor = System.Drawing.Color.PowderBlue
        Me.btn_banco_equipamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_banco_equipamentos.Location = New System.Drawing.Point(392, 270)
        Me.btn_banco_equipamentos.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_banco_equipamentos.Name = "btn_banco_equipamentos"
        Me.btn_banco_equipamentos.Size = New System.Drawing.Size(235, 55)
        Me.btn_banco_equipamentos.TabIndex = 4
        Me.btn_banco_equipamentos.Text = "Consultar Equipamentos"
        Me.btn_banco_equipamentos.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(233, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Área de Gerenciamento"
        '
        'frm_intermeio_gerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_banco_equipamentos)
        Me.Controls.Add(Me.btn_agenda)
        Me.Controls.Add(Me.btn_cadastrar_equipamento)
        Me.Controls.Add(Me.btn_prontuario)
        Me.Controls.Add(Me.btn_pacientes)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_intermeio_gerente"
        Me.Text = "ÁREA DE GERENCIAMENTO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_pacientes As Button
    Friend WithEvents btn_prontuario As Button
    Friend WithEvents btn_cadastrar_equipamento As Button
    Friend WithEvents btn_agenda As Button
    Friend WithEvents btn_banco_equipamentos As Button
    Friend WithEvents Label1 As Label
End Class
