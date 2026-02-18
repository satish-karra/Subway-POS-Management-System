
//  “Developed by Satish Babu Karra”


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SubwayPOSManagementSystem

{
    public partial class JagSubs : Form
    {
        // Dictionary to store bread size and its corresponding cost
        Dictionary<string, double> breadSizeCost = new Dictionary<string, double>()
        {
            {"Kids", 5.00 },
            {"Half", 7.00 },
            {"Whole", 9.00 },
            {"Double", 12.00 }
        };

        // Dictionary to store bread type and its corresponding cost
        Dictionary<string, double> breadTypeCost = new Dictionary<string, double>()
        {
            {"Whole Grain", 2.00 },
            {"Sour Dough", 0.00 },
            {"Italian", 0.00 }
        };

        // List to store customer data
        private List<string[]> customers = new List<string[]>();

        // StreamWriter object for writing customer data to file
        private StreamWriter customerWriter;

        // Variable to keep track of the next available customer number
        private int customNumCount = 1;


        public JagSubs()
        {
            InitializeComponent();
        }

        private void JagSubs_Load(object sender, EventArgs e)
        {
            LoadCustomersFromFile();

            // Populate vegetables list
            string[] veggies = { "Lettuce", "Tomatoes", "Onions", "Green Peppers", "Red Peppers", "Mushrooms", "Pickels", "Celery", "Carrots", "Jalapeno Peppers" };
            lstVeggies.Items.AddRange(veggies);

            // Set default radio button selections
            rdbWhole.Checked = true;
            rdbSourDough.Checked = true;
            chkDelivery.Checked = false;
        }

        // Method to load customer data from file
        private void LoadCustomersFromFile()
        {
            try
            {
                // Read customer data from file and populate customers list
                using (StreamReader CustomerReader = new StreamReader("Customer.txt"))
                {
                    while (CustomerReader.EndOfStream == false)
                    {
                        string currentLine = CustomerReader.ReadLine();
                        string[] fields = currentLine.Split(',');
                        customers.Add(fields);
                        cboCustomer.Items.Add(fields[1]);

                        // Update customNumCount based on the maximum customer number
                        if (int.TryParse(fields[0], out int customNum))
                        {
                            customNumCount = Math.Max(customNum + 1, customNumCount);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}");
            }
        }

        // Method to get the text of the selected radio button for bread size
        private string GetSelectedRadioButtonTextForBreadSize()
        {
            if (rdbKids.Checked)
            {
                return "Kids";
            }
            else if (rdbHalf.Checked)
            {
                return "Half";
            }
            else if (rdbDouble.Checked)
            {
                return "Double";
            }
            else
            {
                return "Whole";
            }
        }

        // Method to get the text of the selected radio button for bread type
        private string GetSelectedRadioButtonTextForBreadType()
        {
            if (rdbWholeGrain.Checked)
            {
                return "Whole Grain";
            }
            else if (rdbItalian.Checked)
            {
                return "Italian";
            }
            else
            {
                return "Sour Dough";
            }
        }

        // Method to get the text of the selected radio button for meat type
        private string GetSelectedRadioButtonTextForMeat()
        {
            if (rdbTurkey.Checked)
            {
                return "Turkey";
            }
            else if (rdbHam.Checked)
            {
                return "Ham";
            }
            else if (rdbChicken.Checked)
            {
                return "Chicken";
            }
            else
            {
                // Handle the case when no meat type is selected
                return null;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lstVeggies.SelectedItems.Clear();
            lstDisplay.Items.Clear();
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {

            // Validate input data
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtZipCode.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please fill in all customer details.");
                return;
            }

            // Get customer details from input fields
            string name = txtName.Text;
            string address = txtAddress.Text;
            string zipCode = txtZipCode.Text;
            string phoneNumber = txtPhoneNumber.Text;

            // Increment customNumCount for the next customer
            int newCustomNumber = customNumCount++;

            // Create array to store customer data
            string[] newCustomer = { newCustomNumber.ToString(), name, address, zipCode, phoneNumber };

            try
            {
                // Write customer data to file
                using (StreamWriter customerWriter = new StreamWriter("Customer.txt", true))
                {
                    customerWriter.WriteLine(string.Join(",", newCustomer));
                }
                MessageBox.Show("Data Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving customer data: {ex.Message}");
            }

            // Add new customer to customers list and combo box
            customers.Add(newCustomer);
            cboCustomer.Items.Add(newCustomer[1]);
        }

        private void JagSubs_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (customerWriter != null)
                customerWriter.Close();
        }

        private void hsbSandwiches_ValueChanged(object sender, EventArgs e)
        {
            lblSandwiches.Text = hsbSandwiches.Value.ToString();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            // Validate if a customer is selected
            if (cboCustomer.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer.");
                return;
            }

            string customName = cboCustomer.SelectedItem.ToString();
            int numberOfSandwiches = int.Parse(lblSandwiches.Text);

            // Get selected bread size
            string breadSize = GetSelectedRadioButtonTextForBreadSize();

            // Get selected bread type
            string breadType = GetSelectedRadioButtonTextForBreadType();

            // Get selected meat type
            string meat = GetSelectedRadioButtonTextForMeat();

            if (string.IsNullOrEmpty(meat))
            {
                MessageBox.Show("Please select type of Meat");
                return;
            }

            // Check if cheese is added
            string cheese = chkCheese.Checked ? "Yes" : "No";

            // Calculate subtotal
            double subtotal = numberOfSandwiches * (breadSizeCost[breadSize] + breadTypeCost[breadType] + ((lstVeggies.SelectedItems.Count) * 0.5));

            // Apply student discount if selected
            double studentDiscount = chkStudent.Checked ? subtotal * 0.1 : 0.0;

            // Calculate tax amount
            double taxAmount = subtotal * 0.1;

            // Calculate total amount
            double total = subtotal + taxAmount;

            // Add delivery charges if applicable
            if (chkDelivery.Checked)
            {
                total += 5.00;
            }

            // Display receipt
            lstDisplay.Items.Clear();
            lstDisplay.Items.Add($"Customer Name: {customName}");
            lstDisplay.Items.Add($"Number of Sandwiches: {numberOfSandwiches}");
            lstDisplay.Items.Add($"Bread Size: {breadSize} - {breadSizeCost[breadSize]:C}");
            lstDisplay.Items.Add($"Bread Type: {breadType} - {breadTypeCost[breadType]:C}");
            lstDisplay.Items.Add($"Type of Meat: {meat}");
            lstDisplay.Items.Add($"Cheese Added? {cheese}");
            lstDisplay.Items.Add("Added Veggies:");
            foreach (string selectedItem in lstVeggies.SelectedItems)
            {
                lstDisplay.Items.Add(selectedItem);
            }

            lstDisplay.Items.Add("");
            lstDisplay.Items.Add("");
            lstDisplay.Items.Add($"Sub Total: {subtotal:C}");
            lstDisplay.Items.Add($"Student Discount: {studentDiscount:C}");
            lstDisplay.Items.Add($"Tax Amount: {taxAmount:C}");

            // Display delivery address if delivery option is selected
            if (chkDelivery.Checked)
            {
                int selectedIndex = cboCustomer.SelectedIndex;
                string[] address = customers[selectedIndex];
                lstDisplay.Items.Add($"Delivery Address: {address[2]} {address[3]}");
            }

            lstDisplay.Items.Add($"Total Order Amount: {total:C}");


        }

        private void lblSandwiches_Click(object sender, EventArgs e)
        {

        }
    }
}


