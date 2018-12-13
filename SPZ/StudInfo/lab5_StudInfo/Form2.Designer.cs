namespace lab5_StudInfo
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddStudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelStudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delLsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(195, 304);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStudToolStripMenuItem,
            this.DelStudToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 48);
            // 
            // AddStudToolStripMenuItem
            // 
            this.AddStudToolStripMenuItem.AccessibleName = "Add";
            this.AddStudToolStripMenuItem.Name = "AddStudToolStripMenuItem";
            this.AddStudToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.AddStudToolStripMenuItem.Text = "Добавить студента";
            this.AddStudToolStripMenuItem.Click += new System.EventHandler(this.AddStudToolStripMenuItem_Click);
            // 
            // DelStudToolStripMenuItem
            // 
            this.DelStudToolStripMenuItem.AccessibleName = "Del";
            this.DelStudToolStripMenuItem.Name = "DelStudToolStripMenuItem";
            this.DelStudToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.DelStudToolStripMenuItem.Text = "Удалить Студента";
            this.DelStudToolStripMenuItem.Click += new System.EventHandler(this.DelStudToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView2.Location = new System.Drawing.Point(230, 37);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(195, 304);
            this.dataGridView2.TabIndex = 2;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLSToolStripMenuItem,
            this.changeLsToolStripMenuItem,
            this.delLsToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 92);
            // 
            // addLSToolStripMenuItem
            // 
            this.addLSToolStripMenuItem.Name = "addLSToolStripMenuItem";
            this.addLSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addLSToolStripMenuItem.Text = "Добавить предмет";
            this.addLSToolStripMenuItem.Click += new System.EventHandler(this.addLSToolStripMenuItem_Click);
            // 
            // changeLsToolStripMenuItem
            // 
            this.changeLsToolStripMenuItem.Name = "changeLsToolStripMenuItem";
            this.changeLsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeLsToolStripMenuItem.Text = "Изменить";
            this.changeLsToolStripMenuItem.Click += new System.EventHandler(this.changeLsToolStripMenuItem_Click);
            // 
            // delLsToolStripMenuItem
            // 
            this.delLsToolStripMenuItem.Name = "delLsToolStripMenuItem";
            this.delLsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.delLsToolStripMenuItem.Text = "Удалить предмет";
            this.delLsToolStripMenuItem.Click += new System.EventHandler(this.delLsToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 376);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DelStudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddStudToolStripMenuItem;
        internal System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem addLSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delLsToolStripMenuItem;
    }
}