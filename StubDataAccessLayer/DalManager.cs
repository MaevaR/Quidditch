using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;

namespace StubDataAccessLayer
{
    //stub = simuler

    public class DalManager
    {
        List<Joueur> joueurs;
        List<Equipe> equipes;
        List<Stade> stades;
        List<Match> matchs;
        List<Coupe> coupes;

        public DalManager()
        {
            joueurs =  new List<Joueur>();
            equipes =  new List<Equipe>();
            stades =  new List<Stade>();
            matchs = new List<Match>();
            coupes = new List<Coupe>();

            Joueur joueur1 = new Joueur(1,"Franky","Georges",new DateTime(1967,02,10),10,5,poste.poursuiveur);
            Joueur joueur2 = new Joueur(2,"Franklin","Arletta",new DateTime(1945,12,03),3,2,poste.gardien);
            Joueur joueur3 = new Joueur(3, "Barack", "Obama", new DateTime(1938, 08, 03),26,15,poste.attrapeur);
            Joueur joueur4 = new Joueur(4, "Wisley", "Ron", new DateTime(1988, 11, 09), 10, 10, poste.batteur);
            Joueur joueur5 = new Joueur(5, "Potter", "Harry", new DateTime(1989, 04, 01), 50, 30, poste.attrapeur);
            Joueur joueur6 = new Joueur(6, "Potter", "Germionne", new DateTime(1989, 06, 10), 50, 30, poste.gardien);

            joueurs.Add(joueur1);
            joueurs.Add(joueur2);
            joueurs.Add(joueur3);
            joueurs.Add(joueur4);
            joueurs.Add(joueur5);

            Equipe equipe1 = new Equipe(7, "Poudlard Team", "England");
            Equipe equipe2 = new Equipe(8,"US Team","USA");

            equipe1.AjouterJoueur(joueur4);
            equipe1.AjouterJoueur(joueur5);
            equipe1.AjouterJoueur(joueur6);

            equipe2.AjouterJoueur(joueur1);
            equipe2.AjouterJoueur(joueur2);
            equipe2.AjouterJoueur(joueur3);

            equipes.Add(equipe1);
            equipes.Add(equipe1);

            Stade stadeMich = new Stade(9,"Stade Michelin","11 rue michelin", 100, .60);

            stades.Add(stadeMich);

            Coupe coupe1 = new Coupe(100,1997);
            Coupe coupe2 = new Coupe(101,2001);
            Coupe coupe3 = new Coupe(102,2005);
            Coupe coupe4 = new Coupe(103,2013);

            coupes.Add(coupe1);
            coupes.Add(coupe2);
            coupes.Add(coupe3);
            coupes.Add(coupe4);

            Match match1 = new Match(10, 100, new DateTime(1997, 07, 10),equipe1, equipe2, 100.50, 50, 23, stadeMich);
            Match match2 = new Match(11, 101, new DateTime(2001, 08, 04), equipe2, equipe1, 20.50, 10, 22, stadeMich);
            Match match3 = new Match(12, 102, new DateTime(2005, 09, 25), equipe1, equipe2, 100.50, 100, 12, stadeMich);
            Match match4 = new Match(13, 103, new DateTime(2013, 10, 02), equipe1, equipe2, 200.50, 30, 31, stadeMich);

            matchs.Add(match1);
            matchs.Add(match2);
            matchs.Add(match3);
            matchs.Add(match4);

        }


        public List<Joueur> Joueurs()
        {
            return joueurs;
        }

        public List<Equipe> Equipes()
        {
            return equipes;
        }

        public List<Stade> Stades()
        {
            return stades;
        }

        public List<Match> Matchs()
        {
            return matchs;
        }

        public List<Coupe> Coupes()
        {
            return coupes;
        }


    }
}
