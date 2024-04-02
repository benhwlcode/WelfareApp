namespace WelfareApp
{
    partial class LoadApplicantForm
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
            buttonTestList = new Button();
            buttonLoadApplicant = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.Controls.Add(listBoxListOfApplicants, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Location = new Point(14, 16);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.Size = new Size(640, 849);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // listBoxListOfApplicants
            // 
            listBoxListOfApplicants.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxListOfApplicants.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxListOfApplicants.FormattingEnabled = true;
            listBoxListOfApplicants.ItemHeight = 28;
            listBoxListOfApplicants.Location = new Point(49, 57);
            listBoxListOfApplicants.Margin = new Padding(3, 4, 3, 4);
            listBoxListOfApplicants.Name = "listBoxListOfApplicants";
            listBoxListOfApplicants.Size = new Size(542, 620);
            listBoxListOfApplicants.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonTestList, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonLoadApplicant, 0, 0);
            tableLayoutPanel2.Location = new Point(49, 693);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(542, 99);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonTestList
            // 
            buttonTestList.Location = new Point(274, 4);
            buttonTestList.Margin = new Padding(3, 4, 3, 4);
            buttonTestList.Name = "buttonTestList";
            buttonTestList.Size = new Size(264, 53);
            buttonTestList.TabIndex = 1;
            buttonTestList.Text = "Test List";
            buttonTestList.UseVisualStyleBackColor = true;
            buttonTestList.Click += buttonTestList_Click;
            // 
            // buttonLoadApplicant
            // 
            buttonLoadApplicant.Location = new Point(3, 4);
            buttonLoadApplicant.Margin = new Padding(3, 4, 3, 4);
            buttonLoadApplicant.Name = "buttonLoadApplicant";
            buttonLoadApplicant.Size = new Size(264, 53);
            buttonLoadApplicant.TabIndex = 0;
            buttonLoadApplicant.Text = "Load Applicant";
            buttonLoadApplicant.UseVisualStyleBackColor = true;
            buttonLoadApplicant.Click += buttonLoadApplicant_Click;
            // 
            // LoadApplicantForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 881);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoadApplicantForm";
            Text = "LoadApplicantForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListBox listBoxListOfApplicants;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonLoadApplicant;
        private Button buttonTestList;
    }
}