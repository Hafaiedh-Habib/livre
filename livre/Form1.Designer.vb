<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label2 = New Label()
        Label3 = New Label()
        txtISBN = New TextBox()
        txtAuteur = New TextBox()
        txtTitre = New TextBox()
        btnAfficher = New Button()
        btnAjouter = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(21, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 25)
        Label2.TabIndex = 1
        Label2.Text = "Titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(21, 203)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 25)
        Label3.TabIndex = 2
        Label3.Text = "Auteur"
        ' 
        ' txtISBN
        ' 
        txtISBN.Location = New Point(150, 93)
        txtISBN.Name = "txtISBN"
        txtISBN.Size = New Size(100, 23)
        txtISBN.TabIndex = 3
        ' 
        ' txtAuteur
        ' 
        txtAuteur.Location = New Point(150, 203)
        txtAuteur.Name = "txtAuteur"
        txtAuteur.Size = New Size(100, 23)
        txtAuteur.TabIndex = 4
        ' 
        ' txtTitre
        ' 
        txtTitre.Location = New Point(150, 147)
        txtTitre.Name = "txtTitre"
        txtTitre.Size = New Size(100, 23)
        txtTitre.TabIndex = 5
        ' 
        ' btnAfficher
        ' 
        btnAfficher.Location = New Point(150, 309)
        btnAfficher.Name = "btnAfficher"
        btnAfficher.Size = New Size(100, 43)
        btnAfficher.TabIndex = 6
        btnAfficher.Text = "Afficher"
        btnAfficher.UseVisualStyleBackColor = True
        ' 
        ' btnAjouter
        ' 
        btnAjouter.Location = New Point(34, 309)
        btnAjouter.Name = "btnAjouter"
        btnAjouter.Size = New Size(103, 43)
        btnAjouter.TabIndex = 7
        btnAjouter.Text = "Ajouter"
        btnAjouter.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(21, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 25)
        Label1.TabIndex = 0
        Label1.Text = "ISBN"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(293, 408)
        Controls.Add(btnAjouter)
        Controls.Add(btnAfficher)
        Controls.Add(txtTitre)
        Controls.Add(txtAuteur)
        Controls.Add(txtISBN)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents txtAuteur As TextBox
    Friend WithEvents txtTitre As TextBox
    Friend WithEvents btnAfficher As Button
    Friend WithEvents btnAjouter As Button
    Friend WithEvents Label1 As Label

End Class
