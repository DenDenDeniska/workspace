namespace Lab3_CompManager
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1_Delay = new System.Windows.Forms.TextBox();
            this.label1_timeNow = new System.Windows.Forms.Label();
            this.label1_devTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(437, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(170, 290);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавитьзадачу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 38);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(375, 238);
            this.listBox2.TabIndex = 2;
            this.listBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Выполнить задачу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 334);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 36);
            this.button3.TabIndex = 4;
            this.button3.Text = "Остановить задачу";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 415);
            this.progressBar1.MarqueeAnimationSpeed = 10000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(375, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // textBox1_Delay
            // 
            this.textBox1_Delay.Location = new System.Drawing.Point(12, 282);
            this.textBox1_Delay.Name = "textBox1_Delay";
            this.textBox1_Delay.Size = new System.Drawing.Size(113, 20);
            this.textBox1_Delay.TabIndex = 6;
            // 
            // label1_timeNow
            // 
            this.label1_timeNow.AutoSize = true;
            this.label1_timeNow.Location = new System.Drawing.Point(12, 399);
            this.label1_timeNow.Name = "label1_timeNow";
            this.label1_timeNow.Size = new System.Drawing.Size(0, 13);
            this.label1_timeNow.TabIndex = 7;
            // 
            // label1_devTime
            // 
            this.label1_devTime.AutoSize = true;
            this.label1_devTime.Location = new System.Drawing.Point(352, 399);
            this.label1_devTime.Name = "label1_devTime";
            this.label1_devTime.Size = new System.Drawing.Size(0, 13);
            this.label1_devTime.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1_devTime);
            this.Controls.Add(this.label1_timeNow);
            this.Controls.Add(this.textBox1_Delay);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form3";
            this.Text = "Свойства";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        internal System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1_Delay;
        private System.Windows.Forms.Label label1_timeNow;
        private System.Windows.Forms.Label label1_devTime;
    }
}