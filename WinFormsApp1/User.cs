using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
   public class User
    {

        [JsonProperty("id")]
        public int id { get; set; }


        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("username")]
        public string username { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        public Address address { get; set; }
       

        [JsonProperty("phone")]
        public string phone { get; set; }

        [JsonProperty("website")]
        public string website { get; set; }

        [JsonProperty("company")]
        public Company Company { get; set; }
    }
    public class Company
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("catchPhrase")]
        public string catchPhrase { get; set; }

        [JsonProperty("bs")]
        public string bs { get; set; }
    }
    public class Address
    {
        [JsonProperty("street")]
        public string street { get; set; }

        [JsonProperty("suite")]
        public string suite;

        [JsonProperty("city")]
        public string city;

        [JsonProperty("zipcode")]
        public string zipcode;

        [JsonProperty("geo")]
        public Geo Geo { get; set; }

    }
    public class Geo
    {
        [JsonProperty("lat")]
        public string lat;

        [JsonProperty("lng")]
        public string lng;
    }

}
