using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmaSpiteri_SWD6._1B
{
    class SinglyLinkedList<T>
    {
        public int Size { get; private set; }

        public Node Head { get; private set; }
        

        public int GetSize()
        {
            return Size;
        }

        public bool isEmpty()
        {
            if (Size == 0 && Head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void InsertFirst(T Element)
        {
            Node newNode = new Node();
            newNode.elemt = Element;
           
            newNode.next = Head;
            Head = newNode;
            Size++;
        }


        public void InsertLast(T Element)
        {
            Node newNode = new Node();
            newNode.elemt = Element;

            if (Size == 0)
            {
                Head = newNode;
            }
            else
            {
                Node lastNode = Head;

                while (lastNode.next != null)
                {
                    lastNode = lastNode.next;
                }
                lastNode.next = newNode;
                newNode.next = null;
            }
            Size++;
        }

        public void InsertBefore(T Element, Node Cursor)
        {
            //Check if the list is empty
            if (Size == 0)
            {
                throw new InvalidOperationException("Empty List");
            }
            else
            {
                //Create a new node
                Node newNode = new Node();
                newNode.elemt = Element;

                //Check if cursor is head
                if (Cursor == Head)
                {
                    //Link the new node to the head
                    newNode.next = Head;
                    Head.Previous = newNode;
                    //Make the new node the head
                    Head = newNode;
                }
                else
                {
                    //Link the new node to recognize the cursor as the node after it
                    newNode.next = Cursor;
                    //Link the new node to recognize the node before the cursor as the node before it
                    newNode.next = Cursor.Previous;

                    //Update the node before the cursor to recognize the new node as the node after it
                    Cursor.Previous.next = newNode;
                    //Update the cursor to recognize the the new node as the node before it
                    Cursor.Previous = newNode;
                }

                //Increase size
                Size++;
            }
        }

    }
}
