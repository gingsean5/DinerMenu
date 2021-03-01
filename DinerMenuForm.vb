Option Strict On
Option Explicit On

'Sean Gingerich
'RCET0265
'Spring 2021
'Diner Menu
'https://github.com/gingsean5/DinerMenu
Public Class DinerMenuForm


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = "Soup of the day: Chicken Tortilla Soup
Shredded chicken breast with navy and black beans in a white creamy soup base with a perfect blend of vegetables and spicy heat. Topped off with seasoned corn tortilla strips. Seasonal item only."
    End Sub
    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Text = "House Caesar Salad
Crisp romaine lettuce is the base of the salad, and the creamy caesar dressing provides a rich and tangy flavor. Parmesan cheese and oven-baked croutons finish off the salad. "
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.Text = "Sockeye Salmon
Flavored with lemon and garlic, pan cooked perfect to be flaky and juicy with tender asparagus roasted in the same pan. A fresh and healthy meal"
    End Sub
End Class
