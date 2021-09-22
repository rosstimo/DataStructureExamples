Module DataStructures

    Sub Main()
        ArrayExample()
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

End Module
