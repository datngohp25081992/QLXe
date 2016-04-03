Public Class clsValidate
    Function IsInteger(ByVal input As Object) As Boolean
        Return Not (IsNumeric(input.ToString()) = False Or input.ToString().StartsWith("-") Or input.ToString() = "0" Or input.ToString().Contains(",") Or input.ToString().Contains("."))
    End Function
End Class
