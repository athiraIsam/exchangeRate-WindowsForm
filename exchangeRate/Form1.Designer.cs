
namespace exchangeRate
{
    partial class Form1
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
            this.title = new System.Windows.Forms.Label();
            this.rbBritishRate = new System.Windows.Forms.RadioButton();
            this.rbMexicanRate = new System.Windows.Forms.RadioButton();
            this.menuChoiceLabel = new System.Windows.Forms.Label();
            this.rbJapanaseRate = new System.Windows.Forms.RadioButton();
            this.usdDollarInput = new System.Windows.Forms.TextBox();
            this.usdDollarLabel = new System.Windows.Forms.Label();
            this.caculateBtn = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputRate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(184, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(418, 15);
            this.title.TabIndex = 0;
            this.title.Text = "===============American Dollars Rate Converter===============";
            // 
            // rbBritishRate
            // 
            this.rbBritishRate.AutoSize = true;
            this.rbBritishRate.Location = new System.Drawing.Point(21, 57);
            this.rbBritishRate.Name = "rbBritishRate";
            this.rbBritishRate.Size = new System.Drawing.Size(101, 19);
            this.rbBritishRate.TabIndex = 1;
            this.rbBritishRate.TabStop = true;
            this.rbBritishRate.Text = "British Pounds";
            this.rbBritishRate.UseVisualStyleBackColor = true;
            // 
            // rbMexicanRate
            // 
            this.rbMexicanRate.AutoSize = true;
            this.rbMexicanRate.Location = new System.Drawing.Point(21, 82);
            this.rbMexicanRate.Name = "rbMexicanRate";
            this.rbMexicanRate.Size = new System.Drawing.Size(103, 19);
            this.rbMexicanRate.TabIndex = 2;
            this.rbMexicanRate.TabStop = true;
            this.rbMexicanRate.Text = "Mexican Pesos";
            this.rbMexicanRate.UseVisualStyleBackColor = true;
            // 
            // menuChoiceLabel
            // 
            this.menuChoiceLabel.AutoSize = true;
            this.menuChoiceLabel.Location = new System.Drawing.Point(21, 36);
            this.menuChoiceLabel.Name = "menuChoiceLabel";
            this.menuChoiceLabel.Size = new System.Drawing.Size(103, 15);
            this.menuChoiceLabel.TabIndex = 3;
            this.menuChoiceLabel.Text = "Please Select Rate:";
            // 
            // rbJapanaseRate
            // 
            this.rbJapanaseRate.AutoSize = true;
            this.rbJapanaseRate.Location = new System.Drawing.Point(21, 107);
            this.rbJapanaseRate.Name = "rbJapanaseRate";
            this.rbJapanaseRate.Size = new System.Drawing.Size(94, 19);
            this.rbJapanaseRate.TabIndex = 4;
            this.rbJapanaseRate.TabStop = true;
            this.rbJapanaseRate.Text = "Japanase Yen";
            this.rbJapanaseRate.UseVisualStyleBackColor = true;
            // 
            // usdDollarInput
            // 
            this.usdDollarInput.Location = new System.Drawing.Point(144, 27);
            this.usdDollarInput.Name = "usdDollarInput";
            this.usdDollarInput.Size = new System.Drawing.Size(100, 23);
            this.usdDollarInput.TabIndex = 5;
            this.usdDollarInput.Text = "0";
            this.usdDollarInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // usdDollarLabel
            // 
            this.usdDollarLabel.AutoSize = true;
            this.usdDollarLabel.Location = new System.Drawing.Point(6, 30);
            this.usdDollarLabel.Name = "usdDollarLabel";
            this.usdDollarLabel.Size = new System.Drawing.Size(132, 15);
            this.usdDollarLabel.TabIndex = 6;
            this.usdDollarLabel.Text = "Number of USD Dollars:";
            // 
            // caculateBtn
            // 
            this.caculateBtn.Location = new System.Drawing.Point(402, 72);
            this.caculateBtn.Name = "caculateBtn";
            this.caculateBtn.Size = new System.Drawing.Size(75, 23);
            this.caculateBtn.TabIndex = 7;
            this.caculateBtn.Text = "Calculate";
            this.caculateBtn.UseVisualStyleBackColor = true;
            this.caculateBtn.Click += new System.EventHandler(this.caculateBtn_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(6, 59);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(61, 15);
            this.outputLabel.TabIndex = 8;
            this.outputLabel.Text = "Total Rate:";
            // 
            // outputRate
            // 
            this.outputRate.Location = new System.Drawing.Point(144, 59);
            this.outputRate.Name = "outputRate";
            this.outputRate.Size = new System.Drawing.Size(100, 23);
            this.outputRate.TabIndex = 9;
            this.outputRate.Text = "0";
            this.outputRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.caculateBtn);
            this.groupBox1.Controls.Add(this.outputRate);
            this.groupBox1.Controls.Add(this.usdDollarInput);
            this.groupBox1.Controls.Add(this.usdDollarLabel);
            this.groupBox1.Controls.Add(this.outputLabel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(21, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 101);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(27, 261);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 15);
            this.errorLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.rbJapanaseRate);
            this.Controls.Add(this.menuChoiceLabel);
            this.Controls.Add(this.rbMexicanRate);
            this.Controls.Add(this.rbBritishRate);
            this.Controls.Add(this.title);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.RadioButton rbBritishRate;
        private System.Windows.Forms.RadioButton rbMexicanRate;
        private System.Windows.Forms.Label menuChoiceLabel;
        private System.Windows.Forms.RadioButton rbJapanaseRate;
        private System.Windows.Forms.TextBox usdDollarInput;
        private System.Windows.Forms.Label usdDollarLabel;
        private System.Windows.Forms.Button caculateBtn;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox outputRate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label errorLabel;
    }
}

