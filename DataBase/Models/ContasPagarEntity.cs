using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Database.Models
{
    [Table("ContasPagar")]
    public class ContasPagarEntity
    {
        [Key]
        [Column("id_conta")]
        public int IdConta { get; set; }

        [Column("nome")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Column("valor_original")]
        public Decimal ValorOriginal { get; set; }

        [Column("data_vencimento", TypeName = "DateTime")]
        public DateTime DataVencimento { get; set; }

        [Column("data_pagamento", TypeName = "DateTime")]
        public DateTime DataPagamento { get; set; }

        [Column("valor_corrigido")]
        public Decimal ValorCorrigido { get; set; }

        [Column("qtde_dias_atraso")]
        public int QuantidadeDiasAtraso { get; set; }

        [Column("dias_atraso")]
        [StringLength(20)]
        public string DiasEmAtraso { get; set; }

        [Column("multa")]
        [StringLength(5)]
        public string Multa { get; set; }

        [Column("juros_dia")]
        [StringLength(5)]
        public string JurosDia { get; set; }

    }
}
