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

        #region 測試 HTTP 是否正常回傳 200
        [Fact]
        public void Get_ReturnOkResult()
        {
            // Act 測試方法
            var result = _listController.Get();
            // Assert 與預期結果比對
            Assert.IsType<OkObjectResult>(result as OkObjectResult);
        }
        #endregion

        #region 測試是否正常回傳ListSelectDto型別
        [Fact]
        public void GetHouseById_ReturnResult()
        {
            // Act 測試方法
            var result = _listService.GetHouseById(_demoDatabaseContext, 1);
            // Assert 與預期結果比對
            Assert.IsType<ListSelectDto>(result);
        }
        #endregion
    }
}