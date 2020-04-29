using DAL;
using Entity;
using System.Collections.Generic;
using System.Data.SqlClient;
using Infraestructura;
using System;

namespace BLL
{
    public class PersonaService
    {

        private SqlConnection conexion;
        private PersonaRepository personaRepository;
        public PdfCreater GenerarPdf;

        private string cadenaConexion = @"Data Source=DESKTOP-NO6VVCF\SQLEXPRESS;Initial Catalog=DBpulsacion;Integrated Security=True";

        public PersonaService()
        {
            GenerarPdf = new PdfCreater();
            conexion = new SqlConnection(cadenaConexion);
            personaRepository = new PersonaRepository(conexion);
        }
        public void GuardarPdf(List<Persona> personas)
        {
            GenerarPdf.GuardarPdf(personas);
        }

        public List<Persona> ConsultarDB()
        {
            try
            {
                conexion.Open();
                List<Persona> personas = personaRepository.ConsultarDB();
                return personas;

            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conexion.Close();
            }

        }

       


        public string Guardar(Persona persona)
        {
            Email email = new Email();
            string mensajeEmail = string.Empty;
            
            try
            {
                conexion.Open();
                string correo_;
                personaRepository.Guardar(persona);
                mensajeEmail = email.EnviarEmail(persona);
                return $"se guardaron los datos correctamente" + mensajeEmail;
            }
            catch (System.Exception ex)
            {

                return "Error de Datos" + ex.Message;
            }
            finally
            {
                conexion.Close();
            }
        }


        public void enviaremail(Persona persona)
        {

            Email email = new Email();
            string correo = null;
            string mensajeEmail = string.Empty;
            mensajeEmail = email.EnviarEmail(persona);

        }


        public string Eliminar(string identificacion)
        {
            try
            {

                conexion.Open();
                personaRepository.Eliminar(identificacion);
                return $"Se Eliminó correctamente";
            }
            catch (System.Exception e)
            {

                return $"Error al eliminar" + e.Message;
            }
            finally
            {
                conexion.Close();
            }
        }




      

        public void GenerarArchivoSexo(string sexo)
        {
            personaRepository.GenerarArchivoSexo(sexo);
        }

        /*---------------------------------------------------*/

        public List<Persona> FiltrarPorSexo(string sexo)
        {
            return personaRepository.FiltrarPorSexo(sexo);
        }

       

        public Persona Buscar(string identificacion)
        {
            return personaRepository.BuscarIdentificacion(identificacion);
        }

        public string Modificar(Persona persona)
        {
            Persona persona2 = personaRepository.BuscarIdentificacion(persona.Identificacion);
            if (persona != null)
            {
                personaRepository.Modificar(persona);
                return $"Se Modifucaron los datos de manera correcta";

            }
            return $"NO Se Modificaron los datos de manera correcta";
        }

        public int TotalizarPersonas()
        {
            return personaRepository.TotalizarPersonas();
        }
        public int TotalizarPersonasMujeres()
        {
            return personaRepository.TotalizarPersonasMujeres();
        }

        public int TotalizarPersonasHombres()
        {
            return personaRepository.TotalizarPersonasHombres();

        }

        public int TotalizarPersonasTipo(string tipo)
        {
            return personaRepository.TotalizarPersonasTipo(tipo);
        }


        public decimal SumarPulsacioens()
        {

            return personaRepository.SumarPulsaciones();
        }

        public decimal PulsacionesdeHombre()
        {
            return personaRepository.PulsacionesdeHombre();
        }

        public decimal PulsacionesdeMujeres()
        {
            return personaRepository.PulsacionesdeMujeres();

        }

        public void GuardarDatos()
        {
            personaRepository.GuardarDatos();
        }
       
    }
}
