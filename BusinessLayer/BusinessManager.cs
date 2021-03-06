﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

using EntitiesLayer;

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
        private DataAccessLayer.DalManager data;
        private StubDataAccessLayer.StubDalManager dataStub;

      /*  public Jedi testBDD()
        {
            return data.testBDD();
        }*/


        public BusinessManager()
        {
            data =  DataAccessLayer.DalManager.Instance;
            if (StubDataAccessLayer.StubDalManager.Stub)
            {
                dataStub = new StubDataAccessLayer.StubDalManager();
            }
            else
            {
                dataStub = new StubDataAccessLayer.StubDalManager();
                AjoutTournoiExemple();
            }
           
        }

        public List<Stade> getStades() { return data.getAllStade(); }
        public List<Jedi> getJedis() { return data.getAllJedi(); }
        public List<Match> getMatches() { return data.getAllMatch(); }
        public List<Caracteristique> getCaracteristique() { return data.getAllCaracteristic(); }
        public List<Utilisateur> getUtilisateur() { return data.getAllUtilisateur(); }

        public List<Tournoi> getTournoi() { return dataStub.getAllTournoi(); }


        public void updateStades(List<Stade> stades) { data.updateStade(stades); }
        public void updateJedi(List<Jedi> jedis) { data.updateJedi(jedis); }
        public void updateMatch(List<Match> matches) { data.updateMatch(matches); }
        public void updateCaracteristique(List<Caracteristique> caracteristiques) { data.updateCaracteristique(caracteristiques); }
        public void updateUtilisateur(List<Utilisateur> utilisateurs) { data.updateUtilisateur(utilisateurs); }

        public void updateTournoi(List<Tournoi> tournois) { dataStub.updateTournoi(tournois); }

        public void playTestMatch()
        {
            Match match = data.getAllMatch()[0];
            PlayingMatch pMatch = new PlayingMatch(match);
            int i = 0;

            //Description match
            Console.Out.WriteLine("Match Test on {0}", match.Stade.Planete);
            Console.Out.WriteLine(match.Stade.ToString());

            Console.Out.WriteLine("{0} contre {1}", match.Jedi1.Nom, match.Jedi2.Nom);
            Console.Out.WriteLine(match.Jedi1.ToString());
            Console.Out.WriteLine(match.Jedi2.ToString());

            while (!pMatch.MatchOver)
            {
                // Ici utilisation d'un choix Automatique (aléatoire)
                EDefCaracteristique j1Caract = pMatch.automaticChoose();
                EDefCaracteristique j2Caract = pMatch.automaticChoose();

                pMatch.playTurn(j1Caract, j2Caract);
                Console.Out.WriteLine("--------------------------", i);
                Console.Out.WriteLine("Tour {0}", i);
                Console.Out.WriteLine("{0} utilise : {1}", match.Jedi1.Nom, j1Caract.ToString());
                Console.Out.WriteLine("{0} utilise : {1}", match.Jedi2.Nom, j2Caract.ToString());
                Console.Out.WriteLine("{0} inflige {1} degats a {2}", pMatch.WinnerJedi.Nom, pMatch.DamageInflicted, pMatch.LooserJedi.Nom);
                Console.Out.WriteLine("Point de vie restant a {0} : {1}", match.Jedi1.Nom, pMatch.PJedi1.HpJedi);
                Console.Out.WriteLine("Point de vie restant a {0} : {1}", match.Jedi2.Nom, pMatch.PJedi2.HpJedi);
                i++;
            }
            //Resultat
            Console.Out.WriteLine("Match termine, gagnant : {0}", match.JediVainqueur.ToString());
            Console.Out.WriteLine("({0} = {1}, {2} = {3})", match.Jedi1.Nom, match.Jedi1.Id, match.Jedi2.Nom, match.Jedi2.Id);
        }

        public IEnumerable<String> getStringStades()
        {
            List<Stade> stades = data.getAllStade();
            IEnumerable<string> results = from stade in stades select stade.Planete + "(" + stade.NbPlaces + ")";
            return results;
        }

        public IEnumerable<String> getStringJedis()
        {
            List<Jedi> jedis = data.getAllJedi();
            IEnumerable<string> results = from jedi in jedis select jedi.Nom;
            return results;
        }

        public IEnumerable<String> getStringMatchs()
        {
            List<Match> matches = data.getAllMatch();
            IEnumerable<string> results = from match in matches select match.Jedi1 + " vs " + match.Jedi2 + " in " + match.Stade.Planete;
            return results;
        }

        public IEnumerable<String> getStringCaracteristics()
        {
            List<Caracteristique> caracteristics = data.getAllCaracteristic();
            IEnumerable<string> results = from caracteristic in caracteristics select caracteristic.Nom;
            return results;
        }


        public IEnumerable<String> getStringObscurJedis()
        {
            List<Jedi> jedis = data.getAllJedi();
            IEnumerable<string> results = from jedi in jedis where jedi.IsSith select jedi.Nom;
            return results;
        }

        public IEnumerable<String> getStringJedis(int strengthPts, int lifePts)
        {
            List<Jedi> jedis = data.getAllJedi();
            IEnumerable<string> force = from jedi in jedis where jedi.Caracteristiques.Any(caract => (caract.Definition == EDefCaracteristique.Force && caract.Valeur > 3)) select jedi.Nom;
            IEnumerable<string> sante = from jedi in jedis where jedi.Caracteristiques.Any(caract => (caract.Definition == EDefCaracteristique.Sante && caract.Valeur > 50)) select jedi.Nom;
            IEnumerable<string> results = force.Intersect(sante);
            return results;
        }

        public IEnumerable<string> getStringSithMatchesOver200()
        {
            List<Match> matches = data.getAllMatch();
            IEnumerable<string> places = from match in matches where match.Stade.NbPlaces > 200 select match.Stade.Planete + ' ' + match.Jedi1.Nom + ' ' + match.Jedi2.Nom;
            IEnumerable<string> sith = from match in matches where match.Jedi1.IsSith && match.Jedi2.IsSith select match.Stade.Planete + ' ' + match.Jedi1.Nom + ' ' + match.Jedi2.Nom;
            IEnumerable<string> results = places.Intersect(sith);
            return results.ToList<String>();
        }

        public void ExportXML(Clicked click, String path)
        {
            System.IO.StreamWriter stream;
            XmlSerializer ser;
            switch (click)
            {
                case (Clicked.Jedis):
                    stream = new System.IO.StreamWriter(@path + "\\ListeJedis.txt");
                    ser = new XmlSerializer(typeof(List<Jedi>));
                    ser.Serialize(stream, data.getAllJedi());
                    stream.Close();
                    break;
                case (Clicked.Stades):
                    stream = new System.IO.StreamWriter(@path + "\\ListeStades.txt");
                    ser = new XmlSerializer(typeof(List<Stade>));
                    ser.Serialize(stream, data.getAllStade());
                    stream.Close();
                    break;
                case (Clicked.Matchs):
                    stream = new System.IO.StreamWriter(@path + "\\ListeMatchs.txt");
                    ser = new XmlSerializer(typeof(List<Match>));
                    ser.Serialize(stream, data.getAllMatch());
                    stream.Close();
                    break;
                case (Clicked.Caracteristiques):
                    stream = new System.IO.StreamWriter(@path + "\\ListeCaracteristiques.txt");
                    ser = new XmlSerializer(typeof(List<Caracteristique>));
                    ser.Serialize(stream, data.getAllCaracteristic());
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
//#if DEBUG
//                return true;
//#endif
                Utilisateur u = data.getUtilisateurByLogin(login);
                result = (u.Password
                    == EntitiesLayer.HashSH1.GetSHA1HashData(password));
                Console.WriteLine(u.Login + " "+u.Password + " " + EntitiesLayer.HashSH1.GetSHA1HashData(password));
            }
            catch (NullReferenceException)
            {
                result = false;
            }
            return result;
        }

        public Tournoi playTournoi(Tournoi tournoi)
        {
            foreach (Match match in tournoi.Matches)
            {
                PlayingMatch pMatch = new PlayingMatch(match);
                while (!pMatch.MatchOver)
                {
                    pMatch.playTurn(pMatch.automaticChoose(), pMatch.automaticChoose());
                }
            }
            return tournoi.nextPool();
        }

        public void AjoutTournoiExemple()
        {
            List<Jedi> jedis = getJedis();
            List<Jedi> jedis_to_pool = new List<Jedi>();
            List<Stade> stades = getStades();
            Random rand = new Random();


            for (int i = 0; i <= 15; i++)
            {
                int index = rand.Next() % jedis.Count;
                jedis_to_pool.Add(jedis[index]);
                jedis.Remove(jedis[index]);
            }
            Tournoi tournoi = new Tournoi(jedis_to_pool, stades);
            tournoi.Nom = "Tournoi de Test";

            List<Tournoi> tournois = getTournoi();
            tournois.Add(tournoi);
            updateTournoi(tournois);
        }
    }

}
