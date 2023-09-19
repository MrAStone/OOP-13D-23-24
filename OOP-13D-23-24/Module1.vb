Module Module1

    Sub Main()
        Dim b As New BankAccount("Mr Stone", 1000000)
        Console.WriteLine(b.getBalance)

    End Sub

End Module
Class BankAccount
    Private ACName As String
    Private ACBalance As Decimal

    Public Sub New(_ACName As String, OpenBalance As Decimal)
        ACName = _ACName
        ACBalance = OpenBalance
    End Sub
    Public Function getBalance()
        Return ACBalance
    End Function
    Public Sub Deposit(amount As Decimal)
        ACBalance += amount
    End Sub
End Class
