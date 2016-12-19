using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CSharp_new_features
{
    class ExceptionFilters
    {
        public void ExceptionWithFilters()
        {
            try
            {

            }
            catch (System.IO.FileNotFoundException exception) when (exception.FileName == "abc.txt")
            {
                // handle only for particular file 
                // In previous version of C#, you have to check it inside
                // and then re throw which would result in losing exception data
            }
        }
    }
}
