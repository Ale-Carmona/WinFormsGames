using WinFormsGames.Models;
using WinFormsGames.Controller;

namespace WinFormsGames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private async void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                ControllerGame controller = new ControllerGame();
                string token = await controller.GetTokenAsync("admin", "admin123");
                var listaJuegos = await controller.GetGamesAsync(token);

                dgDatos.DataSource = listaJuegos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al consumir la API." + ex.Message);
            }
        }
    }
}
