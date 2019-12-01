using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_project
{
    public interface IPurchaseIterator
    {
        Purchase First();
        Purchase Next();
        bool IsDone { get; }
        Purchase Current { get; }
    }
}
