using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_project
{
    public class PurchaseCollection
    {
        private ArrayList _items = new ArrayList();

        public PurchaseIterator CreateIterator()
        {
            return new PurchaseIterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}
