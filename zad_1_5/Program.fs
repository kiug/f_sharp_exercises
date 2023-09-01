open System

let a = 37
let b = 11

Console.WriteLine("Program oblicza resztę z dzielenia całkowitego")
Console.WriteLine("dwóch liczb całkowitych a i b.")
Console.WriteLine()

Console.WriteLine("Dla liczb: a = {0} i b = {1}", a, b)
Console.WriteLine("{0}%{1} = {2}.", a, b, a%b)

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore

