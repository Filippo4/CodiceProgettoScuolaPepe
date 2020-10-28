using System;
using System.Collections.Generic;
using System.Text;

namespace VotoMassimoScuola
{
    public class Classe
    {
        public int Anno { get; private set; }
        private string Sezione;
        public List<Studente> studente { get;}
        public Classe(int a, string s)
        {
            Anno = a;
            Sezione = s;
        }
        public void AddStudente(Studente s)
        {
            studente.Add(s)
        }
        public Materia TrovaVotoMassimo()
        {

        }
    }
}
