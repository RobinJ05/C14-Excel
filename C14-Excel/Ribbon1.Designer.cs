namespace C14_Excel
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">"true", wenn verwaltete Ressourcen gelöscht werden sollen, andernfalls "false".</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl4 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl5 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl6 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl7 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl8 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl9 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl10 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl11 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl12 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl13 = this.Factory.CreateRibbonDropDownItem();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.calculateGroup = this.Factory.CreateRibbonGroup();
            this.calculateRelativeButton = this.Factory.CreateRibbonButton();
            this.calculateAbsoluteButton = this.Factory.CreateRibbonButton();
            this.settingsGroup = this.Factory.CreateRibbonGroup();
            this.seperatorDropdown = this.Factory.CreateRibbonDropDown();
            this.halfTimeDropdown = this.Factory.CreateRibbonDropDown();
            this.halfTimePlusMinusDropdown = this.Factory.CreateRibbonDropDown();
            this.correctionsGroup = this.Factory.CreateRibbonGroup();
            this.contaminationButton = this.Factory.CreateRibbonButton();
            this.comboBox1 = this.Factory.CreateRibbonComboBox();
            this.tab1.SuspendLayout();
            this.calculateGroup.SuspendLayout();
            this.settingsGroup.SuspendLayout();
            this.correctionsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Groups.Add(this.calculateGroup);
            this.tab1.Groups.Add(this.settingsGroup);
            this.tab1.Groups.Add(this.correctionsGroup);
            this.tab1.Label = "C14 Rechner";
            this.tab1.Name = "tab1";
            // 
            // calculateGroup
            // 
            this.calculateGroup.Items.Add(this.calculateRelativeButton);
            this.calculateGroup.Items.Add(this.calculateAbsoluteButton);
            this.calculateGroup.Label = "Calculate";
            this.calculateGroup.Name = "calculateGroup";
            // 
            // calculateRelativeButton
            // 
            this.calculateRelativeButton.Label = "Calculate relative";
            this.calculateRelativeButton.Name = "calculateRelativeButton";
            this.calculateRelativeButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.calculateRelativeButton_Click);
            // 
            // calculateAbsoluteButton
            // 
            this.calculateAbsoluteButton.Label = "Calculate absolute";
            this.calculateAbsoluteButton.Name = "calculateAbsoluteButton";
            this.calculateAbsoluteButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.calculateAbsoluteButton_Click);
            // 
            // settingsGroup
            // 
            this.settingsGroup.Items.Add(this.seperatorDropdown);
            this.settingsGroup.Items.Add(this.halfTimeDropdown);
            this.settingsGroup.Items.Add(this.halfTimePlusMinusDropdown);
            this.settingsGroup.Label = "Settings";
            this.settingsGroup.Name = "settingsGroup";
            // 
            // seperatorDropdown
            // 
            ribbonDropDownItemImpl1.Label = "/";
            ribbonDropDownItemImpl1.ScreenTip = "Slash";
            ribbonDropDownItemImpl2.Label = ";";
            ribbonDropDownItemImpl2.ScreenTip = "Semicolon";
            ribbonDropDownItemImpl3.Label = ",";
            ribbonDropDownItemImpl3.ScreenTip = "Comma";
            this.seperatorDropdown.Items.Add(ribbonDropDownItemImpl1);
            this.seperatorDropdown.Items.Add(ribbonDropDownItemImpl2);
            this.seperatorDropdown.Items.Add(ribbonDropDownItemImpl3);
            this.seperatorDropdown.Label = "Seperator";
            this.seperatorDropdown.Name = "seperatorDropdown";
            this.seperatorDropdown.SuperTip = "Select a seperator used for the input field.";
            // 
            // halfTimeDropdown
            // 
            ribbonDropDownItemImpl4.Label = "Libby";
            ribbonDropDownItemImpl4.ScreenTip = "Libby half-time";
            ribbonDropDownItemImpl4.SuperTip = "The Libby half-time is the oldest C14 dating half-time. It is 5568 ± 30 years.";
            ribbonDropDownItemImpl5.Label = "Cambridge";
            ribbonDropDownItemImpl5.ScreenTip = "Cambridge half-time";
            ribbonDropDownItemImpl5.SuperTip = "The Cambridge half-time is a more modern half-time value. It was calculated in th" +
    "e year 1990. Its half-time is 5715 ± 30 years.";
            this.halfTimeDropdown.Items.Add(ribbonDropDownItemImpl4);
            this.halfTimeDropdown.Items.Add(ribbonDropDownItemImpl5);
            this.halfTimeDropdown.Label = "Half-life";
            this.halfTimeDropdown.Name = "halfTimeDropdown";
            // 
            // halfTimePlusMinusDropdown
            // 
            ribbonDropDownItemImpl6.Label = "0";
            ribbonDropDownItemImpl6.SuperTip = "0 years";
            ribbonDropDownItemImpl7.Label = "-30";
            ribbonDropDownItemImpl7.SuperTip = "- 30 years";
            ribbonDropDownItemImpl8.Label = "+30";
            ribbonDropDownItemImpl8.SuperTip = "+ 30 years";
            this.halfTimePlusMinusDropdown.Items.Add(ribbonDropDownItemImpl6);
            this.halfTimePlusMinusDropdown.Items.Add(ribbonDropDownItemImpl7);
            this.halfTimePlusMinusDropdown.Items.Add(ribbonDropDownItemImpl8);
            this.halfTimePlusMinusDropdown.Label = "Half-time ±";
            this.halfTimePlusMinusDropdown.Name = "halfTimePlusMinusDropdown";
            // 
            // correctionsGroup
            // 
            this.correctionsGroup.Items.Add(this.contaminationButton);
            this.correctionsGroup.Items.Add(this.comboBox1);
            this.correctionsGroup.Label = "Kontamination";
            this.correctionsGroup.Name = "correctionsGroup";
            // 
            // contaminationButton
            // 
            this.contaminationButton.Label = "Contamination";
            this.contaminationButton.Name = "contaminationButton";
            this.contaminationButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.contaminationButton_Click);
            // 
            // comboBox1
            // 
            ribbonDropDownItemImpl9.Label = "1%";
            ribbonDropDownItemImpl10.Label = "25%";
            ribbonDropDownItemImpl11.Label = "50%";
            ribbonDropDownItemImpl12.Label = "75%";
            ribbonDropDownItemImpl13.Label = "100%";
            this.comboBox1.Items.Add(ribbonDropDownItemImpl9);
            this.comboBox1.Items.Add(ribbonDropDownItemImpl10);
            this.comboBox1.Items.Add(ribbonDropDownItemImpl11);
            this.comboBox1.Items.Add(ribbonDropDownItemImpl12);
            this.comboBox1.Items.Add(ribbonDropDownItemImpl13);
            this.comboBox1.Label = "Pollution";
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Text = null;
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.calculateGroup.ResumeLayout(false);
            this.calculateGroup.PerformLayout();
            this.settingsGroup.ResumeLayout(false);
            this.settingsGroup.PerformLayout();
            this.correctionsGroup.ResumeLayout(false);
            this.correctionsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup calculateGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton calculateRelativeButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton calculateAbsoluteButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup settingsGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown seperatorDropdown;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown halfTimeDropdown;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown halfTimePlusMinusDropdown;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup correctionsGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox comboBox1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton contaminationButton;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
