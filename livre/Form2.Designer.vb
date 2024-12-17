<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lstAuteur = New ListBox()
        lstTitre = New ListBox()
        lstISBN = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(41, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 32)
        Label1.TabIndex = 1
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(240, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 32)
        Label2.TabIndex = 2
        Label2.Text = "Titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(442, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 32)
        Label3.TabIndex = 3
        Label3.Text = "Auteur"
        ' 
        ' lstAuteur
        ' 
        lstAuteur.FormattingEnabled = True
        lstAuteur.Location = New Point(442, 124)
        lstAuteur.Margin = New Padding(3, 4, 3, 4)
        lstAuteur.Name = "lstAuteur"
        lstAuteur.Size = New Size(156, 264)
        lstAuteur.TabIndex = 4
        ' 
        ' lstTitre
        ' 
        lstTitre.FormattingEnabled = True
        lstTitre.Location = New Point(240, 124)
        lstTitre.Margin = New Padding(3, 4, 3, 4)
        lstTitre.Name = "lstTitre"
        lstTitre.Size = New Size(156, 264)
        lstTitre.TabIndex = 5
        ' 
        ' lstISBN
        ' 
        lstISBN.FormattingEnabled = True
        lstISBN.Location = New Point(41, 124)
        lstISBN.Margin = New Padding(3, 4, 3, 4)
        lstISBN.Name = "lstISBN"
        lstISBN.Size = New Size(156, 264)
        lstISBN.TabIndex = 6
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(623, 439)
        Controls.Add(lstISBN)
        Controls.Add(lstTitre)
        Controls.Add(lstAuteur)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Public WithEvents lstAuteur As ListBox
    Public WithEvents lstTitre As ListBox
    Public WithEvents lstISBN As ListBox
End Class
