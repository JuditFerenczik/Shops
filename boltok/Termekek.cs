using System;
using System.Collections.Generic;
using System.Text;

namespace Boltos
{
    class Termekek
    {
        private string nev;
        private int ar;
        private string boltsorszam;
        public Termekek(string nev, int ar, string boltsorszam)
        {
            this.nev = nev;
            this.ar = ar;
            this.boltsorszam = boltsorszam;
        }


        public string getNev()
        {
            return this.nev;
        }


        public void setNev(string nev)
        {
            this.nev = nev;
        }


        public int getAr()
        {
            return this.ar;
        }


        public void setAr(int ar)
        {
            this.ar = ar;
        }



        public string getBoltsorszam()
        {
            return this.boltsorszam;
        }


        public void setBoltsorszam(string bolt)
        {
            this.boltsorszam = bolt;
        }
    }
}