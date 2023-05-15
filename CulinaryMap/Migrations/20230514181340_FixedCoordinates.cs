using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CulinaryMap.Migrations
{
    /// <inheritdoc />
    public partial class FixedCoordinates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Recipes",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Recipes",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 46.32m, 23.72m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.13m, 24.5m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Latitude", "Longitude", "Type" },
                values: new object[] { 46.41m, 24.75m, "Fel principal" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 46.75m, 23.57m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 45.88m, 22.9m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Latitude", "Longitude", "Type" },
                values: new object[] { 45.77m, 24.13m, "Fel principal" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 45.83m, 24.97m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 46.35m, 25.81m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Latitude", "Longitude", "Type" },
                values: new object[] { 47.02m, 23.9m, "Fel principal" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 45.72m, 21.23m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Latitude", "Longitude", "Type" },
                values: new object[] { 45.68m, 21.9m, "Fel principal" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 45.29m, 21.87m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 46.07m, 20.62m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.83m, 25.91m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.72m, 26.66m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.16m, 27.56m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.64m, 26.24m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 46.21m, 27.66m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 46.62m, 27.72m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.94m, 26.41m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 45.44m, 25.56m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.93m, 26.05m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.56m, 27.39m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.83m, 24.9m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.41m, 26.03m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 43.95m, 25.32m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 45.13m, 24.67m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.04m, 21.97m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 46.48m, 21.5m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.23m, 22.42m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.5m, 22.16m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.3m, 23.82m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44m, 23.34m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.1m, 24.34m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 43.78m, 24.49m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 45.01m, 23.29m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.15m, 28.6m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 45.16m, 28.8m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 45.09m, 29.36m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 45.4m, 28.03m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.05m, 28.24m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 43.82m, 28.56m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.65m, 23.56m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.79m, 22.87m });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.92m, 23.93m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "Recipes",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "Recipes",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 46.32, 23.719999999999999 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.130000000000003, 24.5 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Latitude", "Longitude", "Type" },
                values: new object[] { 46.409999999999997, 24.75, "Fel Principal" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 46.75, 23.57 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 45.880000000000003, 22.899999999999999 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Latitude", "Longitude", "Type" },
                values: new object[] { 45.770000000000003, 24.129999999999999, "Fel Principal" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 45.829999999999998, 24.969999999999999 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 46.350000000000001, 25.809999999999999 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Latitude", "Longitude", "Type" },
                values: new object[] { 47.020000000000003, 23.899999999999999, "Fel Principal" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 45.719999999999999, 21.23 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Latitude", "Longitude", "Type" },
                values: new object[] { 45.68, 21.899999999999999, "Fel Principal" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 45.289999999999999, 21.870000000000001 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 46.07, 20.620000000000001 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.829999999999998, 25.91 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.719999999999999, 26.66 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.159999999999997, 27.559999999999999 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.640000000000001, 26.239999999999998 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 46.210000000000001, 27.66 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 46.619999999999997, 27.719999999999999 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.939999999999998, 26.41 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 45.439999999999998, 25.559999999999999 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.93, 26.050000000000001 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.560000000000002, 27.390000000000001 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.829999999999998, 24.899999999999999 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.409999999999997, 26.030000000000001 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 43.950000000000003, 25.32 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 45.130000000000003, 24.670000000000002 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.039999999999999, 21.969999999999999 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 46.479999999999997, 21.5 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.229999999999997, 22.420000000000002 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.5, 22.16 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.299999999999997, 23.82 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.0, 23.34 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.100000000000001, 24.34 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 43.780000000000001, 24.489999999999998 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 45.009999999999998, 23.289999999999999 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.149999999999999, 28.600000000000001 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 45.159999999999997, 28.800000000000001 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 45.090000000000003, 29.359999999999999 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 45.399999999999999, 28.030000000000001 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.049999999999997, 28.239999999999998 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 43.82, 28.559999999999999 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.649999999999999, 23.559999999999999 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.789999999999999, 22.870000000000001 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 47.920000000000002, 23.93 });
        }
    }
}
