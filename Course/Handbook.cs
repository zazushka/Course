using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class Handbook
    {
        public CollectionerList Collectioners;
        public CoinList Coins;

        public CoinList UserCollection;

        public Handbook()
        {
            Collectioners = new CollectionerList();
            Coins = new CoinList();
            UserCollection = new CoinList();
        }
    }
}
