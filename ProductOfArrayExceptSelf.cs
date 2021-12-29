public class ProductOfArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] result = new int[nums.Length];
        int[] left = new int[nums.Length];
        int[] right = new int[nums.Length];

        //get the product of elements to the left of each element
        //set the first element
        left[0] = 1;
        for(var i = 1; i < nums.Length; i++){
            left[i] = left[i-1] * nums[i - 1];
        }

        //get the product of elements to the right of each element
        int n = nums.Length - 1;
        right[n] = 1;
        for(var i = n - 1; i >= 0; i--){
            right[i] = right[i + 1] * nums[i + 1];
        }

        //multiply left and right
        for(var i = 0; i < nums.Length; i++){
            result[i] = left[i] * right[i];
        }

        return result;
    }
}

/*
get product of all nums
for each num divide the product by it and set it
*/