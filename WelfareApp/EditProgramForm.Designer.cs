namespace WelfareApp
{
    partial class EditProgramForm
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
            listBoxListOfApplicants = new ListBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonEditApplicant = new Button();
            buttonLoadApplicant = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            labelProgramNameText = new Label();
            labelManagingAgencyText = new Label();
            labelPaymentTypeText = new Label();
            labelMinPaymentText = new Label();
            labelMaxPaymentText = new Label();
            labelAgentText = new Label();
            labelOfficeText = new Label();
            label1ProgramInformationText = new Label();
            textBoxProgramNameValue = new TextBox();
            textBoxMinPaymentValue = new TextBox();
            comboBoxAgencyValue = new ComboBox();
            comboBoxPaymentTypeValue = new ComboBox();
            panel3 = new Panel();
            radioButtonPercentageAmount = new RadioButton();
            radioButtonFlatAmount = new RadioButton();
            textBoxMaxPaymentValue = new TextBox();
            labelSupervisorText = new Label();
            textBoxAgentValue = new TextBox();
            comboBoxOfficeValue = new ComboBox();
            comboBoxSupervisorValue = new ComboBox();
            labelSpouseFirstNameText = new Label();
            labelSpouseInformationText = new Label();
            richTextBoxSummary = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Controls.Add(listBoxListOfApplicants, 1, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // listBoxListOfApplicants
            // 
            listBoxListOfApplicants.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxListOfApplicants.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxListOfApplicants.FormattingEnabled = true;
            listBoxListOfApplicants.ItemHeight = 21;
            listBoxListOfApplicants.Location = new Point(43, 23);
            listBoxListOfApplicants.Name = "listBoxListOfApplicants";
            listBoxListOfApplicants.Size = new Size(114, 14);
            listBoxListOfApplicants.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonEditApplicant, 1, 0);
            tableLayoutPanel2.Controls.Add(buttonLoadApplicant, 0, 0);
            tableLayoutPanel2.Location = new Point(43, 475);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(114, 74);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonEditApplicant
            // 
            buttonEditApplicant.Location = new Point(60, 3);
            buttonEditApplicant.Name = "buttonEditApplicant";
            buttonEditApplicant.Size = new Size(51, 40);
            buttonEditApplicant.TabIndex = 1;
            buttonEditApplicant.Text = "Edit Applicant";
            buttonEditApplicant.UseVisualStyleBackColor = true;
            // 
            // buttonLoadApplicant
            // 
            buttonLoadApplicant.Location = new Point(3, 3);
            buttonLoadApplicant.Name = "buttonLoadApplicant";
            buttonLoadApplicant.Size = new Size(51, 40);
            buttonLoadApplicant.TabIndex = 0;
            buttonLoadApplicant.Text = "Load Applicant";
            buttonLoadApplicant.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.Controls.Add(button1, 1, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 1, 1);
            tableLayoutPanel3.Location = new Point(12, 12);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.Size = new Size(560, 637);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(200, 520);
            button1.Name = "button1";
            button1.Size = new Size(160, 40);
            button1.TabIndex = 0;
            button1.Text = "Update Program";
            button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel7.AutoScroll = true;
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 212F));
            tableLayoutPanel7.Controls.Add(labelProgramNameText, 0, 1);
            tableLayoutPanel7.Controls.Add(labelManagingAgencyText, 0, 2);
            tableLayoutPanel7.Controls.Add(labelPaymentTypeText, 0, 3);
            tableLayoutPanel7.Controls.Add(labelMinPaymentText, 0, 5);
            tableLayoutPanel7.Controls.Add(labelMaxPaymentText, 0, 6);
            tableLayoutPanel7.Controls.Add(labelAgentText, 0, 7);
            tableLayoutPanel7.Controls.Add(labelOfficeText, 0, 8);
            tableLayoutPanel7.Controls.Add(label1ProgramInformationText, 1, 0);
            tableLayoutPanel7.Controls.Add(textBoxProgramNameValue, 1, 1);
            tableLayoutPanel7.Controls.Add(textBoxMinPaymentValue, 1, 5);
            tableLayoutPanel7.Controls.Add(comboBoxAgencyValue, 1, 2);
            tableLayoutPanel7.Controls.Add(comboBoxPaymentTypeValue, 1, 3);
            tableLayoutPanel7.Controls.Add(panel3, 1, 4);
            tableLayoutPanel7.Controls.Add(textBoxMaxPaymentValue, 1, 6);
            tableLayoutPanel7.Controls.Add(labelSupervisorText, 0, 9);
            tableLayoutPanel7.Controls.Add(textBoxAgentValue, 1, 7);
            tableLayoutPanel7.Controls.Add(comboBoxOfficeValue, 1, 8);
            tableLayoutPanel7.Controls.Add(comboBoxSupervisorValue, 1, 9);
            tableLayoutPanel7.Controls.Add(labelSpouseFirstNameText, 0, 10);
            tableLayoutPanel7.Controls.Add(labelSpouseInformationText, 0, 11);
            tableLayoutPanel7.Controls.Add(richTextBoxSummary, 1, 11);
            tableLayoutPanel7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel7.Location = new Point(43, 43);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.Padding = new Padding(0, 0, 10, 0);
            tableLayoutPanel7.RowCount = 14;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel7.Size = new Size(474, 471);
            tableLayoutPanel7.TabIndex = 2;
            // 
            // labelProgramNameText
            // 
            labelProgramNameText.Anchor = AnchorStyles.Right;
            labelProgramNameText.AutoSize = true;
            labelProgramNameText.Location = new Point(42, 34);
            labelProgramNameText.Name = "labelProgramNameText";
            labelProgramNameText.Size = new Size(120, 21);
            labelProgramNameText.TabIndex = 0;
            labelProgramNameText.Text = "Program Name:";
            // 
            // labelManagingAgencyText
            // 
            labelManagingAgencyText.Anchor = AnchorStyles.Right;
            labelManagingAgencyText.AutoSize = true;
            labelManagingAgencyText.Location = new Point(24, 64);
            labelManagingAgencyText.Name = "labelManagingAgencyText";
            labelManagingAgencyText.Size = new Size(138, 21);
            labelManagingAgencyText.TabIndex = 1;
            labelManagingAgencyText.Text = "Managing Agency:";
            // 
            // labelPaymentTypeText
            // 
            labelPaymentTypeText.Anchor = AnchorStyles.Right;
            labelPaymentTypeText.AutoSize = true;
            labelPaymentTypeText.Location = new Point(53, 94);
            labelPaymentTypeText.Name = "labelPaymentTypeText";
            labelPaymentTypeText.Size = new Size(109, 21);
            labelPaymentTypeText.TabIndex = 2;
            labelPaymentTypeText.Text = "Payment Type:";
            // 
            // labelMinPaymentText
            // 
            labelMinPaymentText.Anchor = AnchorStyles.Right;
            labelMinPaymentText.AutoSize = true;
            labelMinPaymentText.Location = new Point(17, 154);
            labelMinPaymentText.Name = "labelMinPaymentText";
            labelMinPaymentText.Size = new Size(145, 21);
            labelMinPaymentText.TabIndex = 4;
            labelMinPaymentText.Text = "Minimum Payment:";
            // 
            // labelMaxPaymentText
            // 
            labelMaxPaymentText.Anchor = AnchorStyles.Right;
            labelMaxPaymentText.AutoSize = true;
            labelMaxPaymentText.Location = new Point(18, 184);
            labelMaxPaymentText.Name = "labelMaxPaymentText";
            labelMaxPaymentText.Size = new Size(144, 21);
            labelMaxPaymentText.TabIndex = 5;
            labelMaxPaymentText.Text = "Maximum Payment";
            // 
            // labelAgentText
            // 
            labelAgentText.Anchor = AnchorStyles.Right;
            labelAgentText.AutoSize = true;
            labelAgentText.Location = new Point(108, 214);
            labelAgentText.Name = "labelAgentText";
            labelAgentText.Size = new Size(54, 21);
            labelAgentText.TabIndex = 6;
            labelAgentText.Text = "Agent:";
            // 
            // labelOfficeText
            // 
            labelOfficeText.Anchor = AnchorStyles.Right;
            labelOfficeText.AutoSize = true;
            labelOfficeText.Location = new Point(108, 244);
            labelOfficeText.Name = "labelOfficeText";
            labelOfficeText.Size = new Size(54, 21);
            labelOfficeText.TabIndex = 7;
            labelOfficeText.Text = "Office:";
            // 
            // label1ProgramInformationText
            // 
            label1ProgramInformationText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1ProgramInformationText.AutoSize = true;
            label1ProgramInformationText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1ProgramInformationText.Location = new Point(168, 9);
            label1ProgramInformationText.Name = "label1ProgramInformationText";
            label1ProgramInformationText.Size = new Size(164, 21);
            label1ProgramInformationText.TabIndex = 9;
            label1ProgramInformationText.Text = "Program Information";
            // 
            // textBoxProgramNameValue
            // 
            textBoxProgramNameValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxProgramNameValue.Location = new Point(168, 33);
            textBoxProgramNameValue.Name = "textBoxProgramNameValue";
            textBoxProgramNameValue.Size = new Size(293, 29);
            textBoxProgramNameValue.TabIndex = 14;
            // 
            // textBoxMinPaymentValue
            // 
            textBoxMinPaymentValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxMinPaymentValue.Location = new Point(168, 153);
            textBoxMinPaymentValue.Name = "textBoxMinPaymentValue";
            textBoxMinPaymentValue.Size = new Size(293, 29);
            textBoxMinPaymentValue.TabIndex = 16;
            // 
            // comboBoxAgencyValue
            // 
            comboBoxAgencyValue.Anchor = AnchorStyles.Left;
            comboBoxAgencyValue.FormattingEnabled = true;
            comboBoxAgencyValue.Location = new Point(168, 63);
            comboBoxAgencyValue.Name = "comboBoxAgencyValue";
            comboBoxAgencyValue.Size = new Size(245, 29);
            comboBoxAgencyValue.TabIndex = 19;
            // 
            // comboBoxPaymentTypeValue
            // 
            comboBoxPaymentTypeValue.Anchor = AnchorStyles.Left;
            comboBoxPaymentTypeValue.FormattingEnabled = true;
            comboBoxPaymentTypeValue.Location = new Point(168, 93);
            comboBoxPaymentTypeValue.Name = "comboBoxPaymentTypeValue";
            comboBoxPaymentTypeValue.Size = new Size(245, 29);
            comboBoxPaymentTypeValue.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(radioButtonPercentageAmount);
            panel3.Controls.Add(radioButtonFlatAmount);
            panel3.Location = new Point(168, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(293, 24);
            panel3.TabIndex = 26;
            // 
            // radioButtonPercentageAmount
            // 
            radioButtonPercentageAmount.AutoSize = true;
            radioButtonPercentageAmount.Location = new Point(69, 0);
            radioButtonPercentageAmount.Name = "radioButtonPercentageAmount";
            radioButtonPercentageAmount.Size = new Size(104, 25);
            radioButtonPercentageAmount.TabIndex = 1;
            radioButtonPercentageAmount.TabStop = true;
            radioButtonPercentageAmount.Text = "Percentage";
            radioButtonPercentageAmount.UseVisualStyleBackColor = true;
            // 
            // radioButtonFlatAmount
            // 
            radioButtonFlatAmount.AutoSize = true;
            radioButtonFlatAmount.Location = new Point(5, 0);
            radioButtonFlatAmount.Name = "radioButtonFlatAmount";
            radioButtonFlatAmount.Size = new Size(53, 25);
            radioButtonFlatAmount.TabIndex = 0;
            radioButtonFlatAmount.TabStop = true;
            radioButtonFlatAmount.Text = "Flat";
            radioButtonFlatAmount.UseVisualStyleBackColor = true;
            // 
            // textBoxMaxPaymentValue
            // 
            textBoxMaxPaymentValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxMaxPaymentValue.Location = new Point(168, 183);
            textBoxMaxPaymentValue.Name = "textBoxMaxPaymentValue";
            textBoxMaxPaymentValue.Size = new Size(293, 29);
            textBoxMaxPaymentValue.TabIndex = 17;
            // 
            // labelSupervisorText
            // 
            labelSupervisorText.Anchor = AnchorStyles.Right;
            labelSupervisorText.AutoSize = true;
            labelSupervisorText.Location = new Point(77, 274);
            labelSupervisorText.Name = "labelSupervisorText";
            labelSupervisorText.Size = new Size(85, 21);
            labelSupervisorText.TabIndex = 24;
            labelSupervisorText.Text = "Supervisor";
            // 
            // textBoxAgentValue
            // 
            textBoxAgentValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxAgentValue.Location = new Point(168, 213);
            textBoxAgentValue.Name = "textBoxAgentValue";
            textBoxAgentValue.Size = new Size(293, 29);
            textBoxAgentValue.TabIndex = 30;
            // 
            // comboBoxOfficeValue
            // 
            comboBoxOfficeValue.Anchor = AnchorStyles.Left;
            comboBoxOfficeValue.FormattingEnabled = true;
            comboBoxOfficeValue.Location = new Point(168, 243);
            comboBoxOfficeValue.Name = "comboBoxOfficeValue";
            comboBoxOfficeValue.Size = new Size(245, 29);
            comboBoxOfficeValue.TabIndex = 32;
            // 
            // comboBoxSupervisorValue
            // 
            comboBoxSupervisorValue.Anchor = AnchorStyles.Left;
            comboBoxSupervisorValue.FormattingEnabled = true;
            comboBoxSupervisorValue.Location = new Point(168, 273);
            comboBoxSupervisorValue.Name = "comboBoxSupervisorValue";
            comboBoxSupervisorValue.Size = new Size(245, 29);
            comboBoxSupervisorValue.TabIndex = 59;
            // 
            // labelSpouseFirstNameText
            // 
            labelSpouseFirstNameText.Anchor = AnchorStyles.Right;
            labelSpouseFirstNameText.AutoSize = true;
            labelSpouseFirstNameText.Location = new Point(162, 304);
            labelSpouseFirstNameText.Name = "labelSpouseFirstNameText";
            labelSpouseFirstNameText.Size = new Size(0, 21);
            labelSpouseFirstNameText.TabIndex = 11;
            // 
            // labelSpouseInformationText
            // 
            labelSpouseInformationText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelSpouseInformationText.AutoSize = true;
            labelSpouseInformationText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSpouseInformationText.Location = new Point(79, 330);
            labelSpouseInformationText.Name = "labelSpouseInformationText";
            labelSpouseInformationText.Size = new Size(83, 21);
            labelSpouseInformationText.TabIndex = 10;
            labelSpouseInformationText.Text = "Summary:";
            // 
            // richTextBoxSummary
            // 
            richTextBoxSummary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxSummary.BackColor = SystemColors.Control;
            richTextBoxSummary.Location = new Point(168, 333);
            richTextBoxSummary.Name = "richTextBoxSummary";
            richTextBoxSummary.Size = new Size(293, 75);
            richTextBoxSummary.TabIndex = 60;
            richTextBoxSummary.Text = "";
            // 
            // EditProgramForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 661);
            Controls.Add(tableLayoutPanel3);
            Name = "EditProgramForm";
            Text = "EditProgramForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListBox listBoxListOfApplicants;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonEditApplicant;
        private Button buttonLoadApplicant;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel7;
        private ComboBox comboBoxSupervisorValue;
        private ComboBox comboBoxOfficeValue;
        private TextBox textBoxAgentValue;
        private Label labelProgramNameText;
        private Label labelManagingAgencyText;
        private Label labelPaymentTypeText;
        private Label labelMinPaymentText;
        private Label labelMaxPaymentText;
        private Label labelAgentText;
        private Label labelOfficeText;
        private Label label1ProgramInformationText;
        private TextBox textBoxProgramNameValue;
        private TextBox textBoxMinPaymentValue;
        private TextBox textBoxMaxPaymentValue;
        private ComboBox comboBoxAgencyValue;
        private ComboBox comboBoxPaymentTypeValue;
        private Label labelSpouseInformationText;
        private Label labelSpouseFirstNameText;
        private Label labelSupervisorText;
        private Panel panel3;
        private RadioButton radioButtonPercentageAmount;
        private RadioButton radioButtonFlatAmount;
        private RichTextBox richTextBoxSummary;
    }
}