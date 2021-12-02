namespace P4_4_1204029
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btTampil = new System.Windows.Forms.Button();
            this.cbLomba = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbHP = new System.Windows.Forms.TextBox();
            this.tbTeam = new System.Windows.Forms.TextBox();
            this.btKeluar = new System.Windows.Forms.Button();
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.tbAng = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(125, 47);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(145, 20);
            this.tbNama.TabIndex = 0;
            this.tbNama.Leave += new System.EventHandler(this.tbNama_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pendaftaran Liga E-Sport";
            // 
            // btTampil
            // 
            this.btTampil.Location = new System.Drawing.Point(326, 80);
            this.btTampil.Name = "btTampil";
            this.btTampil.Size = new System.Drawing.Size(75, 23);
            this.btTampil.TabIndex = 2;
            this.btTampil.Text = "Tampilkan";
            this.btTampil.UseVisualStyleBackColor = true;
            this.btTampil.Click += new System.EventHandler(this.btTampil_Click);
            // 
            // cbLomba
            // 
            this.cbLomba.FormattingEnabled = true;
            this.cbLomba.Items.AddRange(new object[] {
            "Mobile Legend",
            "Free Fire",
            "Point Blank",
            "PUBG Mobile"});
            this.cbLomba.Location = new System.Drawing.Point(125, 197);
            this.cbLomba.Name = "cbLomba";
            this.cbLomba.Size = new System.Drawing.Size(145, 21);
            this.cbLomba.TabIndex = 3;
            this.cbLomba.Text = "--- Pilihan Game Online ---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "No HP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Game";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(125, 77);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(145, 20);
            this.tbEmail.TabIndex = 9;
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // tbHP
            // 
            this.tbHP.Location = new System.Drawing.Point(125, 107);
            this.tbHP.Name = "tbHP";
            this.tbHP.Size = new System.Drawing.Size(145, 20);
            this.tbHP.TabIndex = 10;
            this.tbHP.Leave += new System.EventHandler(this.tbHP_Leave);
            // 
            // tbTeam
            // 
            this.tbTeam.Location = new System.Drawing.Point(125, 137);
            this.tbTeam.Name = "tbTeam";
            this.tbTeam.Size = new System.Drawing.Size(145, 20);
            this.tbTeam.TabIndex = 11;
            this.tbTeam.Leave += new System.EventHandler(this.tbTeam_Leave);
            // 
            // btKeluar
            // 
            this.btKeluar.Location = new System.Drawing.Point(326, 135);
            this.btKeluar.Name = "btKeluar";
            this.btKeluar.Size = new System.Drawing.Size(75, 23);
            this.btKeluar.TabIndex = 13;
            this.btKeluar.Text = "Keluar";
            this.btKeluar.UseVisualStyleBackColor = true;
            this.btKeluar.Click += new System.EventHandler(this.btKeluar_Click);
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Anggota";
            // 
            // tbAng
            // 
            this.tbAng.Location = new System.Drawing.Point(125, 167);
            this.tbAng.Name = "tbAng";
            this.tbAng.Size = new System.Drawing.Size(145, 20);
            this.tbAng.TabIndex = 15;
            this.tbAng.Leave += new System.EventHandler(this.tbAng_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 239);
            this.Controls.Add(this.tbAng);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btKeluar);
            this.Controls.Add(this.tbTeam);
            this.Controls.Add(this.tbHP);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLomba);
            this.Controls.Add(this.btTampil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNama);
            this.Name = "Form1";
            this.Text = "Liga Kampung Cibogo";
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTampil;
        private System.Windows.Forms.ComboBox cbLomba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbHP;
        private System.Windows.Forms.TextBox tbTeam;
        private System.Windows.Forms.Button btKeluar;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.TextBox tbAng;
        private System.Windows.Forms.Label label7;
    }
}

