module Function


    let simpleFunc arg_1 arg_2 = 
        arg_1 + arg_2

    let sum = simpleFunc 23 53
    printfn "Value: %i" sum

    //Inscope define
    let list1 = [ 1; 2; 3]
    let sumPlus x =
    // OK: inner list1 hides the outer list1.
       let list1 = [1; 5; 10]
       x + List.sum list1
 

    let cylinderVolume radius length =
         // Define a local value pi.
         let pi = 3.14159
         length * pi * radius * radius

    let cylinderVolume_02 radius length : float =
     // Define a local value pi.
     let pi = 3.14159
     length * pi * radius * radius

     //Currying
    let cylinderVolume_03 (radius : float) (length : float) : float = 
        let pi = 3.14159
        length * pi * radius * radius
     
    let simpleFuncWithType(arg_1: float32, arg_2: float32) : float32 = 
        let total = arg_1 + arg_2
        total
 
    let vol = cylinderVolume 2.0 3.0 //Call func
 

    let smallPipeRadius = 2.0
    let bigPipeRadius = 3.0
    
    // These define functions that take the length as a remaining
    // argument:
    
    let smallPipeVolume = cylinderVolume smallPipeRadius
    let bigPipeVolume = cylinderVolume bigPipeRadius

    let apply1 (transform : int -> int ) y = transform y
    let increment x = x + 1
    let result1 = apply1 increment 100 // HOF - Higher order function

    let apply2 ( f: int -> int -> int) x y = f x y 
    let mul x y = x * y
    let result2 = apply2 mul 10 20 // HOF combine with currying

    let result3 = apply1 (fun x -> x + 1) 100   //Lambda
    let result4 = apply2 (fun x y -> x * y ) 10 20 //Labda

    //Pipline - combine more function into 1
    let function1 x = x + 1
    let function2 x = x * 2
    let h = function1 >> function2
    let result5 = h 100  
    let result6 = 100 |> function1 |> function2

    // Function composition and pipeline operators compared.
    
    let addOne x = x + 1
    let timesTwo x = 2 * x
    
    // Composition operator
    // ( >> ) : ('T1 -> 'T2) -> ('T2 -> 'T3) -> 'T1 -> 'T3
    let Compose2 = addOne >> timesTwo
    
    // Backward composition operator
    // ( << ) : ('T2 -> 'T3) -> ('T1 -> 'T2) -> 'T1 -> 'T3
    let Compose1 = addOne << timesTwo
    
    // Result is 5
    let result1_1 = Compose1 2
    
    // Result is 6
    let result2_2 = Compose2 2
    
    // Pipelining
    // Pipeline operator
    // ( |> ) : 'T1 -> ('T1 -> 'U) -> 'U
    let Pipeline2 x = addOne x |> timesTwo
    
    // Backward pipeline operator
    // ( <| ) : ('T -> 'U) -> 'T -> 'U
    let Pipeline1 x = addOne <| timesTwo x
    
    // Result is 5
    let result3_3 = Pipeline1 2
    
    // Result is 6
    let result4_4 = Pipeline2 2
    
    // Lambda expressions with parameter lists.
    fun a b c -> 2
    fun (a: int) b c -> 2
    fun (a : int) (b : string) (c:float) -> 2
    
    // A lambda expression with a tuple pattern.
    fun (a, b) -> 2
    
    // A lambda expression with a list pattern.
   // fun head :: tail -> ...
///Notes:
    // Non-recursive function definition.
    //let [inline] function-name parameter-list [ : return-type ] = function-body
    
    // Recursive function definition.
    //let rec function-name parameter-list = recursive-function-body

    //Lambda with fun key word
    //Pipline
    //Can't overload function - only can overload method
