# F &#35;

![logo](assets/logo.png)

---

## Topics

* What is F#
* Syntax
* Types
* Currying
* Awesome sauce

---

## What is F &#35;

* Functional First
  * Immutable
  * Functions as a first class citizen
  * No nulls
* .Net
  * Can call into C#/VB
  * Can be called from C#/VB
  * Has access to the .Net Framework

---

## Types

* Tupples
* Records
* Discriminated Unions
* Options
* Units
* Classes

+++

## Tupples

```Fsharp
let myTupple = ("apples", 5)
let (fruit, count) = myTupple

type FruitOrder = string * float * int
let calculateTotal order : FruitOrder =
  let (_, cost, count) = order
  cost * count

let cost = calculateTotal ("apples", .35, 2)
```

@[1](Constructing a tupple)
@[2](Deconstructing the tupple)
@[4](Giving a tupple a name)
@[5](Using that name)
@[6](Ignoring a value when deconstructing a tupple)
@[5-9](Passing a tuple into a function)

+++

## Records

```FSharp
type FruitOrder = { fruit: string; price: float; count: int}

type FruitOrder = {
  fruit: string
  price: float
  count: int
}

let myOrder = { fruit = "apples"; price = 0.35; count = 2 }
let calculateTotal order =
  let (cost = myCost; count = myCount) = order
  myCost * myCount
```

@[1](Defining a record in one line)
@[3-7](Defining a record on multiple lines (no more semicolons))
@[9](Constructing a record)
@[10-12](Passing a record into a function and deconstructing it)

---

## Resources

* [F# for fun and profit](https://fsharpforfunandprofit.com)
