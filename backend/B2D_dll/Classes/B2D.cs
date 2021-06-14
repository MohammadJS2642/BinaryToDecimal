using System.Reflection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using B2D_dll.Interfaces;

namespace B2D_dll.Classes
{
    public class B2D : IB2D
    {
        // list of banary numbers
        private IList<int> binaryNumbers;

        ///<summary>
        /// This method was implemented from IB2D Interface.
        /// get a list of binary (0 or 1) numbers.
        ///</summary>
        ///<returns>
        /// list of integer binary numbers
        ///</returns>
        public IList<int> GetBinary(string oneOrZeroList)
        {
            if (oneOrZeroList.Length <= 8)
            {
                bool flag = true;

                while (flag)
                {
                    foreach (var i in oneOrZeroList)
                    {
                        // convert i from char to string 
                        string stringBinary = i.ToString();
                        // convert stringBinary from string to int
                        int intBinary = int.Parse(stringBinary);
                        if (intBinary == 0 | intBinary == 1)
                        {
                            binaryNumbers.Append(intBinary);
                            return binaryNumbers;
                        }
                        flag = false;
                        return null;
                    }
                }
            }
            return null;
        }

        ///<summary>
        /// to decimal convertor
        ///</summary>
        /// <returns>
        ///return converted number from binart to decimal
        /// </returns>
        public int ConvertToDecimal(IList<int> binaryList)
        {
            int sum = 0;
            foreach (var num in binaryNumbers)
            {
                // Position of number 1
                int position = 0;
                if (num == 1)
                {
                    // to the power of position where binary number is 1
                    int powTwo = Convert.ToInt32(Math.Pow(position, 2));
                    sum += powTwo;
                    position++;
                }
                else
                {
                    // to the power of position where binary number is 0
                    position++;
                }
            }

            return sum;
        }


        ///<summary>
        /// for simplyfing use this class
        ///</summary>
        ///<returns>
        /// string: convertToDecimalMethod
        ///</returns>
        public string ReturnResult(string setBinaryNumber)
        {
            IList<int> getBinaryMethod = GetBinary(setBinaryNumber);
            int convertToDecimalMethod = ConvertToDecimal(getBinaryMethod);
            return convertToDecimalMethod.ToString();
        }
    }
}