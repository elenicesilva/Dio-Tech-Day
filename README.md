# Projeto Dio-Tech-Day
Repositório para envio de projeto sobre empoderamento feminino Tech Day

# Organização
O projeto  começa na pasta Dio-Tech-Day nela têm a pasta EmpoderamentoFeminino
que dentro fica divido em pasta o frontEnd e o BackEnd

    # frontEnd:
    Solução com uma unica pagina feita em JavaScript 
    .Jquery, Bootstrap e FecthAPi

    # backEnd:
    Solução de uma Api Rest com .Net Core 5 persistindo dados com MySql e disponibilização da Swagger da Api

# Tutorial para montar ambiente Local

    Pré-Requisito: 
        .Microsoft Visual Studio com Dot Net Core 5
        .MySql instalado justamente com um Gereciador de banco de Dados Ex: WorkBenchMySql
        .NPM instalado Globalmente
        .Navegador de Internet Instalado Ex: Google Ghrommer
        .Visual Studio Code instalado
        .Git e GitBash instalados
        .Conhecimento de Git

    1º No GitBash clona o projeto que esta no Github para uma pasta local de sua escolha no seu computador
    2º Para rodar a Api no Backend, com o Microsoft Visual Studio abrir o projeto que fica
        ...\Dio-Tech-Day\EmpoderamentoFeminino\backEnd\EmpoderamentoFemenino.sln
        No Visual Studio abrir a console do Nuget e rodar os comandos
        migration
        Em seguida rodar o outro comando
        update-database

        Alterar a StringConection no aquivo appsettings.json dentro do projeto com os dado de user e password do seu banco 
        No menu, clicar na aba Build e na opção Build Solution em seguida Rodar a APi clicando no botão PLAY no Microsoft Visual Studio

        Visualizar o sistema abrir uma aba no navegador com uma url LocalHost da Swaagger da Api
    

    3º Abrir a pasta do FrontEnd com o Visual Studio Code
        ...\Dio-Tech-Day\EmpoderamentoFeminino\frontEnd
        Abrir a linha de comando no Visual Studio Code e rodar o Comando npm install
        Com a Api rodando no Microsoft Visual Studio, na pasta \frontEnd clicar no arquivo index.html para abrir no navegador de internet

    4º No navegador é possivel ver a interface FrontEnd com o usuario comunicando com a Api.


# Descrição do FrontEnd
  Página única com um Carrossel de Empoderamento Feminino e abaixo um botão para um modal
  que contêm um CRUD.
    
# Feito por Elenice Aparecida Silva