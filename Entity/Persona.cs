using System.Net.Mail;
namespace Entity
{
    public class Persona
    {

        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public decimal Pulsacion { get; set; }
        public string Email { get; set; }



        public void CalcularPulsacion()
        {

            if (Sexo.Equals("FEMENINO"))
            {
                Pulsacion = (210 - Edad) / 10;


            }
            else if (Sexo.Equals("MASCULINO"))
            {
                Pulsacion = (220 - Edad) / 10;
            }
            else
            {
                Pulsacion = 0;
            }


        }


        public override string ToString()
        {
            return $" Identificacion: {Identificacion}    Nombre:{Nombre}      Edad {Edad}     Sexo {Sexo}     pulsacion {Pulsacion} ";
        }
    }
}
