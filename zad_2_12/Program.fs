open System

Console.WriteLine("Program oblicza rekurencyjnie kolejne liczby Fibonacciego.")
Console.WriteLine()

let rec liczba_fibonacciego = function
    | 0 -> 0
    | 1 -> 1
    | n -> liczba_fibonacciego(n - 1) + liczba_fibonacciego(n - 2)

for i = 0 to 10 do
    Console.WriteLine(liczba_fibonacciego i)

Console.WriteLine("liczba_fibonacciego(10) = {0}.", liczba_fibonacciego 10)

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore

