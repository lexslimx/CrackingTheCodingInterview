using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    internal class SetMatrixZeros
    {
        /*
         * 
         * 
         Given an m x n integer matrix matrix, if an element is 0, set its entire row and column to 0's, and return the matrix.

        You must do it in place.            
         * 
         */
        public void SetZeroes(int[][] matrix)
        {
            List<int> cols = new List<int>();
            List<int> rows = new List<int>();

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        cols.Add(j);
                        rows.Add(i);
                    }
                }
            }

            //set all rows to zero
            foreach (var col in cols)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    matrix[i][col] = 0;
                }
            }

            //set all cols to zero

            foreach (var row in rows)
            {

                for (var i = 0; i < matrix[row].Length; i++)
                {
                    matrix[row][i] = 0;
                }
            }
        }
    }
}
