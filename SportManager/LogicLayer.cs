using System;
using System.Collections.Generic;
using System.Text;
using SportManager.Model;

namespace SportManager
{
    class LogicLayer : ILogic
    {

        public IPersistence MyPersitence { get; set; }

        public LogicLayer(IPersistence persistence)
        {
            //MyPersitence = new PersistenceLayer();
            MyPersitence = persistence;
        }
        public List<Athlete> getAllAthletes()
        {
            List<Athlete> athleteList = MyPersitence.AllAthlete; //AllAthlete esiste in PersistenceLayer
            return athleteList;
        }

        public void insertAthlete(Athlete athlete)
        {
            Console.WriteLine(athlete);
        }

        public Athlete searchAthlete(string name)
        {
            throw new NotImplementedException();
        }
    }
}
