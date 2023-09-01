open System

Console.WriteLine("Program oblicza sumę, różnicę, iloczyn i iloraz dla x i y.")
Console.WriteLine()

Console.WriteLine("Podaj x.")
let x = Double.Parse(Console.ReadLine())
Console.WriteLine("Podaj y.")
let y = Double.Parse(Console.ReadLine())

let suma x y = x + y
let różnica x y = x - y
let iloczyn x y = x * y
let iloraz x y = x / y

Console.WriteLine()
Console.WriteLine("suma = {0:##.##},", suma x y)
Console.WriteLine("różnica = {0:##.##},", różnica x y)
Console.WriteLine("iloczyn = {0:##.##},", iloczyn x y)
Console.WriteLine("iloraz = {0:##.##},", iloraz x y)

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore

