namespace htmlXML
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
            this.checkBox_faculty = new System.Windows.Forms.CheckBox();
            this.checkBox_day = new System.Windows.Forms.CheckBox();
            this.checkBox_leader = new System.Windows.Forms.CheckBox();
            this.checkBox_orientation = new System.Windows.Forms.CheckBox();
            this.checkedListBox5 = new System.Windows.Forms.CheckedListBox();
            this.comboBox_faculty = new System.Windows.Forms.ComboBox();
            this.comboBox_day = new System.Windows.Forms.ComboBox();
            this.comboBox_leader = new System.Windows.Forms.ComboBox();
            this.comboBox_orientation = new System.Windows.Forms.ComboBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox_faculty
            // 
            this.checkBox_faculty.AutoSize = true;
            this.checkBox_faculty.Location = new System.Drawing.Point(24, 86);
            this.checkBox_faculty.Name = "checkBox_faculty";
            this.checkBox_faculty.Size = new System.Drawing.Size(120, 24);
            this.checkBox_faculty.TabIndex = 0;
            this.checkBox_faculty.Text = "Факультет";
            this.checkBox_faculty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBox_faculty.UseVisualStyleBackColor = true;
            this.checkBox_faculty.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox_day
            // 
            this.checkBox_day.AutoSize = true;
            this.checkBox_day.Location = new System.Drawing.Point(24, 128);
            this.checkBox_day.Name = "checkBox_day";
            this.checkBox_day.Size = new System.Drawing.Size(125, 24);
            this.checkBox_day.TabIndex = 1;
            this.checkBox_day.Text = "День тижня";
            this.checkBox_day.UseVisualStyleBackColor = true;
            this.checkBox_day.CheckedChanged += new System.EventHandler(this.checkBox_day_CheckedChanged);
            // 
            // checkBox_leader
            // 
            this.checkBox_leader.AutoSize = true;
            this.checkBox_leader.Location = new System.Drawing.Point(24, 170);
            this.checkBox_leader.Name = "checkBox_leader";
            this.checkBox_leader.Size = new System.Drawing.Size(111, 24);
            this.checkBox_leader.TabIndex = 2;
            this.checkBox_leader.Text = "Викладач";
            this.checkBox_leader.UseVisualStyleBackColor = true;
            this.checkBox_leader.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox_orientation
            // 
            this.checkBox_orientation.AutoSize = true;
            this.checkBox_orientation.Location = new System.Drawing.Point(24, 213);
            this.checkBox_orientation.Name = "checkBox_orientation";
            this.checkBox_orientation.Size = new System.Drawing.Size(94, 24);
            this.checkBox_orientation.TabIndex = 3;
            this.checkBox_orientation.Text = "Напрям";
            this.checkBox_orientation.UseVisualStyleBackColor = true;
            this.checkBox_orientation.CheckedChanged += new System.EventHandler(this.checkBox_orientation_CheckedChanged);
            // 
            // checkedListBox5
            // 
            this.checkedListBox5.FormattingEnabled = true;
            this.checkedListBox5.Location = new System.Drawing.Point(105, 295);
            this.checkedListBox5.Name = "checkedListBox5";
            this.checkedListBox5.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox5.TabIndex = 8;
            // 
            // comboBox_faculty
            // 
            this.comboBox_faculty.FormattingEnabled = true;
            this.comboBox_faculty.Items.AddRange(new object[] {
            "ННІФ",
            "ФКНК",
            "ФРЕКС"});
            this.comboBox_faculty.Location = new System.Drawing.Point(246, 82);
            this.comboBox_faculty.Name = "comboBox_faculty";
            this.comboBox_faculty.Size = new System.Drawing.Size(121, 28);
            this.comboBox_faculty.TabIndex = 9;
            this.comboBox_faculty.SelectedIndexChanged += new System.EventHandler(this.comboBox_faculty_SelectedIndexChanged);
            // 
            // comboBox_day
            // 
            this.comboBox_day.FormattingEnabled = true;
            this.comboBox_day.Items.AddRange(new object[] {
            "Пнеділок",
            "Вівторок",
            "Середа ",
            "Четвер",
            "П\'ятниця"});
            this.comboBox_day.Location = new System.Drawing.Point(246, 126);
            this.comboBox_day.Name = "comboBox_day";
            this.comboBox_day.Size = new System.Drawing.Size(121, 28);
            this.comboBox_day.TabIndex = 10;
            this.comboBox_day.SelectedIndexChanged += new System.EventHandler(this.comboBox_day_SelectedIndexChanged);
            // 
            // comboBox_leader
            // 
            this.comboBox_leader.FormattingEnabled = true;
            this.comboBox_leader.Items.AddRange(new object[] {
            "н",
            "а",
            "в",
            "а"});
            this.comboBox_leader.Location = new System.Drawing.Point(246, 170);
            this.comboBox_leader.Name = "comboBox_leader";
            this.comboBox_leader.Size = new System.Drawing.Size(121, 28);
            this.comboBox_leader.TabIndex = 11;
            this.comboBox_leader.SelectedIndexChanged += new System.EventHandler(this.comboBox_leader_SelectedIndexChanged);
            // 
            // comboBox_orientation
            // 
            this.comboBox_orientation.FormattingEnabled = true;
            this.comboBox_orientation.Items.AddRange(new object[] {
            "математика",
            "іноземна мова",
            "фізика "});
            this.comboBox_orientation.Location = new System.Drawing.Point(246, 209);
            this.comboBox_orientation.Name = "comboBox_orientation";
            this.comboBox_orientation.Size = new System.Drawing.Size(121, 28);
            this.comboBox_orientation.TabIndex = 12;
            this.comboBox_orientation.SelectedIndexChanged += new System.EventHandler(this.comboBox_orientation_SelectedIndexChanged);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(24, 286);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(115, 42);
            this.button_search.TabIndex = 13;
            this.button_search.Text = "Пошук";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(195, 285);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(115, 43);
            this.button_save.TabIndex = 14;
            this.button_save.Text = "Зберегти";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(432, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(321, 295);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 48);
            this.label1.TabIndex = 24;
            this.label1.Text = "XML to HTML";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.comboBox_orientation);
            this.Controls.Add(this.comboBox_leader);
            this.Controls.Add(this.comboBox_day);
            this.Controls.Add(this.comboBox_faculty);
            this.Controls.Add(this.checkedListBox5);
            this.Controls.Add(this.checkBox_orientation);
            this.Controls.Add(this.checkBox_leader);
            this.Controls.Add(this.checkBox_day);
            this.Controls.Add(this.checkBox_faculty);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_faculty;
        private System.Windows.Forms.CheckBox checkBox_day;
        private System.Windows.Forms.CheckBox checkBox_leader;
        private System.Windows.Forms.CheckBox checkBox_orientation;
        private System.Windows.Forms.CheckedListBox checkedListBox5;
        private System.Windows.Forms.ComboBox comboBox_faculty;
        private System.Windows.Forms.ComboBox comboBox_day;
        private System.Windows.Forms.ComboBox comboBox_leader;
        private System.Windows.Forms.ComboBox comboBox_orientation;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}

