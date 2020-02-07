using System;
using Xunit;
using Moq;
using MediatR;
using System.Threading.Tasks;
using ServicioPrueba.API.Customers;
using Microsoft.AspNetCore.Mvc;

namespace ServicioPrueba.UnitTests
{
    public class UnitTestWebApi
    {
        private readonly Mock<IMediator> _mediatorMock;

        public UnitTestWebApi()
        {
            _mediatorMock = new Mock<IMediator>();
        }

        [Fact]
        public async Task Cancel_order_with_requestId_success()
        {
            //Arrange

            //Act
            var controller = new CustomerOrdersController(_mediatorMock.Object);
            var actionResult = await controller.GetAtributos() as OkResult;
               
            //Assert
            Assert.Equal(actionResult.StatusCode, (int)System.Net.HttpStatusCode.OK);

        }
    }
}
