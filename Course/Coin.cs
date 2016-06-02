using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class Coin
    {
        public int ID;
        public int Nominal;
        public string Country;
        public int ProductionYear;
        public int ProductedQuanity;
        public string Features;

        public Coin(int nominal, string country, int year, int quanity, string features)
        {
            Nominal = nominal;
            Country = country;
            ProductionYear = year;
            ProductedQuanity = quanity;
            Features = features;
        }

        public override bool Equals(object obj)
        {
            if (this.GetType() != obj.GetType()) return false;
            return ((Coin) obj).ID == ID;
        }
    }

    public class CoinList : List<Coin>
    {
        private int idCounter;

        public CoinList()
        {
            idCounter = 1;
        }

        public CoinList(int idC)
        {
            idCounter = idC;
        }

        public new void Add(Coin coin)
        {
            coin.ID = idCounter++;
            base.Add(coin);
        }

        public bool Replace(int ID, Coin replacant)
        {
            foreach (Coin coin in this)
            {
                if (coin.ID == ID)
                {
                    this[IndexOf(coin)] = replacant;
                    return true;
                }
            }
            return false;
        }

        public bool Delete(int ID)
        {
            foreach (Coin coin in this)
            {
                if (coin.ID == ID)
                {
                    base.Remove(coin);
                    return true;
                }
            }
            return false;
        }

        public Coin GetByID(int ID)
        {
            foreach (Coin coin in this)
            {
                if (coin.ID == ID) return coin;
            }
            return null;
        }
    }
}
