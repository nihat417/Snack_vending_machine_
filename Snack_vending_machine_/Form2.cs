using Snack_vending_machine_.Fakedatas;
using Snack_vending_machine_.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snack_vending_machine_
{
    public partial class Form2 : Form
    {
        
        public float totalmoney = 0.0f;
       
        public Form2()
        {
            InitializeComponent();
            panel2.BackColor = ColorTranslator.FromHtml("#ED9B40");
            panel3.BackColor = ColorTranslator.FromHtml("#B7ADCF");
            Howmuchmontextbox.FillColor = ColorTranslator.FromHtml("#BEB4D3");


            //totalmoney+=money
            //Howmuchmontextbox.Text = "sd";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var products = Fakedata.products;
            for (int i = products.Count-1; i>=0 ; i--)
            {
                Uc_Controls uc1 = new Uc_Controls(products[i]);
                uc1.Dock = DockStyle.Top;
                panel1.Controls.Add(uc1);
            }
        }

        
    }
}
