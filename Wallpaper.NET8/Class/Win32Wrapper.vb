Imports System.Runtime.InteropServices
'Imports System.Text

Public Class Win32Wrapper

    Public Const SM_CXSCREEN As Integer = 0
    Public Const SM_CYSCREEN As Integer = 1
    Public Const SPI_SETDESKWALLPAPER As Integer = 20
    Public Const SPIF_SENDWININICHANGE As Integer = &H2
    Public Const SPIF_UPDATEINIFILE As Integer = &H1
    Public Const SRCCOPY As Integer = 13369376
    Public Const WM_GETICON As Integer = &H7F
    Public Const MAX_PATH As Integer = 260
    Public Const SPI_GETDESKWALLPAPER As Integer = &H73
    Public Delegate Function EnumWindowsProc(ByVal hwnd As IntPtr, ByVal lParam As IntPtr) As Boolean

    <Flags>
    Public Enum SendMessageTimeoutFlags As UInteger
        SMTO_NORMAL = &H0
        SMTO_BLOCK = &H1
        SMTO_ABORTIFHUNG = &H2
        SMTO_NOTIMEOUTIFNOTHUNG = &H8
        SMTO_ERRORONEXIT = &H20
    End Enum

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Public Shared Function EnumWindows(ByVal lpEnumFunc As EnumWindowsProc, ByRef lParam As IntPtr) As Boolean
    End Function
    <DllImport("user32.dll", SetLastError:=True)>
    Public Shared Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    End Function
    <DllImport("user32.dll", SetLastError:=True)>
    Public Shared Function FindWindowEx(ByVal parentHandle As IntPtr, ByVal childAfter As IntPtr, ByVal className As String, ByVal windowTitle As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll", EntryPoint:="GetDesktopWindow")>
    Public Shared Function GetDesktopWindow() As IntPtr
    End Function
    <DllImport("user32.dll")>
    Public Shared Function GetForegroundWindow() As IntPtr
    End Function
    <DllImport("user32.dll")>
    Public Shared Function GetShellWindow() As IntPtr
    End Function
    <DllImport("user32.dll", SetLastError:=True)>
    Public Shared Function GetWindowRect(ByVal hWnd As IntPtr, <Out> ByRef rc As RECT) As Integer
    End Function
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Public Shared Function SendMessageTimeout(ByVal windowHandle As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr, ByVal flags As SendMessageTimeoutFlags, ByVal timeout As UInteger, <Out> ByRef result As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll", SetLastError:=True)>
    Public Shared Function SetParent(ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function SystemParametersInfo(ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Public Structure RECT
        Public Left, Top, Right, Bottom As Integer

        Public Sub New(ByVal left As Integer, ByVal top As Integer, ByVal right As Integer, ByVal bottom As Integer)
            left = left
            top = top
            right = right
            bottom = bottom
        End Sub

        Public Sub New(ByVal r As Rectangle)
            Me.New(r.Left, r.Top, r.Right, r.Bottom)
        End Sub

        Public Property X As Integer
            Get
                Return Left
            End Get
            Set(ByVal value As Integer)
                Right -= (Left - value)
                Left = value
            End Set
        End Property

        Public Property Y As Integer
            Get
                Return Top
            End Get
            Set(ByVal value As Integer)
                Bottom -= (Top - value)
                Top = value
            End Set
        End Property

        Public Property Height As Integer
            Get
                Return Bottom - Top
            End Get
            Set(ByVal value As Integer)
                Bottom = value + Top
            End Set
        End Property

        Public Property Width As Integer
            Get
                Return Right - Left
            End Get
            Set(ByVal value As Integer)
                Right = value + Left
            End Set
        End Property

        Public Property Location As Point
            Get
                Return New Point(Left, Top)
            End Get
            Set(ByVal value As Point)
                X = value.X
                Y = value.Y
            End Set
        End Property

        Public Property Size As Size
            Get
                Return New Size(Width, Height)
            End Get
            Set(ByVal value As Size)
                Width = value.Width
                Height = value.Height
            End Set
        End Property

        Public Shared Widening Operator CType(ByVal r As RECT) As Rectangle
            Return New Rectangle(r.Left, r.Top, r.Width, r.Height)
        End Operator

        Public Shared Widening Operator CType(ByVal r As Rectangle) As RECT
            Return New RECT(r)
        End Operator

        Public Shared Operator =(ByVal r1 As RECT, ByVal r2 As RECT) As Boolean
            Return r1.Equals(r2)
        End Operator

        Public Shared Operator <>(ByVal r1 As RECT, ByVal r2 As RECT) As Boolean
            Return Not r1.Equals(r2)
        End Operator

        Public Overloads Function Equals(ByVal r As RECT) As Boolean
            Return r.Left = Left AndAlso r.Top = Top AndAlso r.Right = Right AndAlso r.Bottom = Bottom
        End Function

        Public Overrides Function Equals(ByVal obj As Object) As Boolean
            If TypeOf obj Is RECT Then
                Return Equals(CType(obj, RECT))
            ElseIf TypeOf obj Is System.Drawing.Rectangle Then
                Return Equals(New RECT(CType(obj, System.Drawing.Rectangle)))
            End If

            Return False
        End Function

    End Structure

End Class
