Public Class clsValidate
    Function IsInteger(ByVal input As Object) As Boolean
        Return Not (IsNumeric(input.ToString()) = False Or input.ToString().StartsWith("-") Or input.ToString() = "0" Or input.ToString().Contains(",") Or input.ToString().Contains("."))
    End Function
    Function IsBefore(ByVal _begin As Date, ByVal _end As Date) As Boolean
        Return _begin.ToOADate < _end.ToOADate
    End Function
    Function IsInside(ByVal _begin As Date, ByVal _end As Date, ByVal _conflict As Date) As Boolean
        Return _begin.ToOADate <= _conflict.ToOADate And _conflict.ToOADate <= _end.ToOADate
    End Function
End Class
