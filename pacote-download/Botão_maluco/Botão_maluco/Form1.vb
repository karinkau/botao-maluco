Public Class frmBotaoMaluco
    'Jogo simples elaborado 14-01-2017

    'Nome:  BOTÃO MALUCO
    'Função : o jogador tentará clicar em cima do botão.
    'Autor :  Karine s m Rodrigues - (38) 9.9125-5433
    'Atualização : 

    '#######################################################################

    Private Sub btnCliqueAqui_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles btnCliqueAqui.MouseMove
        If btnCliqueAqui.Top < 100 Then
            btnCliqueAqui.Top = 250
            btnCliqueAqui.Text = "NÃO DESISTA !  tente mais uma vez."
            btnCliqueAqui.BackColor = Color.Violet
        Else
            btnCliqueAqui.Top = 70
            btnCliqueAqui.Text = "CLIQUE AQUI !  se você conseguir."
            btnCliqueAqui.BackColor = Color.Turquoise
        End If
    End Sub
End Class
'   Karin Kau Produções
