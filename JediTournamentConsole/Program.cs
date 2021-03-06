﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;
using BusinessLayer;

namespace JediTournamentConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessManager businessManager = new BusinessManager();
            int input;
            bool end = false;
            IEnumerable<string> res;

            List<Jedi> jedis = businessManager.getJedis();

            while (!end)
            {
                Console.Out.WriteLine("Menu");
                Console.Out.WriteLine("1 - All matches");
                Console.Out.WriteLine("2 - All stades");
                Console.Out.WriteLine("3 - All siths");
                Console.Out.WriteLine("4 - Jedi 3 F 50 HP");
                Console.Out.WriteLine("5 - Match 200 places siths");
                Console.Out.WriteLine("6 - Play !");
                Console.Out.WriteLine("7 - Bet !");
                Console.Out.WriteLine("8 - Exit");
                input = int.Parse(Console.In.ReadLine());
                switch (input)
                {
                    case 1:
                        List<Match> matches = businessManager.getMatches();
                        foreach (Match match in matches)
                        {
                            Console.Out.Write(match.ToString());
                        }
                        break;
                    case 2:
                        res = businessManager.getStringStades();
                        foreach (String el in res)
                        {
                            Console.Out.WriteLine(el);
                        }
                        break;
                    case 3:
                        res = businessManager.getStringObscurJedis();       //Ce sont des Sith pas des jedis obscurs !!
                        foreach (String el in res)
                        {
                            Console.Out.WriteLine(el);
                        }
                        break;
                    case 4:
                        res = businessManager.getStringJedis(3, 50);
                        foreach (String el in res)
                        {
                            Console.Out.WriteLine(el);
                        }
                        break;
                    case 5:
                        res = businessManager.getStringSithMatchesOver200();
                        foreach (String el in res)
                        {
                            Console.Out.WriteLine(el);
                        }
                        break;

                    case 6:
                        Jedi choosenJedi  = null;
                        PlayingManager pm = new PlayingManager(businessManager);
                        while (choosenJedi == null)
                        {
                            Console.Out.WriteLine("Choose your jedi ! (put id) ");
                            foreach (Jedi jedi in jedis)
                            {
                                Console.Out.WriteLine(jedi.Id + "\t: " + jedi.Nom);
                            }
                            int choixJedi = int.Parse(Console.In.ReadLine());

                            choosenJedi = jedis.Find(x => x.Id == choixJedi);
                        }

                        pm.LancerMatch(choosenJedi,8);

                        while (pm.End != true)
                        {
                            bool cont = false;
                            while(!cont){
                                cont = true;
                                pm.title();
                                Console.Out.WriteLine("Choose your attack :");
                                Console.Out.WriteLine("\t1 - Force");
                                Console.Out.WriteLine("\t2 - Chance");
                                Console.Out.WriteLine("\t3 - Defense !");
                                int choixAttack = int.Parse(Console.In.ReadLine());

                                switch (choixAttack)
                                {
                                    case 1:
                                        pm.utiliserForce();
                                        break;
                                    case 2:
                                        pm.utiliserChance();
                                        break;
                                    case 3:
                                        pm.utiliserDefense();
                                        break;
                                    default:
                                        cont = false;
                                        break;
                                }
                            }
                            Console.Out.WriteLine(pm.StatLastTurn);
                        }
                        if (pm.Win)
                        {
                            Console.Out.WriteLine("Vous avez gagne !");
                        }
                        else
                        {
                            Console.Out.WriteLine("Vous avez perdu !");
                        }
                        break;
                    case 7:
                        BettingManager bettingManager = new BettingManager(businessManager,2);
                        
                        Console.Out.WriteLine("List Jedi :");
                        foreach (Match match in bettingManager.Pool.Matches)
                        {
                            Console.Out.WriteLine(match.Jedi1.Id + "\t: " + match.Jedi1.Nom);
                            Console.Out.WriteLine(match.Jedi2.Id + "\t: " + match.Jedi2.Nom);
                        }
                        while (!bettingManager.End)
                        {
                            int choixJedi1;
                            int bet1;
                            Jedi choosenJediBet1=null;

                            int choixJedi2;
                            int bet2;
                            Jedi choosenJediBet2=null;


                            while (choosenJediBet1 == null)
                            {
                                Console.Out.WriteLine("Player 1 your jedi ! (put id) ");
                                choixJedi1 = int.Parse(Console.In.ReadLine());
                                choosenJediBet1 = jedis.Find(x => x.Id == choixJedi1);
                            }
                            Console.Out.WriteLine("Player 1 choose your bet : ");
                            bet1 = int.Parse(Console.In.ReadLine());

                            while (choosenJediBet1 == null)
                            {
                                Console.Out.WriteLine("Player 2 your jedi ! (put id) ");
                                choixJedi2 = int.Parse(Console.In.ReadLine());
                                choosenJediBet2 = jedis.Find(x => x.Id == choixJedi2);
                            }
                            Console.Out.WriteLine("Player 2 choose your bet : ");
                            bet2 = int.Parse(Console.In.ReadLine());

                            bettingManager.lancerPhaseTournoi(new List<int> { bet1, bet2 }, new List<Jedi> { choosenJediBet1, choosenJediBet2 });
                            Console.Out.WriteLine(bettingManager.toString());

                        }
                        break;

                    case 8:
                        end = true;
                        break;
                    default:
                        Console.Out.WriteLine("Bad input");
                        break;
                }
            }
        }
    }
}
