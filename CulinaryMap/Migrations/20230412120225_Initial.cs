using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CulinaryMap.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IngredientDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kcal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CulinaryHistory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    Latitude = table.Column<int>(type: "int", nullable: false),
                    Longitude = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrepMode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    History = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrepTime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_IngredientDetails_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "IngredientDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "IngredientDetails",
                columns: new[] { "Id", "Kcal", "Name" },
                values: new object[,]
                {
                    { 1, 0, "Fasole alba boabe" },
                    { 2, 0, "Morcov" },
                    { 3, 0, "Pastarnac" },
                    { 4, 0, "Ciolan Afumat" },
                    { 5, 0, "Carnat Afumat" },
                    { 6, 0, "Costita Afumata" },
                    { 7, 0, "Foaie Dafin" },
                    { 8, 0, "Ceapa alba" },
                    { 9, 0, "Faina" },
                    { 10, 0, "Suc de rosii" },
                    { 11, 0, "Tarhon" },
                    { 12, 0, "Otet" },
                    { 13, 0, "Lapte cald" },
                    { 14, 0, "Galbenus" },
                    { 15, 0, "Smantana de gatit" },
                    { 16, 0, "Ulei" },
                    { 17, 0, "Sare" },
                    { 18, 0, "Piper" },
                    { 19, 0, "Boia de ardei dulce" },
                    { 20, 0, "Boia de ardei iute" },
                    { 21, 0, "Patrunjel" },
                    { 22, 0, "Telina" },
                    { 23, 0, "Ceapa verde" },
                    { 24, 0, "Usturoi" },
                    { 25, 0, "Orez" },
                    { 26, 0, "Mazare" },
                    { 27, 0, "Ou" },
                    { 28, 0, "Supa de legume" },
                    { 29, 0, "Apa" },
                    { 30, 0, "Carne tocata porc" },
                    { 31, 0, "Varza Murata" },
                    { 32, 0, "Ulei de masline" },
                    { 33, 0, "Smantana" },
                    { 34, 0, "Cimbru" },
                    { 35, 0, "Rosii" },
                    { 36, 0, "Drojdie Proaspata" },
                    { 37, 0, "Drojdie Uscata" },
                    { 38, 0, "Zahar" },
                    { 39, 0, "Zahar Vanilat" },
                    { 40, 0, "Branza Sarata" },
                    { 41, 0, "Branza de vaci" },
                    { 42, 0, "Branza de oaie" },
                    { 43, 0, "Branza Telemea" },
                    { 44, 0, "Burta de vita" },
                    { 45, 0, "Ardei gras" },
                    { 46, 0, "Esenta de rom" },
                    { 47, 0, "Esenta de vanilie" },
                    { 48, 0, "Cacao" },
                    { 49, 0, "Nuca" },
                    { 50, 0, "Coaja de lamaie" },
                    { 51, 0, "Coaja de portocala" },
                    { 52, 0, "Cartof" },
                    { 53, 0, "Rasol de vitel" },
                    { 54, 0, "Fasole verde" },
                    { 55, 0, "Bors" },
                    { 56, 0, "Fasole Rosie Boabe" },
                    { 57, 0, "Marar" },
                    { 58, 0, "Praz" },
                    { 59, 0, "Slanina" },
                    { 60, 0, "Gris" },
                    { 61, 0, "Carne de miel" },
                    { 62, 0, "Clatite" },
                    { 63, 0, "Unt" },
                    { 64, 0, "Stafide" },
                    { 65, 0, "Albus" },
                    { 66, 0, "Ceapa rosie" },
                    { 67, 0, "Carnat iute" },
                    { 68, 0, "Masline" },
                    { 69, 0, "Vin Rosu" },
                    { 70, 0, "Bulion" },
                    { 71, 0, "Vin Alb" },
                    { 72, 0, "Paine inmuiata in lapte" },
                    { 73, 0, "Pesmet" },
                    { 74, 0, "Prune" },
                    { 75, 0, "Pui" },
                    { 76, 0, "Radacina de patrunjel" },
                    { 77, 0, "Boabe de piper" },
                    { 78, 0, "Gulie" },
                    { 79, 0, "Conopida" },
                    { 80, 0, "Dovlecel" },
                    { 81, 0, "Miere" },
                    { 82, 0, "Scortisoara" },
                    { 83, 0, "Malai" },
                    { 84, 0, "Cas" },
                    { 85, 0, "Paine" },
                    { 86, 0, "Carne tocata vita" },
                    { 87, 0, "Cap de porc" },
                    { 88, 0, "Picioare de porc" },
                    { 89, 0, "Carne de porc" },
                    { 90, 0, "Iaurt" },
                    { 91, 0, "Urda" },
                    { 92, 0, "Apa Carbogazificata" },
                    { 93, 0, "Ciuperci" },
                    { 94, 0, "Leurda" },
                    { 95, 0, "Jumari" },
                    { 96, 0, "Magiun" },
                    { 97, 0, "Nucsoara" },
                    { 98, 0, "Caltabos Afumat" },
                    { 99, 0, "Ardei iute" },
                    { 100, 0, "Peste (la alegere)" },
                    { 101, 0, "Medalion Crap" },
                    { 102, 0, "Macrou" },
                    { 103, 0, "Porumb" },
                    { 104, 0, "Cascaval" },
                    { 105, 0, "Chimen" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "CulinaryHistory", "Name" },
                values: new object[,]
                {
                    { 1, "In Transilvania, Banat si Crisana, influenta germana se face simtita prin varietatea de carnati si mezeluri, cum ar fi virsli sau casul de cap de porc, dar și în consumul de ciorbe groase și varza. Branza de burduf este una dintre specialitatile acestei regiuni, la fel ca si casul de Nasal, o alta branza, maturata intr-o pestera din Taga, Cluj. Influentele bucatariilor maghiare si sarbe sunt si ele simtite prin prezenta cozonacului secuiesc, gulasului sau a multor bauturi tari precum palinca, horinca si slibovita.", "Transilvania" },
                    { 2, "In Transilvania, Banat si Crisana, influenta germana se face simtita prin varietatea de carnati si mezeluri, cum ar fi virsli sau casul de cap de porc, dar și în consumul de ciorbe groase și varza. Branza de burduf este una dintre specialitatile acestei regiuni, la fel ca si casul de Nasal, o alta branza, maturata intr-o pestera din Taga, Cluj. Influentele bucatariilor maghiare si sarbe sunt si ele simtite prin prezenta cozonacului secuiesc, gulasului sau a multor bauturi tari precum palinca, horinca si slibovita.", "Banat" },
                    { 3, "In Transilvania, Banat si Crisana, influenta germana se face simtita prin varietatea de carnati si mezeluri, cum ar fi virsli sau casul de cap de porc, dar și în consumul de ciorbe groase și varza. Branza de burduf este una dintre specialitatile acestei regiuni, la fel ca si casul de Nasal, o alta branza, maturata intr-o pestera din Taga, Cluj. Influentele bucatariilor maghiare si sarbe sunt si ele simtite prin prezenta cozonacului secuiesc, gulasului sau a multor bauturi tari precum palinca, horinca si slibovita.", "Crisana" },
                    { 4, "Oltenia si Muntenia sunt cele doua provincii care au format in trecut Tara Romaneasca, vecina cu Bulgaria, Transilvania și Dobrogea. Cele doua regiuni au o lunga istorie de productie a vinului, cu trei regiuni mari viticole impartite in 13 mari podgorii. Din aceste regiuni provin mancaruri precum ostropelul, ciorba de burta, tuslamaua si ciorba de potroace. Oltenia este renumita pentru carnatii sai. Din Muntenia provin covrigii din Buzau, babicul, carnații de Plescoi, magiunul de Topoloveni si Salamul de Sibiu (originar, de fapt, din Sinaia).", "Muntenia" },
                    { 5, "Oltenia si Muntenia sunt cele doua provincii care au format in trecut Tara Romaneasca, vecina cu Bulgaria, Transilvania și Dobrogea. Cele doua regiuni au o lunga istorie de productie a vinului, cu trei regiuni mari viticole impartite in 13 mari podgorii. Din aceste regiuni provin mancaruri precum ostropelul, ciorba de burta, tuslamaua si ciorba de potroace. Oltenia este renumita pentru carnatii sai. Din Muntenia provin covrigii din Buzau, babicul, carnații de Plescoi, magiunul de Topoloveni si Salamul de Sibiu (originar, de fapt, din Sinaia).", "Oltenia" },
                    { 6, "Diversitatea etnica a Dobrogei ofera regiunii un caracter diferit de Muntenia vecina, bucataria regionala incorporand elementele aduse de turcii, tatarii, grecii, aromanii si lipovenii din regiune. Din judetul Tulcea unde se afla Delta Dunarii, bogata in specii de pesti, provin specialitati precum borșul de pește lipovenesc, storceagul sau saramura de sturion. În județul Constanța se produce vinul Murfatlar din Regiunea Viticolă a Colinelor Dobrogei. Datorită influenței orientale, sunt comune deserturile precum baclavaua, halvaua și sarailiile, mâncăruri precum șuberecul umplut cu carne prăjită cu ceapă, și mezeluri precum ghiudemul și sugiucul. Dobrogea a fost istoric străbătută de păstori, produsele din carne de oaie fiind comune, mai ales în rețetele împrumutate din bucătăriile orientale sau din bucătăria aromână, cât și în rețete autohtone, precum cea de pastramă.", "Dobrogea" },
                    { 7, "Moldova occidentală, Bucovina, Republica Moldova și Bugeacul au format cândva Moldova istorică, a cărei bucătării a fost influențată de cea poloneză, austriacă, rusă și ucraineană. Bucătăria moldovenească este un amestec de arome acide și texturi cremoase, cu o mai abundentă utilizare a verzei, a cartofilor și a cepei. Printre specialitățile locale se numără ciulamaua și tochitura moldovenească. În aceste regiuni, sarmalele se prepară și cu frunze de viță de vie. Pârjoalele moldovenești sunt chifteluțe tocate la grătar, cu usturoi și ierburi aromatice.", "Moldova" },
                    { 8, "Moldova occidentală, Bucovina, Republica Moldova și Bugeacul au format cândva Moldova istorică, a cărei bucătării a fost influențată de cea poloneză, austriacă, rusă și ucraineană. Bucătăria moldovenească este un amestec de arome acide și texturi cremoase, cu o mai abundentă utilizare a verzei, a cartofilor și a cepei. Printre specialitățile locale se numără ciulamaua și tochitura moldovenească. În aceste regiuni, sarmalele se prepară și cu frunze de viță de vie. Pârjoalele moldovenești sunt chifteluțe tocate la grătar, cu usturoi și ierburi aromatice.", "Bucovina" },
                    { 9, "Bucătăria maramureșeană tradițională poate fi considerată o bucătărie rustică pastorală, relativ simplă, care folosește un număr mic de ingrediente de bază (lapte de oaie, caș, urdă, jintiță, mălai, carne de porc sau de oaie, jumări, ouă, cartofi, varză, miere și prune) și care impresionează mai ales prin calitatea produselor finale.\r\nUn rol foarte important în bucătăria locală îl au prunele, folosite proaspete în rețete precum cea de gomboți cu prune, dar mai adesea conservate prin fierbere sau uscare. Din acestea se face horinca, versiunea locală a pălincii, băutură alcoolică dublu distilată, cu o tărie de 50–55%, uneori îndulcită cu miere de albine. Conserva consacrată de prune este magiunul, consumată cu mămăligă sau inclusă în prăjituri precum cornulețele, găluștele de aur sau porloșele. La fel ca în restul Ardealului, prunele uscate se folosesc în supe dulci sau sărate, sosuri pentru fripturi, tocănițe, mâncăruri de orez și în prăjituri.", "Maramures" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_RecipeId",
                table: "RecipeIngredients",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_RegionId",
                table: "Recipes",
                column: "RegionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "IngredientDetails");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
