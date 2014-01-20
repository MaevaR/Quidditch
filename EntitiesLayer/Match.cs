using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Match : EntityObject
    {
        private int _coupeID;
        private DateTime _date;
        private Equipe _equipeDomicile;
        private Equipe _equipeVisiteur;
        private double _prix;
        private int _scoreEquipeDomicile;
        private int _scoreEquipeVisiteur;
        private Stade _stade;

        public Match(int id, int coupeID, DateTime date, Equipe equipeDomicile, Equipe equipeVisiteur,
            double prix, int scoreEquipeDomicile, int scoreEquipeVisiteur, Stade stade) : base(id)
        {
            _coupeID = coupeID;
            _date = date;
            _equipeDomicile = equipeDomicile;
            _equipeVisiteur = equipeVisiteur;
            _prix = prix;
            _scoreEquipeDomicile = scoreEquipeDomicile;
            _scoreEquipeVisiteur = scoreEquipeVisiteur;
            _stade = stade;
        }

        public int CoupeID
        {
            get { return _coupeID; }
            set { _coupeID = value; }
        }
        

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        

        public Equipe EquipeDomicile //internal ?
        {
            get { return _equipeDomicile; }
            set { _equipeDomicile = value; }
        }
        

        public Equipe EquipeVisiteur //internal ?
        {
            get { return _equipeVisiteur; }
            set { _equipeVisiteur = value; }
        }
        

        public double Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }
        

        public int ScoreEquipeDomicile
        {
            get { return _scoreEquipeDomicile; }
            set { _scoreEquipeDomicile = value; }
        }
        

        public int ScoreEquipeVisiteur
        {
            get { return _scoreEquipeVisiteur; }
            set { _scoreEquipeVisiteur = value; }
        }
        

        public Stade Stade //internal ?
        {
            get { return _stade; }
            set { _stade = value; }
        }

       
    }
}
