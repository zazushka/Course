using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    [Serializable]
    //Класс монеты
    public class Coin
    {
        //Идентификационный номер
        public int ID;
        //Номинал
        public int Nominal;
        //Страна
        public string Country;
        //Год производства
        public int ProductionYear;
        //Произведенное количество
        public int ProductedQuanity;
        //Особенности
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
    [Serializable]
    //Список монет
    public class CoinList : List<Coin>
    {
        //Счетчик идентификаторов
        private int idCounter;

        public CoinList()
        {
            idCounter = 1;
        }

        public CoinList(int idC)
        {
            idCounter = idC;
        }

        // Добавление монеты в список
        public new void Add(Coin coin)
        {
            coin.ID = idCounter++;
            base.Add(coin);
        }

        //Замена монеты по ID
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

        //Удаление
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

        //Достать монету из списка по ID
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
