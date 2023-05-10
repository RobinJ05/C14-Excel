using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace C14_Excel
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void calculateRelativeButton_Click(object sender, RibbonControlEventArgs e)
        {
            double VcT = 0;
            double VcL = Math.Pow(10, -13);
            string currentValue = string.Empty;
            string[] splitInput = Array.Empty<string>();

            try
            {
                int halfTime = Globals.ThisAddIn.GetHalfTime(halfTimeDropdown.SelectedItem.Label);
                halfTime += int.Parse(halfTimePlusMinusDropdown.SelectedItem.Label);

                Range currentCell = Globals.ThisAddIn.GetCurrentCellRange();

                currentValue = currentCell.Value;
                currentValue = currentValue.Replace('e', 'E');
                currentValue = currentValue.Replace("^", "");

                if (!currentValue.Contains("E"))
                    currentValue.Replace("^", "E");

                if (currentCell.Value.Contains(seperatorDropdown.SelectedItem.Label))
                {
                    splitInput = currentValue.Split(Convert.ToChar(seperatorDropdown.SelectedItem.Label));
                    VcT = double.Parse(splitInput[0], System.Globalization.NumberStyles.Float);
                    VcL = double.Parse(splitInput[1], System.Globalization.NumberStyles.Float);
                }
                else
                {
                    VcT = double.Parse(currentValue, System.Globalization.NumberStyles.Float);

                    MessageBox.Show("VcT: " + VcT +
                                    "\nVcL: " + VcL +
                                    "\nHlT: " + halfTime);
                }

                double result = -Math.Log(VcT / VcL) * (halfTime / Math.Log(2));

                currentCell.Value = result;
            }
            catch (Exception _e)
            {
                MessageBox.Show($"Error: {_e.Message}\n" +
                                $"VcT: {VcT}\n" +
                                $"VcL: {VcL}\n" +
                                $"Input: {currentValue}\n" +
                                $"VcT Parse: {splitInput[0]}\n" +
                                $"VcL Parse: {splitInput[1]}");
            }
        }

        private void calculateAbsoluteButton_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void contaminationButton_Click(object sender, RibbonControlEventArgs e)
        {
            Range currentCell = Globals.ThisAddIn.GetCurrentCellRange();
        }
    }
}
