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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            buttonShowValid = new Button();
            buttonShowInvalid = new Button();
            buttonInsertData = new Button();
            buttonCount = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(400, 500);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(470, 12);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(400, 500);
            dataGridView2.TabIndex = 1;
            // 
            // buttonShowValid
            // 
            buttonShowValid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonShowValid.Location = new Point(12, 564);
            buttonShowValid.Name = "buttonShowValid";
            buttonShowValid.Size = new Size(180, 40);
            buttonShowValid.TabIndex = 2;
            buttonShowValid.Text = "Show Valid";
            buttonShowValid.UseVisualStyleBackColor = true;
            buttonShowValid.Click += buttonShowValid_Click;
            // 
            // buttonShowInvalid
            // 
            buttonShowInvalid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonShowInvalid.Location = new Point(12, 610);
            buttonShowInvalid.Name = "buttonShowInvalid";
            buttonShowInvalid.Size = new Size(180, 40);
            buttonShowInvalid.TabIndex = 3;
            buttonShowInvalid.Text = "Show Invalid";
            buttonShowInvalid.UseVisualStyleBackColor = true;
            buttonShowInvalid.Click += buttonShowInvalid_Click;
            // 
            // buttonInsertData
            // 
            buttonInsertData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInsertData.Location = new Point(12, 518);
            buttonInsertData.Name = "buttonInsertData";
            buttonInsertData.Size = new Size(180, 40);
            buttonInsertData.TabIndex = 4;
            buttonInsertData.Text = "Insert Data";
            buttonInsertData.UseVisualStyleBackColor = true;
            buttonInsertData.Click += buttonInsertData_Click;
            // 
            // buttonCount
            // 
            buttonCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCount.Location = new Point(232, 518);
            buttonCount.Name = "buttonCount";
            buttonCount.Size = new Size(180, 40);
            buttonCount.TabIndex = 5;
            buttonCount.Text = "Insert Count";
            buttonCount.UseVisualStyleBackColor = true;
            buttonCount.Click += buttonCount_Click;
            // 
            // CsvDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 653);
            Controls.Add(buttonCount);
            Controls.Add(buttonInsertData);
            Controls.Add(buttonShowInvalid);
            Controls.Add(buttonShowValid);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "CsvDataForm";
            Text = "CsvDataForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button buttonShowValid;
        private Button buttonShowInvalid;
        private Button buttonInsertData;
        private Button buttonCount;
    }
}