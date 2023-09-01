open System

Console.WriteLine("Program ilustruje działanie operatora logicznego OR.")
Console.WriteLine()

let operator_OR a b =
    match a, b with
    | true, _ -> true
    | _, true -> true
    | _ -> false

Console.WriteLine("True OR True -> {0}.", operator_OR true true)
Console.WriteLine("True OR False -> {0}.", operator_OR true false)
Console.WriteLine("False OR True -> {0}.", operator_OR false true)
Console.WriteLine("False OR False -> {0}.", operator_OR false false)

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore

