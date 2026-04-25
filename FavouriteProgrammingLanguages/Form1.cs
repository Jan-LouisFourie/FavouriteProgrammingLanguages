using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FavouriteProgrammingLanguages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter a language name.");
                return;
            }

            if (listBox1.Items.Contains(input))
            {
                MessageBox.Show("That language is already in the list!");
            }
            else
            {
                listBox1.Items.Add(input);
                label2.Text = $"Added '{input}' at {DateTime.Now:dd MMM yyyy HH:mm:ss}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string removedLanguage = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(removedLanguage);

                label2.Text = $"Removed '{removedLanguage}' at {DateTime.Now:dd MMM yyyy HH:mm:ss}";
            }
            else
            {
                MessageBox.Show("Please select a language from the list to remove.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}