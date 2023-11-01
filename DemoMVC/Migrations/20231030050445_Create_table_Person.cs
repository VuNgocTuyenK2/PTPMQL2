using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoMVC.Migrations
{
    /// <inheritdoc /> Vu Ngoc Tuyen 2021050715
    public partial class Create_table_Person : Migration
    {
        /// <inheritdoc /> Vu Ngoc Tuyen 2021050715
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",//Vu Ngoc Tuyen 2021050715
                columns: table => new
                {
                    PersonID = table.Column<int>(type: "INTEGER", nullable: false)//Vu Ngoc Tuyen 2021050715
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", nullable: false)//Vu Ngoc Tuyen 2021050715
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonID);//Vu Ngoc Tuyen 2021050715
                });
        }

        /// <inheritdoc /> Vu Ngoc Tuyen 2021050715
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");//Vu Ngoc Tuyen 2021050715
        }
    }
}
