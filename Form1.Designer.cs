
namespace etteremProjekt
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
            this.gbox_rendelo = new System.Windows.Forms.GroupBox();
            this.tav = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tszam = new System.Windows.Forms.TextBox();
            this.rendelocim = new System.Windows.Forms.TextBox();
            this.rendelonev = new System.Windows.Forms.TextBox();
            this.gbox_feltet = new System.Windows.Forms.GroupBox();
            this.e_tartar = new System.Windows.Forms.CheckBox();
            this.e_hagyma = new System.Windows.Forms.CheckBox();
            this.e_bbq = new System.Windows.Forms.CheckBox();
            this.e_chilli = new System.Windows.Forms.CheckBox();
            this.e_sajt = new System.Windows.Forms.CheckBox();
            this.gbox_etel = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.megjegyzes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.enev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eid = new System.Windows.Forms.ComboBox();
            this.gomb = new System.Windows.Forms.Button();
            this.gbox_rendelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tav)).BeginInit();
            this.gbox_feltet.SuspendLayout();
            this.gbox_etel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_rendelo
            // 
            this.gbox_rendelo.Controls.Add(this.tav);
            this.gbox_rendelo.Controls.Add(this.label4);
            this.gbox_rendelo.Controls.Add(this.label3);
            this.gbox_rendelo.Controls.Add(this.label2);
            this.gbox_rendelo.Controls.Add(this.label1);
            this.gbox_rendelo.Controls.Add(this.tszam);
            this.gbox_rendelo.Controls.Add(this.rendelocim);
            this.gbox_rendelo.Controls.Add(this.rendelonev);
            this.gbox_rendelo.Location = new System.Drawing.Point(18, 12);
            this.gbox_rendelo.Name = "gbox_rendelo";
            this.gbox_rendelo.Size = new System.Drawing.Size(806, 175);
            this.gbox_rendelo.TabIndex = 0;
            this.gbox_rendelo.TabStop = false;
            this.gbox_rendelo.Text = "Megrendelő adatai";
            // 
            // tav
            // 
            this.tav.Location = new System.Drawing.Point(726, 87);
            this.tav.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.tav.Name = "tav";
            this.tav.Size = new System.Drawing.Size(74, 20);
            this.tav.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(723, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Távolság (km):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefonszám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Címe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Neve:";
            // 
            // tszam
            // 
            this.tszam.Location = new System.Drawing.Point(617, 86);
            this.tszam.MaxLength = 11;
            this.tszam.Name = "tszam";
            this.tszam.Size = new System.Drawing.Size(100, 20);
            this.tszam.TabIndex = 2;
            this.tszam.TextChanged += new System.EventHandler(this.tszam_TextChanged);
            // 
            // rendelocim
            // 
            this.rendelocim.Location = new System.Drawing.Point(183, 87);
            this.rendelocim.Name = "rendelocim";
            this.rendelocim.Size = new System.Drawing.Size(428, 20);
            this.rendelocim.TabIndex = 1;
            // 
            // rendelonev
            // 
            this.rendelonev.Location = new System.Drawing.Point(22, 87);
            this.rendelonev.Name = "rendelonev";
            this.rendelonev.Size = new System.Drawing.Size(155, 20);
            this.rendelonev.TabIndex = 0;
            this.rendelonev.TextChanged += new System.EventHandler(this.rendelonev_TextChanged);
            // 
            // gbox_feltet
            // 
            this.gbox_feltet.Controls.Add(this.e_tartar);
            this.gbox_feltet.Controls.Add(this.e_hagyma);
            this.gbox_feltet.Controls.Add(this.e_bbq);
            this.gbox_feltet.Controls.Add(this.e_chilli);
            this.gbox_feltet.Controls.Add(this.e_sajt);
            this.gbox_feltet.Location = new System.Drawing.Point(849, 12);
            this.gbox_feltet.Name = "gbox_feltet";
            this.gbox_feltet.Size = new System.Drawing.Size(230, 278);
            this.gbox_feltet.TabIndex = 1;
            this.gbox_feltet.TabStop = false;
            this.gbox_feltet.Text = "Extra feltétek";
            // 
            // e_tartar
            // 
            this.e_tartar.AutoSize = true;
            this.e_tartar.Location = new System.Drawing.Point(40, 145);
            this.e_tartar.Name = "e_tartar";
            this.e_tartar.Size = new System.Drawing.Size(119, 17);
            this.e_tartar.TabIndex = 4;
            this.e_tartar.Text = "Tartár szósz - 200Ft";
            this.e_tartar.UseVisualStyleBackColor = true;
            // 
            // e_hagyma
            // 
            this.e_hagyma.AutoSize = true;
            this.e_hagyma.Location = new System.Drawing.Point(40, 168);
            this.e_hagyma.Name = "e_hagyma";
            this.e_hagyma.Size = new System.Drawing.Size(133, 17);
            this.e_hagyma.TabIndex = 3;
            this.e_hagyma.Text = "Pirított hagyma - 200Ft";
            this.e_hagyma.UseVisualStyleBackColor = true;
            // 
            // e_bbq
            // 
            this.e_bbq.AutoSize = true;
            this.e_bbq.Location = new System.Drawing.Point(40, 122);
            this.e_bbq.Name = "e_bbq";
            this.e_bbq.Size = new System.Drawing.Size(137, 17);
            this.e_bbq.TabIndex = 2;
            this.e_bbq.Text = "Barbecue szósz - 250Ft";
            this.e_bbq.UseVisualStyleBackColor = true;
            // 
            // e_chilli
            // 
            this.e_chilli.AutoSize = true;
            this.e_chilli.Location = new System.Drawing.Point(40, 99);
            this.e_chilli.Name = "e_chilli";
            this.e_chilli.Size = new System.Drawing.Size(112, 17);
            this.e_chilli.TabIndex = 1;
            this.e_chilli.Text = "Chilli szósz - 200Ft";
            this.e_chilli.UseVisualStyleBackColor = true;
            // 
            // e_sajt
            // 
            this.e_sajt.AutoSize = true;
            this.e_sajt.Location = new System.Drawing.Point(40, 77);
            this.e_sajt.Name = "e_sajt";
            this.e_sajt.Size = new System.Drawing.Size(105, 17);
            this.e_sajt.TabIndex = 0;
            this.e_sajt.Text = "Extra sajt - 150Ft";
            this.e_sajt.UseVisualStyleBackColor = true;
            // 
            // gbox_etel
            // 
            this.gbox_etel.Controls.Add(this.label8);
            this.gbox_etel.Controls.Add(this.megjegyzes);
            this.gbox_etel.Controls.Add(this.label7);
            this.gbox_etel.Controls.Add(this.ear);
            this.gbox_etel.Controls.Add(this.label6);
            this.gbox_etel.Controls.Add(this.enev);
            this.gbox_etel.Controls.Add(this.label5);
            this.gbox_etel.Controls.Add(this.eid);
            this.gbox_etel.Location = new System.Drawing.Point(18, 376);
            this.gbox_etel.Name = "gbox_etel";
            this.gbox_etel.Size = new System.Drawing.Size(806, 175);
            this.gbox_etel.TabIndex = 2;
            this.gbox_etel.TabStop = false;
            this.gbox_etel.Text = "Rendelés adatai";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(480, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Megjegyzés:";
            // 
            // megjegyzes
            // 
            this.megjegyzes.Location = new System.Drawing.Point(479, 87);
            this.megjegyzes.Name = "megjegyzes";
            this.megjegyzes.Size = new System.Drawing.Size(321, 20);
            this.megjegyzes.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ára:";
            // 
            // ear
            // 
            this.ear.Enabled = false;
            this.ear.Location = new System.Drawing.Point(373, 86);
            this.ear.Name = "ear";
            this.ear.Size = new System.Drawing.Size(100, 20);
            this.ear.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Étel neve:";
            // 
            // enev
            // 
            this.enev.Enabled = false;
            this.enev.Location = new System.Drawing.Point(54, 87);
            this.enev.Name = "enev";
            this.enev.Size = new System.Drawing.Size(313, 20);
            this.enev.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Étel ID:";
            // 
            // eid
            // 
            this.eid.Cursor = System.Windows.Forms.Cursors.Default;
            this.eid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eid.FormattingEnabled = true;
            this.eid.Location = new System.Drawing.Point(6, 86);
            this.eid.Name = "eid";
            this.eid.Size = new System.Drawing.Size(42, 21);
            this.eid.TabIndex = 0;
            this.eid.SelectedIndexChanged += new System.EventHandler(this.eid_SelectedIndexChanged);
            // 
            // gomb
            // 
            this.gomb.BackColor = System.Drawing.Color.RosyBrown;
            this.gomb.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gomb.FlatAppearance.BorderSize = 2;
            this.gomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gomb.Location = new System.Drawing.Point(849, 386);
            this.gomb.Name = "gomb";
            this.gomb.Size = new System.Drawing.Size(230, 128);
            this.gomb.TabIndex = 3;
            this.gomb.Text = "Bizonylat kinyomtatása";
            this.gomb.UseVisualStyleBackColor = false;
            this.gomb.Click += new System.EventHandler(this.gomb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(128)))), ((int)(((byte)(116)))));
            this.BackgroundImage = global::etteremProjekt.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1118, 566);
            this.Controls.Add(this.gomb);
            this.Controls.Add(this.gbox_etel);
            this.Controls.Add(this.gbox_feltet);
            this.Controls.Add(this.gbox_rendelo);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1134, 605);
            this.MinimumSize = new System.Drawing.Size(1134, 605);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "McBooks Restaurant - Rendelés leadás";
            this.gbox_rendelo.ResumeLayout(false);
            this.gbox_rendelo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tav)).EndInit();
            this.gbox_feltet.ResumeLayout(false);
            this.gbox_feltet.PerformLayout();
            this.gbox_etel.ResumeLayout(false);
            this.gbox_etel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_rendelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tszam;
        private System.Windows.Forms.TextBox rendelocim;
        private System.Windows.Forms.TextBox rendelonev;
        private System.Windows.Forms.GroupBox gbox_feltet;
        private System.Windows.Forms.CheckBox e_tartar;
        private System.Windows.Forms.CheckBox e_hagyma;
        private System.Windows.Forms.CheckBox e_bbq;
        private System.Windows.Forms.CheckBox e_chilli;
        private System.Windows.Forms.CheckBox e_sajt;
        private System.Windows.Forms.GroupBox gbox_etel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox megjegyzes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox enev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox eid;
        private System.Windows.Forms.Button gomb;
        private System.Windows.Forms.NumericUpDown tav;
    }
}

