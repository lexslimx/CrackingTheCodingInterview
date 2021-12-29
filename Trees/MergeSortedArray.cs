public class  MergeSortedArray{
    //using merge sort
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int index1 = 0;
        int index2 = 0;
        int i = 0;
        int[] ans = new int[m+n];
        
        while(index1 < m && index2 < n){
            if(nums1[index1] < nums2[index2]){
                ans[i] = nums1[index1];
                index1++;
            }
            else{
                ans[i] = nums2[index2];
                index2++;
            }
            i++;
        }
        
        while(index1 < m){            
            ans[i] = nums1[index1];
            index1++;
            i++;
        }
        
          while(index2 < n){            
            ans[i] = nums2[index2];
            index2++;
            i++;
        }
    }
    //sort of in place, merge into the first array
        public void Merge2(int[] nums1, int m, int[] nums2, int n) {
        int j = 0;
        for(var i = m; i < nums1.Length; i ++){
            nums1[i] = nums2[j];
            int index = i;
            while(index > 0 && nums1[index] < nums1[index-1]){
                //swap them
                var temp = nums1[index-1];
                nums1[index-1] = nums1[index];
                nums1[index] = temp;               
                index--;
            }
             j++;
        }
    }
}