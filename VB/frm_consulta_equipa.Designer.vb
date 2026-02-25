<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_consulta_equipa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_consulta_equipa))
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_gravar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_campo = New System.Windows.Forms.ToolStripComboBox()
        Me.chk_disponibilidade = New System.Windows.Forms.CheckBox()
        Me.chk_devolvido = New System.Windows.Forms.CheckBox()
        Me.chk_pego = New System.Windows.Forms.CheckBox()
        Me.txt_sala = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_categoria = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_dados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_dados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgv_dados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column2, Me.Column6, Me.Column4, Me.Column5, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.dgv_dados.Location = New System.Drawing.Point(13, 224)
        Me.dgv_dados.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.RowHeadersWidth = 51
        Me.dgv_dados.Size = New System.Drawing.Size(1413, 222)
        Me.dgv_dados.TabIndex = 25
        '
        'Column7
        '
        Me.Column7.HeaderText = "ID"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 49
        '
        'Column1
        '
        Me.Column1.HeaderText = "NOME"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 76
        '
        'Column2
        '
        Me.Column2.HeaderText = "CATEGORIA"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 114
        '
        'Column6
        '
        Me.Column6.HeaderText = "SALA"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 70
        '
        'Column4
        '
        Me.Column4.HeaderText = "DISPONIBILIDADE"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 127
        '
        'Column5
        '
        Me.Column5.HeaderText = "DEVOLVIDO"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column5.Width = 113
        '
        'Column8
        '
        Me.Column8.HeaderText = "HORÁRIO DE DEVOLUÇÃO"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 188
        '
        'Column9
        '
        Me.Column9.HeaderText = "RETIRADO"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column9.Width = 106
        '
        'Column10
        '
        Me.Column10.HeaderText = "HORÁRIO DE RETIRADA"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 175
        '
        'Column11
        '
        Me.Column11.HeaderText = "EDITAR"
        Me.Column11.Image = CType(resources.GetObject("Column11.Image"), System.Drawing.Image)
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 63
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_gravar, Me.ToolStripLabel1, Me.txt_busca, Me.ToolStripLabel2, Me.cmb_campo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1491, 28)
        Me.ToolStrip1.TabIndex = 26
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_gravar
        '
        Me.btn_gravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_gravar.Image = CType(resources.GetObject("btn_gravar.Image"), System.Drawing.Image)
        Me.btn_gravar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(29, 25)
        Me.btn_gravar.Text = "ToolStripButton1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(215, 25)
        Me.ToolStripLabel1.Text = "Digite um parâmetro de busca:"
        '
        'txt_busca
        '
        Me.txt_busca.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(190, 28)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(151, 25)
        Me.ToolStripLabel2.Text = "Selecione um campo:"
        '
        'cmb_campo
        '
        Me.cmb_campo.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmb_campo.Name = "cmb_campo"
        Me.cmb_campo.Size = New System.Drawing.Size(121, 28)
        '
        'chk_disponibilidade
        '
        Me.chk_disponibilidade.AutoSize = True
        Me.chk_disponibilidade.Checked = True
        Me.chk_disponibilidade.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_disponibilidade.Location = New System.Drawing.Point(33, 144)
        Me.chk_disponibilidade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_disponibilidade.Name = "chk_disponibilidade"
        Me.chk_disponibilidade.Size = New System.Drawing.Size(108, 20)
        Me.chk_disponibilidade.TabIndex = 27
        Me.chk_disponibilidade.Text = "DISPONÍVEL"
        Me.chk_disponibilidade.UseVisualStyleBackColor = True
        '
        'chk_devolvido
        '
        Me.chk_devolvido.AutoSize = True
        Me.chk_devolvido.Location = New System.Drawing.Point(33, 117)
        Me.chk_devolvido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_devolvido.Name = "chk_devolvido"
        Me.chk_devolvido.Size = New System.Drawing.Size(106, 20)
        Me.chk_devolvido.TabIndex = 28
        Me.chk_devolvido.Text = "DEVOLVIDO"
        Me.chk_devolvido.UseVisualStyleBackColor = True
        '
        'chk_pego
        '
        Me.chk_pego.AutoSize = True
        Me.chk_pego.Location = New System.Drawing.Point(33, 178)
        Me.chk_pego.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_pego.Name = "chk_pego"
        Me.chk_pego.Size = New System.Drawing.Size(99, 20)
        Me.chk_pego.TabIndex = 29
        Me.chk_pego.Text = "RETIRADO"
        Me.chk_pego.UseVisualStyleBackColor = True
        '
        'txt_sala
        '
        Me.txt_sala.BackColor = System.Drawing.Color.Turquoise
        Me.txt_sala.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_sala.Location = New System.Drawing.Point(663, 176)
        Me.txt_sala.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_sala.Name = "txt_sala"
        Me.txt_sala.ReadOnly = True
        Me.txt_sala.Size = New System.Drawing.Size(112, 15)
        Me.txt_sala.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(660, 144)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "SALA"
        '
        'txt_categoria
        '
        Me.txt_categoria.BackColor = System.Drawing.Color.Turquoise
        Me.txt_categoria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_categoria.Location = New System.Drawing.Point(219, 176)
        Me.txt_categoria.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_categoria.Name = "txt_categoria"
        Me.txt_categoria.ReadOnly = True
        Me.txt_categoria.Size = New System.Drawing.Size(436, 15)
        Me.txt_categoria.TabIndex = 31
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.Turquoise
        Me.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome.Location = New System.Drawing.Point(216, 115)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.ReadOnly = True
        Me.txt_nome.Size = New System.Drawing.Size(436, 15)
        Me.txt_nome.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(216, 145)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "CATEGORIA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "NOME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(660, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "ID (invisível ooo"
        Me.Label3.Visible = False
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.Color.Turquoise
        Me.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_id.Location = New System.Drawing.Point(663, 115)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(135, 15)
        Me.txt_id.TabIndex = 39
        Me.txt_id.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Status:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(316, 30)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Consulta de Equipamentos"
        '
        'frm_consulta_equipa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.ClientSize = New System.Drawing.Size(1491, 741)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_sala)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_categoria)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chk_pego)
        Me.Controls.Add(Me.chk_devolvido)
        Me.Controls.Add(Me.chk_disponibilidade)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgv_dados)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_consulta_equipa"
        Me.Text = "CONSULTA DE EQUIPAMENTOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_busca As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_campo As ToolStripComboBox
    Friend WithEvents chk_disponibilidade As CheckBox
    Friend WithEvents chk_devolvido As CheckBox
    Friend WithEvents chk_pego As CheckBox
    Friend WithEvents txt_sala As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_categoria As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_gravar As ToolStripButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewCheckBoxColumn
    Friend WithEvents Column5 As DataGridViewCheckBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewCheckBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewImageColumn
End Class
