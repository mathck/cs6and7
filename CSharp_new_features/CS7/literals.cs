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
    }
}
