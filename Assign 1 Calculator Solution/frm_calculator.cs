using System;
using System.Windows.Forms;

//  By: David
//  Date: 5/04/2018
//  Purpose: Simple calculator reduced down in size with functions
//  Notes: to simplify further at some stage.. 

namespace Assign_1_Calculator_Solution
{
    public partial class frm_calculator : Form
    {
        public frm_calculator()
        {
            InitializeComponent();
        }

        float num1 = 0, num2 = 0, result;
       
        //Add
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (validateInput(ref txtNum1, ref num1))
                if (validateInput(ref txtNum2, ref num2))
                {
                    result = num1 + num2;
                    lblOperator.Text = "+";
                    txtAnswer.Text = result.ToString();
                }
        }
        //Subtract
        private void btn_subtract_Click(object sender, EventArgs e)
        {
            if (validateInput(ref txtNum1, ref num1))
                if (validateInput(ref txtNum2, ref num2))
                {
                    result = num1 - num2;
                    lblOperator.Text = "-";
                    txtAnswer.Text = result.ToString();
                }
        }
        //Multiply
        private void btn_multiply_Click(object sender, EventArgs e)
        {
            if (validateInput(ref txtNum1, ref num1))
                if (validateInput(ref txtNum2, ref num2))
                {
                    result = num1 * num2;
                    lblOperator.Text = "x";
                    txtAnswer.Text = result.ToString();
                 }
        }
        //Divide
        private void btn_divide_Click(object sender, EventArgs e)
        {
            if (validateInput(ref txtNum1, ref num1))
                if (validateInput(ref txtNum2, ref num2))
                {
                    // ensure not dividing by zero
                    if (isZero(num1))
                    {
                        result = num1 / num2;
                        lblOperator.Text = "/";
                        txtAnswer.Text = result.ToString();
                    }
                }          
        }
        //Modulus 
        private void btn_modulus_Click(object sender, EventArgs e)
        {
            if (validateInput(ref txtNum1,ref num1))
                if (validateInput(ref txtNum2,ref num2))
                {
                    // ensure not dividing by zero
                    if (isZero(num2))
                    {
                        result = num1 % num2;
                        lblOperator.Text = "%";
                        txtAnswer.Text = result.ToString();
                    }
                }
        }
        //Validate user input as correct type
        private bool validateInput(ref TextBox txtEntry,ref float value)
        {
            if(!float.TryParse(txtEntry.Text, out value))
            {
                MessageBox.Show("Number is not valid \nTry again!","Invalid Entry");
                txtEntry.Clear();
                txtEntry.Focus();
                return false;
            }
            return true;
        }

        //Check that input is not 0
        private bool isZero(float secondNum)
        {
            if (secondNum == 0)
            {
                MessageBox.Show("Cannot divide by zero - Please re-enter number 2", "Entry Error");
                txtNum2.SelectAll();
                txtNum2.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
