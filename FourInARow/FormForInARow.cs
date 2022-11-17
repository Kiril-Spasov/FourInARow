using System;
using System.Windows.Forms;
using System.IO;

namespace FourInARow
{
    public partial class FormForInARow : Form
    {
        public FormForInARow()
        {
            InitializeComponent();
        }

        private void BtnFourInARow_Click(object sender, EventArgs e)
        {
            string line = "";
            int number;
            bool finished = false;

            string path = Application.StartupPath + @"\four.txt";
            StreamReader streamReader = new StreamReader(path);

            while (!finished)
            {
                line = streamReader.ReadLine();

                if (line == null)
                {
                    break;
                }
                number = Convert.ToInt32(line);

                TxtResult.Text += Check(number) + Environment.NewLine;
            }
            streamReader.Close();
        }

        private string Check(int x)
        {
            int second = x / 4;
            int first = second - 1;
            int third = second + 1;
            int fourth = second + 2;

            if (first + second + third + fourth == x)
            {
                return x + " is the sum of 4 consecutive integers " + first + " " + second + " " + third + " " + fourth;
            }
            else
            {
                return x + " is not the sum of 4 consecutive integers.";
            }
        }
    }
}
