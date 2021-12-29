using System.Collections.Generic;
using CrackingTheCodingInterview;

public class BinaryTreePaths
{
    public IList<string> SolveBinaryTreePaths(TreeNode root)
    {
        IList<string> list = new List<string>();
        Build(root, "", list);

        return list;
    }
    void Build(TreeNode root, string current,IList<string> list){
        if(root == null){
            return;
        }
        
        if(root.left == null && root.right == null){
            current += root.val;
        }
        else{
             current+=root.val + "->";        
        }
        
        if(root.left !=null) Build(root.left, current, list);
    
        if(root.right !=null) Build(root.right, current, list);
        
        if(root.left == null && root.right == null) list.Add(current);
    }
}