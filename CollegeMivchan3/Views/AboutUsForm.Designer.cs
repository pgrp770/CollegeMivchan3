namespace CollegeMivchan3.Views
{
    partial class AboutUsForm
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
            comboBoxCourseName = new ComboBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            comboBoxMachzor = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            buttonRequiste = new Button();
            textBoxRequiste = new TextBox();
            textBoxNameRequiste = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            label9 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxCourseName
            // 
            comboBoxCourseName.FormattingEnabled = true;
            comboBoxCourseName.Location = new Point(275, 67);
            comboBoxCourseName.Name = "comboBoxCourseName";
            comboBoxCourseName.Size = new Size(242, 40);
            comboBoxCourseName.TabIndex = 0;
            comboBoxCourseName.SelectedIndexChanged += comboBoxCourseName_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(591, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(977, 120);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(591, 302);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.Size = new Size(977, 332);
            dataGridView2.TabIndex = 2;
            // 
            // comboBoxMachzor
            // 
            comboBoxMachzor.FormattingEnabled = true;
            comboBoxMachzor.Location = new Point(275, 133);
            comboBoxMachzor.Name = "comboBoxMachzor";
            comboBoxMachzor.Size = new Size(242, 40);
            comboBoxMachzor.TabIndex = 5;
            comboBoxMachzor.SelectedIndexChanged += comboBoxMachzor_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 67);
            label1.Name = "label1";
            label1.Size = new Size(243, 32);
            label1.TabIndex = 6;
            label1.Text = "Choose course name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 133);
            label3.Name = "label3";
            label3.Size = new Size(76, 32);
            label3.TabIndex = 7;
            label3.Text = "Cycle:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1013, 258);
            label4.Name = "label4";
            label4.Size = new Size(99, 32);
            label4.TabIndex = 8;
            label4.Text = "Sylabus:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1013, 71);
            label5.Name = "label5";
            label5.Size = new Size(91, 32);
            label5.TabIndex = 9;
            label5.Text = "Details:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(171, 81);
            label6.Name = "label6";
            label6.Size = new Size(183, 32);
            label6.TabIndex = 10;
            label6.Text = "+972.8200.8200";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(171, 131);
            label7.Name = "label7";
            label7.Size = new Size(199, 32);
            label7.TabIndex = 11;
            label7.Text = "8200@gmail.com";
            // 
            // buttonRequiste
            // 
            buttonRequiste.Location = new Point(1155, 408);
            buttonRequiste.Name = "buttonRequiste";
            buttonRequiste.Size = new Size(227, 47);
            buttonRequiste.TabIndex = 12;
            buttonRequiste.Text = "Send request";
            buttonRequiste.UseVisualStyleBackColor = true;
            buttonRequiste.Click += buttonRequiste_Click;
            // 
            // textBoxRequiste
            // 
            textBoxRequiste.Location = new Point(191, 144);
            textBoxRequiste.Multiline = true;
            textBoxRequiste.Name = "textBoxRequiste";
            textBoxRequiste.Size = new Size(1191, 227);
            textBoxRequiste.TabIndex = 13;
            // 
            // textBoxNameRequiste
            // 
            textBoxNameRequiste.Location = new Point(191, 78);
            textBoxNameRequiste.Name = "textBoxNameRequiste";
            textBoxNameRequiste.Size = new Size(145, 39);
            textBoxNameRequiste.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(91, 85);
            label8.Name = "label8";
            label8.Size = new Size(78, 32);
            label8.TabIndex = 15;
            label8.Text = "Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBoxRequiste);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(buttonRequiste);
            groupBox1.Controls.Add(textBoxNameRequiste);
            groupBox1.Location = new Point(37, 706);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1478, 494);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contact us";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(91, 147);
            label9.Name = "label9";
            label9.Size = new Size(92, 32);
            label9.TabIndex = 16;
            label9.Text = "Requist";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBoxCourseName);
            groupBox2.Controls.Add(comboBoxMachzor);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(37, 120);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(529, 227);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Courses";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(37, 379);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(529, 255);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Contact us";
            // 
            // AboutUsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1617, 1276);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "AboutUsForm";
            Text = "AboutUsForm";
            FormClosed += AboutUsForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCourseName;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private ComboBox comboBoxMachzor;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button buttonRequiste;
        private TextBox textBoxRequiste;
        private TextBox textBoxNameRequiste;
        private Label label8;
        private GroupBox groupBox1;
        private Label label9;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}