open System
open System.IO

[<EntryPoint>]
let main _ =
    Functions.SubFunctions.writeToTxt() |> ignore
    Console.ReadKey(true) |> ignore
    0 //function returns 0