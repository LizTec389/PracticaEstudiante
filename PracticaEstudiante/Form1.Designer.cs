namespace PracticaEstudiante
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dateTime1 = new DateTimePicker();
            txtbox1 = new TextBox();
            txtbox2 = new TextBox();
            txtbox3 = new TextBox();
            txtbox4 = new TextBox();
            txtbox5 = new TextBox();
            nup = new NumericUpDown();
            button1 = new Button();
            txtbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nup).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 39);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 39);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "LastName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 39);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 2;
            label3.Text = "MotherLastName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(571, 39);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 3;
            label4.Text = "DateTimeBirthdate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 180);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 4;
            label5.Text = "ID";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(212, 180);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 5;
            label6.Text = "Caeer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(348, 180);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 6;
            label7.Text = "Average";
            // 
            // dateTime1
            // 
            dateTime1.Location = new Point(496, 75);
            dateTime1.Name = "dateTime1";
            dateTime1.Size = new Size(200, 23);
            dateTime1.TabIndex = 7;
            // 
            // txtbox1
            // 
            txtbox1.Location = new Point(57, 87);
            txtbox1.Name = "txtbox1";
            txtbox1.Size = new Size(100, 23);
            txtbox1.TabIndex = 8;
            txtbox1.Text = "hola";
            txtbox1.TextChanged += textBox1_TextChanged;
            // 
            // txtbox2
            // 
            txtbox2.Location = new Point(183, 87);
            txtbox2.Name = "txtbox2";
            txtbox2.Size = new Size(100, 23);
            txtbox2.TabIndex = 9;
            txtbox2.Text = "como";
            txtbox2.TextChanged += textBox2_TextChanged;
            // 
            // txtbox3
            // 
            txtbox3.Location = new Point(323, 87);
            txtbox3.Name = "txtbox3";
            txtbox3.Size = new Size(100, 23);
            txtbox3.TabIndex = 10;
            txtbox3.Text = "estas";
            txtbox3.TextChanged += textBox3_TextChanged;
            // 
            // txtbox4
            // 
            txtbox4.Location = new Point(57, 230);
            txtbox4.Name = "txtbox4";
            txtbox4.Size = new Size(100, 23);
            txtbox4.TabIndex = 11;
            txtbox4.Text = "yo bien";
            // 
            // txtbox5
            // 
            txtbox5.Location = new Point(192, 230);
            txtbox5.Name = "txtbox5";
            txtbox5.Size = new Size(100, 23);
            txtbox5.TabIndex = 12;
            txtbox5.Text = "y tu";
            // 
            // nup
            // 
            nup.Location = new Point(323, 231);
            nup.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nup.Name = "nup";
            nup.Size = new Size(120, 23);
            nup.TabIndex = 13;
            nup.Value = new decimal(new int[] { 9, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(571, 267);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Click";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtbox
            // 
            txtbox.Location = new Point(469, 308);
            txtbox.Name = "txtbox";
            txtbox.Size = new Size(100, 23);
            txtbox.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtbox);
            Controls.Add(button1);
            Controls.Add(nup);
            Controls.Add(txtbox5);
            Controls.Add(txtbox4);
            Controls.Add(txtbox3);
            Controls.Add(txtbox2);
            Controls.Add(txtbox1);
            Controls.Add(dateTime1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nup).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTime1;
        private TextBox txtbox1;
        private TextBox txtbox2;
        private TextBox txtbox3;
        private TextBox txtbox4;
        private TextBox txtbox5;
        private NumericUpDown nup;
        private Button button1;
        private TextBox txtbox;
    }
}
