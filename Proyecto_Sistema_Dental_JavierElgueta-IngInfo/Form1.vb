Public Class Form1
    Public coneccion As SqlClient.SqlConnection
    Dim rut As String, sql As String
    Dim pass As String
    Dim com As SqlClient.SqlCommand, dr As SqlClient.SqlDataReader
    Dim da As SqlClient.SqlDataAdapter, cb As SqlClient.SqlCommandBuilder
    Dim ds As DataSet
    Dim contador As Byte = 4
    Public Sub conectar()
        coneccion = New SqlClient.SqlConnection
        coneccion.ConnectionString = "server=LENOVO-PC; database=DRDENTAL; integrated security=true"
        coneccion.Open()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'New Point(Form1.Size.Width + 200, Form1.Size.Height + 200)
        txtnick.Focus()
        txtnick.Select()
        txtnick.Text = ""
        txtpass.Text = ""
       
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Me.verificardatos2()
        'For i As Integer = 5 To 110

        'If i = 100 Then



        ' End If

        ' Next
      

    End Sub
    Private Sub verificardatos2()
        rut = txtnick.Text
        pass = txtpass.Text
        If rut = "" Then
            m1.Visible = True
        Else
            m1.Visible = False
        End If
        If pass = "" Then
            m2.Visible = True
        Else
            m2.Visible = False
        End If
        If rut <> "" And pass <> "" Then
            Timer1.Start()
        End If
    End Sub
    Private Sub verificardatos()
        rut = txtnick.Text
        pass = txtpass.Text
        If rut <> "" And pass <> "" Then
            Timer1.Start()
            'Call Me.IniciarSesion()

        End If


    End Sub
    Private Sub IniciarSesion()
        If rut <> "" And pass <> "" Then

            

        End If
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        lmin.Visible = True
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        lmin.Visible = False
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        lCerr.Visible = True
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        lCerr.Visible = False
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        m1.Visible = False
        m2.Visible = False
    End Sub

    Private Sub txtnick_TextChanged(sender As Object, e As EventArgs) Handles txtnick.TextChanged
        If txtnick.TextLength <> 0 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub


    Private Sub txtnick_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnick.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Button1.PerformClick()
                If txtnick.Text = Nothing Then

                    m1.Visible = True
                End If
                txtpass.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub txtpass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpass.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Button1.PerformClick()
                If txtpass.Text = Nothing Then

                    m2.Visible = True
                End If

                txtnick.Focus()
                '`'  txtTotal.Text = (txtTasaB.Text + txtComisionB.Text + txtGasto.Text + txtIva.Text + txtNotificacion.Text)
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Me.Opacity -= 0.07
            'Call Me.IniciarSesion()
            If Me.Opacity = 0.0 Then

                sql = "exec iniciar_sesion '" + rut + "', '" + pass + "'"

                conectar()

                com = New SqlClient.SqlCommand(sql, coneccion)
                dr = com.ExecuteReader
                If dr.Read Then
                    If rut = dr(1) And pass = dr(6) Then
                        ' Timer1.Start()
                        'Proyecto.lusuario.Text = dr(1)

                        Me.Hide()
                        CopiaProyectoAdmin.Show()
                        Timer1.Stop()
                        Timer1.Enabled = False
                        'UseWaitCursor = True
                        contador = 0
                        txtpass.Text = ""
                    Else
                        Me.Show()
                        Me.Opacity = 100.1
                        Timer1.Enabled = True
                        ProgressBar1.Value = 0
                    End If

                Else

                    If txtnick.Text = "admin" And txtpass.Text = "123" Then
                        'Timer1.Start()
                        Me.Hide()
                        ProyectoAdmin.Show()
                        Timer1.Stop()
                        Timer1.Enabled = False
                        contador = 0
                        'ProyectoAdmin.lusuario.Text = txtnick.Text
                        txtnick.Text = ""
                        txtpass.Text = ""
                        ' Else

                        ' MsgBox("Intentelo denuevo porfavor", MsgBoxStyle.Critical, "Nick o Contraseña Incorrecta")
                        ' txtnick.Text = ""
                        'txtpass.Text = ""
                    Else
                        Me.Show()
                        Me.Opacity = 100.1
                        Timer1.Enabled = True
                        ProgressBar1.Value = 0
                    End If
                    
                End If



                'IniciarSesion()
                'Me.Hide()

                'form show
                'ProyectoAdmin.Show()


            End If
        Else
            ProgressBar1.Value += 4
            If ProgressBar1.Value = contador Then
                Dim w As Integer = PictureBox1.Width
                Dim s As Integer = PictureBox1.Height
                Me.PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                Me.PictureBox1.Width = w
                Me.PictureBox1.Width = s
                Me.PictureBox1.Refresh()
            Else
                If ProgressBar1.Value = contador + 16 Then
                    'label.text = ""
                    Dim w As Integer = PictureBox1.Width
                    Dim s As Integer = PictureBox1.Height
                    Me.PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                    Me.PictureBox1.Width = w
                    Me.PictureBox1.Width = s
                    Me.PictureBox1.Refresh()
                    contador += 20
                End If
                If ProgressBar1.Value = 48 Then
                    'label2.text = "listo"
                    Dim w As Integer = PictureBox1.Width
                    Dim s As Integer = PictureBox1.Height
                    Me.PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                    Me.PictureBox1.Width = w
                    Me.PictureBox1.Width = s
                    Me.PictureBox1.Refresh()
                End If
            End If
        End If

    End Sub
End Class
