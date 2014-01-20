using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public enum poste {
        none, poursuiveur, batteur, gardien, attrapeur
    }
    public class Joueur : Personne
    {
        private int _score;
        private int _nbSelection;
        poste _poste;

        public int Score
        {
            set
            {
                _score = value;
            }

            get
            {
                return _score;
            }
        }

        public int NbSelection
        {
            set
            {
                _nbSelection = value;
            }

            get
            {
                return _nbSelection;
            }
        }

        public poste Poste
        {
            set
            {
                _poste = value;
            }

            get
            {
                return _poste;
            }
        }

        public Joueur(int id, string nom, string prenom, DateTime dateNaissance, int score, int nbSelection, poste p):base(id, nom, prenom, dateNaissance)
        { 
            _score = score;
            _nbSelection = nbSelection;
            _poste = p;
        }

    }
}
