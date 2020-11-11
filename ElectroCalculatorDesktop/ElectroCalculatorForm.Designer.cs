namespace ElectroCalculatorDesktop
{
    partial class ElectroCalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElectroCalculatorForm));
            this.prevValueLabel = new System.Windows.Forms.Label();
            this.currentValueLabel = new System.Windows.Forms.Label();
            this.prevValueTextBox = new System.Windows.Forms.TextBox();
            this.currentValueTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prevValueLabel
            // 
            this.prevValueLabel.AutoSize = true;
            this.prevValueLabel.Location = new System.Drawing.Point(12, 27);
            this.prevValueLabel.Name = "prevValueLabel";
            this.prevValueLabel.Size = new System.Drawing.Size(181, 13);
            this.prevValueLabel.TabIndex = 0;
            this.prevValueLabel.Text = "Предыдущее показание счетчика:";
            // 
            // currentValueLabel
            // 
            this.currentValueLabel.AutoSize = true;
            this.currentValueLabel.Location = new System.Drawing.Point(12, 69);
            this.currentValueLabel.Name = "currentValueLabel";
            this.currentValueLabel.Size = new System.Drawing.Size(166, 13);
            this.currentValueLabel.TabIndex = 1;
            this.currentValueLabel.Text = "Текущее показаниие счетчика:";
            // 
            // prevValueTextBox
            // 
            this.prevValueTextBox.Location = new System.Drawing.Point(199, 24);
            this.prevValueTextBox.Name = "prevValueTextBox";
            this.prevValueTextBox.Size = new System.Drawing.Size(120, 20);
            this.prevValueTextBox.TabIndex = 2;
            this.prevValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrevValueTextBox_KeyDown);
            // 
            // currentValueTextBox
            // 
            this.currentValueTextBox.Location = new System.Drawing.Point(199, 66);
            this.currentValueTextBox.Name = "currentValueTextBox";
            this.currentValueTextBox.Size = new System.Drawing.Size(120, 20);
            this.currentValueTextBox.TabIndex = 3;
            this.currentValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CurrentValueTextBox_KeyDown);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(135, 116);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ElectroCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 151);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.currentValueTextBox);
            this.Controls.Add(this.prevValueTextBox);
            this.Controls.Add(this.currentValueLabel);
            this.Controls.Add(this.prevValueLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ElectroCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор электроэнергии";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prevValueLabel;
        private System.Windows.Forms.Label currentValueLabel;
        private System.Windows.Forms.TextBox prevValueTextBox;
        private System.Windows.Forms.TextBox currentValueTextBox;
        private System.Windows.Forms.Button calculateButton;
    }
}

