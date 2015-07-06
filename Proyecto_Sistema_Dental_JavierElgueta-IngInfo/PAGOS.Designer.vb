<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAGOS
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PAGOS))
        Me.txtRutPagos = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bPago = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.bBusPac = New System.Windows.Forms.Button()
        Me.m3 = New System.Windows.Forms.Label()
        Me.m2 = New System.Windows.Forms.Label()
        Me.m1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnVerPagos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRutPagos
        '
        Me.txtRutPagos.BackColor = System.Drawing.Color.White
        Me.txtRutPagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRutPagos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutPagos.ForeColor = System.Drawing.Color.Navy
        Me.txtRutPagos.Location = New System.Drawing.Point(3, 46)
        Me.txtRutPagos.Name = "txtRutPagos"
        Me.txtRutPagos.Size = New System.Drawing.Size(597, 26)
        Me.txtRutPagos.TabIndex = 0
        Me.txtRutPagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.White
        Me.txtNombres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNombres.Enabled = False
        Me.txtNombres.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.ForeColor = System.Drawing.Color.Navy
        Me.txtNombres.Location = New System.Drawing.Point(3, 193)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(597, 26)
        Me.txtNombres.TabIndex = 1
        Me.txtNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(597, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ingresar Rut del Paciente"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(597, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Confirmar Nombres"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bPago
        '
        Me.bPago.AutoSize = True
        Me.bPago.BackColor = System.Drawing.Color.RoyalBlue
        Me.bPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bPago.FlatAppearance.BorderSize = 0
        Me.bPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.bPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.bPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bPago.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPago.Location = New System.Drawing.Point(3, 451)
        Me.bPago.Name = "bPago"
        Me.bPago.Size = New System.Drawing.Size(597, 35)
        Me.bPago.TabIndex = 6
        Me.bPago.Text = "GUARDAR PAGO"
        Me.bPago.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(597, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Ingresar Monto $"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Navy
        Me.TextBox1.Location = New System.Drawing.Point(3, 419)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(597, 26)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bBusPac
        '
        Me.bBusPac.BackColor = System.Drawing.Color.Transparent
        Me.bBusPac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bBusPac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bBusPac.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bBusPac.FlatAppearance.BorderSize = 0
        Me.bBusPac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.bBusPac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.bBusPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBusPac.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBusPac.Image = Global.Proyecto_Sistema_Dental_JavierElgueta_IngInfo.My.Resources.Resources.BuscarPaciente
        Me.bBusPac.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bBusPac.Location = New System.Drawing.Point(3, 78)
        Me.bBusPac.Name = "bBusPac"
        Me.bBusPac.Size = New System.Drawing.Size(597, 66)
        Me.bBusPac.TabIndex = 9
        Me.bBusPac.Text = "Buscar"
        Me.bBusPac.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bBusPac.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.bBusPac.UseVisualStyleBackColor = False
        '
        'm3
        '
        Me.m3.AutoSize = True
        Me.m3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m3.ForeColor = System.Drawing.Color.Red
        Me.m3.Location = New System.Drawing.Point(3, 397)
        Me.m3.Name = "m3"
        Me.m3.Size = New System.Drawing.Size(597, 19)
        Me.m3.TabIndex = 74
        Me.m3.Text = "Obligatorio"
        Me.m3.Visible = False
        '
        'm2
        '
        Me.m2.AutoSize = True
        Me.m2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m2.ForeColor = System.Drawing.Color.Red
        Me.m2.Location = New System.Drawing.Point(3, 171)
        Me.m2.Name = "m2"
        Me.m2.Size = New System.Drawing.Size(597, 19)
        Me.m2.TabIndex = 73
        Me.m2.Text = "Obligatorio"
        Me.m2.Visible = False
        '
        'm1
        '
        Me.m1.AutoSize = True
        Me.m1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m1.ForeColor = System.Drawing.Color.Red
        Me.m1.Location = New System.Drawing.Point(3, 24)
        Me.m1.Name = "m1"
        Me.m1.Size = New System.Drawing.Size(597, 19)
        Me.m1.TabIndex = 72
        Me.m1.Text = "Obligatorio"
        Me.m1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.m1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(3, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(597, 19)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Obligatorio"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(3, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(597, 24)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Confirmar Apellidos"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtApellidos
        '
        Me.txtApellidos.BackColor = System.Drawing.Color.White
        Me.txtApellidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtApellidos.Enabled = False
        Me.txtApellidos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.ForeColor = System.Drawing.Color.Navy
        Me.txtApellidos.Location = New System.Drawing.Point(3, 268)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(597, 26)
        Me.txtApellidos.TabIndex = 77
        Me.txtApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.Location = New System.Drawing.Point(3, 534)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(597, 189)
        Me.DataGridView1.TabIndex = 80
        Me.DataGridView1.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(3, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(597, 19)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Obligatorio"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(3, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(597, 24)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Seleccionar Tratamiento a Pagar"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(3, 343)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(597, 27)
        Me.ComboBox1.TabIndex = 84
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.m1)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtRutPagos)
        Me.FlowLayoutPanel1.Controls.Add(Me.bBusPac)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.m2)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtNombres)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtApellidos)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel1.Controls.Add(Me.ComboBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.m3)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.bPago)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnVerPagos)
        Me.FlowLayoutPanel1.Controls.Add(Me.DataGridView1)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1, 78)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(603, 726)
        Me.FlowLayoutPanel1.TabIndex = 70
        '
        'btnVerPagos
        '
        Me.btnVerPagos.AutoSize = True
        Me.btnVerPagos.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnVerPagos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerPagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnVerPagos.FlatAppearance.BorderSize = 0
        Me.btnVerPagos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnVerPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnVerPagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVerPagos.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerPagos.Location = New System.Drawing.Point(3, 492)
        Me.btnVerPagos.Name = "btnVerPagos"
        Me.btnVerPagos.Size = New System.Drawing.Size(597, 36)
        Me.btnVerPagos.TabIndex = 85
        Me.btnVerPagos.Text = "VER HISTORIAL DE PAGOS"
        Me.btnVerPagos.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(672, 70)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Pagos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'PAGOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(689, 773)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(1, 1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PAGOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRutPagos As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bPago As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents bBusPac As System.Windows.Forms.Button
    Friend WithEvents m3 As System.Windows.Forms.Label
    Friend WithEvents m2 As System.Windows.Forms.Label
    Friend WithEvents m1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnVerPagos As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
