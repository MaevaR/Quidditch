using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Spectateur : Personne
    {
        private string _adresse;
        private string _mail;

        public string Adresse
        {
            set
            {
                _adresse = value;
            }

            get
            {
                return _adresse;
            }
        }

        public string Mail
        {
            set
            {
                _mail= value;
            }

            get
            {
                return _mail;
            }
        }

        public Spectateur(int id, string nom, string prenom, DateTime dateNaissance, string adresse, string mail) :base(id, nom, prenom, dateNaissance)
        {
            _adresse = adresse;
            _mail = mail;
        }
    }
}
