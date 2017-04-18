Public Class frmCashRegister

    Dim regMenu, kidsMenu As New Choices()
    Dim WithEvents cusOrder As New Choices()
    Dim total As Double

    ' Form onLoad
    Private Sub frmCashRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Regualar menu items added to regMenu
        regMenu.Add(New Food("pizza slice", 1.75))
        regMenu.Add(New Food("burger", 2.55))
        regMenu.Add(New Food("salad", 3.29))
        regMenu.Add(New Food("large soda", 1.25))
        regMenu.Add(New Food("medium soda", 0.9))

        ' kids menu items added to kidsMenu
        kidsMenu.Add(New Food("hot dog", 1.5))
        kidsMenu.Add(New Food("small soda", 0.6))
        kidsMenu.Add(New Food("cookie", 0.96))

        ' Display regular items
        For i = 0 To regMenu.Size - 1
            lstRegularMenu.Items.Add(regMenu.getItem(i).Name & "(" & FormatCurrency(regMenu.getItem(i).Price, 2) + ")")
        Next

        ' Display kidsmenu items
        For i = 0 To kidsMenu.Size - 1
            lstKidsMenu.Items.Add(kidsMenu.getItem(i).Name & "(" & FormatCurrency(regMenu.getItem(i).Price, 2) + ")")
        Next

    End Sub

    ' Add Regular Menu selected item to Customer Order
    Private Sub btnAddReg_Click(sender As Object, e As EventArgs) Handles btnAddReg.Click
        If lstRegularMenu.SelectedIndex <> -1 Then

            Dim index As Integer = lstRegularMenu.SelectedIndex

            cusOrder.Add(regMenu.getItem(index))
            lstCustomerOrder.Items.Add(regMenu.getItem(index).Name & " (" & FormatCurrency(regMenu.getItem(index).Price, 2) + ")")

        Else
            MessageBox.Show("Please select an item", "Warning")

        End If
    End Sub

    ' Add Kids Menu selected item to Customer Order
    Private Sub btnAddKids_Click(sender As Object, e As EventArgs) Handles btnAddKids.Click
        If lstKidsMenu.SelectedIndex <> -1 Then

            Dim index As Integer = lstKidsMenu.SelectedIndex

            cusOrder.Add(kidsMenu.getItem(index))
            lstCustomerOrder.Items.Add(kidsMenu.getItem(index).Name & " (" & FormatCurrency(kidsMenu.getItem(index).Price, 2) + ")")

        Else
            MessageBox.Show("Please select an item", "Warning")

        End If
    End Sub

    ' Procedure for ChoiceChanged Event of cusOrder
    Private Sub cusOrder_ChoiceChanged(ByVal name As String, ByVal price As Double) Handles cusOrder.ChoiceChanged

        total += price

        ' display total in txtTotal
        txtTotal.Text = FormatCurrency(total, 2)

    End Sub

    ' Clear btn, clears choices and customer order
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstRegularMenu.SelectedItem = Nothing
        lstKidsMenu.SelectedItem = Nothing
        lstCustomerOrder.Items.Clear()
        total = 0.0
        txtTotal.Text = FormatCurrency(total, 2)
    End Sub

    ' Quit btn, closes the program
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

End Class

Class Choices
    Private m_fooditems(25) As Food     ' Array of food items of Food class
    Private m_size As Integer = 0       ' Size of food items

    ' When item is added to customer order
    Public Event ChoiceChanged(ByVal name As String, ByVal price As Double)

    ' Property for m_size8
    Public Property Size() As Integer
        Get
            Return m_size
        End Get
        Set(value As Integer)
            m_size = value
        End Set
    End Property

    ' Add item to the footitems array
    Public Sub Add(ByVal item As Food)

        m_fooditems(m_size) = New Food()
        m_fooditems(m_size).Name() = item.Name
        m_fooditems(m_size).Price() = item.Price

        RaiseEvent ChoiceChanged(item.Name, item.Price)

        m_size += 1
    End Sub

    ' Gets item from fooditems array by index
    Function getItem(ByVal index As Integer) As Food
        Return m_fooditems(index)
    End Function

    ' Clear items in fooditems array
    Public Sub clearItems()

        ' Redeclares array and overwrites existing array
        ReDim m_fooditems(25)

        ' Reset size
        m_size = 0
    End Sub
End Class

Class Food
    Private m_name As String    ' Food Name
    Private m_price As Double   ' Food Price

    ' Default constructor
    Public Sub New()
    End Sub

    ' Argumented constructor
    Public Sub New(ByVal item As String, ByVal cost As Double)
        Name = item
        Price = cost
    End Sub

    ' Property for m_name
    Public Property Name() As String
        Get
            Return m_name
        End Get
        Set(value As String)
            m_name = value
        End Set
    End Property

    ' Property for m_price
    Public Property Price() As Double
        Get
            Return m_price
        End Get
        Set(value As Double)
            m_price = value
        End Set
    End Property
End Class
