namespace WelfareApp
{
    partial class CsvDataForm
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
            buttonInsertData = new Button();
            SuspendLayout();
            // 
            // buttonInsertData
            // 
            buttonInsertData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInsertData.Location = new Point(12, 12);
            buttonInsertData.Name = "buttonInsertData";
            buttonInsertData.Size = new Size(180, 40);
            buttonInsertData.TabIndex = 4;
            buttonInsertData.Text = "Insert Data";
            buttonInsertData.UseVisualStyleBackColor = true;
            buttonInsertData.Click += buttonInsertData_Click;
            // 
            // CsvDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(211, 67);
            Controls.Add(buttonInsertData);
            Name = "CsvDataForm";
            Text = "CsvDataForm";
            ResumeLayout(false);
        }

        #endregion
        private Button buttonInsertData;
    }
}