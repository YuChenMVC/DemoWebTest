using DemoWeb.Models;
using DemoWeb.DTOs;
using DemoWeb.Services;
using Xunit;

namespace DemoWebTests
{
    public class ListServiceTest
    {
        private readonly ListService _listService;
        private readonly DemoDatabaseContext _demoDatabaseContext;

        public ListServiceTest()
        {
            _listService = new ListService();
            _demoDatabaseContext = new DemoDatabaseContext();
        }

        [Fact]
        public void GetHouseById_WhenCalled_ReturnsResult()
        {
            // Act ���դ�k
            var Result = _listService.GetHouseById(_demoDatabaseContext, 1);
            // Assert �P�w�����G���
            Assert.IsType<ListSelectDto>(Result);
        }
    }
}