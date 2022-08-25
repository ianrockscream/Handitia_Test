using System;
using System.Collections.Generic;
using System.Text;

namespace Handitia_Test.Logic
{
    public class MultipleBy
    {
        public bool MultipleBy3(int value)
        {
            if (value % 3 == 0)
                return true;
            else
                return false;
        }
        public bool MultipleBy5(int value)
        {
            if (value % 5 == 0)
                return true;
            else
                return false;
        }
    }
}
