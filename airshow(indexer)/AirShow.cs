using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airshow_indexer_
{
    class Goods
    {
        public string Name { get; set; }
        public double price { get; set; }

    }
    class createBasket
    {
        Goods[] data;
        public createBasket()
        {
            data = new Goods[5];
        }
        public Goods this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
        
        public void array(MainWindow main)
        {
            createBasket g = new createBasket();
            g[0] = new Goods { Name = "Boeing747-400", price = 234000000 };
            g[1] = new Goods { Name = "Boeing777-200", price = 269500000 };
            g[2] = new Goods { Name = "Airbus-A380", price = 333517500 };
            g[3] = new Goods { Name = "Sukhoi Superjet", price = 32000000 };
            g[4] = new Goods { Name = "Boeing737 MAX 10", price = 129900000 };

        }
    }   
}
