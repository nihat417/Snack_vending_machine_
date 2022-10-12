using Snack_vending_machine_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snack_vending_machine_.User_Controls
{
    public partial class Uc_Controls : UserControl
    {        
        public float money = 0.0f;
        public int countprod = 0;
        public Uc_Controls(Product product)
        {
            InitializeComponent();
            label1.BackColor = ColorTranslator.FromHtml("#52D1DC");
            panel1.BackColor = ColorTranslator.FromHtml("#16697A");
            groupBox1.BackColor = ColorTranslator.FromHtml("#FFBA08");

            if (!string.IsNullOrWhiteSpace(product.Photo))
                productspicture.Load($"./../../Resources/{product.Photo}");


            //Productnamelabel.Text = $"Name:"+ product.Name.ToString();
            Produccostlabel.Text =  product.Cost.ToString();
            Productcountlabel.Text =product.Count.ToString();
            

        }

        private void minusbutton_Click(object sender, EventArgs e)
        {

        }

        private void Addproductbutton_Click(object sender, EventArgs e)
        {
            if (Productcountlabel.Text != "0")
            {
                money += float.Parse(Produccostlabel.Text);
                countprod = int.Parse(Productcountlabel.Text)-1;
                Productcountlabel.Text = countprod.ToString();

                Form2 f = new Form2();
                f.Howmuchmontextbox.Text = money.ToString();

            }
            else
                Addproductbutton.Enabled = true;
        }
    }
}
