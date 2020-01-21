Imports System
Imports System.IO
Imports Microsoft.VisualBasic.Devices

Module Functions
	Function WriteLineInTxt()
		Dim File As StreamWriter
		File = My.Computer.FileSystem.OpenTextFileWriter("name.txt", True)
		File.WriteLine("Wiktor Nowicki")
		File.Close()
		Return 0
	End Function

	Function ReadLineFromTxt()
		Dim readFile As StreamReader
		readFile = My.Computer.FileSystem.OpenTextFileReader("name.txt")
		Dim readLine As String
		readLine = readFile.ReadLine()
		System.Console.WriteLine(readLine)
		readFile.Close()
		Return 0
	End Function
End Module