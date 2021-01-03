module IfStatement

let main argv =
    let a : int32 = 100
    let b : int32 = 200

    (* check the boolean condition using if statement *)

    if (a = 10) then
       printfn "Value of a is 10\n"
    elif (a = 20) then
       printfn " Value of a is 20\n"
    elif (a = 30) then
       printfn " Value of a is 30\n"
    else
       printfn " None of the values are matching\n"
       printfn "Value of a is: %d" a


    if (a = 100) then
    (* if condition is true then check the following *)
        if (b = 200) then
   printfn "Value of a is 100 and b is 200\n"
printfn "Exact value of a is: %d" a
printfn "Exact value of b is: %d" b
0