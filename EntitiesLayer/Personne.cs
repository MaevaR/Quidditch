using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public abstract class Personne : EntityObject
    {
        protected string _nom;
        protected string _prenom;
        protected DateTime _dateNaissance;

        public string Nom
        {
            set
            {
                _nom = value;
            }

            get
            {
                return _nom;
            }
        }

        public string Prenom
        {
            set
            {
                _prenom = value;
            }

            get
            {
                return _prenom;
            }
        }

        public DateTime DateNaissance
        {
            set
            {
                _dateNaissance = value;
            }

            get
            {
                return _dateNaissance;
            }
        }

        public Personne(int id, string nom, string prenom, DateTime dateNaissance) : base(id)
        {
            _nom = nom;
            _prenom = prenom;
            _dateNaissance = dateNaissance;
        }
        
    }
}
