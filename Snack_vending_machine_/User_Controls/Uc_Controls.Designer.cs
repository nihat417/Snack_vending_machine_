namespace Snack_vending_machine_.User_Controls
{
    partial class Uc_Controls
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Productcountlabel = new System.Windows.Forms.Label();
            this.Produccostlabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.minusbutton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.productspicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productspicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 10);
            this.label1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(162, 126);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 126);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.productspicture);
            this.groupBox1.Controls.Add(this.minusbutton);
            this.groupBox1.Controls.Add(this.guna2Button1);
            this.groupBox1.Controls.Add(this.Productcountlabel);
            this.groupBox1.Controls.Add(this.Produccostlabel);
            this.groupBox1.Location = new System.Drawing.Point(16, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Productcountlabel
            // 
            this.Productcountlabel.Location = new System.Drawing.Point(6, 57);
            this.Productcountlabel.Name = "Productcountlabel";
            this.Productcountlabel.Size = new System.Drawing.Size(70, 13);
            this.Productcountlabel.TabIndex = 2;
            this.Productcountlabel.Text = "Productcount";
            // 
            // Produccostlabel
            // 
            this.Produccostlabel.Location = new System.Drawing.Point(6, 44);
            this.Produccostlabel.Name = "Produccostlabel";
            this.Produccostlabel.Size = new System.Drawing.Size(65, 13);
            this.Produccostlabel.TabIndex = 1;
            this.Produccostlabel.Text = "ProductCost";
            // 
            // minusbutton
            // 
            this.minusbutton.BackgroundImage = global::Snack_vending_machine_.Properties.Resources.minus;
            this.minusbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minusbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.minusbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.minusbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.minusbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.minusbutton.FillColor = System.Drawing.Color.Transparent;
            this.minusbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minusbutton.ForeColor = System.Drawing.Color.White;
            this.minusbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minusbutton.Location = new System.Drawing.Point(72, 91);
            this.minusbutton.Name = "minusbutton";
            this.minusbutton.Size = new System.Drawing.Size(19, 13);
            this.minusbutton.TabIndex = 4;
            this.minusbutton.Text = "guna2Button2";
            this.minusbutton.Click += new System.EventHandler(this.minusbutton_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BackgroundImage = global::Snack_vending_machine_.Properties.Resources.plus;
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(20, 91);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(22, 13);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Adproductbtn";
            this.guna2Button1.UseTransparentBackground = true;
            // 
            // productspicture
            // 
            this.productspicture.BackColor = System.Drawing.Color.Transparent;
            this.productspicture.ImageRotate = 0F;
            this.productspicture.Location = new System.Drawing.Point(63, 31);
            this.productspicture.Name = "productspicture";
            this.productspicture.Size = new System.Drawing.Size(56, 39);
            this.productspicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productspicture.TabIndex = 5;
            this.productspicture.TabStop = false;
            this.productspicture.UseTransparentBackground = true;
            // 
            // Uc_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "Uc_Controls";
            this.Size = new System.Drawing.Size(162, 136);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productspicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button minusbutton;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label Productcountlabel;
        private System.Windows.Forms.Label Produccostlabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2PictureBox productspicture;
    }
}
