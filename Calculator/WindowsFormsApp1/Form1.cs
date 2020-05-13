using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        double firstOperand = 0, secondOperand = 0, result = 0;
        string symbol = String.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            lbResult.Text += btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            lbResult.Text += btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            lbResult.Text += btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            lbResult.Text += btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            lbResult.Text += btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            lbResult.Text += btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            lbResult.Text += btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            lbResult.Text += btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            lbResult.Text += btnNine.Text;
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            lbResult.Text += btnZero.Text;
        }
        private void btnComa_Click(object sender, EventArgs e)
        {
            if (!lbResult.Text.Contains(",") && lbResult.Text != String.Empty)
                lbResult.Text += btnComa.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (lbResult.Text == String.Empty)
                return;

            firstOperand = double.Parse(lbResult.Text);

            if (lbResult.Text != String.Empty)
                lbResult.Text = String.Empty;

            symbol = "+";

            lblTemp.Text = firstOperand.ToString() + " " + symbol + " ";
        }



        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (lbResult.Text == String.Empty)
                return;

            firstOperand = double.Parse(lbResult.Text);

            if (lbResult.Text != String.Empty)
                lbResult.Text = String.Empty;

            symbol = "-";

            lblTemp.Text = firstOperand.ToString() + " " + symbol + " ";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (lbResult.Text == String.Empty)
                return;

            firstOperand = double.Parse(lbResult.Text);

            if (lbResult.Text != String.Empty)
                lbResult.Text = String.Empty;

            symbol = "/";

            lblTemp.Text = firstOperand.ToString() + " " + symbol + " ";

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (lbResult.Text == String.Empty)
                return;

            firstOperand = double.Parse(lbResult.Text);

            if (lbResult.Text != String.Empty)
                lbResult.Text = String.Empty;

            symbol = "*";

            lblTemp.Text = firstOperand.ToString() + " " + symbol;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            
            if(lbResult.Text == String.Empty)
            {
                MessageBox.Show("You have to enter value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstOperand = secondOperand = 0;
                symbol = String.Empty;
            }
            else
            {
                secondOperand = double.Parse(lbResult.Text);
                lblTemp.Text += secondOperand.ToString() + " = " ;

                if (symbol == "/" && double.Parse(lbResult.Text) == 0)
                    lbResult.Text = "Cannot divide by zero.";
                else if (symbol == "/" && secondOperand != 0)
                    firstOperand /= secondOperand;
                else if (symbol == "*")
                    firstOperand *= secondOperand;
                else if (symbol == "+")
                    firstOperand += secondOperand;
                else if (symbol == "-")
                    firstOperand -= secondOperand;

                
                lbResult.Text = firstOperand.ToString();
                firstOperand = secondOperand = 0;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            firstOperand = secondOperand = 0;
            lblTemp.Text = lbResult.Text = String.Empty;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (lbResult.Text != String.Empty)
                lbResult.Text = lbResult.Text.Remove(lbResult.Text.Length - 1, 1);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    btnOne_Click(null, null);
                    break;
                case Keys.D2:
                    btnTwo_Click(null, null);
                    break;
                case Keys.D3:
                    btnThree_Click(null, null);
                    break;
                case Keys.D4:
                    btnFour_Click(null, null);
                    break;
                case Keys.D5:
                    btnFive_Click(null, null);
                    break;
                case Keys.D6:
                    btnSix_Click(null, null);
                    break;
                case Keys.D7:
                    btnSeven_Click(null, null);
                    break;
                case Keys.D8:
                    btnEight_Click(null, null);
                    break;
                case Keys.D9:
                    btnNine_Click(null, null);
                    break;
                case Keys.D0:
                    btnZero_Click(null, null);
                    break;
                case Keys.Oemplus:
                    btnPlus_Click(null, null);
                    break;
                case Keys.OemMinus:
                    btnMinus_Click(null, null);
                    break;
                case Keys.Multiply:
                    btnMultiply_Click(null, null);
                    break;
                case Keys.Divide:
                    btnDivision_Click(null, null);
                    break;
                case Keys.Oemcomma:
                    btnComa_Click(null, null);
                    break;
                case Keys.Return:
                    btnEqual_Click(null, null);
                    break;
                case Keys.Back:
                    btnBack_Click(null, null);
                    break;
            }
        }
    }
}
