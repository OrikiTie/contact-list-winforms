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
            this.jjjj = new System.Windows.Forms.Label();
            this.nnnn = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // jjjj
            // 
            this.jjjj.AutoSize = true;
            this.jjjj.Location = new System.Drawing.Point(124, 61);
            this.jjjj.Name = "jjjj";
            this.jjjj.Size = new System.Drawing.Size(55, 16);
            this.jjjj.TabIndex = 0;
            this.jjjj.Text = "Họ Tên ";
            // 
            // nnnn
            // 
            this.nnnn.AutoSize = true;
            this.nnnn.Location = new System.Drawing.Point(124, 127);
            this.nnnn.Name = "nnnn";
            this.nnnn.Size = new System.Drawing.Size(88, 16);
            this.nnnn.TabIndex = 1;
            this.nnnn.Text = "Số điện thoại ";
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(127, 232);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(119, 46);
            this.btnluu.TabIndex = 2;
            this.btnluu.Text = "lưu ";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(280, 121);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(100, 22);
            this.txtsdt.TabIndex = 3;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(280, 55);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(100, 22);
            this.txthoten.TabIndex = 4;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.nnnn);
            this.Controls.Add(this.jjjj);
            this.Name = "AddContactForm";
            this.Text = "AddContactForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label jjjj;
        private System.Windows.Forms.Label nnnn;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txthoten;
    }
}