Public Class Form1
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Dim l As Livre
        l.titre = txtTitre.Text
        l.auteur = txtAuteur.Text
        l.ISBN = Val(txtISBN.Text)

        If String.IsNullOrWhiteSpace(l.titre) OrElse String.IsNullOrWhiteSpace(l.auteur) OrElse l.ISBN = 0 Then
            MsgBox("Veuillez remplir tous les champs correctement.")
            Exit Sub
        End If

        Dim result As Boolean = AjouterLivre(l)
        If result Then
            MsgBox("Livre ajouté avec succès.")
            txtTitre.Clear()
            txtAuteur.Clear()
            txtISBN.Clear()
        ElseIf Bibliotheque.Length = 100 Then
            MsgBox("La bibliothèque est pleine, impossible d'ajouter ce livre.")
        Else
            MsgBox("Ce livre existe déjà dans la bibliothèque.")
        End If
    End Sub

    Private Sub btnAfficher_Click(sender As Object, e As EventArgs) Handles btnAfficher.Click
        Form2.Show()
    End Sub
End Class
