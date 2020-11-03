using System;
using System.Collections.Generic;

namespace VotoMassimoScuola
{
    public class Scuola
    {
        public string Nome { get; private set; }
        List<Classe> classi = new List<Classe>();
        List<Materia> materie = new List<Materia>();

        public Scuola(string n)
        {
            Nome = n;
        }
        public Classe CreaClasse(string s, int a)
        {
            Classe classe = new Classe(a, s);
            classi.Add(classe);
            return classe;
        }
        public Materia CreatMateria(string n)
        {
            Materia materia = new Materia(n);
            materie.Add(materia);
            return materia;
        }

        public Materia CreateMateria(string nome)
        {
            Materia materia = new Materia(nome);
            materie.Add(materia);
            return materia;
        }

        public List<Materia> GetMaterie()
        {
            return materie;
        }

        public Votazione TrovaVotoMassimo()
        {
            double max = -1;
            int indice = 0;
            for (int i = 0; i < classi.Count; i++)
            {
                Votazione voto = classi[i].TrovaVotoMassimo();
                if (voto.GetVotoDouble() > max)
                {
                    max = voto.GetVotoDouble();
                    indice = i;
                }
            }
            return classi[indice].TrovaVotoMinimo();
        }

        public Votazione TrovaVotoMinimo()
        {
            double min = 11;
            int indice = 0;
            for (int i = 0; i < classi.Count; i++)
            {
                Votazione voto = classi[i].TrovaVotoMinimo();
                if (voto.GetVotoDouble() < min)
                {
                    min = voto.GetVotoDouble();
                    indice = i;
                }
            }
            return classi[indice].TrovaVotoMinimo();
        }
    }
}
