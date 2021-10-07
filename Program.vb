Imports System

Module Program
    Sub Main()
        Console.WriteLine("Che scuola frequenti? ")
        Dim NomeScuola As String
        NomeScuola = Console.ReadLine()
        Console.WriteLine("Dove si trova? ")
        Dim LuogoScuola As String
        LuogoScuola = Console.ReadLine()
        Console.WriteLine("Quanto ci metti ad arrivare?")
        Dim DistanzaDaCasa As Double
        DistanzaDaCasa = Console.ReadLine()
        Console.WriteLine("Frequento " & NomeScuola & ".")
        Console.WriteLine("Si trova a " & LuogoScuola & ".")
        Console.WriteLine("Ci metto " & DistanzaDaCasa & " ad arrivare.")
        Console.ReadLine()
    End Sub
End Module
