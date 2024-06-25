using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quiz_Application.Migrations
{
    /// <inheritdoc />
    public partial class MCQQuestion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quiz_Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrectOption = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                });

            // Insert a sample question
            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "Quiz_Question", "OptionA", "OptionB", "OptionC", "OptionD", "CorrectOption" },
                values: new object[] { "What is the capital of France?", "Paris", "London", "Berlin", "Madrid", "Paris" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Question");
        }
    }
}


//using Microsoft.EntityFrameworkCore.Migrations;

//#nullable disable

//namespace Quiz_Application.Migrations
//{
//    /// <inheritdoc />
//    public partial class MCQQuestion : Migration
//    {
//        /// <inheritdoc />
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.CreateTable(
//                name: "Question",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    Quiz_Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    OptionA = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    OptionB = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    OptionC = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    OptionD = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    CorrectOption = table.Column<string>(type: "nvarchar(max)", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Question", x => x.Id);
//                });
//        }

//        /// <inheritdoc />
//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropTable(
//                name: "Question");
//        }
//    }
//}
