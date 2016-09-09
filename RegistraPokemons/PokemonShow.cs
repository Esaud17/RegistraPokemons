using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistraPokemons.models;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using RegistraPokemons.models;

namespace RegistraPokemons
{
    public partial class PokemonShow : Form
    {

        public PokemonShow()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random aletorio = new Random();
            int valor = 0;

            if (!string.IsNullOrWhiteSpace(this.txb_pokemon.Text)) {
                valor = Int32.Parse(this.txb_pokemon.Text);
                if (valor>720)
                {
                    MessageBox.Show(" Este pokedex cuenta con: \n\n\n  -> 720 pokémons");
                    this.txb_pokemon.Text = "";
                    valor = 720;
                }
            } else {
                valor = aletorio.Next(1, 250);
            }

            string file = String.Format("{0}.png", valor.ToString());
            string url = String.Format("http://veekun.com/dex/media/pokemon/main-sprites/x-y/{0}", file);

            var request = WebRequest.Create(url);
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                ptb_pokemon.Image = Bitmap.FromStream(stream);
               

            }

            string json = String.Format("http://pokeapi.co/api/v2/pokemon/{0}", valor.ToString());

           Pokemon pokestatic = GET(json);

           lbl_nametext.Text= pokestatic.name;
           lbl_idtext.Text = pokestatic.id.ToString();
           lbl_tipotext.Text = pokestatic.types[0].type.name;
           lbl_niveltext.Text = pokestatic.base_experience.ToString();

           lbl_coins.Text = aletorio.Next(1, 10).ToString();
           lbl_pokeballs.Text = aletorio.Next(1, 10).ToString();

           this.txb_pokemon.Text = "";

        }

        private Pokemon GET(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string json = reader.ReadToEnd();
                    return JsonConvert.DeserializeObject<Pokemon>(json); 
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    // log errorText
                }
                throw;
            }
        }

        private void txb_pokemon_KeyPress(object sender, KeyPressEventArgs e)
        {  
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                    e.Handled = true;     
            }
        }
    }
}
