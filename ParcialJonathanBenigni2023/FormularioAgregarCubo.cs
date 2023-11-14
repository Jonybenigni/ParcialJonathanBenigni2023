using ParcialdeJonathanBenigni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialJonathanBenigni2023
{
    public partial class FormularioAgregarCubo : Form
    {
        public FormularioAgregarCubo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormularioAgregarCubo_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Color> colores = Enum.GetValues(typeof(Color)).Cast<Color>().ToList();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Trazo> trazos = Enum.GetValues(typeof(Trazo)).Cast<Trazo>().ToList();
        }
    }

    internal class Trazo
    {
    }
}
