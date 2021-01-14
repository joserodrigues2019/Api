using Api.Database.Models;
using Api.Database.Repositories;
using System;
using System.Collections.Generic;

namespace Api.BussinesLogic
{
    public class ContasPagarBll : IContasPagarBll
    {
        private readonly IContasPagarRepository _contasPagarRepository;
        private string regraDiasAtraso;
        private string  Multa;
        private string JurosDia;

        public ContasPagarBll(IContasPagarRepository contasPagarRepository)
        {
            _contasPagarRepository = contasPagarRepository;
        }

        public IEnumerable<ContasPagarEntity> Listar()
        {
            return  _contasPagarRepository.Listar();
        }

        public string Incluir(ContasPagarEntity contasPagar)
        {
            try
            {
                if (contasPagar.Nome == string.Empty)
                {
                    throw new System.Exception("Nome não pode ser em branco");
                }
                else if (contasPagar.ValorOriginal.ToString() == string.Empty)
                {
                    throw new System.Exception("Valor Original não pode ser em branco");
                }
                else if (string.IsNullOrEmpty(contasPagar.DataVencimento.ToString()))
                {
                    throw new System.Exception("Data de Vencimento não pode ser em branco");
                }
                else if (string.IsNullOrEmpty(contasPagar.DataPagamento.ToString()))
                {
                    throw new System.Exception("Data de Pagamento não pode ser em branco");
                }
                else if (string.IsNullOrEmpty(contasPagar.ValorCorrigido.ToString()))
                {
                    throw new System.Exception("Valor Corrigido não pode ser em branco");
                }
                else if (string.IsNullOrEmpty(contasPagar.QuantidadeDiasAtraso.ToString()))
                {
                    throw new System.Exception("Quantidade de Dias em Atraso não pode ser em branco");
                }
                else
                {
                    if (VerificarContaAtraso(contasPagar.DataVencimento, contasPagar.DataPagamento))
                    {
                        var qtdDiasAtraso = CalcularDiasAtraso(contasPagar.DataVencimento, contasPagar.DataPagamento);
                        var valorComAtraso = CalcularValorAtraso(contasPagar.ValorOriginal, qtdDiasAtraso);

                        contasPagar.QuantidadeDiasAtraso = qtdDiasAtraso;
                        contasPagar.ValorCorrigido = valorComAtraso;

                        //Persistir a regra para o calculo
                        contasPagar.DiasEmAtraso = regraDiasAtraso;
                        contasPagar.Multa = Multa;
                        contasPagar.JurosDia = JurosDia;

                    }

                     _contasPagarRepository.Add(contasPagar);

                    return "[ Registro Salvo !! ]";
                }

            }
            catch (Exception msgError)
            {

                return msgError.Message.ToString();
            }
        }

        private bool VerificarContaAtraso(DateTime dataVencimento, DateTime dataPagamento)
        {
            bool temAtraso;

            // Regra: Quando a data de vencimento for menor ou igual a data do dia corrente
            // verificar qual quando foi feito o pagamento pela data de pagamento

            if ( dataVencimento <= DateTime.Now &&
                dataPagamento > dataVencimento)
            {
                temAtraso = true;
            }
            else
            {
                temAtraso = false;
            }

            return temAtraso;
        }

        private int CalcularDiasAtraso(DateTime data1, DateTime data2)
        {
            TimeSpan calculoDatas = (data2 - data1);

            return calculoDatas.Days;
        }

        private Decimal CalcularValorAtraso(Decimal valorDoc, int qtDiasAtraso)
        {
            // Exemplo de calculo:
            //Juros de 1 % ao mês 30 dias = 0,033 % ao dia
            //0,033 % ao dia x 10 dias de atraso = 0,33 %
            //500,00 x 0,33 % = 1,65
            //Valor cobrado por dez dias de atraso(valor do boleto + multa) = R$ 501,65.

            //R$ 500,00(valor do boleto) +R$ 10,00(valor da multa) + 1,65(valor dos juros por atraso) = 
            // R$ 511,65 valor final cobrado.
            int percentualMulta;
            double percetualJurosMes;
            double resultCalculo;

            //Regras

            if (qtDiasAtraso > 0 && qtDiasAtraso <= 3) // ate 3 dias
            {
                percentualMulta = 2;
                percetualJurosMes = 0.1;
                
                // regras para o calculo
                regraDiasAtraso = "até 3 dias";
                Multa = "2%";
                JurosDia = "0,1%";

            }
            else if (qtDiasAtraso > 3 && qtDiasAtraso < 5) // > 3 dias
            {
                percentualMulta = 3;
                percetualJurosMes = 0.2;

                // regras para o calculo
                regraDiasAtraso = "superior a 3 dias";
                Multa = "2%";
                JurosDia = "0,1%";
            }
            else  // > 5 dias
            {
               
                percentualMulta = 5;
                percetualJurosMes = 0.3;

                // regras para o calculo
                regraDiasAtraso = "superior a 5 dias";
                Multa = "2%";
                JurosDia = "0,1%";
            }

            // Aplicar Calculo
            var valorMulta = (valorDoc * percentualMulta) / 100;
            var percentualJurosDia = (percetualJurosMes / 30) * qtDiasAtraso;
            var valorJurosDia = ((double)valorDoc * percentualJurosDia) / 100;

            resultCalculo = Math.Round(((double)valorDoc + (double)valorMulta + valorJurosDia), 2);


            return Decimal.Parse(resultCalculo.ToString());
        }
    }
}
