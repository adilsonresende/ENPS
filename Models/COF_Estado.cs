namespace ENPS.Models
{
    public class COF_estado
    {
        public int Id { get; set; }
        public bool Ativo { get; set; } = true;
        public string Nome { get; set; }
        public COF_pais COF_pais { get; set; }
    }
}