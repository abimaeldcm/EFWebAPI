using System.Collections.Generic;

namespace EFWebAPI.Model
{
    public class Heroi
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IdentidadeSecreta Identidade { get; set; }
        public List<Arma> Armas { get; set; }
        public List<HeroiBatalha> HeroiBatalha { get; set; }
        public int BatalhaId { get; set; }
    }
}
