using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_ShopList_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                if(textBox1.Text.Length > 0)
                {
                    if (listBox1.Items.Contains(textBox1.Text))
                    {
                        DialogResult result = MessageBox.Show("Element znajduje się już na liście. Czy chcesz go ponownie dodać?", "Uwaga!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if(result == DialogResult.No)
                        {
                            textBox1.Text = null;
                            return;
                        }
                    }   // check for adding duplicate element 

                    listBox1.Items.Add(textBox1.Text);
                    UpdateProgressBar();
                    textBox1.Text = null;
                }
                else 
                {
                    MessageBox.Show("Nie można dodać pustego pola!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Lista została zapełniona!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProgressBar()
        {
            int i = listBox1.Items.Count;
            progressBar1.Value = i * 10;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;

            if (i != -1)
            {
                listBox1.Items.RemoveAt(i);
                UpdateProgressBar();
            }
            else
            {
                MessageBox.Show("Żaden element nie został zaznaczony!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            int i = listBox1.Items.Count;
            
            if (i == 0)
            {
                MessageBox.Show("Lista jest już pusta!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Finishes click event
            }   // Display msg when clicking on an empty list

            DialogResult result = MessageBox.Show("Czy na pewno chcesz wyczyścić całą listę?", "Uwaga!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                UpdateProgressBar();
            }   // Clearing whole list after user's declaration
            else
            {
                return;
            }
        }
    }
}
