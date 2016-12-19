using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_new_features
{
    class Tuples
    {
        void theCs6Way()
        {
            Tuple<int, int> GetPositionOld()
            {
                return new Tuple<int, int>(1, 2);
            }

            void UsingTuplesOld()
            {
                var oldX = GetPositionOld().Item1;
            }
        }

        void theCs7Way()
        {
            (int X, int Y) GetPositionNew()
            {
                return (1, 2);
            }

            void UsingTuplesNew()
            {
                var newX = GetPositionNew().X;
            }
        }
    }
}
