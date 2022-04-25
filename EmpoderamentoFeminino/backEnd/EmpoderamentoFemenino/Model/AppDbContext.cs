using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpoderamentoFemenino.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<EmpoderamentoFeminino> EmpoderamentoFeminino { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmpoderamentoFeminino>()
                .Property(c => c.Nome).HasMaxLength(100);
            modelBuilder.Entity<EmpoderamentoFeminino>()
               .Property(c => c.Descricao).HasMaxLength(3000);
            modelBuilder.Entity<EmpoderamentoFeminino>()
               .Property(c => c.Site).HasMaxLength(150);
            modelBuilder.Entity<EmpoderamentoFeminino>()
               .Property(c => c.Url).HasMaxLength(150);


            modelBuilder.Entity<EmpoderamentoFeminino>()
                .HasData(
                new EmpoderamentoFeminino { Id = 1, Nome = "Django Girls", Descricao = "Django Girls é uma organização sem fins lucrativos e uma comunidade que capacita e ajuda mulheres a organizar oficinas de programação gratuitas de um dia, fornecendo ferramentas, recursos e suporte. Somos uma organização gerida por voluntários com centenas de pessoas contribuindo para trazer mais mulheres incríveis para o mundo da tecnologia. Estamos tornando a tecnologia mais acessível criando recursos projetados com empatia.Durante cada um dos nossos eventos, 30-60 mulheres constroem sua primeira aplicação web usando HTML, CSS, Python e Django.", Site = "https://djangogirls.org/pt/", Url = "https://www.youtube.com/watch?v=o0VZaM91DYI" },
                 new EmpoderamentoFeminino { Id = 2, Nome = "Minas Programam", Descricao = "O Minas Programam é uma iniciativa criada em 2015 para desafiar os estereótipos de gênero e de raça que influenciam nossa relação com as áreas de ciências, tecnologia e computação.Promovemos oportunidades de aprendizado sobre programação para meninas e mulheres, priorizando àquelas que são negras ou indígenas.", Site = "https://minasprogramam.com/", Url = "https://www.youtube.com/channel/UCIXBQxnLSfGzNqG-AtsjDxQ" },
                  new EmpoderamentoFeminino { Id = 3, Nome = "PyLadies", Descricao = "O PyLadies é uma comunidade mundial que foi trazida ao Brasil com o propósito de instigar mais mulheres a entrarem na área tecnológica. Queremos mudar essa realidade de poucas garotas em uma área tão rica e fantástica como a computação. E olhe que temos muita história nesse campo, viu?!", Site = "http://brasil.pyladies.com/about/", Url = "https://www.youtube.com/c/BrazilPyLadies" },
                  new EmpoderamentoFeminino { Id = 4, Nome = "Reprograma", Descricao = "A {reprograma} é uma iniciativa de impacto social que foca em ensinar programação para mulheres cis e trans que não têm recursos e/ou oportunidades para aprender a programar.", Site = "https://www.reprograma.com.br/", Url = "https://www.youtube.com/c/reprogramabr" },
                   new EmpoderamentoFeminino { Id = 5, Nome = "WoMakersCode", Descricao = "Somos uma instituição sem fins lucrativos, com a missão de inspirar e impulsionar meninas e mulheres que desejam ingressar ou se especializar em carreiras ligadas à tecnologia e inovação (STEM).Desde 2015, lideramos uma série de iniciativas de capacitação, mentoria, empregabilidade e conteúdos digitais e alcançamos mais de 200 mil mulheres no Brasil, Chile e América do Norte.", Site = "https://womakerscode.org/", Url = "https://www.youtube.com/c/WoMakersCode" });
        }
    }
}
