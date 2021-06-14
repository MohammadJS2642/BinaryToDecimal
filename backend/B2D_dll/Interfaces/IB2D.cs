using System.Collections;
using System;
using System.Collections.Generic;

namespace B2D_dll.Interfaces
{
    public interface IB2D
    {
        // get list of binary (0 or 1) in a list
        public IList<int> GetBinary(string oneOrZeroList);

        // convert bianry to deciaml  
        public int ConvertToDecimal(IList<int> binaryList);
    }
}