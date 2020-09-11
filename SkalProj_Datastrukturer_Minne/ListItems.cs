using System;
using System.Collections;
using System.Collections.Generic;

namespace SkalProj_Datastrukturer_Minne
{
    public class ListItems //<T> : IEnumerable<T>
    {
        /*protected T[] aList;
        protected int noOf;
        protected int length;
        */
        
        private string insertItem;
        public string InsertItem
        {
            get
            {
                return this.insertItem;
            }
            set
            {
                this.insertItem = value;

            }
        }

        public ListItems(string insertItem)
        {   
            InsertItem = insertItem;
        }
      
        public override string ToString()
        {
            return $"{this.insertItem}";
        }

        public static implicit operator List<object>(ListItems v)
        {
            throw new NotImplementedException();
        }
        //public bool RemoveItem(T item) => theList.Remove(item);

        /*
        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
     */
    }
}