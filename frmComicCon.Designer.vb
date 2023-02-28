<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComicCon
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Header = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.radSuperHero = New System.Windows.Forms.RadioButton()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtTotalCost = New System.Windows.Forms.Label()
        Me.radConvention = New System.Windows.Forms.RadioButton()
        Me.radAutographs = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ComicCon_Registration.My.Resources.Resources.ccr
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(492, 326)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Header
        '
        Me.Header.AutoSize = True
        Me.Header.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header.Location = New System.Drawing.Point(535, 42)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(559, 67)
        Me.Header.TabIndex = 1
        Me.Header.Text = "Comic Con Registration"
        '
        'lblOptions
        '
        Me.lblOptions.AutoSize = True
        Me.lblOptions.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptions.Location = New System.Drawing.Point(57, 352)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(242, 35)
        Me.lblOptions.TabIndex = 2
        Me.lblOptions.Text = "Select Badge Type:"
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.Black
        Me.btnCalc.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.Color.White
        Me.btnCalc.Location = New System.Drawing.Point(606, 481)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(170, 54)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(850, 481)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(170, 54)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInput.Location = New System.Drawing.Point(600, 196)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(151, 35)
        Me.lblInput.TabIndex = 5
        Me.lblInput.Text = "Group Size:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'radSuperHero
        '
        Me.radSuperHero.AutoSize = True
        Me.radSuperHero.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSuperHero.Location = New System.Drawing.Point(41, 390)
        Me.radSuperHero.Name = "radSuperHero"
        Me.radSuperHero.Size = New System.Drawing.Size(539, 39)
        Me.radSuperHero.TabIndex = 6
        Me.radSuperHero.TabStop = True
        Me.radSuperHero.Text = "Convention + SuperHero Experience ($380)"
        Me.radSuperHero.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(869, 197)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(126, 35)
        Me.txtInput.TabIndex = 7
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(600, 316)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(226, 35)
        Me.lblTotalCost.TabIndex = 8
        Me.lblTotalCost.Text = "Registration Cost:"
        '
        'txtTotalCost
        '
        Me.txtTotalCost.AutoSize = True
        Me.txtTotalCost.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCost.Location = New System.Drawing.Point(863, 316)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(132, 35)
        Me.txtTotalCost.TabIndex = 9
        Me.txtTotalCost.Text = "$0000.00"
        '
        'radConvention
        '
        Me.radConvention.AutoSize = True
        Me.radConvention.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radConvention.Location = New System.Drawing.Point(41, 480)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(246, 39)
        Me.radConvention.TabIndex = 10
        Me.radConvention.TabStop = True
        Me.radConvention.Text = "Convention ($209)"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'radAutographs
        '
        Me.radAutographs.AutoSize = True
        Me.radAutographs.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAutographs.Location = New System.Drawing.Point(41, 435)
        Me.radAutographs.Name = "radAutographs"
        Me.radAutographs.Size = New System.Drawing.Size(412, 39)
        Me.radAutographs.TabIndex = 11
        Me.radAutographs.TabStop = True
        Me.radAutographs.Text = "Convention + Autographs ($275)"
        Me.radAutographs.UseVisualStyleBackColor = True
        '
        'frmComicCon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(1130, 621)
        Me.Controls.Add(Me.radAutographs)
        Me.Controls.Add(Me.radConvention)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.radSuperHero)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblOptions)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmComicCon"
        Me.Text = "Comic Con Registration"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Header As Label
    Friend WithEvents lblOptions As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblInput As Label
    Friend WithEvents radSuperHero As RadioButton
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents txtTotalCost As Label
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents radAutographs As RadioButton
End Class
