open System

let liczba = -7
let kwadrat x = x * x
let sześcian x = x * x * x

let znak x =
    match x with
    | x when x > 0 -> "dodatnia"
    | x when x < 0 -> "ujemna"
    | _ -> "zerem"

let transfer f = f liczba

Console.WriteLine("Kwadrat z liczby {0} wynosi {1}.", liczba, transfer kwadrat)
Console.WriteLine("Sześcian z liczby {0} wynosi {1}.", liczba, transfer sześcian)
Console.WriteLine("Liczba {0} jest {1}.", liczba, transfer znak)

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore

