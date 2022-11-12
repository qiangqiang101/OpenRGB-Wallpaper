Imports System.Runtime.CompilerServices
Imports OpenRGB.NET

Module Helper

    Public UserSettingFile As String = $"{My.Application.Info.DirectoryPath}\UserSettings.xml"
    Public UserSettings As UserSettingData = New UserSettingData(UserSettingFile).InstanceXml

    <Extension>
    Public Function ToColor(modelcolor As Models.Color) As Color
        Return Color.FromArgb(modelcolor.R, modelcolor.G, modelcolor.B)
    End Function

End Module
