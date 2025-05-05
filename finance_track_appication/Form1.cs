using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace finance_track_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxType.Items.Add("All");
            comboBoxType.Items.Add("Income");
            comboBoxType.Items.Add("Expense");
            comboBoxType.SelectedIndex = 0;
        }

        private void buttonadd_Click_1(object sender, EventArgs e)
        {
            string category = textBoxcate.Text;
            string amount = textBoxamount.Text;
            DateTime selectedDate = dateTimePicker2.Value;
            string year = selectedDate.Year.ToString();
            string month = selectedDate.ToString("MMMM");
            string transactionType = comboBoxType.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(category) || string.IsNullOrWhiteSpace(amount))
            {
                MessageBox.Show("Lütfen Kategori ve Tutar alanlarını doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string transaction = $"Year: {year}; Month: {month}; Category: {category}; Amount: {amount} ₺; Type: {transactionType}";
            listBoxgoster.Items.Add(transaction);

            textBoxcate.Clear();
            textBoxamount.Clear();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxgoster.Items.Clear();
        }

        private void listBoxgoster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxgoster.SelectedItem == null) return;

            string selectedTransaction = listBoxgoster.SelectedItem.ToString();
            string[] details = selectedTransaction.Split(';');

            if (details.Length == 5)
            {
                string year = details[0].Split(':')[1].Trim();
                string month = details[1].Split(':')[1].Trim();
                string category = details[2].Split(':')[1].Trim();
                string amount = details[3].Split(':')[1].Replace("₺", "").Trim();
                string transactionType = details[4].Split(':')[1].Trim();

                textBoxcate.Text = category;
                textBoxamount.Text = amount;
                dateTimePicker2.Value = new DateTime(int.Parse(year), DateTime.ParseExact(month, "MMMM", null).Month, 1);
                comboBoxType.SelectedItem = transactionType;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxgoster.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen bir işlem seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string category = textBoxcate.Text;
            string amount = textBoxamount.Text;
            DateTime selectedDate = dateTimePicker2.Value;
            string year = selectedDate.Year.ToString();
            string month = selectedDate.ToString("MMMM");
            string transactionType = comboBoxType.SelectedItem.ToString();

            string updatedTransaction = $"Year: {year}; Month: {month}; Category: {category}; Amount: {amount} ₺; Type: {transactionType}";
            listBoxgoster.Items[listBoxgoster.SelectedIndex] = updatedTransaction;

            MessageBox.Show("İşlem başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxcate.Clear();
            textBoxamount.Clear();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterTransactions();
        }

        private void FilterTransactions()
        {
            string selectedType = comboBoxType.SelectedItem.ToString();
            listBoxgoster.Items.Clear();

            foreach (var item in GetTransactions())
            {
                if (selectedType == "All" || item.Contains($"Type: {selectedType}"))
                {
                    listBoxgoster.Items.Add(item);
                }
            }
        }

        private List<string> GetTransactions()
        {
            return new List<string>
            {
                "Year: 2023; Month: January; Category: Salary; Amount: 5000 ₺; Type: Income",
                "Year: 2023; Month: February; Category: Grocery; Amount: 300 ₺; Type: Expense",
                "Year: 2023; Month: March; Category: Freelance; Amount: 1200 ₺; Type: Income",
                "Year: 2023; Month: April; Category: Rent; Amount: 1500 ₺; Type: Expense"
            };
        }
    }
}
