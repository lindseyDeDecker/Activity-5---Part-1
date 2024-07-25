/*Lindsey DeDecker
 * CST-150
 * July 25, 2024string nam
 * Activity 5
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150_DogClass.BuisnessLayer
{
    internal class Dog
    {
        //Define Properties
       public string Name { get; set; }

        public Dog(string name)
        {
            Name = name;
        }

        public double NeckRad { get; set; }

        public Dog(double neckRad)
        {
            NeckRad = neckRad;
        }

        public string Color { get; set; }

       public double Weight { get; set; }


       public bool Sit { get; set; }

        public Dog(bool sit)
        {
            Sit = sit;
        }

        ///<summary>
        ///Default Constructor
        /// </summary>

        public Dog()
        {
            //Initialize the Properties
            Name = "";
            NeckRad = 0.00D;
            Color = "";
            Weight = 0.00D;
            Sit = false;
        }

        ///<summary>
        ///Parameterized Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="neckRad"></param>
        /// <param name="color"></param>
        /// <param name="weight"></param>
        /// <param name="sit"></param>
        public Dog(string name, double neckRad, string color, double weight, bool sit)
        {
            //Main purpose of constructor is to initialize the properties
            Name = name;    
            NeckRad = neckRad;
            Color = color;
            Weight = weight;
            Sit = sit;  
        }

        ///<summary>
        ///Method that takes the property NeckRad and returns the circumference in centemeters
        /// </summary>
        /// <retunrs></retunrs>
        public double CalCircumference()
        {
            //Declare and Initalize
            const double cmConversion = 2.54D;
            double circumference = 0.00D;

            //since NeckRad is at the class level we can use this property inside this method.
            //Conversion from radius to circumference (28Pi8r)
            circumference = 2 * Math.PI * NeckRad;
            //Then convert to centemeters from inches
            return (circumference * cmConversion);
        }

        ///<summary>
        ///Convert weight pounds to kilograms
        /// </summary>
        /// <returns></returns>
        public double CalWeight()
        {
            //Declare and initialize
            const double kgConversion = 0.4535892D;
            //Convert the property weight from pounds to kilograms
            return (Weight * kgConversion);
        }
    }
}
