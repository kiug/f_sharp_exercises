open System

Console.WriteLine("Program ilustruje działanie operatora logicznego AND.")
Console.WriteLine()

let operator_AND a b =
    match a, b with
    | true, true -> true
    | _ -> false

Console.WriteLine("True AND True -> {0}.", operator_AND true true)
Console.WriteLine("True AND False -> {0}.", operator_AND true false)
Console.WriteLine("False AND True -> {0}.", operator_AND false true)
Console.WriteLine("False AND False -> {0}.", operator_AND false false)

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore

