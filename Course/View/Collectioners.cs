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
    // Форма коллекционеров
    public partial class Collectioners : Form
    {
        //Основной список монет
        private CoinList Coinz;
        //Собственно коллекионеры
        private CollectionerList InitalCollectioners;
        DataTable table = new DataTable();
        private void Collectioners_Load(object sender, EventArgs e)
        {

        }
        public Collectioners(CollectionerList list,CoinList coinz)
        {
            InitializeComponent();
            InitalCollectioners = list;
            Coinz = coinz;
            table.Columns.Add("ID");
            table.Columns.Add("Полное имя");
            table.Columns.Add("Номер телефона");
            DisplayList();
        }

        //Отображение списка
        private void DisplayList()
        {

            table.Rows.Clear();
         
            foreach (Collectioner col in InitalCollectioners)
            {
                DisplayCollectioner(col);
            }
            CollectionersView.DataSource = table;
            CollectionersView.Columns[0].Visible = false;
        }

        //Отображение коллекционера
        private void DisplayCollectioner(Collectioner col)
        {
            DataRow row = table.NewRow();
            row["ID"] = col.ID;
            row["Полное имя"] = col.FullName;
            row["Номер телефона"] = col.PhoneNumber;
            table.Rows.Add(row);

        }

        //Кнопка закрыть
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Контекстное меню добавить
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCollectioner form = new AddCollectioner(InitalCollectioners);
            form.ShowDialog();
            DisplayList();
        }

        //Контекстное меню удалить
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CollectionersView.SelectedCells[0] != null && MessageBox.Show("Вы уверенны?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) ==
                DialogResult.OK)
            {
                int index = Convert.ToInt32(CollectionersView.SelectedCells[0].OwningRow.Cells[0].Value);
                InitalCollectioners.Delete(index);
                DisplayList();
            }
        }

        //Контекстное меню редактировать
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCollectioner form = new AddCollectioner(InitalCollectioners, Convert.ToInt32(CollectionersView.SelectedCells[0].OwningRow.Cells[0].Value));
            form.ShowDialog();
            DisplayList();

        }

        //Двойной клик по коллекционеру - его коллекция
        private void CollectionersView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (CollectionersView.SelectedCells[0] == null) return;
            CollectionersCollection form = new CollectionersCollection(InitalCollectioners.GetByID(Convert.ToInt32(CollectionersView.SelectedCells[0].OwningRow.Cells[0].Value)).SelfCollection,Coinz);
            form.ShowDialog();
        }
    }
}
