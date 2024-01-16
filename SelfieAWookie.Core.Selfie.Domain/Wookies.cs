using SSelfieAWookie.Core.Selfie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Selfie.Domain
{
    public class Wookies
    {
        public int Id { get; set; }
        [JsonIgnore]
        public List<Selfies> Selfies { get; set; }
    }
}
