using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picturebox
{
    public partial class frmPictureBox : Form
    {
        private string imagemLocalizada;

        public frmPictureBox()
        {
            InitializeComponent();
        }

        private void btnAnexarImagem_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {  // Caixa de dialogo para abrir arquivo

                OpenFileDialog abrirarquivo = new OpenFileDialog();
                abrirarquivo.Filter = "jpg files(*jpg) | * .jpg | Png files (*.png) | *png | All files (*.*) | *.*";

                if (abrirarquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagemLocalizada = abrirarquivo.FileName;

                    pbAnexarImagem.ImageLocation = imagemLocalizada;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
