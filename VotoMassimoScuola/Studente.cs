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
            int indice = 0;
            double max = -1;
            for (int i = 0; i < Voti.Count; i++)
            {
                if (Voti[i].GetVotoDouble() > max)
                    indice = i;
            }
            return Voti[indice].GetVoto();

        }
        public Votazione TrovaVotoMinimo()
        {
            int indice = 0;
            double min = 11;
            for (int i = 0; i < Voti.Count; i++)
            {
                if (Voti[i].GetVotoDouble() <min)
                    indice = i;
            }
            return Voti[indice].GetVoto();

        }
        public Votazione TrovaVotoPiuRecente()
        {
            DateTime DataRecente = new DateTime(2020,03,02);
            int indice = 0;
            for(int i = 0;i<Voti.Count;i++)
            {
                if(Voti[i].Data < DataRecente)
                {
                    DataRecente = Voti[i].Data;
                    indice = i;
                }
            }
            return Voti[indice];
        }
    }
}

