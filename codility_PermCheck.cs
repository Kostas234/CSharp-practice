// A non-empty array A consisting of N integers is given.

// A permutation is a sequence containing each element from 1 to N once, and only once.

// For example, array A such that:
//     A[0] = 4
//     A[1] = 1
//     A[2] = 3
//     A[3] = 2

// is a permutation, but array A such that:
//     A[0] = 4
//     A[1] = 1
//     A[2] = 3

// is not a permutation, because value 2 is missing.

// The goal is to check whether array A is a permutation.
using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        int result = 1;
        for(int i=1; i<=A.Length; i++){
            if(!A.Contains(i)){
                result = 0;
                break;
            }
        }
        return result;
    }
}