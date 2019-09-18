using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3rdassignment
{
    public partial class Form1 : Form
    {
     
        List <string> name = new List<string> { };
        List <int> contact = new List<int> { };
        List<string> address = new List<string> { };
        List<string>order = new List<string> { };
        List<int>quantity = new List<int> { };
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (contact.Contains(Convert.ToInt32(phonenobox.Text)))
                {
                    MessageBox.Show("Phone Number must be unique");
                    return;
                }
                else
                {
                    contact.Add(Convert.ToInt32(phonenobox.Text));
                }
                if (!String.IsNullOrEmpty(itemcombobox.Text))
                {
                    order.Add(itemcombobox.Text);
                }
                else
                {
                    MessageBox.Show("Please select any Item");
                    return;
                }

                if (!String.IsNullOrEmpty(quantitytextbox.Text))
                {
                    quantity.Add(Convert.ToInt32(quantitytextbox.Text));
                }
                else
                {
                    MessageBox.Show("Please insert the Quantity");
                    return;
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            name.Add(nametextbox.Text);
            address.Add(addresstextbox.Text);
            AddCustomer();
            MessageBox.Show("Data Added");
            nametextbox.Clear();
            phonenobox.Clear();
            addresstextbox.Clear();
            itemcombobox.SelectedIndex = -1;
            quantitytextbox.Clear();
        }
        private void showbutton_Click(object sender, EventArgs e)
        {
            ShowCustomer();

        }
        private void AddCustomer()
        {
            for (i = 0; i < name.Count; i++)
            {
                if (itemcombobox.SelectedItem.ToString() == "Black")
                {
                    quantity[i] = ((quantity[i]) * 120);
                }
                else if (itemcombobox.SelectedItem.ToString() == "Cold")
                {
                    quantity[i] = ((quantity[i]) * 100);
                }
                else if (itemcombobox.SelectedItem.ToString() == "Hot")
                {
                    quantity[i] = ((quantity[i]) * 90);
                }
                else if (itemcombobox.SelectedItem.ToString() == "Regular")
                {
                    quantity[i] = ((quantity[i]) * 80);
                }
                else
                {
                    MessageBox.Show("Select an item");
                }

               // itemRichTextBox.Text= "Customer Name: " + name[i] + "\n" + "Customer No: " + contact[i] + "\n" + "Address: " + address[i] + "\n" + "Order: " + order[i] + "\n" + "Price: " + quantity[i] + "\n" + "\n";
            }
        }

       
        private void ShowCustomer()
        {
            string message = "";
            for (int i = 0; i < name.Count; i++)
            {
                message += "Customer Name: " + name[i] + "\n" + "Customer No: " + contact[i] + "\n" + "Address: " + address[i] + "\n" + "Order: " + order[i] + "\n" + "Price: " + quantity[i] + "\n" + "\n";
            }
            itemRichTextBox.Text = message;
          
        }
    }
}
