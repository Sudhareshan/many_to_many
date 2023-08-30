using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManyToMany.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyEmpProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employes",
                columns: table => new
                {
                    EmployeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employes", x => x.EmployeId);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeProject",
                columns: table => new
                {
                    employesEmployeId = table.Column<int>(type: "int", nullable: false),
                    projectsProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeProject", x => new { x.employesEmployeId, x.projectsProjectId });
                    table.ForeignKey(
                        name: "FK_EmployeProject_employes_employesEmployeId",
                        column: x => x.employesEmployeId,
                        principalTable: "employes",
                        principalColumn: "EmployeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeProject_projects_projectsProjectId",
                        column: x => x.projectsProjectId,
                        principalTable: "projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeProject_projectsProjectId",
                table: "EmployeProject",
                column: "projectsProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeProject");

            migrationBuilder.DropTable(
                name: "employes");

            migrationBuilder.DropTable(
                name: "projects");
        }
    }
}
