using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    // Форма коллекции коллекционера
    public partial class CollectionersCollection : Form
    {
        
        //Собственно коллекция
        private CoinList collection;
        //Основной список монет для добавления
        private CoinList MainCoinList;
        public CollectionersCollection(CoinList coinList, CoinList initial)
        {
            InitializeComponent();
            collection = coinList;
            MainCoinList = initial;
            table.Columns.Add("ID");
            table.Columns.Add("Номинал");
            table.Columns.Add("Год выпуска");
            table.Columns.Add("Количество");
            table.Columns.Add("Особенности");
            DisplayList();
        }

        private void CollectionersCollection_Load(object sender, EventArgs e)
        {

        }

        DataTable table = new DataTable();

        //Отображение списка
        private void DisplayList()
        {

            table.Rows.Clear();

            foreach (Coin coin in collection)
            {
                DisplayCoin(coin);
            }
            CoinView.DataSource = table;
            CoinView.Columns[0].Visible = false;
        }
        
        //Отображение монеты
        private void DisplayCoin(Coin coin)
        {
            DataRow row = table.NewRow();
            row["ID"] = coin.ID;
            row["Номинал"] = coin.Nominal;
            row["Год выпуска"] = coin.ProductionYear;
            row["Количество"] = coin.ProductedQuanity;
            row["Особенности"] = coin.Features;
            table.Rows.Add(row);

        }

        //Контекстное меню добавить
        private void AddToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CoinAddIntoCollection form = new CoinAddIntoCollection(collection, MainCoinList);
            form.ShowDialog();
            DisplayList();
        }
        //Контекстное меню удалить

        private void DeleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (CoinView.SelectedCells[0].OwningRow.DataBoundItem != null && MessageBox.Show("Вы уверенны?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) ==
    DialogResult.OK)
            {
                int index = Convert.ToInt32(CoinView.SelectedCells[0].OwningRow.Cells[0].Value);
                collection.Delete(index);
                DisplayList();
            }
        }
    }
}
