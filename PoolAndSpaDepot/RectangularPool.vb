Public Class RectangularPool

    Private _dblLength As Double
    Private _dblWidth As Double
    Private _dblDepth As Double
    Const dblGAL_PER_CUBIC_FOOT As Double = 7.48

    'Get and Set:
    Public Property Length As Double
        Get
            Return _dblLength
        End Get
        Set(value As Double)
            If value > 0 Then
                _dblLength = value
            Else
                _dblLength = 0
            End If
        End Set
    End Property

    'Get and Set:
    Public Property Width As Double
        Get
            Return _dblWidth
        End Get
        Set(value As Double)
            If value > 0 Then
                _dblWidth = value
            Else
                _dblWidth = 0
            End If
        End Set
    End Property

    'Get and Set:
    Public Property Depth As Double
        Get
            Return _dblDepth
        End Get
        Set(value As Double)
            If value > 0 Then
                _dblDepth = value
            Else
                _dblDepth = 0

            End If
        End Set
    End Property

    Public Sub New()
        _dblLength = 0
        _dblDepth = 0
        _dblWidth = 0
    End Sub

    Public Function GetVolume() As Double

        Return _dblWidth * _dblLength * _dblDepth

    End Function

    Public Function GetGallons() As Double

        Return GetVolume() * dblGAL_PER_CUBIC_FOOT

    End Function

End Class
