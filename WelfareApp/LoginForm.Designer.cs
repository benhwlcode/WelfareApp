﻿namespace WelfareApp
{
    partial class LoginForm
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
            buttonLogin = new Button();
            buttonCsvForm = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            labelUsernameText = new Label();
            labelPasswordText = new Label();
            textBoxUsernameValue = new TextBox();
            textBoxPasswordValue = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Location = new Point(14, 16);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(526, 316);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonLogin, 1, 0);
            tableLayoutPanel2.Controls.Add(buttonCsvForm, 2, 0);
            tableLayoutPanel2.Location = new Point(3, 162);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(520, 150);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(194, 4);
            buttonLogin.Margin = new Padding(3, 4, 3, 4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(130, 64);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCsvForm
            // 
            buttonCsvForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCsvForm.Location = new Point(423, 118);
            buttonCsvForm.Name = "buttonCsvForm";
            buttonCsvForm.Size = new Size(94, 29);
            buttonCsvForm.TabIndex = 1;
            buttonCsvForm.Text = "CSV";
            buttonCsvForm.UseVisualStyleBackColor = true;
            buttonCsvForm.Click += buttonCsvForm_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 457F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 1);
            tableLayoutPanel3.Location = new Point(3, 4);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
            tableLayoutPanel3.Size = new Size(520, 150);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(labelUsernameText, 0, 0);
            tableLayoutPanel4.Controls.Add(labelPasswordText, 0, 1);
            tableLayoutPanel4.Controls.Add(textBoxUsernameValue, 1, 0);
            tableLayoutPanel4.Controls.Add(textBoxPasswordValue, 1, 1);
            tableLayoutPanel4.Location = new Point(34, -6);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(451, 149);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // labelUsernameText
            // 
            labelUsernameText.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelUsernameText.AutoSize = true;
            labelUsernameText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsernameText.Location = new Point(31, 46);
            labelUsernameText.Name = "labelUsernameText";
            labelUsernameText.Size = new Size(103, 28);
            labelUsernameText.TabIndex = 0;
            labelUsernameText.Text = "Username:";
            // 
            // labelPasswordText
            // 
            labelPasswordText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelPasswordText.AutoSize = true;
            labelPasswordText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPasswordText.Location = new Point(37, 74);
            labelPasswordText.Name = "labelPasswordText";
            labelPasswordText.Size = new Size(97, 28);
            labelPasswordText.TabIndex = 1;
            labelPasswordText.Text = "Password:";
            // 
            // textBoxUsernameValue
            // 
            textBoxUsernameValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxUsernameValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsernameValue.Location = new Point(140, 36);
            textBoxUsernameValue.Margin = new Padding(3, 4, 3, 4);
            textBoxUsernameValue.Name = "textBoxUsernameValue";
            textBoxUsernameValue.Size = new Size(306, 34);
            textBoxUsernameValue.TabIndex = 2;
            // 
            // textBoxPasswordValue
            // 
            textBoxPasswordValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPasswordValue.Location = new Point(140, 78);
            textBoxPasswordValue.Margin = new Padding(3, 4, 3, 4);
            textBoxPasswordValue.Name = "textBoxPasswordValue";
            textBoxPasswordValue.Size = new Size(306, 34);
            textBoxPasswordValue.TabIndex = 3;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 348);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "LoginForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonLogin;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label labelUsernameText;
        private Label labelPasswordText;
        private TextBox textBoxUsernameValue;
        private TextBox textBoxPasswordValue;
        private Button buttonCsvForm;
    }
}