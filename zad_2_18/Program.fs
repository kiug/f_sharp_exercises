open System

//let rec r x : int = x * r(x)
//let q = r(1)

let rec sil = function
    | (0, a) -> a
    | (n, a) -> sil((n - 1), (n * a))

let rec silnia n = sil(n, 1)

let x = silnia 1000000

// bez optymalizacji ogonowej (tail-call optimization)
//let rec silnia2 n =
//    if n = 0 then 1 else n * silnia2(n - 1)
let rec silnia2 = function
    | 0 -> 1
    | n -> n * silnia2(n - 1)

let x2 = silnia2 10000

for i = 0 to 10 do
    Console.WriteLine("{0}! = {1}.", i, silnia i)

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore

