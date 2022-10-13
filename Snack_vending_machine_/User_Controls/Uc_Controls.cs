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

        public Action<float,bool> Paymentmoney { get; set; }
        
        
        public int countprod = 0;
        public int? counts;
        public Uc_Controls(Product product,Action<float,bool>paymentmoney)
        {
            InitializeComponent();
            label1.BackColor = ColorTranslator.FromHtml("#52D1DC");
            panel1.BackColor = ColorTranslator.FromHtml("#16697A");
            groupBox1.BackColor = ColorTranslator.FromHtml("#FFBA08");

            if (!string.IsNullOrWhiteSpace(product.Photo))
                productspicture.Load($"./../../Resources/{product.Photo}");


            Produccostlabel.Text =  product.Cost.ToString();
            Productcountlabel.Text =product.Count.ToString();
            counts = product.Count;
            Paymentmoney = paymentmoney;
        }

        private void minusbutton_Click(object sender, EventArgs e)
        {
            
            float money = 0.0f;
            bool isAdd = false;

            int counstay = int.Parse(Productcountlabel.Text);

            if (counstay<counts)
            {
                money += float.Parse(Produccostlabel.Text);
                countprod = int.Parse(Productcountlabel.Text) + 1;
                Productcountlabel.Text = countprod.ToString();
                Paymentmoney(money,isAdd);
            }
            else
                minusbutton.Enabled = true;
        }

        private void Addproductbutton_Click(object sender, EventArgs e)
        {

            float money = 0.0f;
            bool isAdd = true;

            if (Productcountlabel.Text != "0")
            {
                money += float.Parse(Produccostlabel.Text);
                Productcountlabel.Text = (int.Parse(Productcountlabel.Text)-1).ToString();
                //Productcountlabel.Text = countprod.ToString();

                Paymentmoney(money,isAdd);
            }
            else
                Addproductbutton.Enabled = true;
        }
    }
}
