using System;
using VotoMassimoScuola;

namespace ProvaRegistroPepe
{
    class Program
    {
        static void Main(string[] args)
        {
            Scuola scuola = new Scuola("Rosselli_Rasetti");
            Classe classe = scuola.CreaClasse("AI",4);
            Studente studente1 = new Studente("Nicola", "Galeotti");
            Studente studente2 = new Studente("Narcis", "Buzatu");
            classe.AddStudente(studente1);
            classe.AddStudente(studente2);
            Materia materia1 = new Materia("Matematica");
            Votazione voto1 = new Votazione(8, studente1, materia1);
            Votazione voto2 = new Votazione(7, studente2, materia1);
            Votazione votomax = scuola.TrovaVotoMassimo();
            Console.WriteLine($"Il voto massimo della scuola {scuola.Nome} è {votomax.GetVotoDouble()}.");

        }
    }
}
