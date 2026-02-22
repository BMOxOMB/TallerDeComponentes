using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraductorESP_EN
{
    public partial class UserControl1: UserControl
    {
        private readonly System.Collections.Generic.Dictionary<string, string> translations =
            new System.Collections.Generic.Dictionary<string, string>(System.StringComparer.OrdinalIgnoreCase)
            {
                { "hola", "hello" },
                { "adiós", "goodbye" },
                { "gracias", "thank you" },
                { "perro", "dog" },
                { "gato", "cat" },
                { "casa", "house" },
                { "árbol", "tree" },
                { "libro", "book" },
                { "correr", "run" },
                { "comer", "eat" },
                { "agua", "water" },
                { "amigo", "friend" },
                { "mañana", "morning" }
            };

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        
        private void buttonTraducir_Click(object sender, EventArgs e)
        {
            var input = textBoxESP.Text?.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Por favor ingrese una palabra en español.", "Entrada vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEN.Text = string.Empty;
                return;
            }

            // Validar que sea una única palabra (sin espacios)
            var parts = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 1)
            {
                MessageBox.Show("Ingrese solo una única palabra (sin espacios).", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEN.Text = string.Empty;
                return;
            }

            // Buscar la traducción
            if (translations.TryGetValue(input, out var translated))
            {
                textBoxEN.Text = translated;
            }
            else
            {
                textBoxEN.Text = "No se encontró la traducción";
            }
        }

        private void textBoxESP_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
