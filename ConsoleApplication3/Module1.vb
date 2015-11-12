Module Module1

    Sub Main()


        Dim keyin, guess, count, min, max As Integer
        count = 0
        min = 0
        max = 1000
        Dim a As New Random()
        guess = a.Next(1, 1000)
        Console.WriteLine("          ---- 猜數字遊戲 ----          ")
        Console.WriteLine()
        Do
            Console.Write(" 範圍是 {0} < ？ < {1} :", min, max)
            keyin = Val(Console.ReadLine())
            count += 1
            If keyin >= 1 And keyin < 1000 Then
                If keyin = guess Then
                    Console.WriteLine(" Bingo！恭喜你猜對了！")
                    Console.WriteLine(" 你一共猜了 {0} 次", count)
                    Exit Do
                ElseIf keyin > guess Then
                    max = keyin
                    Console.Write(" 再猜小一點！ ")
                ElseIf keyin < guess Then
                    min = keyin
                    Console.Write(" 再猜大一點！ ")
                End If
                Console.WriteLine(" 你目前猜了 {0} 次 ", count)
                Console.WriteLine()
            Else
                Console.WriteLine(" 請輸入提示中的數字！ ")
            End If
        Loop While True
        Console.Read()

    End Sub

End Module
