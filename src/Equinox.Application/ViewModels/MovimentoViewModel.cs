namespace Equinox.Application.ViewModels
{
    public class MovimentoViewModel
    {
        public string evento { get; set; }
        public MovimentoTargetViewModel target { get; set; }
        public MovimentoOriginViewModel origin { get; set; }
        public decimal amount { get; set; }
        public int usuarioId { get; set; }
    }
}
