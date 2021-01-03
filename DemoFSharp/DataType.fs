module DataType
open System

let main argv =
    (*Single byte integer*)

    let floatSingle_X = 2143.99f //Float single
    let floatSingle_Y = 2312.3242f

    let totalFS_Z = floatSingle_X + floatSingle_Y

    printfn "x = %f" floatSingle_X
    printfn "y = %f" floatSingle_Y
    printfn "z = %f" totalFS_Z

    let b = 42y //1 byte from -128 to 127
    let p = 2uy //1 byte from 0 to 255
    let p_01 = 43uy
    (*Can't sum byte with sbyte*)
    let p_02 = p + p_01
    
    printfn "x = %i" b
    printfn "y = %i" p
    printfn "z = %i" p_02

    let a = 12s
    let b = 24s
    let c = a + b
    
    printfn "a: %i" a
    printfn "b: %i" b
    printfn "c: %i" c
    
    (* signed 32-bit integer *)
    
    let d = 212l
    let e = 504l
    let f = d + e
    
    printfn "d: %i" d
    printfn "e: %i" e
    printfn "f: %i" f

    
    let d = 212.098f
    let e = 504.768f
    let f = d + e
    
    printfn "d: %f" d
    printfn "e: %f" e
    printfn "f: %f" f
    
    (* 64-bit signed floating point number *)
    (* 15-16 significant digits *)
    let x = 21290.098
    let y = 50446.768
    let z = x + y
    
    printfn "x: %g" x
    printfn "y: %g" y
    printfn "z: %g" z

    let choice = 'y'
    let name = "Zara Ali"
    let org = "Tutorials Point"
    
    printfn "Choice: %c" choice
    printfn "Name: %s" name
    printfn "Organisation: %s" org

    let trueVal = true
    let falseVal = false
    
    printfn "True Value: %b" (trueVal)
    printfn "False Value: %b" (falseVal)

    ///Notes:
    // float : %f | integer: %i | decimal: %g | bool: %b (value)
   