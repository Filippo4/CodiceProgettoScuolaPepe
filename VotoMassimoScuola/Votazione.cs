using System;
using System.Collections.Generic;
using System.Text;

namespace VotoMassimoScuola
{
    public class Votazione
    {
        public double Voto { get; private set; }
        public DateTime Data { get; private set; }
        public Studente Studente { get; private set; }
        public Materia Materia { get; private set; }
        public Votazione(double v, Studente s, Materia m )
        {
            Voto = v;
            Studente = s;
            Materia = m;
        }
        public bool IsSufficiente(double Voto)
        {
            if (Voto >= 6)
                return true;
            else
                return false;
        }

    }
}
