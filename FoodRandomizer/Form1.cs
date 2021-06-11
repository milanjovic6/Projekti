using System;
using System.Drawing;
using System.Windows.Forms;

namespace FoodRandomizer
{
    public partial class Form1 : Form
    {
        public Color color { get; set; }
        public Form1()
        {
            InitializeComponent();
            color = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
         //This method creates new form on click of button
        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(color);                                     
            this.Hide();                                                
            f2.ShowDialog();
            this.Close();

            
        }
        public void myCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (myCheckBox1.Checked)
            {
                ;
                this.BackColor = Color.FromArgb(34, 36, 49);
                color = Color.FromArgb(34, 36, 49);
                
            }
            else
            {
                this.BackColor = Color.White;
                color = Color.White;
            }

            if (myCheckBox1.Checked)
            {

                roundedButton1.BackColor = Color.FromArgb(35, 45, 45);
            }
            else
            {
                roundedButton1.BackColor = Color.White;

            }
        }
    }
}
