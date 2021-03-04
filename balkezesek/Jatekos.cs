﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balkezesek
{
    class Jatekos
    {
        private string nev;
        private DateTime elso;
        private DateTime utolso;
        private int suly;
        private int magassag;

        public Jatekos(string nev, DateTime elso, DateTime utolso, int suly, int magassag)
        {
            this.nev = nev;
            this.elso = elso;
            this.utolso = utolso;
            this.suly = suly;
            this.magassag = magassag;
        }

        public string Nev { get => nev; set => nev = value; }
        public DateTime Elso { get => elso; set => elso = value; }
        public DateTime Utolso { get => utolso; set => utolso = value; }
        public int Suly { get => suly; set => suly = value; }
        public int Magassag { get => magassag; set => magassag = value; }

        public override string ToString()
        {
            return String.Format("\t{0}, {1} cm", nev, Math.Round(magassag * 2.54, 1));
        }
    }
}
