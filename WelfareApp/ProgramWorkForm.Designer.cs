namespace WelfareApp
{
    partial class ProgramWorkForm
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
            panel1 = new Panel();
            checkBoxShowAll = new CheckBox();
            checkBoxShowDisqualified = new CheckBox();
            checkBoxShowEligible = new CheckBox();
            labelShowApplicationsText = new Label();
            buttonEditProgram = new Button();
            buttonEditEligibility = new Button();
            listBoxListOfApplications = new ListBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonUpdateApplication = new Button();
            listBoxListOfDocuments = new ListBox();
            groupBoxSelectedApplicant = new GroupBox();
            buttonEditApplicant = new Button();
            labelApplicantNameAndIdValue = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            labelApplicationStatusValue = new Label();
            labelApprovalStatusValue = new Label();
            labelEligibilityStatusValue = new Label();
            labelPaymentStatusValue = new Label();
            panel2 = new Panel();
            checkBoxShowPending = new CheckBox();
            labelListOfDocumentsText = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBoxSelectedApplicant.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
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
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(listBoxListOfApplications, 0, 1);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel2.Size = new Size(381, 631);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(checkBoxShowAll);
            panel1.Controls.Add(checkBoxShowDisqualified);
            panel1.Controls.Add(checkBoxShowEligible);
            panel1.Controls.Add(labelShowApplicationsText);
            panel1.Controls.Add(buttonEditProgram);
            panel1.Controls.Add(buttonEditEligibility);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 88);
            panel1.TabIndex = 0;
            // 
            // checkBoxShowAll
            // 
            checkBoxShowAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBoxShowAll.AutoSize = true;
            checkBoxShowAll.Location = new Point(315, 47);
            checkBoxShowAll.Name = "checkBoxShowAll";
            checkBoxShowAll.Size = new Size(57, 32);
            checkBoxShowAll.TabIndex = 5;
            checkBoxShowAll.Text = "All";
            checkBoxShowAll.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowDisqualified
            // 
            checkBoxShowDisqualified.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxShowDisqualified.AutoSize = true;
            checkBoxShowDisqualified.Location = new Point(146, 47);
            checkBoxShowDisqualified.Name = "checkBoxShowDisqualified";
            checkBoxShowDisqualified.Size = new Size(137, 32);
            checkBoxShowDisqualified.TabIndex = 4;
            checkBoxShowDisqualified.Text = "Disqualified";
            checkBoxShowDisqualified.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowEligible
            // 
            checkBoxShowEligible.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxShowEligible.AutoSize = true;
            checkBoxShowEligible.Location = new Point(61, 47);
            checkBoxShowEligible.Name = "checkBoxShowEligible";
            checkBoxShowEligible.Size = new Size(98, 32);
            checkBoxShowEligible.TabIndex = 3;
            checkBoxShowEligible.Text = "Eligible";
            checkBoxShowEligible.UseVisualStyleBackColor = true;
            // 
            // labelShowApplicationsText
            // 
            labelShowApplicationsText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelShowApplicationsText.AutoSize = true;
            labelShowApplicationsText.Location = new Point(3, 59);
            labelShowApplicationsText.Name = "labelShowApplicationsText";
            labelShowApplicationsText.Size = new Size(64, 28);
            labelShowApplicationsText.TabIndex = 2;
            labelShowApplicationsText.Text = "Show:";
            // 
            // buttonEditProgram
            // 
            buttonEditProgram.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditProgram.Location = new Point(126, 3);
            buttonEditProgram.Name = "buttonEditProgram";
            buttonEditProgram.Size = new Size(107, 43);
            buttonEditProgram.TabIndex = 1;
            buttonEditProgram.Text = "Edit Program";
            buttonEditProgram.UseVisualStyleBackColor = true;
            buttonEditProgram.Click += buttonEditProgram_Click;
            // 
            // buttonEditEligibility
            // 
            buttonEditEligibility.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditEligibility.Location = new Point(3, 3);
            buttonEditEligibility.Name = "buttonEditEligibility";
            buttonEditEligibility.Size = new Size(117, 43);
            buttonEditEligibility.TabIndex = 0;
            buttonEditEligibility.Text = "Edit Eligibility";
            buttonEditEligibility.UseVisualStyleBackColor = true;
            // 
            // listBoxListOfApplications
            // 
            listBoxListOfApplications.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxListOfApplications.FormattingEnabled = true;
            listBoxListOfApplications.ItemHeight = 28;
            listBoxListOfApplications.Location = new Point(3, 97);
            listBoxListOfApplications.Name = "listBoxListOfApplications";
            listBoxListOfApplications.Size = new Size(375, 508);
            listBoxListOfApplications.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(buttonUpdateApplication, 0, 4);
            tableLayoutPanel3.Controls.Add(listBoxListOfDocuments, 0, 3);
            tableLayoutPanel3.Controls.Add(groupBoxSelectedApplicant, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Controls.Add(panel2, 0, 2);
            tableLayoutPanel3.Location = new Point(390, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.Size = new Size(467, 631);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // buttonUpdateApplication
            // 
            buttonUpdateApplication.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUpdateApplication.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUpdateApplication.Location = new Point(334, 598);
            buttonUpdateApplication.Name = "buttonUpdateApplication";
            buttonUpdateApplication.Size = new Size(130, 30);
            buttonUpdateApplication.TabIndex = 2;
            buttonUpdateApplication.Text = "Update Application";
            buttonUpdateApplication.UseVisualStyleBackColor = true;
            // 
            // listBoxListOfDocuments
            // 
            listBoxListOfDocuments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxListOfDocuments.FormattingEnabled = true;
            listBoxListOfDocuments.ItemHeight = 28;
            listBoxListOfDocuments.Location = new Point(3, 217);
            listBoxListOfDocuments.Name = "listBoxListOfDocuments";
            listBoxListOfDocuments.Size = new Size(461, 368);
            listBoxListOfDocuments.TabIndex = 1;
            // 
            // groupBoxSelectedApplicant
            // 
            groupBoxSelectedApplicant.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxSelectedApplicant.Controls.Add(buttonEditApplicant);
            groupBoxSelectedApplicant.Controls.Add(labelApplicantNameAndIdValue);
            groupBoxSelectedApplicant.Location = new Point(3, 3);
            groupBoxSelectedApplicant.Name = "groupBoxSelectedApplicant";
            groupBoxSelectedApplicant.Size = new Size(461, 74);
            groupBoxSelectedApplicant.TabIndex = 3;
            groupBoxSelectedApplicant.TabStop = false;
            groupBoxSelectedApplicant.Text = "Selected Applicant";
            // 
            // buttonEditApplicant
            // 
            buttonEditApplicant.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonEditApplicant.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditApplicant.Location = new Point(356, 16);
            buttonEditApplicant.Name = "buttonEditApplicant";
            buttonEditApplicant.Size = new Size(99, 52);
            buttonEditApplicant.TabIndex = 6;
            buttonEditApplicant.Text = "Edit Applicant";
            buttonEditApplicant.UseVisualStyleBackColor = true;
            buttonEditApplicant.Click += buttonEditApplicant_Click;
            // 
            // labelApplicantNameAndIdValue
            // 
            labelApplicantNameAndIdValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelApplicantNameAndIdValue.AutoSize = true;
            labelApplicantNameAndIdValue.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelApplicantNameAndIdValue.Location = new Point(6, 19);
            labelApplicantNameAndIdValue.Name = "labelApplicantNameAndIdValue";
            labelApplicantNameAndIdValue.Size = new Size(318, 37);
            labelApplicantNameAndIdValue.TabIndex = 0;
            labelApplicantNameAndIdValue.Text = ">applicant name and id<";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(labelApplicationStatusValue, 0, 0);
            tableLayoutPanel4.Controls.Add(labelApprovalStatusValue, 1, 1);
            tableLayoutPanel4.Controls.Add(labelEligibilityStatusValue, 0, 1);
            tableLayoutPanel4.Controls.Add(labelPaymentStatusValue, 1, 0);
            tableLayoutPanel4.Location = new Point(3, 83);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(461, 88);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // labelApplicationStatusValue
            // 
            labelApplicationStatusValue.Anchor = AnchorStyles.Left;
            labelApplicationStatusValue.AutoSize = true;
            labelApplicationStatusValue.Location = new Point(3, 0);
            labelApplicationStatusValue.Name = "labelApplicationStatusValue";
            labelApplicationStatusValue.Size = new Size(185, 44);
            labelApplicationStatusValue.TabIndex = 0;
            labelApplicationStatusValue.Text = ">application status value<";
            // 
            // labelApprovalStatusValue
            // 
            labelApprovalStatusValue.Anchor = AnchorStyles.Left;
            labelApprovalStatusValue.AutoSize = true;
            labelApprovalStatusValue.Location = new Point(233, 52);
            labelApprovalStatusValue.Name = "labelApprovalStatusValue";
            labelApprovalStatusValue.Size = new Size(225, 28);
            labelApprovalStatusValue.TabIndex = 3;
            labelApprovalStatusValue.Text = ">approval status value<";
            // 
            // labelEligibilityStatusValue
            // 
            labelEligibilityStatusValue.Anchor = AnchorStyles.Left;
            labelEligibilityStatusValue.AutoSize = true;
            labelEligibilityStatusValue.Location = new Point(3, 44);
            labelEligibilityStatusValue.Name = "labelEligibilityStatusValue";
            labelEligibilityStatusValue.Size = new Size(168, 44);
            labelEligibilityStatusValue.TabIndex = 2;
            labelEligibilityStatusValue.Text = ">eligibility status value<";
            // 
            // labelPaymentStatusValue
            // 
            labelPaymentStatusValue.Anchor = AnchorStyles.Left;
            labelPaymentStatusValue.AutoSize = true;
            labelPaymentStatusValue.Location = new Point(233, 8);
            labelPaymentStatusValue.Name = "labelPaymentStatusValue";
            labelPaymentStatusValue.Size = new Size(224, 28);
            labelPaymentStatusValue.TabIndex = 1;
            labelPaymentStatusValue.Text = ">payment status value<";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(checkBoxShowPending);
            panel2.Controls.Add(labelListOfDocumentsText);
            panel2.Location = new Point(3, 177);
            panel2.Name = "panel2";
            panel2.Size = new Size(461, 34);
            panel2.TabIndex = 5;
            // 
            // checkBoxShowPending
            // 
            checkBoxShowPending.Anchor = AnchorStyles.Right;
            checkBoxShowPending.AutoSize = true;
            checkBoxShowPending.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxShowPending.Location = new Point(337, 12);
            checkBoxShowPending.Name = "checkBoxShowPending";
            checkBoxShowPending.Size = new Size(124, 24);
            checkBoxShowPending.TabIndex = 1;
            checkBoxShowPending.Text = "Show Pending";
            checkBoxShowPending.UseVisualStyleBackColor = true;
            // 
            // labelListOfDocumentsText
            // 
            labelListOfDocumentsText.Anchor = AnchorStyles.Left;
            labelListOfDocumentsText.AutoSize = true;
            labelListOfDocumentsText.Location = new Point(0, 8);
            labelListOfDocumentsText.Name = "labelListOfDocumentsText";
            labelListOfDocumentsText.Size = new Size(168, 28);
            labelListOfDocumentsText.TabIndex = 0;
            labelListOfDocumentsText.Text = "List of Documents";
            // 
            // ProgramWorkForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 661);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MinimumSize = new Size(900, 700);
            Name = "ProgramWorkForm";
            Text = "ProgramWorkForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            groupBoxSelectedApplicant.ResumeLayout(false);
            groupBoxSelectedApplicant.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private ListBox listBoxListOfApplications;
        private TableLayoutPanel tableLayoutPanel3;
        private ListBox listBoxListOfDocuments;
        private Label labelShowApplicationsText;
        private Button buttonEditProgram;
        private Button buttonEditEligibility;
        private Button buttonUpdateApplication;
        private CheckBox checkBoxShowAll;
        private CheckBox checkBoxShowDisqualified;
        private CheckBox checkBoxShowEligible;
        private GroupBox groupBoxSelectedApplicant;
        private Button buttonEditApplicant;
        private Label labelApplicantNameAndIdValue;
        private TableLayoutPanel tableLayoutPanel4;
        private Label labelApplicationStatusValue;
        private Label labelApprovalStatusValue;
        private Label labelEligibilityStatusValue;
        private Label labelPaymentStatusValue;
        private Panel panel2;
        private Label labelListOfDocumentsText;
        private CheckBox checkBoxShowPending;
    }
}