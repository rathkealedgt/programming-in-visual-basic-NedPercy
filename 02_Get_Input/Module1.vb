Public Class Form1

    Sub main()
        Dim UserName, OutputMessage As String
        Dim FirstNumber, SecondNumber, Sum, Product As Integer
        Console.WriteLine("Please enter you name")
        UserName = Console.ReadLine()

        Console.WriteLine("Please enter your favourite number")
        FirstNumber = Console.ReadLine()

        Console.WriteLine("Please enter your second favourite number")
        SecondNumber = Console.ReadLine()


        OutputMessage = String.Format("Hello(0)", UserName)
        Console.WriteLine(OutputMessage)
        Console.ReadLine()

    End Sub

End Class

