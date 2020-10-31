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
            studente.Add(s);
        }
        public Votazione TrovaVotoMassimo()
        {

            double max = -1;
            int indice = 0;
            for (int i = 0; i < studente.Count; i++)
            {
                Votazione voto = studente[i].TrovaVotoMassimo();
                if (voto.GetVotoDouble() > max)
                {
                    max = voto.GetVotoDouble();
                    indice = i;
                }
            }
            return studente[indice].TrovaVotoMassimo();

        }
    }
}
