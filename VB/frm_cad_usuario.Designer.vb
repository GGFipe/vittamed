<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cad_usuario
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cad_usuario))
        Me.cmb_usuario = New System.Windows.Forms.ComboBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_crm = New System.Windows.Forms.Label()
        Me.txt_crm = New System.Windows.Forms.MaskedTextBox()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.lbl_senha = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_usuario
        '
        Me.cmb_usuario.BackColor = System.Drawing.Color.Turquoise
        Me.cmb_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_usuario.Font = New System.Drawing.Font("Yu Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_usuario.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cmb_usuario.FormattingEnabled = True
        Me.cmb_usuario.Items.AddRange(New Object() {"Médico", "Recepcionista", "Gerente"})
        Me.cmb_usuario.Location = New System.Drawing.Point(137, 59)
        Me.cmb_usuario.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cmb_usuario.Name = "cmb_usuario"
        Me.cmb_usuario.Size = New System.Drawing.Size(225, 26)
        Me.cmb_usuario.TabIndex = 0
        Me.cmb_usuario.Text = "TIPO DE USUÁRIO"
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.Turquoise
        Me.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome.Location = New System.Drawing.Point(137, 122)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(227, 15)
        Me.txt_nome.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NOME DE USUÁRIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(131, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "E-MAIL"
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.Turquoise
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_email.Location = New System.Drawing.Point(137, 180)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(227, 15)
        Me.txt_email.TabIndex = 2
        '
        'lbl_crm
        '
        Me.lbl_crm.AutoSize = True
        Me.lbl_crm.Font = New System.Drawing.Font("Yu Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_crm.Location = New System.Drawing.Point(131, 268)
        Me.lbl_crm.Name = "lbl_crm"
        Me.lbl_crm.Size = New System.Drawing.Size(40, 18)
        Me.lbl_crm.TabIndex = 5
        Me.lbl_crm.Text = "CRM"
        Me.lbl_crm.Visible = False
        '
        'txt_crm
        '
        Me.txt_crm.BackColor = System.Drawing.Color.Turquoise
        Me.txt_crm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_crm.ForeColor = System.Drawing.Color.Black
        Me.txt_crm.Location = New System.Drawing.Point(135, 287)
        Me.txt_crm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_crm.Name = "txt_crm"
        Me.txt_crm.Size = New System.Drawing.Size(227, 15)
        Me.txt_crm.TabIndex = 4
        Me.txt_crm.Visible = False
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cadastrar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn_cadastrar.Location = New System.Drawing.Point(193, 326)
        Me.btn_cadastrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Padding = New System.Windows.Forms.Padding(9)
        Me.btn_cadastrar.Size = New System.Drawing.Size(111, 44)
        Me.btn_cadastrar.TabIndex = 5
        Me.btn_cadastrar.Text = "Cadastrar"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'lbl_senha
        '
        Me.lbl_senha.AutoSize = True
        Me.lbl_senha.Font = New System.Drawing.Font("Yu Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_senha.Location = New System.Drawing.Point(133, 215)
        Me.lbl_senha.Name = "lbl_senha"
        Me.lbl_senha.Size = New System.Drawing.Size(55, 18)
        Me.lbl_senha.TabIndex = 9
        Me.lbl_senha.Text = "SENHA"
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.Turquoise
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_senha.Location = New System.Drawing.Point(137, 234)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(227, 15)
        Me.txt_senha.TabIndex = 3
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(401, 59)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(383, 311)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(252, 29)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Cadastro de Usuário"
        '
        'frm_cad_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_senha)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.txt_crm)
        Me.Controls.Add(Me.lbl_crm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.cmb_usuario)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_cad_usuario"
        Me.Text = "CADASTRO DE USUÁRIO"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_usuario As ComboBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents lbl_crm As Label
    Friend WithEvents txt_crm As MaskedTextBox
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents lbl_senha As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
End Class
