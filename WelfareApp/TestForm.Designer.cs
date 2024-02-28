namespace WelfareApp
{
    partial class TestForm
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
            listBoxListOfTestObjects = new ListBox();
            buttonTestFunctionOne = new Button();
            buttonTestFunctionTwo = new Button();
            buttonTestFunctionThree = new Button();
            textBoxTestValue = new TextBox();
            richTextBoxTestOutput = new RichTextBox();
            SuspendLayout();
            // 
            // listBoxListOfTestObjects
            // 
            listBoxListOfTestObjects.FormattingEnabled = true;
            listBoxListOfTestObjects.ItemHeight = 21;
            listBoxListOfTestObjects.Location = new Point(38, 314);
            listBoxListOfTestObjects.Name = "listBoxListOfTestObjects";
            listBoxListOfTestObjects.Size = new Size(312, 172);
            listBoxListOfTestObjects.TabIndex = 0;
            // 
            // buttonTestFunctionOne
            // 
            buttonTestFunctionOne.Location = new Point(38, 48);
            buttonTestFunctionOne.Name = "buttonTestFunctionOne";
            buttonTestFunctionOne.Size = new Size(100, 50);
            buttonTestFunctionOne.TabIndex = 1;
            buttonTestFunctionOne.Text = "Function 1";
            buttonTestFunctionOne.UseVisualStyleBackColor = true;
            buttonTestFunctionOne.Click += buttonTestFunctionOne_Click;
            // 
            // buttonTestFunctionTwo
            // 
            buttonTestFunctionTwo.Location = new Point(144, 48);
            buttonTestFunctionTwo.Name = "buttonTestFunctionTwo";
            buttonTestFunctionTwo.Size = new Size(100, 50);
            buttonTestFunctionTwo.TabIndex = 3;
            buttonTestFunctionTwo.Text = "Function 2";
            buttonTestFunctionTwo.UseVisualStyleBackColor = true;
            buttonTestFunctionTwo.Click += buttonTestFunctionTwo_Click;
            // 
            // buttonTestFunctionThree
            // 
            buttonTestFunctionThree.Location = new Point(250, 48);
            buttonTestFunctionThree.Name = "buttonTestFunctionThree";
            buttonTestFunctionThree.Size = new Size(100, 50);
            buttonTestFunctionThree.TabIndex = 4;
            buttonTestFunctionThree.Text = "Function 3";
            buttonTestFunctionThree.UseVisualStyleBackColor = true;
            buttonTestFunctionThree.Click += buttonTestFunctionThree_Click;
            // 
            // textBoxTestValue
            // 
            textBoxTestValue.Location = new Point(38, 13);
            textBoxTestValue.Name = "textBoxTestValue";
            textBoxTestValue.Size = new Size(312, 29);
            textBoxTestValue.TabIndex = 5;
            // 
            // richTextBoxTestOutput
            // 
            richTextBoxTestOutput.Location = new Point(38, 104);
            richTextBoxTestOutput.Name = "richTextBoxTestOutput";
            richTextBoxTestOutput.Size = new Size(312, 204);
            richTextBoxTestOutput.TabIndex = 6;
            richTextBoxTestOutput.Text = "";
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 511);
            Controls.Add(richTextBoxTestOutput);
            Controls.Add(textBoxTestValue);
            Controls.Add(buttonTestFunctionThree);
            Controls.Add(buttonTestFunctionTwo);
            Controls.Add(buttonTestFunctionOne);
            Controls.Add(listBoxListOfTestObjects);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "TestForm";
            Text = "TestForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxListOfTestObjects;
        private Button buttonTestFunctionOne;
        private Button buttonTestFunctionTwo;
        private Button buttonTestFunctionThree;
        private TextBox textBoxTestValue;
        private RichTextBox richTextBoxTestOutput;
    }
}