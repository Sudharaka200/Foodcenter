namespace WindowsFormsApp1
{
    partial class Orders
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnprofile = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ordertableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodcenterDataSet1 = new WindowsFormsApp1.FoodcenterDataSet1();
            this.ordertableTableAdapter = new WindowsFormsApp1.FoodcenterDataSet1TableAdapters.OrdertableTableAdapter();
            this.sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordertableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodcenterDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(336, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1047, 32);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
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
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
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
            this.panel3.Location = new System.Drawing.Point(3, 320);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "My Orders";
            // 
            // ordertableBindingSource
            // 
            this.ordertableBindingSource.DataMember = "Ordertable";
            this.ordertableBindingSource.DataSource = this.foodcenterDataSet1;
            // 
            // foodcenterDataSet1
            // 
            this.foodcenterDataSet1.DataSetName = "FoodcenterDataSet1";
            this.foodcenterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordertableTableAdapter
            // 
            this.ordertableTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(408, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 369);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(55, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(708, 231);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 694);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordertableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodcenterDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private FoodcenterDataSet1 foodcenterDataSet1;
        private System.Windows.Forms.BindingSource ordertableBindingSource;
        private FoodcenterDataSet1TableAdapters.OrdertableTableAdapter ordertableTableAdapter;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
    }
}