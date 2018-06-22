Public Class ClaseUnitaria
    Dim Id_, IdContribuyente_ As Integer
    Dim Nombre_, Categiva_ As String

    Public Property Id() As Integer
        Get

            Return Id_

        End Get

        Set(ByVal value As Integer)

            Id_ = value

        End Set
    End Property

    Public Property IdContribuyente() As Integer
        Get
            Return IdContribuyente_

        End Get

        Set(ByVal value As Integer)

            IdContribuyente_ = value

        End Set
    End Property

    Public Property Categiva() As String
        Get
            Return Categiva_

        End Get

        Set(ByVal value As String)

            Categiva_ = value

        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return Nombre_

        End Get

        Set(ByVal value As String)

            Nombre_ = value

        End Set
    End Property





End Class
