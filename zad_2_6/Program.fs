open System

let jest_parzysta x = (x % 2 = 0)

let liczba x =
    match jest_parzysta x with
    | true -> Console.WriteLine("Liczba {0} jest parzysta.", x)
    | false -> Console.WriteLine("Liczba {0} jest nieparzysta.", x)

Console.WriteLine(liczba 3)
Console.WriteLine(liczba 30)

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore

