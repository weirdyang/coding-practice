using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int[] A, int K) {
        if (!A.Any() || K == 0)
        {
            return A;
            
        }
        for (int i = 0; i < K; i++)
        {
            A = Rotate(A);
        }
        return A;
        
    }
    public int[] RotateRight(int[] intArray)
    {
        int first = intArray[intArray.Length - 1];
        for (int i = intArray.Length - 1; i > 0; i--)
        {
            intArray[i] = intArray[i - 1];
            
        }
        intArray[0] = first;
        return intArray;   
    }

            public int[] Answer(int[] A, int K)
        {
            if (!A.Any() || K == 0)
            {
                return A;

            }
            int[] answer = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                answer[(K + i) % A.Length] = A[i];
            }
            return answer;
        }
}