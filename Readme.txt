Requisitos para executar o serviço da API e os testes - 26/01/2021 teste

Softwares:
Visual Studio 2019 Community
Sql Server 2019 Express

criar o Banco de Dados: dbAPI
executar o script do banco que está no Git

Compilar o Projeto no visual studio

Tests da API : PostMan

exemplo: Usando tipo JSON

GET : https://localhost:44349/ContasPagar

Resultado:

[
    {
        "idConta": 1,
        "nome": "JOSE RODRIGUES",
        "valorOriginal": 15.00,
        "dataVencimento": "2021-02-26T00:00:00",
        "dataPagamento": "2021-03-13T00:00:00",
        "valorCorrigido": 16.00,
        "quantidadeDiasAtraso": 0,
        "diasEmAtraso": null,
        "multa": null,
        "jurosDia": null
    }
]

POST : https://localhost:44349/ContasPagar
Resultado
{
    "nome": "Cliente Teste",
    "valorOriginal": 10.30,
    "dataVencimento": "2021-01-13T00:00:00",
    "dataPagamento": "2021-01-16T00:00:00",
    "valorCorrigido": 10.20,
    "quantidadeDiasAtraso": 0,
    "diasEmAtraso": null,
    "multa": null,
    "jurosDia": null
}