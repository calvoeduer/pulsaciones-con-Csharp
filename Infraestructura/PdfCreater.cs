using Entity;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.IO;

namespace Infraestructura
{
    public class PdfCreater
    {
        private string ruta = @"PDFTABLAS.pdf";
        public void GuardarPdf(List<Persona> personas)
        {
            FileStream origenFlujlo = new FileStream(ruta, FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 40, 40, 40, 40);
            PdfWriter pdfescritor = PdfWriter.GetInstance(document, origenFlujlo);

            document.AddTitle("Archivos Generados");
            document.AddCreator("Eduer Calvo");

            document.Open();
            document.Add(new Paragraph("Reporte de usuarios"));
            document.Add(new Paragraph("                            "));
            document.Add(LlenarTabla(personas));
            document.Close();

            document.Close();


        }

        private PdfPTable LlenarTabla(List<Persona> personas)
        {
            PdfPTable tabla = new PdfPTable(5);
            tabla.AddCell(new Paragraph("Identificacion"));
            tabla.AddCell(new Paragraph("Nombre"));
            tabla.AddCell(new Paragraph("Edad"));
            tabla.AddCell(new Paragraph("Sexo"));
            tabla.AddCell(new Paragraph("Pulsacion"));

            foreach (var item in personas)
            {
                tabla.AddCell(item.Identificacion);
                tabla.AddCell(item.Nombre);
                tabla.AddCell(item.Edad.ToString());
                tabla.AddCell(item.Sexo);
                tabla.AddCell(item.Pulsacion.ToString());

            }
            return tabla;
        }

    }
}
