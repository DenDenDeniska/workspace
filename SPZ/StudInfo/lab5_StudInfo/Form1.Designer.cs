namespace lab5_StudInfo
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
            this.btStart = new System.Windows.Forms.Button();
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.btAddControlList = new System.Windows.Forms.Button();
            this.btDellControlList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSortByStud = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSortLs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btDeSerialize = new System.Windows.Forms.Button();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btSerialize = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adLsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delLsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.Red;
            this.btStart.Location = new System.Drawing.Point(632, 426);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(167, 23);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "DON\'T TOUCH THIS BUTTON";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.Location = new System.Drawing.Point(12, 12);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(210, 186);
            this.lbStudents.TabIndex = 3;
            this.lbStudents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbStudents_MouseDoubleClick);
            // 
            // btAddControlList
            // 
            this.btAddControlList.Location = new System.Drawing.Point(12, 204);
            this.btAddControlList.Name = "btAddControlList";
            this.btAddControlList.Size = new System.Drawing.Size(101, 34);
            this.btAddControlList.TabIndex = 4;
            this.btAddControlList.Text = "Add list";
            this.btAddControlList.UseVisualStyleBackColor = true;
            this.btAddControlList.Click += new System.EventHandler(this.btAddControlList_Click);
            // 
            // btDellControlList
            // 
            this.btDellControlList.Location = new System.Drawing.Point(121, 204);
            this.btDellControlList.Name = "btDellControlList";
            this.btDellControlList.Size = new System.Drawing.Size(101, 34);
            this.btDellControlList.TabIndex = 5;
            this.btDellControlList.Text = "Delete list";
            this.btDellControlList.UseVisualStyleBackColor = true;
            this.btDellControlList.Click += new System.EventHandler(this.btDellControlList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::lab5_StudInfo.Properties.Resources.DQ664nJlmPI;
            this.panel1.Controls.Add(this.tbSortByStud);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbSortLs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btDeSerialize);
            this.panel1.Controls.Add(this.tbFileName);
            this.panel1.Controls.Add(this.btSerialize);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 426);
            this.panel1.TabIndex = 10;
            // 
            // tbSortByStud
            // 
            this.tbSortByStud.Location = new System.Drawing.Point(317, 14);
            this.tbSortByStud.Name = "tbSortByStud";
            this.tbSortByStud.Size = new System.Drawing.Size(90, 20);
            this.tbSortByStud.TabIndex = 15;
            this.tbSortByStud.TextChanged += new System.EventHandler(this.tbSortByStud_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sort by student :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sort by lesson :";
            // 
            // tbSortLs
            // 
            this.tbSortLs.Location = new System.Drawing.Point(498, 14);
            this.tbSortLs.Name = "tbSortLs";
            this.tbSortLs.Size = new System.Drawing.Size(100, 20);
            this.tbSortLs.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Serrialization to file *.bin";
            // 
            // btDeSerialize
            // 
            this.btDeSerialize.Location = new System.Drawing.Point(117, 363);
            this.btDeSerialize.Name = "btDeSerialize";
            this.btDeSerialize.Size = new System.Drawing.Size(103, 34);
            this.btDeSerialize.TabIndex = 9;
            this.btDeSerialize.Text = "DeSerialize";
            this.btDeSerialize.UseVisualStyleBackColor = true;
            this.btDeSerialize.Click += new System.EventHandler(this.btDeSerialize_Click);
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(11, 337);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(209, 20);
            this.tbFileName.TabIndex = 7;
            // 
            // btSerialize
            // 
            this.btSerialize.Location = new System.Drawing.Point(11, 363);
            this.btSerialize.Name = "btSerialize";
            this.btSerialize.Size = new System.Drawing.Size(103, 34);
            this.btSerialize.TabIndex = 6;
            this.btSerialize.Text = "Serialize";
            this.btSerialize.UseVisualStyleBackColor = true;
            this.btSerialize.Click += new System.EventHandler(this.btSerialize_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(227, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 196);
            this.dataGridView1.TabIndex = 2;
            // 
            // adLsToolStripMenuItem
            // 
            this.adLsToolStripMenuItem.Name = "adLsToolStripMenuItem";
            this.adLsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // delLsToolStripMenuItem
            // 
            this.delLsToolStripMenuItem.Name = "delLsToolStripMenuItem";
            this.delLsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btDellControlList);
            this.Controls.Add(this.btAddControlList);
            this.Controls.Add(this.lbStudents);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentViewer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.Button btAddControlList;
        private System.Windows.Forms.Button btDellControlList;
        private System.Windows.Forms.Button btSerialize;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDeSerialize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSortLs;
        private System.Windows.Forms.TextBox tbSortByStud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem adLsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delLsToolStripMenuItem;
    }
}

