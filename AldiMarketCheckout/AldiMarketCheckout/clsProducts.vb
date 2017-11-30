'class provides pricing and quantities for core product categories in the grocery store
'see file clsProducts.Fruit.vb for the Fruit subclass
Partial Public Class clsProducts

    'private variables for product pricing (items without subcategories)
    Private Shared decBreadPrice As Decimal = 2.99D
    Private Shared decCrackerPrice As Decimal = 1.39D
    Private Shared decChickenPrice As Decimal = 7.99D
    Private Shared decMilkPrice As Decimal = 2.49D
    Private Shared decCheessePrice As Decimal = 2.79D
    Private Shared decEggsPrice As Decimal = 2.49D
    Private Shared decChipsPrice As Decimal = 1.89D

    'private variables for product quantities (items without subcategories)
    Private Shared decBreadQuant As Integer = 0I
    Private Shared decCrackersQuant As Integer = 0I
    Private Shared decChickenQuant As Integer = 0I
    Private Shared decMilkQuant As Integer = 0I
    Private Shared decCheesseQuant As Integer = 0I
    Private Shared decEggsQuant As Integer = 0I
    Private Shared decChipsQuant As Integer = 0I

    'quantity properties (getters/setters)
    Public Shared Property BreadQuant() As String
        Get
            Return decBreadQuant
        End Get
        Set(ByVal value As String)
            decBreadQuant = value
        End Set
    End Property
    Public Shared Property CrackersQuant() As String
        Get
            Return decCrackersQuant
        End Get
        Set(ByVal value As String)
            decCrackersQuant = value
        End Set
    End Property
    Public Shared Property ChickenQuant() As String
        Get
            Return decChickenQuant
        End Get
        Set(ByVal value As String)
            decChickenQuant = value
        End Set
    End Property
    Public Shared Property MilkQuant() As String
        Get
            Return decMilkQuant
        End Get
        Set(ByVal value As String)
            decMilkQuant = value
        End Set
    End Property
    Public Shared Property CheeseQuant() As String
        Get
            Return decCheesseQuant
        End Get
        Set(ByVal value As String)
            decCheesseQuant = value
        End Set
    End Property
    Public Shared Property EggsQuant() As String
        Get
            Return decEggsQuant
        End Get
        Set(ByVal value As String)
            decEggsQuant = value
        End Set
    End Property

    Public Shared Property ChipsQuant() As String
        Get
            Return decChipsQuant
        End Get
        Set(ByVal value As String)
            decChipsQuant = value
        End Set
    End Property

    'pricing properties (getters)
    Public Shared ReadOnly Property BreadPrice() As String
        Get
            Return decBreadPrice
        End Get
    End Property

    Public Shared ReadOnly Property CrackerPrice() As String
        Get
            Return decCrackerPrice
        End Get
    End Property
    Public Shared ReadOnly Property ChickenPrice() As String
        Get
            Return decChickenPrice
        End Get
    End Property
    Public Shared ReadOnly Property CheesePrice() As String
        Get
            Return decCheessePrice
        End Get
    End Property
    Public Shared ReadOnly Property MilkPrice() As String
        Get
            Return decMilkPrice
        End Get
    End Property
    Public Shared ReadOnly Property EggPrice() As String
        Get
            Return decEggsPrice
        End Get
    End Property
    Public Shared ReadOnly Property ChipsPrice() As String
        Get
            Return decChipsPrice
        End Get
    End Property

End Class
