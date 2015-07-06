Public Class Registro
    Public coneccion As SqlClient.SqlConnection
    Dim accion As String, rut As String, sql As String
    Dim res As Integer, nombres, apellidos, telefono, email, pass As String
    'Dim telefono As Integer
    Dim com As SqlClient.SqlCommand, dr As SqlClient.SqlDataReader
    Dim da As SqlClient.SqlDataAdapter, cb As SqlClient.SqlCommandBuilder
    Dim ds As DataSet

  

    Public Sub conectar()
        coneccion = New SqlClient.SqlConnection
        coneccion.ConnectionString = "server=LENOVO-PC; database=DRDENTAL; integrated security=true"
        coneccion.Open()
    End Sub
    Private Sub Registro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtRut.Select()
        ' Me.txtRut.FindForm()

        Me.txtRut.CharacterCasing = CharacterCasing.Upper
        Me.txtNombres.CharacterCasing = CharacterCasing.Upper
        Me.txtApellidos.CharacterCasing = CharacterCasing.Upper

        Me.WindowState = FormWindowState.Maximized


        'With Screen.PrimaryScreen.WorkingArea
        'Me.FlowLayoutPanel1.Location = New Point(Size.Height - Size.Height / 2 + FlowLayoutPanel1.AutoScrollPosition.X)
        ', Size.Width / 2 + Panel1.AutoScrollPosition.Y
        ' End With

        ' Dim X As Integer = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
        ' Dim Y As Integer = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
        'Me.StartPosition = FormStartPosition.Manual
        'Me.WindowState = FormWindowState.Maximized
        'Me.FlowLayoutPanel1.Location = New System.Drawing.Point(Size.Height / 2 + FlowLayoutPanel1.AutoScrollPosition.X)

        '  Me.txtRut.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        '   Me.txtRut.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Dim c As Control = CType(FlowLayoutPanel1, Control)
        'le  establece el top y el Left dentro del Parent  
        With c
            '   .Top = (.Parent.ClientSize.Height - c.Height) \ 2
            .Left = (.Parent.ClientSize.Width - c.Width) \ 2
        End With
      

        '*********************************************************************************
        ' Funcion para centrar en la pantalla una forma o un objeto
        '*********************************************************************************
        'Sub Centrar(ByVal Registro As Object)
        ' Centrar un Formulario ...  
        ' If TypeOf Registro Is Form Then
        ' Dim frm As Form = CType(Registro, Form)
        '   With Screen.PrimaryScreen.WorkingArea ' Dimensiones de la pantalla sin el TaskBar  
        '       frm.Top = (.Height - frm.Height) \ 2
        '       frm.Left = (.Width - frm.Width) \ 2
        '    End With
        ' Centrar un control dentro del contenedor  
        '   Else
        ' referencia al control  
        ' Dim c As Control = CType(Registro, Control)
        'le  establece el top y el Left dentro del Parent  
        '    With c
        '         .Top = (.Parent.ClientSize.Height - c.Height) \ 2
        '         .Left = (.Parent.ClientSize.Width - c.Width) \ 2
        '      End With
        '    End If
        ' End Sub
        'Public Sub New()
        'InitializeComponent()
        'Me.StartPosition = FormStartPosition.CenterScreen
        'Me.MaximumSize = New Size(800, 600)
        ' Me.MinimumSize = New Size(600, 500)
        'End Sub



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Form1.Show()
    End Sub


    Private Sub verificardatos()
        rut = txtRut.Text
        nombres = txtNombres.Text
        apellidos = txtApellidos.Text
        email = txtEmail.Text
        telefono = txtTelefono.Text
        pass = txtPass.Text
        If txtRut.Text = "" Then
            m1.Visible = True
        Else
            m1.Visible = False
        End If
        If txtNombres.Text = "" Then
            m2.Visible = True
        Else
            m2.Visible = False
        End If
        If txtApellidos.Text = "" Then
            m3.Visible = True
        Else
            m3.Visible = False
        End If

        If txtPass.Text = "" Then
            m6.Visible = True
        Else
            m6.Visible = False
        End If
        txtRut.Select()
        If txtRut.Text <> "" And txtNombres.Text <> "" And txtApellidos.Text <> "" And txtPass.Text <> "" Then
            Call Me.registrarSecretaria()


        End If
    End Sub
    Private Sub registrarSecretaria()
        rut = txtRut.Text
        nombres = txtNombres.Text
        apellidos = txtApellidos.Text
        email = txtEmail.Text
        telefono = txtTelefono.Text
        pass = txtPass.Text
        sql = "exec ver_secretarias '" + rut + "'"
        conectar()
        com = New SqlClient.SqlCommand(sql, coneccion)
        dr = com.ExecuteReader
        If dr.Read Then
            
            com = New SqlClient.SqlCommand(sql, coneccion)
            Dim result As Integer = MessageBox.Show("¿ Está seguro que quiere Guardar ?", "Guardando...", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                sql = "exec editar_secretarias" + "'" + rut + "','" + nombres + "','" + apellidos + "','" + telefono + "','" + email + "','" + pass + "'"
                conectar()
                com = New SqlClient.SqlCommand(sql, coneccion)
                res = com.ExecuteNonQuery
                MessageBox.Show("Ha guardado exitosamente", "secretarias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                coneccion.Close()
            End If
        Else
            Dim result As Integer = MessageBox.Show("¿ Está seguro que quiere Guardar ?", "Guardando...", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                sql = "exec registrar_secretarias" + "'" + rut + "','" + nombres + "','" + apellidos + "','" + telefono + "','" + email + "','" + pass + "'"
                conectar()
                com = New SqlClient.SqlCommand(sql, coneccion)
                res = com.ExecuteNonQuery
                coneccion.Close()
                MsgBox("Felicidades", MsgBoxStyle.Information, "Guardado Correctamente")
            End If
        End If

    End Sub


    Private Sub verificarSecretaria()
        rut = txtRut.Text
        nombres = txtNombres.Text
        apellidos = txtApellidos.Text
        email = txtEmail.Text
        telefono = txtTelefono.Text
        pass = txtPass.Text
        If rut = "" Then
            m1.Visible = True
            m2.Visible = False
            m3.Visible = False
            m6.Visible = False

        Else
            m1.Visible = False
        End If
        txtRut.Select()
        If rut <> "" Then
            Call Me.buscarSecretaria()
        End If

    End Sub
    Private Sub buscarSecretaria()
        If rut <> "" Then
            m1.Visible = False
            sql = "exec buscar_secretarias '" + rut + "'"
            conectar()
            com = New SqlClient.SqlCommand(sql, coneccion)
            dr = com.ExecuteReader
            If dr.Read Then
                Me.txtNombres.Text = dr(2)
                Me.txtApellidos.Text = dr(3)
                Me.txtTelefono.Text = dr(4)
                Me.txtEmail.Text = dr(5)
                Me.txtPass.Text = dr(6)

            Else

                MsgBox("Secretaria no existe", MsgBoxStyle.Critical, "Acceso Denegado")
                txtRut.Text = ""
                txtNombres.Text = ""
                txtApellidos.Text = ""
                txtTelefono.Text = ""
                txtEmail.Text = ""
                txtPass.Text = ""
            End If
            coneccion.Close()
        End If
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        verificarSecretaria()
    End Sub

    ' Private Sub FlowLayoutPanel1_Layout(sender As Object, e As LayoutEventArgs) Handles FlowLayoutPanel1.Layout
    ' Centrar formulario
    '  Me.txtRut.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    '   Me.txtRut.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
    'txtRut.Location(x, y) = 100% / 2

    'End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        
            Call Me.verificardatos()


    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles btnLimpiar.Click
       
        Me.txtRut.Text = ""
        Me.txtNombres.Text = ""
        Me.txtApellidos.Text = ""
        Me.txtTelefono.Text = ""
        Me.txtEmail.Text = ""
        Me.txtPass.Text = ""
        txtRut.Select()
    End Sub

    Private Sub txtRut_MouseLeave_1(sender As Object, e As EventArgs) Handles txtRut.MouseLeave
        LEjemplo.Visible = False
    End Sub

    Private Sub txtRut_MouseHover_1(sender As Object, e As EventArgs) Handles txtRut.MouseHover
        LEjemplo.Visible = True
    End Sub

    Private Sub txtRut_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtRut.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRut_TextChanged(sender As Object, e As EventArgs) Handles txtRut.TextChanged
        m1.Visible = False
    End Sub

    Private Sub txtPass_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                btnRegistrar.PerformClick()
                If txtPass.Text = Nothing Then

                    m6.Visible = True
                End If
                txtPass.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub txtEmail_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                btnRegistrar.PerformClick()

                txtEmail.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub

    Private Sub txtTelefono_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtTelefono.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                btnRegistrar.PerformClick()

                txtTelefono.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub

    Private Sub txtApellidos_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtApellidos.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                btnRegistrar.PerformClick()
                If txtApellidos.Text = Nothing Then

                    m3.Visible = True
                End If
                txtApellidos.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub

    Private Sub txtNombres_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtNombres.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                btnRegistrar.PerformClick()
                If txtNombres.Text = Nothing Then

                    m2.Visible = True
                End If
                txtNombres.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub

    Private Sub txtRut_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtRut.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                btnBuscar.PerformClick()
                If txtRut.Text = Nothing Then

                    m1.Visible = True
                End If
                txtRut.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub

    Private Sub m6_Click(sender As Object, e As EventArgs) Handles m6.Click

    End Sub

    Private Sub m3_Click(sender As Object, e As EventArgs) Handles m3.Click

    End Sub

    Private Sub m1_Click(sender As Object, e As EventArgs) Handles m1.Click

    End Sub
End Class

