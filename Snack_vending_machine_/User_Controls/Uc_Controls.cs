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
        public Uc_Controls(Product product)
        {
            InitializeComponent();
            label1.BackColor = ColorTranslator.FromHtml("#52D1DC");
            panel1.BackColor = ColorTranslator.FromHtml("#16697A");
            groupBox1.BackColor = ColorTranslator.FromHtml("#FFBA08");

            if (!string.IsNullOrWhiteSpace(product.Photo))
                productspicture.Load($"./../../Resources/{product.Photo}");


            //Productnamelabel.Text = $"Name:"+ product.Name.ToString();
            Produccostlabel.Text = $"Cost:" + product.Cost.ToString();
            Productcountlabel.Text = $"Count:" + product.Count.ToString();


        }

        private void minusbutton_Click(object sender, EventArgs e)
        {

        }

        
    }
}
