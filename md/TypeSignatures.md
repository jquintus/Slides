## Type Signatures

+++

### Simple Function

```FSharp
let intToString (x:int) = x.ToString()
```

`int -> string`

+++

### Generic Function

```FSharp
let intToString x = x.ToString()
```

`'a -> string`

+++

### Function with Two Parameters

```FSharp
let add x y = x + y

let sum = add 8 80
```

`int -> int -> int`

+++

### Currying

```FSharp
let add8 y = add 8 y
let add8' = add 8

let sum = add8 80
```

`int -> int`

+++

### Functions as Parameters

```FSharp
let pred2String predicate x =
    if predicate x then
        "true"
    else
        "false"
```

`('a -> string) -> 'a -> string`

+++

### unit

```FSharp
let printDouble x =
    printf "%i" (x * 2)
```

`int -> unit`

+++

### Tuples

```FSharp
let add t =
    let (x, y) = t
    x + y

let add1 t d=
    let (x, y, z) = t
    (x + d, y + d, z + d)
```

`int * int -> int`
`int * int * int -> int -> int * int * int`