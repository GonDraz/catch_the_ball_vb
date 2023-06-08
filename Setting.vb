Imports System.Media
Imports System.Runtime.InteropServices





Public Class Setting
    Private Const APPCOMMAND_VOLUME_MUTE = &H80000
    Private Const APPCOMNAND_VOLUME_UP = &HA0000
    Private Const APPCOMMAND_VOLUME_DOWN = &H90000
    Private Const WM_APPCOMAND = &H319

    Public backgoundSound As New SoundPlayer(My.Resources.background_muisc)
    Public hitSound As New SoundPlayer(My.Resources.hit)
    Public gameOverSound As New SoundPlayer(My.Resources.game_over_sound)
    Public saveSound As New SoundPlayer(My.Resources.save_sound)


    <DllImport("user32.dll")> Public Shared Function SendMessageW(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr,
                                                 ByVal lParam As IntPtr) As IntPtr
    End Function




    Private Sub btnBackToMenu_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnBackToMenu.Click
        Form1.SwitchForm(MenuForm)

    End Sub

    Private Sub btnTurnUp_Click(sender As Object, e As EventArgs) Handles btnTurnUp.Click
        SendMessageW(Me.Handle, WM_APPCOMAND, Me.Handle, New IntPtr(APPCOMNAND_VOLUME_UP))
    End Sub

    Private Sub btnOnOff_Click(sender As Object, e As EventArgs) Handles btnOnOff.Click
        SendMessageW(Me.Handle, WM_APPCOMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_MUTE))
    End Sub

    Private Sub btnTurnDown_Click(sender As Object, e As EventArgs) Handles btnTurnDown.Click
        SendMessageW(Me.Handle, WM_APPCOMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_DOWN))
    End Sub
End Class