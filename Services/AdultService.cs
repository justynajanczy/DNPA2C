using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Assignment2.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Services
{
    public class AdultService : IAdultService
    {
        private readonly HttpClient _httpClient;

        public AdultService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<IList<Adult>> GetAdults()
        {
            return await _httpClient.GetJsonAsync<Adult[]>("adults");
        }

        public async Task<ActionResult<Adult>> GetAdult(int id)
        {
            return await _httpClient.GetFromJsonAsync<Adult>($"adults/{id}");
        }

        public async Task<ActionResult<Adult>> AddAdult(Adult adult)
        {
            return await _httpClient.PostJsonAsync<Adult>("adults", adult);
        }

        public async Task DeleteAdult(int id)
        {
            await _httpClient.DeleteAsync($"adults/{id}");
        }

        public async Task<ActionResult<Adult>> UpdateAdult(Adult adult)
        {
            return await _httpClient.PutJsonAsync<Adult>("adults", adult);
        }
    }
}