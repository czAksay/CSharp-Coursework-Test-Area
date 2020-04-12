namespace TestAreaNS
{
    partial class FTestArea
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlCommands = new System.Windows.Forms.TableLayoutPanel();
            this.btnIntroduce = new System.Windows.Forms.Button();
            this.btnGetState = new System.Windows.Forms.Button();
            this.btnTime = new System.Windows.Forms.Button();
            this.btnDrink = new System.Windows.Forms.Button();
            this.btnFeed = new System.Windows.Forms.Button();
            this.btnRepair = new System.Windows.Forms.Button();
            this.btnInject = new System.Windows.Forms.Button();
            this.ckbxAll = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnChoose = new System.Windows.Forms.Button();
            this.tbVolNumber = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPointer = new System.Windows.Forms.Label();
            this.btnNextVol = new System.Windows.Forms.Button();
            this.btnPrevVol = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblNext2 = new System.Windows.Forms.Label();
            this.lblPrev2 = new System.Windows.Forms.Label();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.lbLog = new System.Windows.Forms.ListBox();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.pbPrev = new System.Windows.Forms.PictureBox();
            this.pbCurrent = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlCommands.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.pnlCommands);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 497);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 92);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDelete, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(415, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(96, 90);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 39);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(3, 48);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 39);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlCommands
            // 
            this.pnlCommands.ColumnCount = 4;
            this.pnlCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlCommands.Controls.Add(this.btnIntroduce, 0, 0);
            this.pnlCommands.Controls.Add(this.btnGetState, 0, 1);
            this.pnlCommands.Controls.Add(this.btnTime, 1, 0);
            this.pnlCommands.Controls.Add(this.btnDrink, 2, 0);
            this.pnlCommands.Controls.Add(this.btnFeed, 2, 1);
            this.pnlCommands.Controls.Add(this.btnRepair, 3, 1);
            this.pnlCommands.Controls.Add(this.btnInject, 1, 1);
            this.pnlCommands.Controls.Add(this.ckbxAll, 3, 0);
            this.pnlCommands.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCommands.Location = new System.Drawing.Point(514, 0);
            this.pnlCommands.Name = "pnlCommands";
            this.pnlCommands.RowCount = 2;
            this.pnlCommands.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlCommands.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlCommands.Size = new System.Drawing.Size(434, 90);
            this.pnlCommands.TabIndex = 1;
            // 
            // btnIntroduce
            // 
            this.btnIntroduce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIntroduce.Location = new System.Drawing.Point(3, 3);
            this.btnIntroduce.Name = "btnIntroduce";
            this.btnIntroduce.Size = new System.Drawing.Size(102, 39);
            this.btnIntroduce.TabIndex = 0;
            this.btnIntroduce.Text = "Представьтесь";
            this.btnIntroduce.UseVisualStyleBackColor = true;
            this.btnIntroduce.Click += new System.EventHandler(this.btnIntroduce_Click);
            // 
            // btnGetState
            // 
            this.btnGetState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGetState.Location = new System.Drawing.Point(3, 48);
            this.btnGetState.Name = "btnGetState";
            this.btnGetState.Size = new System.Drawing.Size(102, 39);
            this.btnGetState.TabIndex = 1;
            this.btnGetState.Text = "Доложите состояние";
            this.btnGetState.UseVisualStyleBackColor = true;
            this.btnGetState.Click += new System.EventHandler(this.btnGetState_Click);
            // 
            // btnTime
            // 
            this.btnTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTime.Location = new System.Drawing.Point(111, 3);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(102, 39);
            this.btnTime.TabIndex = 3;
            this.btnTime.Text = "Время нахождения";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // btnDrink
            // 
            this.btnDrink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDrink.Location = new System.Drawing.Point(219, 3);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(102, 39);
            this.btnDrink.TabIndex = 4;
            this.btnDrink.Text = "Напоить";
            this.btnDrink.UseVisualStyleBackColor = true;
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
            // 
            // btnFeed
            // 
            this.btnFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFeed.Location = new System.Drawing.Point(219, 48);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(102, 39);
            this.btnFeed.TabIndex = 2;
            this.btnFeed.Text = "Накормить";
            this.btnFeed.UseVisualStyleBackColor = true;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // btnRepair
            // 
            this.btnRepair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRepair.Location = new System.Drawing.Point(327, 48);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(104, 39);
            this.btnRepair.TabIndex = 6;
            this.btnRepair.Text = "Отремонтировать";
            this.btnRepair.UseVisualStyleBackColor = true;
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // btnInject
            // 
            this.btnInject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInject.Location = new System.Drawing.Point(111, 48);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(102, 39);
            this.btnInject.TabIndex = 5;
            this.btnInject.Text = "Ввести инъекцию";
            this.btnInject.UseVisualStyleBackColor = true;
            this.btnInject.Click += new System.EventHandler(this.btnInject_Click);
            // 
            // ckbxAll
            // 
            this.ckbxAll.AutoSize = true;
            this.ckbxAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbxAll.Location = new System.Drawing.Point(327, 3);
            this.ckbxAll.Name = "ckbxAll";
            this.ckbxAll.Size = new System.Drawing.Size(104, 39);
            this.ckbxAll.TabIndex = 7;
            this.ckbxAll.Text = "Глобальные действия";
            this.ckbxAll.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnChoose);
            this.panel3.Controls.Add(this.tbVolNumber);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 90);
            this.panel3.TabIndex = 3;
            // 
            // btnChoose
            // 
            this.btnChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChoose.Location = new System.Drawing.Point(3, 43);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(209, 31);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "Выбрать";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // tbVolNumber
            // 
            this.tbVolNumber.Location = new System.Drawing.Point(51, 17);
            this.tbVolNumber.Name = "tbVolNumber";
            this.tbVolNumber.Size = new System.Drawing.Size(109, 20);
            this.tbVolNumber.TabIndex = 0;
            this.tbVolNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPointer);
            this.panel2.Controls.Add(this.btnNextVol);
            this.panel2.Controls.Add(this.btnPrevVol);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 90);
            this.panel2.TabIndex = 2;
            // 
            // lblPointer
            // 
            this.lblPointer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPointer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPointer.Location = new System.Drawing.Point(58, 0);
            this.lblPointer.Name = "lblPointer";
            this.lblPointer.Size = new System.Drawing.Size(82, 90);
            this.lblPointer.TabIndex = 1;
            this.lblPointer.Text = "1/1";
            this.lblPointer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNextVol
            // 
            this.btnNextVol.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNextVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNextVol.Location = new System.Drawing.Point(140, 0);
            this.btnNextVol.Name = "btnNextVol";
            this.btnNextVol.Size = new System.Drawing.Size(60, 90);
            this.btnNextVol.TabIndex = 1;
            this.btnNextVol.Text = ">";
            this.btnNextVol.UseVisualStyleBackColor = true;
            this.btnNextVol.Click += new System.EventHandler(this.btnNextVol_Click);
            // 
            // btnPrevVol
            // 
            this.btnPrevVol.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrevVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrevVol.Location = new System.Drawing.Point(0, 0);
            this.btnPrevVol.Name = "btnPrevVol";
            this.btnPrevVol.Size = new System.Drawing.Size(58, 90);
            this.btnPrevVol.TabIndex = 0;
            this.btnPrevVol.Text = "<";
            this.btnPrevVol.UseVisualStyleBackColor = true;
            this.btnPrevVol.Click += new System.EventHandler(this.btnPrevVol_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutput.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOutput.Location = new System.Drawing.Point(582, 42);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(329, 156);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNext2
            // 
            this.lblNext2.AutoSize = true;
            this.lblNext2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNext2.Location = new System.Drawing.Point(482, 208);
            this.lblNext2.Name = "lblNext2";
            this.lblNext2.Size = new System.Drawing.Size(30, 25);
            this.lblNext2.TabIndex = 5;
            this.lblNext2.Text = "...";
            // 
            // lblPrev2
            // 
            this.lblPrev2.AutoSize = true;
            this.lblPrev2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrev2.Location = new System.Drawing.Point(45, 208);
            this.lblPrev2.Name = "lblPrev2";
            this.lblPrev2.Size = new System.Drawing.Size(30, 25);
            this.lblPrev2.TabIndex = 6;
            this.lblPrev2.Text = "...";
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Interval = 8000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // lbLog
            // 
            this.lbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 18;
            this.lbLog.Location = new System.Drawing.Point(582, 220);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(328, 220);
            this.lbLog.TabIndex = 7;
            // 
            // pbNext
            // 
            this.pbNext.Location = new System.Drawing.Point(384, 178);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(84, 84);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNext.TabIndex = 4;
            this.pbNext.TabStop = false;
            // 
            // pbPrev
            // 
            this.pbPrev.Location = new System.Drawing.Point(94, 178);
            this.pbPrev.Name = "pbPrev";
            this.pbPrev.Size = new System.Drawing.Size(84, 84);
            this.pbPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrev.TabIndex = 3;
            this.pbPrev.TabStop = false;
            // 
            // pbCurrent
            // 
            this.pbCurrent.Location = new System.Drawing.Point(201, 138);
            this.pbCurrent.Name = "pbCurrent";
            this.pbCurrent.Size = new System.Drawing.Size(158, 159);
            this.pbCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrent.TabIndex = 2;
            this.pbCurrent.TabStop = false;
            // 
            // FTestArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 589);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.lblPrev2);
            this.Controls.Add(this.lblNext2);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.pbPrev);
            this.Controls.Add(this.pbCurrent);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(966, 628);
            this.Name = "FTestArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Area";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlCommands.ResumeLayout(false);
            this.pnlCommands.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNextVol;
        private System.Windows.Forms.Button btnPrevVol;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel pnlCommands;
        private System.Windows.Forms.Button btnIntroduce;
        private System.Windows.Forms.Button btnGetState;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Button btnFeed;
        private System.Windows.Forms.Button btnInject;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblPointer;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnRepair;
        private System.Windows.Forms.PictureBox pbCurrent;
        private System.Windows.Forms.PictureBox pbPrev;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.Label lblNext2;
        private System.Windows.Forms.Label lblPrev2;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.CheckBox ckbxAll;
        private System.Windows.Forms.TextBox tbVolNumber;
        private System.Windows.Forms.Button btnChoose;
    }
}

