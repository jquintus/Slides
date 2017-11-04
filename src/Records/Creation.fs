type Person = { firstName: string; lastName: string}
let mcFly = { firstName = "Marty"; lastName = "McFly" }

type FruitOrderRecord = {
  fruit: string
  price: float
  count: int
}

let calculateTotal order =
  let { price = _; count = myCount } = order
  order.price * float(myCount)

let total = calculateTotal { fruit = "apples"; price = 0.35; count = 2 }