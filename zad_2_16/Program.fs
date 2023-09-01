open System

let f x = x * x
let g x = -x / 2.0 + 5.0

let reverse_composition_operator = f << g
let forward_composition_operator = f >> g

Console.WriteLine("f << g dla liczby {0} = {1}.", 0.0, reverse_composition_operator 0.0)
Console.WriteLine("f << g dla liczby {0} = {1}.", 1.0, reverse_composition_operator 1.0)

Console.WriteLine("f >> g dla liczby {0} = {1}.", 0.0, forward_composition_operator 0.0)
Console.WriteLine("f >> g dla liczby {0} = {1}.", 1.0, forward_composition_operator 1.0)

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore
