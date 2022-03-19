using Equinox.Domain.Core.Models;

namespace Equinox.Domain.Models
{
    public class IdadeAnimalIdoso : Enumeration<IdadeAnimalIdoso>
    {

        public static readonly IdadeAnimalIdoso CaoGato = new IdadeAnimalIdoso(7, "CãoeGato");
        public static readonly IdadeAnimalIdoso Hamster = new IdadeAnimalIdoso(3, "Hamster");

        protected IdadeAnimalIdoso(int id, string nome)
            :base(id,nome)
        { }

    }
}