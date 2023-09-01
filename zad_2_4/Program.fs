open System

Console.WriteLine("Prosty program ilustrujący dopasowanie do wzorca.")
Console.WriteLine()

Console.WriteLine("Podaj ocenę cyfrą.")
let ocena = Int32.Parse(Console.ReadLine())

match ocena with
| 1 -> Console.WriteLine("Niedostateczny.")
| 2 -> Console.WriteLine("Dopuszczający.")
| 3 -> Console.WriteLine("Dostateczny.")
| 4 -> Console.WriteLine("Dobry.")
| 5 -> Console.WriteLine("Bardzo dobry.")
| 6 -> Console.WriteLine("Celujący.")
| _ -> Console.WriteLine("Nie ma takiej oceny.")

Console.WriteLine("Naciśnij dowolny klawisz.")
Console.ReadKey(true) |> ignore

