namespace soru2_personelidd
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Telefonn = new Label();
            Add = new Label();
            Yasadigiyerr = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 107);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 155);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Telefon:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 207);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 2;
            label3.Text = "Yaşadığı Yer:";
            // 
            // Telefonn
            // 
            Telefonn.AutoSize = true;
            Telefonn.Location = new Point(130, 155);
            Telefonn.Name = "Telefonn";
            Telefonn.Size = new Size(50, 20);
            Telefonn.TabIndex = 3;
            Telefonn.Text = "label4";
            // 
            // Add
            // 
            Add.AutoSize = true;
            Add.Location = new Point(130, 107);
            Add.Name = "Add";
            Add.Size = new Size(50, 20);
            Add.TabIndex = 4;
            Add.Text = "label5";
            // 
            // Yasadigiyerr
            // 
            Yasadigiyerr.AutoSize = true;
            Yasadigiyerr.Location = new Point(130, 207);
            Yasadigiyerr.Name = "Yasadigiyerr";
            Yasadigiyerr.Size = new Size(50, 20);
            Yasadigiyerr.TabIndex = 5;
            Yasadigiyerr.Text = "label6";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "001", "002", "003", "004", "005", "006", "007", "008", "009", "010" });
            listBox1.Location = new Point(415, 107);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(252, 244);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 450);
            Controls.Add(listBox1);
            Controls.Add(Yasadigiyerr);
            Controls.Add(Add);
            Controls.Add(Telefonn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label Telefonn;
        private Label Add;
        private Label Yasadigiyerr;
        private ListBox listBox1;
    }
}