namespace WelfareApp
{
    partial class CreateNewProgramForm
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
            groupBoxAdministrativeInformation = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            comboBoxSupervisorValue = new ComboBox();
            labelAgentText = new Label();
            labelOfficeText = new Label();
            labelSupervisorText = new Label();
            labelAgentNameValue = new Label();
            comboBoxOfficeValue = new ComboBox();
            groupBoxConfirmDetails = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            labelSummaryText = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            buttonCreateProgram = new Button();
            richTextBoxSummary = new RichTextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            groupBoxBasicInformation = new GroupBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            labelProgramNameText = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            labelManagingAgencyText = new Label();
            panel1 = new Panel();
            labelSearchCodeText = new Label();
            textBoxSearchCodeValue = new TextBox();
            panel2 = new Panel();
            textBoxProgramNameValue = new TextBox();
            panel3 = new Panel();
            comboBoxManagingAgencyValue = new ComboBox();
            groupBoxRequiredDocuments = new GroupBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            panel4 = new Panel();
            buttonDeselectAll = new Button();
            buttonSelectAll = new Button();
            checkedListBoxListOfRequiredDocuments = new CheckedListBox();
            groupBoxPaymentInformation = new GroupBox();
            tableLayoutPanel10 = new TableLayoutPanel();
            tableLayoutPanel11 = new TableLayoutPanel();
            labelPaymentTypeText = new Label();
            comboBoxPaymentTypeValue = new ComboBox();
            panel5 = new Panel();
            radioButtonPercentagePayment = new RadioButton();
            radioButtonFlatPayment = new RadioButton();
            tableLayoutPanel12 = new TableLayoutPanel();
            textBoxMaxPaymentValue = new TextBox();
            labelPaymentAmountText = new Label();
            labelMinPaymentText = new Label();
            labelMaxPaymentText = new Label();
            textBoxMinPaymentValue = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBoxAdministrativeInformation.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBoxConfirmDetails.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            groupBoxBasicInformation.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxRequiredDocuments.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            panel4.SuspendLayout();
            groupBoxPaymentInformation.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(860, 637);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBoxAdministrativeInformation, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBoxConfirmDetails, 0, 1);
            tableLayoutPanel2.Location = new Point(476, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.Size = new Size(381, 631);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBoxAdministrativeInformation
            // 
            groupBoxAdministrativeInformation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxAdministrativeInformation.Controls.Add(tableLayoutPanel3);
            groupBoxAdministrativeInformation.Location = new Point(3, 3);
            groupBoxAdministrativeInformation.Name = "groupBoxAdministrativeInformation";
            groupBoxAdministrativeInformation.Size = new Size(375, 120);
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
            tableLayoutPanel3.Controls.Add(comboBoxSupervisorValue, 1, 2);
            tableLayoutPanel3.Controls.Add(labelAgentText, 0, 0);
            tableLayoutPanel3.Controls.Add(labelOfficeText, 0, 1);
            tableLayoutPanel3.Controls.Add(labelSupervisorText, 0, 2);
            tableLayoutPanel3.Controls.Add(labelAgentNameValue, 1, 0);
            tableLayoutPanel3.Controls.Add(comboBoxOfficeValue, 1, 1);
            tableLayoutPanel3.Location = new Point(-3, 22);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(381, 98);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // comboBoxSupervisorValue
            // 
            comboBoxSupervisorValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSupervisorValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSupervisorValue.FormattingEnabled = true;
            comboBoxSupervisorValue.Location = new Point(123, 67);
            comboBoxSupervisorValue.Name = "comboBoxSupervisorValue";
            comboBoxSupervisorValue.Size = new Size(255, 29);
            comboBoxSupervisorValue.TabIndex = 5;
            // 
            // labelAgentText
            // 
            labelAgentText.Anchor = AnchorStyles.Right;
            labelAgentText.AutoSize = true;
            labelAgentText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAgentText.Location = new Point(63, 5);
            labelAgentText.Name = "labelAgentText";
            labelAgentText.Size = new Size(54, 21);
            labelAgentText.TabIndex = 0;
            labelAgentText.Text = "Agent:";
            // 
            // labelOfficeText
            // 
            labelOfficeText.Anchor = AnchorStyles.Right;
            labelOfficeText.AutoSize = true;
            labelOfficeText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelOfficeText.Location = new Point(63, 37);
            labelOfficeText.Name = "labelOfficeText";
            labelOfficeText.Size = new Size(54, 21);
            labelOfficeText.TabIndex = 1;
            labelOfficeText.Text = "Office:";
            // 
            // labelSupervisorText
            // 
            labelSupervisorText.Anchor = AnchorStyles.Right;
            labelSupervisorText.AutoSize = true;
            labelSupervisorText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSupervisorText.Location = new Point(29, 70);
            labelSupervisorText.Name = "labelSupervisorText";
            labelSupervisorText.Size = new Size(88, 21);
            labelSupervisorText.TabIndex = 2;
            labelSupervisorText.Text = "Supervisor:";
            // 
            // labelAgentNameValue
            // 
            labelAgentNameValue.Anchor = AnchorStyles.Left;
            labelAgentNameValue.AutoSize = true;
            labelAgentNameValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAgentNameValue.Location = new Point(123, 5);
            labelAgentNameValue.Name = "labelAgentNameValue";
            labelAgentNameValue.Size = new Size(155, 21);
            labelAgentNameValue.TabIndex = 3;
            labelAgentNameValue.Text = ">agent name value<";
            // 
            // comboBoxOfficeValue
            // 
            comboBoxOfficeValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxOfficeValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxOfficeValue.FormattingEnabled = true;
            comboBoxOfficeValue.Location = new Point(123, 35);
            comboBoxOfficeValue.Name = "comboBoxOfficeValue";
            comboBoxOfficeValue.Size = new Size(255, 29);
            comboBoxOfficeValue.TabIndex = 4;
            // 
            // groupBoxConfirmDetails
            // 
            groupBoxConfirmDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxConfirmDetails.Controls.Add(tableLayoutPanel4);
            groupBoxConfirmDetails.Location = new Point(3, 129);
            groupBoxConfirmDetails.Name = "groupBoxConfirmDetails";
            groupBoxConfirmDetails.Size = new Size(375, 499);
            groupBoxConfirmDetails.TabIndex = 1;
            groupBoxConfirmDetails.TabStop = false;
            groupBoxConfirmDetails.Text = "Confirm Details";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(labelSummaryText, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Location = new Point(6, 22);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(363, 471);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // labelSummaryText
            // 
            labelSummaryText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSummaryText.AutoSize = true;
            labelSummaryText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSummaryText.Location = new Point(3, 19);
            labelSummaryText.Name = "labelSummaryText";
            labelSummaryText.Size = new Size(78, 21);
            labelSummaryText.TabIndex = 0;
            labelSummaryText.Text = "Summary";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tableLayoutPanel5.Controls.Add(buttonCreateProgram, 1, 0);
            tableLayoutPanel5.Controls.Add(richTextBoxSummary, 0, 0);
            tableLayoutPanel5.Location = new Point(3, 43);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(357, 425);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // buttonCreateProgram
            // 
            buttonCreateProgram.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCreateProgram.Location = new Point(265, 377);
            buttonCreateProgram.Name = "buttonCreateProgram";
            buttonCreateProgram.Size = new Size(89, 45);
            buttonCreateProgram.TabIndex = 0;
            buttonCreateProgram.Text = "Create Program";
            buttonCreateProgram.UseVisualStyleBackColor = true;
            buttonCreateProgram.Click += buttonCreateProgram_Click;
            // 
            // richTextBoxSummary
            // 
            richTextBoxSummary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxSummary.BackColor = SystemColors.Control;
            richTextBoxSummary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxSummary.Location = new Point(3, 3);
            richTextBoxSummary.Name = "richTextBoxSummary";
            richTextBoxSummary.Size = new Size(256, 419);
            richTextBoxSummary.TabIndex = 1;
            richTextBoxSummary.Text = "";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(groupBoxBasicInformation, 0, 0);
            tableLayoutPanel6.Controls.Add(groupBoxRequiredDocuments, 0, 1);
            tableLayoutPanel6.Controls.Add(groupBoxPaymentInformation, 0, 2);
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel6.Size = new Size(467, 631);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // groupBoxBasicInformation
            // 
            groupBoxBasicInformation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxBasicInformation.Controls.Add(tableLayoutPanel7);
            groupBoxBasicInformation.Location = new Point(3, 3);
            groupBoxBasicInformation.Name = "groupBoxBasicInformation";
            groupBoxBasicInformation.Size = new Size(461, 214);
            groupBoxBasicInformation.TabIndex = 0;
            groupBoxBasicInformation.TabStop = false;
            groupBoxBasicInformation.Text = "Basic Information";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(labelProgramNameText, 0, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 0, 2);
            tableLayoutPanel7.Controls.Add(panel2, 0, 1);
            tableLayoutPanel7.Controls.Add(panel3, 0, 3);
            tableLayoutPanel7.Location = new Point(-3, 14);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 4;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(470, 200);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // labelProgramNameText
            // 
            labelProgramNameText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelProgramNameText.AutoSize = true;
            labelProgramNameText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelProgramNameText.Location = new Point(3, 29);
            labelProgramNameText.Name = "labelProgramNameText";
            labelProgramNameText.Size = new Size(117, 21);
            labelProgramNameText.TabIndex = 0;
            labelProgramNameText.Text = "Program Name";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(labelManagingAgencyText, 0, 0);
            tableLayoutPanel8.Controls.Add(panel1, 1, 0);
            tableLayoutPanel8.Location = new Point(3, 103);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(464, 44);
            tableLayoutPanel8.TabIndex = 3;
            // 
            // labelManagingAgencyText
            // 
            labelManagingAgencyText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelManagingAgencyText.AutoSize = true;
            labelManagingAgencyText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelManagingAgencyText.Location = new Point(3, 23);
            labelManagingAgencyText.Name = "labelManagingAgencyText";
            labelManagingAgencyText.Size = new Size(135, 21);
            labelManagingAgencyText.TabIndex = 1;
            labelManagingAgencyText.Text = "Managing Agency";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(labelSearchCodeText);
            panel1.Controls.Add(textBoxSearchCodeValue);
            panel1.Location = new Point(235, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 38);
            panel1.TabIndex = 2;
            // 
            // labelSearchCodeText
            // 
            labelSearchCodeText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSearchCodeText.AutoSize = true;
            labelSearchCodeText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSearchCodeText.Location = new Point(3, 20);
            labelSearchCodeText.Name = "labelSearchCodeText";
            labelSearchCodeText.Size = new Size(76, 15);
            labelSearchCodeText.TabIndex = 2;
            labelSearchCodeText.Text = "Search Code:";
            // 
            // textBoxSearchCodeValue
            // 
            textBoxSearchCodeValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearchCodeValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchCodeValue.Location = new Point(79, 6);
            textBoxSearchCodeValue.Name = "textBoxSearchCodeValue";
            textBoxSearchCodeValue.Size = new Size(141, 29);
            textBoxSearchCodeValue.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(textBoxProgramNameValue);
            panel2.Location = new Point(3, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(464, 44);
            panel2.TabIndex = 4;
            // 
            // textBoxProgramNameValue
            // 
            textBoxProgramNameValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxProgramNameValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProgramNameValue.Location = new Point(3, 3);
            textBoxProgramNameValue.Name = "textBoxProgramNameValue";
            textBoxProgramNameValue.Size = new Size(452, 29);
            textBoxProgramNameValue.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(comboBoxManagingAgencyValue);
            panel3.Location = new Point(3, 153);
            panel3.Name = "panel3";
            panel3.Size = new Size(464, 44);
            panel3.TabIndex = 5;
            // 
            // comboBoxManagingAgencyValue
            // 
            comboBoxManagingAgencyValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxManagingAgencyValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxManagingAgencyValue.FormattingEnabled = true;
            comboBoxManagingAgencyValue.Location = new Point(3, 3);
            comboBoxManagingAgencyValue.Name = "comboBoxManagingAgencyValue";
            comboBoxManagingAgencyValue.Size = new Size(452, 29);
            comboBoxManagingAgencyValue.TabIndex = 0;
            // 
            // groupBoxRequiredDocuments
            // 
            groupBoxRequiredDocuments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxRequiredDocuments.Controls.Add(tableLayoutPanel9);
            groupBoxRequiredDocuments.Location = new Point(3, 223);
            groupBoxRequiredDocuments.Name = "groupBoxRequiredDocuments";
            groupBoxRequiredDocuments.Size = new Size(461, 277);
            groupBoxRequiredDocuments.TabIndex = 1;
            groupBoxRequiredDocuments.TabStop = false;
            groupBoxRequiredDocuments.Text = "Required Documents";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(panel4, 0, 1);
            tableLayoutPanel9.Controls.Add(checkedListBoxListOfRequiredDocuments, 0, 0);
            tableLayoutPanel9.Location = new Point(6, 22);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel9.Size = new Size(449, 249);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.Controls.Add(buttonDeselectAll);
            panel4.Controls.Add(buttonSelectAll);
            panel4.Location = new Point(255, 212);
            panel4.Name = "panel4";
            panel4.Size = new Size(191, 34);
            panel4.TabIndex = 0;
            // 
            // buttonDeselectAll
            // 
            buttonDeselectAll.Location = new Point(99, 3);
            buttonDeselectAll.Name = "buttonDeselectAll";
            buttonDeselectAll.Size = new Size(90, 30);
            buttonDeselectAll.TabIndex = 1;
            buttonDeselectAll.Text = "Deselect All";
            buttonDeselectAll.UseVisualStyleBackColor = true;
            buttonDeselectAll.Click += buttonDeselectAll_Click;
            // 
            // buttonSelectAll
            // 
            buttonSelectAll.Location = new Point(3, 3);
            buttonSelectAll.Name = "buttonSelectAll";
            buttonSelectAll.Size = new Size(90, 30);
            buttonSelectAll.TabIndex = 0;
            buttonSelectAll.Text = "Select All";
            buttonSelectAll.UseVisualStyleBackColor = true;
            buttonSelectAll.Click += buttonSelectAll_Click;
            // 
            // checkedListBoxListOfRequiredDocuments
            // 
            checkedListBoxListOfRequiredDocuments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkedListBoxListOfRequiredDocuments.FormattingEnabled = true;
            checkedListBoxListOfRequiredDocuments.Location = new Point(3, 3);
            checkedListBoxListOfRequiredDocuments.Name = "checkedListBoxListOfRequiredDocuments";
            checkedListBoxListOfRequiredDocuments.Size = new Size(443, 202);
            checkedListBoxListOfRequiredDocuments.TabIndex = 1;
            // 
            // groupBoxPaymentInformation
            // 
            groupBoxPaymentInformation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxPaymentInformation.Controls.Add(tableLayoutPanel10);
            groupBoxPaymentInformation.Location = new Point(3, 506);
            groupBoxPaymentInformation.Name = "groupBoxPaymentInformation";
            groupBoxPaymentInformation.Size = new Size(461, 122);
            groupBoxPaymentInformation.TabIndex = 2;
            groupBoxPaymentInformation.TabStop = false;
            groupBoxPaymentInformation.Text = "Payment Information";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(tableLayoutPanel11, 0, 0);
            tableLayoutPanel10.Controls.Add(tableLayoutPanel12, 0, 1);
            tableLayoutPanel10.Location = new Point(9, 22);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(446, 94);
            tableLayoutPanel10.TabIndex = 0;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel11.ColumnCount = 3;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel11.Controls.Add(labelPaymentTypeText, 0, 0);
            tableLayoutPanel11.Controls.Add(comboBoxPaymentTypeValue, 1, 0);
            tableLayoutPanel11.Controls.Add(panel5, 2, 0);
            tableLayoutPanel11.Location = new Point(3, 3);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Size = new Size(440, 41);
            tableLayoutPanel11.TabIndex = 0;
            // 
            // labelPaymentTypeText
            // 
            labelPaymentTypeText.Anchor = AnchorStyles.Left;
            labelPaymentTypeText.AutoSize = true;
            labelPaymentTypeText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPaymentTypeText.Location = new Point(3, 10);
            labelPaymentTypeText.Name = "labelPaymentTypeText";
            labelPaymentTypeText.Size = new Size(109, 21);
            labelPaymentTypeText.TabIndex = 0;
            labelPaymentTypeText.Text = "Payment Type:";
            // 
            // comboBoxPaymentTypeValue
            // 
            comboBoxPaymentTypeValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxPaymentTypeValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPaymentTypeValue.FormattingEnabled = true;
            comboBoxPaymentTypeValue.Location = new Point(123, 6);
            comboBoxPaymentTypeValue.Name = "comboBoxPaymentTypeValue";
            comboBoxPaymentTypeValue.Size = new Size(154, 29);
            comboBoxPaymentTypeValue.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Right;
            panel5.Controls.Add(radioButtonPercentagePayment);
            panel5.Controls.Add(radioButtonFlatPayment);
            panel5.Location = new Point(283, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(154, 35);
            panel5.TabIndex = 2;
            // 
            // radioButtonPercentagePayment
            // 
            radioButtonPercentagePayment.AutoSize = true;
            radioButtonPercentagePayment.Location = new Point(53, 10);
            radioButtonPercentagePayment.Name = "radioButtonPercentagePayment";
            radioButtonPercentagePayment.Size = new Size(84, 19);
            radioButtonPercentagePayment.TabIndex = 1;
            radioButtonPercentagePayment.TabStop = true;
            radioButtonPercentagePayment.Text = "Percentage";
            radioButtonPercentagePayment.UseVisualStyleBackColor = true;
            // 
            // radioButtonFlatPayment
            // 
            radioButtonFlatPayment.AutoSize = true;
            radioButtonFlatPayment.Location = new Point(3, 10);
            radioButtonFlatPayment.Name = "radioButtonFlatPayment";
            radioButtonFlatPayment.Size = new Size(44, 19);
            radioButtonFlatPayment.TabIndex = 0;
            radioButtonFlatPayment.TabStop = true;
            radioButtonFlatPayment.Text = "Flat";
            radioButtonFlatPayment.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel12.ColumnCount = 5;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(textBoxMaxPaymentValue, 4, 0);
            tableLayoutPanel12.Controls.Add(labelPaymentAmountText, 0, 0);
            tableLayoutPanel12.Controls.Add(labelMinPaymentText, 1, 0);
            tableLayoutPanel12.Controls.Add(labelMaxPaymentText, 3, 0);
            tableLayoutPanel12.Controls.Add(textBoxMinPaymentValue, 2, 0);
            tableLayoutPanel12.Location = new Point(3, 50);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Size = new Size(440, 41);
            tableLayoutPanel12.TabIndex = 1;
            // 
            // textBoxMaxPaymentValue
            // 
            textBoxMaxPaymentValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxMaxPaymentValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMaxPaymentValue.Location = new Point(303, 6);
            textBoxMaxPaymentValue.Name = "textBoxMaxPaymentValue";
            textBoxMaxPaymentValue.Size = new Size(134, 29);
            textBoxMaxPaymentValue.TabIndex = 5;
            // 
            // labelPaymentAmountText
            // 
            labelPaymentAmountText.Anchor = AnchorStyles.Left;
            labelPaymentAmountText.AutoSize = true;
            labelPaymentAmountText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPaymentAmountText.Location = new Point(3, 10);
            labelPaymentAmountText.Name = "labelPaymentAmountText";
            labelPaymentAmountText.Size = new Size(69, 21);
            labelPaymentAmountText.TabIndex = 1;
            labelPaymentAmountText.Text = "Amount:";
            // 
            // labelMinPaymentText
            // 
            labelMinPaymentText.Anchor = AnchorStyles.Right;
            labelMinPaymentText.AutoSize = true;
            labelMinPaymentText.Location = new Point(86, 13);
            labelMinPaymentText.Name = "labelMinPaymentText";
            labelMinPaymentText.Size = new Size(31, 15);
            labelMinPaymentText.TabIndex = 2;
            labelMinPaymentText.Text = "min:";
            // 
            // labelMaxPaymentText
            // 
            labelMaxPaymentText.Anchor = AnchorStyles.Right;
            labelMaxPaymentText.AutoSize = true;
            labelMaxPaymentText.Location = new Point(264, 13);
            labelMaxPaymentText.Name = "labelMaxPaymentText";
            labelMaxPaymentText.Size = new Size(33, 15);
            labelMaxPaymentText.TabIndex = 3;
            labelMaxPaymentText.Text = "max:";
            // 
            // textBoxMinPaymentValue
            // 
            textBoxMinPaymentValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxMinPaymentValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMinPaymentValue.Location = new Point(123, 6);
            textBoxMinPaymentValue.Name = "textBoxMinPaymentValue";
            textBoxMinPaymentValue.Size = new Size(134, 29);
            textBoxMinPaymentValue.TabIndex = 4;
            // 
            // CreateNewProgramForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 661);
            Controls.Add(tableLayoutPanel1);
            Name = "CreateNewProgramForm";
            Text = "CreateNewProgramForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBoxAdministrativeInformation.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupBoxConfirmDetails.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            groupBoxBasicInformation.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            groupBoxRequiredDocuments.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            panel4.ResumeLayout(false);
            groupBoxPaymentInformation.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBoxAdministrativeInformation;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox comboBoxSupervisorValue;
        private Label labelAgentText;
        private Label labelOfficeText;
        private Label labelSupervisorText;
        private Label labelAgentNameValue;
        private ComboBox comboBoxOfficeValue;
        private GroupBox groupBoxConfirmDetails;
        private TableLayoutPanel tableLayoutPanel4;
        private Label labelSummaryText;
        private TableLayoutPanel tableLayoutPanel5;
        private Button buttonCreateProgram;
        private RichTextBox richTextBoxSummary;
        private TableLayoutPanel tableLayoutPanel6;
        private GroupBox groupBoxBasicInformation;
        private TableLayoutPanel tableLayoutPanel7;
        private Label labelProgramNameText;
        private GroupBox groupBoxRequiredDocuments;
        private GroupBox groupBoxPaymentInformation;
        private TableLayoutPanel tableLayoutPanel8;
        private Label labelManagingAgencyText;
        private Panel panel1;
        private TextBox textBoxSearchCodeValue;
        private Label labelSearchCodeText;
        private Panel panel2;
        private TextBox textBoxProgramNameValue;
        private Panel panel3;
        private ComboBox comboBoxManagingAgencyValue;
        private TableLayoutPanel tableLayoutPanel9;
        private Panel panel4;
        private Button buttonDeselectAll;
        private Button buttonSelectAll;
        private CheckedListBox checkedListBoxListOfRequiredDocuments;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel11;
        private Label labelPaymentTypeText;
        private TableLayoutPanel tableLayoutPanel12;
        private Label labelPaymentAmountText;
        private ComboBox comboBoxPaymentTypeValue;
        private Panel panel5;
        private RadioButton radioButtonPercentagePayment;
        private RadioButton radioButtonFlatPayment;
        private Label labelMinPaymentText;
        private Label labelMaxPaymentText;
        private TextBox textBoxMaxPaymentValue;
        private TextBox textBoxMinPaymentValue;
    }
}