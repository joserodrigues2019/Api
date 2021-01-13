using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.DataAcess.Entities
{
    [Table("ContasPagar")]
    public class ContasPagarEntity
    {
        [Key]
        public int IdConta { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        public Decimal ValorOriginal { get; set; }

        [Column("DataVencimento", TypeName = "DateTime")]
        public DateTime DataVencimento { get; set; }

        [Column("DataPagamento", TypeName = "DateTime")]
        public DateTime DataPagamento { get; set; }

        public Decimal ValorCorrigido { get; set; }

        public int QuantidadeDiasAtraso { get; set; }

    }
}
