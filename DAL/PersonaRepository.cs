using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; //expreciones landa
using System.Data.SqlClient; //ojo 
using System.Data.SqlTypes;

namespace DAL
{
    public class PersonaRepository
    {

        private readonly string ruta = @"Persona.txt";
        private readonly string rutaDatos = @"InformeDatos.txt";

        SqlConnection conexion;
        List<Persona> personas;
        SqlDataReader Reader;



        public PersonaRepository(SqlConnection conexionBD)
        {
            personas = new List<Persona>();
            conexion = conexionBD;
        }

        public void Guardar(Persona persona)
        {
            using (var comando=conexion.CreateCommand())
            {
                comando.CommandText = "INSERT INTO TBpersona VALUES(@Identificacion,@Nombre,@Edad,@sexo,@pulsacion)";
                comando.Parameters.AddWithValue("@Identificacion", persona.Identificacion);
                comando.Parameters.AddWithValue("@Nombre", persona.Nombre);
                comando.Parameters.Add("@Edad", System.Data.SqlDbType.Int).Value = persona.Edad;
                comando.Parameters.AddWithValue("@Sexo", persona.Sexo);
                comando.Parameters.AddWithValue("@Pulsacion", System.Data.SqlDbType.Decimal).Value = persona.Pulsacion;
               // comando.Parameters.AddWithValue("@Email", persona.Email);
                comando.ExecuteNonQuery();
            }
        }

        public List<Persona> ConsultarDB()
        {

            personas.Clear();

            using (var Comando = conexion.CreateCommand())
            {
                Comando.CommandText = "SELECT * FROM TBpersona";
                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {
                    Persona persona = new Persona();
                    persona = Map(Reader);
                    personas.Add(persona);

                }
            }
            return personas;
        }


        public List<Persona> FiltrarPorSexo(string sexo)
        {
            return personas.Where(p => p.Sexo.Equals(sexo)).ToList();
        }



        public Persona BuscarIdentificacion(string identificacionbuscar)
        {
           
            return personas.Find(p => p.Identificacion.Equals(identificacionbuscar));

        }

        public void Eliminar(string identificacion)
        {
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "DELETE FROM TBpersona WHERE identificacion=@identificacion";
                comando.Parameters.AddWithValue("@Identificacion", identificacion);
            
                comando.ExecuteNonQuery();
                
            }

        }

        public Persona Map(SqlDataReader reader)
        {
            Persona persona = new Persona();
            persona.Identificacion = (string)reader["Identificacion"];
            persona.Nombre = (string)reader["Nombre"];
            persona.Edad = (int)reader["Edad"];
            persona.Sexo = (string)reader["Sexo"];
            persona.Pulsacion =(decimal)reader["Pulsacion"];
            return persona;

        }




        public void Modificar(Persona persona)
        {
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "update TBpersona set identificacion=@Identificacion, nombre=@Nombre" +
                    "edad=@Edad, sexo=@sexo, pulsacion=@Pulsacion" +
                    "WHERE identificacion=@Identificacion";
                comando.Parameters.AddWithValue("@Identificacion", persona.Identificacion);
                comando.Parameters.AddWithValue("@Nombre", persona.Nombre);
                comando.Parameters.AddWithValue("@Edad", persona.Edad);
                comando.Parameters.AddWithValue("@Sexo", persona.Sexo);
                comando.Parameters.AddWithValue("@Pulsacion", persona.Pulsacion);
               // comando.Parameters.AddWithValue("@Email", persona.Email);
                comando.ExecuteNonQuery();
            }

        }



        public void GuardarDatos()
        {
            FileStream origen = new FileStream(rutaDatos, FileMode.Create);
            StreamWriter writer = new StreamWriter(origen);
            writer.WriteLine("TotalPersonas: " + TotalizarPersonas() + ";" + "TotalMujeres: " + TotalizarPersonasMujeres() + ";" + "TotalHombres: " + TotalizarPersonasHombres() + ";"
                + "SumaTotalPulsaciones: " + SumarPulsaciones() + ";" + "PulsacionesHombres: " + PulsacionesdeHombre() + ";" + "PulsacionesMujeres: " + PulsacionesdeMujeres());
            writer.Close();
            origen.Close();
        }

        public void GenerarArchivoSexo(string sexo)
        {
            List<Persona> personasSexo = FiltrarPorSexo(sexo);

            if (personasSexo.Count == 0)
            {
                return;
            }

            FileStream origenFlujo = new FileStream(("Datos" + sexo + ".txt"), FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter escritor = new StreamWriter(origenFlujo);
            escritor.WriteLine($"Total {sexo}S: {personasSexo.Count};Suma Pulsaciones de {sexo}S: {personasSexo.Sum(sp => sp.Pulsacion)} ");
            escritor.Close();
            origenFlujo.Close();
        }

        public int TotalizarPersonas()
        {
            return personas.Count();
        }
        public int TotalizarPersonasMujeres()
        {
            return personas.Count(pm => pm.Sexo.Equals("FEMENINO"));
        }
        public int TotalizarPersonasHombres()
        {
            return personas.Count(pm => pm.Sexo.Equals("MASCULINO"));
        }
        public int TotalizarPersonasTipo(string tipo)
        {
            return personas.Count(pm => pm.Sexo.Equals(tipo));
        }
        public decimal SumarPulsaciones()
        {

            return personas.Sum(p => p.Pulsacion);
        }
        public decimal PulsacionesdeHombre()
        {
            return personas.Where(p => p.Sexo.Equals("MASCULINO")).Sum(p => p.Pulsacion);
        }
        public decimal PulsacionesdeMujeres()
        {
            return personas.Where(p => p.Sexo.Equals("FEMENINO")).Sum(p => p.Pulsacion);
        }

    }
}
