using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    // Форма добавления монеты
    public partial class AddCoin : Form
    {
        //Флаг редактирования или добавления
        private bool Edit;
        //Список монет
        private CoinList InternalList;
        //ID изменяемой монеты
        private int ID;
        public AddCoin(CoinList list, int id)
        {
            InitializeComponent();
            InternalList = list;
            Edit = true;
            ID = id;
            AddEditAcceptButton.Text = "Изменить";
            Coin item = InternalList.GetByID(id);
            NominalBox.Text = item.Nominal.ToString();
            CountryBox.Text = item.Country.ToString();
            ProdYearBox.Text = item.ProductionYear.ToString();
            ProdQuanityBox.Text = item.ProductedQuanity.ToString();
            FeaturesBox.Text = item.Features;
        }

        public AddCoin(CoinList list)
        {
            InitializeComponent();
            InternalList = list;
            Edit = false;
            AddEditAcceptButton.Text = "Добавить";

        }

        //Кнопка подтвердить
        private void AddEditAcceptButton_Click(object sender, EventArgs e)
        {
            if (
                !NominalBox.Text.All(char.IsDigit) ||
                !ProdYearBox.Text.All(char.IsDigit) ||
                !ProdQuanityBox.Text.All(char.IsDigit) || 
                NominalBox.Text == "" || 
                CountryBox.Text == "" || 
                ProdYearBox.Text == "" || 
                ProdQuanityBox.Text == "" ||
                FeaturesBox.Text == "")
            {
                MessageBox.Show("Проверьте правильность ввода полей");
                return;
            }
            if (Edit)
            {
                InternalList.Replace(ID,
                    new Coin(Convert.ToInt32(NominalBox.Text), CountryBox.Text, Convert.ToInt32(ProdYearBox.Text),
                        Convert.ToInt32(ProdQuanityBox.Text), FeaturesBox.Text));
            }
            else
            {
                InternalList.Add(new Coin(Convert.ToInt32(NominalBox.Text), CountryBox.Text, Convert.ToInt32(ProdYearBox.Text), Convert.ToInt32(ProdQuanityBox.Text), FeaturesBox.Text));
            }
            Close();
        }

        //Кнопка отменить
        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("Вы уверенны, что хотите отменить изменения?", "Предупреждение",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
