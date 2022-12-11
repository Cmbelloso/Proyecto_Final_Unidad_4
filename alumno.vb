Imports Microsoft.VisualBasic
Imports System.Data

Public Class alumno
    'instancia de clase conexión

    Dim c As New conexion

    'declaración de propiedades de la clase

    Private codigoalumno As String
    Private nombrealumno As String
    Private apellidoalumno As String
    Private pagina As Page

    'metodos de propiedad

    Public Property codalumno() As String
        Get
            Return codigoalumno
        End Get
        Set(value As String)
            codigoalumno = value
        End Set
    End Property

    Public Property nomalumno() As String
        Get
            Return nombrealumno
        End Get
        Set(value As String)
            nombrealumno = value
        End Set
    End Property

    Public Property apealumno() As String
        Get
            Return apellidoalumno
        End Get
        Set(value As String)
            apellidoalumno = value
        End Set
    End Property





End Class
