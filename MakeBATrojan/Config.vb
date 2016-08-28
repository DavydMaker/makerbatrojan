'------------------------------'
' Desenvolvido por Davyd Maker '
'------------------------------'

Imports System.IO
Module Config
    'Gerar arquivo bat
    Public Sub gerarBat(ByVal comandoBat As String, ByVal nomeBat As String)
        Dim gerarArquivo As New StreamWriter(Application.StartupPath & "/" & nomeBat + ".bat")
        gerarArquivo.Write(comandoBat)
        gerarArquivo.Close()
    End Sub
End Module
