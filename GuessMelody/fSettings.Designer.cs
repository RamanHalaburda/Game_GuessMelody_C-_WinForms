namespace GuessMelody
{
    partial class fSettings
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.orDirectory = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbGameSettings = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxRandomStart = new System.Windows.Forms.CheckBox();
            this.cbMusicDuration = new System.Windows.Forms.ComboBox();
            this.cbGameDuration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLimitAnswerTime = new System.Windows.Forms.CheckBox();
            this.cBoxLimitAnswerTime = new System.Windows.Forms.ComboBox();
            this.gbGameSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(630, 147);
            this.listBox1.TabIndex = 0;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(13, 167);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.Text = "Выбрать папку";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(95, 167);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 23);
            this.btnClearList.TabIndex = 2;
            this.btnClearList.Text = "Очистить список";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // orDirectory
            // 
            this.orDirectory.AutoSize = true;
            this.orDirectory.Location = new System.Drawing.Point(13, 197);
            this.orDirectory.Name = "orDirectory";
            this.orDirectory.Size = new System.Drawing.Size(194, 17);
            this.orDirectory.TabIndex = 3;
            this.orDirectory.Text = "Обрабатывать вложенные папки";
            this.orDirectory.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(389, 389);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(470, 389);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbGameSettings
            // 
            this.gbGameSettings.Controls.Add(this.cBoxLimitAnswerTime);
            this.gbGameSettings.Controls.Add(this.cbLimitAnswerTime);
            this.gbGameSettings.Controls.Add(this.comboBox1);
            this.gbGameSettings.Controls.Add(this.comboBox2);
            this.gbGameSettings.Controls.Add(this.label3);
            this.gbGameSettings.Controls.Add(this.label4);
            this.gbGameSettings.Controls.Add(this.checkBoxRandomStart);
            this.gbGameSettings.Controls.Add(this.cbMusicDuration);
            this.gbGameSettings.Controls.Add(this.cbGameDuration);
            this.gbGameSettings.Controls.Add(this.label2);
            this.gbGameSettings.Controls.Add(this.label1);
            this.gbGameSettings.Location = new System.Drawing.Point(13, 221);
            this.gbGameSettings.Name = "gbGameSettings";
            this.gbGameSettings.Size = new System.Drawing.Size(630, 165);
            this.gbGameSettings.TabIndex = 6;
            this.gbGameSettings.TabStop = false;
            this.gbGameSettings.Text = "Настройки игры";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "O",
            "P",
            "K",
            "L",
            "N",
            "M"});
            this.comboBox1.Location = new System.Drawing.Point(345, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "P";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Q",
            "W",
            "A",
            "S",
            "Z",
            "X"});
            this.comboBox2.Location = new System.Drawing.Point(345, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Игрок 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Игрок 2";
            // 
            // checkBoxRandomStart
            // 
            this.checkBoxRandomStart.AutoSize = true;
            this.checkBoxRandomStart.Location = new System.Drawing.Point(19, 110);
            this.checkBoxRandomStart.Name = "checkBoxRandomStart";
            this.checkBoxRandomStart.Size = new System.Drawing.Size(133, 17);
            this.checkBoxRandomStart.TabIndex = 4;
            this.checkBoxRandomStart.Text = "Со случайного места";
            this.checkBoxRandomStart.UseVisualStyleBackColor = true;
            // 
            // cbMusicDuration
            // 
            this.cbMusicDuration.FormattingEnabled = true;
            this.cbMusicDuration.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "90",
            "120"});
            this.cbMusicDuration.Location = new System.Drawing.Point(114, 42);
            this.cbMusicDuration.Name = "cbMusicDuration";
            this.cbMusicDuration.Size = new System.Drawing.Size(121, 21);
            this.cbMusicDuration.TabIndex = 3;
            this.cbMusicDuration.Text = "30";
            // 
            // cbGameDuration
            // 
            this.cbGameDuration.FormattingEnabled = true;
            this.cbGameDuration.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cbGameDuration.Location = new System.Drawing.Point(114, 19);
            this.cbGameDuration.Name = "cbGameDuration";
            this.cbGameDuration.Size = new System.Drawing.Size(121, 21);
            this.cbGameDuration.TabIndex = 2;
            this.cbGameDuration.Text = "15";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Время игры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Время ответа";
            // 
            // cbLimitAnswerTime
            // 
            this.cbLimitAnswerTime.AutoSize = true;
            this.cbLimitAnswerTime.Location = new System.Drawing.Point(19, 87);
            this.cbLimitAnswerTime.Name = "cbLimitAnswerTime";
            this.cbLimitAnswerTime.Size = new System.Drawing.Size(169, 17);
            this.cbLimitAnswerTime.TabIndex = 9;
            this.cbLimitAnswerTime.Text = "Ограничивать время ответа";
            this.cbLimitAnswerTime.UseVisualStyleBackColor = true;
            this.cbLimitAnswerTime.CheckedChanged += new System.EventHandler(this.cbLimitAnswerTime_CheckedChanged);
            // 
            // cBoxLimitAnswerTime
            // 
            this.cBoxLimitAnswerTime.FormattingEnabled = true;
            this.cBoxLimitAnswerTime.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cBoxLimitAnswerTime.Location = new System.Drawing.Point(194, 83);
            this.cBoxLimitAnswerTime.Name = "cBoxLimitAnswerTime";
            this.cBoxLimitAnswerTime.Size = new System.Drawing.Size(121, 21);
            this.cBoxLimitAnswerTime.TabIndex = 10;
            this.cBoxLimitAnswerTime.Text = "5";
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 424);
            this.Controls.Add(this.gbGameSettings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.orDirectory);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.listBox1);
            this.Name = "fSettings";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.fSettings_Load);
            this.gbGameSettings.ResumeLayout(false);
            this.gbGameSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.CheckBox orDirectory;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbGameSettings;
        private System.Windows.Forms.CheckBox checkBoxRandomStart;
        private System.Windows.Forms.ComboBox cbMusicDuration;
        private System.Windows.Forms.ComboBox cbGameDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxLimitAnswerTime;
        private System.Windows.Forms.CheckBox cbLimitAnswerTime;
    }
}