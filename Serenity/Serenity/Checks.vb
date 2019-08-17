Public Class Checks
    Public Property checknumber As String
    Public Property checkdate As String
    Public Property checkamount As Double
    Public Property payableto As String

    Public inFile As IO.StreamReader
    Public outFile As IO.StreamWriter

    Public Property chknumber As String
        Get
            Return checknumber
        End Get
        Set(value As String)
            If value > 0 Then
                checknumber = value
            Else
                checknumber = 0
            End If
        End Set
    End Property

    Public Property chkdate As String
        Get
            Return checkdate
        End Get
        Set(value As String)
            If value > 0 Then
                checkdate = value
            Else
                checkdate = " "
            End If
        End Set
    End Property

    Public Property chkamount As Double
        Get
            Return checkamount
        End Get
        Set(value As Double)
            If value > 0 Then
                checkamount = value
            Else
                checkamount = 0
            End If
        End Set
    End Property

    Public Property payable As String
        Get
            Return payableto
        End Get
        Set(value As String)
            If value > 0 Then
                payableto = value
            End If
        End Set
    End Property

    Public Sub New()
        checknumber = String.Empty
        checkdate = String.Empty
        checkamount = 0.0
        payableto = String.Empty
    End Sub

    Public Sub New(ByVal intchecknumber As String, ByVal strcheckdate As String, ByVal dblcheckamount As Double, ByVal dblpayableto As String)
        checknumber = intchecknumber
        checkdate = strcheckdate
        checkamount = dblcheckamount
        payableto = dblpayableto
    End Sub

    Public Function getChecknumber() As String
        Return checknumber
    End Function

    Public Function getCheckDate() As String
        Return checkdate
    End Function

    Public Function getCheckAmount() As Double
        Return checkamount
    End Function

    Public Function getPayableTo() As String
        Return payableto
    End Function

    Public Sub SaveCheck(checknumber As String, checkdate As String, checkamount As Double, payableto As String)
        Dim strCheck As String

        If IO.File.Exists("Check.txt") Then
            outFile = IO.File.AppendText("Check.txt")
            strCheck = checknumber & ", " & checkdate & ", " & checkamount.ToString("n2") & ", " & payableto
            outFile.WriteLine(strCheck)
            outFile.Close()
        End If

    End Sub
End Class
