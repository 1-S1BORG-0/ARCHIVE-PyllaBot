using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PyllaBot
{
    public class Configuration
    {   
        [JsonProperty]
        public string[] prefixes;
        [JsonProperty]
        public string token;
        [JsonProperty]
        public PyllaSave pylla = new();
        
    }
}
