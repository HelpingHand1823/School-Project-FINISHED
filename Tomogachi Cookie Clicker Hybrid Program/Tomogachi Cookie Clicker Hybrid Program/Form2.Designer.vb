﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button5 = New System.Windows.Forms.Button()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(61, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(392, 31)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Welcome to the Secret Shop!"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(67, 78)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(144, 117)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "Recieve a Cookie Multiplier for only 5000 Cookies!"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(274, 78)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(144, 117)
		Me.Button2.TabIndex = 2
		Me.Button2.Text = "Change the Background of the Form for only 3000 Cookies!"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.Location = New System.Drawing.Point(0, -3)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(512, 475)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 3
		Me.PictureBox1.TabStop = False
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(173, 235)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(144, 117)
		Me.Button3.TabIndex = 4
		Me.Button3.Text = "This'll Change the Text Font for for ya for only 100000 Cookies!"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.Location = New System.Drawing.Point(136, 400)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(75, 23)
		Me.Button4.TabIndex = 5
		Me.Button4.Text = "On"
		Me.Button4.UseVisualStyleBackColor = True
		Me.Button4.Visible = False
		'
		'Button5
		'
		Me.Button5.Location = New System.Drawing.Point(253, 400)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(75, 23)
		Me.Button5.TabIndex = 6
		Me.Button5.Text = "Off"
		Me.Button5.UseVisualStyleBackColor = True
		Me.Button5.Visible = False
		'
		'Form2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(512, 473)
		Me.Controls.Add(Me.Button5)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Name = "Form2"
		Me.Text = "Form2"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Button3 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents Button5 As Button
End Class
