﻿using BreadthFirstTraversal.Classes;
using System;

namespace BreadthFirstTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Breadth First Queue from Front to rear");
            TreeNode treeNode1 = new TreeNode(1);
            Node node1 = new Node(treeNode1);
            treeNode1.LeftChild = new TreeNode(2);
            treeNode1.RightChild = new TreeNode(3);
            BreadthFirst(node1);
            //Console.WriteLine("out of breadthfirst");
            Console.ReadLine(); //to stop it from auto exit
        }

        /// <summary>
        /// performs a breadth first traversal of a tree (meaning from top down and left to right
        /// </summary>
        /// <param name="root">Node that holds a treenode as its "value"</param>
        public static void BreadthFirst(Node root)
        {
            QueueForTrees methodQueue = new QueueForTrees();

            methodQueue.Enqueue(root.Value);

            while (methodQueue.Peek() != null)
            {
                Console.WriteLine(methodQueue.Front.Value.Value);
                Node temp = methodQueue.Dequeue();
                if (temp.Value.LeftChild != null)
                {
                    methodQueue.Enqueue(temp.Value.LeftChild);
                }
                if (temp.Value.RightChild != null)
                {
                    methodQueue.Enqueue(temp.Value.RightChild);
                }
            }
        }
    }
}
