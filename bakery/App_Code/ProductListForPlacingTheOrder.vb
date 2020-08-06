Public Class ProductListForPlacingTheOrder

    Public _Count As Integer
    Public _TypeOfProduct As String
    Public _PecansRequested As String
    Public _Price As Double
    Public _OrderInTheList As Integer

    Public Property Count() As Integer
        Get
            ' Gets the property value.
            Return _Count
        End Get
        Set(ByVal Value As Integer)
            ' Sets the property value.
            _Count = Value
        End Set
    End Property

    Public Property TypeOfProduct() As String
        Get
            ' Gets the property value.
            Return _TypeOfProduct
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _TypeOfProduct = Value
        End Set
    End Property

    Public Property PecansRequested() As String
        Get
            ' Gets the property value.
            Return _PecansRequested
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _PecansRequested = Value
        End Set
    End Property

    Public Property Price() As Double
        Get
            ' Gets the property value.
            Return _Price
        End Get
        Set(ByVal Value As Double)
            ' Sets the property value.
            _Price = Value
        End Set
    End Property
    Public Property OrderInTheList() As Integer
        Get
            ' Gets the property value.
            Return _OrderInTheList
        End Get
        Set(ByVal Value As Integer)
            ' Sets the property value.
            _OrderInTheList = Value
        End Set
    End Property

End Class
