using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManegement
{
    public partial class Form2 : Form
    {
        public string BillMessage { get; private set; } // Property to store the bill message


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Clear();


            comboBox1.Items.Add("Standard Room");
            comboBox1.Items.Add("Suite");
            comboBox1.Items.Add("Deluxe Room");
            comboBox1.Items.Add("Presidential Room");

            comboBox2.Items.Clear();
            comboBox2.Items.Add("Dollar");
            comboBox2.Items.Add("Saudi Riyal");
            comboBox2.Items.Add("Yemeni Riyal");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string description = "1. *Standard Room*\n" +
                                "- A basic room with essential amenities such as a bed, a desk, a chair, and a private bathroom.\n" +
                                "Cost = 40$ per night\n\n" +
                                "2. *Suite*\n" +
                                "- A larger, more luxurious room with a separate living area, possibly a kitchenette, and upgraded amenities.\n" +
                                "Cost = 70$ per night\n\n" +
                                "3. *Deluxe Room*\n" +
                                "- A room that offers more space and additional amenities compared to a standard room, such as a better view, a mini-bar, or a seating area.\n" +
                                "Cost = 100$ per night\n\n" +
                                "4. *Presidential Suite*\n" +
                                "- The most luxurious and spacious room in a hotel, often featuring multiple bedrooms, a dining area, a private terrace, and premium amenities.\n" +
                                "Cost = 200$ per night";

            MessageBox.Show(description, "Room Descriptions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the name from the TextBox
                string name = textBox1.Text.Trim();

                // Ensure the name is not empty
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Please enter your name.", "Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the check-in and check-out dates
                DateTime checkInDate = dateTimePicker1.Value;
                DateTime checkOutDate = dateTimePicker2.Value;

                // Calculate the number of nights
                int numberOfNights = (checkOutDate - checkInDate).Days;

                // Ensure valid dates
                if (numberOfNights <= 0)
                {
                    MessageBox.Show("Please select a valid check-out date that is after the check-in date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the selected room type and its cost
                decimal roomCost = 0;
                string roomType = comboBox1.SelectedItem?.ToString();

                switch (roomType)
                {
                    case "Standard Room":
                        roomCost = 40;
                        break;
                    case "Suite":
                        roomCost = 70;
                        break;
                    case "Deluxe Room":
                        roomCost = 100;
                        break;
                    case "Presidential Room":
                        roomCost = 200;
                        break;
                    default:
                        MessageBox.Show("Please select a room type.", "Room Type Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                // Calculate the additional services cost
                decimal additionalServicesCost = 0;
                if (checkBox1.Checked) additionalServicesCost += 10;
                if (checkBox2.Checked) additionalServicesCost += 10;
                if (checkBox3.Checked) additionalServicesCost += 10;
                if (checkBox4.Checked) additionalServicesCost += 10;

                // Calculate total cost in Dollars
                decimal totalCostInDollars = (roomCost * numberOfNights) + additionalServicesCost;

                // Get the selected currency
                string selectedCurrency = comboBox2.SelectedItem?.ToString();
                decimal totalCost = totalCostInDollars; // Default to Dollars

                // Convert total cost based on selected currency
                switch (selectedCurrency)
                {
                    case "Dollar":
                        
                        break;
                    case "Saudi Riyal":
                        totalCost = totalCostInDollars * 3.8m; 
                        break;
                    case "Yemeni Riyal":
                        totalCost = totalCostInDollars * 2000m; 
                        break;
                    default:
                        MessageBox.Show("Please select a currency.", "Currency Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                // Prepare the bill message
                BillMessage = $"Name: {name}\n" +
                              $"Check-in Date: {checkInDate.ToShortDateString()}\n" +
                              $"Check-out Date: {checkOutDate.ToShortDateString()}\n" +
                              $"Room Type: {roomType}\n" +
                              $"Number of Nights: {numberOfNights}\n" +
                              $"Room Cost: {roomCost * numberOfNights:C}\n" +
                              $"Additional Services Cost: {additionalServicesCost:C}\n" +
                              $"Total Cost: {totalCost:C}";

                // Show the bill in a message box
                MessageBox.Show(BillMessage, "Booking Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Set the dialog result to OK and close the form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
