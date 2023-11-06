
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WpfAppMapTask.Models
{
    public class Bus
    {

        [JsonProperty("@attributes")]
        public Atribut @attributes;


    }
}
