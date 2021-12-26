using SelfieWookie.Core.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAwwokieCore.Selfies.Domain
{
    public interface ISelfieRepository : IRepository
    {
      public  ICollection<Selfie> GetAll();
    }
}
