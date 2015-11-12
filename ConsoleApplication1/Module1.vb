Module Module1

    Sub Main()

        Dim height, weight As Single
        Console.Write("請輸入你的體重 :")
        weight = Console.ReadLine()
        Console.Write("請輸入你的身高 :")
        height = Console.ReadLine()

        Dim bmi As Single = Single.Parse(Console.Read)
        bmi = weight / (height / 100) ^ 2
        Console.Write("你的BMI值為: {0} ", bmi)
        Console.ReadLine()
        Console.Read()

    End Sub

End Module
