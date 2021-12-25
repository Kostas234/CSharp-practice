// You are given N counters, initially set to 0, and you have two possible operations on them:

//         increase(X) − counter X is increased by 1,
//         max counter − all counters are set to the maximum value of any counter.

// A non-empty array A of M integers is given. This array represents consecutive operations:

//         if A[K] = X, such that 1 ≤ X ≤ N, then operation K is increase(X),
//         if A[K] = N + 1 then operation K is max counter.

// For example, given integer N = 5 and array A such that:
//     A[0] = 3
//     A[1] = 4
//     A[2] = 4
//     A[3] = 6
//     A[4] = 1
//     A[5] = 4
//     A[6] = 4

// the values of the counters after each consecutive operation will be:
//     (0, 0, 1, 0, 0)
//     (0, 0, 1, 1, 0)
//     (0, 0, 1, 2, 0)
//     (2, 2, 2, 2, 2)
//     (3, 2, 2, 2, 2)
//     (3, 2, 2, 3, 2)
//     (3, 2, 2, 4, 2)

// The goal is to calculate the value of every counter after all operations.
using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int N, int[] A) {
        int[] counters = new int[N];
        for(int i=0; i<A.Length; i++){
            if(A[i]<=N){
                counters[A[i]-1]+=1;
            }
            else
                counters = Enumerable.Repeat(counters.Max(), N).ToArray();
        }
        return counters;
    }
}