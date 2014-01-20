using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Reservation : EntityObject
    {
        private int _nombrePlacesReservees;
        private int _codeAnnulation;
        private Spectateur _spectateur;
        private Match _match;

       public int NombrePlacesReservees
        {
          get { return _nombrePlacesReservees; }
          set { _nombrePlacesReservees = value; }
        }

        public int CodeAnnulation
        {
            get { return _codeAnnulation; }
            set { _codeAnnulation = value; }
        }

        public Match Match
        {
            get { return _match; }
            set { _match = value; }
        }

        public Reservation(int id, int nombrePlacesReservees, int codeAnnulation, Spectateur spectateur, Match match) :base(id)
        {
            _nombrePlacesReservees = nombrePlacesReservees;
            _codeAnnulation = codeAnnulation;
            _spectateur = spectateur;
            _match = match;
        }
    }
}
