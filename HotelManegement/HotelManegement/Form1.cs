using System;
using System.Windows.Forms;

namespace HotelManegement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int clickCount = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK) // Show Form2 
            {
                RoomList.Items.Add(form2.BillMessage); // after booking is done, add bill to listbox
            }
        }

        private void RoomList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Increment the click count each time the selection changes
            clickCount++;

            // If the item has been clicked twice, show the bill details
            if (clickCount == 2)
            {
                // Reset click count
                clickCount = 0;

                // Show the bill details
                if (RoomList.SelectedItem != null)
                {
                    string selectedBill = RoomList.SelectedItem.ToString();
                    MessageBox.Show(selectedBill, "Bill Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (clickCount == 1)
            {
              
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Remove_btn_Click(object sender, EventArgs e)
        {
            if (RoomList.SelectedItem != null)
            {
                // Show a confirmation message
                DialogResult result = MessageBox.Show("Are you sure you want to remove this room?",
                                                      "Confirm Removal",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                
                if (result == DialogResult.Yes)
                {
                    RoomList.Items.Remove(RoomList.SelectedItem);
                }
            }
            else
            {
                
                MessageBox.Show("Please select an item to remove.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}