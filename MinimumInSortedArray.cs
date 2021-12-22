public class MinimumInSortedArray{
        public int FindMin(int[] nums) {
            for(var i = 1; i < nums.Length; i ++){
                if(nums[i] < nums[i-1]) return nums[i];
            }
            return -1;
        }

        public int FindMinWithSearch(int[] nums) {
            //4,5,6,7,0,1,2
            //we want to find a node i such that i < i-1 && i > i+1
            //for nodes to the left of i, i < i-1 && i < i+1
            //for nodes to the right of i, i < i - i-1 && i > i+1

            //if we land on a node such that i > left and i < end then seaerch right
            //if we land on a node such that i < left && i < right search space between

            return Search(nums, 0, nums.Length-1);
        }

        private int Search(int[] nums, int left, int right){
                
                while(left < right){
                    int mid = left + (right-left)/2;
                    //check if we have our answer
                    if(mid > 0 && nums[mid] < nums[mid - 1]) return nums[mid];
                    //search only the unsorted side

                    if(nums[left] < nums[mid] && nums[mid] > nums[right] ){
                        left = mid + 1;
                        continue;
                    }
                    else{
                        right = mid - 1;
                    }                 
                }
            return nums[left];
        }
}