using Bunifu.Framework.UI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Manager
{
    public partial class TeamManager : Form
    {
        private List<Country> country = new List<Country>();
        List<Country> countries = new List<Country>();
        Stadion stadion = new Stadion();
        public TeamManager()
        {
            InitializeComponent();

            countriesdrpdwn.AddItem("Select Country");
            countriesdrpdwn.selectedIndex = 0;


            this.BackColor = Color.White;
            this.AllowTransparency = true;


        }

        private async void TeamManager_Load(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();

            var response = await httpClient.GetAsync("https://restcountries.eu/rest/v2/all");
            var countryJson = await response.Content.ReadAsStringAsync();
            countryJson = countryJson.Replace("\\", "");
            countries = JsonConvert.DeserializeObject<List<Country>>(countryJson);

            countries.RemoveAll(c => c.Name.ToLowerInvariant() == "armenia".ToLowerInvariant());

            foreach (var country in countries)
            {

                countriesdrpdwn.AddItem(country.Name);

            }

        }
        private void countriesdrpdwn_onItemSelected(object sender, EventArgs e)
        {


            int index = countriesdrpdwn.selectedIndex;

            if (countriesdrpdwn.selectedIndex > 0)
            {
                using (WebClient wc = new WebClient())
                {
                    using (var ms = new MemoryStream(wc.DownloadData($"https://www.countryflags.io/{countries[index - 1].Alpha2Code}/shiny/32.png")))
                    {
                        var image = Image.FromStream(ms);
                        flags.Image = image;

                    }
                }
            }

        }




        private void generateteambtn_Click(object sender, EventArgs e)
        {

            stadion.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tactics_onItemSelected(object sender, EventArgs e)
        {


            if (tactics.selectedIndex == 0)
            {

            }
            else
            { 
                Point point = new Point();

                point = new Point(59, 78);
                stadion.SetPlayerPosition(point, 5);
                point = new Point(59, 62);
                stadion.SetNamePosition(point, 5);
                point = new Point(75, 98);
                stadion.SetNumberPosition(point, 5);


                point = new Point(188, 89);
                stadion.SetPlayerPosition(point, 9);
                point = new Point(185, 73);
                stadion.SetNamePosition(point, 9);
                point = new Point(204, 110);
                stadion.SetNumberPosition(point, 9);


                point = new Point(308, 89);
                stadion.SetPlayerPosition(point, 10);
                point = new Point(305, 73);
                stadion.SetNamePosition(point, 10);
                point = new Point(325, 107);
                stadion.SetNumberPosition(point, 10);


                point = new Point(77, 212);
                stadion.SetPlayerPosition(point, 6);
                point = new Point(77, 196);
                stadion.SetNamePosition(point, 6);
                point = new Point(93, 233);
                stadion.SetNumberPosition(point, 6);

                point = new Point(191, 212);
                stadion.SetPlayerPosition(point, 7);
                point = new Point(188, 196);
                stadion.SetNamePosition(point, 7);
                point = new Point(208, 232);
                stadion.SetNumberPosition(point, 7); 
              
            }
            stadion.SetNumber(player0n.Text, 0);
            stadion.SetNumber(player1n.Text, 1);
            stadion.SetNumber(player2n.Text, 2);
            stadion.SetNumber(player3n.Text, 3);
            stadion.SetNumber(player4n.Text, 4);
            stadion.SetNumber(player5n.Text, 5);
            stadion.SetNumber(player6n.Text, 6);
            stadion.SetNumber(player7n.Text, 7);
            stadion.SetNumber(player8n.Text, 8);
            stadion.SetNumber(player9n.Text, 9);
            stadion.SetNumber(player10n.Text, 10);


            stadion.SetName(player0nn.Text, 0);
            stadion.SetName(player1nn.Text, 1);
            stadion.SetName(player2nn.Text, 2);
            stadion.SetName(player3nn.Text, 3);
            stadion.SetName(player4nn.Text, 4);
            stadion.SetName(player5nn.Text, 5);
            stadion.SetName(player6nn.Text, 6);
            stadion.SetName(player7nn.Text, 7);
            stadion.SetName(player8nn.Text, 8);
            stadion.SetName(player9nn.Text, 9);
            stadion.SetName(player10nn.Text, 10);

        }

        private void player1p_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
