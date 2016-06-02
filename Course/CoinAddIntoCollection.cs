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
    public partial class CoinAddIntoCollection : Form
    {
        private CoinList CollectorsCoins;
        private CoinList MainCoinsCollection;
        DataTable table = new DataTable();
        public CoinAddIntoCollection(CoinList collectorsCoins, CoinList mainCoins)
        {
            InitializeComponent();
            CollectorsCoins = collectorsCoins;
            MainCoinsCollection = mainCoins;
            table.Columns.Add("ID");
            table.Columns.Add("Номинал");
            table.Columns.Add("Год выпуска");
            table.Columns.Add("Количество");
            table.Columns.Add("Особенности");
            DisplayList();
        }

        private void DisplayList()
        {

            table.Rows.Clear();

            foreach (Coin coin in MainCoinsCollection)
            {
                DisplayCoin(coin);
            }
            CoinView.DataSource = table;
            CoinView.Columns[0].Visible = false;
        }

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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CoinView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CoinView.SelectedCells[0].OwningRow.DataBoundItem == null) return;

            CollectorsCoins.Add(MainCoinsCollection.GetByID(Convert.ToInt32(CoinView.SelectedCells[0].OwningRow.Cells[0].Value)));
            MessageBox.Show("Success!");

        }
    }
}
