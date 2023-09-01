open System

Console.WriteLine("Program oblicza rekurencyjnie kolejne liczby Fibonacciego.")
Console.WriteLine()

let rec liczba_fibonacciego_nto = function
    | n when n = 0I -> 0I
    | n when n = 1I -> 1I
    | n -> liczba_fibonacciego_nto(n - 1I) + liczba_fibonacciego_nto(n - 2I)

let liczba_fibonacciego n =
    let rec pętla a1 a2 = function
        | n when n = 0I -> a1
        | n -> pętla a2 (a1 + a2) (n - 1I)
    pętla 0I 1I n

let start = DateTime.Now
Console.WriteLine("liczba_fibonacciego(10) = {0}.", liczba_fibonacciego 35I)
let stop = DateTime.Now

Console.WriteLine("Czas obliczeń = {0}", stop - start)

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore

