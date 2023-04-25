using Microsoft.AspNetCore.Mvc;
using BlazorPWA.Shared;

namespace Server.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjectController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Project> Get()
    {
        var values = new List<Project>
        {
            new Project
            {
                Name = "Api ShopBridge",
                Description="Esse projeto foi feito como parte de um desafio da ThinkBridge."+
                            "A API foi escrita em C# e inclui: CRUD para gerenciar produtos em um shopping online."+
                            "ORM Entity Framework"+
                            "Autenticação e autorização com JWT."+
                            "Documentação do Swagger para fácil exploração e teste de API."+
                            "Segue os princípios de design da API RESTful."+
                            "Utiliza as melhores práticas para desenvolvimento .NET, incluindo injeção de dependência, acesso a dados com Entity Framework Core e tratamento de exceções.",
                Link="https://github.com/ArielLopes888/API_ShopBridge"
            },
            new Project
            {
                Name="Api Robusta + Deploy no Azure",
                Description="Aprendendo a construir uma API robusta e moderna utilizando .NET. Curso do Lucas Eschechola"+
                            "A API foi escrita em C# e inclui: CRUD"+
                            "ORM Entity Framework"+
                            "Autenticação e autorização com JWT."+
                            "Documentação do Swagger para fácil exploração e teste de API."+
                            "Segue os princípios de design da API RESTful."+
                            "Utiliza as melhores práticas para desenvolvimento .NET, incluindo injeção de dependência, acesso a dados com Entity Framework Core e tratamento de exceções.",
                Link="https://github.com/ArielLopes888/API_ROBUSTA"
            },
            new Project
            {
                Name="Api Projeto Integrador",
                Description="Api feita para o projeto de conlusão do Curso Desenvolvedor Web Full Stack. "+
                "A api contém várias entidades e relacionamentos Muito para Muitos",
                Link="https://github.com/ArielLopes888/API.NET-Projeto-Integrador"
            },
            new Project
            {
                Name="Cadastro de Voluntários da Congregação",
                Description="...",
                Link="https://github.com/ArielLopes888/Cadastro-de-Voluntarios-da-Congregacao"
            },
            new Project
            {
                Name="Este Portfólio",
                Description="Portfólio feito com Blazor. Tecnologias usadas: C# .Net, Sintaxe Razor, Html e Css. "+
                            "Este projeto está dividido em 3 camadas: "+
                            "-Camada do Cliente (Client): Responsável pela interface do usuário. O código nesta camada é executado no navegador do usuário. "+
                            "-Camada Compartilhada (Shared): Contém o código que é compartilhado entre o cliente e o servidor. Nesse projeto contém as Entidades. "+
                            "-Camada do Servidor (Server): Responsável por processar as solicitações do cliente e executar a lógica do aplicativo. O código nesta camada é executado no servidor e é usado para acessar bancos de dados (Nesse projeto, as controllers retornam dados mocados para o client).",
                Link="https://github.com/ArielLopes888/BlazorPWA"
            },
            new Project
            {
                Name="Python Bot Whatsapp",
                Description="Envio automatizado de mensagens em massa no whatsapp."+
                             "Tecnologias utilizadas: Python, Pandas, Selenium.",
                Link="https://github.com/ArielLopes888/Automacao_Whatsapp_Python"
            },
            new Project
            {
                Name="Automação Análise de Dados ",
                Description="Envio automatizado de e-mails em massa e análise e manipulação de dados; "+
                            "Tecnologias utilizadas: Python, Pandas, Pyautogui",
                Link="https://github.com/ArielLopes888/AnaliseDados_Automacao_Python"
            },
        };
        return values;
    }

}
