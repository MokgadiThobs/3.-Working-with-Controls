<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BtnAdd = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        BtnSubtract = New Button()
        BtnDivide = New Button()
        BtnMultiply = New Button()
        TextBox3 = New TextBox()
        BtnAnswer = New Label()
        SuspendLayout()
        ' 
        ' BtnAdd
        ' 
        BtnAdd.Location = New Point(54, 235)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(75, 23)
        BtnAdd.TabIndex = 0
        BtnAdd.Text = "+"
        BtnAdd.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(285, 71)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(157, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 15)
        Label1.TabIndex = 2
        Label1.Text = "Enter Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(157, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 15)
        Label2.TabIndex = 3
        Label2.Text = "Enter Number"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(285, 125)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 4
        ' 
        ' BtnSubtract
        ' 
        BtnSubtract.Location = New Point(163, 235)
        BtnSubtract.Name = "BtnSubtract"
        BtnSubtract.Size = New Size(75, 23)
        BtnSubtract.TabIndex = 5
        BtnSubtract.Text = "-"
        BtnSubtract.UseVisualStyleBackColor = True
        ' 
        ' BtnDivide
        ' 
        BtnDivide.Location = New Point(310, 235)
        BtnDivide.Name = "BtnDivide"
        BtnDivide.Size = New Size(75, 23)
        BtnDivide.TabIndex = 6
        BtnDivide.Text = "/"
        BtnDivide.UseVisualStyleBackColor = True
        ' 
        ' BtnMultiply
        ' 
        BtnMultiply.Location = New Point(427, 235)
        BtnMultiply.Name = "BtnMultiply"
        BtnMultiply.Size = New Size(75, 23)
        BtnMultiply.TabIndex = 7
        BtnMultiply.Text = "*"
        BtnMultiply.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(285, 180)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 8
        ' 
        ' BtnAnswer
        ' 
        BtnAnswer.AutoSize = True
        BtnAnswer.Location = New Point(172, 188)
        BtnAnswer.Name = "BtnAnswer"
        BtnAnswer.Size = New Size(46, 15)
        BtnAnswer.TabIndex = 9
        BtnAnswer.Text = "Answer"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnAnswer)
        Controls.Add(TextBox3)
        Controls.Add(BtnMultiply)
        Controls.Add(BtnDivide)
        Controls.Add(BtnSubtract)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(BtnAdd)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnAdd As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BtnSubtract As Button
    Friend WithEvents BtnDivide As Button
    Friend WithEvents BtnMultiply As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents BtnAnswer As Label
End Class
