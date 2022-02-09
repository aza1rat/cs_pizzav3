using Mnogookno.Окны;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Mnogookno
{
    public partial class MakeOrder : Form
    {
        public double balansMakeOrder;
        public double balansOrdered = 0;
        public static List<Pizza> pizzas = new List<Pizza>();

        public MakeOrder()
        {
            InitializeComponent();
            
        }
        
        private void Nazad_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void MenuList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductView.Clear();
            string choiceCategory = MenuList.SelectedItem.ToString();
            ImageList il = new ImageList();
            il.ImageSize = new Size(100, 100);
            ProductView.LargeImageList = il;
            il.Images.Clear();
            for (int i = 2; i <= ClassExcel.GetCellsRow(ClassExcel.GetLastCells(choiceCategory)); i++)
            {
                if (ClassExcel.CheckNullCell(choiceCategory, i, 1, 5))
                {
                    ProductView.Items.Add(ProductViewAdd(
                    ClassExcel.GetCellsString(choiceCategory, i, 1),
                    ClassExcel.GetCellsDouble(choiceCategory, i, 2),
                    ClassExcel.GetCellsDouble(choiceCategory, i, 3),
                    ClassExcel.GetCellsDouble(choiceCategory, i, 4),
                    ClassExcel.GetCellsString(choiceCategory, i, 5),
                    ClassExcel.GetCellsString(choiceCategory, i, 6),
                    choiceCategory, il, i));
                    
                }
                
            }
        }

        private void AddOrdButton_Click(object sender, EventArgs e) //фикс
        {
            string nameFood = ProductView.SelectedItems[0].Tag.ToString();
            if (CheckInPizzas(nameFood))
            {
                foreach (Pizza pizzaElement in pizzas)
                {
                    if (pizzaElement.ToString() == nameFood)
                    {
                        pizzaElement.count += 1;
                        AfterBuy(pizzaElement.price);
                        return;

                    }

                    
                }
            }
            foreach (string elements in MenuList.Items)
            {
                for (int i = 2; i <= ClassExcel.GetCellsRow(ClassExcel.GetLastCells(elements)); i++)
                {
                    if (ClassExcel.CheckNullCell(elements, i, 1, 5))
                    {
                        if (ClassExcel.GetCellsString(elements, i, 1) == nameFood)
                        {
                            pizzas.Add(new Pizza(nameFood,
                                ClassExcel.GetCellsDouble(elements, i, 2),
                                ClassExcel.GetCellsDouble(elements, i, 3),
                                ClassExcel.GetCellsDouble(elements, i, 4),
                                ClassExcel.GetCellsString(elements, i, 5),
                                ClassExcel.GetCellsString(elements, i, 6)));
                            AfterBuy(ClassExcel.GetCellsDouble(elements, i, 2));
                        }
                    }
                }
                
            }
        }

        bool CheckInPizzas(string namefood)
        {
            if (pizzas.Count != 0)
            {
                foreach (Pizza pizzaElement in pizzas)
                {
                    if (pizzaElement.ToString() == namefood)
                        return true;
                }
            }
            return false;
        }

        void AfterBuy(double price)
        {
            OrderedList.Items.Clear();
            foreach (Pizza element in pizzas)
            {
                OrderedList.Items.Add(element + ": " + element.count);
            }
            balansMakeOrder -= price;
            balansOrdered += price;
            Balance_label.Text = $"Баланс: {balansMakeOrder}";
        }

        void AfterCancel(string nameFood)
        {
            int indexfordel = -1;
            foreach (Pizza element in pizzas)
            {
                if (element.name == nameFood)
                {
                    balansMakeOrder += element.price;
                    balansOrdered -= element.price;
                    Balance_label.Text = $"Баланс: {balansMakeOrder}";
                    OrderedList.Items.Clear();
                    if (element.count != 1)
                    {
                        element.count -= 1;
                    }
                    else
                    {
                        indexfordel = pizzas.FindIndex(Pizza => Pizza.name == element.name);
                    }
                }
            }
            if (indexfordel != -1)
            {
                pizzas.RemoveAt(indexfordel);
            }
            OrderedList.Items.Clear();
            foreach (Pizza element in pizzas)
            {
                OrderedList.Items.Add(element + ": " + element.count);
            }

        }

        ListViewItem ProductViewAdd(string nameFood, double costFood, double kkalFood, double weightFood, string descFood, string fileFood, string category, ImageList il, int index)
        {
            fileFood = Environment.CurrentDirectory + "//images" + "//" + category + "//" + fileFood + ".png";
            Bitmap bitmap;
                ListViewItem lvi = new ListViewItem();
            lvi.Text = nameFood + " - " + costFood + "р.\n" +
            kkalFood + "ккал " + "\n" + weightFood + "г\n" +
            descFood;
                if (File.Exists(fileFood))                  
                
                {
                    bitmap = new Bitmap(fileFood);     
                }
                else
                {
                    bitmap = Properties.Resources.logotip;
                }
                il.Images.Add(bitmap);
            lvi.ImageIndex = index - 2;
            lvi.Tag = nameFood;
            return lvi;
        }

        private void MakeOrder_Load(object sender, EventArgs e)
        {
            Balance_label.Text = $"Баланс: {balansMakeOrder}";
            ProductView.Items.Clear();
            ProductView.LabelWrap = true;
            ProductView.FullRowSelect = true;
            ProductView.RightToLeftLayout = false;
            ProductView.Scrollable = true;
            ProductView.View = View.LargeIcon;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DelOrdButton_Click(object sender, EventArgs e)
        {
            string namefood = OrderedList.SelectedItem.ToString();
            namefood = namefood.Substring(0, namefood.IndexOf(": "));
            if (CheckInPizzas(namefood))
            {
                AfterCancel(namefood);
                
            }
        }
    }
}
