using System.Collections;
using System;
using System.Collections.Generic;

namespace Binary2DecimalAPI.Interfaces
{
    public interface IB2D
    {
        // get list of binary (0 or 1) in a list
        public IList<int> getBinary(string oneOrZeroList);

        // convert bianry to deciaml  
        public int convertToDecimal(List<int> binaryList);
    }
}