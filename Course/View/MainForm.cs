using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Course.View;

namespace Course
{
    //Главная форма
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

        //Отображение списка монет
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
        //Контекстное меню добавления
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCoin form = new AddCoin(Initial.Coins);
            form.ShowDialog();
            DisplayList();
        }

        //Контекстное меню удалить
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CoinView.SelectedCells[0].OwningRow.Cells[0].Value != DBNull.Value && MessageBox.Show("Вы уверенны?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) ==
                DialogResult.OK)
            {
                int index = Convert.ToInt32(CoinView.SelectedCells[0].OwningRow.Cells[0].Value);
                Initial.Coins.Delete(index);
                DisplayList();
                Initial.SaveFile();
            }
        }

        //Контекстное меню редактировать
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CoinView.SelectedCells[0].OwningRow.DataBoundItem == DBNull.Value) return;
            AddCoin form = new AddCoin(Initial.Coins, Convert.ToInt32(CoinView.SelectedCells[0].OwningRow.Cells[0].Value));
            form.ShowDialog();
            DisplayList();
            Initial.SaveFile();
        }

        //Двойной клик - окно особенностей монеты
        private void CoinView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CoinView.SelectedCells[0].OwningRow.Cells[0].Value != DBNull.Value)
                MessageBox.Show(Initial.Coins.GetByID(Convert.ToInt32(CoinView.SelectedCells[0].OwningRow.Cells[0].Value)).Features);
        }

        //Кнопка коллекционеры - список коллекционеров и их коллекций монет
        private void CollectionersButton_Click(object sender, EventArgs e)
        {
            Collectioners form = new Collectioners(Initial.Collectioners,Initial.Coins);
            form.ShowDialog();
            Initial.SaveFile();
        }

        // Кнопка моя коллекция - пользовательская коллекция монет
        private void button2_Click(object sender, EventArgs e)
        {
            CollectionersCollection form = new CollectionersCollection(Initial.UserCollection, Initial.Coins);
            form.ShowDialog();
            Initial.SaveFile();
        }

        //Верхнее меню закрыть
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Верхнее меню справка
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpForm().ShowDialog();
        }

        private void CoinView_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}