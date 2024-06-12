namespace CheckSumCalculator
{
    partial class CheckSumCalculator
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
            label1 = new Label();
            partialCodeTextBox = new TextBox();
            calculateCheckSumBtn = new Button();
            ckValueTitleLbl = new Label();
            codeWithCKValueTitleLbl = new Label();
            checkSumValueLbl = new Label();
            codeWithCheckSumValueLbl = new Label();
            clearScreenBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Code(PAN):";
            // 
            // partialCodeTextBox
            // 
            partialCodeTextBox.Location = new Point(116, 22);
            partialCodeTextBox.Name = "partialCodeTextBox";
            partialCodeTextBox.Size = new Size(473, 23);
            partialCodeTextBox.TabIndex = 1;
            partialCodeTextBox.TextChanged += partialCodeTextBox_TextChanged;
            // 
            // calculateCheckSumBtn
            // 
            calculateCheckSumBtn.Location = new Point(447, 60);
            calculateCheckSumBtn.Name = "calculateCheckSumBtn";
            calculateCheckSumBtn.Size = new Size(142, 23);
            calculateCheckSumBtn.TabIndex = 2;
            calculateCheckSumBtn.Text = "Calculate CheckSum";
            calculateCheckSumBtn.UseVisualStyleBackColor = true;
            calculateCheckSumBtn.Click += calculateCheckSumBtn_Click;
            // 
            // ckValueTitleLbl
            // 
            ckValueTitleLbl.AutoSize = true;
            ckValueTitleLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckValueTitleLbl.Location = new Point(12, 113);
            ckValueTitleLbl.Name = "ckValueTitleLbl";
            ckValueTitleLbl.Size = new Size(102, 15);
            ckValueTitleLbl.TabIndex = 3;
            ckValueTitleLbl.Text = "CheckSum Value:";
            // 
            // codeWithCKValueTitleLbl
            // 
            codeWithCKValueTitleLbl.AutoSize = true;
            codeWithCKValueTitleLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            codeWithCKValueTitleLbl.Location = new Point(160, 113);
            codeWithCKValueTitleLbl.Name = "codeWithCKValueTitleLbl";
            codeWithCKValueTitleLbl.Size = new Size(163, 15);
            codeWithCKValueTitleLbl.TabIndex = 4;
            codeWithCKValueTitleLbl.Text = "Code With CheckSum Value:";
            // 
            // checkSumValueLbl
            // 
            checkSumValueLbl.AutoSize = true;
            checkSumValueLbl.Location = new Point(116, 113);
            checkSumValueLbl.Name = "checkSumValueLbl";
            checkSumValueLbl.Size = new Size(0, 15);
            checkSumValueLbl.TabIndex = 5;
            // 
            // codeWithCheckSumValueLbl
            // 
            codeWithCheckSumValueLbl.AutoSize = true;
            codeWithCheckSumValueLbl.Location = new Point(329, 113);
            codeWithCheckSumValueLbl.Name = "codeWithCheckSumValueLbl";
            codeWithCheckSumValueLbl.Size = new Size(0, 15);
            codeWithCheckSumValueLbl.TabIndex = 6;
            // 
            // clearScreenBtn
            // 
            clearScreenBtn.Location = new Point(281, 60);
            clearScreenBtn.Name = "clearScreenBtn";
            clearScreenBtn.Size = new Size(142, 23);
            clearScreenBtn.TabIndex = 7;
            clearScreenBtn.Text = "Clear Screen";
            clearScreenBtn.UseVisualStyleBackColor = true;
            clearScreenBtn.Click += clearScreenBtn_Click;
            // 
            // CheckSumCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 142);
            Controls.Add(clearScreenBtn);
            Controls.Add(codeWithCheckSumValueLbl);
            Controls.Add(checkSumValueLbl);
            Controls.Add(codeWithCKValueTitleLbl);
            Controls.Add(ckValueTitleLbl);
            Controls.Add(calculateCheckSumBtn);
            Controls.Add(partialCodeTextBox);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CheckSumCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckSum Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox partialCodeTextBox;
        private Button calculateCheckSumBtn;
        private Label ckValueTitleLbl;
        private Label codeWithCKValueTitleLbl;
        private Label checkSumValueLbl;
        private Label codeWithCheckSumValueLbl;
        private Button clearScreenBtn;
    }
}
