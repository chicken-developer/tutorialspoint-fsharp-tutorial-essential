module Operator

let a_0 : int32 = 21
let b_0 : int32 = 10

let mutable c = a_0 + b_0
printfn "Line 1 - Value of c is %d" c

c <- a_0 - b_0
printfn "Line 2 - Value of c is %d" c

c <- a_0 * b_0
printfn "Line 3 - Value of c is %d" c

c <- a_0 / b_0
printfn "Line 4 - Value of c is %d" c
c <- a_0 % b_0

let mutable a : int32 = 21
let mutable b : int32 = 10

if (a = b) then
   printfn "Line 1 - a is equal to b"
else
   printfn "Line 1 - a is not equal to b"

if (a < b) then
   printfn "Line 2 - a is less than b"
else
   printfn "Line 2 - a is not less than b"

if (a > b) then
   printfn "Line 3 - a is greater than b"
else
   printfn "Line 3 - a is not greater than b"

(* Lets change value of a and b *)
a <- 5
b <- 20

if (a <= b) then
   printfn "Line 4 - a is either less than or equal to b"
else
   printfn "Line4 - a is a is greater than b"

   ///Notes:
       // == replace by = (not have ==)
       // != replace by <> (not have !=)