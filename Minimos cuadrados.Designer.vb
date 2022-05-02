<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MinimosCuadrados
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.labelpar = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ta = New System.Windows.Forms.TextBox()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.tvx = New System.Windows.Forms.TextBox()
        Me.Tn = New System.Windows.Forms.TextBox()
        Me.Parejas = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.graficar = New System.Windows.Forms.Button()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grafica = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.salida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grafica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelpar
        '
        Me.labelpar.AutoSize = True
        Me.labelpar.BackColor = System.Drawing.Color.LightCyan
        Me.labelpar.Location = New System.Drawing.Point(86, 48)
        Me.labelpar.Name = "labelpar"
        Me.labelpar.Size = New System.Drawing.Size(125, 13)
        Me.labelpar.TabIndex = 0
        Me.labelpar.Text = "Dame numero de parejas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightCyan
        Me.Label2.Location = New System.Drawing.Point(86, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dame valor a interpolar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightCyan
        Me.Label3.Location = New System.Drawing.Point(86, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dame cifras sifnificativas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightCyan
        Me.Label4.Location = New System.Drawing.Point(68, 358)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "La recta de minimos cuadrados es:"
        '
        'ta
        '
        Me.ta.BackColor = System.Drawing.Color.LightCyan
        Me.ta.Location = New System.Drawing.Point(301, 355)
        Me.ta.Name = "ta"
        Me.ta.Size = New System.Drawing.Size(100, 20)
        Me.ta.TabIndex = 4
        '
        'tc
        '
        Me.tc.BackColor = System.Drawing.Color.LightCyan
        Me.tc.Location = New System.Drawing.Point(260, 144)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(100, 20)
        Me.tc.TabIndex = 5
        '
        'tvx
        '
        Me.tvx.BackColor = System.Drawing.Color.LightCyan
        Me.tvx.Location = New System.Drawing.Point(260, 97)
        Me.tvx.Name = "tvx"
        Me.tvx.Size = New System.Drawing.Size(100, 20)
        Me.tvx.TabIndex = 6
        '
        'Tn
        '
        Me.Tn.BackColor = System.Drawing.Color.LightCyan
        Me.Tn.Location = New System.Drawing.Point(260, 48)
        Me.Tn.Name = "Tn"
        Me.Tn.Size = New System.Drawing.Size(100, 20)
        Me.Tn.TabIndex = 7
        '
        'Parejas
        '
        Me.Parejas.Location = New System.Drawing.Point(421, 55)
        Me.Parejas.Name = "Parejas"
        Me.Parejas.Size = New System.Drawing.Size(101, 23)
        Me.Parejas.TabIndex = 8
        Me.Parejas.Text = "Introducir parejas"
        Me.Parejas.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(421, 100)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Calcular"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'graficar
        '
        Me.graficar.Location = New System.Drawing.Point(434, 191)
        Me.graficar.Name = "graficar"
        Me.graficar.Size = New System.Drawing.Size(75, 23)
        Me.graficar.TabIndex = 10
        Me.graficar.Text = "Graficar"
        Me.graficar.UseVisualStyleBackColor = True
        '
        'limpiar
        '
        Me.limpiar.Location = New System.Drawing.Point(434, 256)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(75, 23)
        Me.limpiar.TabIndex = 11
        Me.limpiar.Text = "Limpiar "
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(434, 315)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Salir"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'salida
        '
        Me.salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.salida.Location = New System.Drawing.Point(66, 191)
        Me.salida.Name = "salida"
        Me.salida.Size = New System.Drawing.Size(349, 147)
        Me.salida.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.HeaderText = "Indice"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "x(i)"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "y(i)"
        Me.Column3.Name = "Column3"
        '
        'Grafica
        '
        ChartArea2.Name = "ChartArea1"
        Me.Grafica.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Grafica.Legends.Add(Legend2)
        Me.Grafica.Location = New System.Drawing.Point(567, 55)
        Me.Grafica.Name = "Grafica"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series5.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Series5.Legend = "Legend1"
        Series5.Name = "Series2"
        Series5.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series6.Legend = "Legend1"
        Series6.Name = "Series3"
        Me.Grafica.Series.Add(Series4)
        Me.Grafica.Series.Add(Series5)
        Me.Grafica.Series.Add(Series6)
        Me.Grafica.Size = New System.Drawing.Size(300, 300)
        Me.Grafica.TabIndex = 17
        Me.Grafica.Text = "Chart1"
        '
        'tb
        '
        Me.tb.BackColor = System.Drawing.Color.LightCyan
        Me.tb.Location = New System.Drawing.Point(301, 395)
        Me.tb.Name = "tb"
        Me.tb.Size = New System.Drawing.Size(100, 20)
        Me.tb.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightCyan
        Me.Label5.Location = New System.Drawing.Point(68, 398)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "El valor interpolado es"
        '
        'MinimosCuadrados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(903, 450)
        Me.Controls.Add(Me.tb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Grafica)
        Me.Controls.Add(Me.salida)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.graficar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Parejas)
        Me.Controls.Add(Me.Tn)
        Me.Controls.Add(Me.tvx)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.ta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labelpar)
        Me.Name = "MinimosCuadrados"
        Me.Text = "Minimos Cuadrados"
        CType(Me.salida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grafica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelpar As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ta As TextBox
    Friend WithEvents tc As TextBox
    Friend WithEvents tvx As TextBox
    Friend WithEvents Tn As TextBox
    Friend WithEvents Parejas As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents graficar As Button
    Friend WithEvents limpiar As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Grafica As DataVisualization.Charting.Chart
    Friend WithEvents tb As TextBox
    Friend WithEvents Label5 As Label
End Class
