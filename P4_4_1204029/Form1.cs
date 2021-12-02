using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace P4_4_1204029
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbNama_Leave(object sender, EventArgs e)
        {
            if (tbNama.Text == "")
            {
                epWarning.SetError(tbNama, "Nama tidak boleh kosong brodi !");
                epWrong.SetError(tbNama, "");
                epCorrect.SetError(tbNama, "");
            }
            else
            {
                if (tbNama.Text != tbNama.Text.ToUpper()) 
                {
                    epWrong.SetError(tbNama, "Pakai Huruf Kapital Ya Brodi!");
                    epWarning.SetError(tbNama, "");
                    epCorrect.SetError(tbNama, "");
                }
                else
                if ((tbNama.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(tbNama, "");
                    epWrong.SetError(tbNama, "");
                    epCorrect.SetError(tbNama, "Betul Brodi");
                }
                else
                {
                    epWrong.SetError(tbNama, "Inputan hanya boleh huruf ya brodi!");
                    epWarning.SetError(tbNama, "");
                    epCorrect.SetError(tbNama, "");
                }
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                epWarning.SetError(tbEmail, "Text Box Email tidak boleh kosong !");
                epWrong.SetError(tbEmail, "");
                epCorrect.SetError(tbEmail, "");
            }
            else
            {
                if (Regex.IsMatch(tbEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epCorrect.SetError(tbEmail, "Betul");
                    epWarning.SetError(tbEmail, "");
                    epWrong.SetError(tbEmail, "");

                }
                else
                {
                    epCorrect.SetError(tbEmail, "");
                    epWarning.SetError(tbEmail, "");
                    epWrong.SetError(tbEmail, "Format email salah ! \nContoh : a@b.c");
                }
            }
        }

        private void tbHP_Leave(object sender, EventArgs e)       
        {
            if (tbHP.Text.Length > 13)
            {
                epWarning.SetError(tbHP, "Tidak boleh lebih dari 13 digit !!!!");
                epWrong.SetError(tbHP, "");
                epCorrect.SetError(tbHP, "");
            }
            else if ((tbHP.Text).All(Char.IsNumber)) 
            {
                epWarning.SetError(tbHP, "");
                epWrong.SetError(tbHP, "");
                epCorrect.SetError(tbHP, "Betul!");
            }
            else
            {
                epWrong.SetError(tbHP, "Inputan hanya boleh Angka!");
                epWarning.SetError(tbHP, "");
                epCorrect.SetError(tbHP, "");
            }
            if (tbHP.Text == "")
            {
                epWarning.SetError(tbHP, "Kolom angka tidak boleh kosong!");
                epWrong.SetError(tbHP, "");
                epCorrect.SetError(tbHP, "");
            }
            
        }

        private void tbAng_Leave(object sender, EventArgs e)
        {
            if (tbAng.Text.Length > 1)
            {
                epWarning.SetError(tbAng, "Anggota hanya boleh 1 digit angka!");               
                epWrong.SetError(tbAng, "");
                epCorrect.SetError(tbAng, "");
            }
            else if ((tbAng.Text).All(Char.IsNumber)) //Numeric TextBox
            {
                epWarning.SetError(tbAng, "");
                epWrong.SetError(tbAng, "");
                epCorrect.SetError(tbAng, "Betul!");
            }
            else
            {
                epWrong.SetError(tbAng, "Inputan hanya boleh angka ya Brodi !!!");
                epWarning.SetError(tbAng, "");
                epCorrect.SetError(tbAng, "");
            }
            if (tbAng.Text == "")
            {
                epWarning.SetError(tbAng, "Anggota Harus Di Isi Ya Brodi!");
                epWrong.SetError(tbAng, "");
                epCorrect.SetError(tbAng, "");
            }
            if (tbAng.Text != "") //Comparison
            {
                if ((int.Parse(tbAng.Text) <= 2))
                {
                    epWarning.SetError(tbAng, "");
                    epWrong.SetError(tbAng, "Anggota Harus Lebih Dari 2 ya Brodi!!");
                    epCorrect.SetError(tbAng, "");
                }
                else { }
            }
        }

        private void tbTeam_Leave(object sender, EventArgs e)
        {
            if (tbTeam.Text == "")
            {
                epWarning.SetError(tbTeam, "Nama tidak boleh kosong brodi !");
                epWrong.SetError(tbTeam, "");
                epCorrect.SetError(tbTeam, "");
            }
            else
            {
                if (tbTeam.Text != tbTeam.Text.ToLower())
                {
                    epWrong.SetError(tbTeam, "Jangan Huruf Kapital Ya Brodi!");
                    epWarning.SetError(tbTeam, "");
                    epCorrect.SetError(tbTeam, "");
                }
                else
                if ((tbTeam.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(tbTeam, "");
                    epWrong.SetError(tbTeam, "");
                    epCorrect.SetError(tbTeam, "Betul Brodi");
                }
                else
                {
                    epWrong.SetError(tbTeam, "Inputan hanya boleh huruf ya brodi!");
                    epWarning.SetError(tbTeam, "");
                    epCorrect.SetError(tbTeam, "");
                }
            }
        }

        private void btKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTampil_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                    ("Nama : " + tbNama.Text +
                    "\nEmail : " + tbEmail.Text +
                    "\nNo HP : " + tbHP.Text +
                    "\nTeam : " + tbTeam.Text +
                    "\nAnggota : " + tbAng.Text+
                    "\nGame : " + cbLomba.Text,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

