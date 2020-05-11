using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskON
{
    class Account
    {
        // buat method sesuai tugas Chapter 2
        private string _userName;
        private string _passWord;
        private string _namaAsli;
        private string _eMail;
        private int _noTelp;
        private string _gender;
        private int _nik;
        private string _lokasiUser;
        private string _tipeAkun;

        // properti
        public string Username
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string Password
        {
            get { return _passWord; }
            set { _passWord = value; }
        }
        public string NamaAsli
        {
            get { return _namaAsli; }
            set { _namaAsli = value; }
        }
        public string Email
        {
            get { return _eMail; }
            set { _eMail = value; }
        }
        public int NomorTelp
        {
            get { return _noTelp; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public int NIK
        {
            get { return _nik; }
        }
        public string LokasiUser
        {
            get { return _lokasiUser; }
            set { _lokasiUser = value; }
        }
        public string TipeAkun
        {
            get { return _tipeAkun; }
            set { _tipeAkun = value; }
        }

        // definisi method login
        public Boolean Login(string userName, string passWord)
        {
            //data base RegisterForm dipakai disini
            //aku makai data contoh biar bisa
            if (userName == "bla" & passWord == "bla")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
