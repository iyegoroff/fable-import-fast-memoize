[<RequireQualifiedAccess>]
module Fable.Import.FastMemoize

open Fable.Core

[<Import("default","fast-memoize"); Emit("$0")>]
let memoize<'A1, 'T> :('A1 -> 'T) -> ('A1 -> 'T) = jsNative

[<Import("default","fast-memoize"); Emit("$0")>]
let memoize2<'A1, 'A2, 'T> :('A1 * 'A2 -> 'T) -> ('A1 -> 'A2 -> 'T) = jsNative

[<Import("default","fast-memoize"); Emit("$0")>]
let memoize3<'A1, 'A2, 'A3, 'T> :('A1 * 'A2 * 'A3 -> 'T) -> ('A1 -> 'A2 -> 'A3 -> 'T) = jsNative

[<Import("default","fast-memoize"); Emit("$0")>]
let memoize4<'A1, 'A2, 'A3, 'A4, 'T> :('A1 * 'A2 * 'A3 * 'A4 -> 'T) -> ('A1 -> 'A2 -> 'A3 -> 'A4 -> 'T) = jsNative
