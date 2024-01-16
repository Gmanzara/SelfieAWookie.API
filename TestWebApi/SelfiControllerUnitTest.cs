using Microsoft.AspNetCore.Mvc;
using SelfieAWookie.API.Controllers;
using System;
using Xunit;

namespace TestWebApi
{
    public class SelfiControllerUnitTest
    {

        [Fact]
        public void ShouldReturnListSelfies()
        {
            //RANGE : renvoyer les données
            var controller = new SelfiesController(null);

            //ACT : action qu'on va faire
            var result = controller.TestMoi();

            //ASSERT
            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result);

            ObjectResult okresult =  result as ObjectResult;    
            Assert.NotNull (okresult.);
            //Assert.True(result.GetEnumerator().MoveNext());
        }
    }
}
