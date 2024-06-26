﻿namespace WelfareApp
{
    partial class CreateNewApplicationForm
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
            buttonCreateNewApplication = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBoxAdministrativeInformation = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            labelProgramText = new Label();
            labelAgentText = new Label();
            labelOfficeText = new Label();
            labelSupervisorText = new Label();
            comboBoxProgramValue = new ComboBox();
            comboBoxAgentValue = new ComboBox();
            comboBoxOfficeValue = new ComboBox();
            comboBoxSupervisorValue = new ComboBox();
            labelReceivedByText = new Label();
            groupBoxDocumentsReceived = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel1 = new Panel();
            buttonDeselectAll = new Button();
            buttonSelectAll = new Button();
            checkedListBoxListOfDocumentsReceived = new CheckedListBox();
            groupBoxApplicantInformation = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel2 = new Panel();
            buttonLoadApplicantData = new Button();
            labelApplicantIdValue = new Label();
            labelApplicantIdText = new Label();
            panelPlaceholder = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBoxAdministrativeInformation.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBoxDocumentsReceived.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel1.SuspendLayout();
            groupBoxApplicantInformation.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCreateNewApplication
            // 
            buttonCreateNewApplication.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCreateNewApplication.Location = new Point(791, 825);
            buttonCreateNewApplication.Margin = new Padding(3, 4, 3, 4);
            buttonCreateNewApplication.Name = "buttonCreateNewApplication";
            buttonCreateNewApplication.Size = new Size(206, 40);
            buttonCreateNewApplication.TabIndex = 0;
            buttonCreateNewApplication.Text = "Create New Application";
            buttonCreateNewApplication.UseVisualStyleBackColor = true;
            buttonCreateNewApplication.Click += buttonCreateNewApplication_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBoxApplicantInformation, 1, 0);
            tableLayoutPanel1.Location = new Point(14, 16);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(983, 801);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBoxAdministrativeInformation, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBoxDocumentsReceived, 0, 1);
            tableLayoutPanel2.Location = new Point(3, 4);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(436, 793);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBoxAdministrativeInformation
            // 
            groupBoxAdministrativeInformation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxAdministrativeInformation.Controls.Add(tableLayoutPanel3);
            groupBoxAdministrativeInformation.Location = new Point(3, 4);
            groupBoxAdministrativeInformation.Margin = new Padding(3, 4, 3, 4);
            groupBoxAdministrativeInformation.Name = "groupBoxAdministrativeInformation";
            groupBoxAdministrativeInformation.Padding = new Padding(3, 4, 3, 4);
            groupBoxAdministrativeInformation.Size = new Size(430, 325);
            groupBoxAdministrativeInformation.TabIndex = 0;
            groupBoxAdministrativeInformation.TabStop = false;
            groupBoxAdministrativeInformation.Text = "Administrative Information";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(labelProgramText, 0, 0);
            tableLayoutPanel3.Controls.Add(labelAgentText, 0, 2);
            tableLayoutPanel3.Controls.Add(labelOfficeText, 0, 3);
            tableLayoutPanel3.Controls.Add(labelSupervisorText, 0, 4);
            tableLayoutPanel3.Controls.Add(comboBoxProgramValue, 1, 0);
            tableLayoutPanel3.Controls.Add(comboBoxAgentValue, 1, 2);
            tableLayoutPanel3.Controls.Add(comboBoxOfficeValue, 1, 3);
            tableLayoutPanel3.Controls.Add(comboBoxSupervisorValue, 1, 4);
            tableLayoutPanel3.Controls.Add(labelReceivedByText, 0, 1);
            tableLayoutPanel3.Location = new Point(7, 29);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(416, 288);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // labelProgramText
            // 
            labelProgramText.Anchor = AnchorStyles.Right;
            labelProgramText.AutoSize = true;
            labelProgramText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelProgramText.Location = new Point(42, 18);
            labelProgramText.Name = "labelProgramText";
            labelProgramText.Size = new Size(92, 28);
            labelProgramText.TabIndex = 0;
            labelProgramText.Text = "Program:";
            // 
            // labelAgentText
            // 
            labelAgentText.Anchor = AnchorStyles.Right;
            labelAgentText.AutoSize = true;
            labelAgentText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAgentText.Location = new Point(65, 110);
            labelAgentText.Name = "labelAgentText";
            labelAgentText.Size = new Size(69, 28);
            labelAgentText.TabIndex = 1;
            labelAgentText.Text = "Agent:";
            // 
            // labelOfficeText
            // 
            labelOfficeText.Anchor = AnchorStyles.Right;
            labelOfficeText.AutoSize = true;
            labelOfficeText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelOfficeText.Location = new Point(67, 175);
            labelOfficeText.Name = "labelOfficeText";
            labelOfficeText.Size = new Size(67, 28);
            labelOfficeText.TabIndex = 2;
            labelOfficeText.Text = "Office:";
            // 
            // labelSupervisorText
            // 
            labelSupervisorText.Anchor = AnchorStyles.Right;
            labelSupervisorText.AutoSize = true;
            labelSupervisorText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSupervisorText.Location = new Point(25, 241);
            labelSupervisorText.Name = "labelSupervisorText";
            labelSupervisorText.Size = new Size(109, 28);
            labelSupervisorText.TabIndex = 3;
            labelSupervisorText.Text = "Supervisor:";
            // 
            // comboBoxProgramValue
            // 
            comboBoxProgramValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxProgramValue.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProgramValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxProgramValue.FormattingEnabled = true;
            comboBoxProgramValue.Location = new Point(140, 14);
            comboBoxProgramValue.Margin = new Padding(3, 4, 3, 4);
            comboBoxProgramValue.Name = "comboBoxProgramValue";
            comboBoxProgramValue.Size = new Size(273, 36);
            comboBoxProgramValue.TabIndex = 4;
            comboBoxProgramValue.SelectedIndexChanged += comboBoxProgramValue_SelectedIndexChanged;
            // 
            // comboBoxAgentValue
            // 
            comboBoxAgentValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxAgentValue.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAgentValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxAgentValue.FormattingEnabled = true;
            comboBoxAgentValue.Location = new Point(140, 106);
            comboBoxAgentValue.Margin = new Padding(3, 4, 3, 4);
            comboBoxAgentValue.Name = "comboBoxAgentValue";
            comboBoxAgentValue.Size = new Size(273, 36);
            comboBoxAgentValue.TabIndex = 5;
            // 
            // comboBoxOfficeValue
            // 
            comboBoxOfficeValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxOfficeValue.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOfficeValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxOfficeValue.FormattingEnabled = true;
            comboBoxOfficeValue.Location = new Point(140, 171);
            comboBoxOfficeValue.Margin = new Padding(3, 4, 3, 4);
            comboBoxOfficeValue.Name = "comboBoxOfficeValue";
            comboBoxOfficeValue.Size = new Size(273, 36);
            comboBoxOfficeValue.TabIndex = 6;
            // 
            // comboBoxSupervisorValue
            // 
            comboBoxSupervisorValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSupervisorValue.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSupervisorValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSupervisorValue.FormattingEnabled = true;
            comboBoxSupervisorValue.Location = new Point(140, 237);
            comboBoxSupervisorValue.Margin = new Padding(3, 4, 3, 4);
            comboBoxSupervisorValue.Name = "comboBoxSupervisorValue";
            comboBoxSupervisorValue.Size = new Size(273, 36);
            comboBoxSupervisorValue.TabIndex = 7;
            // 
            // labelReceivedByText
            // 
            labelReceivedByText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelReceivedByText.AutoSize = true;
            labelReceivedByText.Location = new Point(3, 72);
            labelReceivedByText.Name = "labelReceivedByText";
            labelReceivedByText.Size = new Size(89, 20);
            labelReceivedByText.TabIndex = 8;
            labelReceivedByText.Text = "Received By";
            // 
            // groupBoxDocumentsReceived
            // 
            groupBoxDocumentsReceived.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxDocumentsReceived.Controls.Add(tableLayoutPanel4);
            groupBoxDocumentsReceived.Location = new Point(3, 337);
            groupBoxDocumentsReceived.Margin = new Padding(3, 4, 3, 4);
            groupBoxDocumentsReceived.Name = "groupBoxDocumentsReceived";
            groupBoxDocumentsReceived.Padding = new Padding(3, 4, 3, 4);
            groupBoxDocumentsReceived.Size = new Size(430, 452);
            groupBoxDocumentsReceived.TabIndex = 1;
            groupBoxDocumentsReceived.TabStop = false;
            groupBoxDocumentsReceived.Text = "Documents Received";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(panel1, 0, 1);
            tableLayoutPanel4.Controls.Add(checkedListBoxListOfDocumentsReceived, 0, 0);
            tableLayoutPanel4.Location = new Point(10, 29);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel4.Size = new Size(412, 415);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(buttonDeselectAll);
            panel1.Controls.Add(buttonSelectAll);
            panel1.Location = new Point(188, 359);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 52);
            panel1.TabIndex = 0;
            // 
            // buttonDeselectAll
            // 
            buttonDeselectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDeselectAll.Location = new Point(114, 8);
            buttonDeselectAll.Margin = new Padding(3, 4, 3, 4);
            buttonDeselectAll.Name = "buttonDeselectAll";
            buttonDeselectAll.Size = new Size(103, 40);
            buttonDeselectAll.TabIndex = 2;
            buttonDeselectAll.Text = "Deselect All";
            buttonDeselectAll.UseVisualStyleBackColor = true;
            buttonDeselectAll.Click += buttonDeselectAll_Click;
            // 
            // buttonSelectAll
            // 
            buttonSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSelectAll.Location = new Point(5, 8);
            buttonSelectAll.Margin = new Padding(3, 4, 3, 4);
            buttonSelectAll.Name = "buttonSelectAll";
            buttonSelectAll.Size = new Size(103, 40);
            buttonSelectAll.TabIndex = 1;
            buttonSelectAll.Text = "Select All";
            buttonSelectAll.UseVisualStyleBackColor = true;
            buttonSelectAll.Click += buttonSelectAll_Click;
            // 
            // checkedListBoxListOfDocumentsReceived
            // 
            checkedListBoxListOfDocumentsReceived.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkedListBoxListOfDocumentsReceived.CheckOnClick = true;
            checkedListBoxListOfDocumentsReceived.FormattingEnabled = true;
            checkedListBoxListOfDocumentsReceived.Location = new Point(3, 4);
            checkedListBoxListOfDocumentsReceived.Margin = new Padding(3, 4, 3, 4);
            checkedListBoxListOfDocumentsReceived.Name = "checkedListBoxListOfDocumentsReceived";
            checkedListBoxListOfDocumentsReceived.Size = new Size(406, 334);
            checkedListBoxListOfDocumentsReceived.TabIndex = 1;
            // 
            // groupBoxApplicantInformation
            // 
            groupBoxApplicantInformation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxApplicantInformation.Controls.Add(tableLayoutPanel5);
            groupBoxApplicantInformation.Location = new Point(445, 4);
            groupBoxApplicantInformation.Margin = new Padding(3, 4, 3, 4);
            groupBoxApplicantInformation.Name = "groupBoxApplicantInformation";
            groupBoxApplicantInformation.Padding = new Padding(3, 4, 3, 4);
            groupBoxApplicantInformation.Size = new Size(535, 793);
            groupBoxApplicantInformation.TabIndex = 1;
            groupBoxApplicantInformation.TabStop = false;
            groupBoxApplicantInformation.Text = "Applicant Information";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(panel2, 0, 0);
            tableLayoutPanel5.Controls.Add(panelPlaceholder, 0, 1);
            tableLayoutPanel5.Location = new Point(7, 29);
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 133F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(521, 760);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonLoadApplicantData);
            panel2.Controls.Add(labelApplicantIdValue);
            panel2.Controls.Add(labelApplicantIdText);
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 107);
            panel2.TabIndex = 0;
            // 
            // buttonLoadApplicantData
            // 
            buttonLoadApplicantData.Location = new Point(195, 41);
            buttonLoadApplicantData.Margin = new Padding(3, 4, 3, 4);
            buttonLoadApplicantData.Name = "buttonLoadApplicantData";
            buttonLoadApplicantData.Size = new Size(167, 31);
            buttonLoadApplicantData.TabIndex = 2;
            buttonLoadApplicantData.Text = "Load Applicant Data";
            buttonLoadApplicantData.UseVisualStyleBackColor = true;
            buttonLoadApplicantData.Click += buttonLoadApplicantData_Click;
            // 
            // labelApplicantIdValue
            // 
            labelApplicantIdValue.AutoSize = true;
            labelApplicantIdValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelApplicantIdValue.Location = new Point(3, 41);
            labelApplicantIdValue.Name = "labelApplicantIdValue";
            labelApplicantIdValue.Size = new Size(194, 28);
            labelApplicantIdValue.TabIndex = 1;
            labelApplicantIdValue.Text = ">applicant id value<";
            // 
            // labelApplicantIdText
            // 
            labelApplicantIdText.AutoSize = true;
            labelApplicantIdText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelApplicantIdText.Location = new Point(3, 13);
            labelApplicantIdText.Name = "labelApplicantIdText";
            labelApplicantIdText.Size = new Size(124, 28);
            labelApplicantIdText.TabIndex = 0;
            labelApplicantIdText.Text = "Applicant ID:";
            // 
            // panelPlaceholder
            // 
            panelPlaceholder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPlaceholder.Location = new Point(3, 137);
            panelPlaceholder.Margin = new Padding(3, 4, 3, 4);
            panelPlaceholder.Name = "panelPlaceholder";
            panelPlaceholder.Size = new Size(515, 619);
            panelPlaceholder.TabIndex = 1;
            // 
            // CreateNewApplicationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 881);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonCreateNewApplication);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateNewApplicationForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CreateNewApplicationForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBoxAdministrativeInformation.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupBoxDocumentsReceived.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBoxApplicantInformation.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCreateNewApplication;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBoxAdministrativeInformation;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelProgramText;
        private Label labelAgentText;
        private Label labelOfficeText;
        private GroupBox groupBoxDocumentsReceived;
        private Label labelSupervisorText;
        private ComboBox comboBoxProgramValue;
        private ComboBox comboBoxAgentValue;
        private ComboBox comboBoxOfficeValue;
        private ComboBox comboBoxSupervisorValue;
        private Label labelReceivedByText;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel1;
        private Button buttonDeselectAll;
        private Button buttonSelectAll;
        private CheckedListBox checkedListBoxListOfDocumentsReceived;
        private GroupBox groupBoxApplicantInformation;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel2;
        private Button buttonLoadApplicantData;
        private Label labelApplicantIdValue;
        private Label labelApplicantIdText;
        private Panel panelPlaceholder;
    }
}