using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using BECodingChallengeService.Models;

namespace BECodingChallengeService
{
    public class LocationService : ILocationService
    {
        private const string API_ACCESS_KEY = "ea45564b4b64957db480c3348a649ca7";
        private const string API_URL = @"http://api.ipstack.com";
        private readonly HttpClient _httpClient;

        public LocationService()
        { 
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(API_URL);
        }
        public async Task<string> GetLocation()
        {
            string result = string.Empty;
            string ipAddress = GetIpAddress();
            string url = $"{ipAddress}?access_key={API_ACCESS_KEY}";
            
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode) 
            {
                string responseData = await response.Content.ReadAsStringAsync();

                var deserialized = JsonSerializer.Deserialize<LocationDetail>(responseData, new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
                if(deserialized != null)
                    result = deserialized.City;
            }

            return result;
        }

        private string GetIpAddress()
        {
            string ipAddress = string.Empty;

            var host = Dns.GetHostEntry(Dns.GetHostName());            
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetworkV6 && ip.IsIPv6LinkLocal == false)
                {
                    ipAddress = ip.ToString();
                    break;
                }
            }

            return ipAddress;
        }
    }
}
