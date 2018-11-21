namespace Lab4_WorkWithFiles
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
            this.btGenerateInput = new System.Windows.Forms.Button();
            this.btGenericOut = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.tbOutFile = new System.Windows.Forms.TextBox();
            this.btOpenOutFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btGenerateInput
            // 
            this.btGenerateInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btGenerateInput.Location = new System.Drawing.Point(12, 12);
            this.btGenerateInput.Name = "btGenerateInput";
            this.btGenerateInput.Size = new System.Drawing.Size(148, 48);
            this.btGenerateInput.TabIndex = 0;
            this.btGenerateInput.Text = "Generic random txt ";
            this.btGenerateInput.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btGenerateInput.UseVisualStyleBackColor = false;
            this.btGenerateInput.Click += new System.EventHandler(this.btGenerateFile_Click);
            // 
            // btGenericOut
            // 
            this.btGenericOut.Location = new System.Drawing.Point(166, 12);
            this.btGenericOut.Name = "btGenericOut";
            this.btGenericOut.Size = new System.Drawing.Size(145, 48);
            this.btGenericOut.TabIndex = 1;
            this.btGenericOut.Text = "Generic  Output";
            this.btGenericOut.UseVisualStyleBackColor = true;
            this.btGenericOut.Click += new System.EventHandler(this.btGenericOut_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(12, 251);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(35, 13);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "label1";
            // 
            // tbOutFile
            // 
            this.tbOutFile.Location = new System.Drawing.Point(12, 66);
            this.tbOutFile.Multiline = true;
            this.tbOutFile.Name = "tbOutFile";
            this.tbOutFile.Size = new System.Drawing.Size(299, 143);
            this.tbOutFile.TabIndex = 3;
            // 
            // btOpenOutFile
            // 
            this.btOpenOutFile.Location = new System.Drawing.Point(12, 215);
            this.btOpenOutFile.Name = "btOpenOutFile";
            this.btOpenOutFile.Size = new System.Drawing.Size(299, 23);
            this.btOpenOutFile.TabIndex = 4;
            this.btOpenOutFile.Text = "Open *.out";
            this.btOpenOutFile.UseVisualStyleBackColor = true;
            this.btOpenOutFile.Click += new System.EventHandler(this.btOpenOutFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 273);
            this.Controls.Add(this.btOpenOutFile);
            this.Controls.Add(this.tbOutFile);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btGenericOut);
            this.Controls.Add(this.btGenerateInput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "FileWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGenerateInput;
        private System.Windows.Forms.Button btGenericOut;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox tbOutFile;
        private System.Windows.Forms.Button btOpenOutFile;
    }
}

