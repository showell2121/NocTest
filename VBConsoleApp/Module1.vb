Imports Class1
Module Module1

  Sub Main()
    Dim testInt As Double = 32

    Console.WriteLine("Number of Test {0}", testInt)
    Console.WriteLine(43)

    'Chapter 4'
    Dim test1 As Double = 80.0
    Dim test2 As Double = 90.5

    Dim testResult As Integer = test1 + test2

    Console.WriteLine("Why is you test result like this {0}", testResult) 'what happened to the .5'

    Dim testResult2 As Double = test1 + test2

    Console.WriteLine("Why is you test2 result like this {0}", testResult2) 'what happened to the .5'


    'If statment must have End If'
    If testResult2 = 170.5 Then
      Console.WriteLine("In IF")
    Else
      Console.WriteLine("In Else")

    End If

    'Creates New Object
    Dim obj1 As New Class1
    obj1.name = "Seth"

    Console.WriteLine("Name: {0} ", obj1.name)






    'Prevents Terminal From closing without seeing results' 
    Console.ReadLine()



  End Sub

End Module
