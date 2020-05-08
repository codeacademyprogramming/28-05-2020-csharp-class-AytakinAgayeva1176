using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice("qwerty", "aytin", "qwer")
            {
                article = "laptop",
                quantity = "1"
            };

            inv.CostCalculation(true);
        }

    }
}
