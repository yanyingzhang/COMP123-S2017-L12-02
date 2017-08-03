namespace COMP123_S2017_L12_02
{
    partial class CalculatorForm
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
            this.ButtonLabel = new System.Windows.Forms.TableLayoutPanel();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.TimeButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.PMButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.EqualSign = new System.Windows.Forms.Button();
            this.ButtonLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonLabel
            // 
            this.ButtonLabel.ColumnCount = 4;
            this.ButtonLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonLabel.Controls.Add(this.EqualSign, 3, 4);
            this.ButtonLabel.Controls.Add(this.DecimalButton, 2, 4);
            this.ButtonLabel.Controls.Add(this.ZeroButton, 1, 4);
            this.ButtonLabel.Controls.Add(this.PMButton, 0, 4);
            this.ButtonLabel.Controls.Add(this.PlusButton, 3, 3);
            this.ButtonLabel.Controls.Add(this.ThreeButton, 2, 3);
            this.ButtonLabel.Controls.Add(this.TwoButton, 1, 3);
            this.ButtonLabel.Controls.Add(this.OneButton, 0, 3);
            this.ButtonLabel.Controls.Add(this.MinusButton, 3, 2);
            this.ButtonLabel.Controls.Add(this.SixButton, 2, 2);
            this.ButtonLabel.Controls.Add(this.FiveButton, 1, 2);
            this.ButtonLabel.Controls.Add(this.FourButton, 0, 2);
            this.ButtonLabel.Controls.Add(this.TimeButton, 3, 1);
            this.ButtonLabel.Controls.Add(this.NineButton, 2, 1);
            this.ButtonLabel.Controls.Add(this.EightButton, 1, 1);
            this.ButtonLabel.Controls.Add(this.SevenButton, 0, 1);
            this.ButtonLabel.Controls.Add(this.DivideButton, 3, 0);
            this.ButtonLabel.Controls.Add(this.DelButton, 2, 0);
            this.ButtonLabel.Controls.Add(this.ClearButton, 0, 0);
            this.ButtonLabel.Location = new System.Drawing.Point(4, 124);
            this.ButtonLabel.Name = "ButtonLabel";
            this.ButtonLabel.RowCount = 5;
            this.ButtonLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonLabel.Size = new System.Drawing.Size(290, 299);
            this.ButtonLabel.TabIndex = 0;
            this.ButtonLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonLabel_Paint);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.White;
            this.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Location = new System.Drawing.Point(7, 12);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(287, 109);
            this.ResultTextBox.TabIndex = 1;
            this.ResultTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ClearButton
            // 
            this.ButtonLabel.SetColumnSpan(this.ClearButton, 2);
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(3, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(138, 53);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // DelButton
            // 
            this.DelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelButton.Location = new System.Drawing.Point(147, 3);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(66, 53);
            this.DelButton.TabIndex = 2;
            this.DelButton.Text = "⌫";
            this.DelButton.UseVisualStyleBackColor = true;
            // 
            // DivideButton
            // 
            this.DivideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideButton.Location = new System.Drawing.Point(219, 3);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(68, 53);
            this.DivideButton.TabIndex = 3;
            this.DivideButton.Text = "÷";
            this.DivideButton.UseVisualStyleBackColor = true;
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.White;
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.Location = new System.Drawing.Point(3, 62);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(66, 53);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.White;
            this.EightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.Location = new System.Drawing.Point(75, 62);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(66, 53);
            this.EightButton.TabIndex = 5;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.Color.White;
            this.NineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineButton.Location = new System.Drawing.Point(147, 62);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(66, 53);
            this.NineButton.TabIndex = 6;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            // 
            // TimeButton
            // 
            this.TimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeButton.Location = new System.Drawing.Point(219, 62);
            this.TimeButton.Name = "TimeButton";
            this.TimeButton.Size = new System.Drawing.Size(68, 53);
            this.TimeButton.TabIndex = 7;
            this.TimeButton.Text = "x";
            this.TimeButton.UseVisualStyleBackColor = true;
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.White;
            this.FourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourButton.Location = new System.Drawing.Point(3, 121);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(66, 53);
            this.FourButton.TabIndex = 8;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.button9_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.White;
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveButton.Location = new System.Drawing.Point(75, 121);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(66, 53);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.button10_Click);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.White;
            this.SixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixButton.Location = new System.Drawing.Point(147, 121);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(66, 53);
            this.SixButton.TabIndex = 10;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            // 
            // MinusButton
            // 
            this.MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusButton.Location = new System.Drawing.Point(219, 121);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(68, 53);
            this.MinusButton.TabIndex = 11;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.White;
            this.OneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneButton.Location = new System.Drawing.Point(3, 180);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(66, 53);
            this.OneButton.TabIndex = 12;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.White;
            this.TwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButton.Location = new System.Drawing.Point(75, 180);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(66, 53);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.White;
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeButton.Location = new System.Drawing.Point(147, 180);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(66, 53);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            // 
            // PlusButton
            // 
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusButton.Location = new System.Drawing.Point(219, 180);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(68, 53);
            this.PlusButton.TabIndex = 15;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            // 
            // PMButton
            // 
            this.PMButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMButton.Location = new System.Drawing.Point(3, 239);
            this.PMButton.Name = "PMButton";
            this.PMButton.Size = new System.Drawing.Size(66, 53);
            this.PMButton.TabIndex = 16;
            this.PMButton.Text = "±";
            this.PMButton.UseVisualStyleBackColor = true;
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.White;
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.Location = new System.Drawing.Point(75, 239);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(66, 53);
            this.ZeroButton.TabIndex = 17;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            // 
            // DecimalButton
            // 
            this.DecimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecimalButton.Location = new System.Drawing.Point(147, 239);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(66, 53);
            this.DecimalButton.TabIndex = 18;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            // 
            // EqualSign
            // 
            this.EqualSign.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EqualSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualSign.Location = new System.Drawing.Point(219, 239);
            this.EqualSign.Name = "EqualSign";
            this.EqualSign.Size = new System.Drawing.Size(68, 53);
            this.EqualSign.TabIndex = 19;
            this.EqualSign.Text = "=";
            this.EqualSign.UseVisualStyleBackColor = false;
            // 
            // CalculatorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(298, 424);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ButtonLabel);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.ButtonLabel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ButtonLabel;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button EqualSign;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button PMButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button TimeButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button DelButton;
    }
}

