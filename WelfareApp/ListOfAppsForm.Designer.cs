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
            checkBoxApplicant = new CheckBox();
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
            dataGridViewApps = new DataGridView();
            tabApplicants = new TabPage();
            dataGridViewPeople = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBoxFilter.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tabControlListOfApps.SuspendLayout();
            tabApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewApps).BeginInit();
            tabApplicants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPeople).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 411F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tabControlListOfApps, 0, 0);
            tableLayoutPanel1.Location = new Point(14, 16);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(983, 783);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBoxSearch, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBoxFilter, 0, 1);
            tableLayoutPanel2.Location = new Point(575, 4);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 320F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(405, 775);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxSearch.Controls.Add(tableLayoutPanel3);
            groupBoxSearch.Location = new Point(3, 4);
            groupBoxSearch.Margin = new Padding(3, 4, 3, 4);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Padding = new Padding(3, 4, 3, 4);
            groupBoxSearch.Size = new Size(399, 312);
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
            tableLayoutPanel3.Location = new Point(7, 17);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 240F));
            tableLayoutPanel3.Size = new Size(391, 284);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // textBoxSearchValue
            // 
            textBoxSearchValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearchValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchValue.Location = new Point(3, 4);
            textBoxSearchValue.Margin = new Padding(3, 4, 3, 4);
            textBoxSearchValue.Name = "textBoxSearchValue";
            textBoxSearchValue.Size = new Size(385, 34);
            textBoxSearchValue.TabIndex = 0;
            textBoxSearchValue.TextChanged += textBoxSearchValue_TextChanged;
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
            tableLayoutPanel4.Controls.Add(checkBoxApplicant, 1, 3);
            tableLayoutPanel4.Location = new Point(3, 44);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Size = new Size(385, 236);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // checkBoxOffice
            // 
            checkBoxOffice.Anchor = AnchorStyles.Left;
            checkBoxOffice.AutoSize = true;
            checkBoxOffice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxOffice.Location = new Point(3, 190);
            checkBoxOffice.Margin = new Padding(3, 4, 3, 4);
            checkBoxOffice.Name = "checkBoxOffice";
            checkBoxOffice.Size = new Size(85, 32);
            checkBoxOffice.TabIndex = 6;
            checkBoxOffice.Text = "Office";
            checkBoxOffice.UseVisualStyleBackColor = true;
            checkBoxOffice.CheckedChanged += checkBoxOffice_CheckedChanged;
            // 
            // checkBoxSupervisor
            // 
            checkBoxSupervisor.Anchor = AnchorStyles.Left;
            checkBoxSupervisor.AutoSize = true;
            checkBoxSupervisor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSupervisor.Location = new Point(195, 131);
            checkBoxSupervisor.Margin = new Padding(3, 4, 3, 4);
            checkBoxSupervisor.Name = "checkBoxSupervisor";
            checkBoxSupervisor.Size = new Size(127, 32);
            checkBoxSupervisor.TabIndex = 5;
            checkBoxSupervisor.Text = "Supervisor";
            checkBoxSupervisor.UseVisualStyleBackColor = true;
            checkBoxSupervisor.CheckedChanged += checkBoxSupervisor_CheckedChanged;
            // 
            // checkBoxAgent
            // 
            checkBoxAgent.Anchor = AnchorStyles.Left;
            checkBoxAgent.AutoSize = true;
            checkBoxAgent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAgent.Location = new Point(3, 131);
            checkBoxAgent.Margin = new Padding(3, 4, 3, 4);
            checkBoxAgent.Name = "checkBoxAgent";
            checkBoxAgent.Size = new Size(87, 32);
            checkBoxAgent.TabIndex = 4;
            checkBoxAgent.Text = "Agent";
            checkBoxAgent.UseVisualStyleBackColor = true;
            checkBoxAgent.CheckedChanged += checkBoxAgent_CheckedChanged;
            // 
            // checkBoxManagingAgency
            // 
            checkBoxManagingAgency.Anchor = AnchorStyles.Left;
            checkBoxManagingAgency.AutoSize = true;
            checkBoxManagingAgency.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxManagingAgency.Location = new Point(195, 72);
            checkBoxManagingAgency.Margin = new Padding(3, 4, 3, 4);
            checkBoxManagingAgency.Name = "checkBoxManagingAgency";
            checkBoxManagingAgency.Size = new Size(187, 32);
            checkBoxManagingAgency.TabIndex = 3;
            checkBoxManagingAgency.Text = "Managing Agency";
            checkBoxManagingAgency.UseVisualStyleBackColor = true;
            checkBoxManagingAgency.CheckedChanged += checkBoxManagingAgency_CheckedChanged;
            // 
            // checkBoxProgramName
            // 
            checkBoxProgramName.Anchor = AnchorStyles.Left;
            checkBoxProgramName.AutoSize = true;
            checkBoxProgramName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxProgramName.Location = new Point(3, 72);
            checkBoxProgramName.Margin = new Padding(3, 4, 3, 4);
            checkBoxProgramName.Name = "checkBoxProgramName";
            checkBoxProgramName.Size = new Size(167, 32);
            checkBoxProgramName.TabIndex = 2;
            checkBoxProgramName.Text = "Program Name";
            checkBoxProgramName.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxProgramName.UseVisualStyleBackColor = true;
            checkBoxProgramName.CheckedChanged += checkBoxProgramName_CheckedChanged;
            // 
            // checkBoxAll
            // 
            checkBoxAll.Anchor = AnchorStyles.Left;
            checkBoxAll.AutoSize = true;
            checkBoxAll.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAll.Location = new Point(3, 13);
            checkBoxAll.Margin = new Padding(3, 4, 3, 4);
            checkBoxAll.Name = "checkBoxAll";
            checkBoxAll.Size = new Size(57, 32);
            checkBoxAll.TabIndex = 0;
            checkBoxAll.Text = "All";
            checkBoxAll.UseVisualStyleBackColor = true;
            checkBoxAll.CheckedChanged += checkBoxAll_CheckedChanged;
            // 
            // checkBoxApplicant
            // 
            checkBoxApplicant.Anchor = AnchorStyles.Left;
            checkBoxApplicant.AutoSize = true;
            checkBoxApplicant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxApplicant.Location = new Point(195, 190);
            checkBoxApplicant.Name = "checkBoxApplicant";
            checkBoxApplicant.Size = new Size(118, 32);
            checkBoxApplicant.TabIndex = 7;
            checkBoxApplicant.Text = "Applicant";
            checkBoxApplicant.UseVisualStyleBackColor = true;
            checkBoxApplicant.CheckedChanged += checkBoxApplicant_CheckedChanged;
            // 
            // groupBoxFilter
            // 
            groupBoxFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxFilter.Controls.Add(tableLayoutPanel5);
            groupBoxFilter.Location = new Point(3, 324);
            groupBoxFilter.Margin = new Padding(3, 4, 3, 4);
            groupBoxFilter.Name = "groupBoxFilter";
            groupBoxFilter.Padding = new Padding(3, 4, 3, 4);
            groupBoxFilter.Size = new Size(399, 447);
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
            tableLayoutPanel5.Location = new Point(7, 29);
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 5;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Size = new Size(384, 420);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // checkBoxWithoutChildren
            // 
            checkBoxWithoutChildren.Anchor = AnchorStyles.Left;
            checkBoxWithoutChildren.AutoSize = true;
            checkBoxWithoutChildren.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxWithoutChildren.Location = new Point(195, 278);
            checkBoxWithoutChildren.Margin = new Padding(3, 4, 3, 4);
            checkBoxWithoutChildren.Name = "checkBoxWithoutChildren";
            checkBoxWithoutChildren.Size = new Size(184, 32);
            checkBoxWithoutChildren.TabIndex = 7;
            checkBoxWithoutChildren.Text = "Without Children";
            checkBoxWithoutChildren.UseVisualStyleBackColor = true;
            checkBoxWithoutChildren.CheckedChanged += checkBoxWithoutChildren_CheckedChanged;
            // 
            // buttonEditCustomFilter
            // 
            buttonEditCustomFilter.Anchor = AnchorStyles.Left;
            buttonEditCustomFilter.Location = new Point(195, 351);
            buttonEditCustomFilter.Margin = new Padding(3, 4, 3, 4);
            buttonEditCustomFilter.Name = "buttonEditCustomFilter";
            buttonEditCustomFilter.Size = new Size(137, 53);
            buttonEditCustomFilter.TabIndex = 9;
            buttonEditCustomFilter.Text = "Edit Custom Filter";
            buttonEditCustomFilter.UseVisualStyleBackColor = true;
            buttonEditCustomFilter.Click += buttonEditCustomFilter_Click;
            // 
            // checkBoxWithChildren
            // 
            checkBoxWithChildren.Anchor = AnchorStyles.Left;
            checkBoxWithChildren.AutoSize = true;
            checkBoxWithChildren.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxWithChildren.Location = new Point(3, 278);
            checkBoxWithChildren.Margin = new Padding(3, 4, 3, 4);
            checkBoxWithChildren.Name = "checkBoxWithChildren";
            checkBoxWithChildren.Size = new Size(154, 32);
            checkBoxWithChildren.TabIndex = 6;
            checkBoxWithChildren.Text = "With Children";
            checkBoxWithChildren.UseVisualStyleBackColor = true;
            checkBoxWithChildren.CheckedChanged += checkBoxWithChildren_CheckedChanged;
            // 
            // checkBoxUnemployed
            // 
            checkBoxUnemployed.Anchor = AnchorStyles.Left;
            checkBoxUnemployed.AutoSize = true;
            checkBoxUnemployed.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxUnemployed.Location = new Point(195, 194);
            checkBoxUnemployed.Margin = new Padding(3, 4, 3, 4);
            checkBoxUnemployed.Name = "checkBoxUnemployed";
            checkBoxUnemployed.Size = new Size(147, 32);
            checkBoxUnemployed.TabIndex = 5;
            checkBoxUnemployed.Text = "Unemployed";
            checkBoxUnemployed.UseVisualStyleBackColor = true;
            checkBoxUnemployed.CheckedChanged += checkBoxUnemployed_CheckedChanged;
            // 
            // checkBoxEmployed
            // 
            checkBoxEmployed.Anchor = AnchorStyles.Left;
            checkBoxEmployed.AutoSize = true;
            checkBoxEmployed.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxEmployed.Location = new Point(3, 194);
            checkBoxEmployed.Margin = new Padding(3, 4, 3, 4);
            checkBoxEmployed.Name = "checkBoxEmployed";
            checkBoxEmployed.Size = new Size(122, 32);
            checkBoxEmployed.TabIndex = 4;
            checkBoxEmployed.Text = "Employed";
            checkBoxEmployed.UseVisualStyleBackColor = true;
            checkBoxEmployed.CheckedChanged += checkBoxEmployed_CheckedChanged;
            // 
            // checkBoxMarried
            // 
            checkBoxMarried.Anchor = AnchorStyles.Left;
            checkBoxMarried.AutoSize = true;
            checkBoxMarried.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxMarried.Location = new Point(195, 110);
            checkBoxMarried.Margin = new Padding(3, 4, 3, 4);
            checkBoxMarried.Name = "checkBoxMarried";
            checkBoxMarried.Size = new Size(103, 32);
            checkBoxMarried.TabIndex = 3;
            checkBoxMarried.Text = "Married";
            checkBoxMarried.UseVisualStyleBackColor = true;
            checkBoxMarried.CheckedChanged += checkBoxMarried_CheckedChanged;
            // 
            // checkBoxSingle
            // 
            checkBoxSingle.Anchor = AnchorStyles.Left;
            checkBoxSingle.AutoSize = true;
            checkBoxSingle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSingle.Location = new Point(3, 110);
            checkBoxSingle.Margin = new Padding(3, 4, 3, 4);
            checkBoxSingle.Name = "checkBoxSingle";
            checkBoxSingle.Size = new Size(88, 32);
            checkBoxSingle.TabIndex = 2;
            checkBoxSingle.Text = "Single";
            checkBoxSingle.UseVisualStyleBackColor = true;
            checkBoxSingle.CheckedChanged += checkBoxSingle_CheckedChanged;
            // 
            // checkBoxAdultsAboveSixtyFive
            // 
            checkBoxAdultsAboveSixtyFive.Anchor = AnchorStyles.Left;
            checkBoxAdultsAboveSixtyFive.AutoSize = true;
            checkBoxAdultsAboveSixtyFive.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAdultsAboveSixtyFive.Location = new Point(195, 26);
            checkBoxAdultsAboveSixtyFive.Margin = new Padding(3, 4, 3, 4);
            checkBoxAdultsAboveSixtyFive.Name = "checkBoxAdultsAboveSixtyFive";
            checkBoxAdultsAboveSixtyFive.Size = new Size(179, 32);
            checkBoxAdultsAboveSixtyFive.TabIndex = 1;
            checkBoxAdultsAboveSixtyFive.Text = "Adults Above 65";
            checkBoxAdultsAboveSixtyFive.UseVisualStyleBackColor = true;
            checkBoxAdultsAboveSixtyFive.CheckedChanged += checkBoxAdultsAboveSixtyFive_CheckedChanged;
            // 
            // checkBoxAdultsBelowSixtyFive
            // 
            checkBoxAdultsBelowSixtyFive.Anchor = AnchorStyles.Left;
            checkBoxAdultsBelowSixtyFive.AutoSize = true;
            checkBoxAdultsBelowSixtyFive.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAdultsBelowSixtyFive.Location = new Point(3, 26);
            checkBoxAdultsBelowSixtyFive.Margin = new Padding(3, 4, 3, 4);
            checkBoxAdultsBelowSixtyFive.Name = "checkBoxAdultsBelowSixtyFive";
            checkBoxAdultsBelowSixtyFive.Size = new Size(174, 32);
            checkBoxAdultsBelowSixtyFive.TabIndex = 0;
            checkBoxAdultsBelowSixtyFive.Text = "Adults Below 65";
            checkBoxAdultsBelowSixtyFive.UseVisualStyleBackColor = true;
            checkBoxAdultsBelowSixtyFive.CheckedChanged += checkBoxAdultsBelowSixtyFive_CheckedChanged;
            // 
            // checkBoxUseCustomFilter
            // 
            checkBoxUseCustomFilter.Anchor = AnchorStyles.Left;
            checkBoxUseCustomFilter.AutoSize = true;
            checkBoxUseCustomFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxUseCustomFilter.Location = new Point(3, 362);
            checkBoxUseCustomFilter.Margin = new Padding(3, 4, 3, 4);
            checkBoxUseCustomFilter.Name = "checkBoxUseCustomFilter";
            checkBoxUseCustomFilter.Size = new Size(186, 32);
            checkBoxUseCustomFilter.TabIndex = 8;
            checkBoxUseCustomFilter.Text = "Use Custom Filter";
            checkBoxUseCustomFilter.UseVisualStyleBackColor = true;
            checkBoxUseCustomFilter.CheckedChanged += checkBoxUseCustomFilter_CheckedChanged;
            // 
            // tabControlListOfApps
            // 
            tabControlListOfApps.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlListOfApps.Controls.Add(tabApplications);
            tabControlListOfApps.Controls.Add(tabApplicants);
            tabControlListOfApps.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlListOfApps.Location = new Point(3, 4);
            tabControlListOfApps.Margin = new Padding(3, 4, 3, 4);
            tabControlListOfApps.Name = "tabControlListOfApps";
            tabControlListOfApps.SelectedIndex = 0;
            tabControlListOfApps.Size = new Size(566, 775);
            tabControlListOfApps.TabIndex = 1;
            // 
            // tabApplications
            // 
            tabApplications.Controls.Add(dataGridViewApps);
            tabApplications.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabApplications.Location = new Point(4, 37);
            tabApplications.Margin = new Padding(3, 4, 3, 4);
            tabApplications.Name = "tabApplications";
            tabApplications.Padding = new Padding(3, 4, 3, 4);
            tabApplications.Size = new Size(558, 734);
            tabApplications.TabIndex = 0;
            tabApplications.Text = "Applications";
            tabApplications.UseVisualStyleBackColor = true;
            // 
            // dataGridViewApps
            // 
            dataGridViewApps.AllowUserToAddRows = false;
            dataGridViewApps.AllowUserToDeleteRows = false;
            dataGridViewApps.AllowUserToResizeRows = false;
            dataGridViewApps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewApps.Dock = DockStyle.Fill;
            dataGridViewApps.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewApps.Location = new Point(3, 4);
            dataGridViewApps.Name = "dataGridViewApps";
            dataGridViewApps.ReadOnly = true;
            dataGridViewApps.RowHeadersVisible = false;
            dataGridViewApps.RowHeadersWidth = 51;
            dataGridViewApps.RowTemplate.Height = 29;
            dataGridViewApps.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewApps.Size = new Size(552, 726);
            dataGridViewApps.TabIndex = 0;
            dataGridViewApps.CellClick += dataGridViewApps_CellClick;
            dataGridViewApps.CellDoubleClick += dataGridViewApps_CellDoubleClick;
            dataGridViewApps.CellMouseLeave += dataGridViewApps_CellMouseLeave;
            // 
            // tabApplicants
            // 
            tabApplicants.Controls.Add(dataGridViewPeople);
            tabApplicants.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabApplicants.Location = new Point(4, 37);
            tabApplicants.Margin = new Padding(3, 4, 3, 4);
            tabApplicants.Name = "tabApplicants";
            tabApplicants.Padding = new Padding(3, 4, 3, 4);
            tabApplicants.Size = new Size(558, 734);
            tabApplicants.TabIndex = 1;
            tabApplicants.Text = "Applicants";
            tabApplicants.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPeople
            // 
            dataGridViewPeople.AllowUserToAddRows = false;
            dataGridViewPeople.AllowUserToDeleteRows = false;
            dataGridViewPeople.AllowUserToResizeRows = false;
            dataGridViewPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPeople.Dock = DockStyle.Fill;
            dataGridViewPeople.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewPeople.Location = new Point(3, 4);
            dataGridViewPeople.Name = "dataGridViewPeople";
            dataGridViewPeople.ReadOnly = true;
            dataGridViewPeople.RowHeadersVisible = false;
            dataGridViewPeople.RowHeadersWidth = 51;
            dataGridViewPeople.RowTemplate.Height = 29;
            dataGridViewPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPeople.Size = new Size(552, 726);
            dataGridViewPeople.TabIndex = 0;
            dataGridViewPeople.CellDoubleClick += dataGridViewPeople_CellDoubleClick;
            // 
            // ListOfAppsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 815);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
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
            tabApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewApps).EndInit();
            tabApplicants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPeople).EndInit();
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
        private DataGridView dataGridViewApps;
        private DataGridView dataGridViewPeople;
        private CheckBox checkBoxApplicant;
    }
}