using Microsoft.AspNetCore.Mvc;
using SelfieWW.API.UI.Controllers;
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
            var controller = new SelfieController(null);
            //ACT

            var result = controller.TestAMoi();
            
            //ASSERT
            Assert.NotNull(result); 
            Assert.IsType<OkObjectResult>(result);
            OkObjectResult okResult = result as OkObjectResult;

            //  Assert.True(result.GetEnumerator().MoveNext());
            Assert.NotNull(okResult.Value);

            


        }


        #endregion

    }
}