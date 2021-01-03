module Variables

let x = 15
let y = 20
let z = x + y

printfn "x: %i" x
printfn "y: %i" y
printfn "z: %i" z

let x_1:int32 = 10
let y_1:int32 = 20
let z_1:int32 = x + y

printfn "x: %d" x_1
printfn "y: %d" y_1
printfn "z: %d" z_1

let p:float = 15.99
let q:float = 20.78
let r:float = p + q

printfn "p: %g" p
printfn "q: %g" q
printfn "r: %g" r


let mutable x_2 = 10
let y_2 = 20
let mutable z_2 = x_2 + y_2

printfn "Original Values:"
printfn "x: %i" x_2
printfn "y: %i" y_2
printfn "z: %i" z_2

printfn "Let us change the value of x"
printfn "Value of z will change too."

x_2 <- 15
z_2 <- x + y

printfn "New Values:"
printfn "x: %i" x_2
printfn "y: %i" y_2
printfn "z: %i" z_2


///Notes: 
   //Define a value: let x | let x: int32 | let x: float32 ,...
   //Define a variable: let mutable x = 10
   //Change value of variable x <- 20