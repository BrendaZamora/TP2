Imports System.ComponentModel

Public Class ClaseCollection

    Inherits BindingList(Of ClaseUnitaria)

    Protected Overrides Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)

        e.NewObject = New ClaseUnitaria()

    End Sub
End Class
