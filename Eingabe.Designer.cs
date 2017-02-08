namespace Fima
{
    partial class Eingabe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eingabe));
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChild = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUeberstunden = new System.Windows.Forms.CheckBox();
            this.bJetzt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtHour = new System.Windows.Forms.DateTimePicker();
            this.dtMin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbCustomShutdown = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bFarbe = new System.Windows.Forms.Button();
            this.rbShutdown = new System.Windows.Forms.RadioButton();
            this.rbCustomShutdown = new System.Windows.Forms.RadioButton();
            this.gbCustomShutdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtBegin
            // 
            this.dtBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBegin.Location = new System.Drawing.Point(144, 11);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.ShowUpDown = true;
            this.dtBegin.Size = new System.Drawing.Size(49, 20);
            this.dtBegin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arbeitsbegin:";
            // 
            // cbChild
            // 
            this.cbChild.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChild.FormattingEnabled = true;
            this.cbChild.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbChild.Items.AddRange(new object[] {
            "Nein",
            "Ja"});
            this.cbChild.Location = new System.Drawing.Point(144, 43);
            this.cbChild.Name = "cbChild";
            this.cbChild.Size = new System.Drawing.Size(49, 21);
            this.cbChild.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 132);
            this.button1.TabIndex = 3;
            this.button1.Text = "Timer starten";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minderjährig:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Überstunden zählen:";
            // 
            // cbUeberstunden
            // 
            this.cbUeberstunden.AutoSize = true;
            this.cbUeberstunden.Location = new System.Drawing.Point(144, 105);
            this.cbUeberstunden.Name = "cbUeberstunden";
            this.cbUeberstunden.Size = new System.Drawing.Size(15, 14);
            this.cbUeberstunden.TabIndex = 7;
            this.cbUeberstunden.UseVisualStyleBackColor = true;
            // 
            // bJetzt
            // 
            this.bJetzt.Location = new System.Drawing.Point(213, 7);
            this.bJetzt.Name = "bJetzt";
            this.bJetzt.Size = new System.Drawing.Size(59, 23);
            this.bJetzt.TabIndex = 8;
            this.bJetzt.Text = "jetzt";
            this.bJetzt.UseVisualStyleBackColor = true;
            this.bJetzt.Click += new System.EventHandler(this.bJetzt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Herunterfahren:";
            // 
            // dtHour
            // 
            this.dtHour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHour.Location = new System.Drawing.Point(141, 12);
            this.dtHour.Name = "dtHour";
            this.dtHour.ShowUpDown = true;
            this.dtHour.Size = new System.Drawing.Size(34, 20);
            this.dtHour.TabIndex = 10;
            this.dtHour.Value = new System.DateTime(2016, 12, 21, 14, 55, 44, 0);
            // 
            // dtMin
            // 
            this.dtMin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMin.Location = new System.Drawing.Point(195, 12);
            this.dtMin.Name = "dtMin";
            this.dtMin.ShowUpDown = true;
            this.dtMin.Size = new System.Drawing.Size(34, 20);
            this.dtMin.TabIndex = 11;
            this.dtMin.Value = new System.DateTime(2016, 12, 21, 14, 55, 44, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "nach:";
            // 
            // gbCustomShutdown
            // 
            this.gbCustomShutdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbCustomShutdown.Controls.Add(this.label6);
            this.gbCustomShutdown.Controls.Add(this.dtHour);
            this.gbCustomShutdown.Controls.Add(this.dtMin);
            this.gbCustomShutdown.Controls.Add(this.label7);
            this.gbCustomShutdown.Controls.Add(this.label5);
            this.gbCustomShutdown.Location = new System.Drawing.Point(3, 150);
            this.gbCustomShutdown.Name = "gbCustomShutdown";
            this.gbCustomShutdown.Size = new System.Drawing.Size(266, 36);
            this.gbCustomShutdown.TabIndex = 17;
            this.gbCustomShutdown.TabStop = false;
            this.gbCustomShutdown.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Timer Farbe:";
            // 
            // bFarbe
            // 
            this.bFarbe.Location = new System.Drawing.Point(144, 74);
            this.bFarbe.Name = "bFarbe";
            this.bFarbe.Size = new System.Drawing.Size(76, 18);
            this.bFarbe.TabIndex = 19;
            this.bFarbe.UseVisualStyleBackColor = true;
            this.bFarbe.Click += new System.EventHandler(this.bFarbe_Click);
            // 
            // rbShutdown
            // 
            this.rbShutdown.AutoSize = true;
            this.rbShutdown.Checked = true;
            this.rbShutdown.Location = new System.Drawing.Point(144, 131);
            this.rbShutdown.Name = "rbShutdown";
            this.rbShutdown.Size = new System.Drawing.Size(53, 17);
            this.rbShutdown.TabIndex = 20;
            this.rbShutdown.TabStop = true;
            this.rbShutdown.Text = "Direkt";
            this.rbShutdown.UseVisualStyleBackColor = true;
            // 
            // rbCustomShutdown
            // 
            this.rbCustomShutdown.AutoSize = true;
            this.rbCustomShutdown.Location = new System.Drawing.Point(203, 131);
            this.rbCustomShutdown.Name = "rbCustomShutdown";
            this.rbCustomShutdown.Size = new System.Drawing.Size(60, 17);
            this.rbCustomShutdown.TabIndex = 21;
            this.rbCustomShutdown.Text = "Custom";
            this.rbCustomShutdown.UseVisualStyleBackColor = true;
            this.rbCustomShutdown.CheckedChanged += new System.EventHandler(this.rbCustomShutdown_CheckedChanged);
            // 
            // Eingabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 333);
            this.Controls.Add(this.rbCustomShutdown);
            this.Controls.Add(this.rbShutdown);
            this.Controls.Add(this.bFarbe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbCustomShutdown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bJetzt);
            this.Controls.Add(this.cbUeberstunden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbChild);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtBegin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Eingabe";
            this.Text = "Fima V1.4";
            this.Load += new System.EventHandler(this.Eingabe_Load);
            this.gbCustomShutdown.ResumeLayout(false);
            this.gbCustomShutdown.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChild;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbUeberstunden;
        private System.Windows.Forms.Button bJetzt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtHour;
        private System.Windows.Forms.DateTimePicker dtMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbCustomShutdown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button bFarbe;
        private System.Windows.Forms.RadioButton rbShutdown;
        private System.Windows.Forms.RadioButton rbCustomShutdown;

    }
}