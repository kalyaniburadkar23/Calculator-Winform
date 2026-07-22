using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        double firstNumber = 0;
        string operation = "";
        string expression = "";
        bool isResultShown = false;
        public Calculator()
        {
            InitializeComponent();
        }
        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (isResultShown)
            {
                expression = "";
                txtDisplay.Clear();
                isResultShown = false;
            }

            expression += btn.Text;
            txtDisplay.Text = expression;
        }
        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (string.IsNullOrEmpty(expression))
                return;

            char lastChar = expression[expression.Length - 1];

            if ("+-*/".Contains(lastChar))
            {
                expression = expression.Substring(0, expression.Length - 1);
            }

            expression += btn.Text;
            txtDisplay.Text = expression;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);    
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            expression = "";
            txtDisplay.Clear();
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            isResultShown = true;
            try
            {
                string originalExpression = expression;

                DataTable dt = new DataTable();
                var result = dt.Compute(expression, "");

                txtDisplay.Text = originalExpression + "=" + result.ToString();

                expression = result.ToString();
            }
            catch
            {
                txtDisplay.Text = "Error";
                expression = "";
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Operator_Click(sender, e);
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            Operator_Click(sender, e);
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            Operator_Click(sender, e);
        }

        private void btninto_Click(object sender, EventArgs e)
        {
            Operator_Click(sender, e);
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
