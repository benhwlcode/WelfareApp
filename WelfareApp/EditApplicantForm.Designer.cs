namespace WelfareApp
{
    partial class EditApplicantForm
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
            buttonUpdateApplicant = new Button();
            panelPlaceholder = new Panel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonUpdateApplicant, 0, 1);
            tableLayoutPanel1.Controls.Add(panelPlaceholder, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(560, 637);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonUpdateApplicant
            // 
            buttonUpdateApplicant.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonUpdateApplicant.Location = new Point(3, 605);
            buttonUpdateApplicant.Name = "buttonUpdateApplicant";
            buttonUpdateApplicant.Size = new Size(554, 29);
            buttonUpdateApplicant.TabIndex = 0;
            buttonUpdateApplicant.Text = "Update Applicant";
            buttonUpdateApplicant.UseVisualStyleBackColor = true;
            // 
            // panelPlaceholder
            // 
            panelPlaceholder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPlaceholder.Location = new Point(3, 3);
            panelPlaceholder.Name = "panelPlaceholder";
            panelPlaceholder.Size = new Size(554, 596);
            panelPlaceholder.TabIndex = 1;
            // 
            // EditApplicantForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 661);
            Controls.Add(tableLayoutPanel1);
            Name = "EditApplicantForm";
            Text = "EditApplicantForm";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonUpdateApplicant;
        private Panel panelPlaceholder;
    }
}