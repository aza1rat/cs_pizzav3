namespace Mnogookno
{
    partial class MainMenuPizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuPizza));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Zakaz_button = new System.Windows.Forms.Button();
            this.Admin_button = new System.Windows.Forms.Button();
            this.List_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(183, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(462, 559);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Mnogookno.Properties.Resources.logotip;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(456, 553);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::Mnogookno.Properties.Resources.fon;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Zakaz_button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Admin_button, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.List_button, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Exit_button, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.48544F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.51456F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(183, 559);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Zakaz_button
            // 
            this.Zakaz_button.AutoSize = true;
            this.Zakaz_button.BackColor = System.Drawing.Color.Tomato;
            this.Zakaz_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Zakaz_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zakaz_button.Location = new System.Drawing.Point(3, 3);
            this.Zakaz_button.Name = "Zakaz_button";
            this.Zakaz_button.Size = new System.Drawing.Size(177, 117);
            this.Zakaz_button.TabIndex = 0;
            this.Zakaz_button.Tag = "Zakaz";
            this.Zakaz_button.Text = "Сделать заказ";
            this.Zakaz_button.UseVisualStyleBackColor = false;
            this.Zakaz_button.Click += new System.EventHandler(this.MenuButtons);
            // 
            // Admin_button
            // 
            this.Admin_button.AutoSize = true;
            this.Admin_button.BackColor = System.Drawing.Color.Tomato;
            this.Admin_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Admin_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Admin_button.Location = new System.Drawing.Point(3, 126);
            this.Admin_button.Name = "Admin_button";
            this.Admin_button.Size = new System.Drawing.Size(177, 115);
            this.Admin_button.TabIndex = 1;
            this.Admin_button.Tag = "Modering";
            this.Admin_button.Text = "Управлять меню";
            this.Admin_button.UseVisualStyleBackColor = false;
            this.Admin_button.Click += new System.EventHandler(this.MenuButtons);
            // 
            // List_button
            // 
            this.List_button.AutoSize = true;
            this.List_button.BackColor = System.Drawing.Color.Tomato;
            this.List_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.List_button.Location = new System.Drawing.Point(3, 247);
            this.List_button.Name = "List_button";
            this.List_button.Size = new System.Drawing.Size(177, 111);
            this.List_button.TabIndex = 2;
            this.List_button.Tag = "PriceList";
            this.List_button.Text = "Прайс-лист";
            this.List_button.UseVisualStyleBackColor = false;
            this.List_button.Click += new System.EventHandler(this.MenuButtons);
            // 
            // Exit_button
            // 
            this.Exit_button.AutoSize = true;
            this.Exit_button.BackColor = System.Drawing.Color.Tomato;
            this.Exit_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_button.Location = new System.Drawing.Point(3, 501);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(177, 55);
            this.Exit_button.TabIndex = 3;
            this.Exit_button.Tag = "Exit";
            this.Exit_button.Text = "Выход";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.MenuButtons);
            // 
            // MainMenuPizza
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(645, 559);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuPizza";
            this.Text = "Pizza.kit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenuPizza_FormClosed);
            this.Load += new System.EventHandler(this.MainMenuPizza_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Zakaz_button;
        private System.Windows.Forms.Button Admin_button;
        private System.Windows.Forms.Button List_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}