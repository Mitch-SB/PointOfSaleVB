Imports RegisterVB.Grocery
Imports RegisterVB.Helper
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class DataAccess

    Public Function GetGrocery(ByVal lookUp) As Grocery
        Dim matchingGrocery As Grocery = New Grocery()
        Dim helper As Helper = New Helper()

        Dim myCnn As String = helper.connectionString
        Dim cnn As SqlConnection = New SqlConnection(myCnn)

        'Query that will run my stored procedure
        Dim oString As String = "dbo.Grocery_GetByLookUp @LookUp"
        Dim oCmd As SqlCommand = New SqlCommand(oString, cnn)
        oCmd.Parameters.AddWithValue("@LookUp", lookUp)
        cnn.Open()

        Using oReader As SqlDataReader = oCmd.ExecuteReader()
            While oReader.Read()
                'assigns the values grabbed into their respective places
                matchingGrocery.Name = oReader("Name").ToString()
                matchingGrocery.Price = oReader("Price").ToString()
                matchingGrocery.Taxable = oReader("Taxable").ToString()
                matchingGrocery.Identification18 = oReader("Identification18").ToString()
                matchingGrocery.Identification21 = oReader("Identification21").ToString()
            End While
            'Securely closes my connection
            cnn.Close()

        End Using
        Return matchingGrocery

    End Function

End Class
