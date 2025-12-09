using System.Net;
using System.Text.Json;
using System.Windows.Forms;
using WinFormsGames.Controller;
using WinFormsGames.Models;

namespace WinFormsGames
{
    public partial class Form1 : Form
    {
        private readonly ControllerGame _controller = new ControllerGame();
        private string _token;

        private static string _jwtToken = null;

        private static readonly HttpClient _httpClient = new HttpClient();

        // URLs Base de TU PROPIA API de .NET 8
        private const string ApiBaseUrl = "https://localhost:7277/"; // La URL base
        private const string CharacterUrl = ApiBaseUrl + "api/Games/id/";
        private const string AllCharactersUrl = ApiBaseUrl + "api/Games";
        private const string LoginUrl = ApiBaseUrl + "api/Auth/login"; // Endpoint de Login
        public Form1()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls13;
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            InitializeComponent();
        }


        private async void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                ControllerGame controller = new ControllerGame();
                string user = txbUserName.Text.Trim();
                string pass = txbPassword.Text.Trim();

                _token = await _controller.GetTokenAsync(user, pass);
                var listaJuegos = await controller.GetGamesAsync(_token);

                dgDatos.DataSource = listaJuegos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al consumir la API." + ex.Message);
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbID.Text))
                {
                    MessageBox.Show("Ingresa un ID para buscar.");
                    return;
                }

                int id = int.Parse(txbID.Text);
                ControllerGame controller = new ControllerGame();

                // 1. Obtener token
                string token = await controller.GetTokenAsync("admin", "admin123");

                // 2. Buscar juego por ID
                var game = await controller.GetGameByIdAsync(token, id);

                if (game == null)
                {
                    MessageBox.Show("No se encontró el juego.");
                    return;
                }

                // 3. Mostrar en el DataGridView
                dgDatos.DataSource = new List<GameModels> { game };

                // 4. Mostrar la imagen usando un proxy
                if (!string.IsNullOrWhiteSpace(game.thumbnail))
                {
                    string proxyUrl = $"https://api.allorigins.win/raw?url={Uri.EscapeDataString(game.thumbnail)}";
                    await CargarImagenDesdeUrl(proxyUrl);
                }
                else
                {
                    picGame.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private async Task CargarImagenDesdeUrl(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");

                    byte[] imageBytes = await client.GetByteArrayAsync(url); // Direct URL

                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image imgTemp = Image.FromStream(ms);
                        picGame.Image?.Dispose();
                        picGame.Image = new Bitmap(imgTemp);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.Message);
            }
        }



        private async void picGame_Click(object sender, EventArgs e)

        {
        }

        private void dgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void dgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txbUserName.Text.Trim();
                string pass = txbPassword.Text.Trim();

                _token = await _controller.GetTokenAsync(user, pass);

                MessageBox.Show("Login correcto!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de login: " + ex.Message);
            }
        }
    
    }
}
