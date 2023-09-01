open System

let fibonacci n : bigint =
    let rec pętla a1 a2 n =
        match n with
        | 0 -> a1
        | 1 -> a2
        | n -> pętla a2 (a1 + a2) (n - 1)
    pętla (bigint 0) (bigint 1) n

let start = DateTime.Now
Console.WriteLine("fibonacci(1000) = {0}.", fibonacci 1000)
let stop = DateTime.Now
Console.WriteLine("Czas obliczeń = {0}", stop - start)

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore

