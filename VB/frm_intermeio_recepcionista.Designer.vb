<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_intermeio_recepcionista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_intermeio_recepcionista))
        Me.btn_pacientes = New System.Windows.Forms.Button()
        Me.btn_agendas = New System.Windows.Forms.Button()
        Me.btn_equipamentos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_pacientes
        '
        Me.btn_pacientes.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_pacientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_pacientes.Location = New System.Drawing.Point(242, 109)
        Me.btn_pacientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_pacientes.Name = "btn_pacientes"
        Me.btn_pacientes.Size = New System.Drawing.Size(265, 65)
        Me.btn_pacientes.TabIndex = 0
        Me.btn_pacientes.Text = "Cadastrar ou Consultar Pacientes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_pacientes.UseVisualStyleBackColor = False
        '
        'btn_agendas
        '
        Me.btn_agendas.BackColor = System.Drawing.Color.PowderBlue
        Me.btn_agendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agendas.Location = New System.Drawing.Point(242, 255)
        Me.btn_agendas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_agendas.Name = "btn_agendas"
        Me.btn_agendas.Size = New System.Drawing.Size(265, 65)
        Me.btn_agendas.TabIndex = 1
        Me.btn_agendas.Text = "Agenda de Consultas"
        Me.btn_agendas.UseVisualStyleBackColor = False
        '
        'btn_equipamentos
        '
        Me.btn_equipamentos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_equipamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_equipamentos.Location = New System.Drawing.Point(242, 182)
        Me.btn_equipamentos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_equipamentos.Name = "btn_equipamentos"
        Me.btn_equipamentos.Size = New System.Drawing.Size(265, 65)
        Me.btn_equipamentos.TabIndex = 2
        Me.btn_equipamentos.Text = "Consultar Equipamentos"
        Me.btn_equipamentos.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Área do Recepcionista"
        '
        'frm_intermeio_recepcionista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_equipamentos)
        Me.Controls.Add(Me.btn_agendas)
        Me.Controls.Add(Me.btn_pacientes)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_intermeio_recepcionista"
        Me.Text = "ÁREA DO RECEPCIONISTA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_pacientes As Button
    Friend WithEvents btn_agendas As Button
    Friend WithEvents btn_equipamentos As Button
    Friend WithEvents Label1 As Label
End Class
