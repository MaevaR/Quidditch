using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Equipe : EntityObject
    {
        private string _nom;
        private string _pays;
        private List<Joueur> _joueurs;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Pays
        {
            get { return _pays; }
            set { _pays = value; }
        }

        public List<Joueur> Joueurs
        {
            get { return _joueurs; }
            set { _joueurs = value; }
        }

        public void AjouterJoueur(Joueur j)
        {
            _joueurs.Add(j);
        }

        public Equipe(int id, string nom, string pays, List<Joueur> joueurs): base(id)
        {
            _nom = nom;
            _pays = pays;
            _joueurs = joueurs;
        }

        public Equipe(int id, string nom, string pays): base(id)
        {
            _nom = nom;
            _pays = pays;
            _joueurs = new List<Joueur>();
        }

    }
}
