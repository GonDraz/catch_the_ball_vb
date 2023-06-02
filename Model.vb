Imports Newtonsoft.Json

Public Class Player
    Public Property Name As String
    Public Property Score As Integer
End Class

Public Class Model
    Public Property Player As List(Of Player)
End Class
