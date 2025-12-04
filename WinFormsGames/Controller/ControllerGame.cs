using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WinFormsGames.Models;
using System.Net.Http;  

namespace WinFormsGames.Controller
{
    internal class ControllerGame
    {
        private readonly HttpClient _httpClient;

        public ControllerGame()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7277/");
        }

        // 1. Obtener token JWT
        public async Task<string> GetTokenAsync(string user, string pass)
        {
            var loginData = new
            {
                Username = user,
                Password = pass
            };

            var json = JsonConvert.SerializeObject(loginData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/Auth/Login", content);

            if (!response.IsSuccessStatusCode)
                throw new Exception("Login failed: " + response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();

            dynamic data = JsonConvert.DeserializeObject(result);
            string token = data.access_token;  // <- AQUÍ EL ARREGLO

            return token;
        }


        // 2. Consumir Pokémon usando el token y devolver lista tipada
        public async Task<List<GameModels>> GetGamesAsync(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.GetAsync("api/Games");

            if (!response.IsSuccessStatusCode)
                throw new Exception("Error: " + response.StatusCode);

            var resultJson = await response.Content.ReadAsStringAsync();

            // Convertir el JSON en una lista de PokemonModel
            var lista = JsonConvert.DeserializeObject<List<GameModels>>(resultJson);

            return lista!;
        }

        public async Task<GameModels?> GetGameByIdAsync(string token, int id)
        {
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.GetAsync($"api/Games/{id}");

            if (!response.IsSuccessStatusCode)
                throw new Exception("Error al obtener el juego: " + response.StatusCode);

            var json = await response.Content.ReadAsStringAsync();

            var game = JsonConvert.DeserializeObject<GameModels>(json);

            return game;
        }
    }
}
