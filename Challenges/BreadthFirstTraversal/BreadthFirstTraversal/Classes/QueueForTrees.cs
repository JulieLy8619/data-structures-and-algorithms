﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstTraversal.Classes
{
    public class QueueForTrees
    {
        //properties
        public Node Front { get; set; }
        public Node Rear { get; set; }

        //instantiate
        //queue with nothing given
        public QueueForTrees()
        {
            Front = null;
            Rear = null;
        }

        //queue with a given node
        public QueueForTrees(Node node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// adding a node to the queue
        /// </summary>
        /// <param name="value">value of new node</param>
        public void Enqueue(TreeNode value)
        {
            if (Front == null) //if queue was empty and I add one
            {
                Node newNode = new Node(value);
                Rear = newNode;
                Front = newNode;
            }
            else
            {
                Node newNode = new Node(value);
                Rear.Next = newNode;
                Rear = newNode;
            }
        }

        /// <summary>
        /// removes a node from the queue
        /// </summary>
        /// <returns>the first node in the queue</returns>
        public Node Dequeue()
        {
            //should add check if trying to dequeue from an empty queue
            if (Front == null)
            {
                return null;
            }
            else
            {
                Node temp = Front;
                Front = Front.Next;
                temp.Next = null;
                return temp;
            }
        }

        /// <summary>
        /// looks to see whos in front of the queue
        /// </summary>
        /// <returns>information on the first node in the queue</returns>
        public Node Peek()
        {
            return Front;
        }
    }
}
