## Discriminated Unions

* Nothing really like it in C#
  * Kinda like enums with data
  * Kinda like abstract classes (but better)
* "Additive" types
* Requires pattern matching

+++?code=src/DiscriminatedUnions/Creation.fs&lang=FSharp&title="Discriminated Unions"

@[1](One liner)
@[2-3](Constructing a Result)
@[5-7](Generics)
@[9-15](Multiline with a variety of data)

+++?code=src/DiscriminatedUnions/PatternMatching.fs&lang=FSharp&title="Pattern Matching"

@[1-6](Define some types)
@[8-12](Simple pattern matching)
@[14-23](Complex patterns)

+++

### Pattern Matching

* Can be used with all types
* Can be used to check if something is a subtype (`:? int`)
* Must be exhaustive (`_` can be used to catch all remaining cases)