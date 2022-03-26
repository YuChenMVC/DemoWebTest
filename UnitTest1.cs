using DemoWeb.Models;
using DemoWeb.DTOs;
using DemoWeb.Services;
using Xunit;
using DemoWeb.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebTests
{
    public class ListServiceTest
    {
        private readonly ListService _listService;
        private readonly ListController _listController;
        private readonly DemoDatabaseContext _demoDatabaseContext;

        public ListServiceTest()
        {
            _listService = new ListService();            
            _demoDatabaseContext = new DemoDatabaseContext();
            _listController = new ListController(_demoDatabaseContext, _listService);
        }

        #region ���� HTTP �O�_���`�^�� 200
        [Fact]
        public void Get_ReturnOkResult()
        {
            // Act ���դ�k
            var result = _listController.Get();
            // Assert �P�w�����G���
            Assert.IsType<OkObjectResult>(result as OkObjectResult);
        }
        #endregion

        #region ���լO�_���`�^��ListSelectDto���O
        [Fact]
        public void GetHouseById_ReturnResult()
        {
            // Act ���դ�k
            var result = _listService.GetHouseById(_demoDatabaseContext, 1);
            // Assert �P�w�����G���
            Assert.IsType<ListSelectDto>(result);
        }
        #endregion
    }
}