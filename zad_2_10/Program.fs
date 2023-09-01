open System

Console.WriteLine("Program oblicza 10! wykorzystując mechanizm rekurencji.")
Console.WriteLine()

let rec silnia = function
    | 0 | 1 -> 1
    | n -> n * silnia(n - 1)

Console.WriteLine("silnia(10) = {0}.", silnia 10)

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore

