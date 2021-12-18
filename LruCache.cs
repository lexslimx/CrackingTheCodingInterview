using System.Collections.Generic;

public class LRUCache {

 
    int capacity;
    int count;
    Node head;
    Node tail;
    Dictionary<int, Node> map;
    public LRUCache(int capacity)
    {
        this.capacity = capacity;
        count = 0;
        head = new Node();
        tail = new Node();

        head.next = tail;
        tail.prev = head;
        map = new Dictionary<int, Node>();
    }

    public int Get(int key)
    {
        int result = -1;
        Node node = null;
        if(map.ContainsKey(key)) node = map[key];
        if(node != null){
            result = node.value;
            Remove(node);
            Add(node);
        }
        return result;
    }

    public void Put(int key, int value)
    {
        Node node = null;
        if(map.ContainsKey(key)) node = map[key];
        if(node != null){
            node.value = value;
            Remove(node);
            Add(node);
        }
        else{
            //check capacity
            if(map.Count == capacity){
                map.Remove(tail.prev.key);
                Remove(tail.prev);
            }
            Node newNode = new Node(key,value);
            map.Add(key, newNode);
            Add(newNode);
        }
        
    }

    private void Add(Node node){ //we are adding to the front of the list
        Node headnext = head.next;
        head.next = node;
        node.prev = head;
        node.next = headnext;
        headnext.prev = node;
    }

    private void Remove(Node node){
        Node next = node.next;
        Node prev    = node.prev;

        next.prev = prev;
        prev.next = next;
    }
}
    public class Node
{
    public Node(){

    }
    public Node(int key, int value)
    {
        this.key = key;
        this.value = value;
    }
    public Node prev;
    public Node next;
    public int key;
    public int value;
}
/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */