namespace WelfareApp
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
            button1 = new Button();
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
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(692, 619);
            button1.Name = "button1";
            button1.Size = new Size(180, 30);
            button1.TabIndex = 0;
            button1.Text = "Create New Application";
            button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBoxApplicantInformation, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(860, 601);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBoxAdministrativeInformation, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBoxDocumentsReceived, 0, 1);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(381, 595);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBoxAdministrativeInformation
            // 
            groupBoxAdministrativeInformation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxAdministrativeInformation.Controls.Add(tableLayoutPanel3);
            groupBoxAdministrativeInformation.Location = new Point(3, 3);
            groupBoxAdministrativeInformation.Name = "groupBoxAdministrativeInformation";
            groupBoxAdministrativeInformation.Size = new Size(375, 244);
            groupBoxAdministrativeInformation.TabIndex = 0;
            groupBoxAdministrativeInformation.TabStop = false;
            groupBoxAdministrativeInformation.Text = "Administrative Information";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
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
            tableLayoutPanel3.Location = new Point(6, 22);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(363, 216);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // labelProgramText
            // 
            labelProgramText.Anchor = AnchorStyles.Right;
            labelProgramText.AutoSize = true;
            labelProgramText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelProgramText.Location = new Point(43, 14);
            labelProgramText.Name = "labelProgramText";
            labelProgramText.Size = new Size(74, 21);
            labelProgramText.TabIndex = 0;
            labelProgramText.Text = "Program:";
            // 
            // labelAgentText
            // 
            labelAgentText.Anchor = AnchorStyles.Right;
            labelAgentText.AutoSize = true;
            labelAgentText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAgentText.Location = new Point(63, 83);
            labelAgentText.Name = "labelAgentText";
            labelAgentText.Size = new Size(54, 21);
            labelAgentText.TabIndex = 1;
            labelAgentText.Text = "Agent:";
            // 
            // labelOfficeText
            // 
            labelOfficeText.Anchor = AnchorStyles.Right;
            labelOfficeText.AutoSize = true;
            labelOfficeText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelOfficeText.Location = new Point(63, 132);
            labelOfficeText.Name = "labelOfficeText";
            labelOfficeText.Size = new Size(54, 21);
            labelOfficeText.TabIndex = 2;
            labelOfficeText.Text = "Office:";
            // 
            // labelSupervisorText
            // 
            labelSupervisorText.Anchor = AnchorStyles.Right;
            labelSupervisorText.AutoSize = true;
            labelSupervisorText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSupervisorText.Location = new Point(29, 181);
            labelSupervisorText.Name = "labelSupervisorText";
            labelSupervisorText.Size = new Size(88, 21);
            labelSupervisorText.TabIndex = 3;
            labelSupervisorText.Text = "Supervisor:";
            // 
            // comboBoxProgramValue
            // 
            comboBoxProgramValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxProgramValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxProgramValue.FormattingEnabled = true;
            comboBoxProgramValue.Location = new Point(123, 10);
            comboBoxProgramValue.Name = "comboBoxProgramValue";
            comboBoxProgramValue.Size = new Size(237, 29);
            comboBoxProgramValue.TabIndex = 4;
            // 
            // comboBoxAgentValue
            // 
            comboBoxAgentValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxAgentValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxAgentValue.FormattingEnabled = true;
            comboBoxAgentValue.Location = new Point(123, 79);
            comboBoxAgentValue.Name = "comboBoxAgentValue";
            comboBoxAgentValue.Size = new Size(237, 29);
            comboBoxAgentValue.TabIndex = 5;
            // 
            // comboBoxOfficeValue
            // 
            comboBoxOfficeValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxOfficeValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxOfficeValue.FormattingEnabled = true;
            comboBoxOfficeValue.Location = new Point(123, 128);
            comboBoxOfficeValue.Name = "comboBoxOfficeValue";
            comboBoxOfficeValue.Size = new Size(237, 29);
            comboBoxOfficeValue.TabIndex = 6;
            // 
            // comboBoxSupervisorValue
            // 
            comboBoxSupervisorValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSupervisorValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSupervisorValue.FormattingEnabled = true;
            comboBoxSupervisorValue.Location = new Point(123, 177);
            comboBoxSupervisorValue.Name = "comboBoxSupervisorValue";
            comboBoxSupervisorValue.Size = new Size(237, 29);
            comboBoxSupervisorValue.TabIndex = 7;
            // 
            // labelReceivedByText
            // 
            labelReceivedByText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelReceivedByText.AutoSize = true;
            labelReceivedByText.Location = new Point(3, 54);
            labelReceivedByText.Name = "labelReceivedByText";
            labelReceivedByText.Size = new Size(70, 15);
            labelReceivedByText.TabIndex = 8;
            labelReceivedByText.Text = "Received By";
            // 
            // groupBoxDocumentsReceived
            // 
            groupBoxDocumentsReceived.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxDocumentsReceived.Controls.Add(tableLayoutPanel4);
            groupBoxDocumentsReceived.Location = new Point(3, 253);
            groupBoxDocumentsReceived.Name = "groupBoxDocumentsReceived";
            groupBoxDocumentsReceived.Size = new Size(375, 339);
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
            tableLayoutPanel4.Location = new Point(9, 22);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel4.Size = new Size(360, 311);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(buttonDeselectAll);
            panel1.Controls.Add(buttonSelectAll);
            panel1.Location = new Point(164, 269);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 39);
            panel1.TabIndex = 0;
            // 
            // buttonDeselectAll
            // 
            buttonDeselectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDeselectAll.Location = new Point(100, 6);
            buttonDeselectAll.Name = "buttonDeselectAll";
            buttonDeselectAll.Size = new Size(90, 30);
            buttonDeselectAll.TabIndex = 2;
            buttonDeselectAll.Text = "Deselect All";
            buttonDeselectAll.UseVisualStyleBackColor = true;
            // 
            // buttonSelectAll
            // 
            buttonSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSelectAll.Location = new Point(4, 6);
            buttonSelectAll.Name = "buttonSelectAll";
            buttonSelectAll.Size = new Size(90, 30);
            buttonSelectAll.TabIndex = 1;
            buttonSelectAll.Text = "Select All";
            buttonSelectAll.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxListOfDocumentsReceived
            // 
            checkedListBoxListOfDocumentsReceived.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkedListBoxListOfDocumentsReceived.FormattingEnabled = true;
            checkedListBoxListOfDocumentsReceived.Location = new Point(3, 3);
            checkedListBoxListOfDocumentsReceived.Name = "checkedListBoxListOfDocumentsReceived";
            checkedListBoxListOfDocumentsReceived.Size = new Size(354, 256);
            checkedListBoxListOfDocumentsReceived.TabIndex = 1;
            // 
            // groupBoxApplicantInformation
            // 
            groupBoxApplicantInformation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxApplicantInformation.Controls.Add(tableLayoutPanel5);
            groupBoxApplicantInformation.Location = new Point(390, 3);
            groupBoxApplicantInformation.Name = "groupBoxApplicantInformation";
            groupBoxApplicantInformation.Size = new Size(467, 595);
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
            tableLayoutPanel5.Location = new Point(6, 22);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(455, 570);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonLoadApplicantData);
            panel2.Controls.Add(labelApplicantIdValue);
            panel2.Controls.Add(labelApplicantIdText);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 80);
            panel2.TabIndex = 0;
            // 
            // buttonLoadApplicantData
            // 
            buttonLoadApplicantData.Location = new Point(171, 31);
            buttonLoadApplicantData.Name = "buttonLoadApplicantData";
            buttonLoadApplicantData.Size = new Size(146, 23);
            buttonLoadApplicantData.TabIndex = 2;
            buttonLoadApplicantData.Text = "Load Applicant Data";
            buttonLoadApplicantData.UseVisualStyleBackColor = true;
            buttonLoadApplicantData.Click += buttonLoadApplicantData_Click;
            // 
            // labelApplicantIdValue
            // 
            labelApplicantIdValue.AutoSize = true;
            labelApplicantIdValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelApplicantIdValue.Location = new Point(3, 31);
            labelApplicantIdValue.Name = "labelApplicantIdValue";
            labelApplicantIdValue.Size = new Size(153, 21);
            labelApplicantIdValue.TabIndex = 1;
            labelApplicantIdValue.Text = ">applicant id value<";
            // 
            // labelApplicantIdText
            // 
            labelApplicantIdText.AutoSize = true;
            labelApplicantIdText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelApplicantIdText.Location = new Point(3, 10);
            labelApplicantIdText.Name = "labelApplicantIdText";
            labelApplicantIdText.Size = new Size(97, 21);
            labelApplicantIdText.TabIndex = 0;
            labelApplicantIdText.Text = "Applicant ID:";
            // 
            // panelPlaceholder
            // 
            panelPlaceholder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPlaceholder.Location = new Point(3, 103);
            panelPlaceholder.Name = "panelPlaceholder";
            panelPlaceholder.Size = new Size(449, 464);
            panelPlaceholder.TabIndex = 1;
            // 
            // CreateNewApplicationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 661);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button1);
            Name = "CreateNewApplicationForm";
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

        private Button button1;
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