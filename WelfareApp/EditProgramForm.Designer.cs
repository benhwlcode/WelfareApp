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
            buttonUpdate = new Button();
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
            comboBoxOfficeValue = new ComboBox();
            comboBoxSupervisorValue = new ComboBox();
            labelSpouseFirstNameText = new Label();
            labelSpouseInformationText = new Label();
            richTextBoxSummary = new RichTextBox();
            labelAgentValue = new Label();
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
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tableLayoutPanel3.Controls.Add(buttonUpdate, 1, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 1, 1);
            tableLayoutPanel3.Location = new Point(14, 16);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel3.Size = new Size(640, 849);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.Top;
            buttonUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUpdate.Location = new Point(228, 693);
            buttonUpdate.Margin = new Padding(3, 4, 3, 4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(183, 53);
            buttonUpdate.TabIndex = 0;
            buttonUpdate.Text = "Update Program";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel7.AutoScroll = true;
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 189F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 342F));
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
            tableLayoutPanel7.Controls.Add(comboBoxOfficeValue, 1, 8);
            tableLayoutPanel7.Controls.Add(comboBoxSupervisorValue, 1, 9);
            tableLayoutPanel7.Controls.Add(labelSpouseFirstNameText, 0, 10);
            tableLayoutPanel7.Controls.Add(labelSpouseInformationText, 0, 11);
            tableLayoutPanel7.Controls.Add(richTextBoxSummary, 1, 11);
            tableLayoutPanel7.Controls.Add(labelAgentValue, 1, 7);
            tableLayoutPanel7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel7.Location = new Point(49, 57);
            tableLayoutPanel7.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.Padding = new Padding(0, 0, 11, 0);
            tableLayoutPanel7.RowCount = 12;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(542, 628);
            tableLayoutPanel7.TabIndex = 2;
            // 
            // labelProgramNameText
            // 
            labelProgramNameText.Anchor = AnchorStyles.Right;
            labelProgramNameText.AutoSize = true;
            labelProgramNameText.Location = new Point(37, 46);
            labelProgramNameText.Name = "labelProgramNameText";
            labelProgramNameText.Size = new Size(149, 28);
            labelProgramNameText.TabIndex = 0;
            labelProgramNameText.Text = "Program Name:";
            // 
            // labelManagingAgencyText
            // 
            labelManagingAgencyText.Anchor = AnchorStyles.Right;
            labelManagingAgencyText.AutoSize = true;
            labelManagingAgencyText.Location = new Point(11, 86);
            labelManagingAgencyText.Name = "labelManagingAgencyText";
            labelManagingAgencyText.Size = new Size(175, 28);
            labelManagingAgencyText.TabIndex = 1;
            labelManagingAgencyText.Text = "Managing Agency:";
            // 
            // labelPaymentTypeText
            // 
            labelPaymentTypeText.Anchor = AnchorStyles.Right;
            labelPaymentTypeText.AutoSize = true;
            labelPaymentTypeText.Location = new Point(49, 126);
            labelPaymentTypeText.Name = "labelPaymentTypeText";
            labelPaymentTypeText.Size = new Size(137, 28);
            labelPaymentTypeText.TabIndex = 2;
            labelPaymentTypeText.Text = "Payment Type:";
            // 
            // labelMinPaymentText
            // 
            labelMinPaymentText.Anchor = AnchorStyles.Right;
            labelMinPaymentText.AutoSize = true;
            labelMinPaymentText.Location = new Point(6, 206);
            labelMinPaymentText.Name = "labelMinPaymentText";
            labelMinPaymentText.Size = new Size(180, 28);
            labelMinPaymentText.TabIndex = 4;
            labelMinPaymentText.Text = "Minimum Payment:";
            // 
            // labelMaxPaymentText
            // 
            labelMaxPaymentText.Anchor = AnchorStyles.Right;
            labelMaxPaymentText.AutoSize = true;
            labelMaxPaymentText.Location = new Point(7, 246);
            labelMaxPaymentText.Name = "labelMaxPaymentText";
            labelMaxPaymentText.Size = new Size(179, 28);
            labelMaxPaymentText.TabIndex = 5;
            labelMaxPaymentText.Text = "Maximum Payment";
            // 
            // labelAgentText
            // 
            labelAgentText.Anchor = AnchorStyles.Right;
            labelAgentText.AutoSize = true;
            labelAgentText.Location = new Point(117, 286);
            labelAgentText.Name = "labelAgentText";
            labelAgentText.Size = new Size(69, 28);
            labelAgentText.TabIndex = 6;
            labelAgentText.Text = "Agent:";
            // 
            // labelOfficeText
            // 
            labelOfficeText.Anchor = AnchorStyles.Right;
            labelOfficeText.AutoSize = true;
            labelOfficeText.Location = new Point(119, 326);
            labelOfficeText.Name = "labelOfficeText";
            labelOfficeText.Size = new Size(67, 28);
            labelOfficeText.TabIndex = 7;
            labelOfficeText.Text = "Office:";
            // 
            // label1ProgramInformationText
            // 
            label1ProgramInformationText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1ProgramInformationText.AutoSize = true;
            label1ProgramInformationText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1ProgramInformationText.Location = new Point(192, 12);
            label1ProgramInformationText.Name = "label1ProgramInformationText";
            label1ProgramInformationText.Size = new Size(204, 28);
            label1ProgramInformationText.TabIndex = 9;
            label1ProgramInformationText.Text = "Program Information";
            // 
            // textBoxProgramNameValue
            // 
            textBoxProgramNameValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxProgramNameValue.Location = new Point(192, 44);
            textBoxProgramNameValue.Margin = new Padding(3, 4, 3, 4);
            textBoxProgramNameValue.Name = "textBoxProgramNameValue";
            textBoxProgramNameValue.Size = new Size(336, 34);
            textBoxProgramNameValue.TabIndex = 14;
            textBoxProgramNameValue.TextChanged += textBoxProgramNameValue_TextChanged;
            // 
            // textBoxMinPaymentValue
            // 
            textBoxMinPaymentValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxMinPaymentValue.Location = new Point(192, 204);
            textBoxMinPaymentValue.Margin = new Padding(3, 4, 3, 4);
            textBoxMinPaymentValue.Name = "textBoxMinPaymentValue";
            textBoxMinPaymentValue.Size = new Size(336, 34);
            textBoxMinPaymentValue.TabIndex = 16;
            textBoxMinPaymentValue.TextChanged += textBoxMinPaymentValue_TextChanged;
            // 
            // comboBoxAgencyValue
            // 
            comboBoxAgencyValue.Anchor = AnchorStyles.Left;
            comboBoxAgencyValue.FormattingEnabled = true;
            comboBoxAgencyValue.Location = new Point(192, 84);
            comboBoxAgencyValue.Margin = new Padding(3, 4, 3, 4);
            comboBoxAgencyValue.Name = "comboBoxAgencyValue";
            comboBoxAgencyValue.Size = new Size(279, 36);
            comboBoxAgencyValue.TabIndex = 19;
            comboBoxAgencyValue.SelectedIndexChanged += comboBoxAgencyValue_SelectedIndexChanged;
            // 
            // comboBoxPaymentTypeValue
            // 
            comboBoxPaymentTypeValue.Anchor = AnchorStyles.Left;
            comboBoxPaymentTypeValue.FormattingEnabled = true;
            comboBoxPaymentTypeValue.Location = new Point(192, 124);
            comboBoxPaymentTypeValue.Margin = new Padding(3, 4, 3, 4);
            comboBoxPaymentTypeValue.Name = "comboBoxPaymentTypeValue";
            comboBoxPaymentTypeValue.Size = new Size(279, 36);
            comboBoxPaymentTypeValue.TabIndex = 20;
            comboBoxPaymentTypeValue.SelectedIndexChanged += comboBoxPaymentTypeValue_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(radioButtonPercentageAmount);
            panel3.Controls.Add(radioButtonFlatAmount);
            panel3.Location = new Point(192, 164);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(336, 32);
            panel3.TabIndex = 26;
            // 
            // radioButtonPercentageAmount
            // 
            radioButtonPercentageAmount.AutoSize = true;
            radioButtonPercentageAmount.Location = new Point(79, 0);
            radioButtonPercentageAmount.Margin = new Padding(3, 4, 3, 4);
            radioButtonPercentageAmount.Name = "radioButtonPercentageAmount";
            radioButtonPercentageAmount.Size = new Size(129, 32);
            radioButtonPercentageAmount.TabIndex = 1;
            radioButtonPercentageAmount.TabStop = true;
            radioButtonPercentageAmount.Text = "Percentage";
            radioButtonPercentageAmount.UseVisualStyleBackColor = true;
            radioButtonPercentageAmount.CheckedChanged += radioButtonPercentageAmount_CheckedChanged;
            // 
            // radioButtonFlatAmount
            // 
            radioButtonFlatAmount.AutoSize = true;
            radioButtonFlatAmount.Location = new Point(6, 0);
            radioButtonFlatAmount.Margin = new Padding(3, 4, 3, 4);
            radioButtonFlatAmount.Name = "radioButtonFlatAmount";
            radioButtonFlatAmount.Size = new Size(65, 32);
            radioButtonFlatAmount.TabIndex = 0;
            radioButtonFlatAmount.TabStop = true;
            radioButtonFlatAmount.Text = "Flat";
            radioButtonFlatAmount.UseVisualStyleBackColor = true;
            radioButtonFlatAmount.CheckedChanged += radioButtonFlatAmount_CheckedChanged;
            // 
            // textBoxMaxPaymentValue
            // 
            textBoxMaxPaymentValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxMaxPaymentValue.Location = new Point(192, 244);
            textBoxMaxPaymentValue.Margin = new Padding(3, 4, 3, 4);
            textBoxMaxPaymentValue.Name = "textBoxMaxPaymentValue";
            textBoxMaxPaymentValue.Size = new Size(336, 34);
            textBoxMaxPaymentValue.TabIndex = 17;
            textBoxMaxPaymentValue.TextChanged += textBoxMaxPaymentValue_TextChanged;
            // 
            // labelSupervisorText
            // 
            labelSupervisorText.Anchor = AnchorStyles.Right;
            labelSupervisorText.AutoSize = true;
            labelSupervisorText.Location = new Point(81, 366);
            labelSupervisorText.Name = "labelSupervisorText";
            labelSupervisorText.Size = new Size(105, 28);
            labelSupervisorText.TabIndex = 24;
            labelSupervisorText.Text = "Supervisor";
            // 
            // comboBoxOfficeValue
            // 
            comboBoxOfficeValue.Anchor = AnchorStyles.Left;
            comboBoxOfficeValue.FormattingEnabled = true;
            comboBoxOfficeValue.Location = new Point(192, 324);
            comboBoxOfficeValue.Margin = new Padding(3, 4, 3, 4);
            comboBoxOfficeValue.Name = "comboBoxOfficeValue";
            comboBoxOfficeValue.Size = new Size(279, 36);
            comboBoxOfficeValue.TabIndex = 32;
            comboBoxOfficeValue.SelectedIndexChanged += comboBoxOfficeValue_SelectedIndexChanged;
            // 
            // comboBoxSupervisorValue
            // 
            comboBoxSupervisorValue.Anchor = AnchorStyles.Left;
            comboBoxSupervisorValue.FormattingEnabled = true;
            comboBoxSupervisorValue.Location = new Point(192, 364);
            comboBoxSupervisorValue.Margin = new Padding(3, 4, 3, 4);
            comboBoxSupervisorValue.Name = "comboBoxSupervisorValue";
            comboBoxSupervisorValue.Size = new Size(279, 36);
            comboBoxSupervisorValue.TabIndex = 59;
            comboBoxSupervisorValue.SelectedIndexChanged += comboBoxSupervisorValue_SelectedIndexChanged;
            // 
            // labelSpouseFirstNameText
            // 
            labelSpouseFirstNameText.Anchor = AnchorStyles.Right;
            labelSpouseFirstNameText.AutoSize = true;
            labelSpouseFirstNameText.Location = new Point(186, 406);
            labelSpouseFirstNameText.Name = "labelSpouseFirstNameText";
            labelSpouseFirstNameText.Size = new Size(0, 28);
            labelSpouseFirstNameText.TabIndex = 11;
            // 
            // labelSpouseInformationText
            // 
            labelSpouseInformationText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelSpouseInformationText.AutoSize = true;
            labelSpouseInformationText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSpouseInformationText.Location = new Point(82, 440);
            labelSpouseInformationText.Name = "labelSpouseInformationText";
            labelSpouseInformationText.Size = new Size(104, 28);
            labelSpouseInformationText.TabIndex = 10;
            labelSpouseInformationText.Text = "Summary:";
            // 
            // richTextBoxSummary
            // 
            richTextBoxSummary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxSummary.BackColor = SystemColors.Control;
            richTextBoxSummary.Location = new Point(192, 444);
            richTextBoxSummary.Margin = new Padding(3, 4, 3, 4);
            richTextBoxSummary.Name = "richTextBoxSummary";
            richTextBoxSummary.Size = new Size(336, 180);
            richTextBoxSummary.TabIndex = 60;
            richTextBoxSummary.Text = "";
            // 
            // labelAgentValue
            // 
            labelAgentValue.Anchor = AnchorStyles.Left;
            labelAgentValue.AutoSize = true;
            labelAgentValue.Location = new Point(192, 286);
            labelAgentValue.Name = "labelAgentValue";
            labelAgentValue.Size = new Size(115, 28);
            labelAgentValue.TabIndex = 61;
            labelAgentValue.Text = ">agent info";
            // 
            // EditProgramForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 881);
            Controls.Add(tableLayoutPanel3);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button buttonUpdate;
        private TableLayoutPanel tableLayoutPanel7;
        private ComboBox comboBoxSupervisorValue;
        private ComboBox comboBoxOfficeValue;
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
        private Label labelAgentValue;
    }
}