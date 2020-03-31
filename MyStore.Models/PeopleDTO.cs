using System;
using System.Collections.Generic;

namespace MyStore.Models
{
    public partial class PeopleDTO
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
    }
}