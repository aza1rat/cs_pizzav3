namespace Mnogookno
{
    partial class MakeOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeOrder));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Nazad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Balance_label = new System.Windows.Forms.Label();
            this.MenuList = new System.Windows.Forms.ListBox();
            this.AddOrdButton = new System.Windows.Forms.Button();
            this.ProductView = new System.Windows.Forms.ListView();
            this.OrderedList = new System.Windows.Forms.ListBox();
            this.DelOrdButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::Mnogookno.Properties.Resources.fon;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.80295F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.19705F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 255F));
            this.tableLayoutPanel1.Controls.Add(this.Nazad, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Balance_label, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.MenuList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddOrdButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ProductView, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.OrderedList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DelOrdButton, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.40187F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.59813F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(916, 683);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Nazad
            // 
            this.Nazad.BackColor = System.Drawing.Color.Tomato;
            this.Nazad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nazad.ForeColor = System.Drawing.Color.Black;
            this.Nazad.Location = new System.Drawing.Point(663, 636);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(250, 44);
            this.Nazad.TabIndex = 8;
            this.Nazad.Text = "Вернуться";
            this.Nazad.UseVisualStyleBackColor = false;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Mnogookno.Properties.Resources.logotip2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(663, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 319);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Balance_label
            // 
            this.Balance_label.AutoSize = true;
            this.Balance_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Balance_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Balance_label.Location = new System.Drawing.Point(663, 325);
            this.Balance_label.Name = "Balance_label";
            this.Balance_label.Size = new System.Drawing.Size(250, 25);
            this.Balance_label.TabIndex = 16;
            this.Balance_label.Text = "Кошелек: ";
            // 
            // MenuList
            // 
            this.MenuList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuList.FormattingEnabled = true;
            this.MenuList.ItemHeight = 16;
            this.MenuList.Location = new System.Drawing.Point(3, 3);
            this.MenuList.Name = "MenuList";
            this.MenuList.Size = new System.Drawing.Size(316, 319);
            this.MenuList.TabIndex = 17;
            this.MenuList.SelectedIndexChanged += new System.EventHandler(this.MenuList_SelectedIndexChanged);
            // 
            // AddOrdButton
            // 
            this.AddOrdButton.BackColor = System.Drawing.Color.Tomato;
            this.AddOrdButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddOrdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrdButton.Location = new System.Drawing.Point(3, 328);
            this.AddOrdButton.Name = "AddOrdButton";
            this.AddOrdButton.Size = new System.Drawing.Size(316, 61);
            this.AddOrdButton.TabIndex = 19;
            this.AddOrdButton.Text = "Добавить";
            this.AddOrdButton.UseVisualStyleBackColor = false;
            this.AddOrdButton.Click += new System.EventHandler(this.AddOrdButton_Click);
            // 
            // ProductView
            // 
            this.ProductView.HideSelection = false;
            this.ProductView.Location = new System.Drawing.Point(325, 3);
            this.ProductView.Name = "ProductView";
            this.ProductView.Size = new System.Drawing.Size(332, 319);
            this.ProductView.TabIndex = 20;
            this.ProductView.UseCompatibleStateImageBehavior = false;
            // 
            // OrderedList
            // 
            this.OrderedList.FormattingEnabled = true;
            this.OrderedList.ItemHeight = 16;
            this.OrderedList.Location = new System.Drawing.Point(325, 328);
            this.OrderedList.Name = "OrderedList";
            this.OrderedList.Size = new System.Drawing.Size(332, 292);
            this.OrderedList.TabIndex = 21;
            // 
            // DelOrdButton
            // 
            this.DelOrdButton.Location = new System.Drawing.Point(3, 636);
            this.DelOrdButton.Name = "DelOrdButton";
            this.DelOrdButton.Size = new System.Drawing.Size(316, 44);
            this.DelOrdButton.TabIndex = 22;
            this.DelOrdButton.Text = "button1";
            this.DelOrdButton.UseVisualStyleBackColor = true;
            this.DelOrdButton.Click += new System.EventHandler(this.DelOrdButton_Click);
            // 
            // MakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 683);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MakeOrder";
            this.Text = "Сделать заказ";
            this.Load += new System.EventHandler(this.MakeOrder_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label Balance_label;
        private System.Windows.Forms.Button AddOrdButton;
        public System.Windows.Forms.ListBox MenuList;
        private System.Windows.Forms.ListView ProductView;
        private System.Windows.Forms.ListBox OrderedList;
        private System.Windows.Forms.Button DelOrdButton;
    }
}