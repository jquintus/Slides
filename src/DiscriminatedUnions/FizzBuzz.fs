let fizzBuzz max =
    let inner = 
        function 
        | x when x % 15 = 0 -> printfn "fizzbuzz"
        | x when x %  5 = 0 -> printfn "fizz"
        | x when x %  3 = 0 -> printfn "buzz"
        | x                 -> printfn "%A" x
    [ 1 .. max ]
    |> List.iter inner

fizzBuzz 16