'Recommended project type for compiling: Console App (.NET Framework)
'.NET Framework version: 4.7.x/4.8
'.NET Core version: 2.x

Imports System
Imports System.IO
Imports Microsoft.VisualBasic.Devices

Module Main
    Sub Main()
        Functions.WriteLineInTxt()
        Functions.ReadLineFromTxt()
        System.Console.Read() 'pauses the console
    End Sub
End Module