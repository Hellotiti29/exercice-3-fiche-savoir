using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_3_fiche_savoir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable 
            float moyenne, totalNotes;
            int Nbnote;

            //saisie d'une note
            {
                Console.WriteLine("Entrez une somme de note:");
                totalNotes = float.Parse(Console.ReadLine());
                Console.WriteLine("Entrez le nombre de note:");
                Nbnote = int.Parse(Console.ReadLine());

            // Calcul de la moyenne
                moyenne = Nbnote / totalNotes;
            // Affichage de la moyenne
                Console.WriteLine("Moyenne =" + moyenne);
                Console.ReadLine();
            }
        }
    }
}
