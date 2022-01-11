using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAwwokieCore.Selfies.Domain
{
    public class Selfie
    {
        #region Properties
        public int Id { get; set; }
        public string? Title { get; set; }
        public string?  ImagePath { get; set; }

        public int WookieId { get; set; }    
        public Wookie? Wookie { get; set; }

<<<<<<< HEAD
        public int PictureId { get; set; }
        public Picture? Picture { get; set; }


=======
>>>>>>> 18e673c52cbd52ed9b9e7b8015efe1f234fbb2f9
        #endregion


    }
}
