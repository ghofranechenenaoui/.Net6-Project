using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAwwokieCore.Selfies.Domain
{
    public  class Picture
    {
        public int Id { get; set; }
        public string url { get; set; }

        public List<Selfie> selfies { get; set; }
    }
}
