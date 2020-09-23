
Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Public Class MainForm
    'Fields'
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    'Constructor'
    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.'
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        LeftPanel.Controls.Add(leftBorderBtn)

        'Form'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    'Methods'
    'Close-Maximize-Minimize'
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btCerrar.Click
        Application.Exit()
    End Sub
    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btMaximizar.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    'Remove transparent border in maximized state'
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        MainPanel.Controls.Add(childForm)
        MainPanel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lbTitulo.Text = childForm.Text
    End Sub

    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub btConsulta_Click(sender As Object, e As EventArgs) Handles btConsulta.Click
        OpenChildForm(New FormConsulta)
    End Sub

    Private Sub pbLogo_Click(sender As Object, e As EventArgs) Handles pbLogo.Click

    End Sub

    Private Sub btImportar_Click(sender As Object, e As EventArgs) Handles btImportar.Click
        OpenChildForm(New FormImportar)
    End Sub
End Class
