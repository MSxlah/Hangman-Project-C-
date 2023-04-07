namespace Hangman
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.WordBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB10 = new System.Windows.Forms.TextBox();
            this.TB9 = new System.Windows.Forms.TextBox();
            this.TB8 = new System.Windows.Forms.TextBox();
            this.TB7 = new System.Windows.Forms.TextBox();
            this.TB6 = new System.Windows.Forms.TextBox();
            this.TB5 = new System.Windows.Forms.TextBox();
            this.TB4 = new System.Windows.Forms.TextBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.TB12 = new System.Windows.Forms.TextBox();
            this.TB13 = new System.Windows.Forms.TextBox();
            this.TB11 = new System.Windows.Forms.TextBox();
            this.GuessTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.invalidLettersTB = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // WordBox
            // 
            this.WordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordBox.Location = new System.Drawing.Point(1216, 835);
            this.WordBox.Multiline = true;
            this.WordBox.Name = "WordBox";
            this.WordBox.Size = new System.Drawing.Size(178, 47);
            this.WordBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(51, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 83);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Word";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB1
            // 
            this.TB1.Enabled = false;
            this.TB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB1.Location = new System.Drawing.Point(18, 560);
            this.TB1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB1.Multiline = true;
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(92, 73);
            this.TB1.TabIndex = 4;
            // 
            // TB10
            // 
            this.TB10.Enabled = false;
            this.TB10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB10.Location = new System.Drawing.Point(950, 560);
            this.TB10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB10.Multiline = true;
            this.TB10.Name = "TB10";
            this.TB10.Size = new System.Drawing.Size(92, 73);
            this.TB10.TabIndex = 5;
            this.TB10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB9
            // 
            this.TB9.Enabled = false;
            this.TB9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB9.Location = new System.Drawing.Point(846, 560);
            this.TB9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB9.Multiline = true;
            this.TB9.Name = "TB9";
            this.TB9.Size = new System.Drawing.Size(92, 73);
            this.TB9.TabIndex = 6;
            this.TB9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB8
            // 
            this.TB8.Enabled = false;
            this.TB8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB8.Location = new System.Drawing.Point(742, 560);
            this.TB8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB8.Multiline = true;
            this.TB8.Name = "TB8";
            this.TB8.Size = new System.Drawing.Size(92, 73);
            this.TB8.TabIndex = 7;
            this.TB8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB7
            // 
            this.TB7.Enabled = false;
            this.TB7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB7.Location = new System.Drawing.Point(639, 560);
            this.TB7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB7.Multiline = true;
            this.TB7.Name = "TB7";
            this.TB7.Size = new System.Drawing.Size(92, 73);
            this.TB7.TabIndex = 8;
            this.TB7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB6
            // 
            this.TB6.Enabled = false;
            this.TB6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB6.Location = new System.Drawing.Point(536, 560);
            this.TB6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB6.Multiline = true;
            this.TB6.Name = "TB6";
            this.TB6.Size = new System.Drawing.Size(92, 73);
            this.TB6.TabIndex = 9;
            // 
            // TB5
            // 
            this.TB5.Enabled = false;
            this.TB5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB5.Location = new System.Drawing.Point(432, 560);
            this.TB5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB5.Multiline = true;
            this.TB5.Name = "TB5";
            this.TB5.Size = new System.Drawing.Size(92, 73);
            this.TB5.TabIndex = 10;
            // 
            // TB4
            // 
            this.TB4.Enabled = false;
            this.TB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB4.Location = new System.Drawing.Point(328, 560);
            this.TB4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB4.Multiline = true;
            this.TB4.Name = "TB4";
            this.TB4.Size = new System.Drawing.Size(92, 73);
            this.TB4.TabIndex = 11;
            // 
            // TB3
            // 
            this.TB3.Enabled = false;
            this.TB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB3.Location = new System.Drawing.Point(225, 560);
            this.TB3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB3.Multiline = true;
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(92, 73);
            this.TB3.TabIndex = 12;
            // 
            // TB2
            // 
            this.TB2.Enabled = false;
            this.TB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB2.Location = new System.Drawing.Point(122, 560);
            this.TB2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB2.Multiline = true;
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(92, 73);
            this.TB2.TabIndex = 13;
            // 
            // TB12
            // 
            this.TB12.Enabled = false;
            this.TB12.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB12.Location = new System.Drawing.Point(1156, 560);
            this.TB12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB12.Multiline = true;
            this.TB12.Name = "TB12";
            this.TB12.Size = new System.Drawing.Size(92, 73);
            this.TB12.TabIndex = 14;
            this.TB12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB13
            // 
            this.TB13.Enabled = false;
            this.TB13.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB13.Location = new System.Drawing.Point(1260, 560);
            this.TB13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB13.Multiline = true;
            this.TB13.Name = "TB13";
            this.TB13.Size = new System.Drawing.Size(92, 73);
            this.TB13.TabIndex = 17;
            this.TB13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB11
            // 
            this.TB11.Enabled = false;
            this.TB11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB11.Location = new System.Drawing.Point(1053, 560);
            this.TB11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB11.Multiline = true;
            this.TB11.Name = "TB11";
            this.TB11.Size = new System.Drawing.Size(92, 73);
            this.TB11.TabIndex = 18;
            this.TB11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GuessTB
            // 
            this.GuessTB.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessTB.Location = new System.Drawing.Point(432, 206);
            this.GuessTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GuessTB.Multiline = true;
            this.GuessTB.Name = "GuessTB";
            this.GuessTB.Size = new System.Drawing.Size(127, 92);
            this.GuessTB.TabIndex = 19;
            this.GuessTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 71);
            this.label1.TabIndex = 20;
            this.label1.Text = "Enter your guess:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(225, 334);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 62);
            this.button2.TabIndex = 21;
            this.button2.Text = "Submit";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Poor Richard", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(628, 714);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 60);
            this.ErrorLabel.TabIndex = 22;
            // 
            // invalidLettersTB
            // 
            this.invalidLettersTB.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidLettersTB.Location = new System.Drawing.Point(20, 651);
            this.invalidLettersTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.invalidLettersTB.Multiline = true;
            this.invalidLettersTB.Name = "invalidLettersTB";
            this.invalidLettersTB.Size = new System.Drawing.Size(402, 232);
            this.invalidLettersTB.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1428, 894);
            this.Controls.Add(this.invalidLettersTB);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuessTB);
            this.Controls.Add(this.TB11);
            this.Controls.Add(this.TB13);
            this.Controls.Add(this.TB12);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB4);
            this.Controls.Add(this.TB5);
            this.Controls.Add(this.TB6);
            this.Controls.Add(this.TB7);
            this.Controls.Add(this.TB8);
            this.Controls.Add(this.TB9);
            this.Controls.Add(this.TB10);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WordBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WordBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB10;
        private System.Windows.Forms.TextBox TB9;
        private System.Windows.Forms.TextBox TB8;
        private System.Windows.Forms.TextBox TB7;
        private System.Windows.Forms.TextBox TB6;
        private System.Windows.Forms.TextBox TB5;
        private System.Windows.Forms.TextBox TB4;
        private System.Windows.Forms.TextBox TB3;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.TextBox TB12;
        private System.Windows.Forms.TextBox TB13;
        private System.Windows.Forms.TextBox TB11;
        private System.Windows.Forms.TextBox GuessTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox invalidLettersTB;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

