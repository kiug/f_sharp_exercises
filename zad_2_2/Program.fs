open System

Console.WriteLine("Program oblicza objętość kuli o pormieniu r.")
Console.WriteLine()

Console.WriteLine("Podaj r.")
let r = Double.Parse(Console.ReadLine())

Console.Write("Objętość kuli o promieniu r = {0:##.##}", r)

let objętość (r : Double) = 4.0 * Math.PI * r ** 3.0 / 3.0

Console.WriteLine(" wynosi {0:##.##}.", objętość r)

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore

