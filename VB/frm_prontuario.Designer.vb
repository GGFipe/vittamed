<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_prontuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_prontuario))
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_crm = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cid11 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_historico = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_anamnese = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_exames = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_diagnostico = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_tratamento = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_alta_e_trans = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_gravar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.Turquoise
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cpf.Location = New System.Drawing.Point(387, 117)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(132, 21)
        Me.txt_cpf.TabIndex = 4
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(383, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CPF DO PACIENTE"
        '
        'txt_crm
        '
        Me.txt_crm.BackColor = System.Drawing.Color.Turquoise
        Me.txt_crm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_crm.Location = New System.Drawing.Point(35, 117)
        Me.txt_crm.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_crm.Name = "txt_crm"
        Me.txt_crm.Size = New System.Drawing.Size(343, 21)
        Me.txt_crm.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "CRM"
        '
        'txt_cid11
        '
        Me.txt_cid11.BackColor = System.Drawing.Color.Turquoise
        Me.txt_cid11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cid11.Location = New System.Drawing.Point(35, 176)
        Me.txt_cid11.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cid11.Name = "txt_cid11"
        Me.txt_cid11.Size = New System.Drawing.Size(484, 21)
        Me.txt_cid11.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 155)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CID"
        '
        'txt_historico
        '
        Me.txt_historico.BackColor = System.Drawing.Color.Turquoise
        Me.txt_historico.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_historico.Location = New System.Drawing.Point(35, 244)
        Me.txt_historico.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_historico.Multiline = True
        Me.txt_historico.Name = "txt_historico"
        Me.txt_historico.Size = New System.Drawing.Size(484, 83)
        Me.txt_historico.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 223)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "HISTÓRICO"
        '
        'txt_anamnese
        '
        Me.txt_anamnese.BackColor = System.Drawing.Color.Turquoise
        Me.txt_anamnese.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_anamnese.Location = New System.Drawing.Point(35, 363)
        Me.txt_anamnese.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_anamnese.Multiline = True
        Me.txt_anamnese.Name = "txt_anamnese"
        Me.txt_anamnese.Size = New System.Drawing.Size(484, 210)
        Me.txt_anamnese.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 342)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "ANAMNESE"
        '
        'txt_exames
        '
        Me.txt_exames.BackColor = System.Drawing.Color.Turquoise
        Me.txt_exames.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_exames.Location = New System.Drawing.Point(539, 117)
        Me.txt_exames.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_exames.Multiline = True
        Me.txt_exames.Name = "txt_exames"
        Me.txt_exames.Size = New System.Drawing.Size(484, 210)
        Me.txt_exames.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(536, 96)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "EXAMES"
        '
        'txt_diagnostico
        '
        Me.txt_diagnostico.BackColor = System.Drawing.Color.Turquoise
        Me.txt_diagnostico.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_diagnostico.Location = New System.Drawing.Point(539, 363)
        Me.txt_diagnostico.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_diagnostico.Multiline = True
        Me.txt_diagnostico.Name = "txt_diagnostico"
        Me.txt_diagnostico.Size = New System.Drawing.Size(484, 210)
        Me.txt_diagnostico.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(536, 342)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "DIAGNÓSTICO"
        '
        'txt_tratamento
        '
        Me.txt_tratamento.BackColor = System.Drawing.Color.Turquoise
        Me.txt_tratamento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_tratamento.Location = New System.Drawing.Point(1037, 117)
        Me.txt_tratamento.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_tratamento.Multiline = True
        Me.txt_tratamento.Name = "txt_tratamento"
        Me.txt_tratamento.Size = New System.Drawing.Size(484, 210)
        Me.txt_tratamento.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1035, 96)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "TRATAMENTO"
        '
        'txt_alta_e_trans
        '
        Me.txt_alta_e_trans.BackColor = System.Drawing.Color.Turquoise
        Me.txt_alta_e_trans.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_alta_e_trans.Location = New System.Drawing.Point(1031, 363)
        Me.txt_alta_e_trans.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_alta_e_trans.Multiline = True
        Me.txt_alta_e_trans.Name = "txt_alta_e_trans"
        Me.txt_alta_e_trans.Size = New System.Drawing.Size(484, 210)
        Me.txt_alta_e_trans.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1035, 342)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "ALTA E TRANSFERÊNCIA"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_gravar, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1540, 27)
        Me.ToolStrip1.TabIndex = 23
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_gravar
        '
        Me.btn_gravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_gravar.Image = CType(resources.GetObject("btn_gravar.Image"), System.Drawing.Image)
        Me.btn_gravar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(29, 24)
        Me.btn_gravar.Text = "ToolStripButton1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(122, 24)
        Me.ToolStripLabel1.Text = "Salvar Prontuário"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Yu Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(223, 30)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Prontuário Médico"
        '
        'frm_prontuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.ClientSize = New System.Drawing.Size(1540, 591)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txt_alta_e_trans)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_tratamento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_diagnostico)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_exames)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_anamnese)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_historico)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_cid11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_crm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Yu Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_prontuario"
        Me.Text = "PRONTUÁRIO MÉDICO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_crm As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cid11 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_historico As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_anamnese As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_exames As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_diagnostico As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_tratamento As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_alta_e_trans As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_gravar As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Label10 As Label
End Class
