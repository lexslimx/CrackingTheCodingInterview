using System;
using CrackingTheCodingInterview.Heap;

namespace CrackingTheCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            SetMatrixZeros setMatrixZeros = new SetMatrixZeros();
            setMatrixZeros.SetZeroes(new int[][]
            {
                new int[]{0,1}
            });            
        }
    }
}
