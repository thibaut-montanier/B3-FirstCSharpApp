using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAppCSharp {
    class Personne {

        public string Nom { get;  set; }
        public string Prenom { get; set; }

        

        public int CreerMessage() {
            return 0;// "Je m'appelle " + Prenom + " " + Nom;
        }
        
    }
}
