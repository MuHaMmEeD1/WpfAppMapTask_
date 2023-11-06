using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMapTask.Models
{
    public class BBus
    {
        [JsonProperty("BUS")]
        public List<Bus> BUS { get; set; }


 
    }
}
