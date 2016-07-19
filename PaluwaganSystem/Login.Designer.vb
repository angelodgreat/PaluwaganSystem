<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits Telerik.WinControls.UI.RadForm

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
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.VisualStudio2012DarkTheme1 = New Telerik.WinControls.Themes.VisualStudio2012DarkTheme()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.RadButton1)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox1.Controls.Add(Me.RadTextBox2)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Controls.Add(Me.RadTextBox1)
        Me.RadGroupBox1.HeaderText = "Login"
        Me.RadGroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(368, 193)
        Me.RadGroupBox1.TabIndex = 2
        Me.RadGroupBox1.Text = "Login"
        Me.RadGroupBox1.ThemeName = "VisualStudio2012Dark"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(207, 127)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(110, 24)
        Me.RadButton1.TabIndex = 6
        Me.RadButton1.Text = "Login"
        Me.RadButton1.ThemeName = "VisualStudio2012Dark"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(51, 86)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(56, 18)
        Me.RadLabel2.TabIndex = 5
        Me.RadLabel2.Text = "Password:"
        Me.RadLabel2.ThemeName = "VisualStudio2012Dark"
        '
        'RadTextBox2
        '
        Me.RadTextBox2.Location = New System.Drawing.Point(113, 84)
        Me.RadTextBox2.MinimumSize = New System.Drawing.Size(0, 24)
        Me.RadTextBox2.Name = "RadTextBox2"
        '
        '
        '
        Me.RadTextBox2.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.RadTextBox2.Size = New System.Drawing.Size(204, 24)
        Me.RadTextBox2.TabIndex = 4
        Me.RadTextBox2.ThemeName = "VisualStudio2012Dark"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(48, 60)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(59, 18)
        Me.RadLabel1.TabIndex = 3
        Me.RadLabel1.Text = "Username:"
        Me.RadLabel1.ThemeName = "VisualStudio2012Dark"
        '
        'RadTextBox1
        '
        Me.RadTextBox1.Location = New System.Drawing.Point(113, 58)
        Me.RadTextBox1.MinimumSize = New System.Drawing.Size(0, 24)
        Me.RadTextBox1.Name = "RadTextBox1"
        '
        '
        '
        Me.RadTextBox1.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.RadTextBox1.Size = New System.Drawing.Size(204, 24)
        Me.RadTextBox1.TabIndex = 2
        Me.RadTextBox1.ThemeName = "VisualStudio2012Dark"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 218)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Name = "Login"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Paluwagan System"
        Me.ThemeName = "VisualStudio2012Dark"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents VisualStudio2012DarkTheme1 As Telerik.WinControls.Themes.VisualStudio2012DarkTheme
End Class

