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
    public partial class AddCollectioner : Form
    {
        private CollectionerList InternalList;
        private int ID;
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
