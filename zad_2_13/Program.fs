open System

Console.WriteLine("Program wyznacza największy wspólny dzielnik dwóch liczb: 259, 111.")
Console.WriteLine()

let rec nwd a b =
    if b = 0 then a
    else nwd b (a % b)

Console.WriteLine("nwd(259, 111) = {0}.", nwd 259 111)

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore

