module Fable.Import.FastMemoize

open Fable.Core

[<Import("default","fast-memoize"); Emit("$0")>]
let memoize<'a1, 'b> :('a1 -> 'b) -> ('a1 -> 'b) = jsNative
