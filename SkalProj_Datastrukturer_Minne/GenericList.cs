using System;
using System.Collections.Generic;
using System.Text;

namespace SkalProj_Datastrukturer_Minne
{
    class GenericList<T> 
    {
        public Node<T> First { get; set; }
        public int CountNode { get; set; }

        public void AddFirstNode(T data)
        {
            Node<T> newNode = new Node<T>();

            newNode.Value = data;
            if (First != null)
                newNode.Next = First;
            First = newNode;
            CountNode++;
        }

        public void RemoveFirst(T data)
        {
            Node<T> newNode = new Node<T>();

            newNode.Value = data;
            if (First != null)
                newNode.Next = First;
            First = newNode;
            CountNode--;

        }
        public T this[int index]
        {

            get
            {
                if(index >= CountNode)
                {
                    throw new IndexOutOfRangeException();
                }
                Node<T> nodeIndex = First;
                int i = 0;
                while(i<index)
                {
                    nodeIndex = nodeIndex.Next;
                    i++;
                }
                return nodeIndex.Value;
            }
        }
    }
}
