open System

Console.WriteLine("Program oblicza rekurencyjnie kolejne liczby Lucasa.")
Console.WriteLine()

let rec liczba_lucasa = function
    | 0 -> 2
    | 1 -> 1
    | n -> liczba_lucasa(n - 1) + liczba_lucasa(n - 2)

for i = 0 to 10 do
    Console.WriteLine(liczba_lucasa i)

Console.WriteLine("liczba_lucasa(10) = {0}.", liczba_lucasa 10)

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore

