
namespace Example_Try
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstTestButton = new System.Windows.Forms.Button();
            this.SecondTestButton = new System.Windows.Forms.Button();
            this.ThirdTestButton = new System.Windows.Forms.Button();
            this.InputFieldID = new System.Windows.Forms.TextBox();
            this.progressBarTestF = new System.Windows.Forms.ProgressBar();
            this.progressBarTestS = new System.Windows.Forms.ProgressBar();
            this.progressBarTestT = new System.Windows.Forms.ProgressBar();
            this.StopTestF = new System.Windows.Forms.Button();
            this.StopTestS = new System.Windows.Forms.Button();
            this.StopTestT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelStatusTestT = new System.Windows.Forms.Label();
            this.labelStatusTestS = new System.Windows.Forms.Label();
            this.labelStatusTestF = new System.Windows.Forms.Label();
            this.labelStatusInput = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstTestButton
            // 
            this.FirstTestButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FirstTestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FirstTestButton.Location = new System.Drawing.Point(30, 38);
            this.FirstTestButton.Name = "FirstTestButton";
            this.FirstTestButton.Size = new System.Drawing.Size(75, 23);
            this.FirstTestButton.TabIndex = 0;
            this.FirstTestButton.Text = "Test 1";
            this.FirstTestButton.UseVisualStyleBackColor = false;
            this.FirstTestButton.Click += new System.EventHandler(this.FirstTestButton_Click);
            // 
            // SecondTestButton
            // 
            this.SecondTestButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SecondTestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SecondTestButton.Location = new System.Drawing.Point(30, 67);
            this.SecondTestButton.Name = "SecondTestButton";
            this.SecondTestButton.Size = new System.Drawing.Size(75, 23);
            this.SecondTestButton.TabIndex = 1;
            this.SecondTestButton.Text = "Test 2";
            this.SecondTestButton.UseVisualStyleBackColor = false;
            this.SecondTestButton.Click += new System.EventHandler(this.SecondTestButton_Click);
            // 
            // ThirdTestButton
            // 
            this.ThirdTestButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ThirdTestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThirdTestButton.Location = new System.Drawing.Point(30, 96);
            this.ThirdTestButton.Name = "ThirdTestButton";
            this.ThirdTestButton.Size = new System.Drawing.Size(75, 23);
            this.ThirdTestButton.TabIndex = 2;
            this.ThirdTestButton.Text = "Test 3";
            this.ThirdTestButton.UseVisualStyleBackColor = false;
            this.ThirdTestButton.Click += new System.EventHandler(this.ThirdTestButton_Click);
            // 
            // InputFieldID
            // 
            this.InputFieldID.Location = new System.Drawing.Point(111, 12);
            this.InputFieldID.Name = "InputFieldID";
            this.InputFieldID.Size = new System.Drawing.Size(238, 20);
            this.InputFieldID.TabIndex = 3;
            // 
            // progressBarTestF
            // 
            this.progressBarTestF.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressBarTestF.ForeColor = System.Drawing.Color.Green;
            this.progressBarTestF.Location = new System.Drawing.Point(111, 38);
            this.progressBarTestF.Name = "progressBarTestF";
            this.progressBarTestF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBarTestF.Size = new System.Drawing.Size(208, 23);
            this.progressBarTestF.TabIndex = 4;
            // 
            // progressBarTestS
            // 
            this.progressBarTestS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressBarTestS.ForeColor = System.Drawing.Color.Green;
            this.progressBarTestS.Location = new System.Drawing.Point(111, 67);
            this.progressBarTestS.Name = "progressBarTestS";
            this.progressBarTestS.Size = new System.Drawing.Size(208, 23);
            this.progressBarTestS.TabIndex = 5;
            // 
            // progressBarTestT
            // 
            this.progressBarTestT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressBarTestT.ForeColor = System.Drawing.Color.Green;
            this.progressBarTestT.Location = new System.Drawing.Point(111, 96);
            this.progressBarTestT.Name = "progressBarTestT";
            this.progressBarTestT.Size = new System.Drawing.Size(208, 23);
            this.progressBarTestT.TabIndex = 6;
            // 
            // StopTestF
            // 
            this.StopTestF.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StopTestF.BackgroundImage = global::Example_Try.Properties.Resources.stop;
            this.StopTestF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StopTestF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopTestF.Location = new System.Drawing.Point(325, 37);
            this.StopTestF.Name = "StopTestF";
            this.StopTestF.Size = new System.Drawing.Size(24, 24);
            this.StopTestF.TabIndex = 7;
            this.StopTestF.UseVisualStyleBackColor = false;
            this.StopTestF.Click += new System.EventHandler(this.StopTestF_Click);
            // 
            // StopTestS
            // 
            this.StopTestS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StopTestS.BackgroundImage = global::Example_Try.Properties.Resources.stop;
            this.StopTestS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StopTestS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopTestS.Location = new System.Drawing.Point(325, 67);
            this.StopTestS.Name = "StopTestS";
            this.StopTestS.Size = new System.Drawing.Size(24, 24);
            this.StopTestS.TabIndex = 8;
            this.StopTestS.UseVisualStyleBackColor = false;
            this.StopTestS.Click += new System.EventHandler(this.StopTestS_Click);
            // 
            // StopTestT
            // 
            this.StopTestT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StopTestT.BackgroundImage = global::Example_Try.Properties.Resources.stop;
            this.StopTestT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StopTestT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopTestT.Location = new System.Drawing.Point(325, 96);
            this.StopTestT.Name = "StopTestT";
            this.StopTestT.Size = new System.Drawing.Size(24, 24);
            this.StopTestT.TabIndex = 9;
            this.StopTestT.UseVisualStyleBackColor = false;
            this.StopTestT.Click += new System.EventHandler(this.StopTestT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.labelStatusTestT);
            this.panel1.Controls.Add(this.labelStatusTestS);
            this.panel1.Controls.Add(this.labelStatusTestF);
            this.panel1.Controls.Add(this.labelStatusInput);
            this.panel1.Location = new System.Drawing.Point(355, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 108);
            this.panel1.TabIndex = 10;
            // 
            // labelStatusTestT
            // 
            this.labelStatusTestT.AutoSize = true;
            this.labelStatusTestT.Location = new System.Drawing.Point(3, 89);
            this.labelStatusTestT.Name = "labelStatusTestT";
            this.labelStatusTestT.Size = new System.Drawing.Size(0, 13);
            this.labelStatusTestT.TabIndex = 3;
            // 
            // labelStatusTestS
            // 
            this.labelStatusTestS.AutoSize = true;
            this.labelStatusTestS.Location = new System.Drawing.Point(3, 60);
            this.labelStatusTestS.Name = "labelStatusTestS";
            this.labelStatusTestS.Size = new System.Drawing.Size(0, 13);
            this.labelStatusTestS.TabIndex = 2;
            // 
            // labelStatusTestF
            // 
            this.labelStatusTestF.AutoSize = true;
            this.labelStatusTestF.Location = new System.Drawing.Point(3, 31);
            this.labelStatusTestF.Name = "labelStatusTestF";
            this.labelStatusTestF.Size = new System.Drawing.Size(0, 13);
            this.labelStatusTestF.TabIndex = 1;
            // 
            // labelStatusInput
            // 
            this.labelStatusInput.AutoSize = true;
            this.labelStatusInput.Location = new System.Drawing.Point(3, 3);
            this.labelStatusInput.Name = "labelStatusInput";
            this.labelStatusInput.Size = new System.Drawing.Size(0, 13);
            this.labelStatusInput.TabIndex = 0;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox.Location = new System.Drawing.Point(30, 14);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(66, 17);
            this.checkBox.TabIndex = 11;
            this.checkBox.Text = "Random";
            this.checkBox.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(756, 138);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StopTestT);
            this.Controls.Add(this.StopTestS);
            this.Controls.Add(this.StopTestF);
            this.Controls.Add(this.progressBarTestT);
            this.Controls.Add(this.progressBarTestS);
            this.Controls.Add(this.progressBarTestF);
            this.Controls.Add(this.InputFieldID);
            this.Controls.Add(this.ThirdTestButton);
            this.Controls.Add(this.SecondTestButton);
            this.Controls.Add(this.FirstTestButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FirstTestButton;
        private System.Windows.Forms.Button SecondTestButton;
        private System.Windows.Forms.Button ThirdTestButton;
        private System.Windows.Forms.TextBox InputFieldID;
        private System.Windows.Forms.ProgressBar progressBarTestF;
        private System.Windows.Forms.ProgressBar progressBarTestS;
        private System.Windows.Forms.ProgressBar progressBarTestT;
        private System.Windows.Forms.Button StopTestF;
        private System.Windows.Forms.Button StopTestS;
        private System.Windows.Forms.Button StopTestT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelStatusTestT;
        private System.Windows.Forms.Label labelStatusTestS;
        private System.Windows.Forms.Label labelStatusTestF;
        private System.Windows.Forms.Label labelStatusInput;
        private System.Windows.Forms.CheckBox checkBox;
    }
}

