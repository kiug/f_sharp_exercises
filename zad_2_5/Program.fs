open System

let pozdrowienie imię =
    match imię with
    | "Andrzej" | "Jerzy" | "Janka" -> Console.Write("Cześć!")
    | "Steve" | "Dorothy" | "John" -> Console.Write("Hello!")
    | "Carlos" | "Maria" -> Console.Write("Hola!")
    | "Pierre" | "Monique" -> Console.Write("Bonjour!")
    | _ -> Console.Write("Nie mogę pozdrowić.")

Console.WriteLine(pozdrowienie "Jerzy")
Console.WriteLine(pozdrowienie "Dorothy")
Console.WriteLine(pozdrowienie "Carlos")
Console.WriteLine(pozdrowienie "Pierre")
Console.WriteLine(pozdrowienie "Piotr")

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore

