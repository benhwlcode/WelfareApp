namespace WelfareApp
{
    partial class EditEligibilityForm
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
            groupBoxConditions = new GroupBox();
            tableLayoutPanelConditions = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonAddCondition = new Button();
            buttonRemoveCondition = new Button();
            buttonApplyCondition = new Button();
            buttonTest = new Button();
            tableLayoutPanel1.SuspendLayout();
            groupBoxConditions.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBoxConditions, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(882, 553);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxConditions
            // 
            groupBoxConditions.Controls.Add(tableLayoutPanelConditions);
            groupBoxConditions.Dock = DockStyle.Fill;
            groupBoxConditions.Location = new Point(3, 3);
            groupBoxConditions.Name = "groupBoxConditions";
            groupBoxConditions.Size = new Size(876, 487);
            groupBoxConditions.TabIndex = 0;
            groupBoxConditions.TabStop = false;
            groupBoxConditions.Text = "Conditions";
            // 
            // tableLayoutPanelConditions
            // 
            tableLayoutPanelConditions.AllowDrop = true;
            tableLayoutPanelConditions.AutoScroll = true;
            tableLayoutPanelConditions.ColumnCount = 1;
            tableLayoutPanelConditions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelConditions.Dock = DockStyle.Fill;
            tableLayoutPanelConditions.Location = new Point(3, 23);
            tableLayoutPanelConditions.Name = "tableLayoutPanelConditions";
            tableLayoutPanelConditions.RowCount = 1;
            tableLayoutPanelConditions.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelConditions.Size = new Size(870, 461);
            tableLayoutPanelConditions.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel2.Controls.Add(buttonAddCondition, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonRemoveCondition, 1, 0);
            tableLayoutPanel2.Controls.Add(buttonApplyCondition, 4, 0);
            tableLayoutPanel2.Controls.Add(buttonTest, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 496);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(876, 54);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonAddCondition
            // 
            buttonAddCondition.Dock = DockStyle.Fill;
            buttonAddCondition.Location = new Point(3, 3);
            buttonAddCondition.Name = "buttonAddCondition";
            buttonAddCondition.Size = new Size(154, 48);
            buttonAddCondition.TabIndex = 0;
            buttonAddCondition.Text = "Add Condition";
            buttonAddCondition.UseVisualStyleBackColor = true;
            buttonAddCondition.Click += buttonAddCondition_Click;
            // 
            // buttonRemoveCondition
            // 
            buttonRemoveCondition.Dock = DockStyle.Fill;
            buttonRemoveCondition.Location = new Point(163, 3);
            buttonRemoveCondition.Name = "buttonRemoveCondition";
            buttonRemoveCondition.Size = new Size(154, 48);
            buttonRemoveCondition.TabIndex = 1;
            buttonRemoveCondition.Text = "Remove Condition";
            buttonRemoveCondition.UseVisualStyleBackColor = true;
            buttonRemoveCondition.Click += buttonRemoveCondition_Click;
            // 
            // buttonApplyCondition
            // 
            buttonApplyCondition.Dock = DockStyle.Fill;
            buttonApplyCondition.Location = new Point(719, 3);
            buttonApplyCondition.Name = "buttonApplyCondition";
            buttonApplyCondition.Size = new Size(154, 48);
            buttonApplyCondition.TabIndex = 2;
            buttonApplyCondition.Text = "Apply Condition";
            buttonApplyCondition.UseVisualStyleBackColor = true;
            buttonApplyCondition.Click += buttonApplyCondition_Click;
            // 
            // buttonTest
            // 
            buttonTest.Dock = DockStyle.Fill;
            buttonTest.Location = new Point(559, 3);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(154, 48);
            buttonTest.TabIndex = 3;
            buttonTest.Text = "Test Function";
            buttonTest.UseVisualStyleBackColor = true;
            buttonTest.Click += buttonTest_Click;
            // 
            // EditEligibilityForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(882, 553);
            Controls.Add(tableLayoutPanel1);
            Name = "EditEligibilityForm";
            Text = "EditEligibilityForm";
            tableLayoutPanel1.ResumeLayout(false);
            groupBoxConditions.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBoxConditions;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonAddCondition;
        private Button buttonRemoveCondition;
        private Button buttonApplyCondition;
        private TableLayoutPanel tableLayoutPanelConditions;
        private Button buttonTest;
    }
}