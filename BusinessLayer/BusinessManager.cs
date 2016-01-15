﻿using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
 

namespace BusinessLayer
{
    public enum Clicked
    {
        Jedis,
        Stades,
        Matchs,
        Caracteristiques,
        Bonus,
        Null
    };
    public class BusinessManager
    {
        private StubDataAccessLayer.DalManager Data;

        public BusinessManager()
        {
            Data = new StubDataAccessLayer.DalManager();
        }

        public IEnumerable<String> getStades()
        {
            List<Stade> stades = Data.getAllStade();
            IEnumerable<string> results = from stade in stades select stade.Planete + "(" + stade.NbPlaces + ")";
            return results;
        }

        public IEnumerable<String> getJedis()
        {
            List<Jedi> jedis = Data.getAllJedi();
            IEnumerable<string> results = from jedi in jedis select jedi.Nom;
            return results;
        }

        public IEnumerable<String> getMatchs()
        {
            List<Match> matches = Data.getAllMatch();
            IEnumerable<string> results = from match in matches select match.Jedi1+" vs "+ match.Jedi2+" in "+match.Stade.Planete;
            return results;
        }

        public IEnumerable<String> getCaracteristics()
        {
            List<Caracteristique> caracteristics = Data.getAllCaracteristic();
            IEnumerable<string> results = from caracteristic in caracteristics select caracteristic.Nom;
            return results;
        }


        public IEnumerable<String> getObscurJedis()
        {
            List<Jedi> jedis = Data.getAllJedi();
            IEnumerable<string> results = from jedi in jedis where jedi.IsSith select jedi.Nom;
            return results;
                }

        public IEnumerable<String> getJedis(int strengthPts, int lifePts)
        {
            List<Jedi> jedis = Data.getAllJedi();
            IEnumerable<string> force = from jedi in jedis where jedi.Caracteristiques.Any(caract => (caract.Definition == EDefCaracteristique.Force && caract.Valeur > 3)) select jedi.Nom;
            IEnumerable<string> sante = from jedi in jedis where jedi.Caracteristiques.Any(caract => (caract.Definition == EDefCaracteristique.Sante && caract.Valeur > 50)) select jedi.Nom;
            IEnumerable<string> results = force.Intersect(sante);
            return results;
        }

        public IEnumerable<string> getSithMatchesOver200()
        {
            List<Match> matches = Data.getAllMatch();
            IEnumerable<string> places = from match in matches where match.Stade.NbPlaces > 200 select match.Stade.Planete + ' ' + match.Jedi1.Nom + ' ' + match.Jedi2.Nom;
            IEnumerable<string> sith = from match in matches where match.Jedi1.IsSith && match.Jedi2.IsSith select match.Stade.Planete + ' ' + match.Jedi1.Nom + ' ' + match.Jedi2.Nom;
            IEnumerable<string> results = places.Intersect(sith);
            return results.ToList<String>();
        }

        public void ExportXML(Clicked click)
        {
            System.IO.StreamWriter stream;
            XmlSerializer ser;
            switch(click)
            {
                case (Clicked.Jedis):
                    stream = new System.IO.StreamWriter(@"C:\Users\garaux\Desktop\ListeJedis.txt");
                    ser = new XmlSerializer(typeof(List<Jedi>));
                    ser.Serialize(stream, Data.getAllJedi());
                    stream.Close();
                    break;
                case (Clicked.Stades):
                    stream = new System.IO.StreamWriter(@"C:\Users\garaux\Desktop\ListeStades.txt");
                    ser = new XmlSerializer(typeof(List<Stade>));
                    ser.Serialize(stream, Data.getAllStade());
                    stream.Close();
                    break;
                case (Clicked.Matchs):
                    stream = new System.IO.StreamWriter(@"C:\Users\garaux\Desktop\ListeMatchs.txt");
                    ser = new XmlSerializer(typeof(List<Match>));
                    ser.Serialize(stream, Data.getAllMatch());
                    stream.Close();
                    break;
                case (Clicked.Caracteristiques):
                    stream = new System.IO.StreamWriter(@"C:\Users\garaux\Desktop\ListeCaracteristiques.txt");
                    ser = new XmlSerializer(typeof(List<Caracteristique>));
                    ser.Serialize(stream, Data.getAllCaracteristic());
                    stream.Close();
                    break;
                default:
                    break;
            }
        }

        public bool CheckConnexionUser(string login, string password)
        {
            bool result;
            try
            {
                Utilisateur u = Data.getUtilisateurByLogin(login);
                result = (u.Password == password);
            }
            catch (NullReferenceException)
            {
                result = false;
            }
            return result;
        }
    }

}
