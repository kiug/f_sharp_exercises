open System

Console.WriteLine("Program ilustruje działanie funkcji signum.")
Console.WriteLine()

let signum = function
    | i when i < 0.0 -> -1
    | 0.0 -> 0
    | _ -> 1

Console.WriteLine("Funkcja signum({0}) = {1}.", -5.0, signum -5.0)
Console.WriteLine("Funkcja signum({0}) = {1}.", 0.0, signum 0.0)
Console.WriteLine("Funkcja signum({0}) = {1}.", 30.0, signum 30.0)

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore

