module DefaultFSharp.TestSemanticHighlighting

// Here's a function that accepts parameters and uses local variables
let addAndSquare x y =  // parameters x and y
    let sum = x + y     // local variable
    sum * sum

// Function calls
let result = addAndSquare 5 7
printfn "The result of the function call is %A" result

// Variable in the loop
for number in [1..10] do     // for loop with a local variable
    let squared = number * number  // local variable inside the loop
    printfn "The square of %A is %A" number squared 

// Variable in list comprehension
let squares = [ for number in [1..10] -> number * number ] // local variable in list comprehension
printfn "The squares are: %A" squares

