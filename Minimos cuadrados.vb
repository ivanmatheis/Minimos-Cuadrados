Public Class MinimosCuadrados
    Dim c, i, redon, n As Integer
    Dim x(50), y(50), sx, sy, scx, sxy, a, b, vx, vy, xmedia, ymedia As Single

    Private Sub graficar_Click(sender As Object, e As EventArgs) Handles graficar.Click
        g = CreateGraphics()
        For i = 1 To n
            Grafica.Series(0).Points.AddXY(Math.Round(x(i), 2), y(i))
        Next
        Grafica.Series(2).Points.AddXY(Math.Round(vx, 2), vy)
        Grafica.Series(1).Points.AddXY(x(1), a + b * x(1))
        Grafica.Series(1).Points.AddXY(x(n), a + b * x(n))
    End Sub

    Dim g As Graphics

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        Tn.Clear()
        tvx.Clear()
        tc.Clear()
        ta.Clear()
        tb.Clear()
        salida.Rows.Clear()
        Grafica.Series(0).Points.Clear()
        Grafica.Series(1).Points.Clear()
        Grafica.Series(2).Points.Clear()
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub


    Private Sub Parejas_Click(sender As Object, e As EventArgs) Handles Parejas.Click
        n = Tn.Text
        c = tc.Text
        vx = tvx.Text
        redon = c + 2

        For i = 1 To n
            x(i) = InputBox("x(" & i & ")=")
            y(i) = InputBox("y(" & i & ")=")

            salida.Rows.Add(i, x(i), y(i))

            sx = sx + x(i)
            sy = sy + y(i)
            scx = scx + x(i) ^ 2
            sxy = sxy + x(i) * y(i)

        Next
        xmedia = sx / n
        ymedia = sy / n

        b = (sxy - n * xmedia * ymedia) / (scx - n * xmedia ^ 2)
        a = (ymedia - b * xmedia)
        vy = a + b * vx
        ta.Text = "y(x)= " & a & "+" & b & "x"
        tb.Text = "y(" & vx & ")=" & vy
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
