namespace CollegeMivchan3.Views
{
    partial class HomeForm
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
            buttonStudent = new Button();
            buttonAboutUs = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // buttonStudent
            // 
            buttonStudent.Location = new Point(172, 86);
            buttonStudent.Name = "buttonStudent";
            buttonStudent.Size = new Size(184, 168);
            buttonStudent.TabIndex = 0;
            buttonStudent.Text = "Student";
            buttonStudent.UseVisualStyleBackColor = true;
            buttonStudent.Click += buttonStudent_Click;
            // 
            // buttonAboutUs
            // 
            buttonAboutUs.Location = new Point(416, 86);
            buttonAboutUs.Name = "buttonAboutUs";
            buttonAboutUs.Size = new Size(184, 168);
            buttonAboutUs.TabIndex = 1;
            buttonAboutUs.Text = "About As";
            buttonAboutUs.UseVisualStyleBackColor = true;
            buttonAboutUs.Click += buttonAboutUs_Click;
            // 
            // button3
            // 
            button3.Location = new Point(294, 284);
            button3.Name = "button3";
            button3.Size = new Size(184, 165);
            button3.TabIndex = 2;
            button3.Text = "Secret";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 545);
            Controls.Add(button3);
            Controls.Add(buttonAboutUs);
            Controls.Add(buttonStudent);
            Name = "HomeForm";
            Text = "HomeForm";
            FormClosed += HomeForm_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStudent;
        private Button buttonAboutUs;
        private Button button3;
    }
}