Option Strict On
Option Explicit On
Option Compare Text
'Baden Brenner
'RCET 0265 
'spring 23
'Roll the Dice

Imports System

Module Program
    Sub Main(args As String())
        Dim rollValue As Integer
        Dim rollCount(11, 1) As Integer
        Dim numberofRolls As Integer
        Dim printcount As Integer

        'setting the column labels 
        rollCount(0, 0) = 1
        rollCount(1, 0) = 2
        rollCount(2, 0) = 3
        rollCount(3, 0) = 4
        rollCount(4, 0) = 5
        rollCount(5, 0) = 6
        rollCount(6, 0) = 7
        rollCount(7, 0) = 8
        rollCount(8, 0) = 9
        rollCount(9, 0) = 10
        rollCount(10, 0) = 11
        rollCount(11, 0) = 12

        'Reseting The Array
        rollCount(0, 1) = 0
        rollCount(1, 1) = 0
        rollCount(2, 1) = 0
        rollCount(3, 1) = 0
        rollCount(4, 1) = 0
        rollCount(5, 1) = 0
        rollCount(6, 1) = 0
        rollCount(7, 1) = 0
        rollCount(8, 1) = 0
        rollCount(9, 1) = 0
        rollCount(10, 1) = 0
        rollCount(11, 1) = 0

        Do Until numberofRolls = 1000
            Dim Dice1 As Integer
            Randomize()
            Dice1 = CInt(Int((6 * Rnd()) + 1))

            Dim Dice2 As Integer
            Randomize()
            Dice2 = CInt(Int((6 * Rnd()) + 1))

            rollValue = (Dice1 + Dice2)


            If rollValue = 1 Then
                rollCount(0, 1) = rollCount(0, 1) + 1
            ElseIf rollValue = 2 Then
                rollCount(1, 1) = rollCount(1, 1) + 1
            ElseIf rollValue = 3 Then
                rollCount(2, 1) = rollCount(2, 1) + 1
            ElseIf rollValue = 4 Then
                rollCount(3, 1) = rollCount(3, 1) + 1
            ElseIf rollValue = 5 Then
                rollCount(4, 1) = rollCount(4, 1) + 1
            ElseIf rollValue = 6 Then
                rollCount(5, 1) = rollCount(5, 1) + 1
            ElseIf rollValue = 7 Then
                rollCount(6, 1) = rollCount(6, 1) + 1
            ElseIf rollValue = 8 Then
                rollCount(7, 1) = rollCount(7, 1) + 1
            ElseIf rollValue = 9 Then
                rollCount(8, 1) = rollCount(8, 1) + 1
            ElseIf rollValue = 10 Then
                rollCount(9, 1) = rollCount(9, 1) + 1
            ElseIf rollValue = 11 Then
                rollCount(10, 1) = rollCount(10, 1) + 1
            ElseIf rollValue = 12 Then
                rollCount(11, 1) = rollCount(11, 1) + 1S
            Else
                Console.WriteLine("oops")
            End If

            numberofRolls = numberofRolls + 1

        Loop
        Console.WriteLine("Dice Rolls by Number of Times That a Roll Occurs")

        For printcount = 0 To 11 Step 1
            Console.Write(Str(rollCount(printcount, 0)).PadLeft(4))
        Next
        Console.WriteLine()
        For printcount = 0 To 11 Step 1
            Console.Write(Str(rollCount(printcount, 1)).PadLeft(4))
        Next

    End Sub
End Module
