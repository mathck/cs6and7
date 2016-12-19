using System;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp_new_features
{
    class OutVariables
    {
        void theCs6Way()
        {
            DateTime date;
            DateTime.TryParse("26-Nov-2016", out date);

            WriteLine(date);
        }

        void theCs7Way()
        {
            DateTime.TryParse("26-Nov-2016", out DateTime date);

            WriteLine(date);
        }
    }
}
