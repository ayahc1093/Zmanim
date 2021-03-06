﻿Imports Zmanim.TzDatebase
Imports Zmanim.Utilities
Imports Zmanim.TimeZone

Public Class _Default
    Inherits System.Web.UI.Page

    Dim Calendar As ComplexZmanimCalendar

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim locationName As String = "Lakewood, NJ"
        Dim latitude As Double = 40.09596 'Lakewood, NJ
        Dim longitude As Double = -74.22213 'Lakewood, NJ
        Dim elevation As Double = 0 'optional elevation
        Dim timeZone As ITimeZone = New OlsonTimeZone("America/New_York")
        Dim location As New GeoLocation(locationName, latitude, longitude, elevation, timeZone)
        Calendar = New ComplexZmanimCalendar(location)

    End Sub

    Protected Function GetSunrise() As DateTime
        Return Calendar.GetSunrise()
    End Function

    Protected Function GetSunset() As DateTime
        Return Calendar.GetSunset()
    End Function


    Protected Function GetZman(ByVal zman As Func(Of ComplexZmanimCalendar, [DateTime])) As DateTime
        Return zman.Invoke(Calendar)
    End Function
End Class