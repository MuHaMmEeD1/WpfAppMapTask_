using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMapTask.Models
{
    public class Atribut
    {

        [JsonProperty("BUS_ID")]
        public string BUSID { get; set; }

        [JsonProperty("PLATE")]
        public string PLATE { get; set; }

        [JsonProperty("DRIVER_NAME")]
        public string DRIVERNAME { get; set; }

        [JsonProperty("PREV_STOP")]
        public string PREVSTOP;

        [JsonProperty("CURRENT_STOP")]
        public string CURRENTSTOP;

        [JsonProperty("SPEED")]
        public string SPEED;

        [JsonProperty("BUS_MODEL")]
        public string BUSMODEL;

        [JsonProperty("LATITUDE")]
        public string LATITUDE;

        [JsonProperty("LONGITUDE")]
        public string LONGITUDE;

        [JsonProperty("ROUTE_NAME")]
        public string ROUTENAME;

        [JsonProperty("LAST_UPDATE_TIME")]
        public int LASTUPDATETIME;

        [JsonProperty("DISPLAY_ROUTE_CODE")]
        public string DISPLAYROUTECODE;


    }
}
