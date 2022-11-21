Imports System.Runtime.InteropServices
Imports System.Text

Public Class W32

    Public Const SM_CXSCREEN As Integer = 0
    Public Const SM_CYSCREEN As Integer = 1
    Public Const SPI_SETDESKWALLPAPER As Integer = 20
    Public Const SPIF_SENDWININICHANGE As Integer = &H2
    Public Const SPIF_UPDATEINIFILE As Integer = &H1
    Public Const SRCCOPY As Integer = 13369376
    Public Const WM_GETICON As Integer = &H7F
    Public Delegate Function EnumWindowsProc(ByVal hwnd As IntPtr, ByVal lParam As IntPtr) As Boolean

    <Flags>
    Public Enum BbFlags As Byte
        DwmBbEnable = 1
        DwmBbBlurregion = 2
        DwmBbTransitiononmaximized = 4
    End Enum

    <Flags()>
    Public Enum DeviceContextValues As UInteger
        Window = &H1
        Cache = &H2
        NoResetAttrs = &H4
        ClipChildren = &H8
        ClipSiblings = &H10
        ParentClip = &H20
        ExcludeRgn = &H40
        IntersectRgn = &H80
        ExcludeUpdate = &H100
        IntersectUpdate = &H200
        LockWindowUpdate = &H400
        UseStyle = &H10000
        Validate = &H200000
    End Enum

    <Flags>
    Public Enum RedrawWindowFlags As UInteger
        Invalidate = &H1
        InternalPaint = &H2
        [Erase] = &H4
        Validate = &H8
        NoInternalPaint = &H10
        NoErase = &H20
        NoChildren = &H40
        AllChildren = &H80
        UpdateNow = &H100
        EraseNow = &H200
        Frame = &H400
        NoFrame = &H800
    End Enum


    <Flags()>
    Public Enum SetWindowPosFlags As UInteger
        AsynWindowPos = &H4000
        DeferErase = &H2000
        DrawFrame = &H20
        FrameChanged = &H20
        HideWindow = &H80
        NoActivate = &H10
        NoCopyBits = &H100
        NoMove = &H2
        NoOwnerZOrder = &H200
        NoRedraw = &H8
        NoReposition = &H200
        NoSendChanging = &H400
        NoSize = &H1
        NoZOrder = &H4
        ShowWindow = &H40
    End Enum

    Public Enum WindowLongFlags As Integer
        GWL_EXSTYLE = -20
        GWLP_HINSTANCE = -6
        GWLP_HWNDPARENT = -8
        GWL_ID = -12
        GWL_STYLE = -16
        GWL_USERDATA = -21
        GWL_WNDPROC = -4
        DWLP_USER = &H8
        DWLP_MSGRESULT = &H0
        DWLP_DLGPROC = &H4
    End Enum

    <Flags>
    Public Enum WindowStyles As UInteger
        WS_BORDER = &H800000
        WS_CAPTION = &HC00000
        WS_CHILD = &H40000000
        WS_CLIPCHILDREN = &H2000000
        WS_CLIPSIBLINGS = &H4000000
        WS_DISABLED = &H8000000
        WS_DLGFRAME = &H400000
        WS_GROUP = &H20000
        WS_HSCROLL = &H100000
        WS_MAXIMIZE = &H1000000
        WS_MAXIMIZEBOX = &H10000
        WS_MINIMIZE = &H20000000
        WS_MINIMIZEBOX = &H20000
        WS_OVERLAPPED = &H0
        WS_POPUP = &H80000000UI
        WS_SIZEFRAME = &H40000
        WS_SYSMENU = &H80000
        WS_TABSTOP = &H10000
        WS_VISIBLE = &H10000000
        WS_VSCROLL = &H200000
    End Enum

    <Flags>
    Public Enum WindowStylesEx As UInteger
        WS_EX_ACCEPTFILES = &H10
        WS_EX_APPWINDOW = &H40000
        WS_EX_CLIENTEDGE = &H200
        WS_EX_COMPOSITED = &H2000000
        WS_EX_CONTEXTHELP = &H400
        WS_EX_CONTROLPARENT = &H10000
        WS_EX_DLGMODALFRAME = &H1
        WS_EX_LAYERED = &H80000
        WS_EX_LAYOUTRTL = &H400000
        WS_EX_LEFT = &H0
        WS_EX_LEFTSCROLLBAR = &H4000
        WS_EX_LTRREADING = &H0
        WS_EX_MDICHILD = &H40
        WS_EX_NOACTIVATE = &H8000000
        WS_EX_NOINHERITLAYOUT = &H100000
        WS_EX_NOPARENTNOTIFY = &H4
        WS_EX_OVERLAPPEDWINDOW = WS_EX_WINDOWEDGE Or WS_EX_CLIENTEDGE
        WS_EX_PALETTEWINDOW = WS_EX_WINDOWEDGE Or WS_EX_TOOLWINDOW Or WS_EX_TOPMOST
        WS_EX_RIGHT = &H1000
        WS_EX_RIGHTSCROLLBAR = &H0
        WS_EX_RTLREADING = &H2000
        WS_EX_STATICEDGE = &H20000
        WS_EX_TOOLWINDOW = &H80
        WS_EX_TOPMOST = &H8
        WS_EX_TRANSPARENT = &H20
        WS_EX_WINDOWEDGE = &H100
    End Enum

    <Flags>
    Public Enum SendMessageTimeoutFlags As UInteger
        SMTO_NORMAL = &H0
        SMTO_BLOCK = &H1
        SMTO_ABORTIFHUNG = &H2
        SMTO_NOTIMEOUTIFNOTHUNG = &H8
        SMTO_ERRORONEXIT = &H20
    End Enum

    <DllImport("gdi32.dll", EntryPoint:="BitBlt")>
    Public Shared Function BitBlt(ByVal hdcDest As IntPtr, ByVal xDest As Integer, ByVal yDest As Integer, ByVal wDest As Integer, ByVal hDest As Integer, ByVal hdcSource As IntPtr, ByVal xSrc As Integer, ByVal ySrc As Integer, ByVal RasterOp As Integer) As Boolean
    End Function
    <DllImport("gdi32.dll", EntryPoint:="CreateCompatibleBitmap")>
    Public Shared Function CreateCompatibleBitmap(ByVal hdc As IntPtr, ByVal nWidth As Integer, ByVal nHeight As Integer) As IntPtr
    End Function
    <DllImport("gdi32.dll", EntryPoint:="CreateCompatibleDC")>
    Public Shared Function CreateCompatibleDC(ByVal hdc As IntPtr) As IntPtr
    End Function
    <DllImport("gdi32.dll", EntryPoint:="DeleteDC")>
    Public Shared Function DeleteDC(ByVal hDc As IntPtr) As IntPtr
    End Function
    <DllImport("gdi32.dll", EntryPoint:="DeleteObject")>
    Public Shared Function DeleteObject(ByVal hDc As IntPtr) As IntPtr
    End Function
    <DllImport("dwmapi.dll")>
    Public Shared Function DwmEnableBlurBehindWindow(ByVal hWnd As IntPtr, ByRef blurBehind As BbStruct) As Integer
    End Function
    <DllImport("DwmApi.dll")>
    Public Shared Function DwmExtendFrameIntoClientArea(ByVal hwnd As IntPtr, ByRef pMarInset As Margins) As Integer
    End Function
    <DllImport("dwmapi.dll", EntryPoint:="#127", PreserveSig:=False)>
    Public Shared Sub DwmGetColorizationParameters(<Out> ByRef parameters As DWM_COLORIZATION_PARAMS)
    End Sub
    <DllImport("dwmapi.dll", PreserveSig:=False)>
    Public Shared Function DwmIsCompositionEnabled() As Boolean
    End Function
    <DllImport("dwmapi.dll")>
    Public Shared Function DwmIsCompositionEnabled(<Out> ByRef enabled As Boolean) As Integer
    End Function
    <DllImport("dwmapi.dll", EntryPoint:="#131", PreserveSig:=False)>
    Public Shared Sub DwmSetColorizationParameters(ByRef parameters As DWM_COLORIZATION_PARAMS, ByVal uUnknown As Long)
    End Sub
    <DllImport("dwmapi.dll")>
    Public Shared Function DwmSetWindowAttribute(ByVal hwnd As IntPtr, ByVal attr As Integer, ByRef attrValue As Integer, ByVal attrSize As Integer) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Public Shared Function EnumWindows(ByVal lpEnumFunc As EnumWindowsProc, ByRef lParam As IntPtr) As Boolean
    End Function
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Public Shared Function EnumChildWindows(ByVal parentHandle As IntPtr, ByVal lpEnumFunc As EnumWindowsProc, ByVal lParam As IntPtr) As Boolean
    End Function
    <DllImport("user32.dll", SetLastError:=True)>
    Public Shared Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    End Function
    <DllImport("user32.dll", SetLastError:=True)>
    Public Shared Function FindWindowEx(ByVal parentHandle As IntPtr, ByVal childAfter As IntPtr, ByVal className As String, ByVal windowTitle As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll")>
    Public Shared Function GetClassLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer) As UInteger
    End Function
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Public Shared Function GetClassName(ByVal hWnd As IntPtr, ByVal lpClassName As StringBuilder, ByVal nMaxCount As Integer) As Integer
    End Function
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Public Shared Function GetWindowText(ByVal hWnd As IntPtr, ByVal lpWindowText As StringBuilder, ByVal nMaxCount As Integer) As Integer
    End Function
    <DllImport("user32.dll", EntryPoint:="GetDC")>
    Public Shared Function GetDC(ByVal ptr As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll")>
    Public Shared Function GetDCEx(ByVal hWnd As IntPtr, ByVal hrgnClip As IntPtr, ByVal flags As DeviceContextValues) As IntPtr
    End Function
    <DllImport("user32.dll", EntryPoint:="GetDesktopWindow")>
    Public Shared Function GetDesktopWindow() As IntPtr
    End Function
    <DllImport("user32.dll")>
    Public Shared Function GetForegroundWindow() As IntPtr
    End Function
    <DllImport("user32.dll", ExactSpelling:=True, CharSet:=CharSet.Auto)>
    Public Shared Function GetParent(ByVal hWnd As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll")>
    Public Shared Function GetShellWindow() As IntPtr
    End Function
    <DllImport("user32.dll", EntryPoint:="GetSystemMetrics")>
    Public Shared Function GetSystemMetrics(ByVal abc As Integer) As Integer
    End Function
    <DllImport("user32.dll", EntryPoint:="GetWindowDC")>
    Public Shared Function GetWindowDC(ByVal ptr As Int32) As IntPtr
    End Function
    <DllImport("user32.dll")>
    Public Shared Function IsWindowVisible(ByVal hWnd As IntPtr) As Boolean
    End Function
    <DllImport("user32.dll")>
    Public Shared Function RedrawWindow(ByVal hWnd As IntPtr,
    <[In]> ByRef lprcUpdate As RECT, ByVal hrgnUpdate As IntPtr, ByVal flags As RedrawWindowFlags) As Boolean
    End Function
    <DllImport("user32.dll")>
    Public Shared Function RedrawWindow(ByVal hWnd As IntPtr, ByVal lprcUpdate As IntPtr, ByVal hrgnUpdate As IntPtr, ByVal flags As RedrawWindowFlags) As Boolean
    End Function
    <DllImport("user32.dll", EntryPoint:="ReleaseDC")>
    Public Shared Function ReleaseDC(ByVal hWnd As IntPtr, ByVal hDc As IntPtr) As IntPtr
    End Function
    <DllImport("gdi32.dll", EntryPoint:="SelectObject")>
    Public Shared Function SelectObject(ByVal hdc As IntPtr, ByVal bmp As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInt32, ByVal wParam As Integer, ByVal lParam As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Public Shared Function SendMessageTimeout(ByVal windowHandle As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr, ByVal flags As SendMessageTimeoutFlags, ByVal timeout As UInteger, <Out> ByRef result As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll", SetLastError:=True)>
    Public Shared Function SetParent(ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As IntPtr
    End Function
    <DllImport("kernel32.dll")>
    Public Shared Function SetProcessWorkingSetSize(ByVal handle As IntPtr, ByVal minimumWorkingSetSize As Integer, ByVal maximumWorkingSetSize As Integer) As Boolean
    End Function
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Public Shared Function EnableWindow(ByVal hWnd As IntPtr, ByVal bEnable As Boolean) As Boolean
    End Function

    <DllImport("user32.dll")>
    Public Shared Function SetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As WindowLongFlags, ByVal dwNewLong As Integer) As Integer
    End Function
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Public Shared Function SetWindowPos(ByVal hWnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal uFlags As SetWindowPosFlags) As Boolean
    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Public Shared Function SystemParametersInfo(ByVal action As UInt32, ByVal uParam As UInt32, ByVal vParam As String, ByVal winIni As UInt32) As Int32
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Public Structure BbStruct
        Public Flags As BbFlags
        Public Enable As Boolean
        Public Region As IntPtr
        Public TransitionOnMaximized As Boolean
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Public Structure DWM_COLORIZATION_PARAMS
        Public clrColor As Integer
        Public clrAfterGlow As Integer
        Public nIntensity As Integer
        Public clrAfterGlowBalance As Integer
        Public clrBlurBalance As Integer
        Public clrGlassReflectionIntensity As Integer
        Public fOpaque As Boolean
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Public Structure Margins
        Public cxLeftWidth As Integer
        Public cxRightWidth As Integer
        Public cyTopHeight As Integer
        Public cyBottomHeight As Integer
    End Structure

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
