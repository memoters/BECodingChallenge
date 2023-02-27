using BECodingChallengeService;
using Shouldly;
using System.Runtime.InteropServices;

namespace BECodingChallengeServiceTest
{
    [TestClass]
    public class ListingServiceTest
    {
        [TestMethod]
        public void GetQuote_ValidNumberOfPassengers_ReturnOk()
        {
            //should use fakes/stubs for the await _httpClient.GetAsync(API_URL); to avod actual calls to the API
            IListingsService listingService = new ListingService();

            Should.NotThrowAsync(async () =>
            {
                await listingService.GetQuote(2);
            });
        }

        [TestMethod]
        public void GetQuote_InvalidNumberOrPassengers_ExceptionThrown()
        {
            IListingsService listingService = new ListingService();

            Should.Throw<Exception>(async () =>
            {
                await listingService.GetQuote(0);
            });
        }
    }
}