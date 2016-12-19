using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp_new_features
{
    public class Literals
    {
        void representations()
        {
            // Represent 50 in decimal, hexadecimal & binary  
            int a = 50;             // decimal representation of 50  
            int b = 0X32;           // hexadecimal representation of 50  
            int c = 0B110010;       // binary representation of 50  

            // Represent 100 in decimal, hexadecimal & binary  
            int d = 50 * 2;         // decimal represenation of 100   
            int e = 0x32 * 2;       // hexadecimal represenation of 100  
            int f = 0b110010 * 2;   // binary represenation of 100  
        }

        public static void Main()
        {
            int binaryData = 0B0010_0111_0001_0000; // binary value of 10000   
            int hexaDecimalData = 0X2B_67;          // HexaDecimal Value of 11,111   
            int decimalData = 104_567_789;
            int myCustomData = 1___________2__________3___4____5_____6;
            double realdata = 1_000.111_1e1_00;
            WriteLine($" binaryData :{binaryData} \n hexaDecimalData: {hexaDecimalData} \n decimalData: {decimalData} \n myCustomData: {myCustomData} \n realdata: {realdata}");
            ReadLine();
        }
    }
}
