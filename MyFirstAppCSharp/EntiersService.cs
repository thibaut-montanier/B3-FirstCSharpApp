using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstAppCSharp {


    public class EntiersService {
        // 1. Créer une fonction qui indique si un entier est pair et l'utiliser dans Main

        public bool isEven(int v) {
            return v % 2 == 0;
        }

        public int Add(int v1, int v2) {
            return v1 + v2;
        }
        // 2. Créer une fonction qui prend en paramètre une liste d'entiers et qui ne retourne
        // que les nombres pairs
        public IEnumerable<int> filterEvenNumber(List<int> values) {
            return values.Where(v => isEven(v));
        }

        public bool isDivisible(int value, int divisor) {
            return value % divisor == 0;
        }


        public IEnumerable<int> filtre(IEnumerable<int> values, Func<int, bool> monFiltre) {
            foreach(int i in values) {
                if (monFiltre(i)) {
                    yield return i;
                }
            }
        }


        public IEnumerable<int> FilterByDivisible(IEnumerable<int> values, int divisor) {
            return values.Where((v) => {
                Console.WriteLine("Evaluation de " + v + " / " + divisor + ", resultat = " + isDivisible(v, divisor));
                return isDivisible(v, divisor);
            });
        }



        
        public IEnumerable<int> DonneLes10PremiersEntiers() {
            var maList = new List<int> { 1, 2, 3, 4, 5 };
            foreach(var x in maList) {
                yield return x;
            }
            
        }

        //public IEnumerable<int> maFonctionAvecPlusieursArguments(List<int> values, params int[] parametres) {
        //    return null;
        //}
    }
}
