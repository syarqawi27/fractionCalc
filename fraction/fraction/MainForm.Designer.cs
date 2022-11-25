namespace fraction
{
    partial class MainForm
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
            this.qqqq = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CheckBox = new System.Windows.Forms.CheckBox();
            this.MsgLabel = new System.Windows.Forms.Label();
            this.BarPanel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CopyDenomButton = new System.Windows.Forms.Button();
            this.CopyNumerButton = new System.Windows.Forms.Button();
            this.DenomTextBox = new System.Windows.Forms.TextBox();
            this.NumerTextBox = new System.Windows.Forms.TextBox();
            this.DenomLabel = new System.Windows.Forms.Label();
            this.NumerLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.qqqq.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qqqq
            // 
            this.qqqq.Controls.Add(this.tabPage1);
            this.qqqq.Controls.Add(this.tabPage2);
            this.qqqq.Location = new System.Drawing.Point(14, 17);
            this.qqqq.Name = "qqqq";
            this.qqqq.SelectedIndex = 0;
            this.qqqq.Size = new System.Drawing.Size(766, 419);
            this.qqqq.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.CheckBox);
            this.tabPage1.Controls.Add(this.MsgLabel);
            this.tabPage1.Controls.Add(this.BarPanel1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.CopyDenomButton);
            this.tabPage1.Controls.Add(this.CopyNumerButton);
            this.tabPage1.Controls.Add(this.DenomTextBox);
            this.tabPage1.Controls.Add(this.NumerTextBox);
            this.tabPage1.Controls.Add(this.DenomLabel);
            this.tabPage1.Controls.Add(this.NumerLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(758, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "System View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSize = true;
            this.CheckBox.Location = new System.Drawing.Point(49, 310);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(80, 17);
            this.CheckBox.TabIndex = 14;
            this.CheckBox.Text = "checkBox1";
            this.CheckBox.UseVisualStyleBackColor = true;
            // 
            // MsgLabel
            // 
            this.MsgLabel.AutoSize = true;
            this.MsgLabel.Location = new System.Drawing.Point(47, 260);
            this.MsgLabel.Name = "MsgLabel";
            this.MsgLabel.Size = new System.Drawing.Size(50, 13);
            this.MsgLabel.TabIndex = 13;
            this.MsgLabel.Text = "Message";
            // 
            // BarPanel1
            // 
            this.BarPanel1.BackColor = System.Drawing.Color.Black;
            this.BarPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BarPanel1.Location = new System.Drawing.Point(367, 113);
            this.BarPanel1.Name = "BarPanel1";
            this.BarPanel1.Size = new System.Drawing.Size(133, 10);
            this.BarPanel1.TabIndex = 12;
            this.BarPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.BarPanel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 63);
            this.label2.TabIndex = 11;
            this.label2.Text = "1";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 63);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            // 
            // CopyDenomButton
            // 
            this.CopyDenomButton.Location = new System.Drawing.Point(253, 178);
            this.CopyDenomButton.Name = "CopyDenomButton";
            this.CopyDenomButton.Size = new System.Drawing.Size(75, 23);
            this.CopyDenomButton.TabIndex = 9;
            this.CopyDenomButton.Text = ">>>>";
            this.CopyDenomButton.UseVisualStyleBackColor = true;
            this.CopyDenomButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CopyNumerButton
            // 
            this.CopyNumerButton.Location = new System.Drawing.Point(253, 60);
            this.CopyNumerButton.Name = "CopyNumerButton";
            this.CopyNumerButton.Size = new System.Drawing.Size(75, 22);
            this.CopyNumerButton.TabIndex = 8;
            this.CopyNumerButton.Text = ">>>>";
            this.CopyNumerButton.UseVisualStyleBackColor = true;
            this.CopyNumerButton.Click += new System.EventHandler(this.CopyNumerButton_Click);
            // 
            // DenomTextBox
            // 
            this.DenomTextBox.Location = new System.Drawing.Point(117, 180);
            this.DenomTextBox.Name = "DenomTextBox";
            this.DenomTextBox.Size = new System.Drawing.Size(100, 20);
            this.DenomTextBox.TabIndex = 7;
            this.DenomTextBox.TextChanged += new System.EventHandler(this.DenomTextBox_TextChanged);
            // 
            // NumerTextBox
            // 
            this.NumerTextBox.Location = new System.Drawing.Point(117, 62);
            this.NumerTextBox.Name = "NumerTextBox";
            this.NumerTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumerTextBox.TabIndex = 6;
            // 
            // DenomLabel
            // 
            this.DenomLabel.AutoSize = true;
            this.DenomLabel.Location = new System.Drawing.Point(44, 183);
            this.DenomLabel.Name = "DenomLabel";
            this.DenomLabel.Size = new System.Drawing.Size(67, 13);
            this.DenomLabel.TabIndex = 5;
            this.DenomLabel.Text = "Denominator";
            // 
            // NumerLabel
            // 
            this.NumerLabel.AutoSize = true;
            this.NumerLabel.Location = new System.Drawing.Point(55, 65);
            this.NumerLabel.Name = "NumerLabel";
            this.NumerLabel.Size = new System.Drawing.Size(56, 13);
            this.NumerLabel.TabIndex = 4;
            this.NumerLabel.Text = "Numerator";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(758, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Web View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(104, 367);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.qqqq);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.qqqq.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl qqqq;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button CopyDenomButton;
        private System.Windows.Forms.Button CopyNumerButton;
        private System.Windows.Forms.TextBox DenomTextBox;
        private System.Windows.Forms.TextBox NumerTextBox;
        private System.Windows.Forms.Label DenomLabel;
        private System.Windows.Forms.Label NumerLabel;
        private System.Windows.Forms.Panel BarPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MsgLabel;
        private System.Windows.Forms.CheckBox CheckBox;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

