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
    //Форма добавления или изменения данных коллекционера
    public partial class AddCollectioner : Form
    {
        //Список коллекционеров
        private CollectionerList InternalList;
        //ID коллекционера
        private int ID;
        //Флаг добавления либо редактирования
        private bool Edit;

        public AddCollectioner(CollectionerList internalList)
        {
            InitializeComponent();
            InternalList = internalList;
            Edit = false;
        }

        public AddCollectioner(CollectionerList internalList, int id)
        {
            InitializeComponent();
            InternalList = internalList;
            Edit = true;
            ID = id;
            Collectioner someone = internalList.GetByID(id);
            NameBox.Text = someone.FullName;
            PhoneBox.Text = someone.PhoneNumber.ToString();
        }

        private void AddCollectioner_Load(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }

        //Кнопка добавить или изменить
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (
                !PhoneBox.Text.All(char.IsDigit) ||
                NameBox.Text == "" ||
                PhoneBox.Text == "")
            {
                MessageBox.Show("Проверьте правильность ввода полей");
                return;
            }
            if (Edit)
            {
                InternalList.GetByID(ID).FullName = NameBox.Text;
                InternalList.GetByID(ID).PhoneNumber = Convert.ToInt64(PhoneBox.Text);
            }
            else
            {
                InternalList.Add(new Collectioner(NameBox.Text,Convert.ToInt64(PhoneBox.Text)));
            }
            Close();
        }

        //Кнопка отменить
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
