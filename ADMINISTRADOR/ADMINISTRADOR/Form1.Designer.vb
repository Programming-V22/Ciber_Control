<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBoxPUERTO1 = New System.Windows.Forms.TextBox()
        Me.NumH1 = New System.Windows.Forms.NumericUpDown()
        Me.NumM1 = New System.Windows.Forms.NumericUpDown()
        Me.ButtonBLOQUEO = New System.Windows.Forms.Button()
        Me.ButtonAPAGAR = New System.Windows.Forms.Button()
        Me.ButtonINICIAR = New System.Windows.Forms.Button()
        Me.TextBoxMENSAJES1 = New System.Windows.Forms.TextBox()
        Me.ButtonAÑADIR = New System.Windows.Forms.Button()
        Me.ButtonCERRAR = New System.Windows.Forms.Button()
        Me.ButtonREINICIAR = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.NumH1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumM1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxPUERTO1
        '
        Me.TextBoxPUERTO1.BackColor = System.Drawing.Color.Black
        Me.TextBoxPUERTO1.ForeColor = System.Drawing.Color.Cyan
        Me.TextBoxPUERTO1.Location = New System.Drawing.Point(174, 213)
        Me.TextBoxPUERTO1.Name = "TextBoxPUERTO1"
        Me.TextBoxPUERTO1.Size = New System.Drawing.Size(140, 22)
        Me.TextBoxPUERTO1.TabIndex = 5
        Me.TextBoxPUERTO1.Text = "55555"
        Me.TextBoxPUERTO1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumH1
        '
        Me.NumH1.BackColor = System.Drawing.Color.Black
        Me.NumH1.ForeColor = System.Drawing.Color.Cyan
        Me.NumH1.Location = New System.Drawing.Point(127, 39)
        Me.NumH1.Name = "NumH1"
        Me.NumH1.Size = New System.Drawing.Size(60, 22)
        Me.NumH1.TabIndex = 7
        Me.NumH1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumM1
        '
        Me.NumM1.BackColor = System.Drawing.Color.Black
        Me.NumM1.ForeColor = System.Drawing.Color.Cyan
        Me.NumM1.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumM1.Location = New System.Drawing.Point(214, 39)
        Me.NumM1.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumM1.Name = "NumM1"
        Me.NumM1.Size = New System.Drawing.Size(60, 22)
        Me.NumM1.TabIndex = 8
        Me.NumM1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumM1.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'ButtonBLOQUEO
        '
        Me.ButtonBLOQUEO.BackColor = System.Drawing.Color.Black
        Me.ButtonBLOQUEO.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonBLOQUEO.Location = New System.Drawing.Point(42, 312)
        Me.ButtonBLOQUEO.Name = "ButtonBLOQUEO"
        Me.ButtonBLOQUEO.Size = New System.Drawing.Size(140, 40)
        Me.ButtonBLOQUEO.TabIndex = 10
        Me.ButtonBLOQUEO.Text = "BLOQUEO"
        Me.ButtonBLOQUEO.UseVisualStyleBackColor = False
        '
        'ButtonAPAGAR
        '
        Me.ButtonAPAGAR.BackColor = System.Drawing.Color.Black
        Me.ButtonAPAGAR.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonAPAGAR.Location = New System.Drawing.Point(42, 450)
        Me.ButtonAPAGAR.Name = "ButtonAPAGAR"
        Me.ButtonAPAGAR.Size = New System.Drawing.Size(140, 40)
        Me.ButtonAPAGAR.TabIndex = 11
        Me.ButtonAPAGAR.Text = "APAGAR REMOTO"
        Me.ButtonAPAGAR.UseVisualStyleBackColor = False
        '
        'ButtonINICIAR
        '
        Me.ButtonINICIAR.BackColor = System.Drawing.Color.Black
        Me.ButtonINICIAR.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonINICIAR.Location = New System.Drawing.Point(295, 34)
        Me.ButtonINICIAR.Name = "ButtonINICIAR"
        Me.ButtonINICIAR.Size = New System.Drawing.Size(106, 31)
        Me.ButtonINICIAR.TabIndex = 12
        Me.ButtonINICIAR.Text = "INICIAR"
        Me.ButtonINICIAR.UseVisualStyleBackColor = False
        '
        'TextBoxMENSAJES1
        '
        Me.TextBoxMENSAJES1.BackColor = System.Drawing.Color.Black
        Me.TextBoxMENSAJES1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMENSAJES1.ForeColor = System.Drawing.Color.Yellow
        Me.TextBoxMENSAJES1.Location = New System.Drawing.Point(609, 34)
        Me.TextBoxMENSAJES1.Multiline = True
        Me.TextBoxMENSAJES1.Name = "TextBoxMENSAJES1"
        Me.TextBoxMENSAJES1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxMENSAJES1.Size = New System.Drawing.Size(140, 66)
        Me.TextBoxMENSAJES1.TabIndex = 13
        Me.TextBoxMENSAJES1.Text = "MENSAJES"
        '
        'ButtonAÑADIR
        '
        Me.ButtonAÑADIR.BackColor = System.Drawing.Color.Black
        Me.ButtonAÑADIR.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonAÑADIR.Location = New System.Drawing.Point(407, 34)
        Me.ButtonAÑADIR.Name = "ButtonAÑADIR"
        Me.ButtonAÑADIR.Size = New System.Drawing.Size(118, 31)
        Me.ButtonAÑADIR.TabIndex = 24
        Me.ButtonAÑADIR.Text = "AÑADIR T."
        Me.ButtonAÑADIR.UseVisualStyleBackColor = False
        '
        'ButtonCERRAR
        '
        Me.ButtonCERRAR.BackColor = System.Drawing.Color.Black
        Me.ButtonCERRAR.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonCERRAR.Location = New System.Drawing.Point(42, 358)
        Me.ButtonCERRAR.Name = "ButtonCERRAR"
        Me.ButtonCERRAR.Size = New System.Drawing.Size(140, 40)
        Me.ButtonCERRAR.TabIndex = 25
        Me.ButtonCERRAR.Text = "CERRAR APLICACION"
        Me.ButtonCERRAR.UseVisualStyleBackColor = False
        '
        'ButtonREINICIAR
        '
        Me.ButtonREINICIAR.BackColor = System.Drawing.Color.Black
        Me.ButtonREINICIAR.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonREINICIAR.Location = New System.Drawing.Point(42, 404)
        Me.ButtonREINICIAR.Name = "ButtonREINICIAR"
        Me.ButtonREINICIAR.Size = New System.Drawing.Size(140, 40)
        Me.ButtonREINICIAR.TabIndex = 26
        Me.ButtonREINICIAR.Text = "REINICIAR REMOTO"
        Me.ButtonREINICIAR.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Black
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.ForeColor = System.Drawing.Color.Yellow
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"W7", "XP"})
        Me.ComboBox1.Location = New System.Drawing.Point(27, 34)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(79, 24)
        Me.ComboBox1.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Horas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Segundos"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.ForeColor = System.Drawing.Color.Cyan
        Me.Button1.Location = New System.Drawing.Point(295, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 31)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "INICIAR2"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.ForeColor = System.Drawing.Color.Cyan
        Me.Button2.Location = New System.Drawing.Point(295, 126)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 31)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "INICIAR3"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.Black
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.Cyan
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(216, 85)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(60, 22)
        Me.NumericUpDown1.TabIndex = 33
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.BackColor = System.Drawing.Color.Black
        Me.NumericUpDown2.ForeColor = System.Drawing.Color.Cyan
        Me.NumericUpDown2.Location = New System.Drawing.Point(129, 85)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(60, 22)
        Me.NumericUpDown2.TabIndex = 32
        Me.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.BackColor = System.Drawing.Color.Black
        Me.NumericUpDown3.ForeColor = System.Drawing.Color.Cyan
        Me.NumericUpDown3.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown3.Location = New System.Drawing.Point(216, 131)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(60, 22)
        Me.NumericUpDown3.TabIndex = 35
        Me.NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown3.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.BackColor = System.Drawing.Color.Black
        Me.NumericUpDown4.ForeColor = System.Drawing.Color.Cyan
        Me.NumericUpDown4.Location = New System.Drawing.Point(129, 131)
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(60, 22)
        Me.NumericUpDown4.TabIndex = 34
        Me.NumericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.ForeColor = System.Drawing.Color.Cyan
        Me.Button3.Location = New System.Drawing.Point(407, 80)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 31)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "AÑADIR T."
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.ForeColor = System.Drawing.Color.Cyan
        Me.Button4.Location = New System.Drawing.Point(407, 126)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 31)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "AÑADIR T."
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(795, 514)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.NumericUpDown3)
        Me.Controls.Add(Me.NumericUpDown4)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ButtonREINICIAR)
        Me.Controls.Add(Me.ButtonCERRAR)
        Me.Controls.Add(Me.ButtonAÑADIR)
        Me.Controls.Add(Me.TextBoxMENSAJES1)
        Me.Controls.Add(Me.ButtonINICIAR)
        Me.Controls.Add(Me.ButtonAPAGAR)
        Me.Controls.Add(Me.ButtonBLOQUEO)
        Me.Controls.Add(Me.NumM1)
        Me.Controls.Add(Me.NumH1)
        Me.Controls.Add(Me.TextBoxPUERTO1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Cyan
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADMINISTRADOR"
        CType(Me.NumH1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumM1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxPUERTO1 As System.Windows.Forms.TextBox
    Friend WithEvents NumH1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumM1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents ButtonBLOQUEO As System.Windows.Forms.Button
    Friend WithEvents ButtonAPAGAR As System.Windows.Forms.Button
    Friend WithEvents ButtonINICIAR As System.Windows.Forms.Button
    Friend WithEvents TextBoxMENSAJES1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAÑADIR As System.Windows.Forms.Button
    Friend WithEvents ButtonCERRAR As System.Windows.Forms.Button
    Friend WithEvents ButtonREINICIAR As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
