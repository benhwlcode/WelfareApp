namespace WelfareApp
{
    partial class uEligibilityCondition
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            comboBoxProperty = new ComboBox();
            comboBoxCondition = new ComboBox();
            comboBoxDynamic = new ComboBox();
            textBoxInput = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tableLayoutPanel1.Controls.Add(comboBoxProperty, 0, 0);
            tableLayoutPanel1.Controls.Add(comboBoxCondition, 1, 0);
            tableLayoutPanel1.Controls.Add(comboBoxDynamic, 2, 0);
            tableLayoutPanel1.Controls.Add(textBoxInput, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.Size = new Size(660, 40);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBoxProperty
            // 
            comboBoxProperty.Dock = DockStyle.Fill;
            comboBoxProperty.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProperty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxProperty.FormattingEnabled = true;
            comboBoxProperty.Location = new Point(3, 3);
            comboBoxProperty.Name = "comboBoxProperty";
            comboBoxProperty.Size = new Size(194, 36);
            comboBoxProperty.TabIndex = 0;
            comboBoxProperty.SelectedIndexChanged += comboBoxProperty_SelectedIndexChanged;
            // 
            // comboBoxCondition
            // 
            comboBoxCondition.Dock = DockStyle.Fill;
            comboBoxCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCondition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCondition.FormattingEnabled = true;
            comboBoxCondition.Location = new Point(203, 3);
            comboBoxCondition.Name = "comboBoxCondition";
            comboBoxCondition.Size = new Size(54, 36);
            comboBoxCondition.TabIndex = 1;
            // 
            // comboBoxDynamic
            // 
            comboBoxDynamic.Dock = DockStyle.Fill;
            comboBoxDynamic.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDynamic.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDynamic.FormattingEnabled = true;
            comboBoxDynamic.Location = new Point(263, 3);
            comboBoxDynamic.Name = "comboBoxDynamic";
            comboBoxDynamic.Size = new Size(386, 36);
            comboBoxDynamic.TabIndex = 2;
            // 
            // textBoxInput
            // 
            textBoxInput.Dock = DockStyle.Fill;
            textBoxInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxInput.Location = new Point(655, 3);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(2, 34);
            textBoxInput.TabIndex = 3;
            // 
            // uEligibilityCondition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(tableLayoutPanel1);
            Name = "uEligibilityCondition";
            Size = new Size(660, 40);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox comboBoxProperty;
        private ComboBox comboBoxCondition;
        private ComboBox comboBoxDynamic;
        private TextBox textBoxInput;
    }
}
