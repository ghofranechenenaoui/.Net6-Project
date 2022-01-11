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
<<<<<<< HEAD
        public ICollection<Selfie> GetAll();
        public ICollection<Selfie> GetAll2(int wookieId);

        //Add one selfie in data base
        public Selfie AddOne(Selfie a);

        public Picture AddOnePicture(string url);
=======
      public  ICollection<Selfie> GetAll();
>>>>>>> 18e673c52cbd52ed9b9e7b8015efe1f234fbb2f9
    }
}
