Imports System.Runtime.CompilerServices
Imports OpenRGB.NET

Module Helper

    <Extension>
    Public Function ToColor(modelcolor As Models.Color) As Color
        Return Color.FromArgb(modelcolor.R, modelcolor.G, modelcolor.B)
    End Function

    Public Function CalcY(rows As Integer, current As Integer, height As Single) As Single


        Return CSng(height * (rows - current))
    End Function

End Module
