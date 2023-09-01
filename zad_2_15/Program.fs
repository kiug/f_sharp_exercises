open System

let liczba = 2
let kwadrat x = x * x
let sześcian x = x * x * x

// operator potokowy zdefinowany w bibliotece standardowej (forward pipe operator)
// let (|>) x f = f x
let (>>>>) x f = f x

Console.WriteLine("Wynik operatora potokowego >>>> {0}.", liczba >>>> kwadrat >>>> sześcian)
Console.WriteLine("Wynik operatora potokowego |> {0}.", liczba |> kwadrat |> sześcian)

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore

