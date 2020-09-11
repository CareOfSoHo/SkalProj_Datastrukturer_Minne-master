using System.Collections.Generic;

namespace SkalProj_Datastrukturer_Minne
{
    public class ListHandler
    {
        //deklarerar listan ListItems
       public List<ListItems> listitemsList;
       
        public ListHandler()
        {
            //nya listan
            listitemsList = new List<ListItems>();
        }

        public ListItems AddListItem(string addListItem)
        {
            ListItems itrm = new ListItems(addListItem);
            listitemsList.Add(itrm);
            return itrm;
        }
    }
}