using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4, 5, 6, 7 };
        var tree = Utilities.BuildTree(a, 0, a.Length - 1);
        var newTree = Clone(tree);
        Node newRoot = new Node(tree.val);
        CloneDFS(tree,newRoot);
        Utilities.DFS(newTree);
    }

    static Node Clone(Node root)
    {
        var queue = new Queue<Node>();
        var newRoot = new Node(root.val);
        queue.Enqueue(root);
        queue.Enqueue(newRoot);
        while(queue.Count > 0)
        {
            var original = queue.Dequeue();
            var cloned = queue.Dequeue();
            if(original.left != null)
            {
                cloned.left = new Node(original.left.val);
                queue.Enqueue(original.left);
                queue.Enqueue(cloned.left);
            }

            if(original.right != null)
            {
                cloned.right = new Node(original.right.val);
                queue.Enqueue(original.right);
                queue.Enqueue(cloned.right);
            }
        }
        return newRoot;
    }

    static void CloneDFS(Node root,Node newRoot)
    {
        if(root != null)
        {
        }
        if (root.left != null)
        {
            newRoot.left = new Node(root.left.val);
            CloneDFS(root.left, newRoot);
        }
        if (root.right != null)
        {
            newRoot.right = new Node(root.right.val);
            CloneDFS(root.right, newRoot);
        }
    }
}

