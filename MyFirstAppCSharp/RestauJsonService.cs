using MyFirstAppCSharp.Data.ModelRestau;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyFirstAppCSharp {
   public  class RestauJsonService {

        public List<Restaurant> loadFromFile(string fileName) {
            using (var sr = new StreamReader(fileName)) {
                return JsonConvert.DeserializeObject<List<Restaurant>>(sr.ReadToEnd());
            }
                

        }
    }
}
