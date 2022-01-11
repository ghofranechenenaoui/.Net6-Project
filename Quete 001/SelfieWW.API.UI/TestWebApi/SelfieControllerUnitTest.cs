using Microsoft.AspNetCore.Mvc;
using Moq;
using SelfieAwwokieCore.Selfies.Domain;
<<<<<<< HEAD
using SelfieWookie.Core.Framework;
=======
>>>>>>> 18e673c52cbd52ed9b9e7b8015efe1f234fbb2f9
using SelfieWW.API.UI.Application.DTOs;
using SelfieWW.API.UI.Controllers;
using System.Collections.Generic;
using Xunit;

namespace TestWebApi
{
    public class SelfieControllerUnitTest
    {
        #region public methods

        [Fact]
<<<<<<< HEAD
        #region Insert method
        public void ShouldAddOneSelfie()
        {
            //Arrange 
            SelfieDto selfie = new SelfieDto();
            var RepositoryMock = new Mock<ISelfieRepository>();
            var unit = new Mock<IUnitOfWork>();
            RepositoryMock.Setup(item => item.UnitOfWork).Returns(unit.Object);
            RepositoryMock.Setup(item => item.AddOne(It.IsAny<Selfie>())).Returns(new Selfie() { Id = 4 });

            //Act
            var controller = new SelfieController(RepositoryMock.Object);
            var result = controller.AddOne(selfie);
            //ASSert
            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result);

            var addeSelfir = (result as OkObjectResult).Value as SelfieDto;
            Assert.NotNull(addeSelfir);
            Assert.True(addeSelfir.Id > 0);


        }


        [Fact]
=======
>>>>>>> 18e673c52cbd52ed9b9e7b8015efe1f234fbb2f9
        public void ShouldReturnListOfSelfie()
        {
            //ARRANGE


            var lisExpected = new List<Selfie>()
            {  new Selfie(){Wookie =new Wookie()},
               new Selfie(){Wookie = new Wookie()}
            };

            var repositoryMock = new Mock<ISelfieRepository>();
            repositoryMock.Setup(item => item.GetAll()).Returns(lisExpected);
            var controller = new SelfieController(repositoryMock.Object);

            //ACT

            var result = controller.TestAMoi();

            //ASSERT

            Assert.NotNull(result); 
            Assert.IsType<OkObjectResult>(result);
            
            OkObjectResult? okResult = result as OkObjectResult;

            Assert.NotNull(okResult.Value);

            Assert.IsType<List<SelfieResumeDto>>(okResult.Value);

            List<SelfieResumeDto> list = okResult.Value as List<SelfieResumeDto>;
            Assert.True(list.Count == lisExpected.Count);

            // Assert.True(result.GetEnumerator().MoveNext()
        }


        #endregion

    }
}