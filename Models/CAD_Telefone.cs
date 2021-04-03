using System.Collections.Generic;

namespace ENPS.Models
{
    public class CAD_Telefone
    {
        public long Id { get; set; }
        public bool Ativo { get; set; }
        public bool Princial { get; set; }
        public int CodigoPais { get; set; }
        public int CodigoEstado { get; set; }
        public int Numero { get; set; }
        public List<CAD_empresa> CAD_Empresa { get; set; }
        public List<CAD_pessoa> CAD_Pessoa { get; set; }
    }
}