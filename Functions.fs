namespace Functions
open System
open System.IO

    module SubFunctions =
        let writeToTxt() =
            File.WriteAllText("name.txt", "Wiktor Nowicki")
            let name = File.ReadAllText("name.txt")
            printfn("%s") name
            0 //function returns 0