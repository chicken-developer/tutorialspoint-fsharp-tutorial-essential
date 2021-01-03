// Learn more about F# at http://fsharp.org

open System

let sign number =
    if number > 5  || number = 5 then "This is bigger number"
    elif number > 10 then "This is biggest number"
    else "This is any number"
    //Comment
    (* Comment *)
[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
 
    Console.WriteLine( "Sign of 5 is: {0}", (sign 5))
    0 