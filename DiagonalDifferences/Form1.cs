using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagonalDifferences
{

    public partial class Form1 : Form
    {
        int iSumTRBLGlobal;
        int iSumTLBRGlobal;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Clearing Output Textbox for New Size
            txtOut.Clear();

            // Variables
            int iNumSize = Convert.ToInt32(txtSize.Text);
            int[,] iArray = new int[iNumSize, iNumSize];
            Random iRng = new Random();

            // Nested For Loop for Occupying the Array
            for (int i = 0; i < iNumSize; i++)
            {
                for (int j = 0; j < iNumSize; j++)
                    iArray[i, j] = iRng.Next(1, 101);
            }

            // Nested For Loop for Displaying the Generated Array
            for (int i = 0; i < iNumSize; i++) 
            {
                for (int j = 0; j < iNumSize; j++) 
                {
                    // If/Else to keep everything somewhat readable.
                    if (iArray[i, j] == 100)
                        txtOut.Text += iArray[i, j] + " ";
                    else if (iArray[i, j] < 100 && iArray[i, j] > 9)
                        txtOut.Text += iArray[i, j] + "  ";
                    else
                        txtOut.Text += iArray[i, j] + "    ";
                }
                //New Row New Line
                txtOut.Text += "\r\n";
            }

            // Putting Sums of Diagonals into Global Variable so they can be accessed in btnDifference
            iSumTLBRGlobal = CalculateTLBR(iArray, iNumSize);
            iSumTRBLGlobal = CalculateTRBL(iArray, iNumSize);

            // Put Sums of Each Diagonal into their respective text boxes
            txtSumTLBR.Text = iSumTLBRGlobal.ToString();
            txtSumTRBL.Text = iSumTRBLGlobal.ToString();

            // Put Difference of Aboslute Diagonal in TextBox
            txtDifference.Text = CalculateAbsoluteDifference(iSumTLBRGlobal, iSumTRBLGlobal).ToString();
        }

        private void btnDifference_Click(object sender, EventArgs e)
        {
            txtDifference.Text = CalculateAbsoluteDifference(iSumTLBRGlobal, iSumTRBLGlobal).ToString();
        }

        private int CalculateTLBR(int[,] iArray, int iNumSize) 
        {
            int iSumTLBR = 0;

            // Top Left to Bottom Right
            for (int i = 0; i < iNumSize; i++)
                iSumTLBR += iArray[i, i];

            return iSumTLBR;
        }

        private int CalculateTRBL(int[,] iArray, int iNumSize)
        {
            int iSumTRBL = 0;

            // Top Left to Bottom Right
            for (int i = iNumSize - 1; i >= 0; i--)
                   iSumTRBL += iArray[i, iNumSize - 1 - i];         

            return iSumTRBL;
        }

        private int CalculateAbsoluteDifference(int iSumTLBR, int iSumTRBL) 
        {
            return Math.Abs(iSumTLBR - iSumTRBL);
        }
    }
}
