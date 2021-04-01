using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uebung
{
    
    public partial class Form1 : Form
    {
        private int number1 = 0;
        private int number2 = 0;
        private string res = "ERROR";
        private string operation = null;
        private bool result = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            numbersAdd();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            numberSub();
        }

        private void numbersAdd()
        {
            number1 = int.Parse(txtInOut.Text);
            operation = "+";
            txtInOut.Text = string.Empty;
            txtInOut.Focus();
        }

        private void numberSub()
        {
            number1 = int.Parse(txtInOut.Text);
            operation = "-";
            txtInOut.Text = "";
            txtInOut.Focus();
        }

        private void numberRes()
        {
            number2 = int.Parse(txtInOut.Text);
            switch (operation)
            {
                case "+":
                    res = (number1 + number2).ToString();
                    break;
                case "-":
                    res = (number1 - number2).ToString();
                    break;
                default:
                    break;
            }
            //txtInOut.Text = res;
            result = true;
        }
        private void btnRes_Click(object sender, EventArgs e)
        {
            numberRes();
        }


        private void txtInOut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
            {
                numbersAdd();
            }
            if (e.KeyCode == Keys.Subtract)
            {
                numberSub();
            }
            if (e.KeyCode == Keys.Enter)
                numberRes();
            if (e.KeyCode == Keys.Delete)
                clearAll();
            txtInOut.Text = !result ? string.Empty : res;
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            number1 = 0;
            number2 = 0;
            operation = null;
            txtInOut.Text = string.Empty;
            res = string.Empty;
        }
    }
}
