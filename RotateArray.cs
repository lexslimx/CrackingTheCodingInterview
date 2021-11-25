/**
You are given an n x n 2D matrix representing an image,
rotate the image by 90 degrees (clockwise).
You have to rotate the image in-place, which means 
you have to modify the input 2D matrix directly. 
DO NOT allocate another 2D matrix and do the rotation.
**/

public class RotateArray
{
    public void Rotate(int[][] matrix)
    {
        //do it in place
        //Convert rows to columns
        for (var c = 0; c < matrix.Length; c++)
        {
            for (var r = c; r < matrix[c].Length; r++)
            {
                var temp = matrix[r][c];
                matrix[r][c] = matrix[c][r];
                matrix[c][r] = temp;
            }
        }

        //Reverse each row
        for (var r = 0; r < matrix.Length; r++)
        {

            int start = 0;
            int end = matrix[r].Length - 1;
            while (start < end)
            {
                var temp = matrix[r][start];
                matrix[r][start] = matrix[r][end];
                matrix[r][end] = temp;
                start++;
                end--;
            }
        }

    }
}