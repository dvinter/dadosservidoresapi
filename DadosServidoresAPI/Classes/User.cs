using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DadosServidoresAPI.Classes

{
    public class User
    {
        public string Username { get; set; }

        [JsonIgnore]
        public string Password { get; set; }
    }
}