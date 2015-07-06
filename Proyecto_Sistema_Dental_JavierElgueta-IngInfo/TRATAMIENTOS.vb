Imports System.Data.SqlClient
Imports System.IO
Imports System.Data
Imports System.Configuration
Imports System.Text
Public Class TRATAMIENTOS
    Public coneccion As SqlClient.SqlConnection
    Dim accion As String, rut As String, sql As String
    Dim res As Integer, nombres, apellidos, fecha, tratamiento, pieza, zona, estado, hora As String
    Dim com As SqlClient.SqlCommand, dr As SqlClient.SqlDataReader
    Dim da As SqlClient.SqlDataAdapter, cb As SqlClient.SqlCommandBuilder
    Dim ds As DataSet
    Public Sub conectar()
        coneccion = New SqlClient.SqlConnection
        coneccion.ConnectionString = "server=LENOVO-PC; database=DRDENTAL; integrated security=true"
        coneccion.Open()
    End Sub
    Dim conexion As New SqlConnection("server=LENOVO-PC; database=DRDENTAL; integrated security=true")

    Private Sub TRATAMIENTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRut.Select()
        'VerticalScroll.Value = AutoScrollPosition.Y
        Timer1.Start()



        Lfecha.Text = Today
        txtRut.CharacterCasing = CharacterCasing.Upper
        Me.WindowState = FormWindowState.Maximized
        '  My.Forms.Registro.WindowState = FormWindowState.Maximized
        '   Me.txtRut.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        
        'NuevoRepositorio https://github.com/DRDENTAL/Proyecto_Sistema_Dental_JavierElgueta-IngInfo.git

        Dim d As Control = CType(FlowLayoutPanel1, Control)
        'le  establece el top y el Left dentro del Parent  
       
        With d
            ' .Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
            '.Top = (.Parent.ClientSize.Height - Me.Height) \ 2
            .Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.FlowLayoutPanel1.Width) / 2
            '.Left = (.Parent.ClientSize.Width - d.Width) \ 2
        End With


        Try
            Dim da As New SqlDataAdapter("select Rut,Nombres,Apellidos,Fecha,Tratamiento,Pieza,Zona,Estado from dbo.historial", conexion)
            Dim ds As New DataSet
            da.Fill(ds, "historial")
            Me.dgvHistorial.DataSource = ds.Tables("historial")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try

            Dim da As New SqlDataAdapter("select nombre from dbo.presupuesto", conexion)
            Dim ds As New DataSet
            da.Fill(ds, "presupuesto")
            cbTratamiento.DataSource = ds.Tables(0)
            cbTratamiento.ValueMember = ds.Tables(0).Columns(0).Caption
            cbTratamiento.DisplayMember = ds.Tables(0).Columns(0).Caption.ToString
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        
    End Sub

    Private Sub cbTratamiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTratamiento.SelectedIndexChanged

    End Sub

    Private Sub txtRut_TextChanged(sender As Object, e As EventArgs) Handles txtRut.TextChanged

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        verificarrut()
    End Sub
    Private Sub verificarrut()
        rut = txtRut.Text
        nombres = Lnom.Text
        If rut = "" Then
            m1.Visible = True
            Lnom.Visible = False
            lApe.Visible = False
            Try
                Dim da As New SqlDataAdapter("select Rut,Nombres,Apellidos,Fecha,Tratamiento,Pieza,Zona,Estado from dbo.historial ", conexion)
                Dim ds As New DataSet
                da.Fill(ds, "historial")
                Me.dgvHistorial.DataSource = ds.Tables("historial")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            m1.Visible = False
        End If
        Call Me.buscarpaciente()
    End Sub
    Private Sub buscarpaciente()
        If rut <> "" Then
            Sql = "exec buscar_pacientes '" + rut + "'"
            conectar()
            com = New SqlClient.SqlCommand(Sql, coneccion)
            dr = com.ExecuteReader
            If dr.Read Then
                Me.Lnom.Text = dr(1)
                Me.lApe.Text = dr(2)
                Lnom.Visible = True
                lApe.Visible = True
                Try
                    Dim da As New SqlDataAdapter("select Rut,Nombres,Apellidos,Fecha,Tratamiento,Pieza,Zona,Estado,Hora from dbo.historial where Rut = '" & rut & "'", conexion)
                    Dim ds As New DataSet
                    da.Fill(ds, "historial")
                    Me.dgvHistorial.DataSource = ds.Tables("historial")

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                MsgBox("Puede guardar tratamientos", MsgBoxStyle.Exclamation, "Paciente correcto")
            Else
                MsgBox("Paciente no existe", MsgBoxStyle.Exclamation, "Acceso Denegado")
                txtRut.Text = ""
                Lnom.Visible = False
                lApe.Visible = False

                
                m1.Visible = False

                'Dim result As Integer = MessageBox.Show("¿ Desea Ingresar un Nuevo Paciente ?", "Busqueda Finalizada", MessageBoxButtons.YesNo)
                'If result = DialogResult.No Then
                '    txtNombres.Enabled = False
                '    txtApellidos.Enabled = False
                'ElseIf result = DialogResult.Yes Then
                '    txtNombres.Enabled = True
                '    txtApellidos.Enabled = True
                'End If
                coneccion.Close()
                
                Try
                    Dim da As New SqlDataAdapter("select Rut,Nombres,Apellidos,Fecha,Tratamiento,Pieza,Zona,Estado from dbo.historial ", conexion)
                    Dim ds As New DataSet
                    da.Fill(ds, "historial")
                    Me.dgvHistorial.DataSource = ds.Tables("historial")

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles LFin.Click
        If Raba.Checked = True Then
            Daba.FillColor = Color.Lime
            Daba.Visible = True
        End If
        If Rarr.Checked = True Then
            Darr.FillColor = Color.Lime
            Darr.Visible = True
        End If
        If Rder.Checked = True Then
            Dder.FillColor = Color.Lime
            Dder.Visible = True
        End If
        If Rizq.Checked = True Then
            Dizq.FillColor = Color.Lime
            Dizq.Visible = True
        End If
        If Rcen.Checked = True Then
            Dcen.FillColor = Color.Lime
            Dcen.Visible = True
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles LDet.Click
        If Raba.Checked = True Then
            Daba.FillColor = Color.Yellow
            Daba.Visible = True
        End If
        If Rarr.Checked = True Then
            Darr.FillColor = Color.Yellow
            Darr.Visible = True
        End If
        If Rizq.Checked = True Then
            Dizq.FillColor = Color.Yellow
            Dizq.Visible = True
        End If
        If Rder.Checked = True Then
            Dder.FillColor = Color.Yellow
            Dder.Visible = True
        End If
        If Rcen.Checked = True Then
            Dcen.FillColor = Color.Yellow
            Dcen.Visible = True
        End If
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles LIni.Click
        If Raba.Checked = True Then
            Daba.FillColor = Color.Red
            Daba.Visible = True
        End If
        If Rarr.Checked = True Then
            Darr.FillColor = Color.Red
            Darr.Visible = True
        End If
        If Rizq.Checked = True Then
            Dizq.FillColor = Color.Red
            Dizq.Visible = True
        End If
        If Rder.Checked = True Then
            Dder.FillColor = Color.Red
            Dder.Visible = True
        End If
        If Rcen.Checked = True Then
            Dcen.FillColor = Color.Red
            Dcen.Visible = True
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        If Raba.Checked = True Then
            Daba.FillColor = Color.Red
            Daba.Visible = True
        End If
        If Rarr.Checked = True Then
            Darr.FillColor = Color.Red
            Darr.Visible = True
        End If
        If Rizq.Checked = True Then
            Dizq.FillColor = Color.Red
            Dizq.Visible = True
        End If
        If Rder.Checked = True Then
            Dder.FillColor = Color.Red
            Dder.Visible = True
        End If
        If Rcen.Checked = True Then
            Dcen.FillColor = Color.Red
            Dcen.Visible = True
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        If Raba.Checked = True Then
            Daba.FillColor = Color.Yellow
            Daba.Visible = True
        End If
        If Rarr.Checked = True Then
            Darr.FillColor = Color.Yellow
            Darr.Visible = True
        End If
        If Rizq.Checked = True Then
            Dizq.FillColor = Color.Yellow
            Dizq.Visible = True
        End If
        If Rder.Checked = True Then
            Dder.FillColor = Color.Yellow
            Dder.Visible = True
        End If
        If Rcen.Checked = True Then
            Dcen.FillColor = Color.Yellow
            Dcen.Visible = True
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If Raba.Checked = True Then
            Daba.FillColor = Color.Lime
            Daba.Visible = True
        End If
        If Rarr.Checked = True Then
            Darr.FillColor = Color.Lime
            Darr.Visible = True
        End If
        If Rizq.Checked = True Then
            Dizq.FillColor = Color.Lime
            Dizq.Visible = True
        End If
        If Rder.Checked = True Then
            Dder.FillColor = Color.Lime
            Dder.Visible = True
        End If
        If Rcen.Checked = True Then
            Dcen.FillColor = Color.Lime
            Dcen.Visible = True
        End If
    End Sub

    Private Sub txtRut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRut.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Timer1.Start()
        Call Me.verificardatos()
    End Sub
    Private Sub verificardatos()
        rut = txtRut.Text
        nombres = Lnom.Text
        apellidos = lApe.Text
        If rut = "" Then
            m1.Visible = True
        Else
            m1.Visible = False
        End If
        If Lnom.Visible = True Then
            nombres = Lnom.Text
        End If
        If lApe.Visible = True Then
            apellidos = lApe.Text
        End If

        If Lnom.Visible = False And lApe.Visible = False Then
            MsgBox("Falta nombres y apellidos")
        Else
            If Rder.Checked = False And Rizq.Checked = False And Rcen.Checked = False And Rarr.Checked = False And Raba.Checked = False Then
                MsgBox("DEBE SELECCIONAR UNA ZONA DENTAL")
            Else
                If Dizq.FillColor = Color.Black And Dder.FillColor = Color.Black And Darr.FillColor = Color.Black And Daba.FillColor = Color.Black And Dcen.FillColor = Color.Black Then
                    MsgBox("FALTA seleccionar ESTADO de la Pieza")
                Else
                    'Timer1.Start()
                    Call Me.registrarhistorial()
                End If
                End If
            End If
    End Sub
    Private Sub registrarhistorial()
        rut = txtRut.Text
        nombres = Lnom.Text
        apellidos = lApe.Text
        tratamiento = cbTratamiento.Text
        pieza = nudNpieza.Text
        hora = LHora.Text
        fecha = Lfecha.Text
        If Darr.FillColor = Color.Red Then
            estado = LIni.Text
        End If
        If Daba.FillColor = Color.Red Then
            estado = LIni.Text
        End If
        If Dder.FillColor = Color.Red Then
            estado = LIni.Text
        End If
        If Dizq.FillColor = Color.Red Then
            estado = LIni.Text
        End If
        If Dcen.FillColor = Color.Red Then
            estado = LIni.Text
        End If

        If Darr.FillColor = Color.Lime Then
            estado = LFin.Text
        End If
        If Daba.FillColor = Color.Lime Then
            estado = LFin.Text
        End If
        If Dder.FillColor = Color.Lime Then
            estado = LFin.Text
        End If
        If Dizq.FillColor = Color.Lime Then
            estado = LFin.Text
        End If
        If Dcen.FillColor = Color.Lime Then
            estado = LFin.Text
        End If

        If Darr.FillColor = Color.Yellow Then
            estado = LDet.Text
        End If
        If Daba.FillColor = Color.Yellow Then
            estado = LDet.Text
        End If
        If Dder.FillColor = Color.Yellow Then
            estado = LDet.Text
        End If
        If Dizq.FillColor = Color.Yellow Then
            estado = LDet.Text
        End If
        If Dcen.FillColor = Color.Yellow Then
            estado = LDet.Text
        End If

        If Rarr.Checked = True Then
            zona = Label7Sup.Text
        End If
        If Raba.Checked = True Then
            zona = Label7Inf.Text
        End If
        If Rder.Checked = True Then
            zona = Label7Der.Text
        End If
        If Rizq.Checked = True Then
            zona = Label7Izq.Text
        End If
        If Rcen.Checked = True Then
            zona = Label7Cen.Text
        End If

        sql = "exec ver_pacientes '" + rut + "'"
        conectar()
        com = New SqlClient.SqlCommand(sql, coneccion)
        dr = com.ExecuteReader

        If dr.Read Then
            ' com = New SqlClient.SqlCommand(sql, coneccion)
            'sql = "exec editar_historial" + "'" + rut + "','" + nombres + "','" + apellidos + "','" + tratamiento + "','" + pieza + "','" + hora + "'"
            'conectar()
            'com = New SqlClient.SqlCommand(sql, coneccion)
            'res = com.ExecuteNonQuery
            'MessageBox.Show("Ha guardado exitosamente", "historial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'coneccion.Close()

            ' Try
            'Dim da As New SqlDataAdapter("select Rut,Nombres,Apellidos,Fecha,Tratamiento,Pieza,Zona,Hora,Estado from dbo.historial where Rut= '" & rut & "' ", conexion)
            'Dim ds As New DataSet
            ' da.Fill(ds, "historial")
            'Me.dgvHistorial.DataSource = ds.Tables("historial")

            ' Catch ex As Exception
            'MsgBox(ex.Message)
            'End Try
            'txtRut.Text = ""
            'segunda
            'sql = "exec ver_pacientes '" + rut + "'"
            'conectar()
            'com = New SqlClient.SqlCommand(sql, coneccion)
            'dr = com.ExecuteReader
            'If dr.Read Then
            '    If rut = dr(0) And nombres = dr(1) Then
            '        'AGENDA.txtrut.Text = dr(0)
            '        'AGENDA.txtNombres.Text = dr(1)
            '        Me.Close()
            '        'AGENDA.Show()
            '    End If
            'End If



            sql = "exec ingresar_historial '" + rut + "','" + nombres + "','" + apellidos + "','" + fecha + "','" + tratamiento + "','" + pieza + "','" + zona + "','" + estado + "','" + hora + "'"
            conectar()
            com = New SqlClient.SqlCommand(sql, coneccion)
            res = com.ExecuteNonQuery
            coneccion.Close()

            Try
                Dim da As New SqlDataAdapter("select Rut,Nombres,Apellidos,Fecha,Tratamiento,Pieza,Zona,Estado,Hora from dbo.historial where Rut= '" & rut & "'", conexion)
                Dim ds As New DataSet
                da.Fill(ds, "historial")
                Me.dgvHistorial.DataSource = ds.Tables("historial")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            txtRut.Text = ""

            'sql = "exec ver_pacientes '" + rut + "'"
            'conectar()
            'com = New SqlClient.SqlCommand(sql, coneccion)
            'dr = com.ExecuteReader
            'If dr.Read Then
            '    If rut = dr(0) And nombres = dr(1) Then
            '        'AGENDA.txtrut.Text = dr(0)
            '        'AGENDA.txtNombres.Text = dr(1)
            '        Me.Close()
            '        'AGENDA.Show()
            '    End If
            'End If



            MsgBox("Historial Guardado Correctamente", MsgBoxStyle.Information, "Información almacenada")
        End If
        Timer1.Stop()
    End Sub

    Private Sub txtRut_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRut.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                btnBuscar.PerformClick()
                If txtRut.Text = Nothing Then

                    m1.Visible = True
                End If
                txtRut.Focus()

        End Select
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)


    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        LHora.Text = TimeOfDay
    End Sub
End Class