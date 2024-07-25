using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150_DogClass.BuisnessLayer
{
    internal class Utility
    {
        ///<summary>
        ///Utility that returns false if the parameter string is null, empty or just contains white space
        /// </summary>
        /// <param name="TextToTest"></param>
        /// <returns></returns>
        public bool NotNull(string TextToTest)
        {
            //Check if the string is empty, null or contains only whitespace
            if (string.IsNullOrWhiteSpace(TextToTest))
            {
                return false;
            }
            return true;
        }

        ///<summary>
        ///Test to determine if a valid double was entered.
        ///If true the string is parsed to souble and true is returned.
        ///If false, -1 is returned and false for bool.
        ///Tjos return type is called a tuple.
        /// </summary>
        /// <param name="ValueToTest"></param>
        /// <retunrs></retunrs>
        public (double doubleValue, bool isConverted) validDouble(string valueToTest)
        {

            //Declare and initialize 
            double convertValue = 0.00D;
            //Test to see if the string can be parsed to a double
            if (Double.TryParse(valueToTest, out convertValue))
            {
                return (convertValue, true);
            }
            //If parse fails return false and -1
            return (-1D, false);
        }
        ///<summary>
        ///Convert Yes to bool true and No to bool false
        /// </summary>
        /// <param name="YesOrNo"></param>
        /// <returns></returns>
        public bool ConvertToBool(string YesOrNo)
        {
            if(YesOrNo =="Yes")
            {
                return true;
            }
            return false;
        }
    }
}
