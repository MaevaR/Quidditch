using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchWPF
{
    class Pilotage  
    {
        
        private double _largeur, _hauteur;
        private  double _abscisse, _ordonnee;

        public Pilotage()
        {
            _largeur=0;
            _hauteur=0;
            _abscisse=0;
            _ordonnee=0;
        }
        
         public double Largeur
        {
            set
            {
                _largeur = value;
            }

            get
            {
                return _largeur;
            }
        }

         public double Hauteur
         {
             set
             {
                 _hauteur = value;
             }

             get
             {
                 return _hauteur;
             }
         }

         public double Abscisse
         {
             set
             {
                 _abscisse = value;
             }

             get
             {
                 return _abscisse;
             }
         }

         public double Ordonnee
         {
             set
             {
                 _ordonnee = value;
             }

             get
             {
                 return _ordonnee;
             }
         }


    }
}
