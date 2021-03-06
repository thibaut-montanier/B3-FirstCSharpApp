﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstAppCSharp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Comment tu t'appelles ?");

            var mesEntiers = new List<int> { 1, 4, 6, 0, 9, 12, 24, 30, 36, 72, 5, 102 };
            var t = 5;
            if (t % 2 == 0) {
                Console.WriteLine("t est pair");
            } else {
                Console.WriteLine("t est impair");
            }
            // affichage uniquement des nombres pairs.*
            var entSrv = new EntiersService();

            var resultTemp1 = mesEntiers.FilterByDivisible(2)
                                        .FilterByDivisible(3)
                                        .FilterByDivisible(5)
                                        .FilterByPositive();


            var resultTemp2 = mesEntiers.Where(v => v % 2 == 0)
                                        .Where(v => v % 3 == 0)
                                        .Where(v => v % 5 == 0)
                                        .Where(v => v > 0);

            foreach (var i in resultTemp1.Take(2)) {
                Console.WriteLine("Mon entier pair est " + i);
            }

            // Filtrer les données sur les critères suivants : 
            // Toutes les femmes / tous les hommes
            // Tous les majeurs
            // Toutes les personnes dont le nom commence par "P"
            // Toutes les personnes dont le nom est exactement Pierre
            // Toutes les personnes dont le nom contient un f
            Person p1 = new Person() { Nom = "Pierre", Age = 16 };
            Person p2 = new Person() { Nom = "Jean", Age = 16 };
            List<Person> mesPers = new List<Person> {
                p1,
                p2,
                new Person() { Nom = "Sohpie", Age = 20},
                new Person() { Nom = "ANais", Age = 30},
                new Person() { Nom = "Paul", Age = 5},
                new Person() { Nom = "Fabrice", Age = 45},
                new Person() { Nom = "Julie", Age = 17 }
            };

            Car c1 = new Car() { Annee = 1999, Model = "Clio" };
            Car c2 = new Car() { Annee = 1999, Model = "206" };
            Car c3 = new Car() { Annee = 1985, Model = "R5" };


            p1.Cars.Add(c1);
            p1.Cars.Add(c2);
            p2.Cars.Add(c1);


            string result = JsonConvert.SerializeObject(mesPers);



        }
    }

    public class PersonFormulaireVM {

        public string FirstName { get; set; }
    }

}

