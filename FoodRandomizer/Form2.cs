using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml.XmlConfiguration;

namespace FoodRandomizer
{
    public partial class Form2 : Form
    {
        RandomizerKlasa obj = new RandomizerKlasa();
        public Color color { get; set; }

        public Form2(Color color)
        {
            InitializeComponent();
            this.BackColor = color;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            
            // Display the result
            label1.Text = obj.Randomize();


        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbFoodADD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void rbADD_Click(object sender, EventArgs e)
        {
            string itemToADD = tbFoodADD.Text.ToString();
            MessageBox.Show($"Item that you have added to Randomizer is {itemToADD}");
            obj.food.Add(itemToADD);
            tbFoodADD.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
    }

}
