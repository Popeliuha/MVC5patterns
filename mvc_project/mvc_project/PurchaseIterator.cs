using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_project
{
    public class PurchaseIterator : IPurchaseIterator
    {
        private PurchaseCollection _purchases;
        private int _current = 0;
        private int _step = 1;

        public PurchaseIterator(PurchaseCollection purchases)
        {
            this._purchases = purchases;
        }

        public Purchase First()
        {
            _current = 0;
            return _purchases[_current] as Purchase;
        }

        public Purchase Next()
        {
            _current += _step;
            if (!IsDone)
                return _purchases[_current] as Purchase;
            else
                return null;
        }

        public Purchase Current
        {
            get { return _purchases[_current] as Purchase; }
        }

        public bool IsDone
        {
            get { return _current >= _purchases.Count; }
        }
    }
}
