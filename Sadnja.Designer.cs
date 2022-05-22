namespace Basta
{
    partial class Sadnja
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_prikaz = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.txt_vreme = new System.Windows.Forms.TextBox();
            this.txt_god = new System.Windows.Forms.TextBox();
            this.txt_mesec = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.cmb_tip = new System.Windows.Forms.ComboBox();
            this.cmb_sadioc = new System.Windows.Forms.ComboBox();
            this.cmb_poz = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sadioc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Osuncanost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "M. sadnje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vreme radjanja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Godina sadnje";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(407, 180);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Dodaj";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_prikaz
            // 
            this.btn_prikaz.Location = new System.Drawing.Point(522, 180);
            this.btn_prikaz.Name = "btn_prikaz";
            this.btn_prikaz.Size = new System.Drawing.Size(75, 23);
            this.btn_prikaz.TabIndex = 8;
            this.btn_prikaz.Text = "Prikazi";
            this.btn_prikaz.UseVisualStyleBackColor = true;
            this.btn_prikaz.Click += new System.EventHandler(this.btn_prikaz_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(628, 180);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 9;
            this.btn_del.Text = "Izbrisi";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // grid1
            // 
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Location = new System.Drawing.Point(38, 240);
            this.grid1.Name = "grid1";
            this.grid1.RowHeadersWidth = 51;
            this.grid1.RowTemplate.Height = 24;
            this.grid1.Size = new System.Drawing.Size(715, 184);
            this.grid1.TabIndex = 10;
            // 
            // txt_vreme
            // 
            this.txt_vreme.Location = new System.Drawing.Point(179, 89);
            this.txt_vreme.Name = "txt_vreme";
            this.txt_vreme.Size = new System.Drawing.Size(100, 22);
            this.txt_vreme.TabIndex = 12;
            // 
            // txt_god
            // 
            this.txt_god.Location = new System.Drawing.Point(179, 138);
            this.txt_god.Name = "txt_god";
            this.txt_god.Size = new System.Drawing.Size(100, 22);
            this.txt_god.TabIndex = 13;
            // 
            // txt_mesec
            // 
            this.txt_mesec.Location = new System.Drawing.Point(394, 138);
            this.txt_mesec.Name = "txt_mesec";
            this.txt_mesec.Size = new System.Drawing.Size(100, 22);
            this.txt_mesec.TabIndex = 14;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(603, 43);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 22);
            this.txt_id.TabIndex = 17;
            // 
            // cmb_tip
            // 
            this.cmb_tip.FormattingEnabled = true;
            this.cmb_tip.Location = new System.Drawing.Point(179, 45);
            this.cmb_tip.Name = "cmb_tip";
            this.cmb_tip.Size = new System.Drawing.Size(121, 24);
            this.cmb_tip.TabIndex = 18;
            // 
            // cmb_sadioc
            // 
            this.cmb_sadioc.FormattingEnabled = true;
            this.cmb_sadioc.Location = new System.Drawing.Point(373, 45);
            this.cmb_sadioc.Name = "cmb_sadioc";
            this.cmb_sadioc.Size = new System.Drawing.Size(121, 24);
            this.cmb_sadioc.TabIndex = 19;
            // 
            // cmb_poz
            // 
            this.cmb_poz.FormattingEnabled = true;
            this.cmb_poz.Location = new System.Drawing.Point(373, 89);
            this.cmb_poz.Name = "cmb_poz";
            this.cmb_poz.Size = new System.Drawing.Size(121, 24);
            this.cmb_poz.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Broj meseca";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(402, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Prilikom brisanja samo uneti ID zeljenog objekta i kliknuti izbrisi";
            // 
            // Sadnja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_poz);
            this.Controls.Add(this.cmb_sadioc);
            this.Controls.Add(this.cmb_tip);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_mesec);
            this.Controls.Add(this.txt_god);
            this.Controls.Add(this.txt_vreme);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_prikaz);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sadnja";
            this.Text = "Sadnja";
            this.Load += new System.EventHandler(this.Sadnja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_prikaz;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.TextBox txt_vreme;
        private System.Windows.Forms.TextBox txt_god;
        private System.Windows.Forms.TextBox txt_mesec;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.ComboBox cmb_tip;
        private System.Windows.Forms.ComboBox cmb_sadioc;
        private System.Windows.Forms.ComboBox cmb_poz;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}