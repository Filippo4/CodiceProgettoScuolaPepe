using System;

namespace VotoMassimoScuola
{
    public class Scuola
    {
        public string Nome { get; private set; }
        public Scuola(string n)
        {
            Nome = n;
        }
        public Classe CreateClass(string s, int a)
        {
            Classe classe = new Classe(a, s);
            return classe;
        }
        public Materia CreatMateria(string n)
        {
            Materia materia = new Materia(n);
            return materia;
        }

    }
}
