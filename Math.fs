module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz (n : int64)=
  let rec colmini (n : int64) count =
    //printfn "%d" n => test 5에서 overflow 확인됨 
    if n = 1L then count
    elif n % 2L = 0L then colmini (n / 2L) (count + 1)
    else colmini ( n * 3L+ 1L) (count + 1)
  colmini n 0 