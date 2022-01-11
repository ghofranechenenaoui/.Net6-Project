using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SelfieAwwokieCore.Selfies.Domain;
using SelfieAwwokieCore.Selfies.Infrastructure.Data;
using SelfieWW.API.UI.Application.DTOs;

namespace SelfieWW.API.UI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SelfieController : ControllerBase
<<<<<<< HEAD
    {
        #region Fields 
        private readonly ISelfieRepository _repository = null;
        private readonly IWebHostEnvironment _webHostEnvironment = null;

=======
        {
        #region Fields 
        private readonly ISelfieRepository _repository = null; 
>>>>>>> 18e673c52cbd52ed9b9e7b8015efe1f234fbb2f9
        #endregion

        #region Constructeur

<<<<<<< HEAD
        public SelfieController(ISelfieRepository repository, IWebHostEnvironment webHostEnvironment)
        {

            this._repository = repository;
            this._webHostEnvironment = webHostEnvironment;
=======
        public SelfieController (ISelfieRepository repository)
        {
             this._repository = repository;
>>>>>>> 18e673c52cbd52ed9b9e7b8015efe1f234fbb2f9

        }
        #endregion


        //    #region public methods
        //    [HttpGet]
        //    public IEnumerable<Selfie> TestAMoi()
        //    {
        //        return Enumerable.Range(1, 10).Select(item => new Selfie() { Id = item });
        //    }

        //    #endregion

        #region public methods
<<<<<<< HEAD
        [HttpGet("GetAll")]

        //The ActionResult types represent various HTTP status codes.
        public IActionResult GetAll()
        {
            // var model=  Enumerable.Range(1, 10).Select(item => new Selfie() { Id = item });
            // return this.StatusCode(StatusCodes.Status204NoContent);
            //var model = this._context.Selfies.ToList();
            // var query = from Wookie in this._context.Selfies select Wookie;
            // with this we can not show the wookie so another solution
            // var model = this._context.Selfies.Include(item => item.Wookie).Select(item => new {Title = item.Title , WookieId = item.Wookie.Id , NbSelfieFromOneWookie = item.Wookie.Selfies.Count() }).ToList();
            // include les information sur les wookies 
            var selfieList = this._repository.GetAll();
            var model = selfieList.Select(item => new SelfieResumeDto() { Title = item.Title, WookieId = item.Wookie.Id, NbrSelfiesFromWooki = (item.Wookie?.Selfies?.Count()).GetValueOrDefault(0) }).ToList();
            return this.Ok(model);
        }

        [HttpGet]
        public IActionResult GetAll2([FromQuery] int wookieId = 0)
        {

            var param = this.Request.Query["wookieId"];
            var selfieList = this._repository.GetAll2(wookieId);
            var model = selfieList.Select(item => new SelfieResumeDto() { Title = item.Title, WookieId = item.Wookie.Id, NbrSelfiesFromWooki = (item.Wookie?.Selfies?.Count()).GetValueOrDefault(0) }).ToList();
            return this.Ok(model);
        }

        [HttpPost]
        //public IActionResult AddOne(UneClasseQuineSertARien tata)
        public IActionResult AddOne(SelfieDto tata)
        {
            IActionResult result = this.BadRequest();
            Selfie adSelfie = this._repository.AddOne(new Selfie()
            {
                ImagePath = tata.ImagePath,
                Title = tata.Title,

            });
            this._repository.UnitOfWork.SaveChanges();

            if (adSelfie != null)
            {
                tata.Id = adSelfie.Id;
                result = this.Ok(tata);
            }
            return result;

        }


        // Async/Await when to use :
        // When My code will be waiting for something, such as data from a database, reading a file,
        // a call to a web service. In this case you should use Async/Await

        //[Route("photos")]

        //we have 2 post so we have to rename one of them 
        //[HttpPost]
        //public async Task<IActionResult> AddPicture()
        //{
        //    using var stream = new StreamReader(this.Request.Body) ;

        //    var content = await stream.ReadToEndAsync();
        //    return this.Ok();
        //}


        [Route("photos")]
        [HttpPost]
        public async Task<IActionResult> AddPicture(IFormFile picture)
        {
            string filePath = Path.Combine(this._webHostEnvironment.ContentRootPath, @"images\selfies");
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            filePath = Path.Combine(filePath, picture.FileName);


            using var stream = new FileStream(filePath, FileMode.OpenOrCreate);
            await picture.CopyToAsync(stream);


            var ItemFile = this._repository.AddOnePicture(filePath);
            this._repository.UnitOfWork.SaveChanges();

            return this.Ok(ItemFile);
        }


        #endregion

    }
=======
        [HttpGet]

        //The ActionResult types represent various HTTP status codes.
        public IActionResult TestAMoi()
    {
            // var model=  Enumerable.Range(1, 10).Select(item => new Selfie() { Id = item });

            // return this.StatusCode(StatusCodes.Status204NoContent);

            //var model = this._context.Selfies.ToList();
            // var query = from Wookie in this._context.Selfies select Wookie;
           // with this we can not show the wookie so another solution
           // var model = this._context.Selfies.Include(item => item.Wookie).Select(item => new {Title = item.Title , WookieId = item.Wookie.Id , NbSelfieFromOneWookie = item.Wookie.Selfies.Count() }).ToList();
           // include les information sur les wookies 


            var selfieList = this._repository.GetAll();

            var model = selfieList.Select(item => new SelfieResumeDto() { Title = item.Title, WookieId = item.Wookie.Id, NbrSelfiesFromWooki = (item.Wookie?.Selfies?.Count()).GetValueOrDefault(0)}).ToList();




            return this.Ok(model);
    }

    #endregion
}
>>>>>>> 18e673c52cbd52ed9b9e7b8015efe1f234fbb2f9
}
