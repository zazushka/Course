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
    public partial class MainForm : Form
    {
        public Handbook Initial;
        DataTable table = new DataTable();
        public MainForm()
        {
            InitializeComponent();
            Initial = new Handbook();
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

            foreach (Coin coin in Initial.Coins)
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
        //
        //TODO: Fix exception on double click on grid cell
        //
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCoin form = new AddCoin(Initial.Coins);
            form.ShowDialog();
            DisplayList();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CoinView.SelectedCells[0].OwningRow.DataBoundItem != null && MessageBox.Show("Вы уверенны?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) ==
                DialogResult.OK)
            {
                int index = Convert.ToInt32(CoinView.SelectedCells[0].OwningRow.Cells[0].Value);
                Initial.Coins.Delete(index);
                DisplayList();
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CoinView.SelectedCells[0].OwningRow.DataBoundItem == null) return;
            AddCoin form = new AddCoin(Initial.Coins, Convert.ToInt32(CoinView.SelectedCells[0].OwningRow.Cells[0].Value));
            form.ShowDialog();
            DisplayList();

        }

        private void CoinView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CoinView.SelectedCells[0].OwningRow != null)
                MessageBox.Show(Initial.Coins.GetByID(Convert.ToInt32(CoinView.SelectedCells[0].OwningRow.Cells[0].Value)).Features);
        }

        private void CollectionersButton_Click(object sender, EventArgs e)
        {
            Collectioners form = new Collectioners(Initial.Collectioners,Initial.Coins);
            form.ShowDialog();
        }
    }
}
