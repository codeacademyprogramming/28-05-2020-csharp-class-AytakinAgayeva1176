using System;

namespace csharp_classes
{
    class Invoice
    {
        private readonly string _account;
        private readonly string _customer;
        private readonly string _provider;

        public string article { get; set; }
        public string quantity { get; set; }

        
        public Invoice(string account, string customer ,string provider)
        {
            _account = account;
            _customer = customer;
            _provider = provider;
        }

        
        private void PriceOfSelectedProduct()
        {  
            switch (article)
            {
                case "laptop":
                    price = 1400;
                    break;

                case "sd-card":
                    price = 30;
                    break;

                case "usb-hab":
                    price = 12;
                    break;
  
                default:
                    break;
            }
        }
        float price;
       
        public void CostCalculation(bool needEdv) 
        {
            PriceOfSelectedProduct();

            if (needEdv)
            {
                float adv = price * 0.18f;
                price= price * float.Parse(quantity) + adv;
            }

            else
            {
                price *= float.Parse(quantity);
            }


            Console.WriteLine($"{_account} {_customer} {_provider} {article} {quantity} {price}");
        }

      

    }
}
