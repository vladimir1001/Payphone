namespace Course_OOP
{
    partial class FormHandSet
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
            this.textSend = new System.Windows.Forms.TextBox();
            this.textReceive = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureSend = new System.Windows.Forms.PictureBox();
            this.pictureMainTheme = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMainTheme)).BeginInit();
            this.SuspendLayout();
            // 
            // textSend
            // 
            this.textSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSend.Location = new System.Drawing.Point(155, 261);
            this.textSend.MaxLength = 150;
            this.textSend.Multiline = true;
            this.textSend.Name = "textSend";
            this.textSend.Size = new System.Drawing.Size(187, 103);
            this.textSend.TabIndex = 0;
            // 
            // textReceive
            // 
            this.textReceive.Enabled = false;
            this.textReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textReceive.HideSelection = false;
            this.textReceive.Location = new System.Drawing.Point(155, 54);
            this.textReceive.MaxLength = 150;
            this.textReceive.Multiline = true;
            this.textReceive.Name = "textReceive";
            this.textReceive.ReadOnly = true;
            this.textReceive.ShortcutsEnabled = false;
            this.textReceive.Size = new System.Drawing.Size(187, 88);
            this.textReceive.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(152, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Відповідь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(152, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Передати дані";
            // 
            // pictureSend
            // 
            this.pictureSend.BackColor = System.Drawing.Color.Transparent;
            this.pictureSend.InitialImage = null;
            this.pictureSend.Location = new System.Drawing.Point(51, 261);
            this.pictureSend.Name = "pictureSend";
            this.pictureSend.Size = new System.Drawing.Size(86, 103);
            this.pictureSend.TabIndex = 4;
            this.pictureSend.TabStop = false;
            this.pictureSend.Click += new System.EventHandler(this.pictureSend_Click);
            // 
            // pictureMainTheme
            // 
            this.pictureMainTheme.Image = global::Course_OOP.Properties.Resources.HandSet;
            this.pictureMainTheme.Location = new System.Drawing.Point(-1, -1);
            this.pictureMainTheme.Name = "pictureMainTheme";
            this.pictureMainTheme.Size = new System.Drawing.Size(370, 439);
            this.pictureMainTheme.TabIndex = 5;
            this.pictureMainTheme.TabStop = false;
            // 
            // FormHandSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 436);
            this.Controls.Add(this.pictureSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textReceive);
            this.Controls.Add(this.textSend);
            this.Controls.Add(this.pictureMainTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(0, 90);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHandSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Трубка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMainTheme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSend;
        private System.Windows.Forms.TextBox textReceive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureSend;
        private System.Windows.Forms.PictureBox pictureMainTheme;
    }
}