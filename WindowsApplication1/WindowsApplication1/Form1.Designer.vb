<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.pt1 = New System.Windows.Forms.WebBrowser()
        Me.pt2 = New System.Windows.Forms.WebBrowser()
        Me.p3 = New System.Windows.Forms.WebBrowser()
        Me.p4 = New System.Windows.Forms.WebBrowser()
        Me.p5 = New System.Windows.Forms.WebBrowser()
        Me.validate = New System.Windows.Forms.WebBrowser()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pt1
        '
        Me.pt1.Location = New System.Drawing.Point(12, 12)
        Me.pt1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.pt1.Name = "pt1"
        Me.pt1.Size = New System.Drawing.Size(142, 144)
        Me.pt1.TabIndex = 0
        Me.pt1.Url = New System.Uri("", System.UriKind.Relative)
        '
        'pt2
        '
        Me.pt2.Location = New System.Drawing.Point(209, 12)
        Me.pt2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.pt2.Name = "pt2"
        Me.pt2.Size = New System.Drawing.Size(142, 144)
        Me.pt2.TabIndex = 1
        Me.pt2.Url = New System.Uri("", System.UriKind.Relative)
        '
        'p3
        '
        Me.p3.Location = New System.Drawing.Point(443, 12)
        Me.p3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.p3.Name = "p3"
        Me.p3.Size = New System.Drawing.Size(142, 144)
        Me.p3.TabIndex = 2
        Me.p3.Url = New System.Uri("", System.UriKind.Relative)
        '
        'p4
        '
        Me.p4.Location = New System.Drawing.Point(650, 12)
        Me.p4.MinimumSize = New System.Drawing.Size(20, 20)
        Me.p4.Name = "p4"
        Me.p4.Size = New System.Drawing.Size(142, 144)
        Me.p4.TabIndex = 3
        Me.p4.Url = New System.Uri("", System.UriKind.Relative)
        '
        'p5
        '
        Me.p5.Location = New System.Drawing.Point(12, 197)
        Me.p5.MinimumSize = New System.Drawing.Size(20, 20)
        Me.p5.Name = "p5"
        Me.p5.Size = New System.Drawing.Size(142, 144)
        Me.p5.TabIndex = 4
        Me.p5.Tag = ""
        Me.p5.Url = New System.Uri("", System.UriKind.Relative)
        '
        'validate
        '
        Me.validate.Location = New System.Drawing.Point(685, 356)
        Me.validate.MinimumSize = New System.Drawing.Size(20, 20)
        Me.validate.Name = "validate"
        Me.validate.Size = New System.Drawing.Size(142, 144)
        Me.validate.TabIndex = 5
        Me.validate.Url = New System.Uri("", System.UriKind.Relative)
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(281, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(262, 145)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "get codes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 512)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.validate)
        Me.Controls.Add(Me.p5)
        Me.Controls.Add(Me.p4)
        Me.Controls.Add(Me.p3)
        Me.Controls.Add(Me.pt2)
        Me.Controls.Add(Me.pt1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pt1 As System.Windows.Forms.WebBrowser
    Friend WithEvents pt2 As System.Windows.Forms.WebBrowser
    Friend WithEvents p3 As System.Windows.Forms.WebBrowser
    Friend WithEvents p4 As System.Windows.Forms.WebBrowser
    Friend WithEvents p5 As System.Windows.Forms.WebBrowser
    Friend WithEvents validate As System.Windows.Forms.WebBrowser
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
