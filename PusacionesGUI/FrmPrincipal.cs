using System;
using System.Windows.Forms;

namespace PusacionesGUI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void RegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersona frmPersona = new FrmPersona();
            frmPersona.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void SalirdelaAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarTodo frmConsultarTodo = new FrmConsultarTodo();
            frmConsultarTodo.Show();
        }

        private void PersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
