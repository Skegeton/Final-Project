Public Class MenuItem
    Private mName As String
    Private mPrice As Decimal

    Public ReadOnly Property name() As String
        Get
            Return mName
        End Get
    End Property
    Public ReadOnly Property price() As String
        Get
            Return mPrice
        End Get
    End Property
    Sub New(ByVal pName As String, ByVal pPrice As Integer)
        'Constructor sets member values to parameter values
        mName = pName
        mPrice = pPrice
    End Sub
End Class
