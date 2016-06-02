using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    //Основной класс справочника
    [Serializable]
    public class Handbook
    {
        //Список коллекционеров
        public CollectionerList Collectioners;
        //Список монет
        public CoinList Coins;

        //Коллекция пользователя
        public CoinList UserCollection;

        public Handbook()
        {
            Collectioners = new CollectionerList();
            Coins = new CoinList();
            UserCollection = new CoinList();
        }

        //Сохранение в файл
        public void SaveFile()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream("database.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            formatter.Serialize(stream,this);
            stream.Close();
        }

        //Чтение из файла
        public void ReadFile()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream("database.bin", FileMode.Open, FileAccess.Read);
            Handbook temp = (Handbook)formatter.Deserialize(stream);
            stream.Close();
            Collectioners = temp.Collectioners;
            Coins = temp.Coins;
            UserCollection = temp.UserCollection;
        }
    }
}
