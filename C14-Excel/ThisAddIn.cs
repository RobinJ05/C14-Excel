using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Runtime.InteropServices;

namespace C14_Excel
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        public Excel.Worksheet GetActiveWorksheet()
        {
            return (Excel.Worksheet)Application.ActiveSheet;
        }

        public Excel.Range GetCurrentCellRange()
        {
            // Excel-Anwendungsobjekt erstellen oder abrufen
            Excel.Application excelApp = null;
            try
            {
                excelApp = (Excel.Application)Marshal.GetActiveObject("Excel.Application");
            }
            catch (COMException)
            {
                excelApp = new Excel.Application();
                excelApp.Visible = true;
            }

            // Aktives Arbeitsblatt abrufen
            Excel.Worksheet worksheet = excelApp.ActiveSheet;

            // Aktuelle Zelle des aktiven Arbeitsblatts abrufen
            Excel.Range currentCellRange = excelApp.ActiveCell;

            // COM-Objekt freigeben
            Marshal.ReleaseComObject(excelApp);
            excelApp = null;

            // Aktuelles Range-Objekt zurückgeben
            return currentCellRange;
        }
        
        public int GetHalfTime(string name)
        {
            switch (name)
            {
                case "Libby":
                    return 5568;

                case "Cambridge":
                    return 5715;

                default:
                    return 0;
            }
        }

        #region Von VSTO generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
