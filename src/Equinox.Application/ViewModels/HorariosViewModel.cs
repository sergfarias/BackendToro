using System;
using System.ComponentModel.DataAnnotations;

namespace Equinox.Application.ViewModels
{
    public class HorariosViewModel
    {
        [Key]
        public int id { get; set; }
        public int veterinarioid { get; set; }
        public string veterinarionome { get; set; }
        public bool geriatra { get; set; }
        public string horario { get; set; }
        public DateTime horini { get; set; }
        public DateTime horfim { get; set; }
        public int intervalo { get; set; }
    }
}
