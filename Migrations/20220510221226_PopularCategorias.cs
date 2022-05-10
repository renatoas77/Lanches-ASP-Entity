using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteLanches.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO categorias(CategoriaNome, Descricao) VALUES ('Normal','Lanche feito com ingredientes normais')");

            migrationBuilder.Sql("INSERT INTO categorias(CategoriaNome, Descricao) VALUES ('Natural','Lanche feito com ingredientes naturais ou integrais')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE from categorias");
        }
    }
}
