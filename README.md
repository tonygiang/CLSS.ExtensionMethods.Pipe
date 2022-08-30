# CLSS.ExtensionMethods.Pipe

### Problem

It's common to feed the result of a method as an argument into another method, but when doing so, the reading flow of your code is reversed into right-to-left:

```csharp
var result = Method4(Method3(Method2(Method1(100))));
```

It also makes logical errors from one missing or one extra parenthesis easy to miss. Typical C# programmers are not used to parse parenthesis pairs as Lisp programmers are.

You can get around the code comprehension issue by writing more lines of code to assign each method's result to a variable. This creates some mental hurdles since you have to think of logical names to the variables.

```csharp
var result1 = Method1(100);
var result2 = Method2(result1);
var result3 = Method3(result2);
var result4 = Method4(result3);
```

F# has a native operator for this use case - the forward pipe operator:

```fsharp
let result = 100 |> Method1 |> Method2 |> Method3 |> Method4;
```

Unfortunately, no such operator natively exists within the C# language.

### Solution

`Pipe` is an extension method that replicates the syntax of F#'s forward pipe operator. The above first example can be rewritten as follows:

```csharp
using CLSS;

var result = Method1(100).Pipe(Method2).Pipe(Method3).Pipe(Method4);
```

In one line, the order of execution still goes from left to right with the `Pipe` syntax.

`Pipe` also accepts lambda expressions:

```csharp
using CLSS;

FetchSomething()?.Pipe(result => { /* Only execute if result is not null */ };
```

If passed in a `void` method, `Pipe` returns the caller object.

This package also provides the `PipeKeep` extension method if you want to return the caller object even when passing in a method with non-`void` return type.

##### This package is a part of the [C# Language Syntactic Sugar suite](https://github.com/tonygiang/CLSS).