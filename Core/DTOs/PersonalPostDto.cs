using System;

namespace Core.DTOs
{
    public class PersonalPostDto
    {
        public string Nombre { get; set; }
        public string Empresa { get; set; }
        public string Placas { get; set; }
        public string Atencion { get; set; }
        public string Temperatura { get; set; }
        public string Poliza { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
    }
}
