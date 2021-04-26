using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmaSpiteri_SWD6._1B
{
    class DoublyLinkedList<T>
    {
        public int size;

        public DoublyNode<T> Head;

        public bool isEmpty()
        {
            if (Head == null && size == 0)
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
            DoublyNode<T> newNode = new DoublyNode<T>();
            newNode.elem = Element;

            if (isEmpty() == true)
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
            }
            size++;
        }

        public void InsertLast(T Element)
        {
            DoublyNode<T> newNode = new DoublyNode<T>();
            newNode.elem = Element;

            if (isEmpty() == true)
            {
                Head = newNode;
            }
            else
            {
                DoublyNode<T> lastNode = Head;

                while (lastNode.Next != null)
                {
                    lastNode = lastNode.Next;
                }

                lastNode.Next = newNode;

                newNode.Previous = lastNode;
            }
        
            size++;
        }

        public void InsertBefore(T Element, DoublyNode<T> Cursor)
        {
         
            if (size == 0)
            {
                throw new InvalidOperationException("Empty List");
            }
            else
            {
                DoublyNode<T> newNode = new DoublyNode<T>();
                newNode.elem = Element;

                if (Cursor == Head)
                {
                    newNode.Next = Head;
                    Head.Previous = newNode;
                    Head = newNode;
                }
                else
                {
                    newNode.Next = Cursor;
                    newNode.Previous = Cursor.Previous;

                    Cursor.Previous.Next = newNode;
                    Cursor.Previous = newNode;
                }
                size++;
            }
        }

    }
}
