using System;
using System.Collections.Generic;
using System.Text;

namespace VotoMassimoScuola
{
    public class Docente
    {
        public string nome { get; private set; }
        public string cognome { get; private set; }
        public Materia materia { get; set; }
        public Docente (string n , string c ,Materia m)
        {
            nome = n;
            cognome = c;
            materia = m;
        }
        public Votazione AssegnaVoto(double v , Studente s)
        {
           Votazione voto = new Votazione(v, s, materia);
            return voto;
        }

    }
}
