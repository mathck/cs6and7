using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp_new_features.CS7
{
    class ExpressionBody
    {
        int ProductId { get; } = 1;
        string ProductName { get; }

        decimal Price => 3000;

        ExpressionBody() => ProductName = "Fancy quick constructor";

        ~ExpressionBody() => WriteLine("Fancy quick deconstructor"); // also new: Deconstruction!!

        decimal PriceExtended
        {
            get => productPriceList[ProductId];
            set => productPriceList[ProductId] = value;
        }

        Dictionary<int, decimal> productPriceList = new Dictionary<int, decimal>();

        string Summary => $@"Name: {ProductName}
                             Price: {Price} €";
    }
}
