using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Stade : EntityObject
    {
        private string _nom;
        private string _adresse;
        private int _nbPlaces;
        private double _pourcentageCommission;

        public Stade(int id, string nom, string adresse, int nbPlaces, double pourcentageCommission) : base(id)
        {
            _nom = nom;
            _adresse = adresse;
            _nbPlaces = nbPlaces;
            _pourcentageCommission = pourcentageCommission;
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }
        

        public int NbPlaces
        {
            get { return _nbPlaces; }
            set { _nbPlaces = value; }
        }
        

        public double PourcentageCommission
        {
            get { return _pourcentageCommission; }
            set { _pourcentageCommission = value; }
        }
    }
}
