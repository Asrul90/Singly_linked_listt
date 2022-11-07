﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Singly_linked_list
{
    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;
    }
    class list
    {
        Node START;
        
        public list()
        {
            START = null;
        }
        
        public void addNote()// add note list
        {
            int rollNo;
            string nm;
            Console.Write("\nEnter the roll number of thr student: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the roll name of the student: ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;
            if ((START != null) && (rollNo <= START.rollNumber)) ;
            {
                if ((START != null) && (rollNo == START.rollNumber)) ;
                {
                    Console.WriteLine();
                    return;
                }
                newnode.next = START;
                START = newnode;
                return;
            }
            Node previous, current;
            previous = START;
            current = START;

            while ((current != null) && (rollNo >= current.rollNumber))
            {
                if (rollNo == current.rollNumber)
                {
                    Console.WriteLine();
                    return;
                }
                previous.next = current;
                previous.next = newnode;
            }
            newnode.next = current;
            previous.next = newnode;
        }
        public bool delnode(int rollNo)
        {
            Node previous, current;
            previous = current = null;
            if (search(rollNo, ref previous, ref current) == false)
                return false;
            if (current == START)
                START = START.next;
            return true;
        }
        public bool search(int rollNo, ref Node previous, ref Node current)
        {
            previous = START;
            current = START;
            while ((current != null) && (rollNo != current.rollNumber))
            {
                previous = current;
                current = current.next;
            }
            if (current == null)
                return false;
            else
                return true;
        }
        public void traverse()
        {
            if (listEmpty())
                Console.WriteLine();
            else
            {
                Console.WriteLine();
                Node currentNode;
                for (currentNode = START; currentNode != null;
                    currentNode = currentNode.next)
                    Console.Write(currentNode.rollNumber + "" + currentNode.name + "\n");
                Console.WriteLine();

            }
        }
        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }
        class Program
        {
        static void Main(string[] args)
        {
                list obj = new list();
                while (true)
                {
                    try
                    {
                        Console.WriteLine("\nMenu");
                        Console.WriteLine(" 1. add record to the list");
                        Console.WriteLine(" 2. delete a record from the list");
                        Console.WriteLine(" 3. view all the records in the list");
                        Console.WriteLine(" 4. search for a record in the list");
                        Console.WriteLine(" 5. EXIT");
                        Console.Write("\nEnter your choice (1-5) : ");
                        char ch = Convert.ToChar(Console.ReadLine());
                        switch (ch)
                        {
                            case '1':
                                {
                                    obj.addNote();
                                }
                                break;
                            case '2':
                                {
                                    if (obj.listEmpty())
                                    {
                                        Console.WriteLine("\nlist is empty");
                                        break;
                                        {

                                        }
                                    }
                                }
                        }
                    }
                }
        }
    }
}

