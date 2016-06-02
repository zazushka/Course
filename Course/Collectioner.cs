using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class Collectioner
    {
        public int ID;
        public string FullName;
        public long PhoneNumber;
        public CoinList SelfCollection;

        public Collectioner(string name, long number)
        {
            FullName = name;
            PhoneNumber = number;
            SelfCollection = new CoinList();
        }
    }

    public class CollectionerList : List<Collectioner>
    {
        private int idCounter;

        public CollectionerList()
        {
            idCounter = 1;
        }

        public CollectionerList(int idC)
        {
            idCounter = idC;
        }

        public new void Add(Collectioner collectioner)
        {
            collectioner.ID = idCounter++;
            base.Add(collectioner);
        }

        public bool Replace(int ID, Collectioner replacant)
        {
            foreach (Collectioner collectioner in this)
            {
                if (collectioner.ID == ID)
                {
                    this[IndexOf(collectioner)] = replacant;
                    return true;
                }
            }
            return false;
        }

        public bool Delete(int ID)
        {
            foreach (Collectioner collectioner in this)
            {
                if (collectioner.ID == ID)
                {
                    base.Remove(collectioner);
                    return true;
                }
            }
            return false;
        }

        public Collectioner GetByID(int ID)
        {
            foreach (Collectioner collectioner in this)
            {
                if (collectioner.ID == ID) return collectioner;
            }
            return null;
        }
    }
}
