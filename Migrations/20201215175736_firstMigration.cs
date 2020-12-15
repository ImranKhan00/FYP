using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FYP.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cures",
                columns: table => new
                {
                    CureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cures", x => x.CureId);
                });

            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    DiseaseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.DiseaseId);
                });

            migrationBuilder.CreateTable(
                name: "Precautions",
                columns: table => new
                {
                    PrecautionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Precautions", x => x.PrecautionId);
                });

            migrationBuilder.CreateTable(
                name: "Symptoms",
                columns: table => new
                {
                    SymtomsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symptoms", x => x.SymtomsId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "DiseaseCures",
                columns: table => new
                {
                    DiseaseCureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiseaseId = table.Column<int>(nullable: true),
                    CureId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseCures", x => x.DiseaseCureId);
                    table.ForeignKey(
                        name: "FK_DiseaseCures_Cures_CureId",
                        column: x => x.CureId,
                        principalTable: "Cures",
                        principalColumn: "CureId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiseaseCures_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "DiseaseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DiseasePrecautions",
                columns: table => new
                {
                    DiseasePrecautionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiseaseId = table.Column<int>(nullable: true),
                    PrecautionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseasePrecautions", x => x.DiseasePrecautionId);
                    table.ForeignKey(
                        name: "FK_DiseasePrecautions_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "DiseaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiseasePrecautions_Precautions_PrecautionId",
                        column: x => x.PrecautionId,
                        principalTable: "Precautions",
                        principalColumn: "PrecautionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DiseaseSymptoms",
                columns: table => new
                {
                    DiseaseSymptomsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiseaseId = table.Column<int>(nullable: true),
                    SymptomsSymtomsId = table.Column<int>(nullable: true),
                    Severity = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseSymptoms", x => x.DiseaseSymptomsId);
                    table.ForeignKey(
                        name: "FK_DiseaseSymptoms_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "DiseaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiseaseSymptoms_Symptoms_SymptomsSymtomsId",
                        column: x => x.SymptomsSymtomsId,
                        principalTable: "Symptoms",
                        principalColumn: "SymtomsId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Diagnoses",
                columns: table => new
                {
                    DiagnosisId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    MyProperty = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnoses", x => x.DiagnosisId);
                    table.ForeignKey(
                        name: "FK_Diagnoses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diagnoses_UserId",
                table: "Diagnoses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseCures_CureId",
                table: "DiseaseCures",
                column: "CureId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseCures_DiseaseId",
                table: "DiseaseCures",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseasePrecautions_DiseaseId",
                table: "DiseasePrecautions",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseasePrecautions_PrecautionId",
                table: "DiseasePrecautions",
                column: "PrecautionId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseSymptoms_DiseaseId",
                table: "DiseaseSymptoms",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseSymptoms_SymptomsSymtomsId",
                table: "DiseaseSymptoms",
                column: "SymptomsSymtomsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diagnoses");

            migrationBuilder.DropTable(
                name: "DiseaseCures");

            migrationBuilder.DropTable(
                name: "DiseasePrecautions");

            migrationBuilder.DropTable(
                name: "DiseaseSymptoms");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cures");

            migrationBuilder.DropTable(
                name: "Precautions");

            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "Symptoms");
        }
    }
}
