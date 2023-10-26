namespace WinFormsApp1
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
            LB_Data = new ListBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            TB_Author_Firstname = new TextBox();
            TB_Author_Lastname = new TextBox();
            AddAuthor_Button = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // LB_Data
            // 
            LB_Data.FormattingEnabled = true;
            LB_Data.ItemHeight = 15;
            LB_Data.Location = new Point(103, 38);
            LB_Data.Name = "LB_Data";
            LB_Data.Size = new Size(151, 304);
            LB_Data.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(146, 367);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(397, 258);
            button2.Name = "button2";
            button2.Size = new Size(75, 62);
            button2.TabIndex = 2;
            button2.Text = "Find category by id";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(422, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(293, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // TB_Author_Firstname
            // 
            TB_Author_Firstname.Location = new Point(293, 38);
            TB_Author_Firstname.Name = "TB_Author_Firstname";
            TB_Author_Firstname.Size = new Size(100, 23);
            TB_Author_Firstname.TabIndex = 5;
            // 
            // TB_Author_Lastname
            // 
            TB_Author_Lastname.Location = new Point(413, 38);
            TB_Author_Lastname.Name = "TB_Author_Lastname";
            TB_Author_Lastname.Size = new Size(100, 23);
            TB_Author_Lastname.TabIndex = 6;
            // 
            // AddAuthor_Button
            // 
            AddAuthor_Button.Location = new Point(539, 38);
            AddAuthor_Button.Name = "AddAuthor_Button";
            AddAuthor_Button.Size = new Size(75, 30);
            AddAuthor_Button.TabIndex = 7;
            AddAuthor_Button.Text = "add author";
            AddAuthor_Button.UseVisualStyleBackColor = true;
            AddAuthor_Button.Click += AddAuthor_Button_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(631, 140);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(62, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(550, 140);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(64, 23);
            textBox5.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(AddAuthor_Button);
            Controls.Add(TB_Author_Lastname);
            Controls.Add(TB_Author_Firstname);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(LB_Data);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LB_Data;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox TB_Author_Firstname;
        private TextBox TB_Author_Lastname;
        private Button AddAuthor_Button;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}