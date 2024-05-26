using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudMvc.Migrations
{
    public partial class AlteracaoEmColunasDeEscolaNoDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoEscola",
                table: "Escola",
                newName: "Tipo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Escola",
                newName: "TipoEscola");
        }
    }
}
