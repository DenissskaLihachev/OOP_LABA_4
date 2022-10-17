using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class ListQueue
    {
        internal class Element
        {
            public Person data = null;
            public Element next = null;
        }

        private Element head = null;

        public void add(Person chel)
        {
            Element e = new Element();
            e.data = chel;
            if (head == null)
                head = e;
            else
            {
                Element temp = new Element();
                temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = e;
            }
        }

        public Person get()
        {
            Element temp = new Element();
            temp = head;
            if(head != null)
            {
                head = head.next;
                return temp.data;
            }
            else
            {
                return null;
            }
        }
    }
}
