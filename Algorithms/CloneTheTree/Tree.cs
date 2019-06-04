using System;
using System.Collections;

class Node
{
    public int val;
    public Node left;
    public Node right;
    public Node(int val)
    {
        this.val = val;
    }

    public Node(int val,Node left,Node right)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

class Utilities
{
    public static Node BuildTree(int[] a,int li,int hi)
    {
        if (hi < li) return null;
        int mi = li + (hi - li) / 2;
        var node = new Node(a[mi]);
        node.left = BuildTree(a, li, mi - 1);
        node.right = BuildTree(a, mi + 1, hi);
        return node;
    }

    public static void DFS(Node root)
    {
        if (root == null) return;
        DFS(root.left);
        Console.WriteLine(root.val);
        DFS(root.right);
    }
}



class DepthFirstSearch
{
    private Stack _searchStack;
    private Node _root;
    public DepthFirstSearch(Node rootNode)
    {
        _root = rootNode;
        _searchStack = new Stack();
    }
    public bool Search(int data)
    {
        Node _current;
        _searchStack.Push(_root);
        while (_searchStack.Count != 0)
        {
            _current = (Node)_searchStack.Pop();
            if (_current.val == data)
            {
                return true;
            }
            else
            {
                _searchStack.Push(_current.right);
                _searchStack.Push(_current.left);
            }
        }
        return false;
    }
}
