using System;
using System.Collections.Generic;
using Tree;

class Program
{
    static void Main(string[] args)
    {
        BTree tree = new BTree(50); // Create a binary tree with root value 50

        // Insert some values
        tree.Insert(30);
        tree.Insert(40);
        tree.Insert(20);
        tree.Insert(70);
        

        // Draw the tree
        Console.WriteLine("Binary Tree:");
        tree.DrawTree();
     //  tree.del(50);
        tree.del(20);
        Console.WriteLine("..................");
        tree.DrawTree();

        tree.del(30);
        Console.WriteLine("..................");
        tree.DrawTree();
    }
}