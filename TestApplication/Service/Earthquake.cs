using System;
using System.Net.Http;
using System.Threading.Tasks;
using TestApplication.Interface;
using TestApplication.Models;

namespace TestApplication.Service
{
    public class Earthquake : IEarthquake
    {
        private readonly HttpClient _httpClient;
        public Earthquake(HttpClient httpClient) 
        { 
            _httpClient = httpClient;
        }
        public async Task<EarthquakeInfo> GetEarthquakeInfoAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("https://earthquake.usgs.gov/fdsnws/event/1/query?format=geojson&starttime=2021-02-23&&endtime=2021-02-24");
                if(response?.IsSuccessStatusCode ?? false) 
                {
                    return await response.Content.ReadAsAsync<EarthquakeInfo>();
                }
            }
            catch(Exception ex) 
            { 
            
            }
            return default;
        }
    }
}
