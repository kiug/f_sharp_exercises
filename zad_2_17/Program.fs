open System

let suma = fun x y -> x + y

Console.WriteLine("3 + 4 = {0}.", suma 3 4)
Console.WriteLine("3 + 4 = {0}.", (fun x y -> x + y) 3 4)

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore

