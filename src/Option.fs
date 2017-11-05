let split (subString: string) (input: string) =
    let idx = input.IndexOf(subString)
    if (idx > 0) then 
        let prefix = input.Substring(0, idx)
        let suffix = input.Substring(idx + 1) 
        Some  (prefix , subString, suffix)
    else
        None

let getPrefix = function 
    | Some (pre, _, _) -> pre
    | None             -> ""

let splitOnSpace = split " "

let failure = getPrefix (splitOnSpace "Hello")
let  success = 
    "Hello world" 
    |> splitOnSpace
    |> getPrefix

let dynamite = ("boom" |> splitOnSpace).Value