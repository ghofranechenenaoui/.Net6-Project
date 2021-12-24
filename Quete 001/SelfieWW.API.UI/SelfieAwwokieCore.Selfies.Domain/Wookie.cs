using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SelfieAwwokieCore.Selfies.Domain
{
    public class Wookie
    {
        #region properties
        public int Id { get; set; }
        // [JsonIgnore]
        public List<Selfie> Selfies { get; set; }
        #endregion
    }
}
