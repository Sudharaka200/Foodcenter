namespace WindowsFormsApp1
{
    partial class Cart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnprofile = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cart2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodcenterDataSet = new WindowsFormsApp1.FoodcenterDataSet();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShipping = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cart2TableAdapter = new WindowsFormsApp1.FoodcenterDataSetTableAdapters.Cart2TableAdapter();
            this.foodcenterDataSet2 = new WindowsFormsApp1.FoodcenterDataSet2();
            this.pizzamenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzamenuTableAdapter = new WindowsFormsApp1.FoodcenterDataSet2TableAdapters.pizzamenuTableAdapter();
            this.labname = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cart2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodcenterDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodcenterDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzamenuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(336, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1047, 32);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnprofile);
            this.panel1.Controls.Add(this.btnOrders);
            this.panel1.Controls.Add(this.btnCart);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 694);
            this.panel1.TabIndex = 5;
            // 
            // btnprofile
            // 
            this.btnprofile.BackColor = System.Drawing.Color.Gray;
            this.btnprofile.FlatAppearance.BorderSize = 0;
            this.btnprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprofile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprofile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnprofile.Location = new System.Drawing.Point(12, 388);
            this.btnprofile.Name = "btnprofile";
            this.btnprofile.Size = new System.Drawing.Size(324, 62);
            this.btnprofile.TabIndex = 7;
            this.btnprofile.Text = "Profile";
            this.btnprofile.UseVisualStyleBackColor = false;
            this.btnprofile.Click += new System.EventHandler(this.btnprofile_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.Gray;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrders.Location = new System.Drawing.Point(12, 320);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(324, 62);
            this.btnOrders.TabIndex = 6;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.Gray;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCart.Location = new System.Drawing.Point(12, 252);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(324, 62);
            this.btnCart.TabIndex = 5;
            this.btnCart.Text = "Cart";
            this.btnCart.UseVisualStyleBackColor = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Gray;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.Location = new System.Drawing.Point(12, 184);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(324, 62);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(0, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 62);
            this.panel3.TabIndex = 3;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Gray;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Location = new System.Drawing.Point(12, 116);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(324, 62);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(361, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 579);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(564, 327);
            this.listView1.TabIndex = 36;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(372, 427);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 37);
            this.button3.TabIndex = 35;
            this.button3.Text = "Clear Cart";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(172, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Save Cart";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cart2BindingSource
            // 
            this.cart2BindingSource.DataMember = "Cart2";
            this.cart2BindingSource.DataSource = this.foodcenterDataSet;
            // 
            // foodcenterDataSet
            // 
            this.foodcenterDataSet.DataSetName = "FoodcenterDataSet";
            this.foodcenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTotalBill);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtShipping);
            this.panel4.Controls.Add(this.txtTotal);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(953, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 315);
            this.panel4.TabIndex = 8;
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Location = new System.Drawing.Point(160, 199);
            this.txtTotalBill.Multiline = true;
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.Size = new System.Drawing.Size(221, 33);
            this.txtTotalBill.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total";
            // 
            // txtShipping
            // 
            this.txtShipping.Location = new System.Drawing.Point(160, 114);
            this.txtShipping.Multiline = true;
            this.txtShipping.Name = "txtShipping";
            this.txtShipping.Size = new System.Drawing.Size(221, 33);
            this.txtShipping.TabIndex = 6;
            this.txtShipping.TextChanged += new System.EventHandler(this.txtShipping_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(160, 61);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(221, 33);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dilivery Fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order Summary";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(4, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(390, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Proceed to Checkout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cart2TableAdapter
            // 
            this.cart2TableAdapter.ClearBeforeFill = true;
            // 
            // foodcenterDataSet2
            // 
            this.foodcenterDataSet2.DataSetName = "FoodcenterDataSet2";
            this.foodcenterDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pizzamenuBindingSource
            // 
            this.pizzamenuBindingSource.DataMember = "pizzamenu";
            this.pizzamenuBindingSource.DataSource = this.foodcenterDataSet2;
            // 
            // pizzamenuTableAdapter
            // 
            this.pizzamenuTableAdapter.ClearBeforeFill = true;
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Location = new System.Drawing.Point(1327, 35);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(0, 16);
            this.labname.TabIndex = 9;
            // 
            // Cart
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 694);
            this.Controls.Add(this.labname);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cart2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodcenterDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodcenterDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzamenuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnprofile;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtShipping;
        private System.Windows.Forms.TextBox txtTotal;
        private FoodcenterDataSet foodcenterDataSet;
        private System.Windows.Forms.BindingSource cart2BindingSource;
        private FoodcenterDataSetTableAdapters.Cart2TableAdapter cart2TableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private FoodcenterDataSet2 foodcenterDataSet2;
        private System.Windows.Forms.BindingSource pizzamenuBindingSource;
        private FoodcenterDataSet2TableAdapters.pizzamenuTableAdapter pizzamenuTableAdapter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labname;
    }
}