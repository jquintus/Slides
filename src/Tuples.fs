let myTuple = ("apples", 5)
let (fruit, count) = myTuple

type FruitOrder = string * float * int
let calculateTotal (order: FruitOrder) =
  let (_, cost, count) = order
  cost * float count

let cost = calculateTotal ("apples", 0.35, 2)