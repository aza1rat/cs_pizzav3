namespace Mnogookno.Окны
{
    partial class PriceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceList));
            this.ImageBuyedPizza = new System.Windows.Forms.PictureBox();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ExitCheckButton = new System.Windows.Forms.Button();
            this.DelOrderedButton = new System.Windows.Forms.Button();
            this.BuyedList = new System.Windows.Forms.ListBox();
            this.InfoBuyed = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StoimLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBuyedPizza)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageBuyedPizza
            // 
            this.ImageBuyedPizza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageBuyedPizza.Location = new System.Drawing.Point(260, 29);
            this.ImageBuyedPizza.Name = "ImageBuyedPizza";
            this.ImageBuyedPizza.Size = new System.Drawing.Size(284, 264);
            this.ImageBuyedPizza.TabIndex = 1;
            this.ImageBuyedPizza.TabStop = false;
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BalanceLabel.Location = new System.Drawing.Point(260, 0);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(284, 25);
            this.BalanceLabel.TabIndex = 6;
            this.BalanceLabel.Text = "label2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::Mnogookno.Properties.Resources.fon;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.95513F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.04487F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tableLayoutPanel1.Controls.Add(this.ExitCheckButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.DelOrderedButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BuyedList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.InfoBuyed, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ImageBuyedPizza, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.StoimLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BalanceLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.783784F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.21622F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 603);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // ExitCheckButton
            // 
            this.ExitCheckButton.BackColor = System.Drawing.Color.Tomato;
            this.ExitCheckButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitCheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitCheckButton.Location = new System.Drawing.Point(550, 556);
            this.ExitCheckButton.Name = "ExitCheckButton";
            this.ExitCheckButton.Size = new System.Drawing.Size(241, 44);
            this.ExitCheckButton.TabIndex = 5;
            this.ExitCheckButton.Text = "Вернуться";
            this.ExitCheckButton.UseVisualStyleBackColor = false;
            this.ExitCheckButton.Click += new System.EventHandler(this.ExitCheckButton_Click);
            // 
            // DelOrderedButton
            // 
            this.DelOrderedButton.BackColor = System.Drawing.Color.Tomato;
            this.DelOrderedButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DelOrderedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelOrderedButton.ForeColor = System.Drawing.Color.Black;
            this.DelOrderedButton.Location = new System.Drawing.Point(3, 299);
            this.DelOrderedButton.Name = "DelOrderedButton";
            this.DelOrderedButton.Size = new System.Drawing.Size(251, 43);
            this.DelOrderedButton.TabIndex = 3;
            this.DelOrderedButton.Text = "Убрать";
            this.DelOrderedButton.UseVisualStyleBackColor = false;
            this.DelOrderedButton.Click += new System.EventHandler(this.DelOrderedButton_Click);
            // 
            // BuyedList
            // 
            this.BuyedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuyedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyedList.FormattingEnabled = true;
            this.BuyedList.ItemHeight = 16;
            this.BuyedList.Location = new System.Drawing.Point(3, 29);
            this.BuyedList.Name = "BuyedList";
            this.BuyedList.Size = new System.Drawing.Size(251, 264);
            this.BuyedList.TabIndex = 0;
            this.BuyedList.SelectedIndexChanged += new System.EventHandler(this.BuyedList_SelectedIndexChanged);
            // 
            // InfoBuyed
            // 
            this.InfoBuyed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoBuyed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoBuyed.Location = new System.Drawing.Point(260, 299);
            this.InfoBuyed.Multiline = true;
            this.InfoBuyed.Name = "InfoBuyed";
            this.InfoBuyed.Size = new System.Drawing.Size(284, 251);
            this.InfoBuyed.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Mnogookno.Properties.Resources.logotip2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(550, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 264);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // StoimLabel
            // 
            this.StoimLabel.AutoSize = true;
            this.StoimLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StoimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StoimLabel.Location = new System.Drawing.Point(3, 0);
            this.StoimLabel.Name = "StoimLabel";
            this.StoimLabel.Size = new System.Drawing.Size(251, 25);
            this.StoimLabel.TabIndex = 4;
            this.StoimLabel.Text = "label1";
            // 
            // PriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mnogookno.Properties.Resources._9srYKnlrJNc;
            this.ClientSize = new System.Drawing.Size(794, 603);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PriceList";
            this.Text = "Чек";
            this.Load += new System.EventHandler(this.PriceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBuyedPizza)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ImageBuyedPizza;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ExitCheckButton;
        private System.Windows.Forms.Button DelOrderedButton;
        public System.Windows.Forms.ListBox BuyedList;
        private System.Windows.Forms.TextBox InfoBuyed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label StoimLabel;
    }
}