using System;
using System.Collections.Generic;
using System.Text;

namespace SkalProj_Datastrukturer_Minne
{
    class Node<T>
    {
        public Node<T> Next;
        public T Value;

        public override string ToString()
        {
            if (Value != null)
                return Value.ToString();
            else
                return "Null or empty";
        }
    }
}
