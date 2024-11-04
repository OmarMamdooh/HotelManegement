namespace HotelManegement
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
            RoomList = new ListBox();
            button1 = new Button();
            Remove_btn = new Button();
            SuspendLayout();
            // 
            // RoomList
            // 
            RoomList.BackColor = SystemColors.Menu;
            RoomList.FormattingEnabled = true;
            RoomList.Location = new Point(67, 53);
            RoomList.Name = "RoomList";
            RoomList.Size = new Size(946, 364);
            RoomList.TabIndex = 0;
            RoomList.SelectedIndexChanged += RoomList_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(463, 478);
            button1.Name = "button1";
            button1.Size = new Size(181, 42);
            button1.TabIndex = 1;
            button1.Text = "Add Room";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Remove_btn
            // 
            Remove_btn.BackColor = Color.Salmon;
            Remove_btn.FlatStyle = FlatStyle.Flat;
            Remove_btn.Font = new Font("Segoe UI", 12F);
            Remove_btn.Location = new Point(463, 553);
            Remove_btn.Name = "Remove_btn";
            Remove_btn.Size = new Size(181, 42);
            Remove_btn.TabIndex = 2;
            Remove_btn.Text = "Remove Room";
            Remove_btn.UseVisualStyleBackColor = false;
            Remove_btn.Click += Remove_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(1081, 696);
            Controls.Add(Remove_btn);
            Controls.Add(button1);
            Controls.Add(RoomList);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Rooms Manegement";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox RoomList;
        private Button button1;
        private Button Remove_btn;
    }
}
