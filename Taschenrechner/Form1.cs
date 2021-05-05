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
            txtCalcRes.Text = string.Empty;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int zahl;
            List<int> numbers = new List<int>();
            List<string> operators = new List<string>();

            string[] read = txtCalcRes.Text.ToString().Split(' ');

            foreach (string item in read)
            {
                if (int.TryParse(item, out zahl))
                {
                    numbers.Add(zahl);
                }
                else
                {
                    operators.Add(item);
                }

            }

            int erg = numbers[0];
            for (int i =1; i<numbers.Count; i++)
            {
                switch (operators[i-1])
                {
                    case "+":
                        erg += numbers[i];
                        break;
                    case "-":
                        erg -= numbers[i];
                        break;
                    default:
                        erg=-99;
                        break;
                }
                if (erg == -99)
                    break;
            }

            txtCalcRes.Text = erg==-99 ? "ERROR" : erg.ToString();

        }
    }
    
}
