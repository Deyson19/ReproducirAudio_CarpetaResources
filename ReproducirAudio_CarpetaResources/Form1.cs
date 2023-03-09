using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproducirAudio_CarpetaResources
{
    public partial class Form1 : Form
    {
        private SoundPlayer playerIncorrecta, playerCorrecta;
        public Form1()
        {
            InitializeComponent();
            playerCorrecta = new SoundPlayer(Properties.Resources.correcta);
            playerIncorrecta = new SoundPlayer(Properties.Resources.incorrecta);
        }

        private void btnCorrecta_Click(object sender, EventArgs e)
        {
            playerCorrecta.Play();
        }

        private void btnIncorrecta_Click(object sender, EventArgs e)
        {
            playerIncorrecta.Play();
        }
    }
}
