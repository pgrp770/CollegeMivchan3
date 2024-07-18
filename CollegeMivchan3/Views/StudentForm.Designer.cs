namespace CollegeMivchan3.Views
{
    partial class StudentForm
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            comboBoxMachzor = new ComboBox();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            comboBoxCourseName = new ComboBox();
            buttonBuyCourse = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            listBox1 = new ListBox();
            label9 = new Label();
            label10 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(450, 290);
            label5.Name = "label5";
            label5.Size = new Size(91, 32);
            label5.TabIndex = 17;
            label5.Text = "Details:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(442, 486);
            label4.Name = "label4";
            label4.Size = new Size(99, 32);
            label4.TabIndex = 16;
            label4.Text = "Sylabus:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 111);
            label3.Name = "label3";
            label3.Size = new Size(76, 32);
            label3.TabIndex = 15;
            label3.Text = "Cycle:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 53);
            label1.Name = "label1";
            label1.Size = new Size(243, 32);
            label1.TabIndex = 14;
            label1.Text = "Choose course name:";
            // 
            // comboBoxMachzor
            // 
            comboBoxMachzor.FormattingEnabled = true;
            comboBoxMachzor.Location = new Point(309, 111);
            comboBoxMachzor.Name = "comboBoxMachzor";
            comboBoxMachzor.Size = new Size(242, 40);
            comboBoxMachzor.TabIndex = 13;
            comboBoxMachzor.SelectedIndexChanged += comboBoxMachzor_SelectedIndexChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(63, 528);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.Size = new Size(904, 332);
            dataGridView2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(63, 339);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(904, 120);
            dataGridView1.TabIndex = 11;
            // 
            // comboBoxCourseName
            // 
            comboBoxCourseName.FormattingEnabled = true;
            comboBoxCourseName.Location = new Point(309, 53);
            comboBoxCourseName.Name = "comboBoxCourseName";
            comboBoxCourseName.Size = new Size(242, 40);
            comboBoxCourseName.TabIndex = 10;
            comboBoxCourseName.SelectedIndexChanged += comboBoxCourseName_SelectedIndexChanged;
            // 
            // buttonBuyCourse
            // 
            buttonBuyCourse.Location = new Point(152, 184);
            buttonBuyCourse.Name = "buttonBuyCourse";
            buttonBuyCourse.Size = new Size(263, 46);
            buttonBuyCourse.TabIndex = 18;
            buttonBuyCourse.Text = "Buy the course";
            buttonBuyCourse.UseVisualStyleBackColor = true;
            buttonBuyCourse.Click += buttonBuyCourse_Click;
            // 
            // button1
            // 
            button1.Location = new Point(158, 190);
            button1.Name = "button1";
            button1.Size = new Size(90, 46);
            button1.TabIndex = 20;
            button1.Text = "Pay";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(72, 541);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 258);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Payment";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(255, 133);
            label6.Name = "label6";
            label6.Size = new Size(27, 32);
            label6.TabIndex = 23;
            label6.Text = "$";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(91, 39);
            textBox1.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 72);
            label2.Name = "label2";
            label2.Size = new Size(271, 32);
            label2.TabIndex = 21;
            label2.Text = "Enter an amount to pay:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBoxCourseName);
            groupBox2.Controls.Add(buttonBuyCourse);
            groupBox2.Controls.Add(comboBoxMachzor);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(594, 146);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1005, 901);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buy courses";

            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(97, 475);
            label7.Name = "label7";
            label7.Size = new Size(135, 32);
            label7.TabIndex = 23;
            label7.Text = "Rest to Pay:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(276, 475);
            label8.Name = "label8";
            label8.Size = new Size(78, 32);
            label8.TabIndex = 24;
            label8.Text = "label8";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(80, 87);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(240, 164);
            listBox1.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(113, 32);
            label9.Name = "label9";
            label9.Size = new Size(135, 32);
            label9.TabIndex = 26;
            label9.Text = "My courses";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 0);
            label10.Name = "label10";
            label10.Size = new Size(91, 32);
            label10.TabIndex = 27;
            label10.Text = "label10";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(listBox1);
            groupBox3.Location = new Point(72, 134);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(428, 286);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1636, 1175);
            Controls.Add(groupBox3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "StudentForm";
            Text = "StudentForm";
            FormClosed += StudentForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private ComboBox comboBoxMachzor;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private ComboBox comboBoxCourseName;
        private Button buttonBuyCourse;
        private Button button1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label6;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label label7;
        private Label label8;
        private ListBox listBox1;
        private Label label9;
        private Label label10;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox3;
    }
}