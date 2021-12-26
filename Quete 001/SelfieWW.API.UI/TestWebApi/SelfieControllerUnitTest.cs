using Microsoft.AspNetCore.Mvc;
using Moq;
using SelfieAwwokieCore.Selfies.Domain;
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