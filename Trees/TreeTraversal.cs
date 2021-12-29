using CrackingTheCodingInterview;
using System;
public class TreeTraversal{

    void InOrder(TreeNode root){
        /*
        left
        root 
        right
        */
        if(root == null) return;
        InOrder(root.left);
        Console.Write(root.val);
        InOrder(root.right);
    }

    void PreOrder(TreeNode root){
        /*
        root
        left
        right
        */
        if(root == null) return;
        Console.Write(root.val);
        InOrder(root.left);
        InOrder(root.right);
    }

    void PostOrder(TreeNode root){
        /*
        left 
        right
        root
        */
        if(root == null) return;
        InOrder(root.left);
        InOrder(root.right);
        Console.Write(root.val);
    }
}