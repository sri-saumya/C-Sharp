using System;
using System.Collections.Generic;
using System.Text;

namespace Action_delegate
{
    class Cal<T>
    {
        public T echo { get; set; }
        public void Display(Action displayType)
        {
            displayType();
        }

    }
}
