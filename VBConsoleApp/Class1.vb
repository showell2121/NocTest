Public Class Class1

  Public age As Integer
  Public name As String

  'Sub does not return a value'
  Public Sub printName(ByVal name2 As String)
    name = name2
  End Sub

  Public Function getName() As String
    Return name
  End Function



End Class
