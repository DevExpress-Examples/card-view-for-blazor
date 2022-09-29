Imports Microsoft.AspNetCore.Hosting
Imports System.Collections.Generic
Imports System.IO
Imports System.Xml.Serialization

Namespace DxBlazorApplication5.Data

    <XmlRoot("HomesList")>
    Public Class HomesList

        <XmlElement("Homes")>
        Public Property Homes As List(Of Homes)
    End Class

    Public Class Homes

        <XmlElement("ID")>
        Public Property ID As Integer

        <XmlElement("Address")>
        Public Property Address As String

        <XmlElement("Beds")>
        Public Property Beds As Integer

        <XmlElement("Baths")>
        Public Property Baths As Integer

        <XmlElement("HouseSize")>
        Public Property HouseSize As Double

        <XmlElement("LotSize")>
        Public Property LotSize As Double

        <XmlElement("Price")>
        Public Property Price As Decimal

        <XmlElement("Features")>
        Public Property Features As String

        <XmlElement("YearBuilt")>
        Public Property YearBuilt As Integer

        <XmlElement("Status")>
        Public Property Status As Integer

        <XmlElement("Photo")>
        Public Property Photo As Byte()

        Public Property PhotoUrl As String
    End Class

    Public Class DataProvider

        Private _env As IWebHostEnvironment

        Public Sub New(ByVal env As IWebHostEnvironment)
            _env = env
        End Sub

        Public Function GetDataFormXml() As List(Of Homes)
            Dim formatter As XmlSerializer = New XmlSerializer(GetType(HomesList))
            Using fs As FileStream = New FileStream("Data/Homes.xml", FileMode.Open)
                Dim homesList As HomesList = CType(formatter.Deserialize(fs), HomesList)
                For Each home As Homes In homesList.Homes
                    home.PhotoUrl = home.ID.ToString() & ".jpg"
                    File.WriteAllBytes(_env.WebRootPath & "/Images/" & home.PhotoUrl, home.Photo)
                Next

                Return homesList.Homes
            End Using
        End Function
    End Class
End Namespace
