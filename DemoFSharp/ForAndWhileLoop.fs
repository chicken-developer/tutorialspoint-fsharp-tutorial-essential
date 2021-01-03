module ForAndWhileLoop

let loop() =
   for i = 1 to 20 do
      printfn "i: %i" i
loop()

let loop_down() =
   for i = 20 downto 1 do
      printfn "i: %i" i
loop_down()

let loop_in() =
 for i = 1 to 5 do
    printf "\n"
    for j = 1 to 3 do
       printf "*"
loop_in()

// Looping over a list.
let list1 = [ 10; 25; 34; 45; 78 ]
for i in list1 do
   printfn "%d" i

// Looping over a sequence.
let seq1 = seq { for i in 1 .. 10 -> (i, i*i) }
for (a, asqr) in seq1 do
   printfn "%d squared is %d" a asqr

let mutable a = 10
while (a < 20) do
   printfn "value of a: %d" a
   a <- a + 1


