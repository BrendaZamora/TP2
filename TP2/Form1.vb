Public Class Form1
    Dim operacion_ As String
    Dim MiUnitaria As New ClaseUnitaria
    Dim indice_ As Byte

    Public Property operacion() As String
        Get
            Return operacion_

        End Get

        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property
    Public Property indice() As String
        Get
            Return indice_

        End Get

        Set(ByVal value As String)
            indice_ = value
        End Set
    End Property


    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click

        If TextBox1.Text = "" Then
            MsgBox("El Id no puede estar vacio")
            Exit Sub

        End If

        If TextBox2.Text = "" Then
            MsgBox("El IdContribuyente no puede estar vacio")
            Exit Sub

        End If

        If TextBox3.Text.Trim = "" Then
            MsgBox("El Nombre no puede estar vacio")
            Exit Sub

        End If

        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una opcion")
            Exit Sub

        End If

        MiUnitaria.Id = CInt(TextBox1.Text)
        MiUnitaria.IdContribuyente = CInt(textbox2.Text)
        MiUnitaria.Nombre = TextBox3.Text
        MiUnitaria.Categiva = ComboBox1.SelectedItem

        Select Case operacion_
            Case "Agregar"
                lst.Add(MiUnitaria)

            Case "Eliminar"
                If lst.Count = 0 Then Exit Sub

                lst.RemoveAt(indice_)

            Case "Modificar"
                If lst.Count = 0 Then Exit Sub

                lst.Item(indice_) = MiUnitaria

                Grilla.DataGridView1.Refresh()
        End Select
        Me.Close()



    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not Id.Text.IndexOf(".") Then
            e.Handled = False
        ElseIf e.KeyChar = "." Then
            e.Handled = True
        Else
            e.Handled = True
        End If
        Exit Sub

       
    End Sub


    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not IdContribuyente.Text.IndexOf(".") Then
            e.Handled = False
        ElseIf e.KeyChar = "." Then
            e.Handled = True
        Else
            e.Handled = True
            Exit Sub

        End If

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsControl(e.KeyChar) Then

            e.Handled = False
        Else

            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()

    End Sub

    'Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
    '    Dim nom() As String
    '    TextBox3.Text = TextBox3.Text.TrimStart
    '    TextBox3.Text = TextBox3.Text.TrimEnd

    '    nom = TextBox3.Text.Split(" ")
    '    TextBox3.Clear()
    '    Dim x As Integer
    '    For x = 0 To nom.Length - 1
    '        nom(x) = nom(x).Substring(0, 1).ToUpper + nom(x).Substring(1).ToLower
    '        TextBox3.Text = TextBox3.Text + " " + nom(x)
    '    Next
    'End Sub

   

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then

            e.Handled = True
        End If

    End Sub
End Class

