using BECodingChallengeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BECodingChallengeService
{
    public class ListingService : IListingsService
    {
        private const string API_URL = @"https://jayridechallengeapi.azurewebsites.net/api/QuoteRequest";
        private readonly HttpClient _httpClient;

        public ListingService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(API_URL);
        }

        public async Task<QuoteResponse> GetQuote(int numberOfPassengers)
        {
            if(numberOfPassengers <= 0) 
            {
                throw new Exception("Passenger number must not be less than or equal to zero.");
            }

            QuoteResponse quoteResponse = new QuoteResponse();

            var response = await _httpClient.GetAsync(API_URL);

            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();

                var deserialized = JsonSerializer.Deserialize<QuoteResult>(responseData, new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
                if (deserialized != null)
                {
                    var listings = deserialized.Listings.ToList().Where(l => l.VehicleType.MaxPassengers >= numberOfPassengers).ToList();
                    
                    quoteResponse.TotalPrice = listings.Sum(l => l.PricePerPassenger);
                    quoteResponse.Listings = listings.OrderByDescending(l => l.PricePerPassenger).ToList();
                }
            }

            return quoteResponse;
        }
    }
}
