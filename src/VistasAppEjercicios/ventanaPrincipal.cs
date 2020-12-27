using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistasAppEjercicios
{
    public partial class ventanaPrincipal : Form
    {
        public ventanaPrincipal()
        {
            InitializeComponent();
        }

        private void ingresarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //buscar definicion de una clse y de un objeto
            ventanaDatos ventana = new ventanaDatos();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void ingresarEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventanaEjercicios vn = new ventanaEjercicios();
            vn.MdiParent = this;
            vn.Show();
                        
        }
    }
}
