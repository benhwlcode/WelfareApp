﻿namespace WelfareApp
{
    partial class StartupForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxListOfPrograms = new ListBox();
            textBoxSearchValue = new TextBox();
            labelSearchText = new Label();
            buttonCreateNewProgram = new Button();
            buttonCreateNewApplication = new Button();
            buttonListOfApplications = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxListOfPrograms
            // 
            listBoxListOfPrograms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxListOfPrograms.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxListOfPrograms.FormattingEnabled = true;
            listBoxListOfPrograms.ItemHeight = 28;
            listBoxListOfPrograms.Location = new Point(13, 49);
            listBoxListOfPrograms.Margin = new Padding(4);
            listBoxListOfPrograms.Name = "listBoxListOfPrograms";
            listBoxListOfPrograms.Size = new Size(558, 536);
            listBoxListOfPrograms.TabIndex = 0;
            listBoxListOfPrograms.DoubleClick += listBoxListOfPrograms_DoubleClick;
            // 
            // textBoxSearchValue
            // 
            textBoxSearchValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchValue.Location = new Point(95, 15);
            textBoxSearchValue.Margin = new Padding(4);
            textBoxSearchValue.Name = "textBoxSearchValue";
            textBoxSearchValue.Size = new Size(369, 34);
            textBoxSearchValue.TabIndex = 1;
            textBoxSearchValue.TextChanged += textBoxSearchValue_TextChanged;
            // 
            // labelSearchText
            // 
            labelSearchText.AutoSize = true;
            labelSearchText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSearchText.Location = new Point(13, 21);
            labelSearchText.Margin = new Padding(4, 0, 4, 0);
            labelSearchText.Name = "labelSearchText";
            labelSearchText.Size = new Size(74, 28);
            labelSearchText.TabIndex = 2;
            labelSearchText.Text = "Search:";
            // 
            // buttonCreateNewProgram
            // 
            buttonCreateNewProgram.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCreateNewProgram.Location = new Point(3, 3);
            buttonCreateNewProgram.Name = "buttonCreateNewProgram";
            buttonCreateNewProgram.Size = new Size(180, 102);
            buttonCreateNewProgram.TabIndex = 3;
            buttonCreateNewProgram.Text = "Create New Program";
            buttonCreateNewProgram.UseVisualStyleBackColor = true;
            buttonCreateNewProgram.Click += buttonCreateNewProgram_Click;
            // 
            // buttonCreateNewApplication
            // 
            buttonCreateNewApplication.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCreateNewApplication.Location = new Point(189, 3);
            buttonCreateNewApplication.Name = "buttonCreateNewApplication";
            buttonCreateNewApplication.Size = new Size(180, 102);
            buttonCreateNewApplication.TabIndex = 4;
            buttonCreateNewApplication.Text = "Create New Application";
            buttonCreateNewApplication.UseVisualStyleBackColor = true;
            buttonCreateNewApplication.Click += buttonCreateNewApplication_Click;
            // 
            // buttonListOfApplications
            // 
            buttonListOfApplications.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonListOfApplications.Location = new Point(375, 3);
            buttonListOfApplications.Name = "buttonListOfApplications";
            buttonListOfApplications.Size = new Size(181, 102);
            buttonListOfApplications.TabIndex = 5;
            buttonListOfApplications.Text = "List of Applications";
            buttonListOfApplications.UseVisualStyleBackColor = true;
            buttonListOfApplications.Click += buttonListOfApplications_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 186F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 186F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 186F));
            tableLayoutPanel1.Controls.Add(buttonCreateNewProgram, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonListOfApplications, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonCreateNewApplication, 1, 0);
            tableLayoutPanel1.Location = new Point(13, 592);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(559, 108);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // StartupForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 716);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(labelSearchText);
            Controls.Add(textBoxSearchValue);
            Controls.Add(listBoxListOfPrograms);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MinimumSize = new Size(600, 700);
            Name = "StartupForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "StartupForm";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxListOfPrograms;
        private TextBox textBoxSearchValue;
        private Label labelSearchText;
        private Button buttonCreateNewProgram;
        private Button buttonCreateNewApplication;
        private Button buttonListOfApplications;
        private TableLayoutPanel tableLayoutPanel1;
    }
}