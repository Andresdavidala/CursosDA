using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CursosDA.Migrations
{
    /// <inheritdoc />
    public partial class addProfesorIdColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Profesor_ProferorIdProfesor",
                table: "Cursos");

            migrationBuilder.RenameColumn(
                name: "ProferorIdProfesor",
                table: "Cursos",
                newName: "ProfesorId");

            migrationBuilder.RenameIndex(
                name: "IX_Cursos_ProferorIdProfesor",
                table: "Cursos",
                newName: "IX_Cursos_ProfesorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Profesor_ProfesorId",
                table: "Cursos",
                column: "ProfesorId",
                principalTable: "Profesor",
                principalColumn: "IdProfesor",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Profesor_ProfesorId",
                table: "Cursos");

            migrationBuilder.RenameColumn(
                name: "ProfesorId",
                table: "Cursos",
                newName: "ProferorIdProfesor");

            migrationBuilder.RenameIndex(
                name: "IX_Cursos_ProfesorId",
                table: "Cursos",
                newName: "IX_Cursos_ProferorIdProfesor");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Profesor_ProferorIdProfesor",
                table: "Cursos",
                column: "ProferorIdProfesor",
                principalTable: "Profesor",
                principalColumn: "IdProfesor",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
