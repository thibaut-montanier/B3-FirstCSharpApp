
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAppCSharp {
    public class Person {
        public int ID { get; set; }

        private string _Nom;
        public string Nom {
            get {
                return _Nom;
            }
            set {
                _Nom = value;
            }
        }

        public string LastName { get; set; }
        public int Age { get; set; }

        public List<Car> Cars { get; set; } = new List<Car>();
        public SexEnum Sex { get; set; }
        public enum SexEnum {
            Male,
            Female
        }
    }

    public class Student : Person {

    }

    public class Car {
        public string Model { get; set; }

        public int Annee { get; set; }

        [Newtonsoft.Json.JsonIgnore()]
        public Person Owner { get; set; }
    }
    
}
