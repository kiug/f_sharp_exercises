open System

Console.WriteLine("Program oblicza pole prostokąta.")
Console.WriteLine()

Console.WriteLine("Podaj bok a.")
let a = Single.Parse(Console.ReadLine())
Console.WriteLine("Podaj bok b.")
let b = Single.Parse(Console.ReadLine())

Console.Write("Pole prostokąta o bokach a = {0} i b = {1}", a, b)

let pole_prostokąta a b = a * b

Console.WriteLine(" wynosi {0}.", pole_prostokąta a b)

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore

