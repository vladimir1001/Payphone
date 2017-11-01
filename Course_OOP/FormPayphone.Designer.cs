namespace Course_OOP
{
    partial class FormPayphone
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayphone));
            this.groupBox_Card = new System.Windows.Forms.GroupBox();
            this.checkBox_Damaged = new System.Windows.Forms.CheckBox();
            this.textBox_NameCard = new System.Windows.Forms.TextBox();
            this.numericAccount = new System.Windows.Forms.NumericUpDown();
            this.buttonPutTheCard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textScreen = new System.Windows.Forms.TextBox();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_asterisk = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_sharp = new System.Windows.Forms.Button();
            this.mainHandSet = new System.Windows.Forms.PictureBox();
            this.pictureCardReader = new System.Windows.Forms.PictureBox();
            this.Reseter = new System.Windows.Forms.PictureBox();
            this.pictureMainTheme = new System.Windows.Forms.PictureBox();
            this.pictureMemory = new System.Windows.Forms.PictureBox();
            this.groupBox_Card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainHandSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCardReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reseter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMainTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMemory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Card
            // 
            this.groupBox_Card.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Card.Controls.Add(this.checkBox_Damaged);
            this.groupBox_Card.Controls.Add(this.textBox_NameCard);
            this.groupBox_Card.Controls.Add(this.numericAccount);
            this.groupBox_Card.Controls.Add(this.buttonPutTheCard);
            this.groupBox_Card.Controls.Add(this.label2);
            this.groupBox_Card.Controls.Add(this.label1);
            this.groupBox_Card.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Card.Location = new System.Drawing.Point(502, 134);
            this.groupBox_Card.Name = "groupBox_Card";
            this.groupBox_Card.Size = new System.Drawing.Size(200, 330);
            this.groupBox_Card.TabIndex = 1;
            this.groupBox_Card.TabStop = false;
            this.groupBox_Card.Text = "КАРТКА";
            // 
            // checkBox_Damaged
            // 
            this.checkBox_Damaged.AutoSize = true;
            this.checkBox_Damaged.Location = new System.Drawing.Point(24, 221);
            this.checkBox_Damaged.Name = "checkBox_Damaged";
            this.checkBox_Damaged.Size = new System.Drawing.Size(110, 20);
            this.checkBox_Damaged.TabIndex = 5;
            this.checkBox_Damaged.Text = "Пошкоджена";
            this.checkBox_Damaged.UseVisualStyleBackColor = true;
            this.checkBox_Damaged.CheckedChanged += new System.EventHandler(this.checkBox_Damaged_CheckedChanged);
            // 
            // textBox_NameCard
            // 
            this.textBox_NameCard.Location = new System.Drawing.Point(24, 173);
            this.textBox_NameCard.MaxLength = 50;
            this.textBox_NameCard.Name = "textBox_NameCard";
            this.textBox_NameCard.Size = new System.Drawing.Size(147, 22);
            this.textBox_NameCard.TabIndex = 4;
            // 
            // numericAccount
            // 
            this.numericAccount.DecimalPlaces = 1;
            this.numericAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericAccount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericAccount.Location = new System.Drawing.Point(24, 77);
            this.numericAccount.Name = "numericAccount";
            this.numericAccount.Size = new System.Drawing.Size(120, 24);
            this.numericAccount.TabIndex = 3;
            // 
            // buttonPutTheCard
            // 
            this.buttonPutTheCard.Location = new System.Drawing.Point(24, 267);
            this.buttonPutTheCard.Name = "buttonPutTheCard";
            this.buttonPutTheCard.Size = new System.Drawing.Size(147, 46);
            this.buttonPutTheCard.TabIndex = 2;
            this.buttonPutTheCard.Text = "Вставити картку";
            this.buttonPutTheCard.UseVisualStyleBackColor = true;
            this.buttonPutTheCard.Click += new System.EventHandler(this.bPutTheCard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ім\'я";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рахунок";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textScreen
            // 
            this.textScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(60)))), ((int)(((byte)(49)))));
            this.textScreen.Enabled = false;
            this.textScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textScreen.Location = new System.Drawing.Point(249, 255);
            this.textScreen.Multiline = true;
            this.textScreen.Name = "textScreen";
            this.textScreen.Size = new System.Drawing.Size(166, 55);
            this.textScreen.TabIndex = 3;
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(288, 344);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(24, 24);
            this.button_1.TabIndex = 6;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.Num_Click);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(318, 344);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(24, 24);
            this.button_2.TabIndex = 7;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.Num_Click);
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(348, 344);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(24, 24);
            this.button_3.TabIndex = 8;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.Num_Click);
            // 
            // button_4
            // 
            this.button_4.Location = new System.Drawing.Point(288, 374);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(24, 24);
            this.button_4.TabIndex = 9;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.Num_Click);
            // 
            // button_5
            // 
            this.button_5.Location = new System.Drawing.Point(318, 374);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(24, 24);
            this.button_5.TabIndex = 10;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.Num_Click);
            // 
            // button_6
            // 
            this.button_6.Location = new System.Drawing.Point(348, 374);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(24, 24);
            this.button_6.TabIndex = 11;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.Num_Click);
            // 
            // button_7
            // 
            this.button_7.Location = new System.Drawing.Point(288, 404);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(24, 24);
            this.button_7.TabIndex = 12;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.Num_Click);
            // 
            // button_8
            // 
            this.button_8.Location = new System.Drawing.Point(318, 404);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(24, 24);
            this.button_8.TabIndex = 13;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.Num_Click);
            // 
            // button_9
            // 
            this.button_9.Location = new System.Drawing.Point(348, 404);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(24, 24);
            this.button_9.TabIndex = 14;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.Num_Click);
            // 
            // button_asterisk
            // 
            this.button_asterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_asterisk.Location = new System.Drawing.Point(288, 434);
            this.button_asterisk.Name = "button_asterisk";
            this.button_asterisk.Size = new System.Drawing.Size(24, 24);
            this.button_asterisk.TabIndex = 15;
            this.button_asterisk.Text = "*";
            this.button_asterisk.UseVisualStyleBackColor = true;
            this.button_asterisk.Click += new System.EventHandler(this.Num_Click);
            // 
            // button_0
            // 
            this.button_0.Location = new System.Drawing.Point(318, 434);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(24, 24);
            this.button_0.TabIndex = 16;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.Num_Click);
            // 
            // button_sharp
            // 
            this.button_sharp.Location = new System.Drawing.Point(348, 434);
            this.button_sharp.Name = "button_sharp";
            this.button_sharp.Size = new System.Drawing.Size(24, 24);
            this.button_sharp.TabIndex = 17;
            this.button_sharp.Text = "#";
            this.button_sharp.UseVisualStyleBackColor = true;
            this.button_sharp.Click += new System.EventHandler(this.Num_Click);
            // 
            // mainHandSet
            // 
            this.mainHandSet.Image = ((System.Drawing.Image)(resources.GetObject("mainHandSet.Image")));
            this.mainHandSet.InitialImage = null;
            this.mainHandSet.Location = new System.Drawing.Point(0, 160);
            this.mainHandSet.Name = "mainHandSet";
            this.mainHandSet.Size = new System.Drawing.Size(201, 511);
            this.mainHandSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainHandSet.TabIndex = 2;
            this.mainHandSet.TabStop = false;
            this.mainHandSet.Click += new System.EventHandler(this.Handset_Click);
            // 
            // pictureCardReader
            // 
            this.pictureCardReader.Enabled = false;
            this.pictureCardReader.Image = global::Course_OOP.Properties.Resources.CardReader;
            this.pictureCardReader.InitialImage = null;
            this.pictureCardReader.Location = new System.Drawing.Point(270, 36);
            this.pictureCardReader.Name = "pictureCardReader";
            this.pictureCardReader.Size = new System.Drawing.Size(128, 146);
            this.pictureCardReader.TabIndex = 5;
            this.pictureCardReader.TabStop = false;
            this.pictureCardReader.Click += new System.EventHandler(this.pictureCardReader_Click);
            // 
            // Reseter
            // 
            this.Reseter.BackColor = System.Drawing.Color.Transparent;
            this.Reseter.InitialImage = null;
            this.Reseter.Location = new System.Drawing.Point(0, 264);
            this.Reseter.Name = "Reseter";
            this.Reseter.Size = new System.Drawing.Size(195, 74);
            this.Reseter.TabIndex = 0;
            this.Reseter.TabStop = false;
            this.Reseter.Click += new System.EventHandler(this.Reseter_Click);
            // 
            // pictureMainTheme
            // 
            this.pictureMainTheme.Image = global::Course_OOP.Properties.Resources.Payphone_main_theme;
            this.pictureMainTheme.InitialImage = null;
            this.pictureMainTheme.Location = new System.Drawing.Point(0, 0);
            this.pictureMainTheme.Name = "pictureMainTheme";
            this.pictureMainTheme.Size = new System.Drawing.Size(715, 671);
            this.pictureMainTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureMainTheme.TabIndex = 4;
            this.pictureMainTheme.TabStop = false;
            // 
            // pictureMemory
            // 
            this.pictureMemory.BackColor = System.Drawing.Color.Transparent;
            this.pictureMemory.InitialImage = null;
            this.pictureMemory.Location = new System.Drawing.Point(227, 510);
            this.pictureMemory.Name = "pictureMemory";
            this.pictureMemory.Size = new System.Drawing.Size(209, 28);
            this.pictureMemory.TabIndex = 18;
            this.pictureMemory.TabStop = false;
            this.pictureMemory.Click += new System.EventHandler(this.pictureMemory_Click);
            // 
            // FormPayphone
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(715, 670);
            this.Controls.Add(this.pictureMemory);
            this.Controls.Add(this.button_sharp);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_asterisk);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.mainHandSet);
            this.Controls.Add(this.pictureCardReader);
            this.Controls.Add(this.textScreen);
            this.Controls.Add(this.groupBox_Card);
            this.Controls.Add(this.Reseter);
            this.Controls.Add(this.pictureMainTheme);
            this.MaximizeBox = false;
            this.Name = "FormPayphone";
            this.Text = "Таксофон";
            this.groupBox_Card.ResumeLayout(false);
            this.groupBox_Card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainHandSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCardReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reseter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMainTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMemory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.TextBox textScreen;
        private System.Windows.Forms.PictureBox Reseter;
        private System.Windows.Forms.GroupBox groupBox_Card;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox mainHandSet;
        private System.Windows.Forms.Button buttonPutTheCard;
        private System.Windows.Forms.NumericUpDown numericAccount;
        private System.Windows.Forms.TextBox textScreen;
        private System.Windows.Forms.TextBox textBox_NameCard;
        private System.Windows.Forms.CheckBox checkBox_Damaged;
        private System.Windows.Forms.PictureBox pictureMainTheme;
        private System.Windows.Forms.PictureBox pictureCardReader;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_asterisk;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_sharp;
        private System.Windows.Forms.PictureBox pictureMemory;
    }
}

