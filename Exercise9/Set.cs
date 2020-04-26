using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lydia's code - find the errors!
//Corrected by Joseph Gallotta

namespace CST117_IC08_console
{
    class Set
    {
        private List<int> elements;

        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            // fix: replaced with List<T>.Contains 

            return elements.Contains(val);

            //for (int i = 0; i < elements.Count; i++)
            //{
            //    if (val == elements[i])
            //        return true;
            //    else
            //        return false;
            //}
            //return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {
            // fix: return new set object

            Set union = new Set();

            // fix: add current elements to new object

            for (int i = 0; i < this.elements.Count; i++)
            {
                union.addElement(this.elements[i]);
            }

            for (int i = 0; i < rhs.elements.Count; i++)
            {
                //fix: union.addElement
                //this.addElement(rhs.elements[i]);
                union.addElement(rhs.elements[i]);
            }
            return union;
        }
    }
}
