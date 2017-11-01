namespace Course_OOP
{
    partial class FormATS
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
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bIsBusyLine = new System.Windows.Forms.Button();
            this.textAnswer = new System.Windows.Forms.TextBox();
            this.textSend = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bSend = new System.Windows.Forms.Button();
            this.bTake = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Enabled = false;
            this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumber.Location = new System.Drawing.Point(21, 172);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.ReadOnly = true;
            this.textBoxNumber.Size = new System.Drawing.Size(199, 31);
            this.textBoxNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(85, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "АТС";
            // 
            // bIsBusyLine
            // 
            this.bIsBusyLine.Location = new System.Drawing.Point(58, 60);
            this.bIsBusyLine.Name = "bIsBusyLine";
            this.bIsBusyLine.Size = new System.Drawing.Size(114, 42);
            this.bIsBusyLine.TabIndex = 6;
            this.bIsBusyLine.UseVisualStyleBackColor = true;
            this.bIsBusyLine.Click += new System.EventHandler(this.bIsBusyLine_Click);
            // 
            // textAnswer
            // 
            this.textAnswer.Enabled = false;
            this.textAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textAnswer.Location = new System.Drawing.Point(257, 36);
            this.textAnswer.MaxLength = 150;
            this.textAnswer.Multiline = true;
            this.textAnswer.Name = "textAnswer";
            this.textAnswer.ReadOnly = true;
            this.textAnswer.Size = new System.Drawing.Size(197, 125);
            this.textAnswer.TabIndex = 7;
            // 
            // textSend
            // 
            this.textSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSend.Location = new System.Drawing.Point(499, 36);
            this.textSend.MaxLength = 150;
            this.textSend.Multiline = true;
            this.textSend.Name = "textSend";
            this.textSend.Size = new System.Drawing.Size(197, 125);
            this.textSend.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(254, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Відповідь";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(496, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Дані";
            // 
            // bSend
            // 
            this.bSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSend.Location = new System.Drawing.Point(499, 174);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(197, 33);
            this.bSend.TabIndex = 11;
            this.bSend.Text = "Надіслати";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // bTake
            // 
            this.bTake.Location = new System.Drawing.Point(58, 119);
            this.bTake.Name = "bTake";
            this.bTake.Size = new System.Drawing.Size(114, 42);
            this.bTake.TabIndex = 12;
            this.bTake.Text = "Прийняти";
            this.bTake.UseVisualStyleBackColor = true;
            // 
            // FormATS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(725, 211);
            this.ControlBox = false;
            this.Controls.Add(this.bTake);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSend);
            this.Controls.Add(this.textAnswer);
            this.Controls.Add(this.bIsBusyLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(200, 700);
            this.MaximizeBox = false;
            this.Name = "FormATS";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "АТС";
            this.VisibleChanged += new System.EventHandler(this.FormATS_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bIsBusyLine;
        private System.Windows.Forms.TextBox textAnswer;
        private System.Windows.Forms.TextBox textSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.Button bTake;
    }
}