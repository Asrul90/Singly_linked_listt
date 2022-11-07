using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                if ((START != null) && (rollNo <= START.rollNumber)) ;
                {
                    Console.WriteLine();
                    return;
                }
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

