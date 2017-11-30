'subclass Fruit is defined as an inner class within the clsProducts class
'see clsProducts.vb for the remaining class definition
Partial Public Class clsProducts
    Public Class Fruit

        'private variables for subcategory Fruit pricing
        Private Shared decBananasPrice As Decimal = 4D
        Private Shared decApplesPrice As Decimal = 4.25D
        Private Shared decOrangesPrice As Decimal = 4.5D
        Private Shared decBlueberriesPrice As Decimal = 4.75D

        'private variables for subcategory Fruit quantities
        Private Shared decBananasQuant As Decimal = 0I
        Private Shared decApplesQuant As Decimal = 0I
        Private Shared decOrangesQuant As Decimal = 0I
        Private Shared decBlueberriesQuant As Decimal = 0I

        'Fruit quantity properties (getters/setters)
        Public Shared Property BananasQuant() As String
            Get
                Return decBananasQuant
            End Get
            Set(ByVal value As String)
                decBananasQuant = value
            End Set
        End Property

        Public Shared Property ApplesQuant() As String
            Get
                Return decApplesQuant
            End Get
            Set(ByVal value As String)
                decApplesQuant = value
            End Set
        End Property
        Public Shared Property OrangesQuant() As String
            Get
                Return decOrangesQuant
            End Get
            Set(ByVal value As String)
                decOrangesQuant = value
            End Set
        End Property
        Public Shared Property BlueberriesQuant() As String
            Get
                Return decBlueberriesQuant
            End Get
            Set(ByVal value As String)
                decBlueberriesQuant = value
            End Set
        End Property

        'Fruit pricing properties (getters)
        Public Shared ReadOnly Property BananasPrice() As String
            Get
                Return decBananasPrice
            End Get
        End Property
        Public Shared ReadOnly Property ApplesPrice() As String
            Get
                Return decApplesPrice
            End Get
        End Property
        Public Shared ReadOnly Property OrangesPrice() As String
            Get
                Return decOrangesPrice
            End Get
        End Property
        Public Shared ReadOnly Property BlueberriesPrice() As String
            Get
                Return decBlueberriesPrice
            End Get
        End Property
    End Class
End Class


