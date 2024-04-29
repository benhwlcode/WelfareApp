namespace WelfareApp
{
    partial class EditFilterForm
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
            groupBoxFilters = new GroupBox();
            tableLayoutPanelFilters = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonAdd = new Button();
            buttonRemove = new Button();
            buttonApply = new Button();
            tableLayoutPanel1.SuspendLayout();
            groupBoxFilters.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBoxFilters, 0, 0);
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
            // groupBoxFilters
            // 
            groupBoxFilters.Controls.Add(tableLayoutPanelFilters);
            groupBoxFilters.Dock = DockStyle.Fill;
            groupBoxFilters.Location = new Point(3, 3);
            groupBoxFilters.Name = "groupBoxFilters";
            groupBoxFilters.Size = new Size(876, 487);
            groupBoxFilters.TabIndex = 0;
            groupBoxFilters.TabStop = false;
            groupBoxFilters.Text = "Filters";
            // 
            // tableLayoutPanelFilters
            // 
            tableLayoutPanelFilters.ColumnCount = 1;
            tableLayoutPanelFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelFilters.Dock = DockStyle.Fill;
            tableLayoutPanelFilters.Location = new Point(3, 23);
            tableLayoutPanelFilters.Name = "tableLayoutPanelFilters";
            tableLayoutPanelFilters.RowCount = 1;
            tableLayoutPanelFilters.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelFilters.Size = new Size(870, 461);
            tableLayoutPanelFilters.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel2.Controls.Add(buttonAdd, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonRemove, 1, 0);
            tableLayoutPanel2.Controls.Add(buttonApply, 4, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 496);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(876, 54);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Location = new Point(3, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(154, 48);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add Filter";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Dock = DockStyle.Fill;
            buttonRemove.Location = new Point(163, 3);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(154, 48);
            buttonRemove.TabIndex = 1;
            buttonRemove.Text = "Remove Filter";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonApply
            // 
            buttonApply.Dock = DockStyle.Fill;
            buttonApply.Location = new Point(719, 3);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(154, 48);
            buttonApply.TabIndex = 2;
            buttonApply.Text = "Apply Filter";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += buttonApply_Click;
            // 
            // EditFilterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(882, 553);
            Controls.Add(tableLayoutPanel1);
            Name = "EditFilterForm";
            Text = "EditFilterForm";
            tableLayoutPanel1.ResumeLayout(false);
            groupBoxFilters.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBoxFilters;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonAdd;
        private Button buttonRemove;
        private Button buttonApply;
        private TableLayoutPanel tableLayoutPanelFilters;
    }
}