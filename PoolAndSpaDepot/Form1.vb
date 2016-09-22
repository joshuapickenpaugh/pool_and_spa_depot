'Joshua Pickenpaugh
'September 22nd, 2016
'"Pool and Spa Depot", CPT 432, Unit 6

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    'Public Function GetGallons(ByVal pool As Dimensions) As Double
    '    'Calculates and returns the number of gallons.

    '    Const dblGAL_PER_CUBIC_FOOT As Double = 7.48

    '    Return pool.dblLength * pool.dblDepth * pool.dblWidth * dblGAL_PER_CUBIC_FOOT

    'End Function

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Delcares variables:
        Dim poolSize As New RectangularPool
        Dim dblGallons As Double

        'Assigns structures to text boxes:
        Double.TryParse(txtLength.Text, poolSize.Length)
        Double.TryParse(txtWidth.Text, poolSize.Width)
        Double.TryParse(txtDepth.Text, poolSize.Depth)

        dblGallons = poolSize.GetGallons
        lblTotal.Text = dblGallons.ToString("N0")

    End Sub

    'Structure Dimensions

    '    'Instead of variables, declares it as a structure:
    '    Public dblLength As Double
    '    Public dblWidth As Double
    '    Public dblDepth As Double

    'End Structure
End Class
