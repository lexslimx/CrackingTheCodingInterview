using CrackingTheCodingInterview.Heap;
//median middle value in an ordered integer list
public class MedianFromDataStream{
    MaxHeap maxHeap;
    MinHeap minHeap;
    public MedianFromDataStream()
    {
        maxHeap = new MaxHeap();
        minHeap = new MinHeap();
    }

    public void AddNum(int num) {
        minHeap.Push(num);
        maxHeap.Push(minHeap.RemoveMin());
        
    }
    
    public double FindMedian() {
        
        return 0;
    }
}