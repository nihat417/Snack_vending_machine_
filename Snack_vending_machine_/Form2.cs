using Newtonsoft.Json;
using Snack_vending_machine_.Fakedatas;
using Snack_vending_machine_.Models;
using Snack_vending_machine_.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Snack_vending_machine_
{
    public partial class Form2 : Form
    {
        public Action<float,bool> Paymentmoney { get; set; }
        public float totalmoney = 0.0f;
        public float retunedmoney = 0.0f;
       
        public Form2()
        {
            InitializeComponent();
            panel2.BackColor = ColorTranslator.FromHtml("#ED9B40");
            panel3.BackColor = ColorTranslator.FromHtml("#B7ADCF");
            Howmuchmontextbox.FillColor = ColorTranslator.FromHtml("#BEB4D3");
            remainingamounttextbox.FillColor = ColorTranslator.FromHtml("#BEB4D3");
            retunedtextbox.FillColor = ColorTranslator.FromHtml("#BEB4D3");
            Paymentmoney += (money,isAdd)=>
            {
                if(isAdd==true)
                {
                    totalmoney += money;
                    Howmuchmontextbox.Text = totalmoney.ToString();
                }
                else
                {
                    totalmoney -= money;
                    Howmuchmontextbox.Text = totalmoney.ToString();
                }
            };
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var products = Fakedata.products;
            //for (int i = products.Count - 1; i >= 0; i--)
            //{
            //    Uc_Controls uc1 = new Uc_Controls(products[i], Paymentmoney);
            //    uc1.Dock = DockStyle.Top;
            //    panel1.Controls.Add(uc1);
            //};
            if (File.Exists("Productsss.json"))
            {
                JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText("Productsss.json"));
            
                for (int i = products.Count - 1; i >= 0; i--)
                {
                    Uc_Controls uc1 = new Uc_Controls(products[i], Paymentmoney);
                    uc1.Dock = DockStyle.Top;
                    panel1.Controls.Add(uc1);
                    
                }
            }
            else
            {
                for (int i = products.Count - 1; i >= 0; i--)
                {
                    Uc_Controls uc1 = new Uc_Controls(products[i], Paymentmoney);
                    uc1.Dock = DockStyle.Top;
                    panel1.Controls.Add(uc1);
                }
            }
        }

        private void dollar1btn_Click(object sender, EventArgs e)
        {
            if (Howmuchmontextbox.Text != "")
            {
                if (totalmoney <= 1)
                {
                    //totalmoney = 0;
                    remainingamounttextbox.Text = "0";
                    Howmuchmontextbox.Text = totalmoney.ToString();
                    retunedtextbox.Text = (1.0f - totalmoney).ToString();
                }
                else if (totalmoney == 1)
                    retunedtextbox.Text = "0";
                else
                {

                    remainingamounttextbox.Text = (totalmoney -= 1.0f).ToString();
                }
            }
            else
                dollar1btn.Enabled = true;
        }

        private void dollar5btn_Click(object sender, EventArgs e)
        {
            if (Howmuchmontextbox.Text != "")
            {
                if (totalmoney <= 5)
                {
                    //totalmoney = 0;
                    remainingamounttextbox.Text = "0";
                    Howmuchmontextbox.Text = totalmoney.ToString();
                    retunedtextbox.Text = (5.0f - totalmoney).ToString();
                }
                else if (totalmoney == 5)
                    retunedtextbox.Text = "0";                
                else
                {

                    remainingamounttextbox.Text = (totalmoney -= 5.0f).ToString();
                }
            }
            else
                dollar5btn.Enabled = true;
        }

        private void dollar10btn_Click(object sender, EventArgs e)
        {
            if (Howmuchmontextbox.Text != "")
            {
                if (totalmoney <= 10)
                {

                    remainingamounttextbox.Text = "0";
                    Howmuchmontextbox.Text = totalmoney.ToString();
                    retunedtextbox.Text = (10.0f - totalmoney).ToString();
                }
                else
                {

                    remainingamounttextbox.Text = (totalmoney -= 10.0f).ToString();
                }
            }
            else
                dollar10btn.Enabled = true;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if(remainingamounttextbox.Text=="0")
            {
                Howmuchmontextbox.Text = "";
                remainingamounttextbox.Text = "";
                retunedtextbox.Text = "";
                File.WriteAllText($"Productsss.json", JsonConvert.SerializeObject(Fakedata.products));
            }
            else
            {
                MessageBox.Show("mebleg tam odenilmeyib!");
            }
        }
    }
}

