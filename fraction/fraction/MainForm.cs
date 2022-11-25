using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fraction
{
    public partial class MainForm : Form
    {
        Fraction myFraction = new Fraction();
        public MainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void BarPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CopyNumerButton_Click(object sender, EventArgs e)
        {
            int temp;
            try
            {
                temp = Convert.ToInt32(NumerTextBox.Text);
            }
            catch (Exception excep)
            {
                MsgLabel.Text = "Message: Please give a valid value";
                return;
            }
            myFraction.Numerator = temp;
            NumerLabel.Text = Convert.ToString(temp);
        }


        private void DenomTextBox_TextChanged(object sender, EventArgs e)
        {
            int temp;
            try
            {
                temp = Convert.ToInt32(DenomTextBox.Text);
            }
            catch (Exception excep)
            {
                MsgLabel.Text = "Message: Please give a valid value";
                return;
            }
            myFraction.Denominator = temp;
            DenomLabel.Text = Convert.ToString(temp);
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)

        {
         /*if (CheckBox.Checked == true)
                CheckBox.Text = myFraction.Value().ToString();
            else
                CheckBox.Text = "....";  */
        }

    }
}
