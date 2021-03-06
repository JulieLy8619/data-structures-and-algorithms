﻿using System;

namespace _401d6LinkedList.Classes
{
    public class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }


        /// <summary>
        /// constructor if not given a node
        /// </summary>
        public LList()
        {
            Head = null;
        }

        /// <summary>
        /// inserts a node at the beginning of the linked list
        /// </summary>
        /// <param name="value">takes in the new value of the node</param>
        public void Insert(int value)
        {
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }

        /// <summary>
        /// checks if a value is in the node list
        /// </summary>
        /// <param name="value">value one is looking for</param>
        /// <returns>true or false if the value is in the list</returns>
        public bool Includes(int value)
        {
            Current = Head;
            if (Head == null)
            {
                Console.WriteLine("The linked list is Null");
                return false;
            }
            else
            {
                while (Current.Next != null)
                {
                    if (Current.Value == value)
                    {
                        return true;
                    }
                    Current = Current.Next;
                }
                if (Current.Value == value)
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// walks through node lists and prints value to screen
        /// </summary>
        public void Print()
        {
            // output to the console the linked list
            if (Head != null)
            {
                Current = Head;
                while (Current.Next != null)
                {
                    //Console.WriteLine("NEXT" + Current.Next);
                    Console.Write(Current.Value + " -> ");
                    Current = Current.Next;
                }
                Console.Write(Current.Value + " -> null"); //last node
            }
            else
            {
                Console.WriteLine("The link list is empty");
            }
        }

        /// <summary>
        /// This will append a new node to the end of the linked list
        /// </summary>
        /// <param name="value">Value of the new node</param>
        public void Append (int value)
        {
            Current = Head; //don't need to because we're just trying to find the end
            if (Head == null)
            {
                Console.WriteLine("The linked list is Null");
            }
            else
            {
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }
                Node newNode = new Node(value);
                Current.Next = newNode;
            }
        }

        /// <summary>
        /// This will insert a new node before a given node value
        /// </summary>
        /// <param name="value">the node you would like anew node inserted before</param>
        /// <param name="newValue">the value of the new node</param>
        public void InsertBefore(int value, int newValue)
        {
            bool inLList = false;
            Current = Head;
            if (Head == null) 
            {
                Console.WriteLine("The linked list is Null");
            }
            else if (Current.Value == value)
            {
                Insert(newValue);
                inLList = true;
                return; //to exit because I don't need to go through the rest of the list
            }
            else
            {

                while (Current.Next != null)
                {
                    if (Current.Next.Value == value)
                    {
                        Node newNode = new Node(newValue);
                        newNode.Next = Current.Next;
                        Current.Next = newNode;
                        inLList = true;
                        return;//to exit because I don't need to go through the rest of the list
                    }
                    else
                    {
                        Current = Current.Next;
                    }
                }
                if (inLList == false)//if value isn't in list
                {
                    Console.WriteLine();
                    Console.WriteLine($"{value} isn't in the list");
                }
            }
        }

        /// <summary>
        /// This will insert a new node after a given node value
        /// </summary>
        /// <param name="value">the node you would like a new node inserted after</param>
        /// <param name="newValue">the value of the new node</param>
        public void InsertAfter(int value, int newValue)
        {
            bool inLList = false;
            Current = Head;
            if (Head == null)
            {
                Console.WriteLine("The linked list is Null");
            }
            else
            {

                while (Current.Next != null)
                {
                    if (Current.Value == value)
                    {
                        Node newNode = new Node(newValue);
                        newNode.Next = Current.Next;
                        Current.Next = newNode;
                        inLList = true;
                        return;//to exit because I don't need to go through the rest of the list
                    }
                    else
                    {
                        Current = Current.Next;
                    }
                }
                if (Current.Value == value)//it was the last one in the list
                {
                    Node newNode = new Node(newValue);
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    inLList = true;
                    return;//to exit because I don't need to go through the rest of the list
                }
                else if (inLList == false)//if value isn't in list
                {
                    Console.WriteLine();
                    Console.WriteLine($"{value} isn't in the list");
                }
            }
        }
    }
}

