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
    public partial class Parol : Form
    {
        public List<Pizza> menusParol;
        public List<int> orderedParol;
        public Parol()
        {
            InitializeComponent();
        }
        string parol = "and";
        string parol2;
        
        private void Parol_button_Click(object sender, EventArgs e)
        {
            
            parol2 = Convert.ToString(Parol_texbox.Text);
            if (parol == parol2)
            {
                ModMenu modMenu = new ModMenu();
                foreach (Pizza pizza in menusParol)
                {
                    modMenu.EditMenuList.Items.Add(pizza.ToString());
                }
                this.Hide();
                modMenu.menusModMenu = menusParol;
                modMenu.orderedModMenu = orderedParol;
                modMenu.ShowDialog();
                if (modMenu.alarm == false)
                {
                    menusParol = modMenu.menusModMenu;
                    orderedParol = modMenu.orderedModMenu;
                }
                    
                this.Close();
            }
            else
            {
                MessageBox.Show("Неправильный пароль");
            }
        }
    }
}
