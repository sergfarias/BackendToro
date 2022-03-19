using Equinox.Domain.Core.Models;

namespace Equinox.Domain.Models
{
    public class TipoAnimal : Enumeration<TipoAnimal>
    {

        public static readonly TipoAnimal Cao = new TipoAnimal(1, "Cão");
        public static readonly TipoAnimal Gato = new TipoAnimal(2, "Gato");
        public static readonly TipoAnimal Hamsters = new TipoAnimal(3, "Hamster");

        protected TipoAnimal(int id, string nome)
            :base(id,nome)
        { }

    }
}