using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CulinaryMap.Migrations
{
    /// <inheritdoc />
    public partial class FixedMucenici : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PrepMode", "PrepTime" },
                values: new object[] { "Preparam maiaua din drojdie, o lingurita zahar si una de faina. Dupa 10 minute o amestecam cu restul ingredientelor enumerate mai sus pentru aluat.\r\nFramantam bine aluatul. Vom obtine un aluat moale pe care il lasam sa creasca la loc caldut.\r\nCand acesta creste (si va creste mult), il impartim in 8 bucati din care modelam in snusruri lungi subtiri, pe care le indoim la jumatate, le rulam  si le impletim, apoi le suprapunem in forma de 8. Punem mucenicii intr-o tava tapetata cu hartie de copt.\r\nIi vom coace timp de 20-30 de minute in cuptor electric preincalzit la 180°C (in functie d eputerea cuptorului).\r\nCat timp acestia se coc pregatim siropul: fierbem apa cu zaharul si aromele timp de 5 minute. Lasam sa se raceasca putin si adaugam mierea de albine si esenta de vanilie.\r\nCand mucenicii sunt gata ii scoatem din cuptor, ii lasam sa se raceasca foarte putin, apoi ii inmuiem bine in sirop, dar cat sa fie coaja umeda, iar interiorul inca pufos. Ii ungem cu miere si presaram nuca.\r\nIi servim proaspeti, cu nuci presarate din belsug.\r\n", "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PrepMode", "PrepTime" },
                values: new object[] { "", "Preparam maiaua din drojdie, o lingurita zahar si una de faina. Dupa 10 minute o amestecam cu restul ingredientelor enumerate mai sus pentru aluat.\r\nFramantam bine aluatul. Vom obtine un aluat moale pe care il lasam sa creasca la loc caldut.\r\nCand acesta creste (si va creste mult), il impartim in 8 bucati din care modelam in snusruri lungi subtiri, pe care le indoim la jumatate, le rulam  si le impletim, apoi le suprapunem in forma de 8. Punem mucenicii intr-o tava tapetata cu hartie de copt.\r\nIi vom coace timp de 20-30 de minute in cuptor electric preincalzit la 180°C (in functie d eputerea cuptorului).\r\nCat timp acestia se coc pregatim siropul: fierbem apa cu zaharul si aromele timp de 5 minute. Lasam sa se raceasca putin si adaugam mierea de albine si esenta de vanilie.\r\nCand mucenicii sunt gata ii scoatem din cuptor, ii lasam sa se raceasca foarte putin, apoi ii inmuiem bine in sirop, dar cat sa fie coaja umeda, iar interiorul inca pufos. Ii ungem cu miere si presaram nuca.\r\nIi servim proaspeti, cu nuci presarate din belsug.\r\n" });
        }
    }
}
