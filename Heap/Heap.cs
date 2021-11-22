using System;

namespace CrackingTheCodingInterview.Heap
{
    public class MaxHeap
    {
        public MaxHeap()
        {
            arr = new int[10000];
        }
        public int[] arr;
        int lastIndex = 0;
        public int GetMax()
        {
            return arr[0];
        }
        public void Push(int num)
        {
            //add to end of array i.e last index
            if (lastIndex == 0)
            {
                arr[lastIndex] = num;
                lastIndex++;
                return;
            }
            arr[lastIndex] = num;
            //increment last index
            int childIndex = lastIndex;
            lastIndex++;

            //bubble up to correct position
            //Find parent = Math.Flor((n-1)/2) ??
            double parentIndex = Math.Floor((double)(childIndex - 1) / 2);
            //check if parent is less than num
            //if less swap
            //Repeat check until num is greater than the parent
            if (arr[childIndex] > arr[(int)parentIndex])
            {
                //swap them
                MaxHeapiFy((int)parentIndex, childIndex);
            }
        }

        private void MaxHeapiFy(int parentIndex, int childIndex)
        {
            while (childIndex != 0 && arr[childIndex] > arr[parentIndex])
            {
                //swap
                var temp = arr[childIndex];
                arr[childIndex] = arr[parentIndex];
                arr[parentIndex] = temp;

                childIndex = parentIndex;
                parentIndex = (int)Math.Floor((double)(childIndex - 1) / 2);
            }
        }
        public int RemoveMax()
        {
            //swap first and last
            //get rid of last
            //bubble down first
        }
    }

    public class MinHeap
    {
        public MinHeap()
        {
            arr = new int[10000];
        }
        public int[] arr;
        int lastIndex = 0;

        public void Push(int num)
        {
            //add to end of array i.e last index
            if (lastIndex == 0)
            {
                arr[lastIndex] = num;
                lastIndex++;
                return;
            }
            arr[lastIndex] = num;
            //increment last index
            int childIndex = lastIndex;
            lastIndex++;

            //bubble up to correct position
            //Find parent = Math.Flor((n-1)/2) ??
            double parentIndex = Math.Floor((double)(childIndex - 1) / 2);
            //check if parent is less than num
            //if less swap
            //Repeat check until num is greater than the parent
            if (arr[childIndex] < arr[(int)parentIndex])
            {
                //swap them
                MinHeapiFy((int)parentIndex, childIndex);
            }
        }
        private void MinHeapiFy(int parentIndex, int childIndex)
        {
            while (childIndex != 0 && arr[childIndex] < arr[parentIndex])
            {
                //swap
                var temp = arr[childIndex];
                arr[childIndex] = arr[parentIndex];
                arr[parentIndex] = temp;

                childIndex = parentIndex;
                parentIndex = (int)Math.Floor((double)(childIndex - 1) / 2);
            }
        }

        public int RemoveMin()
        {
            var min = arr[0];
            //swap first and last
            //get rid of last
            //bubble down first
        }
        public int GetMin()
        {
            return arr[0];
        }
    }
}