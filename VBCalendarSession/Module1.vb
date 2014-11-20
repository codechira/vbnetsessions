Module Module1

    Sub Main()
        'What is a Program?
        '   Data <-- --> Logic
        '   Data 
        '       Variables: They change their value during the program
        '           Native Type/Value types -- stored on Stack
        '               Fixed in size
        '           Object type /reference type -- stored on Heap
        '               Dynamic in size
        '       Constants: Do not change their value

        '       Lifecycle of a variable
        '           Declare
        '           Assign/Use 
        '           Dispose -- not required for native type varibles

        'Declare
        Dim flag As Boolean
        Dim count As Integer
        Dim precision As Double
        Dim accuracy As Single
        Dim name As String

        'Assign
        flag = True
        count = 10
        precision = 10.42367575879797
        accuracy = 10.5456
        name = "Ruchira"

        Console.WriteLine("This is a VB session Day 1")
        Console.ReadLine()

        Dim number1 As Integer
        number1 = 20

        Dim number2 As Integer
        number2 = 30

        Dim sum As Integer
        sum = number1 + number2

        Dim product As Integer
        product = number1 * number2

        Dim division As Integer
        division = number2 / number1

        Dim remainder As Integer
        Math.DivRem(number1, number2, remainder)

        'Concatenation of strings
        Dim message1 As String
        message1 = "This is the first day of classroom session"

        Dim message2 As String
        message2 = " and we are learning basics of VB.Net"

        Dim resultmessage As String
        resultmessage = message1 + message2
        Console.WriteLine("The new message is " + resultmessage)
        Console.ReadLine()

        Dim position As Integer
        position = InStr(resultmessage, "of")
        Console.WriteLine(position)
        Console.ReadLine()

        Dim somemorefunctions As String
        somemorefunctions = resultmessage.Substring(10)
        'Console.WriteLine(somemorefunctions)
        'Console.ReadLine()

        'Reference Type variables
        '   Collections
        '       list variable
        '       can store any data type and multiple types
        '       dynamically grows in size
        '       keys can be provided easily
        '       1 based

        'Declare
        Dim pcollection As New Collection

        'Use -- Adding items in a collection
        pcollection.Add(1)
        pcollection.Add("Ruchira")
        pcollection.Add("Pune")

        'retrieving an item from a collection
        'Object -- consider as base class, can point to anything
        '   late binding
        Dim givemecollobject As Object
        givemecollobject = pcollection.Item(2)
        Console.WriteLine(givemecollobject)
        Console.ReadLine()

        'Declare
        Dim pCollection2 As New Collection
        pCollection2.Add(2)
        pCollection2.Add("Satender")
        pCollection2.Add("Chandigarh")

        'Declare
        Dim pRows As New Collection

        'Add collections to pRow collection
        pRows.Add(pcollection)
        pRows.Add(pCollection2)

        Dim getaRow As New Collection
        'retrieve the second collection from pRows
        getaRow = pRows.Item(2)

        'Console.WriteLine(getaRow.Item(2))
        Dim item As Object
        item = getaRow.Item(2)

        Console.WriteLine("The second item inside the second collection of pRows is " + item)
        Console.ReadLine()

        'Disposing
        pcollection = Nothing

    End Sub
End Module
