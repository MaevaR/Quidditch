using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace QuidditchConsole
{
    class Program
    {
        public void ModeTexte()
        {
            int quitter = 0;
            var funcs = new List<Func<List<String>>>(); // Liste de Func<IEnumerable<String>> 
            // fonction qui ne prend pas de paramètre et retourne une liste de String
            CoupeManager tournoi = new CoupeManager();

            funcs.Add(tournoi.AfficheMatchsProgrammés);
            funcs.Add(tournoi.AfficheStadesProgrammés);
            funcs.Add(tournoi.AfficheAttrapeursADomicile);

            while (quitter == 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("Pour afficher la liste des Matchs prévus tapez 1");
                Console.WriteLine("Pour afficher les Stades avec au moins un match pogrammé prévus tapez 2");
                Console.WriteLine("Pour afficher la liste des attrapeurs qui ont joués à domicile tapez 3");
                Console.WriteLine("Pour quitter tapez 0");


                string saisie = Console.ReadLine();

                if (saisie == "0") quitter = 1;
                else
                {
                    int valeur;
                    bool reussi = int.TryParse(saisie, out valeur);
                    if (reussi)
                    {
                        var func = funcs[valeur - 1];
                        IEnumerable<String> resultat = func(); // appel de la fonction

                        foreach (String ligne in resultat)
                        {
                            Console.WriteLine(ligne);
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ModeTexte();
        }
    }
}
