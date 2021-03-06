﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;

namespace StubDataAccessLayer
{
    public class StubDalManager
    {
        static bool stub = false;
        public static bool Stub { get { return stub; } }

        static private List<Jedi> allJedi;
        static private List<Match> allMatch;
        static private List<Stade> allStade;
        static private List<Tournoi> allTournoi;
        static private List<Caracteristique> allCharacteristics;
        static private SortedDictionary<string, Utilisateur> allUtilisateurs;

        // Ajout de donnees factices
        private void stuber()
        {
            // Ajout de Caracteristiques
            allCharacteristics = new List<Caracteristique>();
            allCharacteristics.Add(new Caracteristique(1, EDefCaracteristique.Chance, "Utilisation de la force", ETypeCaracteristique.Jedi, 18));
            allCharacteristics.Add(new Caracteristique(1, EDefCaracteristique.Defense, "Agilite", ETypeCaracteristique.Jedi, 5));
            allCharacteristics.Add(new Caracteristique(1, EDefCaracteristique.Sante, "Armure", ETypeCaracteristique.Jedi, 100));
            allCharacteristics.Add(new Caracteristique(1, EDefCaracteristique.Force, "Badassitude", ETypeCaracteristique.Jedi, 7));
            allCharacteristics.Add(new Caracteristique(5, EDefCaracteristique.Force, "Lave", ETypeCaracteristique.Stade, 12));

            // Ajout de Jedis
            allJedi = new List<Jedi>();
            List<Caracteristique> lc = new List<Caracteristique>();
            lc.Add(new Caracteristique(1, EDefCaracteristique.Force, "Force", ETypeCaracteristique.Jedi, 90));
            lc.Add(new Caracteristique(4, EDefCaracteristique.Sante, "Santé", ETypeCaracteristique.Jedi, 90));
            allJedi.Add(new Jedi(0, "Luke", false, lc));

            lc = new List<Caracteristique>();
            lc.Add(new Caracteristique(2, EDefCaracteristique.Force, "Force", ETypeCaracteristique.Jedi, 95));
            lc.Add(new Caracteristique(3, EDefCaracteristique.Sante, "Santé", ETypeCaracteristique.Jedi, 85));
            allJedi.Add(new Jedi(1, "Anakin", true, lc));

            List<Caracteristique> CaractBenjamen = getAllCaracteristic();
            allJedi.Add(new Jedi(2, "Benjamin",  true,  CaractBenjamen));

            List<Caracteristique> CaractCat = getAllCaracteristic().Where(c => c.Id == 1).ToList();
            allJedi.Add(new Jedi(3, "Cataracte", true, CaractCat));
            
            // Ajout de Stades
            allStade = new List<Stade>();
            List<Caracteristique> caractStade = getAllCaracteristic().Where(c => c.Id == 5).ToList();
            allStade.Add(new Stade(1, 300, "Jakku", caractStade));

            // Ajout de Matchs
            allMatch = new List<Match>();
            allMatch.Add(new Match(1, allJedi[0], allJedi[2], EPhaseTournoi.DemiFinale, allStade[0]));
            allMatch.Add(new Match(2, allJedi[1], allJedi[3], EPhaseTournoi.DemiFinale, allStade[0]));

            // Ajout d'Utilisateur
            allUtilisateurs = new SortedDictionary<string, Utilisateur>();
            allUtilisateurs["pierre-loup"] = new Utilisateur(1,"Pissavy", "Pierre-Loup", "pierre-loup", HashSH1.GetSHA1HashData("totoestbete"));
            allUtilisateurs["anne-lise"] = new Utilisateur(2,"Michel", "Anne-Lise", "anne-lise", HashSH1.GetSHA1HashData("moustache"));
            allUtilisateurs["pierre"] = new Utilisateur(3,"Chevalier", "Pierre", "pierre", HashSH1.GetSHA1HashData("jveuxdire"));
            allUtilisateurs["gael"] = new Utilisateur(4,"Raux", "Gaël", "gael", HashSH1.GetSHA1HashData("brest"));
            
            allUtilisateurs["begarco"] = new Utilisateur(5,"Garcon", "Benoit", "begarco", HashSH1.GetSHA1HashData("suce")); // l'intru

            // Ajout d'un tournoi
            allTournoi = new List<Tournoi>();
        }

        public StubDalManager()
        {
            if (!stub)
            {
                stuber();
                stub = true;
            }
        }

        public List<Jedi> getAllJedi()
        {    
            return allJedi;
        }

        public List<Match> getAllMatch()
        {
            
            return allMatch;
        }

        public List<Stade> getAllStade()
        {
            
            return allStade;
        }

        public List<Tournoi> getAllTournoi()
        {

            return allTournoi;
        }

        public List<Caracteristique> getAllCaracteristic()
        {
            return allCharacteristics;
        }


        public Utilisateur getUtilisateurByLogin(string login) {
            try
            {
                return allUtilisateurs[login];
            }
            catch (KeyNotFoundException)
            {
                return null;
            }

        }

        public List<Utilisateur> getAllUtilisateur()
        {
            List<Utilisateur> list = new List<Utilisateur>();
            foreach(Utilisateur ut in allUtilisateurs.Values)
            {
                list.Add(ut);
            }
            return list;
        }

        public void updateJedi(List<Jedi> jedis)
        {
            allJedi = jedis;
        }
        public void updateMatch(List<Match> matches)
        {
            allMatch = matches;
        }
        public void updateStade(List<Stade> stades)
        {
            allStade = stades;
        }
        public void updateTournoi(List<Tournoi> tournois)
        {
            allTournoi = tournois;
        }
        public void updateCaracteristique(List<Caracteristique> caracteristiques)
        {
            allCharacteristics = caracteristiques;
        }
        public void updateUtilisateur(List<Utilisateur> utilisateurs)
        {
            SortedDictionary<string, Utilisateur> dic = new SortedDictionary<string, Utilisateur>();
            foreach (Utilisateur ut in utilisateurs)
            {
                dic.Add(ut.Login, ut);
            }
           allUtilisateurs = dic;
        }
    }
}
