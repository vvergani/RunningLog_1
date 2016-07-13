using SQLite.Net.Attributes

namespace RunningLogDbModel.Model
{
    public class Shoes
    {   
        [PrimaryKey]
        public int ShoesId { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int Peso { get; set; }
        public decimal DurataPrevista { get; set; }
        

    }
}
