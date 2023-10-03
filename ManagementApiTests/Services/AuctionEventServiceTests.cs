using AutoFixture.Kernel;
using AutoFixture;
using ManagementApi.Services;
using ManagementApi.Services.Interfaces;

namespace ManagementApiTests.Services
{
    public class AuctionEventServiceTests
    {
        private readonly IAuctionEventService _auctionEventService;

        public AuctionEventServiceTests() 
        {
            var fixture = new Fixture();
            fixture.Customizations.Add(
                new TypeRelay(
                    typeof(IAuctionEventService),
                    typeof(AuctionEventService)));
            _auctionEventService = fixture.Create<IAuctionEventService>();
        }

        [Theory]
        [InlineData(1234)]
        public async Task Should_Return_Null_When_Unable_To_Connect_To_Database(int saleId)
        {
            var result = await _auctionEventService.GetAuctionEventDetails(saleId);

            // Assert
            Assert.Null(result);
            //await Assert.ThrowsAsync<ArgumentException>(async () => await _auctionEventService.GetAuctionEventDetails(saleId));
        }

        [Theory]
        [InlineData(1234)]
        public async Task Should_Return_AuctionEventDetails_When_SaleId_Is_ValidAsync(int saleId)
        {
            // ToDo: Update Unit Test
            var result = await _auctionEventService.GetAuctionEventDetails(saleId);

            // Assert
            Assert.Null(result);
            //await Assert.ThrowsAsync<ArgumentException>(async () => await _auctionEventService.GetAuctionEventDetails(saleId));
        }
    }
}