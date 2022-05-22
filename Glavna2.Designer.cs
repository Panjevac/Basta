namespace Basta
{
    partial class Glavna2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.obradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pozicijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sadiocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sadnjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obradaToolStripMenuItem,
            this.novoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // obradaToolStripMenuItem
            // 
            this.obradaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pozicijaToolStripMenuItem,
            this.tipToolStripMenuItem,
            this.sadiocToolStripMenuItem});
            this.obradaToolStripMenuItem.Name = "obradaToolStripMenuItem";
            this.obradaToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.obradaToolStripMenuItem.Text = "Podaci";
            this.obradaToolStripMenuItem.Click += new System.EventHandler(this.obradaToolStripMenuItem_Click);
            // 
            // pozicijaToolStripMenuItem
            // 
            this.pozicijaToolStripMenuItem.Name = "pozicijaToolStripMenuItem";
            this.pozicijaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pozicijaToolStripMenuItem.Text = "Pozicija";
            this.pozicijaToolStripMenuItem.Click += new System.EventHandler(this.pozicijaToolStripMenuItem_Click);
            // 
            // tipToolStripMenuItem
            // 
            this.tipToolStripMenuItem.Name = "tipToolStripMenuItem";
            this.tipToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tipToolStripMenuItem.Text = "Tip";
            this.tipToolStripMenuItem.Click += new System.EventHandler(this.tipToolStripMenuItem_Click);
            // 
            // sadiocToolStripMenuItem
            // 
            this.sadiocToolStripMenuItem.Name = "sadiocToolStripMenuItem";
            this.sadiocToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sadiocToolStripMenuItem.Text = "Sadioc";
            this.sadiocToolStripMenuItem.Click += new System.EventHandler(this.sadiocToolStripMenuItem_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sadnjaToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // sadnjaToolStripMenuItem
            // 
            this.sadnjaToolStripMenuItem.Name = "sadnjaToolStripMenuItem";
            this.sadnjaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sadnjaToolStripMenuItem.Text = "Sadnja";
            this.sadnjaToolStripMenuItem.Click += new System.EventHandler(this.sadnjaToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Glavna2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavna2";
            this.Text = "Glavna2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Glavna2_FormClosed_1);
            this.Load += new System.EventHandler(this.Glavna2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem obradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pozicijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sadiocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sadnjaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}