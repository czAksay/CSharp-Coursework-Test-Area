namespace TestAreaNS
{
    partial class AddVol
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
            this.btnHuman = new System.Windows.Forms.Button();
            this.btnRobot = new System.Windows.Forms.Button();
            this.pnlAddHuman = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRace = new System.Windows.Forms.ComboBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlRobot = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbArch = new System.Windows.Forms.ComboBox();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.pnlAddHuman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.pnlRobot.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHuman
            // 
            this.btnHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHuman.Location = new System.Drawing.Point(74, 25);
            this.btnHuman.Name = "btnHuman";
            this.btnHuman.Size = new System.Drawing.Size(89, 33);
            this.btnHuman.TabIndex = 0;
            this.btnHuman.Text = "Человек";
            this.btnHuman.UseVisualStyleBackColor = true;
            this.btnHuman.Click += new System.EventHandler(this.btnHuman_Click);
            // 
            // btnRobot
            // 
            this.btnRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRobot.Location = new System.Drawing.Point(161, 25);
            this.btnRobot.Name = "btnRobot";
            this.btnRobot.Size = new System.Drawing.Size(89, 33);
            this.btnRobot.TabIndex = 1;
            this.btnRobot.Text = "Робот";
            this.btnRobot.UseVisualStyleBackColor = true;
            this.btnRobot.Click += new System.EventHandler(this.btnRobot_Click);
            // 
            // pnlAddHuman
            // 
            this.pnlAddHuman.Controls.Add(this.label4);
            this.pnlAddHuman.Controls.Add(this.label3);
            this.pnlAddHuman.Controls.Add(this.label2);
            this.pnlAddHuman.Controls.Add(this.label1);
            this.pnlAddHuman.Controls.Add(this.cmbRace);
            this.pnlAddHuman.Controls.Add(this.numAge);
            this.pnlAddHuman.Controls.Add(this.tbLastName);
            this.pnlAddHuman.Controls.Add(this.tbFirstName);
            this.pnlAddHuman.Location = new System.Drawing.Point(25, 64);
            this.pnlAddHuman.Name = "pnlAddHuman";
            this.pnlAddHuman.Size = new System.Drawing.Size(270, 176);
            this.pnlAddHuman.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Раса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Возраст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // cmbRace
            // 
            this.cmbRace.DisplayMember = "0";
            this.cmbRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.Items.AddRange(new object[] {
            "Европеец",
            "Американец",
            "Африканец"});
            this.cmbRace.Location = new System.Drawing.Point(115, 121);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(141, 21);
            this.cmbRace.TabIndex = 3;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(186, 84);
            this.numAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(70, 20);
            this.numAge.TabIndex = 2;
            this.numAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(115, 48);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(141, 20);
            this.tbLastName.TabIndex = 1;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(115, 13);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(141, 20);
            this.tbFirstName.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(89, 263);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlRobot
            // 
            this.pnlRobot.Controls.Add(this.label5);
            this.pnlRobot.Controls.Add(this.label6);
            this.pnlRobot.Controls.Add(this.label7);
            this.pnlRobot.Controls.Add(this.cbArch);
            this.pnlRobot.Controls.Add(this.tbCompany);
            this.pnlRobot.Controls.Add(this.tbModel);
            this.pnlRobot.Location = new System.Drawing.Point(25, 64);
            this.pnlRobot.Name = "pnlRobot";
            this.pnlRobot.Size = new System.Drawing.Size(270, 176);
            this.pnlRobot.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(19, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Архитектура";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(19, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Компания";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(19, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Модель";
            // 
            // cbArch
            // 
            this.cbArch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArch.FormattingEnabled = true;
            this.cbArch.Items.AddRange(new object[] {
            "KASint",
            "AmdRodeon",
            "Intpel "});
            this.cbArch.Location = new System.Drawing.Point(112, 85);
            this.cbArch.Name = "cbArch";
            this.cbArch.Size = new System.Drawing.Size(141, 21);
            this.cbArch.TabIndex = 10;
            // 
            // tbCompany
            // 
            this.tbCompany.Location = new System.Drawing.Point(112, 50);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(141, 20);
            this.tbCompany.TabIndex = 9;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(112, 15);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(141, 20);
            this.tbModel.TabIndex = 8;
            // 
            // AddVol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 311);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRobot);
            this.Controls.Add(this.btnHuman);
            this.Controls.Add(this.pnlAddHuman);
            this.Controls.Add(this.pnlRobot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddVol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Volunteer";
            this.pnlAddHuman.ResumeLayout(false);
            this.pnlAddHuman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.pnlRobot.ResumeLayout(false);
            this.pnlRobot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHuman;
        private System.Windows.Forms.Button btnRobot;
        private System.Windows.Forms.Panel pnlAddHuman;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.ComboBox cmbRace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Panel pnlRobot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbArch;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.TextBox tbModel;
    }
}