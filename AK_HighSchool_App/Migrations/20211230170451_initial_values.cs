using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AK_HighSchool_App.Migrations
{
    public partial class initial_values : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    studentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentFirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    studentLastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    userName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    studentAge = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.studentID);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    subjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<int>(type: "int", nullable: false),
                    GraphicDesign = table.Column<int>(type: "int", nullable: true),
                    WebbDevelopment = table.Column<int>(type: "int", nullable: true),
                    Programming = table.Column<int>(type: "int", nullable: true),
                    DataBase = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.subjectID);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    teacherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teacherFirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    teacherLastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    teacherAge = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.teacherID);
                });

            migrationBuilder.CreateTable(
                name: "Relations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentIDFK = table.Column<int>(type: "int", nullable: false),
                    teacherIDFK = table.Column<int>(type: "int", nullable: false),
                    subjectIDFK = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    StudyType = table.Column<int>(type: "int", nullable: false),
                    GPA = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Relations_Students_studentIDFK",
                        column: x => x.studentIDFK,
                        principalTable: "Students",
                        principalColumn: "studentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Relations_Subjects_subjectIDFK",
                        column: x => x.subjectIDFK,
                        principalTable: "Subjects",
                        principalColumn: "subjectID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Relations_Teachers_teacherIDFK",
                        column: x => x.teacherIDFK,
                        principalTable: "Teachers",
                        principalColumn: "teacherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "studentID", "Gender", "email", "password", "studentAge", "studentFirstName", "studentLastName", "userName" },
                values: new object[,]
                {
                    { 1, 0, "Anderss@gmail.com", "AndG1234", 48, "Anderss", "Gappi", "AnderssG" },
                    { 2, 1, "maria@gmail.com", "MarE1234", 42, "Maria", "Erik", "MariaK" },
                    { 3, 1, "Anna@gmail.com", "AnaL1234", 38, "Anna", "Lars", "AnnaL" },
                    { 4, 1, "Christina@gmail.com", "ChrP1234", 29, "Christina", "Peter", "ChristinaP" },
                    { 5, 0, "Johan@gmail.com", "JuhG1234", 52, "Johan", "Gunner", "JuhanG" },
                    { 6, 0, "Oskar@gmail.com", "OskM1234", 33, "Oskar", "Michal", "OskarM" },
                    { 7, 0, "Erik@gmail.com", "EriB1234", 32, "Erik", "Bjork", "ErikB" },
                    { 8, 1, "Camilla@gmail.com", "CamN234", 26, "Kamilla", "Nystrom", "Camilla" },
                    { 9, 1, "Eva@gmail.com", "EvaE1234", 24, "Eva", "Eriksson", "EvaE" },
                    { 10, 0, "Carl@gmail.com", "CarlO1234", 30, "Carl", "Olsson", "CarlO" },
                    { 11, 0, "Marcus@gmail.com", "MarF1234", 41, "Marcus", "Fredrik", "Marcus" },
                    { 12, 1, "Lena@gmail.com", "LenaG1234", 34, "Lena", "Gunner", "LenaG" },
                    { 13, 1, "Hanna@gmail.com", "HanB1234", 38, "Hanna", "Bjorn", "HannaB" },
                    { 14, 0, "Robert@gmail.com", "RobA1234", 25, "Robert", "Ali", "RobertA" },
                    { 15, 0, "William@gmail.com", "JuhG1234", 36, "Johan", "Gunner", "JuhanG" },
                    { 16, 0, "Anderss@gmail.com", "WilH1234", 48, "William", "Hinrik", "WilliamH" },
                    { 17, 1, "Elsa@gmail.com", "ElsF1234", 23, "Elsa", "Forsberg", "ElsaF" },
                    { 18, 0, "Dan@gmail.com", "DanE1234", 29, "Dan", "Eklund", "DanE" },
                    { 19, 0, "David@gmail.com", "DavG1234", 35, "David", "Gunnel", "DavidG" },
                    { 20, 0, "Johan@gmail.com", "JuhG1234", 52, "Karolin", "Holm", "KarolinH" },
                    { 21, 1, "Emma@gmail.com", "EmmJ1234", 41, "Emma", "Johansson", "EmmaJ" },
                    { 22, 1, "Astrid@gmail.com", "AstL1234", 30, "Astrid", "Lars", "AstridL" },
                    { 23, 0, "Karl@gmail.com", "KarN1234", 37, "Karl", "Nils", "KarlN" },
                    { 24, 0, "Hans@gmail.com", "HanR1234", 36, "Hans", "Roberto", "HansR" },
                    { 25, 1, "Asa@gmail.com", "AsaS1234", 35, "Asa", "Sven", "AsaS" },
                    { 26, 0, "Per@gmail.com", "PerT1234", 43, "Per", "Tomas", "PerT" },
                    { 27, 1, "Kristin@gmail.com", "KrsT1234", 31, "Kristin", "Magnus", "KristinM" },
                    { 28, 0, "Fredrik@gmail.com", "FreS1234", 29, "Fredrik", "Simon", "FredrikS" },
                    { 29, 1, "Brigitta@gmail.com", "BigL1234", 51, "Brigitta", "Larsson", "BrigittaL" },
                    { 30, 0, "Filip@gmail.com", "FilA1234", 44, "Filip", "Anton", "FilipA" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "subjectID", "Category", "DataBase", "GraphicDesign", "Programming", "WebbDevelopment" },
                values: new object[,]
                {
                    { 1, 0, null, 0, null, null },
                    { 2, 0, null, 1, null, null },
                    { 3, 0, null, 2, null, null },
                    { 4, 1, null, null, null, 0 },
                    { 5, 1, null, null, null, 1 },
                    { 6, 1, null, null, null, 2 },
                    { 7, 2, null, null, 0, null },
                    { 8, 2, null, null, 1, null },
                    { 9, 2, null, null, 2, null },
                    { 10, 3, 0, null, null, null },
                    { 11, 3, 1, null, null, null },
                    { 12, 3, 2, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "teacherID", "Gender", "teacherAge", "teacherFirstName", "teacherLastName" },
                values: new object[,]
                {
                    { 1, 1, 44, "Helen", "Fredrik" },
                    { 2, 0, 38, "Peter", "Rolf" },
                    { 3, 0, 42, "Lars", "Johnsson" },
                    { 4, 0, 56, "Filip", "Niklas" },
                    { 5, 1, 36, "Emilla", "Gunner" }
                });

            migrationBuilder.InsertData(
                table: "Relations",
                columns: new[] { "ID", "GPA", "Level", "StudyType", "studentIDFK", "subjectIDFK", "teacherIDFK" },
                values: new object[,]
                {
                    { 1, 1, 2, 0, 1, 7, 3 },
                    { 2, 2, 1, 1, 1, 10, 3 },
                    { 3, 4, 0, 1, 2, 1, 1 },
                    { 4, 3, 1, 2, 2, 3, 1 },
                    { 5, 0, 2, 0, 3, 4, 2 },
                    { 6, 0, 1, 0, 3, 5, 2 },
                    { 7, 0, 0, 2, 3, 6, 2 },
                    { 8, 3, 1, 1, 4, 3, 1 },
                    { 9, 1, 2, 1, 5, 4, 2 },
                    { 10, 2, 1, 2, 6, 5, 2 },
                    { 11, 4, 0, 0, 7, 1, 1 },
                    { 12, 3, 1, 1, 8, 6, 2 },
                    { 13, 0, 2, 1, 10, 8, 4 },
                    { 14, 4, 1, 0, 10, 11, 4 },
                    { 15, 0, 0, 2, 11, 9, 5 },
                    { 16, 3, 1, 2, 11, 12, 5 },
                    { 17, 1, 2, 2, 12, 6, 3 },
                    { 18, 2, 1, 1, 12, 7, 3 },
                    { 19, 0, 0, 0, 12, 10, 3 },
                    { 20, 5, 1, 2, 13, 8, 5 },
                    { 21, 0, 2, 2, 13, 11, 5 },
                    { 22, 4, 1, 2, 14, 9, 5 },
                    { 23, 0, 0, 2, 14, 12, 5 },
                    { 24, 0, 0, 1, 15, 1, 1 },
                    { 25, 1, 1, 1, 15, 2, 1 },
                    { 26, 0, 0, 0, 15, 3, 1 },
                    { 27, 3, 1, 0, 16, 4, 2 },
                    { 28, 0, 2, 2, 16, 5, 2 },
                    { 29, 4, 1, 2, 16, 6, 2 },
                    { 30, 0, 0, 2, 17, 7, 3 },
                    { 31, 3, 1, 2, 18, 8, 4 },
                    { 32, 1, 1, 2, 19, 4, 2 },
                    { 33, 2, 1, 0, 19, 5, 2 },
                    { 34, 2, 0, 2, 20, 4, 2 },
                    { 35, 3, 1, 2, 20, 5, 2 },
                    { 36, 0, 2, 0, 20, 6, 2 },
                    { 37, 1, 1, 2, 20, 7, 3 },
                    { 38, 0, 0, 2, 20, 10, 3 },
                    { 39, 0, 0, 2, 21, 10, 3 },
                    { 40, 5, 1, 0, 21, 11, 4 },
                    { 41, 0, 0, 2, 21, 12, 5 },
                    { 42, 3, 1, 2, 22, 9, 5 }
                });

            migrationBuilder.InsertData(
                table: "Relations",
                columns: new[] { "ID", "GPA", "Level", "StudyType", "studentIDFK", "subjectIDFK", "teacherIDFK" },
                values: new object[,]
                {
                    { 43, 0, 2, 2, 22, 12, 5 },
                    { 44, 4, 1, 2, 23, 1, 1 },
                    { 45, 2, 0, 2, 23, 2, 1 },
                    { 46, 3, 1, 2, 23, 3, 1 },
                    { 47, 1, 1, 2, 24, 4, 1 },
                    { 48, 2, 1, 1, 24, 5, 1 },
                    { 49, 2, 0, 2, 24, 6, 1 },
                    { 50, 3, 1, 2, 25, 8, 2 },
                    { 51, 1, 2, 2, 25, 11, 2 },
                    { 52, 0, 1, 0, 26, 7, 4 },
                    { 53, 2, 0, 2, 26, 9, 4 },
                    { 54, 4, 1, 2, 27, 7, 3 },
                    { 55, 2, 0, 2, 27, 8, 3 },
                    { 56, 3, 1, 1, 27, 10, 4 },
                    { 57, 1, 1, 2, 27, 11, 4 },
                    { 58, 5, 1, 0, 27, 5, 1 },
                    { 59, 2, 0, 2, 28, 4, 2 },
                    { 60, 3, 1, 2, 28, 5, 2 },
                    { 61, 1, 2, 1, 28, 6, 2 },
                    { 62, 0, 1, 2, 28, 9, 5 },
                    { 63, 4, 0, 2, 28, 12, 5 },
                    { 64, 4, 1, 2, 29, 7, 3 },
                    { 65, 2, 0, 2, 29, 8, 3 },
                    { 66, 3, 1, 1, 30, 1, 1 },
                    { 67, 1, 1, 2, 30, 2, 1 },
                    { 68, 5, 1, 0, 30, 3, 1 },
                    { 69, 2, 0, 2, 30, 4, 2 },
                    { 70, 3, 1, 1, 30, 5, 2 },
                    { 71, 1, 2, 2, 30, 6, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Relations_studentIDFK",
                table: "Relations",
                column: "studentIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Relations_subjectIDFK",
                table: "Relations",
                column: "subjectIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Relations_teacherIDFK",
                table: "Relations",
                column: "teacherIDFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Relations");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
