using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmpoderamentoFemenino.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EmpoderamentoFeminino",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(3000)", maxLength: 3000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Site = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Url = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpoderamentoFeminino", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "EmpoderamentoFeminino",
                columns: new[] { "Id", "Descricao", "Nome", "Site", "Url" },
                values: new object[,]
                {
                    { 1, "Django Girls é uma organização sem fins lucrativos e uma comunidade que capacita e ajuda mulheres a organizar oficinas de programação gratuitas de um dia, fornecendo ferramentas, recursos e suporte. Somos uma organização gerida por voluntários com centenas de pessoas contribuindo para trazer mais mulheres incríveis para o mundo da tecnologia. Estamos tornando a tecnologia mais acessível criando recursos projetados com empatia.Durante cada um dos nossos eventos, 30-60 mulheres constroem sua primeira aplicação web usando HTML, CSS, Python e Django.", "Django Girls", "https://djangogirls.org/pt/", "https://www.youtube.com/watch?v=o0VZaM91DYI" },
                    { 2, "O Minas Programam é uma iniciativa criada em 2015 para desafiar os estereótipos de gênero e de raça que influenciam nossa relação com as áreas de ciências, tecnologia e computação.Promovemos oportunidades de aprendizado sobre programação para meninas e mulheres, priorizando àquelas que são negras ou indígenas.", "Minas Programam", "https://minasprogramam.com/", "https://www.youtube.com/channel/UCIXBQxnLSfGzNqG-AtsjDxQ" },
                    { 3, "O PyLadies é uma comunidade mundial que foi trazida ao Brasil com o propósito de instigar mais mulheres a entrarem na área tecnológica. Queremos mudar essa realidade de poucas garotas em uma área tão rica e fantástica como a computação. E olhe que temos muita história nesse campo, viu?!", "PyLadies", "http://brasil.pyladies.com/about/", "https://www.youtube.com/c/BrazilPyLadies" },
                    { 4, "A {reprograma} é uma iniciativa de impacto social que foca em ensinar programação para mulheres cis e trans que não têm recursos e/ou oportunidades para aprender a programar.", "Reprograma", "https://www.reprograma.com.br/", "https://www.youtube.com/c/reprogramabr" },
                    { 5, "Somos uma instituição sem fins lucrativos, com a missão de inspirar e impulsionar meninas e mulheres que desejam ingressar ou se especializar em carreiras ligadas à tecnologia e inovação (STEM).Desde 2015, lideramos uma série de iniciativas de capacitação, mentoria, empregabilidade e conteúdos digitais e alcançamos mais de 200 mil mulheres no Brasil, Chile e América do Norte.", "WoMakersCode", "https://womakerscode.org/", "https://www.youtube.com/c/WoMakersCode" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpoderamentoFeminino");
        }
    }
}
