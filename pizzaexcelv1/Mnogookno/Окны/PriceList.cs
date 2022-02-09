using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mnogookno.Окны
{
    public partial class PriceList : Form
    {
        public double balansPriceList;
        public List<Pizza> menusPriceList;
        public List<int> orderedPriceList;
        public PriceList()
        {
            InitializeComponent();
        }

        private void ExitCheckButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DelOrderedButton_Click(object sender, EventArgs e)
        {
            int indexItem = Convert.ToInt32((string)BuyedList.SelectedIndex.ToString());
            if (indexItem != -1)
            {
                if (orderedPriceList[indexItem] > 0)
                {
                    orderedPriceList[indexItem] -= 1;
                    //balansPriceList += menusPriceList[indexItem].Price;
                    BalanceLabel.Text = $"Баланс: {balansPriceList}";
                    StoimLabel.Text = $"Заказ: {FullStoim()}";
                //    InfoBuyed.Text = $"Название: {menusPriceList[indexItem].Name}" + Environment.NewLine +
                //$"Стоимость: {menusPriceList[indexItem].Price} x {orderedPriceList[indexItem]} = {menusPriceList[indexItem].Price * orderedPriceList[indexItem]}";
                }
            }
        }

        private void BuyedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexItem = Convert.ToInt32(BuyedList.SelectedIndex.ToString());
            MainMenuPizza mainMenuPizza = new MainMenuPizza();
            if (indexItem != -1)
            {
                //InfoBuyed.Text = $"Название: {menusPriceList[indexItem].Name}" + Environment.NewLine +
                //$"Стоимость: {menusPriceList[indexItem].Price} x {orderedPriceList[indexItem]} = {menusPriceList[indexItem].Price * orderedPriceList[indexItem]}";
                
            }
        }

        private void PriceList_Load(object sender, EventArgs e)
        {
            BalanceLabel.Text = $"Баланс: {balansPriceList}";
            StoimLabel.Text = $"Заказ: {FullStoim()}";
        }

        double FullStoim()
        {
            double sum = 0;
            for (int i = 0; i < menusPriceList.Count; i++)
            {
                //sum += menusPriceList[i].Price * orderedPriceList[i];
            }
            return sum;
        }
    }
}
