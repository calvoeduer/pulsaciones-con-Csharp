using BLL;
using Entity;
using System;
using System.Windows.Forms;
using Infraestructura;
using System.Net.Mail;



namespace PusacionesGUI
{
    public partial class FrmPersona : MetroFramework.Forms.MetroForm , IRecepcion
    {
        private readonly PersonaService personaService = new PersonaService();

        



        public FrmPersona()
        {

            InitializeComponent();
            CmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {

        }



        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
           
            Persona persona = CalcularPulsacion();
            Email email = new Email();
            new MailAddress(TxtEmail.Text);
            email.EnviarEmail(persona);
            
            string mensaje = personaService.Guardar(persona);
            MessageBox.Show(mensaje, "MensajeGuardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();

        }

        private Persona CalcularPulsacion()
        {
            try
            {

                Persona persona = new Persona
                {
                    Identificacion = TxtIdendificacion.Text.Trim(),
                    Nombre = TxtNombre.Text.Trim(),
                    Edad = Convert.ToInt32(TxtEdad.Text.Trim()),
                    Sexo = CmbSexo.Text
                };
                persona.CalcularPulsacion();
                TxtPulsaciones.Text = persona.Pulsacion.ToString();
                return persona;
            }
            catch (Exception e)
            {

                MessageBox.Show("Seleccione un sexo e ingrese una edad valida", "ERROR EDAD O SEXO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return null;
                
        }


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            if (personaService.Buscar(TxtIdendificacion.Text) == null)
            {
                MessageBox.Show("No existe la persona");
            }
            else
            {
                persona = personaService.Buscar(TxtIdendificacion.Text);
                TxtIdendificacion.Text = persona.Identificacion;
                TxtNombre.Text = persona.Nombre;

                TxtEdad.Text = persona.Edad.ToString();
                CmbSexo.Text = persona.Sexo;


            }


        }

        private void PintarBusqueda(string identificacion)
        {
            TxtNombre.Text = personaService.Buscar(identificacion).Nombre;
            TxtIdendificacion.Text = personaService.Buscar(identificacion).Identificacion;
            TxtEdad.Text = Convert.ToString(personaService.Buscar(identificacion).Edad);
            TxtPulsaciones.Text = Convert.ToString(personaService.Buscar(identificacion).Pulsacion);
            CmbSexo.Text = personaService.Buscar(identificacion).Sexo;
        }
        private void Limpiar()
        {
            TxtIdendificacion.Text = ("");
            TxtNombre.Text = ("");
            TxtEdad.Text = ("");
            CmbSexo.Text = ("");
            TxtPulsaciones.Text = ("");
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            string identificacion = TxtIdendificacion.Text.Trim();


            string mensaje = personaService.Eliminar(identificacion);
            MessageBox.Show(mensaje, "MensajeEliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpiar();

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            string identificacion = TxtIdendificacion.Text.Trim();

            Persona persona = CalcularPulsacion();

            string msg = personaService.Modificar(persona);

            MessageBox.Show(msg, "Notofocacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpiar();


        }

        private void FrmPersona_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void BtnCalcularPulsacion_Click(object sender, EventArgs e)
        {
            CalcularPulsacion();
        }


        public void Recibir(Persona persona)
        {
            if (persona != null)
            {
                TxtIdendificacion.Text = persona.Identificacion;
                TxtNombre.Text = persona.Nombre;
                TxtEdad.Text = Convert.ToString( persona.Edad);
                CmbSexo.Text = persona.Sexo;
                TxtPulsaciones.Text =  persona.Pulsacion.ToString();
            }
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            FrmConsultarTodo frmConsultarTodo = new FrmConsultarTodo(this); //me llamo porque necesito escribir en mi mismo y como es la mima clase la mando con this
            frmConsultarTodo.Show();
        }
    }
}
