namespace ContactList
{
    partial class AddContactForm
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
            this.Hoten = new System.Windows.Forms.TextBox();
            this.Sodienthoai = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hoten
            // 
            this.Hoten.Location = new System.Drawing.Point(168, 132);
            this.Hoten.Name = "Hoten";
            this.Hoten.Size = new System.Drawing.Size(100, 22);
            this.Hoten.TabIndex = 0;
            this.Hoten.Text = "Họ tên ";
            // 
            // Sodienthoai
            // 
            this.Sodienthoai.Location = new System.Drawing.Point(168, 206);
            this.Sodienthoai.Name = "Sodienthoai";
            this.Sodienthoai.Size = new System.Drawing.Size(100, 22);
            this.Sodienthoai.TabIndex = 1;
            this.Sodienthoai.Text = "Số điện thoại";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sodienthoai);
            this.Controls.Add(this.Hoten);
            this.Name = "AddContactForm";
            this.Text = "AddContactForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Hoten;
        private System.Windows.Forms.TextBox Sodienthoai;
        private System.Windows.Forms.Button button1;
    }
}