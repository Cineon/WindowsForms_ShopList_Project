namespace WindowsForms_ShopList_Project
{
    partial class Form1
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(405, 71);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(284, 33);
            this.progressBar1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(48, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(275, 404);
            this.listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(485, 279);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 39);
            this.textBox1.TabIndex = 2;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(485, 337);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(99, 40);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(590, 337);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(99, 40);
            this.BtnRemove.TabIndex = 4;
            this.BtnRemove.Text = "Usuń";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(485, 392);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(203, 40);
            this.BtnReset.TabIndex = 5;
            this.BtnReset.Text = "Wyczyść";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(480, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dodaj produkty :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Zapełnienie listy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 458);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.progressBar1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lista zakupowa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

