using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creation and assignment of different datatype variable
            int sharkTeeth = 240;
            string sharkName = "C Shark";
            bool isHappy = true;
            char gender = 'M';
            double lengthFt = 14.64;

            //Output details to the console
            Console.WriteLine("Shark Details\n-----------");
            Console.WriteLine("Name: " + sharkName + "\nHappy: " + isHappy
                + "\nGender: " + gender + "\nLength (ft): " + lengthFt + "\nNo. Teeth: " + sharkTeeth);
        }
    }
}
