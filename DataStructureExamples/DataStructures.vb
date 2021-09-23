Module DataStructures

    Sub Main()
        'ArrayExample()
        TestRandom()


        Console.ReadLine()

    End Sub

    Sub ArrayExample()
        Dim fruit(3) As String
        Dim names(1, 5) As String

        fruit(0) = "apple"
        fruit(1) = "banana"
        fruit(2) = "orange"
        fruit(3) = "pear"
        'fruit(4) = "tomato"

        Console.WriteLine(fruit(2))

        For i = LBound(fruit) To UBound(fruit)
            Console.WriteLine(fruit(i))
        Next

        names(0, 0) = "Bob"
        names(1, 0) = "Marley"
        names(0, 1) = "Jimmy"
        names(1, 1) = "Page"


        Console.ReadLine()
    End Sub

    Sub TestRandom()
        Dim biggestNumber As Integer = 10
        Dim RandomNumbers(10) As Integer

        'get random numbers
        For i = 0 To 100000
            RandomNumbers(RandomNumberInRange(6)) += 1
        Next
        'write header
        For i = LBound(RandomNumbers) To UBound(RandomNumbers)
            Console.Write(CStr(i).PadLeft(6) & " |")
        Next
        Console.WriteLine()
        Console.WriteLine(StrDup(70, "-"))
        'write values
        For i = LBound(RandomNumbers) To UBound(RandomNumbers)
            Console.Write(CStr(RandomNumbers(i)).PadLeft(6) & " |")
        Next

    End Sub

    Function RandomNumberInRange(max As Integer) As Integer
        Dim randomNumber As Integer

        randomNumber = CInt(System.Math.Floor(Rnd() * (max + 1)))

        Return randomNumber
    End Function

End Module
