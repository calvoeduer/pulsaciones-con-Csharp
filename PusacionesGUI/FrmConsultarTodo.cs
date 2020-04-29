using BLL;
using Entity;
using Infraestructura;
using System;
using System.Windows.Forms;

namespace PusacionesGUI
{
    public partial class FrmConsultarTodo : Form
    {
        IRecepcion frmrecepcion;
        private readonly PersonaService personaService = new PersonaService();

        public FrmConsultarTodo()
        {
            InitializeComponent();
            TablaPersonas.DataSource = personaService.ConsultarDB();
        }

        public FrmConsultarTodo(IRecepcion recepcion)
        {
            InitializeComponent();
            frmrecepcion = recepcion;
            TablaPersonas.DataSource = personaService.ConsultarDB();
        }



        private void BtnConsultar_Click(object sender, EventArgs e)
        {

            TablaPersonas.DataSource = null;
            TablaPersonas.DataSource = personaService.ConsultarDB();

            TablaPersonas.DataSource = personaService.FiltrarPorSexo(CmbConsultarPorSexo.Text);

            if (CmbConsultarPorSexo.Text.Equals("TODOS"))
            {
                TablaPersonas.DataSource = null;
                TablaPersonas.DataSource = personaService.ConsultarDB();
            }

            personaService.GenerarArchivoSexo(CmbConsultarPorSexo.Text);

            TxtTotalPersonas.Text = personaService.TotalizarPersonas().ToString();
            TxtSumaPulsaciones.Text = personaService.SumarPulsacioens().ToString();
            TxtSumaPulsacionHombre.Text = personaService.PulsacionesdeHombre().ToString();
            TxtSumaPulsacionMujeres.Text = personaService.PulsacionesdeMujeres().ToString();
            TxtTotalHombres.Text = personaService.TotalizarPersonasHombres().ToString();
            TxtTotalMujeres.Text = personaService.TotalizarPersonasMujeres().ToString();
            /**/
            personaService.GuardarDatos();
            
        }

        private void TablaPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TablaPersonas.Refresh();
        }

        private void BtnGenerarPdf_Click(object sender, EventArgs e)
        {

            try
            {
                if (personaService.ConsultarDB() is null)
                {
                    MessageBox.Show("Error al leer el archivo", "ERROR AL GENERAR PDF O ENVIAR EMAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    TablaPersonas.DataSource = personaService.ConsultarDB();
                    personaService.GuardarPdf(personaService.ConsultarDB());

                    EmailAdjunto adjunto = new EmailAdjunto();
                    adjunto.EnviarEmail();

                }

                MessageBox.Show("Pdf Generado y Enviado Correctamente", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Em)
            {
                MessageBox.Show("Error al leer el archivo o enviar pdf" + Em);
            }

            
            
        }

       

        private void FrmConsultarTodo_Load(object sender, EventArgs e)
        {

        }

        public void TablaPersonas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (frmrecepcion != null)
            {
                Persona persona = (Persona)TablaPersonas.CurrentRow.DataBoundItem;
                frmrecepcion.Recibir(persona);
                this.Hide();
            }
        }
    }
}
