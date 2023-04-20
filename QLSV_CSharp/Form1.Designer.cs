namespace QLSV_CSharp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhapDLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpDLTableLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpDLTableSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapDLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhapDLToolStripMenuItem
            // 
            this.nhapDLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpDLTableLớpToolStripMenuItem,
            this.nhậpDLTableSinhViênToolStripMenuItem});
            this.nhapDLToolStripMenuItem.Name = "nhapDLToolStripMenuItem";
            this.nhapDLToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.nhapDLToolStripMenuItem.Text = "Nhập DL";
            // 
            // nhậpDLTableLớpToolStripMenuItem
            // 
            this.nhậpDLTableLớpToolStripMenuItem.Name = "nhậpDLTableLớpToolStripMenuItem";
            this.nhậpDLTableLớpToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.nhậpDLTableLớpToolStripMenuItem.Text = "Nhập DL Table Lớp";
            this.nhậpDLTableLớpToolStripMenuItem.Click += new System.EventHandler(this.nhậpDLTableLớpToolStripMenuItem_Click);
            // 
            // nhậpDLTableSinhViênToolStripMenuItem
            // 
            this.nhậpDLTableSinhViênToolStripMenuItem.Name = "nhậpDLTableSinhViênToolStripMenuItem";
            this.nhậpDLTableSinhViênToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.nhậpDLTableSinhViênToolStripMenuItem.Text = "Nhập DL Table Sinh Viên";
            this.nhậpDLTableSinhViênToolStripMenuItem.Click += new System.EventHandler(this.nhậpDLTableSinhViênToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 458);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhapDLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpDLTableLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpDLTableSinhViênToolStripMenuItem;

    }
}

