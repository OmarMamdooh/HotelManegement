namespace HotelManegement
{
    partial class Form2
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 74);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Visitor's Name";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(164, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 145);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "Check-In : ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(164, 140);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 212);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 4;
            label3.Text = "Check-Out : ";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(164, 212);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 284);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 6;
            label4.Text = "Room Type : ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(164, 281);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 371);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 8;
            label5.Text = "Payment Currency : ";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(164, 371);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 452);
            label6.Name = "label6";
            label6.Size = new Size(147, 20);
            label6.TabIndex = 10;
            label6.Text = "Additional Services : ";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(214, 451);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(66, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Wi-Fi";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(380, 452);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(92, 24);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "Breakfast";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(214, 507);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(61, 24);
            checkBox3.TabIndex = 13;
            checkBox3.Text = "Gym";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(380, 507);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(60, 24);
            checkBox4.TabIndex = 14;
            checkBox4.Text = "Pool";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkTurquoise;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(243, 600);
            button1.Name = "button1";
            button1.Size = new Size(110, 40);
            button1.TabIndex = 15;
            button1.Text = "Book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(380, 280);
            button2.Name = "button2";
            button2.Size = new Size(80, 27);
            button2.TabIndex = 16;
            button2.Text = "Details";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(619, 675);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form2";
            Text = "Booking Form";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private ComboBox comboBox2;
        private Label label6;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button button1;
        private Button button2;
    }
}