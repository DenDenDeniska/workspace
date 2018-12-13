namespace FactoryController
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
            this.components = new System.ComponentModel.Container();
            this.mclb_Main = new System.Windows.Forms.TabControl();
            this.cclb_Buying = new System.Windows.Forms.TabPage();
            this.lb_CurrentSize1 = new System.Windows.Forms.Label();
            this.lb_Budget1 = new System.Windows.Forms.Label();
            this.bt_Buying = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cclb_Creatin = new System.Windows.Forms.TabPage();
            this.bt_Creating = new System.Windows.Forms.Button();
            this.lb_CurrentSize2 = new System.Windows.Forms.Label();
            this.lb_Budget2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cclb_Realization = new System.Windows.Forms.TabPage();
            this.bt_Realize = new System.Windows.Forms.Button();
            this.lb_CurrentSize3 = new System.Windows.Forms.Label();
            this.lb_Budget3 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cclb_Reports = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_GenReport = new System.Windows.Forms.Button();
            this.tb_RepInfo = new System.Windows.Forms.TextBox();
            this.lbox_Reports = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mclb_Main.SuspendLayout();
            this.cclb_Buying.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.cclb_Creatin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.cclb_Realization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.cclb_Reports.SuspendLayout();
            this.SuspendLayout();
            // 
            // mclb_Main
            // 
            this.mclb_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mclb_Main.Controls.Add(this.cclb_Buying);
            this.mclb_Main.Controls.Add(this.cclb_Creatin);
            this.mclb_Main.Controls.Add(this.cclb_Realization);
            this.mclb_Main.Controls.Add(this.cclb_Reports);
            this.mclb_Main.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mclb_Main.Location = new System.Drawing.Point(12, 12);
            this.mclb_Main.Multiline = true;
            this.mclb_Main.Name = "mclb_Main";
            this.mclb_Main.SelectedIndex = 0;
            this.mclb_Main.Size = new System.Drawing.Size(776, 426);
            this.mclb_Main.TabIndex = 0;
            // 
            // cclb_Buying
            // 
            this.cclb_Buying.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cclb_Buying.Controls.Add(this.lb_CurrentSize1);
            this.cclb_Buying.Controls.Add(this.lb_Budget1);
            this.cclb_Buying.Controls.Add(this.bt_Buying);
            this.cclb_Buying.Controls.Add(this.numericUpDown1);
            this.cclb_Buying.Controls.Add(this.label3);
            this.cclb_Buying.Controls.Add(this.label2);
            this.cclb_Buying.Controls.Add(this.label1);
            this.cclb_Buying.Location = new System.Drawing.Point(4, 35);
            this.cclb_Buying.Name = "cclb_Buying";
            this.cclb_Buying.Padding = new System.Windows.Forms.Padding(3);
            this.cclb_Buying.Size = new System.Drawing.Size(768, 387);
            this.cclb_Buying.TabIndex = 0;
            this.cclb_Buying.Text = "Buying";
            // 
            // lb_CurrentSize1
            // 
            this.lb_CurrentSize1.AutoSize = true;
            this.lb_CurrentSize1.Location = new System.Drawing.Point(6, 183);
            this.lb_CurrentSize1.Name = "lb_CurrentSize1";
            this.lb_CurrentSize1.Size = new System.Drawing.Size(73, 26);
            this.lb_CurrentSize1.TabIndex = 8;
            this.lb_CurrentSize1.Text = "label5";
            // 
            // lb_Budget1
            // 
            this.lb_Budget1.AutoSize = true;
            this.lb_Budget1.Location = new System.Drawing.Point(161, 84);
            this.lb_Budget1.Name = "lb_Budget1";
            this.lb_Budget1.Size = new System.Drawing.Size(73, 26);
            this.lb_Budget1.TabIndex = 7;
            this.lb_Budget1.Text = "label4";
            // 
            // bt_Buying
            // 
            this.bt_Buying.Location = new System.Drawing.Point(11, 287);
            this.bt_Buying.Name = "bt_Buying";
            this.bt_Buying.Size = new System.Drawing.Size(751, 94);
            this.bt_Buying.TabIndex = 5;
            this.bt_Buying.Text = "Закупить товар";
            this.bt_Buying.UseVisualStyleBackColor = true;
            this.bt_Buying.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(365, 24);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(182, 49);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(427, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Заполненность склада :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Бюджет :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество цехов :";
            // 
            // cclb_Creatin
            // 
            this.cclb_Creatin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cclb_Creatin.Controls.Add(this.bt_Creating);
            this.cclb_Creatin.Controls.Add(this.lb_CurrentSize2);
            this.cclb_Creatin.Controls.Add(this.lb_Budget2);
            this.cclb_Creatin.Controls.Add(this.numericUpDown2);
            this.cclb_Creatin.Controls.Add(this.label6);
            this.cclb_Creatin.Controls.Add(this.label7);
            this.cclb_Creatin.Controls.Add(this.label8);
            this.cclb_Creatin.Location = new System.Drawing.Point(4, 35);
            this.cclb_Creatin.Name = "cclb_Creatin";
            this.cclb_Creatin.Padding = new System.Windows.Forms.Padding(3);
            this.cclb_Creatin.Size = new System.Drawing.Size(768, 387);
            this.cclb_Creatin.TabIndex = 1;
            this.cclb_Creatin.Text = "Creating";
            // 
            // bt_Creating
            // 
            this.bt_Creating.Location = new System.Drawing.Point(11, 283);
            this.bt_Creating.Name = "bt_Creating";
            this.bt_Creating.Size = new System.Drawing.Size(751, 90);
            this.bt_Creating.TabIndex = 15;
            this.bt_Creating.Text = "Запуск производства";
            this.bt_Creating.UseVisualStyleBackColor = true;
            this.bt_Creating.Click += new System.EventHandler(this.bt_Creating_Click);
            // 
            // lb_CurrentSize2
            // 
            this.lb_CurrentSize2.AutoSize = true;
            this.lb_CurrentSize2.Location = new System.Drawing.Point(6, 176);
            this.lb_CurrentSize2.Name = "lb_CurrentSize2";
            this.lb_CurrentSize2.Size = new System.Drawing.Size(73, 26);
            this.lb_CurrentSize2.TabIndex = 14;
            this.lb_CurrentSize2.Text = "label5";
            // 
            // lb_Budget2
            // 
            this.lb_Budget2.AutoSize = true;
            this.lb_Budget2.Location = new System.Drawing.Point(161, 82);
            this.lb_Budget2.Name = "lb_Budget2";
            this.lb_Budget2.Size = new System.Drawing.Size(73, 26);
            this.lb_Budget2.TabIndex = 13;
            this.lb_Budget2.Text = "label4";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(365, 22);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(182, 49);
            this.numericUpDown2.TabIndex = 12;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(427, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Заполненность склада :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "Бюджет :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(343, 26);
            this.label8.TabIndex = 9;
            this.label8.Text = "Количество цехов :";
            // 
            // cclb_Realization
            // 
            this.cclb_Realization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cclb_Realization.Controls.Add(this.bt_Realize);
            this.cclb_Realization.Controls.Add(this.lb_CurrentSize3);
            this.cclb_Realization.Controls.Add(this.lb_Budget3);
            this.cclb_Realization.Controls.Add(this.numericUpDown3);
            this.cclb_Realization.Controls.Add(this.label11);
            this.cclb_Realization.Controls.Add(this.label12);
            this.cclb_Realization.Controls.Add(this.label13);
            this.cclb_Realization.Location = new System.Drawing.Point(4, 35);
            this.cclb_Realization.Name = "cclb_Realization";
            this.cclb_Realization.Padding = new System.Windows.Forms.Padding(3);
            this.cclb_Realization.Size = new System.Drawing.Size(768, 387);
            this.cclb_Realization.TabIndex = 2;
            this.cclb_Realization.Text = "Realization";
            // 
            // bt_Realize
            // 
            this.bt_Realize.Location = new System.Drawing.Point(11, 291);
            this.bt_Realize.Name = "bt_Realize";
            this.bt_Realize.Size = new System.Drawing.Size(751, 90);
            this.bt_Realize.TabIndex = 21;
            this.bt_Realize.Text = "Отправить на продажу";
            this.bt_Realize.UseVisualStyleBackColor = true;
            this.bt_Realize.Click += new System.EventHandler(this.bt_Realize_Click);
            // 
            // lb_CurrentSize3
            // 
            this.lb_CurrentSize3.AutoSize = true;
            this.lb_CurrentSize3.Location = new System.Drawing.Point(6, 176);
            this.lb_CurrentSize3.Name = "lb_CurrentSize3";
            this.lb_CurrentSize3.Size = new System.Drawing.Size(73, 26);
            this.lb_CurrentSize3.TabIndex = 20;
            this.lb_CurrentSize3.Text = "label5";
            // 
            // lb_Budget3
            // 
            this.lb_Budget3.AutoSize = true;
            this.lb_Budget3.Location = new System.Drawing.Point(161, 74);
            this.lb_Budget3.Name = "lb_Budget3";
            this.lb_Budget3.Size = new System.Drawing.Size(73, 26);
            this.lb_Budget3.TabIndex = 19;
            this.lb_Budget3.Text = "label4";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(365, 14);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(182, 49);
            this.numericUpDown3.TabIndex = 18;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(427, 26);
            this.label11.TabIndex = 17;
            this.label11.Text = "Заполненность склада :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 26);
            this.label12.TabIndex = 16;
            this.label12.Text = "Бюджет :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(343, 26);
            this.label13.TabIndex = 15;
            this.label13.Text = "Количество цехов :";
            // 
            // cclb_Reports
            // 
            this.cclb_Reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cclb_Reports.Controls.Add(this.label4);
            this.cclb_Reports.Controls.Add(this.bt_Delete);
            this.cclb_Reports.Controls.Add(this.bt_GenReport);
            this.cclb_Reports.Controls.Add(this.tb_RepInfo);
            this.cclb_Reports.Controls.Add(this.lbox_Reports);
            this.cclb_Reports.Location = new System.Drawing.Point(4, 35);
            this.cclb_Reports.Name = "cclb_Reports";
            this.cclb_Reports.Padding = new System.Windows.Forms.Padding(3);
            this.cclb_Reports.Size = new System.Drawing.Size(768, 387);
            this.cclb_Reports.TabIndex = 3;
            this.cclb_Reports.Text = "Reports";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Найденые отчеты";
            // 
            // bt_Delete
            // 
            this.bt_Delete.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_Delete.Location = new System.Drawing.Point(450, 320);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(312, 54);
            this.bt_Delete.TabIndex = 3;
            this.bt_Delete.Text = "Удалить выбраный";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_GenReport
            // 
            this.bt_GenReport.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_GenReport.Location = new System.Drawing.Point(174, 320);
            this.bt_GenReport.Name = "bt_GenReport";
            this.bt_GenReport.Size = new System.Drawing.Size(270, 54);
            this.bt_GenReport.TabIndex = 2;
            this.bt_GenReport.Text = "Создать отчет";
            this.bt_GenReport.UseVisualStyleBackColor = true;
            this.bt_GenReport.Click += new System.EventHandler(this.bt_GenReport_Click);
            // 
            // tb_RepInfo
            // 
            this.tb_RepInfo.Location = new System.Drawing.Point(174, 50);
            this.tb_RepInfo.Multiline = true;
            this.tb_RepInfo.Name = "tb_RepInfo";
            this.tb_RepInfo.Size = new System.Drawing.Size(588, 256);
            this.tb_RepInfo.TabIndex = 1;
            // 
            // lbox_Reports
            // 
            this.lbox_Reports.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbox_Reports.FormattingEnabled = true;
            this.lbox_Reports.ItemHeight = 20;
            this.lbox_Reports.Location = new System.Drawing.Point(6, 50);
            this.lbox_Reports.Name = "lbox_Reports";
            this.lbox_Reports.Size = new System.Drawing.Size(162, 324);
            this.lbox_Reports.TabIndex = 0;
            this.lbox_Reports.SelectedIndexChanged += new System.EventHandler(this.lbox_Reports_SelectedIndexChanged);
            this.lbox_Reports.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbox_Reports_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mclb_Main);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.mclb_Main.ResumeLayout(false);
            this.cclb_Buying.ResumeLayout(false);
            this.cclb_Buying.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.cclb_Creatin.ResumeLayout(false);
            this.cclb_Creatin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.cclb_Realization.ResumeLayout(false);
            this.cclb_Realization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.cclb_Reports.ResumeLayout(false);
            this.cclb_Reports.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mclb_Main;
        private System.Windows.Forms.TabPage cclb_Buying;
        private System.Windows.Forms.TabPage cclb_Creatin;
        private System.Windows.Forms.TabPage cclb_Realization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_CurrentSize1;
        private System.Windows.Forms.Label lb_Budget1;
        private System.Windows.Forms.Button bt_Buying;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_CurrentSize2;
        private System.Windows.Forms.Label lb_Budget2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_Creating;
        private System.Windows.Forms.Label lb_CurrentSize3;
        private System.Windows.Forms.Label lb_Budget3;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bt_Realize;
        private System.Windows.Forms.TabPage cclb_Reports;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_GenReport;
        private System.Windows.Forms.TextBox tb_RepInfo;
        private System.Windows.Forms.ListBox lbox_Reports;
    }
}

