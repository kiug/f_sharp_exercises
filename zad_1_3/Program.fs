open System

Console.WriteLine("Program wyświetla pierwiastek kwadratowy z liczby pi")
Console.WriteLine("z dokładnością do dwóch miejsc po przecinku.")
Console.WriteLine()

Console.WriteLine("Sqrt(pi) = {0:##.##}.", Math.Sqrt(Math.PI))

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore

