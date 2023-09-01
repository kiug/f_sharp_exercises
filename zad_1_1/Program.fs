open System

Console.WriteLine("Prosty program ilustrujący wykorzystanie słowa kluczowego let.")

let ą = 2
let b = 3
let ć = ą + b

Console.Write("ą = {0}, ", ą)
Console.Write("b = {0}, ", b)
Console.Write("ć = ą + b = {0}", ć)
Console.WriteLine()

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore

