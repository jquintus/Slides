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

* Tuples
* Records
* Discriminated Unions
* Options
* Units
* Classes

---?code=src/Tuples.fs&lang=FSharp&title=Tuples

@[1](Constructing a tuple)
@[2](Deconstructing the tuple)
@[4](Giving a tuple a name)
@[5](Using that name)
@[6](Ignoring a value when deconstructing a tuple)
@[5-9](Passing a tuple into a function)

+++

## Tuples Summary

* Commma seperated values
* Parens useful, but not required
* Order is important
* Do not need to define anything before hand

---?code=src/Records/Creation.fs&lang-FSharp&title=Records

@[1](Defining a record in one line)
@[2](Constructing a record)
@[4-8](Defining a record on multiple lines (no more semicolons))
@[10-14](Passing a record into a function and deconstructing it)

+++?code=src/Records/With.fs&lang-FSharp&title=Records

+++?code=src/Records/StructuralEquality.fs&lang-FSharp&title=Records

@[1-4]
@[6-7](Equals operator)
@[8-9](Object.Equals)
@[10-11](Object.ReferenceEquals)

+++?code=src/Records/ConflictingTypes.fs&lang-FSharp&title=Records

@[2-3](Different types with the same fields)
@[5](Defaults to the most recent type defined)
@[7-8](Be specific to get a different type)

+++?code=src/Records/Person.cs&lang-CSharp&title="Equivelent Code in C#"

+++

## Records Summary

* Defined with `{ }`
* Use semicolons
* Label order does not matter
* Similar to classes with out methods
  * You can add some if you really want

---

## Resources

* [F# for fun and profit](https://fsharpforfunandprofit.com)
