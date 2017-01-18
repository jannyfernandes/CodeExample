Module OOP

    'base class Animal
    Class Animal

        Overridable Sub Color()
            ParentAnimal()
            Console.WriteLine("Base class Red")
        End Sub


        Private Function ParentAnimal()
            Console.WriteLine("Parent class")
        End Function

    End Class

    'child class inheriting base class Animal
    Class Peacock : Inherits Animal
        Public Overrides Sub Color()
            Console.WriteLine("Child Peacock class green")
        End Sub

    End Class

    'Child class inheriting base class Animal
    Class Cat : Inherits Animal

        'polymorphism - function overriding
        Public Overrides Sub Color()
            Console.WriteLine("Child Class Cat White")
        End Sub
        'polymorphism function overloading
        Public Function Height()
            Console.WriteLine("Height is one.")
        End Function

        Public Function Height(ByVal ht As Integer)
            Console.WriteLine("Height is " + Convert.ToString(ht))
        End Function
    End Class

    'Interface Dog
    Interface IDog
        Function Leg() As Integer

    End Interface
    'child class implementing dog and inheriting animal class
    Class Dog : Inherits Animal
        Implements IDog

        Private _num As Integer
        'property 
        Public Property Number() As Integer
            Get
                Return _num
            End Get
            Set(value As Integer)
                _num = value
            End Set
        End Property

        Public Overrides Sub Color()
            MyBase.Color()
        End Sub

        Public Function Leg() As Integer Implements IDog.Leg
            Console.WriteLine("Dog has 4 legs.")
        End Function


    End Class


    MustInherit Class Person
        MustOverride Sub Name()
    End Class

    Class Customer : Inherits Person

        Public Overrides Sub Name()
            Console.WriteLine("I like animals")
        End Sub
    End Class

    Sub Main()

        Dim c As Cat = New Cat()
        Dim d As Dog = New Dog()
        Dim p As Peacock = New Peacock()
        Dim cust As Customer = New Customer()

        Console.WriteLine("Inheritance example")
        c.Color()
        Console.WriteLine(vbCrLf & "Implementing interface example")
        d.Leg()
        Console.WriteLine(vbCrLf & "function overloading example 1")
        c.Height()
        Console.WriteLine(vbCrLf & "function overriding example 2")
        c.Height(3)
        Console.WriteLine(vbCrLf & "Encapsulation example")
        d.Color()
        Console.WriteLine(vbCrLf & "Abstraction example")
        cust.Name()
        Console.WriteLine(vbCrLf & "Properties example")
        d.Number = 10
        Console.WriteLine(d.Number & vbCrLf)

        p.Color()

    End Sub

End Module
