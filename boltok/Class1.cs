using System;
using System.Collections.Generic;
using System.Text;

namespace boltok
{
    class Termekek
    {
        private string nev;
        private int ar;
        private int boltsorszam;
        public Termekek(string nev, int ar, int boltsorszam) {
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



        public int getBoltsorszam()
        {
            return this.boltsorszam;
        }


        public void setBoltsorszam(int bolt)
        {
            this.boltsorszam = bolt;
        }

    }


   
        static void Main(string[] args)
        {



        }
    }
        
