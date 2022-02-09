using Mnogookno.Окны;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Mnogookno
{

    public partial class MainMenuPizza : Form
    {
        public double balans = -1;

        public MainMenuPizza()
        {
            InitializeComponent();
        }
        
         void MenuButtons(object sender, EventArgs e)
         {
            Button but=(Button)sender;
            switch (but.Tag)
            {
                case "Zakaz":
                    MakeOrder makeOrder = new MakeOrder();
                    makeOrder.balansMakeOrder = balans;

                    if (ClassExcel.excelBook.Sheets[1].Name == "Каталог")
                    {
                        makeOrder.MenuList.Items.Clear();
                        for (int i = 1; i <= ClassExcel.GetCellsRow(ClassExcel.GetLastCells("Каталог")); i++)
                        {
                            ClassExcel.GetCells("Каталог", i, 1);
                            if (ClassExcel.excelCells != null && ClassExcel.excelCells.Value2 == ClassExcel.excelBook.Sheets[i+1].Name)
                            {
                                makeOrder.MenuList.Items.Add(ClassExcel.excelCells.Value2);
                            }
                        }
                    }

                    this.Hide();
                    makeOrder.ShowDialog();
                    balans = makeOrder.balansMakeOrder;
                    this.Show();
                    break;

                case "Modering":
                    Parol parol = new Parol();
                    this.Hide();
                    parol.ShowDialog();
                    this.Show();
                    break;
                case "PriceList":
                    PriceList priceList = new PriceList();
                    priceList.balansPriceList = balans;
                    this.Hide();
                    priceList.ShowDialog();
                    balans = priceList.balansPriceList;
                    this.Show();
                    break;
                case "Exit": this.Close();break;
            }
         }

        private void MainMenuPizza_Load(object sender, EventArgs e)
        {
            
            if (balans == -1)
            {
                ClassExcel.excelApp = new Excel.Application();
                ClassExcel.excelApp.Visible = false;
                ClassExcel.excelBook = ClassExcel.excelApp.Workbooks.Open(Application.StartupPath + @"\pricelist.xlsx");
                Random random = new Random();
                balans = random.Next(2000, 6000);
            }
        }

        private void MainMenuPizza_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClassExcel.excelApp.Quit();
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(ClassExcel.excelApp);
            GC.Collect();
        }
    }
}
