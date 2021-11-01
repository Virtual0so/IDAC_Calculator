using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDACFormulaCalculatorApp
{
    public partial class Form1 : Form
    {
        string userInput = "";
        static List<int> _IMSI = new List<int>();

        public Form1()
        {
            InitializeComponent();
            var _IMSI = new List<int>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display.Text += "";
            userInput += "1"; 
            Display.Text = userInput;
            _IMSI.Add(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display.Text += "";
            userInput += "2";

            Display.Text = userInput;
            _IMSI.Add(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display.Text += "";
            userInput += "3";

            Display.Text = userInput;
            _IMSI.Add(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Display.Text += "";
            userInput += "4";

            Display.Text = userInput;
            _IMSI.Add(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display.Text += "";
            userInput += "5";

            Display.Text = userInput;
            _IMSI.Add(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Display.Text += "";
            userInput += "6";

            Display.Text = userInput;
            _IMSI.Add(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Display.Text += "";
            userInput += "7";

            Display.Text = userInput;
            _IMSI.Add(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Display.Text += "";
            userInput += "8";

            Display.Text = userInput;
            _IMSI.Add(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Display.Text += "";
            userInput += "9";

            Display.Text = userInput;
            _IMSI.Add(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Display.Text += "";
            userInput += "0";

            Display.Text = userInput;
            _IMSI.Add(0);
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string index = "";
            long IMSI = 0;
            int i;
            int almostSolutionInt = 0;
            long solutionInt;
            List<int> test = new List<int>(_IMSI);
            List<int> indexes = new List<int>();
            List<int> IDAC = new List<int>();
            var rng = new Random();

            //populate lists for random indexes and random index values
            for (i = 0; i < 4; i++)
            {
                var randomElement = rng.Next(test.Count);
                indexes.Add(randomElement);
                IDAC.Add(test[randomElement]);
                
            }
            //try catch error handling for IMSI length
            try
            {
                //retrieves IMSI
                for (i = 0; i < 15; i++)
                {
                    if (test[i] == 0)
                    {
                        IMSI = IMSI * 10;
                    }
                    else
                    {
                        IMSI += test[i];
                        IMSI = IMSI * 10;
                    }
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Display.Text = "Enter 15 Digit IMSI";
            }
            //retrieves index values for operation
            for (i = 0; i < 4; i++)
            {
                if (IDAC[i] == 0)
                {
                    almostSolutionInt = almostSolutionInt * 10;
                }
                else
                {
                    almostSolutionInt += IDAC[i];
                    almostSolutionInt = almostSolutionInt * 10;
                }
            }
            //get indexes string value for output
            for (i = 0; i < 4; i++)
            {
                index += Convert.ToString(indexes[i]);
                index += " ";
            }

            //Control for trailing zeros
            IMSI = IMSI / 10;
            almostSolutionInt = almostSolutionInt / 10;
            //IDAC formula
            solutionInt = IMSI % almostSolutionInt;
            //display indexes and IDAC
            IndexDisplay.Text = index;
            SolutionDisplay.Text = Convert.ToString(solutionInt);

        }
        private void Clear_Click(object sender, EventArgs e)
        {
            userInput = "";
            Display.Text = "0";
            _IMSI.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}