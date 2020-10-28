using System;
using System.Collections.Generic;
using System.Text;

namespace VotoMassimoScuola
{
    public class Studente
    {
        public string Nome { get; private set; }
        public string Cognome { get; private set; }
        public DateTime DataDiNascita { get; set; }
        public List<Votazione> Voti { get;}
        public Studente(string n,string c)
        {
            Nome = n;
            Cognome = c;
        }
        public void AddVoto( Votazione v)
        {
            Voti.Add(v);
        }
        public Votazione TrovaVotoMassimo()
        {
            double max = 0;
            for (int i = 0; i>Voti.Count;i++)
            {
                if (Voti[i]>)
                {
                    max = Voti[i];
                }

                return max;
            }
        }
    }
}
