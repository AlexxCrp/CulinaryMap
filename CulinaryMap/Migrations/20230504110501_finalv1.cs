using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CulinaryMap.Migrations
{
    /// <inheritdoc />
    public partial class finalv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients");

            migrationBuilder.AlterColumn<double>(
                name: "Kcal",
                table: "IngredientDetails",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Kcal",
                value: 132.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Kcal",
                value: 41.299999999999997);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "Kcal",
                value: 72.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "Kcal",
                value: 337.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "Kcal",
                value: 301.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 6,
                column: "Kcal",
                value: 237.59999999999999);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 7,
                column: "Kcal",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 8,
                column: "Kcal",
                value: 40.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 9,
                column: "Kcal",
                value: 364.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 10,
                column: "Kcal",
                value: 17.399999999999999);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 11,
                column: "Kcal",
                value: 295.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 12,
                column: "Kcal",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 13,
                column: "Kcal",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 14,
                column: "Kcal",
                value: 55.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 15,
                column: "Kcal",
                value: 216.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 16,
                column: "Kcal",
                value: 840.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 17,
                column: "Kcal",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 18,
                column: "Kcal",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 19,
                column: "Kcal",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 20,
                column: "Kcal",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 21,
                column: "Kcal",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 22,
                column: "Kcal",
                value: 16.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 23,
                column: "Kcal",
                value: 32.299999999999997);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 24,
                column: "Kcal",
                value: 149.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 25,
                column: "Kcal",
                value: 260.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 26,
                column: "Kcal",
                value: 84.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 27,
                column: "Kcal",
                value: 155.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 28,
                column: "Kcal",
                value: 13.4);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 29,
                column: "Kcal",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 30,
                column: "Kcal",
                value: 566.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 31,
                column: "Kcal",
                value: 18.600000000000001);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 32,
                column: "Kcal",
                value: 884.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 33,
                column: "Kcal",
                value: 195.5);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 34,
                column: "Kcal",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Kcal", "Name" },
                values: new object[] { 18.0, "Rosie" });

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 36,
                column: "Kcal",
                value: 105.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 37,
                column: "Kcal",
                value: 295.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 38,
                column: "Kcal",
                value: 386.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 39,
                column: "Kcal",
                value: 398.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 40,
                column: "Kcal",
                value: 273.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 41,
                column: "Kcal",
                value: 200.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 42,
                column: "Kcal",
                value: 283.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 43,
                column: "Kcal",
                value: 273.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 44,
                column: "Kcal",
                value: 168.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 45,
                column: "Kcal",
                value: 20.100000000000001);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 46,
                column: "Kcal",
                value: 231.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 47,
                column: "Kcal",
                value: 288.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 48,
                column: "Kcal",
                value: 229.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 49,
                column: "Kcal",
                value: 654.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 50,
                column: "Kcal",
                value: 47.100000000000001);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 51,
                column: "Kcal",
                value: 97.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 52,
                column: "Kcal",
                value: 87.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 53,
                column: "Kcal",
                value: 132.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 54,
                column: "Kcal",
                value: 30.800000000000001);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 55,
                column: "Kcal",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 56,
                column: "Kcal",
                value: 332.89999999999998);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 57,
                column: "Kcal",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 58,
                column: "Kcal",
                value: 60.899999999999999);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 59,
                column: "Kcal",
                value: 538.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 60,
                column: "Kcal",
                value: 359.89999999999998);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 61,
                column: "Kcal",
                value: 294.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 62,
                column: "Kcal",
                value: 121.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 63,
                column: "Kcal",
                value: 716.79999999999995);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 64,
                column: "Kcal",
                value: 299.19999999999999);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 65,
                column: "Kcal",
                value: 51.600000000000001);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 66,
                column: "Kcal",
                value: 39.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 67,
                column: "Kcal",
                value: 203.40000000000001);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 68,
                column: "Kcal",
                value: 115.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 69,
                column: "Kcal",
                value: 85.099999999999994);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 70,
                column: "Kcal",
                value: 267.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 71,
                column: "Kcal",
                value: 81.700000000000003);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 72,
                column: "Kcal",
                value: 365.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 73,
                column: "Kcal",
                value: 395.10000000000002);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 74,
                column: "Kcal",
                value: 240.40000000000001);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 75,
                column: "Kcal",
                value: 239.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 76,
                column: "Kcal",
                value: 29.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 77,
                column: "Kcal",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 78,
                column: "Kcal",
                value: 27.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 79,
                column: "Kcal",
                value: 24.899999999999999);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 80,
                column: "Kcal",
                value: 12.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 81,
                column: "Kcal",
                value: 304.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 82,
                column: "Kcal",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 83,
                column: "Kcal",
                value: 369.69999999999999);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 84,
                column: "Kcal",
                value: 254.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 85,
                column: "Kcal",
                value: 264.60000000000002);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 86,
                column: "Kcal",
                value: 245.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 87,
                column: "Kcal",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 88,
                column: "Kcal",
                value: 232.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 89,
                column: "Kcal",
                value: 242.09999999999999);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 90,
                column: "Kcal",
                value: 58.799999999999997);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 91,
                column: "Kcal",
                value: 136.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 92,
                column: "Kcal",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 93,
                column: "Kcal",
                value: 22.199999999999999);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 94,
                column: "Kcal",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 95,
                column: "Kcal",
                value: 638.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 96,
                column: "Kcal",
                value: 276.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 97,
                column: "Kcal",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 98,
                column: "Kcal",
                value: 307.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 99,
                column: "Kcal",
                value: 39.700000000000003);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 100,
                column: "Kcal",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 101,
                column: "Kcal",
                value: 127.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 102,
                column: "Kcal",
                value: 260.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 103,
                column: "Kcal",
                value: 377.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 104,
                column: "Kcal",
                value: 283.0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 105,
                column: "Kcal",
                value: 0.0);

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "History", "Latitude", "Longitude", "Name", "PrepMode", "PrepTime", "RegionId", "Type" },
                values: new object[,]
                {
                    { 1, "NA", 0, 0, "Ciorba Ardeleneasca de fasole cu afumatura si tarhon", "Fasolea o punem la inmuiat peste noapte, astfel incat sa fie acoperita de apa.\r\nPunem apoi fasolea la fiert, schimband apa de 3 ori – la 10 minute de fiert aruncam apa si o punem sa fiarba in alta apa fierbinte. In ultima apa in care o punem la final adaugam 2 morcovi si un pastarnac (folosim in jur de 3 l apa – mai adaugam daca va fi nevoie). Separat calim o ceapa mare impreuna cu afumatura. Adaugam apoi afumatura calita in oala, sucul de rosii, faina, boia de ardei, frunzele de dafin, tarhonul, boabele de piper, putina sare si continuam sa fierbem pana fasolea este suficient de moale .\r\nCand bobul de fasole este fiert dregem cioba. Amestecam laptele cald cu smantana, galbenusul si o lingura otet. Daca este nevoie mai adaugam si zeama din supa de pe pe foc, apoi incoporam aceasta compozitie in ciorba amestecand cat timp turnam laptele cu smantana. O mai lasam 2-3 minute sa fiarba, avand grija sa amestecam din cand in cand. La final gustam pentru a vedea daca mai are nevoie de sare.\r\nO servim fierbinte, cu putin patrunjel verde si ceapa rosie!\r\n", "NA", 1, "Fel principal" },
                    { 2, "NA", 0, 0, "Ciorba Ardeleneasca de miel", "Pentru a pregati ciorba ardeleneasca de miel folosim capul si bucati de carne de la miel.\r\nSpalam si curatam carnea. Pentru inceput o oparim in apa cu otet. Aruncam apa si punem carnea iar la fiert in apa rece cu sare.\r\nAvem grija sa fie acoperita Vom indeparta spuma de cate ori este nevoie.\r\nLegumele le taiem marunt si le calim in ulei, apoi le inabusim cu putina apa.\r\nLe punem la fiert in oala in care fierbem carnea, adaugand si usturoiul, frunza de dafin, frunzele de leustean si boabele de piper. Orezul il vom fierbe separat.\r\nCand este fiarta carnea o scoatem si o alegem de pe oase, portionam bucatile mai mari, apoi le punem inapoi in oala. Adaugam orezul, otet dupa gust (zeama de lamaie sau bors) fierbem 4-5 minute, apoi punem dressingul din faina, galbenusuri si smantana de gatit. Dressingul este diluat in prealabil cu 4-5 polonice de zeama fierbinte si abia dupa aceasta operatiune se pune in oala.\r\nEste important ca dressingul sa ajunga la o temperatura apropiata de a ciorbei, asa ca zeama calda o punem treptat peste smantana cu oua si faina, iar in oala se pune tot treptat, nu se toarna tot lichidul dintr-o singura miscare.\r\nMai lasam sa fiarba  cateva clocote (nu se va branzi pentru ca avem si faina!), saram cat este nevoie si ciorba este gata.\r\n", "NA", 1, "Fel principal" },
                    { 3, "NA", 0, 0, "Supa de mazare Ardeleneasca", "In primul rand am pus 120 ml de apa la fiert.\r\nAm taiat morcovii in rondele subtiri  si ceapa cat mai fin.\r\nAm calit morcovii cu ceapa un putin ulei incins in prealabil.\r\nAm pus morcovii si ceapa calita in apa care a inceput sa clocoteasca si am lasat sa fiarba 5 minute.\r\nDupa caest interval de timp am turnat supa concentrata de legume si am condimentat supa de mazare, reteta ardeleneasca, cu piper si sare.\r\nDintr-un ou, 4 lingurite de faina si 1-2 lingurite de apa am realizat un aluat moale.\r\nDin acesta am luat cu lingurita umezita foarte putin si l-am pus in supa de mazare fierbinte.\r\nObtinem niste galusti foarte mici. Cand acestea se ridica la suprafata se adauga mazarea si se mai fierbe inca 5 minute.\r\nMazarea este congelata, asa ca nu are nevoie de timp mare de gatire.\r\nAm turnat smantana de gatit si am luat de pe foc.\r\nAm presarat patrunjelul tocat marunt.\r\n", "NA", 1, "Fel Principal" },
                    { 4, "NA", 0, 0, "Varza ala Cluj", "Varza murata o spalam in cateva ape apoi o taiem fideluta, avand grija sa eliminam nervurile groase din fiecare frunza. Calim varza in 4 linguri ulei de masline, adaugand apoi putina apa (o cana ar trebui sa fie suficienta) si foaia de dafin, la foc mic acoperita, sau la cuptor, pentru 1 ora.\r\nOrezul il calim deasemena in 3 linguri ulei de masline, apoi stingem cu 1/2 l apa fierbinte. Ii facem loc in cuptor, langa varza, unde il lasam acoperit sa fiarba in jur de 15-20 minute.\r\nCat timp acestea stau in cuptor, calim ceapa tocata marunt in 4-5 linguri ulei masline, adaugam carnea tocata si incepem sa o perpelim la foc mic cam 30 de minute. Asezonam cu sare, piper si putin cimbru. Punem din cand in cand putina apa, sa nu se arda.\r\nCand toate sunt gata, amestecam carnea cu orezul. Intr-un vas termorezistent punem un rand subtire de varza, il acoperim cu unul de carne, apoi iar varza, carne, termanand cu un strat de varza.\r\nAcoperim totul cu sos de rosii si decoram cu felii de rosii taiate rotund. Dam totul la cuptor pentru inca 15-20 minute, cat sa se imbine aromele.\r\n", "NA", 1, "Fel principal" },
                    { 5, "NA", 0, 0, "Langosi", "Dizolvă într-un castron drojdia şi amestecă cu apă călduţă, sare şi zahăr.  Adaugă făina şi frământă bine preparatul.\r\nPune aluatul frământat într-un vas uns cu ulei,  acoperă cu un prosop. Lasă la cald, ferit de curent, să crească, pentru aproximativ 30 de minute.\r\nPune ulei la încins într-o tigaie şi desfă cu o lingură, sau cu mâna, bucăţi din aluat crescut.\r\nSe aplatizează (turtesc) bucăţile de aluat și, dacă nu le vrei simple, pune umplutura (de brânză, brânză cu verdeţuri, stafide, fructe, gem, etc.).\r\nLipește marginile, ca într-un plic şi pune în uleiul încins, la prăjit, circa 2 minute pe fiecare parte, până devin aurii.\r\nSe scot langoşile pe șervețele de hârtie şi se lasă la scurs. Fiecare bucățică de langoși se pudrează cu zahăr sau scorţişoară, după gust.\r\n", "NA", 1, "Desert" },
                    { 6, "NA", 0, 0, "Ciorba de burta ardeleneasca", "Ciorbă de burtă ardelenească – diferența dintre ea și ciorba de burtă tradițională este adăugarea rasolului sau/și picioarelor de porc.\r\nSe spală și curăță bine rasolul sau/și picioarele de porc. IMPORTANT: Când începe să fiarbă, îndepărtează spuma formată cu o spumieră.\r\nÎntre timp curăță legumele și pune, separat, la fiert, burta cu puțin oțet și las-o să dea în clocot.\r\nAdaugă legumele peste rasolul sau/și picioarele de porc și lasă la fiert în continuare până când carnea se desprinde singură de pe oase.\r\nScoate bucățile de carne și lasă-le la răcit. Când s-au răcit îndeajuns, taie-le bucățele și pune-le înapoi în oală cu legumele. Adaugă și burta și extra apă, dacă se cere. Mai lasă pe foc până când burta este foarte bine fiartă.\r\nÎntre timp curăță usturoiul zdrobește-l. Freacă-l cu sare ca pentru mujdei (până obții o pastă albicioasă, adică). Separat bate ouăle cu un vârf de sare și vreo 3 linguri de smântână.\r\nAdaugă în ciorbă ouăle bătute și jumătate din crema de usturoi. Opreste focul, acrește cu oțet, după gust.\r\n", "NA", 1, "Fel Principal" },
                    { 7, "NA", 0, 0, "Cozonac Ardelenesc", "1. Se cerne făina şi se lasă la temperatura camerei 3-4 ore împreună cu celelalte ingrediente. Se separă ouăle iar uleiul se încălzeşte 5-10 minute. Se incalzeste putin laptele şi se amestecă cu 2 linguri de zahăr, cu drojdia şi se lasă la dospit acoperit cu un şervet.\r\n2. În bolul cu făină, se adaugă restul de zahăr, gălbenuşurile frecate cu sarea, zahărul vanilat, coaja de lămâie şi de portocală, drojdia dospită şi albuşurile bătute spumă.\r\n3. Toate ingredientele se amestecă până se obţine o cocă nici prea vârtoasă, nici prea moale. Se adaugă lapte dacă e prea tare şi apoi se frământă 30 de minute adăugându-se uleiul, câte puţin. După ce s-a încorporat tot uleiul, se acoperă şi se lasă la crescut o oră sau chiar mai mult.\r\n4. Între timp, se pregăteşte crema de nucă. Se amestecă nuca măcinată şi coaptă cu zahărul şi cu laptele fierbinte. Se adaugă o esenţă de vanilie şi 2-3 picături de rom, coaja de lămâie şi cacaoa. Crema se lasă la temperatura camerei. Se ung tăvile cu unt din abundenţă. Se împarte coca în două părţi şi se întind. Se umplu cu crema de nucă şi se rulează. Se aranjează în tavă una lângă alta şi se mai lasă 20 de minute la crescut. Se ung cu galbenuş şi se coc la aceeaşi temperatură.\r\n", "120 min", 1, "Desert" },
                    { 8, "NA", 0, 0, "Ciorba Ardeleneasca", "1. Se curăţă rasolul de viţel şi se pune la fiert într-o oală cu apă și puţină sare. Se spumează în timpul fierberii şi se lasă la foc potrivit, acoperit cu un capac.\r\n2. Separat, se curăţă morcovii, ceapa, ardeii, fasolea şi cartofii. Se spală, se taie bucăţi mari şi se pun să fiarbă împreună cu rasolul de viţel. Se condimentează cu sare, piper şi paprika şi se fierb la foc potrivit.\r\n3. Borşul se strecoară şi se fierbe separat în câteva clocote. În borş, se adaugă câteva frunze de leuştean pentru a-i da o aromă mai specială.\r\n4. După ce au fiert toate legumele, se scoate rasolul, se desface carnea de pe os şi se taie bucăţele. Se adaugă borşul şi se serveşte ornată cu leuştean şi pătrunjel.", "40 min", 1, "Fel principal" },
                    { 9, "NA", 0, 0, "Ghiveci Ardelenesc", "1. Pentru început, se alege fasolea uscată şi se lasă câteva ore să se înmoaie. După ce a stat în apă călduţă, se scoate şi se pune să fiarbă. Se fierbe în câteva ape până se elimină toxinele apoi se scoate în sită să se scurgă.\r\n2. Carnea se taie cubuleţe şi se căleşte în uleiul încins. Se înăbuşe uşor la foc mediu şi se adaugă ceapa şi ardeii tăiaţi cubuleţe.\r\n3. Morcovii, fasolea verde şi cartofii se spală, se curăţă şi se taie cubuleţe. Se adaugă în cratiţa cu carne şi se lasă să fiarbă la foc potrivit.\r\n4. După ce au fiert şi legumele, şi ceapa, se adaugă piureul de roşii şi fasolea fiartă. Ghiveciul se lasă să scadă în cuptor şi se serveşte cu mărar şi cimbru.", "40 min", 1, "Fel Principal" },
                    { 10, "NA", 0, 0, "Clatite Banatene", "Ungeți o tavă cu unt. Preîncălziți cuptorul.\r\nÎntr-un bol mediu, omogenizați umplutura pentru clătite – brânza de vaci cu oul, zahărul, stafidele și esențele.\r\nSeparați celelalte 4 ouă necesare – deoarece pentru sosul de vanilie veți folosi gălbenușurile, iar pentru bezea albușurile. Amestecați cu mixerul gălbenușurile cu smântâna, zahărul tos și cel  vanilat. Bateți albușurile  – tot cu mixerul – până se întăresc și apoi adăugați zahărul rămas și sarea. Gata și bezeaua!\r\nUmpleți clătitele cu umplutură și împăturiți-le pe rând, ca pe sarmale. Așezați-le în vasul uns cu unt. Turnați crema de vanilie deasupra. Dați la cuptor pentru 10 minute sau până când vedeți că începe să se închege sosul. Scoateți vasul și turnați deasupra compoziția de bezea. Dați la cuptor pentru alte 10 minute sau până când încep să se rumenească crusta de bezea.\r\n", "40 min", 2, "Desert" },
                    { 11, "NA", 0, 0, "Ciorba Banateana", "1. Se lasă fasolea la înmuiat în apă călduţă, timp de 3-4 ore. Se scoate din apă şi se pune să fiarbă în câteva ape, până elimină toxinele.\r\n2. După ce s-a fiert, se scoate din apă şi se lasă în sită să se scurgă. Separat, se curăţă ceapa, ardeii, morcovul şi cartofii. Se taie cubuleţe, ca pentru ciorbă şi se înăbuşe câteva minute în uleiul de floarea-soarelui.\r\n3. Se adaugă aproximativ 2 litri de apă şi se pun să fiarbă la foc mediu, acoperite cu un capac. În acest timp, se taie cârnaţii felii şi se călesc în sucul propriu.\r\n4. După ce au fiert legumele, se adaugă sucul de roşii, sarea, piperul, boiaua iute, se mai lasă să clocotească 10 minute şi se serveşte cu bucăţile de cârnaţi şi pătrunjel proaspăt tocat mărunt.", "40 min", 2, "Fel Principal" },
                    { 12, "NA", 0, 0, "Ceapa umpluta ca la Caransebes", "Ceapa se curata si se fierbe intreaga. Se da apoi la rece si i se scoate miezul. Se realizeaza apoi o compozitie din: nucile pisate bine in mojar, pâinea inmuiata in lapte si stoarsa bine, maslinele jumatati, sare, piper, miezul cepelor si patrunjelul tocat marunt.Cu aceasta compozitie se umplu cepele, care se aseaza apoi intr-o tava unsa.Separat se face un sos, astfel: se rumeneste faina in uleiul bine incins, pana ce faina capata o culoare aurie. Se stinge apoi cu bulionul de rosii si cu un pic de vin alb. Se presara apoi zaharul si se mai da in câteva clocote. Cand sosul este gata se toarna peste cepele din tava.Se baga apoi tava la cuptor pentru circa 15 minute. Preparatul se serveste fierbinte cu smantana deasupra.", "NA", 2, "Aperitiv" },
                    { 13, "NA", 0, 0, "Gomboti cu prune", "Preparare aluat:\r\n1. Pentru inceput, se aleg cartofi mai degraba fainosi, din cei care sunt potriviti pentru piure, nu pentru prajit. Cartofii cu tot cu coaja se spala bine si se pun la fiert. Cand sunt bine fierti, se scurg de apa si se lasa sa se racoreasca atat cat sa se poata atinge si se curata de coaja.\r\n2. Se zdrobesc bine cartofii.\r\n3. Se adauga pe rand cele doua oua intregi, un praf de sare, cele 4 linguri de gris si 8 linguri de faina varfuite.\r\n4. Se framanta rapid aluatul, fara a insista foarte mult. Ideea e sa se obtina un aluat molcut, care sa se adune intr-o bila si sa se desfaca de pe peretii vasului, dar care e inca usor lipicios fata de maini. La nevoie, mai adaugati cate o lingura de faina, dar fara exagerare, nu trebuie sa se obtina un aluat greu.\r\n(Aluatul trebuie sa fie moale, poate e ceva mai greu de lucrat cu el, insa rezultatul e de o mare fragezime. Daca se adauga faina pana la obtinerea unui aluat care nu se mai lipeste, galustele vor fi tari oricat le-am fierbe).\r\nPrepararea pesmetului aromat\r\n3. Cat timp au fiert cartofii, eu am pregatit pesmetul. Am incins uleiul intr-o tigaie, apoi am adaugat untul.\r\n4. Cand untul s-a topit complet, am adaugat pesmetul si l-am rumenit, amestecand frecvent ca sa nu se arda.\r\n5. adaugam zaharul tos (dupa gust) si semintele dintr-o pastaie de vanilie.\r\nAm amestecat bine si am acoperit cu un capac, pentru ca semintele de vanilie sa isi dezvolte aroma in pesmetul inca fierbinte.\r\nFierberea galustelor\r\n6. Am pus o oala incapatoare (5-6 litri) plina cu apa, la fiert.\r\n7. Cand apa aproape clocoteste, se adauga in oala o lingura rasa de sare si se trece la modelarea galustelor. Cu mainile in permanenta udate cu apa (eu tin un castronel cu apa la indemana) se rup bucati din aluat cam de dimensiunea unei prune. Se aplatizeaza aluatul in palma si se adauga jumatatile de prune dinainte pregatite. Unii prefera sa adauge in interiorul prunelor zahar amestecat cu arome (scortisoara), altii pun un cubulet mic de unt. Eu le prefer simple. \r\nObservație: in timpul iernii gombotii se pot pregati identic, folosind jumatati de prune congelate. Nu le decongelam, ci le invelim cat sunt inghetate bine in aluat, apoi continuam ca in pasii urmatori.\r\n8. Se inchide cu grija aluatul peste pruna, se rotunjesc galustele in palmele ude si se plonjeaza pe rand in apa clocotita.\r\n9. In scurt timp, galustele cu prune se vor ridica la suprafata. In acest moment se reduce focul la minimum si se mai fierb in clocote mici 4-7 minute, pentru ca grisul din compozitie sa absoarba umiditate, fragezind aluatul, si pentru ca pruna din interior sa fiarba si ea (daca doriti pruna mai cruda, scoateti galustele mai repede).\r\n10. Cand sunt gata, galustele cu prune se scot cu o\r\n", "NA", 2, "Desert" },
                    { 14, "", 0, 0, "Ciorba Radauteana", "Pentru inceput am pus puiul intr-o oala si am adaugat apa rece (am folosit 3.5l ). Apa se pune pana cand acesta va fi acoperit, in functie de marimea oalei in care fierbeti. Am adaugat o lingura varfuita de sare si boabele de piper si am lasat sa fiarba 15 minute, la foc mic, din momentul in care apa a inceput sa clocoteasca. Am indepartat spuma formata si am pus capacul.\r\nIn acest timp am curatat si taiat morcovii, pastarnacul, patrunjelul si felia de ardei in jumatate. Ceapa si felia de telina le-am lasat intregi. Le-am pus in oala, langa pui, am pus capacul si am lasat sa fiarba in jur de 45 minute.\r\nAm dat usturoiul presa. Am luat oala de pe foc si am oparit usturoiul cu 4 polonice de supa. Am acoperit bolul cu o farfurie.\r\nAm strecurat supa. Legumele le voi pastra pentru o salata olivier (salata a la Russe).\r\nAm indepartat oasele si pielea de pe carne, apoi am rupt-o in fasii.\r\nAm pregatit liezonul, adica dressingul din galbenusuri si smantana cu care se drege ciorba. Pentru ingrosare am folosit faina.\r\nAm amestecat galbenusurile cu sare, am adaugat faina, apoi smantana pentru gatit. Am avut grija sa nu ramana cocoloase.\r\nAm adaugat treptat cate un polonic de supa, pana cand liezonul a avut o temperatura apropiata de a ciorbei. In acest mod ma asigur ca nu se branzeste.\r\nAm pus fasiile de carne in oala. Am strecurat lichidul cu usturoi si am presat putin usturoiul.\r\nAm adaugat in supa treptat cate un polonic din dressingul de oua cu smantana.\r\nAm pus oala pe foc si am mai lasat sa fiarba in jur de 5 minute, astfel incat faina sa fie gatita.\r\n", "NA", 7, "Fel principal" },
                    { 15, "", 0, 0, "Bors Moldovenesc de pui cu legume", "In primul rand punem carnea la foc, in apa cu putina sare. Cand incepe sa fiarba luam spuma de cate ori este necesar si lasam sa fiarba in continuare la foc mic.\r\nCalim ceapa tocata marunt cu morcovii taiati rondele si ardeiul tocat cubulete intr-o lingura de ulei.\r\nLe punem peste carne impreuna cu telina, gulia si cartofii taiati in cuburi. Dupa 5 minute adaugam buchetele de conopida si dovleceii taiati in cuburi. Continuam sa fierbem acoperind cu un capac.\r\nCand au fiert legumele si carnea, adaugam borsul fiert in prealabil, frunzele de leustean si mai lasam sa fiarba 2-3 minute.\r\nServim borsul fierbinte cu ptarunjel sau leustean proaspat tocat.\r\n", "", 7, "Fel principal" },
                    { 16, "Sarbatoarea crestina a celor 40 de Mucenici poate sa cada si in perioada postului, asa ca in acest caz veti pregati un aluat de cozonac fara oua.\r\nIn aceasta zi pe vremuri oamenii obisnuiau sa faca ritualiri de indepartarea gerului, se face curatenie de primavara si se incheie perioada „babelor” si incep pregatirile pentru arat.\r\nIn traditiile vechi populare se spune ca se deschid mormintele si portile Raiului, dar mai sunt inca multe alte obiceiuri ce aduc aminte de perioada in cei 40 mucenici aflati in slujba imparatului roman Licinius.\r\nAcestia au fost condamnati la moarte dupa ce au fost chinuiti si torturati pentru ca nu s-au inchinat idolilor.\r\nIn lacul in care au condamnati la moarte prin inghetare s-au petrecut minuni, apa lacului s-a incalzit, s-a topit ghetata si 40 de cununi stralucitoare  au pogarat peste mucenici.\r\nPentru ca au fost scosi vii din lac comandantii au poruncit sa li se zdrobeasca picioarele cu ciocanele, apoi au fost arsi.\r\n", 0, 0, "Mucenici Moldovenesti", "", "Preparam maiaua din drojdie, o lingurita zahar si una de faina. Dupa 10 minute o amestecam cu restul ingredientelor enumerate mai sus pentru aluat.\r\nFramantam bine aluatul. Vom obtine un aluat moale pe care il lasam sa creasca la loc caldut.\r\nCand acesta creste (si va creste mult), il impartim in 8 bucati din care modelam in snusruri lungi subtiri, pe care le indoim la jumatate, le rulam  si le impletim, apoi le suprapunem in forma de 8. Punem mucenicii intr-o tava tapetata cu hartie de copt.\r\nIi vom coace timp de 20-30 de minute in cuptor electric preincalzit la 180°C (in functie d eputerea cuptorului).\r\nCat timp acestia se coc pregatim siropul: fierbem apa cu zaharul si aromele timp de 5 minute. Lasam sa se raceasca putin si adaugam mierea de albine si esenta de vanilie.\r\nCand mucenicii sunt gata ii scoatem din cuptor, ii lasam sa se raceasca foarte putin, apoi ii inmuiem bine in sirop, dar cat sa fie coaja umeda, iar interiorul inca pufos. Ii ungem cu miere si presaram nuca.\r\nIi servim proaspeti, cu nuci presarate din belsug.\r\n", 7, "Desert" },
                    { 17, "Una din mâncărurile de bază ale ciobanilor din pitoreasca zonă a Bucovinei, balmoșul este de multe ori confundat cu o banală mămăligă. Da, are la bază tot mălaiul, dar nu se fierbe în apă ci în zer (sau jintuială).", 0, 0, "Balmos", "În primul rând vă spunem că dacă nu aveți de unde lua zer, îl puteți înlocui cu o smântână mai ușoară, cât mai apoasă. Astfel, într-o oală înaltă puneți untul la topit, asezonat cu un pic de sare. Apoi turnați deasupra zerul/smântâna și lăsați la fiert, la foc mic. Când începe să clocotească, turnați mălaiul treptat și cernut – ca pentru mămăligă. Amestecați un pic să nu facă deloc cocoloașe și lăsați la fiert 15 minute. Puneți oul, amestecați. Radeți brânza peste balmoșul care se formează în oală și amestecați temeinic. Când începe să se desprindă de pe oală, mai lăsați 5 minute și dați la o parte de pe foc.\r\nSe servește cu caș fărâmițat deasupra și cu lapte acru din belșug.\r\n", "75 min", 7, "Fel principal" },
                    { 18, "", 0, 0, "Alivenci Moldovenesti", "Laptele se pune la fiert cu un praf de sare., amestecând din când în când să nu se lipească. Atunci când dă în clocot, adăugați mălaiul, cernut treptat, ca atunci când faceți mămăligă. Amestecați, amestecați, ca să nu se formeze cocoloașe. După 10 minute, dați de pe foc și lăsați la răcit.\r\nÎntre timp, preîncălziți cuptorul. Într-un castron mic, separați ouăle. Într-un bol mediu amestecați brânza cu smântâna și adăugați gălbenușurile. Bateți albușurile cu un vârf de linguriță de sare până se întăresc.\r\nAmestecați terciul de mămăligă cu crema de brânză. Încorporați albușurile, cu mișcări ample. Ungeți o tavă care nu lipește cu unt (sau tapetați-o cu hârtie de copt).  Turnați compoziția și nivelați-o. Dacă doriți, puteți presăra deasupra cașcaval ras.\r\nDați la cuptor pentru 35-40 minute sau până când vedeți că se rumenește apetisant la suprafață. Serviți calde, cu smântână cremoasă deasupra.\r\n", "65 min", 7, "Aperitiv" },
                    { 19, "", 0, 0, "Poale-n Brau", "Se încinge cuptorul la 200 de grade şi se unge o tavă mare cu ulei.\r\nSe dizolvă drojdia în apă călduţă şi se amestecă cu 2 linguri de zahăr, apoi se lasă la dizolvat 10 minute.\r\nSe amestecă laptele cu ouăle, uleiul, restul de zahăr şi aromele. Se adaugă un paf de sare şi drojdia dizolvată,apoi se incorporează făina treptat şi se frământă bine aluatul, până devine un pic poros.\r\nSe unge un castron mare cu ulei, se pune bila de aluat, acoperită cu un strat de ulei şi o cârpă şi se lasă la dospit până se dublează în cantitate.\r\nSe pregăteşte umplutura de brânză, astfel încât ultimul să fie turnat grişul, care se mai ajustează în funcţie de cât de densă vreţi să fie la final crema.\r\nSe întinde bila de aluat dospit cu un făcăleţ şi se taie în pătrate, care se umplu cu cremă de brânză şi se împăturesc de colţuri, care se presează deasupra, ca un plic.\r\nAmestecaţi ouăle cu lapte pentru uns şi daţi pe deasupra plăcintelor cu o pensulă de gătit.\r\nSe dau poalele-n brâu la cuptor pentru circa 30 de minute, după care se ung cu apă cu zahăr şi se pudrează sau nu cu zahăr.\r\n", "NA", 7, "Desert" },
                    { 20, "", 0, 0, "Parjoale Moldovenesti", "Punem feliile de paine (folosim paine mai uscata, veche de 2-3 zile) la inmuiat in lapte pentru cca 10 minute.\r\nAmestecam ambele tipuri de carne tocata, apoi adaugam cartoful crud, usturoiul si ceapa, date toate prin razatoarea cu gauri foarte mici. Adaugam ouale, mararul si patrunjelul, dupa gust, tocate foarte marunt, si painea stoarsa bine. Condimentam cu sare si piper si framantam pana obtinem un amestec omogen.\r\nAcoperim vasul cu o folie de plastic alimentara si il punem in frigider pentru 1 ora.\r\nDupa repaus, punem intr-o farfurie pesmetul si faina si le amestecam.\r\nCu mainile umede, formam parjoale lunguiete de circa 50-60 g si le asezam in farfurie. Le presam, astfel incat parjoala finala sa aiba o grosime de circa 1,5 cm.\r\nTavalim parjoalele moldovenesti pe ambele parti prin amestecul de pesmet.\r\nPunem ulei intr-o tigaie antiaderenta (circa un deget de ulei) si cand acesta s-a incins, adaugam parjoalele. Inainte de a pune parjoalele in tigaie, le mai alungim putin. Facem acest lucru, pentru ca in timp ce se prajesc, se mai strang.\r\nLe prajim la foc mic spre mediu, cate 5-6 minute pe fiecare parte (timpul este relativ, depinde foarte mult de marimea parjoalelor si tigaia folosita).\r\nLe scoatem pe o farfurie tapetata cu hartie absorbanta de bucatarie si dupa ce s-au scurs, le servim.\r\n", "NA", 7, "Aperitiv" },
                    { 21, "", 0, 0, "Mucenici Muntenesti", "Amestecă făina, apa și sarea și frământă pentru a obține un aluat potrivit de tare. Întinde aluatul într-o foaie nu mai groasă de 1/2 cm. Taie mucenicii cu aparatul special în formă de 8.\r\nPune mucenicii tăiaţi pe hârtie (sau într-o tavă), răsfiraţi. Lasă-i să se usuce timp de o oră.\r\nPune pe foc o oala cu 2-3 litri de apa, cu sare si zahăr – după gust. Când apa începe sa fiarbă, micșoreaza focul și pune mucenicii cu grijă. Adaugă răzătura de citrice, esenţele și zahărul vanilat si lasă-i la fiert în jur de 20-25 de minute.\r\nMucenicii se servesc reci sau calzi, cu nucă si scorţisoară presărate deasupra.\r\n", "90 min", 4, "Desert" },
                    { 22, "", 0, 0, "Racitura de porc Munteneasca", "1. Picioarele şi capul se pârlesc la flacăra aragazului, se răzuie şi se spală în mai multe rânduri în apă rece, până ce sunt albe şi curate. Apoi, capul se taie.\r\n2. Carnea şi extremităţile porcului se pun la fiert în 6 litri de apă rece cu sare. După ce s-a luat spuma care se va forma la suprafaţă, se pun cepele şi morcovii, care se scot înainte de a fi fiartă carnea.\r\n3. Se lasă la fiert până ce carnea se ia de pe oase şi zeama scade la jumătate. Carnea se scoate, se aruncă oasele şi ceapa şi ce rămâne se taie bucăţi mici. Usturoiul se pisează şi se pune în zeama în care a fiert carnea. Se lasă aşa 15-20 de minute, după care se strecoară şi se potriveşte gustul de piper.\r\n3. În patru vase se pune pe fund o felie de ou fiert şi apoi mazăre şi rondele de morcovi. Se pun carnea şi bastonaşe de morcovi şi apoi se toarnă zeamă. Se acoperă şi se dau la rece, dacă este posibil nu în frigider.\r\n", "6 ore", 4, "Aperitiv" },
                    { 23, "", 0, 0, "Mamaliga in straturi", "Pune apa pentru mămăligă la fiert, adaugă-i sare și cele 700 g de iaurt. Amestecă până devine omogen și începe să clocotească. Presară treptat mălaiul și cu o lingură de lemn amestecă vioi pentru a nu se forma cocoloașe.\r\nDupă ce compoziția se îngroașă și se dezlipește cu ușurință de pe vas, oprește focul.\r\nImediat ce ai luat mămăliga de pe foc, încorporează smântâna în ea printr-o amestecare continuă.\r\nÎncinge o tigaie antiaderentă pe foc, pune uleiul în ea și călește cârnații sau afumătura de porc, în funcție de ce tip de carne dorești să ai în mămăligă.\r\nÎntr-un vas de yena sau într-o tavă, întinde cu o lingură de lemn primul strat de mămăligă, peste care pune o jumătate din cantitatea de telemea răzuită, dar și jumătate din cantitatea de urdă.\r\nDeasupra, așază câteva bucățele de cârnat/ afumătură, iar apoi învelește acest strat cu unul de mămăligă. Întinde iar un strat de telemea, unul de urdă și unul de afumătură, pe care îl vei acoperi cu încă un strat de mămăligă fierbinte. Păstrează cârnați/ afumătură și pentru ornare.\r\nFolosește o lingură pentru a face 4 cuiburi la suprafața ultimului strat de mămăligă, și sparge acolo câte un ou. La final, aruncă la întâmplare cârnații rămași.\r\nBagă tava cu mămăligă în straturi în cuptorul preîncălzit la 180 de grade Celsius, las-o jumătate de oră și după acest timp scoate-o din cuptor.\r\nDă-i voie mămăligii în straturi să se odihnească preț de 10 minute, apoi bucură-te de ea din plin.\r\n", "40 min", 4, "Fel principal" },
                    { 24, "", 0, 0, "Papanasi fierti cu branza de vaci si pesmet", "Pentru ca papanașii fierți să fie gustoși, e important să respecți cantitățile de ingrediente recomandate. Bineînțeles, dacă vrei un rezultat cu un gust desăvârșit, trebuie să pui și un strop de dragoste pe lângă ingredientele folosite.\r\nÎntr-un vas încăpător, amestecă vioi grișul din grâu Raftul Bunicii cu brânza bine scursă înainte, zahărul pudră, un praf de sare, ouăle, dar și coaja de lămâie rasă și zahărul vanilat. După ce amestecul devine omogen, dă-i răgaz jumătate de oră, timp în care acesta va crește de bucurie.\r\nClătește-ți mâinile cu apă rece, ia aluatul și modelează-l în 20 de biluțe aproximativ egale. Lasă-le să se odihnească pe o tavă cât timp pui apa la fiert și pregătești toppingul.\r\nToppingul de pesmet prăjit pentru papanași se prepară foarte rapid. Topește untul într-o tigaie și amestecă ușor. La final, după ce pesmetul capătă o nuanță maro, se adaugă și zahărul și se mai lasă cel mult 3 minute pe foc.\r\nCând apa începe să clocotească, dizolvă în ea sare și apoi adaugă biluțele de aluat, una câte una, în apă. Se lasă focul mai mic și se așteaptă să se ridice la suprafață papanașii. Din acel moment, se mai lasă la fiert maxim 3-4 minute și se scot cu ajutorul unei spumiere.\r\nPapanașii sunt transferați imediat în tigaia cu pesmet proaspăt prăjit. Cu o lingură de lemn, rostogolește-i prin pesmet, astfel încât să fie complet acoperiți de acesta.\r\nSunt gata de servire, îți mai rămâne să-i înnobilezi cu smântână rece și puțină dulceață.\r\n", "40 min", 4, "Desert" },
                    { 25, "", 0, 0, "Ciorba de fasole in paine", "Pasul 1\r\nPregătește fasolea cu o seară înainte. Aceasta trebuie spălată și curățată foarte bine, apoi lăsată într-un bol cu apă la înmuiat. Ai grijă ca apa din vas să acopere integral fasolea.\r\nPasul 2 – Pregătirea pâinii\r\nIa un bol micuț și amestecă bine drojdia, sarea și puțină apă călduță. Toată această compoziție adaugă peste Făina Standard 650 Raftul Bunicii. Suflecă-ți bine mânecile și începe să alinți cu grijă aluatul de pâine. Treptat, adaugă apă și continuă să frămânți până când obții un aluat care se dezlipește de pe mâni. După ce ai terminat, lasă-l la odihnit pentru aproximativ o oră.\r\nDupă ce aluatul a crescut vesel și frumos, împarte-l în patru părți egale și așază-l în tot atâtea tăvi rotunde tapetate în prealabil cu ulei și făină. După ce ai așezat aluatul în forme, mai lasă-l puțin să crească, apoi lasă-l la cuptor pentru o oră.\r\nDupă ce pâinicile sunt gata, le poți unge cu un ou pentru a prinde un aspect auriu și minunat, iar apoi lasă-le la cuptor pentru încă 5 minute.\r\nPasul 3 – Pregătirea ciorbei\r\nDupă ce ai terminat pâinica, este timpul să te apuci de pregătit ciorba. Ia mai întâi o oală mare și pune la fiert fasolea pe care ai lăsat-o cu o seară înainte la înmuiat. Ea trebuie să fiarbă aproximativ 10 minute. Într-o oală separată, pune la fiert și carnea din ciolanul afumat sau costița și fierbe-o tot în jur de 10 minute.\r\nAcum trebuie să iei o altă oală mai mare și călește ceapa, morcovii, ardeiul și condimentele ( boia, sare, piper) în ea. După ce toate legumele au prins o culoare frumoasă, poți adăuga apa, țelina, apoi fasolea și carnea fierte. Lasă totul pe foc și când apa începe să danseze, adaugă sucul de roșii, cimbrul și tarhonul. Mai fierbe apoi ciorba pentru aproximativ 10 minute și poți opri focul.\r\nPasul 4 – Servirea\r\nIa fiecare pâinică și taie vârful acesteia pentru a forma un capac. Scoate miezul, astfel încât pâinica să rămână goală. Pune pâinea pe o farfurie, umple-o cu ciorbița de fasole realizată anterior, apoi acoperă totul cu capacul din coajă.\r\n", "2 ore", 4, "Fel principal" },
                    { 26, "", 0, 0, "Specialitate munteneasca cu ciuperci", "Primul pas constă în pregătirea unui aluat de clătite și înarmarea cu multă răbdare pentru a prăji uniform, fiecare clătită în tigaia încinsă, de teflon.\r\nLasă clătitele aurii la odihnit și pregătește, între timp, compoziția. Într-un bol încăpător, amestecă făina, sarea și ouăle, încorporează laptele și apa minerală carbogazoasă, responsabilă de aspectul pufos și de consistența aerată a umpluturii. Taie ceapa mărunt-mărunt și călește-o rapid în ulei; adaugă peste ea ciupercile tăiate în felii subțiri și lasă totul pe foc pentru 15 minute, amestecând din când în când. Adaugă compoziția peste ceapă și ciuperci și mai lasă la foc mic, pentru maximum 10 minute, amestecând continuu cu o spatulă din lemn.\r\nÎntr-un vas termorezistent și suficient de înalt, așază prima clătită, peste care pune un strat uniform de umplutură. Repetă acest pas până consumi toate ingredientele. Poți strecura printre straturi și felii subțiri de roșii ori de castraveți murați ori după cum te ghidează pofta. Dă la cuptor, la 175 de grade Celsius, pentru aproximativ 15 minute.\r\nOrnează cu pătrunjel proaspăt, cu roșii-cherry sau frunze de salvie.\r\n", "NA", 4, "Fel principal" },
                    { 27, "", 0, 0, "Bors de Leurda", "cartofii se taie cubulete si se pun la fiert in 2 l de apa cu sare, timp de 10 minute;\r\nseparat, se pune la fiert borsul;\r\nceapa se toaca, iar leuda se taie fideluta, apoi se adauga peste cartofi si se mai lasa pe foc, acoperit, inca 15 minute;\r\nse adauga apoi si borsul si se mai lasa pentru cateva clocote;\r\nse sareaza si se pipereaza;\r\nleusteanul se toaca si se presara peste fiertura;\r\nse drege cu ou batut cu smantana.\r\n", "NA", 4, "Fel principal" },
                    { 28, "", 0, 0, "Mamaliga Toponita", "Începe să preîncălzești cuptorul.\r\nPe aragaz, pune într-un ceaun apa cu sare la fiert. Cu zâmbetul pe buze, îndreaptă-te spre blatul de lucru din bucătărie și începe să tai în cuburi mărunte toate tipurile de carne. Apucă degrabă o tigaie întinsă, toarnă ulei în ea și pune-o pe un alt ochi de aragaz. În ea vei prăji cubulețele de carne.\r\nCând apa din ceaun dă în clocot, începe să presari din abundență Mălai Extra Gold Raftul bunicii, pentru a face mămăliga. Este bine să o faci cât mai moale în această etapă.\r\nDupă ce carnea s-a prăjit bine, pune cubulețele într-un alt vas. Cu o parte din untura topită rămasă în tigaie, unge tava în care vei pune la cuptor toponita. Cealaltă parte o vei adăuga în compoziție.\r\nPe tava tapetată cu untură, așază primul strat de mămăligă moale, cât de subțire poți. Peste acest strat, adaugă unul format din carnea friptă în tigaie. Continuă cu încă un strat de mămăligă, după care adaugă unul de brânză telemea, de oaie sau vacă, după preferințe. Peste stratul de brânză, toarnă unul de untură topită, apoi un alt strat de carne friptă, unul de mămăligă, unul de brânză, și continuă tot așa, până când observi că ai terminat ingredientele. Aplică secretul care va asigura reușita toponitei: ai grijă ca ultimul strat de deasupra să fie cel format din mămăligă.\r\nAcum, bate oul și unge cu el mămăliga. Ia tava și așaz-o drăgăstos în cuptor, unde toponita se va rumeni voioasă, în aproximativ 20 sau 30 de minute. Servește-o cât e caldă, de preferat cu smântână rece!\r\n", "40 min", 3, "Fel principal" },
                    { 29, "", 0, 0, "Cornuri cu magiun", "Ia un castron mic din bucătărie și freacă drojdia cu 1 lingură de zahăr, până când se lichefiază. Pentru drojdia uscată, folosește 3-4 linguri de lapte cald și 1 lingură de zahăr.\r\nIa un bol încăpător și cerne cu dedicare Făina Superioară 000 Raftul bunicii, peste care adaugă coaja de lămâie fin răzuită, amestecă bine ingredientele, după care toarnă drojdia.\r\nÎntr-un mic bol, bate oul întreg cu 3 dintre gălbenușuri, laolaltă cu zahărul rămas, apoi incorporează treptat extractul de vanilie, sarea și laptele cald. Toarnă această compoziție peste făină.\r\nCu o spatulă sau o lingură de lemn, amestecă bine compoziția, până când făina absoarbe lichidele, iar apoi frământă cu grijă timp de 10 minute, până când vei obține un aluat omogen.\r\nEste momentul să adaugi untul moale, treptat, și să continui frământatul până rezultă un aluat fin și moale. Pune aluatul obținut la odihnit într-un castron, la căldură, și lasă-l așa până când își dublează volumul. Îi va lua în jur de 45 de minute sau 1 oră.\r\nPe blatul de lucru, toarnă puțin ulei și răstoarnă aluatul crescut, pe care apoi îl întinzi cu palmele sau un sucitor, în formă rotundă, de 1 cm grosime.\r\nÎmparte cercul în 12 triunghiuri egale, cu ajutorul unui cuțit cu vârf ascuțit. La baza triunghiurilor, pune în cantitate egală o bilă de magiun. Acum, rulează aluatul de la bază spre vârf, astfel încât magiunul să rămână protejat, la mijloc. Formează cornulețele și așază-le pe o tavă de copt tapetată cu hârtie, cu vârful aluatului dedesubt, pentru a nu se desface în cuptor.\r\nMai lasă cornurile în tavă, pentru a-și mări volumul, iar după aceea unge-le cu gălbenușul de ou rămas, bătut cu 3 linguri de apă.\r\nÎncinge cuptorul la 190 de grade Celsius, așază tava în interiorul acestuia la o înălțime medie, iar apoi redu temperatura la 180 de grade. În 25 de minute, cornurile vor căpăta rumeneala mult dorită.\r\nÎn timpul coacerii, aplică secretul care te va ajuta să obții cornuri bine coapte și crocante: acoperă-le cu o folie de aluminiu sau o coală de hârtie de copt umezită, asta deoarece aluatul dulce se va rumeni mai repede decât se va coace în interior.\r\nLa final, scoate cornurile pe tava, presară-le cu zahăr pudră și adună pofticioșii în jurul mesei, pentru a se răsfăța cu o delicatesă splendidă, culeasă tocmai din Crișana.\r\n", "2 ore", 3, "Desert" },
                    { 30, "", 0, 0, "Supa de gulii", "Taie morcovii rondele și ceapa mărunt, apoi, călește-le în ulei. În timp ce se rumenesc, rade deasupra lor guliile─ pe dinții mari─ și mai lasă totul pe foc, timp de 5 minute.\r\nAdaugă supa și potrivește de sare. Din făină, ou și apă, pregătește găluște de mărimea unui ou de porumbel, pe care le adaugi în supă, când legumele s-au fiert.\r\nAșteaptă ca găluștele să capete consistență, apoi, adaugă mărar și pătrunjel și stinge focul. Acoperă pentru câteva minute, apoi servește cu smântână.\r\n", "NA", 3, "Fel principal" },
                    { 31, "", 0, 0, "Gimicus", "Slanina sau costita afumata se taie feliute si se prajeste in tigaie (in tipsie din tuci), in ulei Arpis.\r\nCarnatul afumat se taie rondele si se adauga si el peste slaninuta, impreuna cu caltabosul taiat felii.\r\nSe prepara malaiul copt din faina Arpis, pe baza retetei folosite in Banat si Crisana \r\nDupa ce s-a racit malaiul copt, se sfarama peste ingredientele de mai sus si se amesteca totul astfel incat sa absoarba malaiul din grasimea lasata de la prajit, dupa care se poate servi cu muraturi.\r\n", "NA", 3, "Fel principal" },
                    { 32, "", 0, 0, "Supa crema de praz", "1. În oala de fiert supa se topeşte untul şi se pun prazul tăiat rondele şi ceapa tăiată peştişori. Se amestecă şi se lasă 10 minute să se înmoaie.\r\n2. Se adaugă cartofii curăţaţi şi tăiaţi rondele foarte subţiri. Se lasă 2 minute să se călească uşor.\r\n3. Se adaugă sare, piper, nucşoară, lapte şi apă şi se lasă la fiert 30 de minute.\r\n4. Apoi, se mixează ingredientele şi se aduce supa imediat la masă presărată cu mărar.\r\n", "45 min", 5, "Fel principal" },
                    { 33, "", 0, 0, "Ciorba de praz", "1. În oala de fiert ciorba se încinge uleiul şi se căleşte un pic afumătura. Apoi se scoate.\r\n2. În acelaşi ulei se pun la călit întâi bulionul şi, după un minut, se adaugă ceapa, morcovul şi prazul tăiate mărunt.\r\n3. Se adaugă afumătura, se pun doi litri de apă şi se lasă la fiert pentru 20 de minute.\r\n4. Când prazul şi carnea au fiert, se pun roşiile fără pieliţe şi se mai lasă pe foc 10 minute, potrivind gustul de sare.\r\n", "40 min", 5, "Fel principal" },
                    { 34, "", 0, 0, "Tarta de praz cu morcovi", "1. Morcovii se răzuiesc şi se trec prin răzătoarea cu ochiuri mari. Prazul se curăţă şi se taie rondele fine.\r\n2. Într-o lingură de ulei, se călesc legumele până devin translucide şi apoi se lasă să se răcească.\r\n3. Ouăle se bat ca pentru omletă, se adaugă laptele şi brânza trecută prin răzătoare.\r\n4. Se amestecă ouăle cu legumele, sare şi piper, după gust, şi se toarnă într-o formă rotundă sau o cratiţă care merge la cuptor. Se dă la copt pentru 45 de minute până ce o scobitoare introdusă iese curată.", "65 min", 5, "Aperitiv" },
                    { 35, "", 0, 0, "Saramura de pui", "Începe prin a spăla bine și prin a porționa puiul. Masează apoi bucățile de pui cu sare și piper din belșug. Pune bucățile de carne pe grătarul încins, apoi spală roșiile și ardeii grași și așază-i tacticos lângă carne. Ai grijă să nu se ardă nici legumele, nici puiul, acestea trebuie să rămână suculente, așa că, le poți întoarce de oricâte ori este nevoie, pentru a se pătrunde bine.\r\nÎntre timp, cât se rumenesc legumele și puiul, umple cu apă o oală potrivită, adaugă sare și las-o la foc mic, până ce începe să clocotească. Atunci când ardeii grași și roșiile s-au copt, pune-le cu grijă, rând pe rând, în apa care clocotește. Poți toca mărunt aceste legume sau le poți lăsa întregi, după cum știi că vă plac în familie.\r\nCurăță usturoiul și pisează-l, apoi adaugă-l în oală, alături de boabele de piper, ardeiul iute tocat mărunt, dar și de tarhon. După ce acest amestec dă iar în clocot, este momentul să oprești focul, pentru că toate aromele s-au întrepătruns și este exact ce trebuie să fie.\r\nCât ai clipi, iată că și puiul de pe grătar este rumenit și arată delicios!  Așază-l tacticos într-o tavă sau într-un vas de yena și toarnă peste el toată saramura de legume și condimente pregătită mai devreme. Lasă-l să se mai odihnească la cuptor, vreme de 15 minute, la o temperatură de maximum 180 de grade.\r\nImediat ce scoți saramura de pui din cuptor, presară pe deasupra pătrunjelul și leușteanul tocate mărunt.\r\n", "70 min", 5, "Fel principal" },
                    { 36, "Turta de mălai sau pâinea bunicilor este o rețetă oltenească mai puțin cunoscută în zilele noastre. Cu toate acestea, dacă o întrebi pe bunica, o să-ți povestească nostalgică despre vremurile în care aceasta era aproape nelipsită din bucătăria țărănească.\r\nConsumată atât pe timp de vară, cât și pe timp de iarnă, coaptă la cuptor de cărămidă sau țest, turta de mălai însoțea pe vremuri orice fel de mâncare și era frecvent consumată de gospodari. Acest lucru se datora faptului că oamenii nu puteau mânca numai mămăligă, iar pâinea era mult prea scumpă. Astfel, turta de mălai era cel mai bun înlocuitor.\r\nÎn zilele noastre, tinerii curioși încă testează această rețetă delicioasă și ușor de făcut. Iar pentru cine știe să facă mămăligă sau pâine, este floare la ureche să prepare turta de mălai.\r\nȘi pentru că astăzi este despre amintiri, despre tradiție și despre nostalgia vremurilor trecute, te invităm mai aproape de copilăria bunicilor, testând și tu această rețetă simplă și gustoasă, ce are o tradiție românească îndelungată.\r\n", 0, 0, "Turta de malai", "Pasul 1\r\nPrimul pas pentru a realiza o turtă de mălai este pregătirea unui păsat (a unei mămăligi moi). Acestea fiind spuse, pregătește o oală cu apă pe care trebuie să o pui la fiert și presară 2 lingurițe de sare în ea. Apa trebuie să ajungă la aproximativ 70 de grade.\r\nAsigură-te că nu va da în clocot, altfel există posibilitatea ca mălaiul să facă multe cocoloașe. Când apa s-a încălzit suficient, toarnă două polonice de Mălai Extra Gold Raftul bunicii și amestecă în mod constant și cu multă grijă, timp de aproximativ 10 minute, pentru ca păsatul să nu adune cocoloașe. În timp ce amesteci, adaugă treptat mai mult mălai, până când obții consistența unei mămăligi moi.\r\nPasul 2\r\nPregătește un bol mare în care să pui toată Făina Superioară 000 Raftul bunicii. După ce ai pregătit mămăliga, pune-o, așa fierbinte cum este, peste făina din bol. Amestecă apoi totul foarte bine până când obții o compoziție omogenă și fină.\r\nPasul 3\r\nDupă ce ai terminat de amestecat, lasă puțin compoziția la răcit, apoi suflecă-ți bine mânecile și începe să modelezi frumos turta. Pregătește o tavă unsă cu puțin unt, iar apoi așază turta în ea cu mare grijă. Umezește-ți mâinile cu puțină apă și modelează partea de sus a turtei pentru a închide crăpăturile de la suprafață.\r\nPasul 4\r\nPune tava la cuptorul încins în prealabil la 180 de grade, pentru aproximativ o oră, până când turta se coace foarte bine și prinde o culoare rumenă frumoasă.\r\nDupă ce se răcește te poți bucura de o turtă tradițională gustoasă și fragedă realizată în doar 4 pași simpli. Nu uita să-i chemi și pe cei dragi la masă.\r\n", "80 min", 5, "Aperitiv" },
                    { 37, "", 0, 0, "Tochitura Dobrogeana", "Pasul 1\r\nPrima dată, ia carnea de porc, pe care o tai în cubulețe medii. Pregătește o tigaie încăpătoare și pune uleiul sau untura la încins. Când a devenit suficient de fierbinte, adaugă bucățelele de carne și lasă-le pe foc până când încep să albească. Adaugă acum cele două căni de apă, piperul boabe și foile de dafin.\r\nPasul 2\r\nLasă totul la fiert la foc mic pentru aproximativ 30 de minute, până când carnea devine moale, iar sosul scade. După ce sosul a scăzut suficient, iar carnea este numai bună, poți adăuga vinul, pasta de roșii și usturoiul tocat mărunțel. Amestecă totul foarte bine, apoi potrivește gustul preparatului cu sare, boia, cimbru și piper. Mai lasă totul pe foc aproximativ 10 minute, apoi poți pune tochitura deoparte.\r\nPasul 3\r\nAcum este timpul să te pregătești mămăliguța cremoasă alături de care vei servi tochitura dobrogeană. Pentru aceasta ai nevoie de:\r\n1 pahar de Mălai Extra Gold Raftul Bunicii - good\r\n4 pahare cu apă - good\r\n1 praf de sare\r\n1 lingură de unt\r\nMod de preparare mămăligă cremoasă\r\nPasul 1\r\nDupă ce ai făcut rost de toate ingredientele, pune apa la fiert până când începe să fiarbă, toarnă apoi mălaiul în ploaie și amestecă continuu pentru a nu forma cocoloașe.\r\nPasul 2\r\nPăstrează mămăliga la foc mic până când devine cremoasă și se desprinde de marginile vasului. Răstoarn-o apoi pe o farfurie mare și ai terminat.\r\nPasul 3\r\nDupă ce mămăliguța este gata, pregătește câte un ou ochi pentru fiecare porție de tochitură și rade deasupra acestuia brânza de vaci.\r\nAșază toate elementele pe farfurie și apoi îi poți chema pe cei dragi pentru a servi o masă tradițională delicioasă, așa cum se servește și în zona Dobrogei.\r\n", "50 min", 6, "Fel principal" },
                    { 38, "Cu brânză sărată, dulce sau simplă, plăcinta dobrogeană este un preparat de mare tradiție în familiile românești, nelipsit de pe mesele de sărbătoare.\r\nÎn Dobrogea, există chiar o tradiție culinară, care continuă să fie transmisă din generație în generație, în care mireasa, a doua zi după nuntă, trebuie să pregătească o plăcintă dobrogeană pentru toți musafirii și să demonstreze că poate face cea mai subțire foaie de plăcintă. În acest fel, rețeta bunicii poate fi transmisă mai departe și poate bucura generațiile viitoare.\r\n", 0, 0, "Placinta Dobrogeana", "Pasul 1\r\nPrima dată vei începe cu prepararea foii de plăcintă. Pentru aceasta ai nevoie de un bol micuț, în care trebuie să amesteci drojdia cu o linguriță de zahăr, până când obții o pastă lichidă.\r\nSeparat, într-un bol mai mare, adaugă un kg de Făină Superioară 000 Raftul bunicii, pasta pe care ai preparat-o anterior, două linguri de ulei, două linguri de oțet și două-trei lingurițe de sare.\r\nAcum este timpul să îți sufleci bine mânecile, și cu zâmbetul pe buze, să te apuci de frământat. Dacă ți se pare că aluatul devine foarte lipicios, adaugă treptat mai multă făină, până când observi că ți se desprinde de pe mâini. După de ai terminat de frământat, împarte coca în două bucăți mari și lasă-le la odihnit în timp ce te ocupi de compoziție.\r\nPasul 2\r\nPentru a prepara compoziția, pregătește un bol mare în care vei începe să razi brânza sărată. Peste aceasta adaugă cele trei ouă, pliculețele de zahăr vanilat, coaja rasă de la o lămâie și cana cu zahăr. Apoi, începe să amesteci toate ingredientele foarte bine.\r\nPasul 3\r\nIa cele două două bucăți de aluat pe care le-ai lăsat la dospit și împarte-le pe jumătate, astfel încât, să obții patru mingiuțe de cocă.\r\nPresară puțină făină pe blatul de lucru și cu ajutorul unui sucitor, întinde prima foaie de plăcintă. Stropește-o cu puțin ulei, apoi adaugă câteva linguri din compoziția cu brânză doar în partea de jos a foii. Întinde foarte bine compoziția, apoi, apucă partea de foaie liberă și acoperă cu ea cealaltă parte care conține crema de brânză.\r\nAstfel, vei obține un pachețel delicios gata de pus în tavă. Procedează în același fel și cu celelalte trei foi de plăcintă.\r\nPasul 4\r\nPregătește o tavă încăpătoare și așază cele patru foi de plăcintă umplute cu brânză, după ce ai uns-o în prealabil cu ulei. Înainte de a pune totul la cuptor, ia un bol micuț și amestecă foarte bine două ouă și o cană de iaurt. După ce ai obținut un mix omogen, întinde totul peste plăcintă și asigură-te că întinzi uniform compoziția.\r\nPasul 5\r\nAcum, plăcinta este gata să stea la cuptor aproximativ 40-50 de minute, la foc mic. La final, vei obține o plăcintă aromată și gustoasă, de care cei dragi cu greu se vor putea sătura.\r\n", "90 min", 6, "Desert" },
                    { 39, "", 0, 0, "Peste cu sos de rosii", "1. Ceapa şi ardeii se taie cubuleţe mici care se pun la călit în ulei. Se presară cu un praf de sare.\r\n2. Se taie şi roşiile, cât se poate de mici, şi se adaugă. Se lasă 10 minute să-şi lase apa şi apoi se adaugă bulionul desfăcut şi el cu puţină apă. Se lasă la fiert alte 10 minute.\r\n3. Se pune peştele curăţat de cap şi coadă, chiar fileuri dacă se poate, şi se lasă să fiarbă în acest sos de legume timp de 10 minute.\r\n4. Se aduce la masă cu pătrunjel.\r\n", "30 min", 6, "Fel principal" },
                    { 40, "", 0, 0, "Saramura de Crap", "1. Într-o oală, se pune un litru de apă la fiert cu boabele de piper, sare, frunze de dafin, ardei iute tocat şi roşioare. Se lasă să fiarbă 10 minute şi se dă deoparte. Se adaugă mărarul tocat mărunt.\r\n2. Pe grătarul încins se frig medalioanele de peşte şi, pe măsură ce se rumenesc, se scot şi se pun într-un vas. Se presară felioare de usturoi.\r\n3. Se toarnă zeama fiartă cu roşiile şi se lasă 10 minute înainte de a-l aduce la masă.\r\n", "55 min", 6, "Fel principal" },
                    { 41, "", 0, 0, "Bors de Macrou", "1. Pestele se spala si se taie bucaţi nu mai late de doua degete.\r\n2. Ardeiul se taie fâsii, iar morcovul si radacina de patrunjel se trec prin razatoare. Se pun la fiert legumele cu 1,5 litri de apa si sare.\r\n3. Între timp, se da borsul într-un clocot si se toarna în oala alaturi de legume. Se adauga pestele si rosiile, se potriveste de gust cu sare si piper si se lasa la fiert înca 10 minute. Pentru ca macroul este gras, nu se adauga ulei.\r\n4. Se stinge focul, se presara patrunjelul si se aduce borsul la masa.\r\n", "70 min", 6, "Fel principal" },
                    { 42, "", 0, 0, "Cherdele", "Se face un aluat simplu din făină, apă, sare, drojdie și puțin ulei.\r\nCât se lasă aluatul la dospit, se face umplutura care este din brânză amestecată cu ou ,smântână și verdeață (mărar și foi de ceapă verde) tocată mărunt.\r\nCând coca a dospit, se întind foi late cât palma, pe mijlocul acestora se pune umplutura, se rulează odată pe lățime și se porționează în bucăți. Se așează pe o tavă unsă cu untură (sau ulei), apoi se bagă în cuptorul bine încins. Când cherdelele sunt aproape coapte, se ung pe deasupra cu un amestec de iaurt, smântână sau lapte dulce și ouă astfel la 400 g de iaurt se bat 3-4 ouă. Se reintroduce tava din nou în cuptor și se mai lasă până se rumenesc frumos.\r\n", "NA", 6, "Desert" },
                    { 43, "Urda este ridicata la rang de mare cinste in Maramures. Pe vreme rece, mamaliguta calda cu urda este nelipsita de pe mese, dar atunci cand vine primavara, urda isi gaseste alte utilizari in bucataria maramureseana, utilizari cel putin la fel de delicioase. O gustare rapida cu urda este perfecta pentru perioada de primavara cand legumele incep sa capete gustul acela aparte de proaspat iar aroma de ceapa verde face orice masa mai imbietoare. Acesta este momentul in care in Maramures incep sa se pregateasca clatite cu urda si verdeata.\r\n", 0, 0, "Clatite cu Urda si verdeata", "Se bat ouale cu un varf de sare timp de 1 – 2 minute. Se toarna de sus si imprastiat faina pana cand se obtine un aluat fin, apoi se adauga apa minerala si laptele. Compozitia se lasa in frigider pentru 30 de minute.\r\nSe pregateste separat umplutura din verdeata tocata marunt, untul lasat la inmuiat, urda, ceapa verde, leurda si sare dupa gust.\r\nDupa ce compozitia a fost racita, se unge o tigaie cu ulei si se lasa la incins apoi se toarna cate un polonic din compozitie in maniera obisnuita pentru prepararea clatitelor.\r\nClatitele astfel obtinute se umplu cu crema de urda si verdeturi.\r\n", "NA", 9, "Desert" },
                    { 44, "", 0, 0, "Coltunasi cu legume", "Se framanta untul cu faina si se adauga 5 – 6 linguri de apa, o lingurita de otet si un praf de sare. Aluatul framantat astfel obtinut se pune la rece pentru jumatate de zi.\r\nCu 30 de minute inainte ca aluatul sa fie scos de la frigider se taie legumele in cubulete cat mai marunte si se pun la fiert in apa cu sare si piper.\r\nAluatul luat de la frigider se intinde si se taie in forma de cercuri ce se umplu cu legumele fierte se impaturesc pe jumatate si se lipesc cu apa sau cu albus de ou. Marginile coltunasilor se cresteaza cu furculita din motive de prezentare.\r\nScoicile de aluat cu legume se prajesc in ulei incins pana cand capata o culoare aurie.\r\n", "NA", 9, "Desert" },
                    { 45, "", 0, 0, "Supa cu porumb si cascaval", "Pentru a prepara supa de porumb cu cascaval se incepe de la o baza de supa de legume clasica, strecurata.\r\nIntr-o oala incinsa cu unt topit se calesc ceapa uscata, bulbii de ceapa verde si usturoiul pana devin transparente.\r\nSe adauga supa fierbinte de legume impreuna cu chimenul.\r\nSe adauga porumbul (de preferinta porumb congelat) impreuna cu cartofii taiati cuburi si se lasa la fiert 15 minute dupa care se aduna intr-un vas separat cartofii si 200 grame de porumb. Cartofii si porumbul scosi din oala se piseaza si se amesteca cu cascavalul ras si smantana.\r\nDupa ce supa ramasa in oala da in clocot se adauga piureul nou obtinut din cascaval, porumb, cartofi si smantana si se mai lasa la clocotit 4 – 5 minute timp in care se amesteca in continuu.\r\nSe condimenteaza dupa gust.\r\nSe serveste alaturi de cascaval ras si cozi de ceapa verde pentru a fi adaugate in farfurie in functie de gustul fiecarui mesean.\r\n", "NA", 9, "Fel principal" }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId" },
                values: new object[,]
                {
                    { 1, 1, "500 g", 1 },
                    { 2, 2, "2 bucati", 1 },
                    { 3, 3, "O bucata", 1 },
                    { 4, 4, "1/4 Bucata", 1 },
                    { 5, 5, "1/2 Bucata", 1 },
                    { 6, 6, "4 Bucati", 1 },
                    { 7, 7, "O bucata", 1 },
                    { 8, 8, "O bucata", 1 },
                    { 9, 9, "1/2 lingurita", 1 },
                    { 10, 10, "200 ml", 1 },
                    { 11, 11, "2 crengute", 1 },
                    { 12, 12, "O lingurita", 1 },
                    { 13, 13, "4 linguri", 1 },
                    { 14, 14, "Un", 1 },
                    { 15, 15, "o lingurita", 1 },
                    { 16, 16, "", 1 },
                    { 17, 17, "", 1 },
                    { 18, 18, "", 1 },
                    { 19, 19, "", 1 },
                    { 20, 2, "3 bucati", 2 },
                    { 21, 21, "O legatura", 2 },
                    { 22, 22, "O bucata", 2 },
                    { 23, 8, "O bucata", 2 },
                    { 24, 23, "2 bucati", 2 },
                    { 25, 24, "Un catel", 2 },
                    { 26, 15, "300 ml", 2 },
                    { 27, 14, "3 bucati", 2 },
                    { 28, 16, "2 linguri", 2 },
                    { 29, 25, "3 linguri", 2 },
                    { 30, 12, "4 linguri", 2 },
                    { 31, 9, "O lingura", 2 },
                    { 32, 17, "", 2 },
                    { 33, 18, "", 2 },
                    { 34, 7, "O", 2 },
                    { 35, 26, "300 g", 3 },
                    { 36, 8, "O bucata", 3 },
                    { 37, 2, "Doua bucati", 3 },
                    { 38, 27, "Un", 3 },
                    { 39, 9, "4 linguri", 3 },
                    { 40, 28, "800 ml", 3 },
                    { 41, 29, "500 ml", 3 },
                    { 42, 21, "", 3 },
                    { 43, 15, "100 ml", 3 },
                    { 44, 30, "700 g", 4 },
                    { 45, 8, "O", 4 },
                    { 46, 31, "Doua bucati", 4 },
                    { 47, 32, "", 4 },
                    { 48, 33, "200 g", 4 },
                    { 49, 7, "O", 4 },
                    { 50, 34, "1/4 lingurita", 4 },
                    { 51, 18, "", 4 },
                    { 52, 17, "", 4 },
                    { 53, 10, "3-4 linguri", 4 },
                    { 54, 35, "2 bucati", 4 },
                    { 55, 9, "250 g", 5 },
                    { 56, 29, "150 ml", 5 },
                    { 57, 36, "1/2 cub", 5 },
                    { 58, 17, "", 5 },
                    { 59, 38, "2 linguri", 5 },
                    { 60, 16, "2 cani", 5 },
                    { 61, 40, "200 g", 5 },
                    { 62, 44, "1 kg", 6 },
                    { 63, 29, "5 L", 6 },
                    { 64, 88, "4", 6 },
                    { 65, 8, "2", 6 },
                    { 66, 45, "1", 6 },
                    { 67, 33, "250 ml", 6 },
                    { 68, 24, "O capatana", 6 },
                    { 69, 12, "2-4 linguri", 6 },
                    { 70, 27, "2-3 bucati", 6 },
                    { 71, 18, "", 6 },
                    { 72, 17, "", 6 },
                    { 73, 46, "", 7 },
                    { 74, 47, "", 7 },
                    { 75, 38, "350 g", 7 },
                    { 76, 13, "600 ml", 7 },
                    { 77, 48, "10 lingurite", 7 },
                    { 78, 49, "500 g", 7 },
                    { 79, 50, "", 7 },
                    { 80, 39, "2 pliculete", 7 },
                    { 81, 17, "O lingurita", 7 },
                    { 82, 16, "8 Linguri", 7 },
                    { 83, 38, "10 Linguri", 7 },
                    { 84, 37, "50 g", 7 },
                    { 85, 27, "6 bucati", 7 },
                    { 86, 9, "1 kg", 7 },
                    { 87, 14, "Un", 7 },
                    { 88, 52, "6 bucati", 8 },
                    { 89, 53, "1 kg", 8 },
                    { 90, 54, "200 g", 8 },
                    { 91, 55, "1 L", 8 },
                    { 92, 2, "2-3 bucati", 8 },
                    { 93, 23, "2 bucati", 8 },
                    { 94, 45, "1-2 bucati", 8 },
                    { 95, 17, "", 8 },
                    { 96, 18, "", 8 },
                    { 97, 19, "o lingurita", 8 },
                    { 98, 21, "o legatura", 8 },
                    { 99, 89, "400 g", 9 },
                    { 100, 52, "6 bucati", 9 },
                    { 101, 54, "300 g", 9 },
                    { 102, 56, "300 g", 9 },
                    { 103, 2, "3- 4 bucati", 9 },
                    { 104, 8, "2 bucati", 9 },
                    { 105, 45, "2 bucati", 9 },
                    { 106, 10, "400 g", 9 },
                    { 107, 16, "3-4 linguri", 9 },
                    { 108, 17, "", 9 },
                    { 109, 18, "", 9 },
                    { 110, 57, "O legatura", 9 },
                    { 111, 34, "", 9 },
                    { 112, 62, "8", 10 },
                    { 113, 63, "50 g", 10 },
                    { 114, 27, "1", 10 },
                    { 115, 41, "250 g", 10 },
                    { 116, 47, "2 fiole", 10 },
                    { 117, 39, "1 plic", 10 },
                    { 118, 38, "50 g", 10 },
                    { 119, 64, "50 g", 10 },
                    { 120, 14, "4 bucati", 10 },
                    { 121, 15, "200 g", 10 },
                    { 122, 38, "175 g", 10 },
                    { 123, 39, "1 plic", 10 },
                    { 124, 65, "4 bucati", 10 },
                    { 125, 17, "", 10 },
                    { 126, 1, "300 g", 11 },
                    { 127, 52, "4 bucati", 11 },
                    { 128, 66, "1-2 bucati", 11 },
                    { 129, 2, "Un", 11 },
                    { 130, 45, "1-2 bucati", 11 },
                    { 131, 10, "500 ml", 11 },
                    { 132, 20, "O lingurita", 11 },
                    { 133, 67, "300 g", 11 },
                    { 134, 21, "O legatura", 11 },
                    { 135, 16, "O lingurita", 11 },
                    { 136, 8, "600 g", 12 },
                    { 137, 68, "100 g", 12 },
                    { 138, 49, "100 g", 12 },
                    { 139, 16, "150 ml", 12 },
                    { 140, 72, "100 g", 12 },
                    { 141, 9, "20 g", 12 },
                    { 142, 38, "10g", 12 },
                    { 143, 70, "25 g", 12 },
                    { 144, 21, "", 12 },
                    { 145, 33, "100 ml", 12 },
                    { 146, 17, "", 12 },
                    { 147, 18, "", 12 },
                    { 148, 71, "Putin", 12 },
                    { 149, 52, "4 bucati", 13 },
                    { 150, 27, "Doua bucati", 13 },
                    { 151, 9, "200 g", 13 },
                    { 152, 60, "50 g", 13 },
                    { 153, 17, "", 13 },
                    { 154, 16, "O lingura", 13 },
                    { 155, 63, "40 g", 13 },
                    { 156, 73, "150 g", 13 },
                    { 157, 38, "", 13 },
                    { 158, 82, "", 13 },
                    { 159, 74, "11-12", 13 },
                    { 160, 75, "Un", 14 },
                    { 161, 2, "6 bucati", 14 },
                    { 162, 3, "1 radacina", 14 },
                    { 163, 76, "1", 14 },
                    { 164, 22, "O felie", 14 },
                    { 165, 77, "1 lingurita", 14 },
                    { 166, 8, "1 bucata", 14 },
                    { 167, 14, "4 bucati", 14 },
                    { 168, 9, "O lingura", 14 },
                    { 169, 15, "400 ml", 14 },
                    { 170, 24, "O capatana", 14 },
                    { 171, 17, "", 14 },
                    { 172, 75, "500 g", 15 },
                    { 173, 8, "1", 15 },
                    { 174, 2, "2-3 bucati", 15 },
                    { 175, 22, "1", 15 },
                    { 176, 78, "1", 15 },
                    { 177, 80, "1", 15 },
                    { 178, 79, "Cateva buchete de", 15 },
                    { 179, 52, "2 bucati", 15 },
                    { 180, 23, "O legatura", 15 },
                    { 181, 45, "1", 15 },
                    { 182, 17, "", 15 },
                    { 183, 18, "", 15 },
                    { 184, 16, "1-2 linguri", 15 },
                    { 185, 55, "500 ml", 15 },
                    { 186, 9, "600 g", 16 },
                    { 187, 38, "160 g", 16 },
                    { 188, 14, "3 bucati", 16 },
                    { 189, 37, "20 g", 16 },
                    { 190, 50, "Putina", 16 },
                    { 191, 63, "60 g", 16 },
                    { 192, 17, "1/2 lingurita", 16 },
                    { 193, 13, "300 ml", 16 },
                    { 194, 81, "O ceasca", 16 },
                    { 195, 29, "300 ml", 16 },
                    { 196, 47, "1/2 lingurita", 16 },
                    { 197, 51, "O felie", 16 },
                    { 198, 82, "Un bat", 16 },
                    { 199, 49, "250 g", 16 },
                    { 200, 83, "1 kg", 17 },
                    { 201, 63, "350 g", 17 },
                    { 202, 33, "2 L", 17 },
                    { 203, 27, "1", 17 },
                    { 204, 42, "600 g", 17 },
                    { 205, 84, "250 g", 17 },
                    { 206, 17, "", 17 },
                    { 207, 83, "250 g", 18 },
                    { 208, 13, "1 L", 18 },
                    { 209, 27, "4 bucati", 18 },
                    { 210, 41, "550 g", 18 },
                    { 211, 42, "100 g", 18 },
                    { 212, 33, "200 ml", 18 },
                    { 213, 63, "70 g", 18 },
                    { 214, 17, "", 18 },
                    { 215, 9, "500 g", 19 },
                    { 216, 13, "200 ml", 19 },
                    { 217, 27, "5 bucati", 19 },
                    { 218, 16, "100 ml", 19 },
                    { 219, 38, "350 g", 19 },
                    { 220, 17, "", 19 },
                    { 221, 37, "25 g", 19 },
                    { 222, 41, "350 g", 19 },
                    { 223, 39, "2 plicuri", 19 },
                    { 224, 46, "O fiola", 19 },
                    { 225, 60, "3 linguri", 19 },
                    { 226, 86, "200 g", 20 },
                    { 227, 30, "300 g", 20 },
                    { 228, 8, "1", 20 },
                    { 229, 24, "2 catei", 20 },
                    { 230, 52, "1", 20 },
                    { 231, 85, "2 felii", 20 },
                    { 232, 13, "", 20 },
                    { 233, 27, "2 bucati", 20 },
                    { 234, 17, "", 20 },
                    { 235, 18, "", 20 },
                    { 236, 57, "", 20 },
                    { 237, 21, "", 20 },
                    { 238, 73, "150 g", 20 },
                    { 239, 9, "3 linguri", 20 },
                    { 240, 9, "500 g", 21 },
                    { 241, 29, "(Aluat) 200 ml, (Fiert) 2L", 21 },
                    { 242, 17, "1/2 lingurita", 21 },
                    { 243, 38, "", 21 },
                    { 244, 49, "300 g", 21 },
                    { 245, 46, "", 21 },
                    { 246, 50, "", 21 },
                    { 247, 51, "", 21 },
                    { 248, 39, "Un plic", 21 },
                    { 249, 82, "", 21 },
                    { 250, 17, "", 22 },
                    { 251, 27, "1", 22 },
                    { 252, 26, "200 g", 22 },
                    { 253, 24, "O capatana", 22 },
                    { 254, 2, "4 bucati", 22 },
                    { 255, 8, "2 bucati", 22 },
                    { 256, 89, "400 g", 22 },
                    { 257, 87, "1/2", 22 },
                    { 258, 88, "4", 22 },
                    { 259, 18, "", 22 },
                    { 260, 83, "300 g", 23 },
                    { 261, 90, "700 g", 23 },
                    { 262, 29, "300 g", 23 },
                    { 263, 5, "300 g", 23 },
                    { 264, 91, "200 g", 23 },
                    { 265, 43, "200 g", 23 },
                    { 266, 33, "200 g", 23 },
                    { 267, 27, "4 bucati", 23 },
                    { 268, 17, "", 23 },
                    { 269, 60, "150 g", 24 },
                    { 270, 41, "350 g", 24 },
                    { 271, 39, "30 g", 24 },
                    { 272, 27, "2 bucati", 24 },
                    { 273, 50, "", 24 },
                    { 274, 17, "", 24 },
                    { 275, 73, "100 g", 24 },
                    { 276, 63, "20 g", 24 },
                    { 277, 33, "", 24 },
                    { 278, 9, "1.5 kg", 25 },
                    { 279, 36, "3 cubulete", 25 },
                    { 280, 29, "", 25 },
                    { 281, 17, "", 25 },
                    { 282, 1, "500 g", 25 },
                    { 283, 4, "", 25 },
                    { 284, 8, "1", 25 },
                    { 285, 4, "2 bucati", 25 },
                    { 286, 45, "1", 25 },
                    { 287, 22, "", 25 },
                    { 288, 11, "", 25 },
                    { 289, 34, "", 25 },
                    { 290, 18, "", 25 },
                    { 291, 19, "", 25 },
                    { 292, 10, "", 25 },
                    { 293, 9, "250 g", 26 },
                    { 294, 13, "500 ml", 26 },
                    { 295, 27, "3 bucati", 26 },
                    { 296, 92, "3 linguri", 26 },
                    { 297, 17, "", 26 },
                    { 298, 16, "", 26 },
                    { 299, 18, "", 26 },
                    { 300, 93, "500 g", 26 },
                    { 301, 8, "1", 26 },
                    { 302, 33, "350 g", 26 },
                    { 303, 94, "O farfurie", 27 },
                    { 304, 52, "2 bucati", 27 },
                    { 305, 27, "1", 27 },
                    { 306, 55, "1 L", 27 },
                    { 307, 33, "1 cana", 27 },
                    { 308, 17, "", 27 },
                    { 309, 18, "", 27 },
                    { 310, 83, "500 g", 28 },
                    { 311, 43, "200 g", 28 },
                    { 312, 5, "180 g", 28 },
                    { 313, 89, "100 g", 28 },
                    { 314, 27, "1", 28 },
                    { 315, 95, "", 28 },
                    { 316, 17, "", 28 },
                    { 317, 9, "500 g", 29 },
                    { 318, 96, "350 g", 29 },
                    { 319, 13, "200 ml", 29 },
                    { 320, 38, "100 g", 29 },
                    { 321, 63, "70 g", 29 },
                    { 322, 36, "20 g", 29 },
                    { 323, 14, "4 bucati", 29 },
                    { 324, 27, "1", 29 },
                    { 325, 47, "1 lingurinta", 29 },
                    { 326, 17, "", 29 },
                    { 327, 50, "", 29 },
                    { 328, 8, "1", 30 },
                    { 329, 78, "5-6 bucati", 30 },
                    { 330, 2, "1-2 bucati", 30 },
                    { 331, 27, "1", 30 },
                    { 332, 16, "100 ml", 30 },
                    { 333, 9, "2 linguri", 30 },
                    { 334, 28, "1.5 L", 30 },
                    { 335, 57, "O legatura", 30 },
                    { 336, 21, "O legatura", 30 },
                    { 337, 17, "", 30 },
                    { 338, 33, "", 30 },
                    { 339, 83, "", 31 },
                    { 340, 6, "", 31 },
                    { 341, 5, "", 31 },
                    { 342, 98, "", 31 },
                    { 343, 16, "", 31 },
                    { 344, 58, "2 bucati", 32 },
                    { 345, 8, "1", 32 },
                    { 346, 52, "4-5 bucati", 32 },
                    { 347, 63, "20 g", 32 },
                    { 348, 29, "1/2 L", 32 },
                    { 349, 13, "200 ml", 32 },
                    { 350, 57, "Cateva fire", 32 },
                    { 351, 97, "", 32 },
                    { 352, 17, "", 32 },
                    { 353, 18, "", 32 },
                    { 354, 8, "1", 33 },
                    { 355, 58, "2 bucati", 33 },
                    { 356, 5, "200 g", 33 },
                    { 357, 35, "6 bucati", 33 },
                    { 358, 10, "1 lingura", 33 },
                    { 359, 17, "", 33 },
                    { 360, 16, "2 linguri", 33 },
                    { 361, 58, "2 bucati", 34 },
                    { 362, 2, "4 bucati", 34 },
                    { 363, 27, "4 bucati", 34 },
                    { 364, 13, "200 ml", 34 },
                    { 365, 43, "100 g", 34 },
                    { 366, 16, "", 34 },
                    { 367, 17, "", 34 },
                    { 368, 18, "", 34 },
                    { 369, 75, "1", 35 },
                    { 370, 35, "5", 35 },
                    { 371, 45, "3 bucati", 35 },
                    { 372, 99, "1", 35 },
                    { 373, 24, "5 catei", 35 },
                    { 374, 77, "", 35 },
                    { 375, 17, "", 35 },
                    { 376, 21, "", 35 },
                    { 377, 11, "Un praf", 35 },
                    { 378, 83, "750 g", 36 },
                    { 379, 9, "250 g", 36 },
                    { 380, 29, "2 L", 36 },
                    { 381, 17, "2 lingurite", 36 },
                    { 382, 89, "1 kg", 37 },
                    { 383, 16, "50 ml", 37 },
                    { 384, 7, "2 bucati", 37 },
                    { 385, 77, "15", 37 },
                    { 386, 29, "2 cani", 37 },
                    { 387, 69, "1 pahar", 37 },
                    { 388, 10, "3 linguri", 37 },
                    { 389, 24, "1 capatana", 37 },
                    { 390, 17, "", 37 },
                    { 391, 18, "", 37 },
                    { 392, 20, "", 37 },
                    { 393, 9, "1 kg", 38 },
                    { 394, 36, "1 cub", 38 },
                    { 395, 38, "1 lingurita", 38 },
                    { 396, 12, "2 linguri", 38 },
                    { 397, 16, "2 linguri", 38 },
                    { 398, 29, "1 cana", 38 },
                    { 399, 17, "2-3 lingurite", 38 },
                    { 400, 27, "3 bucati", 38 },
                    { 401, 39, "2 pliculete", 38 },
                    { 402, 38, "O cana", 38 },
                    { 403, 40, "1 kg", 38 },
                    { 404, 50, "", 38 },
                    { 405, 21, "Cateva fire", 39 },
                    { 406, 16, "2 linguri", 39 },
                    { 407, 45, "1", 39 },
                    { 408, 8, "2 bucati", 39 },
                    { 409, 70, "2 linguri", 39 },
                    { 410, 35, "1 kg", 39 },
                    { 411, 100, "3-4 bucati", 39 },
                    { 412, 17, "", 39 },
                    { 413, 101, "4 bucati", 40 },
                    { 414, 99, "O bucata", 40 },
                    { 415, 35, "4", 40 },
                    { 416, 57, "o legatura", 40 },
                    { 417, 24, "2 catei", 40 },
                    { 418, 77, "10", 40 },
                    { 419, 7, "2 bucati", 40 },
                    { 420, 17, "", 40 },
                    { 421, 102, "2 bucati", 41 },
                    { 422, 2, "2 bucati", 41 },
                    { 423, 76, "1", 41 },
                    { 424, 45, "1", 41 },
                    { 425, 35, "2", 41 },
                    { 426, 55, "1 L", 41 },
                    { 427, 21, "O legatura", 41 },
                    { 428, 17, "", 41 },
                    { 429, 18, "", 41 },
                    { 430, 9, "1 kg", 42 },
                    { 431, 17, "1 lingurita", 42 },
                    { 432, 16, "1 ceasca", 42 },
                    { 433, 37, "50 g", 42 },
                    { 434, 41, "1 kg", 42 },
                    { 435, 40, "400 g", 42 },
                    { 436, 33, "400 g", 42 },
                    { 437, 23, "3 legaturi", 42 },
                    { 438, 57, "3 legaturi", 42 },
                    { 439, 90, "400 g", 42 },
                    { 440, 27, "3-4 bucati", 42 },
                    { 441, 9, "100 g", 43 },
                    { 442, 91, "300 g", 43 },
                    { 443, 92, "1 pahar", 43 },
                    { 444, 13, "O cana", 43 },
                    { 445, 27, "3 bucati", 43 },
                    { 446, 23, "O legatura", 43 },
                    { 447, 94, "O legatura", 43 },
                    { 448, 57, "1/2 legatura", 43 },
                    { 449, 33, "1 ceasca", 43 },
                    { 450, 63, "4 linguri", 43 },
                    { 451, 9, "400 g", 44 },
                    { 452, 63, "250 g", 44 },
                    { 453, 2, "200 g", 44 },
                    { 454, 22, "150 g", 44 },
                    { 455, 52, "150 g", 44 },
                    { 456, 12, "", 44 },
                    { 457, 103, "400 g", 45 },
                    { 458, 104, "250 g", 45 },
                    { 459, 8, "2 bucati", 45 },
                    { 460, 23, "1", 45 },
                    { 461, 24, "1-2 catei", 45 },
                    { 462, 52, "200 g", 45 },
                    { 463, 21, "2 legaturi", 45 },
                    { 464, 63, "Jumatate pachet", 45 },
                    { 465, 33, "Un pahar", 45 },
                    { 466, 105, "", 45 },
                    { 467, 28, "", 45 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients");

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.AlterColumn<int>(
                name: "Kcal",
                table: "IngredientDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 6,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 7,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 8,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 9,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 10,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 11,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 12,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 13,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 14,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 15,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 16,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 17,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 18,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 19,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 20,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 21,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 22,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 23,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 24,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 25,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 26,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 27,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 28,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 29,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 30,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 31,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 32,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 33,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 34,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Kcal", "Name" },
                values: new object[] { 0, "Rosii" });

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 36,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 37,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 38,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 39,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 40,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 41,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 42,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 43,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 44,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 45,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 46,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 47,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 48,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 49,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 50,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 51,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 52,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 53,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 54,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 55,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 56,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 57,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 58,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 59,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 60,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 61,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 62,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 63,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 64,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 65,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 66,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 67,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 68,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 69,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 70,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 71,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 72,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 73,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 74,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 75,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 76,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 77,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 78,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 79,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 80,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 81,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 82,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 83,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 84,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 85,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 86,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 87,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 88,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 89,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 90,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 91,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 92,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 93,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 94,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 95,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 96,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 97,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 98,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 99,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 100,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 101,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 102,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 103,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 104,
                column: "Kcal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 105,
                column: "Kcal",
                value: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId",
                unique: true);
        }
    }
}
