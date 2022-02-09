namespace Mnogookno.Окны
{
    partial class Parol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parol));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Parol_texbox = new System.Windows.Forms.TextBox();
            this.Parol_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.BackgroundImage = global::Mnogookno.Properties.Resources.fon;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.09623F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.90377F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tableLayoutPanel1.Controls.Add(this.Parol_texbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Parol_button, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.90361F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.09639F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(685, 415);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Parol_texbox
            // 
            this.Parol_texbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Parol_texbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Parol_texbox.Location = new System.Drawing.Point(215, 199);
            this.Parol_texbox.Name = "Parol_texbox";
            this.Parol_texbox.Size = new System.Drawing.Size(274, 30);
            this.Parol_texbox.TabIndex = 0;
            // 
            // Parol_button
            // 
            this.Parol_button.BackColor = System.Drawing.Color.Tomato;
            this.Parol_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Parol_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Parol_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Parol_button.Location = new System.Drawing.Point(215, 235);
            this.Parol_button.Name = "Parol_button";
            this.Parol_button.Size = new System.Drawing.Size(274, 33);
            this.Parol_button.TabIndex = 1;
            this.Parol_button.Text = "Подвердить";
            this.Parol_button.UseVisualStyleBackColor = false;
            this.Parol_button.Click += new System.EventHandler(this.Parol_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Mnogookno.Properties.Resources.logotip2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(495, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 226);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Parol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 415);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Parol";
            this.Text = "Пароль";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Parol_texbox;
        private System.Windows.Forms.Button Parol_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}