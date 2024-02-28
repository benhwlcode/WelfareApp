namespace WelfareApp
{
    partial class ListOfAppsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBoxSearch = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            textBoxSearchValue = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            checkBoxOffice = new CheckBox();
            checkBoxSupervisor = new CheckBox();
            checkBoxAgent = new CheckBox();
            checkBoxManagingAgency = new CheckBox();
            checkBoxProgramName = new CheckBox();
            checkBoxAll = new CheckBox();
            groupBoxFilter = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            checkBoxWithoutChildren = new CheckBox();
            buttonEditCustomFilter = new Button();
            checkBoxWithChildren = new CheckBox();
            checkBoxUnemployed = new CheckBox();
            checkBoxEmployed = new CheckBox();
            checkBoxMarried = new CheckBox();
            checkBoxSingle = new CheckBox();
            checkBoxAdultsAboveSixtyFive = new CheckBox();
            checkBoxAdultsBelowSixtyFive = new CheckBox();
            checkBoxUseCustomFilter = new CheckBox();
            tabControlListOfApps = new TabControl();
            tabApplications = new TabPage();
            tabApplicants = new TabPage();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBoxFilter.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tabControlListOfApps.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 360F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tabControlListOfApps, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(860, 587);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBoxSearch, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBoxFilter, 0, 1);
            tableLayoutPanel2.Location = new Point(503, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 240F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(354, 581);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxSearch.Controls.Add(tableLayoutPanel3);
            groupBoxSearch.Location = new Point(3, 3);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(348, 234);
            groupBoxSearch.TabIndex = 0;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Search";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(textBoxSearchValue, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Location = new Point(6, 13);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
            tableLayoutPanel3.Size = new Size(342, 213);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // textBoxSearchValue
            // 
            textBoxSearchValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearchValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchValue.Location = new Point(3, 3);
            textBoxSearchValue.Name = "textBoxSearchValue";
            textBoxSearchValue.Size = new Size(336, 29);
            textBoxSearchValue.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(checkBoxOffice, 0, 3);
            tableLayoutPanel4.Controls.Add(checkBoxSupervisor, 1, 2);
            tableLayoutPanel4.Controls.Add(checkBoxAgent, 0, 2);
            tableLayoutPanel4.Controls.Add(checkBoxManagingAgency, 1, 1);
            tableLayoutPanel4.Controls.Add(checkBoxProgramName, 0, 1);
            tableLayoutPanel4.Controls.Add(checkBoxAll, 0, 0);
            tableLayoutPanel4.Location = new Point(3, 33);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Size = new Size(336, 177);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // checkBoxOffice
            // 
            checkBoxOffice.Anchor = AnchorStyles.Left;
            checkBoxOffice.AutoSize = true;
            checkBoxOffice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxOffice.Location = new Point(3, 142);
            checkBoxOffice.Name = "checkBoxOffice";
            checkBoxOffice.Size = new Size(70, 25);
            checkBoxOffice.TabIndex = 6;
            checkBoxOffice.Text = "Office";
            checkBoxOffice.UseVisualStyleBackColor = true;
            // 
            // checkBoxSupervisor
            // 
            checkBoxSupervisor.Anchor = AnchorStyles.Left;
            checkBoxSupervisor.AutoSize = true;
            checkBoxSupervisor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSupervisor.Location = new Point(171, 97);
            checkBoxSupervisor.Name = "checkBoxSupervisor";
            checkBoxSupervisor.Size = new Size(104, 25);
            checkBoxSupervisor.TabIndex = 5;
            checkBoxSupervisor.Text = "Supervisor";
            checkBoxSupervisor.UseVisualStyleBackColor = true;
            // 
            // checkBoxAgent
            // 
            checkBoxAgent.Anchor = AnchorStyles.Left;
            checkBoxAgent.AutoSize = true;
            checkBoxAgent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAgent.Location = new Point(3, 97);
            checkBoxAgent.Name = "checkBoxAgent";
            checkBoxAgent.Size = new Size(70, 25);
            checkBoxAgent.TabIndex = 4;
            checkBoxAgent.Text = "Agent";
            checkBoxAgent.UseVisualStyleBackColor = true;
            // 
            // checkBoxManagingAgency
            // 
            checkBoxManagingAgency.Anchor = AnchorStyles.Left;
            checkBoxManagingAgency.AutoSize = true;
            checkBoxManagingAgency.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxManagingAgency.Location = new Point(171, 53);
            checkBoxManagingAgency.Name = "checkBoxManagingAgency";
            checkBoxManagingAgency.Size = new Size(154, 25);
            checkBoxManagingAgency.TabIndex = 3;
            checkBoxManagingAgency.Text = "Managing Agency";
            checkBoxManagingAgency.UseVisualStyleBackColor = true;
            // 
            // checkBoxProgramName
            // 
            checkBoxProgramName.Anchor = AnchorStyles.Left;
            checkBoxProgramName.AutoSize = true;
            checkBoxProgramName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxProgramName.Location = new Point(3, 53);
            checkBoxProgramName.Name = "checkBoxProgramName";
            checkBoxProgramName.Size = new Size(136, 25);
            checkBoxProgramName.TabIndex = 2;
            checkBoxProgramName.Text = "Program Name";
            checkBoxProgramName.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxProgramName.UseVisualStyleBackColor = true;
            // 
            // checkBoxAll
            // 
            checkBoxAll.Anchor = AnchorStyles.Left;
            checkBoxAll.AutoSize = true;
            checkBoxAll.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAll.Location = new Point(3, 9);
            checkBoxAll.Name = "checkBoxAll";
            checkBoxAll.Size = new Size(47, 25);
            checkBoxAll.TabIndex = 0;
            checkBoxAll.Text = "All";
            checkBoxAll.UseVisualStyleBackColor = true;
            // 
            // groupBoxFilter
            // 
            groupBoxFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxFilter.Controls.Add(tableLayoutPanel5);
            groupBoxFilter.Location = new Point(3, 243);
            groupBoxFilter.Name = "groupBoxFilter";
            groupBoxFilter.Size = new Size(348, 335);
            groupBoxFilter.TabIndex = 1;
            groupBoxFilter.TabStop = false;
            groupBoxFilter.Text = "Filter";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(checkBoxWithoutChildren, 1, 3);
            tableLayoutPanel5.Controls.Add(buttonEditCustomFilter, 1, 4);
            tableLayoutPanel5.Controls.Add(checkBoxWithChildren, 0, 3);
            tableLayoutPanel5.Controls.Add(checkBoxUnemployed, 1, 2);
            tableLayoutPanel5.Controls.Add(checkBoxEmployed, 0, 2);
            tableLayoutPanel5.Controls.Add(checkBoxMarried, 1, 1);
            tableLayoutPanel5.Controls.Add(checkBoxSingle, 0, 1);
            tableLayoutPanel5.Controls.Add(checkBoxAdultsAboveSixtyFive, 1, 0);
            tableLayoutPanel5.Controls.Add(checkBoxAdultsBelowSixtyFive, 0, 0);
            tableLayoutPanel5.Controls.Add(checkBoxUseCustomFilter, 0, 4);
            tableLayoutPanel5.Location = new Point(6, 22);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 5;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Size = new Size(336, 315);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // checkBoxWithoutChildren
            // 
            checkBoxWithoutChildren.Anchor = AnchorStyles.Left;
            checkBoxWithoutChildren.AutoSize = true;
            checkBoxWithoutChildren.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxWithoutChildren.Location = new Point(171, 208);
            checkBoxWithoutChildren.Name = "checkBoxWithoutChildren";
            checkBoxWithoutChildren.Size = new Size(148, 25);
            checkBoxWithoutChildren.TabIndex = 7;
            checkBoxWithoutChildren.Text = "Without Children";
            checkBoxWithoutChildren.UseVisualStyleBackColor = true;
            // 
            // buttonEditCustomFilter
            // 
            buttonEditCustomFilter.Anchor = AnchorStyles.Left;
            buttonEditCustomFilter.Location = new Point(171, 263);
            buttonEditCustomFilter.Name = "buttonEditCustomFilter";
            buttonEditCustomFilter.Size = new Size(120, 40);
            buttonEditCustomFilter.TabIndex = 9;
            buttonEditCustomFilter.Text = "Edit Custom Filter";
            buttonEditCustomFilter.UseVisualStyleBackColor = true;
            // 
            // checkBoxWithChildren
            // 
            checkBoxWithChildren.Anchor = AnchorStyles.Left;
            checkBoxWithChildren.AutoSize = true;
            checkBoxWithChildren.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxWithChildren.Location = new Point(3, 208);
            checkBoxWithChildren.Name = "checkBoxWithChildren";
            checkBoxWithChildren.Size = new Size(125, 25);
            checkBoxWithChildren.TabIndex = 6;
            checkBoxWithChildren.Text = "With Children";
            checkBoxWithChildren.UseVisualStyleBackColor = true;
            // 
            // checkBoxUnemployed
            // 
            checkBoxUnemployed.Anchor = AnchorStyles.Left;
            checkBoxUnemployed.AutoSize = true;
            checkBoxUnemployed.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxUnemployed.Location = new Point(171, 145);
            checkBoxUnemployed.Name = "checkBoxUnemployed";
            checkBoxUnemployed.Size = new Size(118, 25);
            checkBoxUnemployed.TabIndex = 5;
            checkBoxUnemployed.Text = "Unemployed";
            checkBoxUnemployed.UseVisualStyleBackColor = true;
            // 
            // checkBoxEmployed
            // 
            checkBoxEmployed.Anchor = AnchorStyles.Left;
            checkBoxEmployed.AutoSize = true;
            checkBoxEmployed.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxEmployed.Location = new Point(3, 145);
            checkBoxEmployed.Name = "checkBoxEmployed";
            checkBoxEmployed.Size = new Size(98, 25);
            checkBoxEmployed.TabIndex = 4;
            checkBoxEmployed.Text = "Employed";
            checkBoxEmployed.UseVisualStyleBackColor = true;
            // 
            // checkBoxMarried
            // 
            checkBoxMarried.Anchor = AnchorStyles.Left;
            checkBoxMarried.AutoSize = true;
            checkBoxMarried.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxMarried.Location = new Point(171, 82);
            checkBoxMarried.Name = "checkBoxMarried";
            checkBoxMarried.Size = new Size(84, 25);
            checkBoxMarried.TabIndex = 3;
            checkBoxMarried.Text = "Married";
            checkBoxMarried.UseVisualStyleBackColor = true;
            // 
            // checkBoxSingle
            // 
            checkBoxSingle.Anchor = AnchorStyles.Left;
            checkBoxSingle.AutoSize = true;
            checkBoxSingle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSingle.Location = new Point(3, 82);
            checkBoxSingle.Name = "checkBoxSingle";
            checkBoxSingle.Size = new Size(72, 25);
            checkBoxSingle.TabIndex = 2;
            checkBoxSingle.Text = "Single";
            checkBoxSingle.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdultsAboveSixtyFive
            // 
            checkBoxAdultsAboveSixtyFive.Anchor = AnchorStyles.Left;
            checkBoxAdultsAboveSixtyFive.AutoSize = true;
            checkBoxAdultsAboveSixtyFive.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAdultsAboveSixtyFive.Location = new Point(171, 19);
            checkBoxAdultsAboveSixtyFive.Name = "checkBoxAdultsAboveSixtyFive";
            checkBoxAdultsAboveSixtyFive.Size = new Size(143, 25);
            checkBoxAdultsAboveSixtyFive.TabIndex = 1;
            checkBoxAdultsAboveSixtyFive.Text = "Adults Above 65";
            checkBoxAdultsAboveSixtyFive.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdultsBelowSixtyFive
            // 
            checkBoxAdultsBelowSixtyFive.Anchor = AnchorStyles.Left;
            checkBoxAdultsBelowSixtyFive.AutoSize = true;
            checkBoxAdultsBelowSixtyFive.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAdultsBelowSixtyFive.Location = new Point(3, 19);
            checkBoxAdultsBelowSixtyFive.Name = "checkBoxAdultsBelowSixtyFive";
            checkBoxAdultsBelowSixtyFive.Size = new Size(141, 25);
            checkBoxAdultsBelowSixtyFive.TabIndex = 0;
            checkBoxAdultsBelowSixtyFive.Text = "Adults Below 65";
            checkBoxAdultsBelowSixtyFive.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseCustomFilter
            // 
            checkBoxUseCustomFilter.Anchor = AnchorStyles.Left;
            checkBoxUseCustomFilter.AutoSize = true;
            checkBoxUseCustomFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxUseCustomFilter.Location = new Point(3, 271);
            checkBoxUseCustomFilter.Name = "checkBoxUseCustomFilter";
            checkBoxUseCustomFilter.Size = new Size(152, 25);
            checkBoxUseCustomFilter.TabIndex = 8;
            checkBoxUseCustomFilter.Text = "Use Custom Filter";
            checkBoxUseCustomFilter.UseVisualStyleBackColor = true;
            // 
            // tabControlListOfApps
            // 
            tabControlListOfApps.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlListOfApps.Controls.Add(tabApplications);
            tabControlListOfApps.Controls.Add(tabApplicants);
            tabControlListOfApps.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlListOfApps.Location = new Point(3, 3);
            tabControlListOfApps.Name = "tabControlListOfApps";
            tabControlListOfApps.SelectedIndex = 0;
            tabControlListOfApps.Size = new Size(494, 581);
            tabControlListOfApps.TabIndex = 1;
            // 
            // tabApplications
            // 
            tabApplications.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabApplications.Location = new Point(4, 30);
            tabApplications.Name = "tabApplications";
            tabApplications.Padding = new Padding(3);
            tabApplications.Size = new Size(486, 547);
            tabApplications.TabIndex = 0;
            tabApplications.Text = "Applications";
            tabApplications.UseVisualStyleBackColor = true;
            // 
            // tabApplicants
            // 
            tabApplicants.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabApplicants.Location = new Point(4, 30);
            tabApplicants.Name = "tabApplicants";
            tabApplicants.Padding = new Padding(3);
            tabApplicants.Size = new Size(486, 547);
            tabApplicants.TabIndex = 1;
            tabApplicants.Text = "Applicants";
            tabApplicants.UseVisualStyleBackColor = true;
            // 
            // ListOfAppsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 611);
            Controls.Add(tableLayoutPanel1);
            Name = "ListOfAppsForm";
            Text = "ListOfAppsForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBoxSearch.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            groupBoxFilter.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tabControlListOfApps.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBoxSearch;
        private GroupBox groupBoxFilter;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox textBoxSearchValue;
        private TableLayoutPanel tableLayoutPanel4;
        private CheckBox checkBoxOffice;
        private CheckBox checkBoxSupervisor;
        private CheckBox checkBoxAgent;
        private CheckBox checkBoxManagingAgency;
        private CheckBox checkBoxProgramName;
        private CheckBox checkBoxAll;
        private TableLayoutPanel tableLayoutPanel5;
        private CheckBox checkBoxMarried;
        private CheckBox checkBoxSingle;
        private CheckBox checkBoxAdultsAboveSixtyFive;
        private CheckBox checkBoxAdultsBelowSixtyFive;
        private CheckBox checkBoxWithoutChildren;
        private Button buttonEditCustomFilter;
        private CheckBox checkBoxWithChildren;
        private CheckBox checkBoxUnemployed;
        private CheckBox checkBoxEmployed;
        private CheckBox checkBoxUseCustomFilter;
        private TabControl tabControlListOfApps;
        private TabPage tabApplications;
        private TabPage tabApplicants;
    }
}