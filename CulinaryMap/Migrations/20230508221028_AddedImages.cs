using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CulinaryMap.Migrations
{
    /// <inheritdoc />
    public partial class AddedImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "RecipeId", "Source" },
                values: new object[,]
                {
                    { 1, 1, "https://divainbucatarie.ro/wp-content/uploads/2013/02/CIORBA-DE-FASOLE-CU-AFUMATURA-SI-TARHON-4.jpg" },
                    { 2, 1, "http://www.gradinamea.ro/_files/Image/articole/5/ciorba%20ardeleneasca%20de%20fasole%20boabe.jpg" },
                    { 3, 2, "https://divainbucatarie.ro/wp-content/uploads/2011/04/ciorba-de-miel.jpg\r\n" },
                    { 4, 2, "https://madeincluj.ro/wp-content/uploads/2020/04/Ciorba-de-miel-ardeleneasca.jpeg" },
                    { 5, 3, "https://divainbucatarie.ro/wp-content/uploads/2010/08/supa-de-mazare1.jpg" },
                    { 6, 3, "https://www.lauralaurentiu.ro/wp-content/uploads/2012/08/supa-de-mazare-cu-galuste-reteta-ardeleneasca-supa-de-mazare-reteta-laura-laurentiu.jpg" },
                    { 7, 4, "https://divainbucatarie.ro/wp-content/uploads/2011/10/varza-a-la-cluj.jpg" },
                    { 8, 4, "https://divainbucatarie.ro/wp-content/uploads/2011/10/varza-a-la-cluj-01.jpg" },
                    { 9, 5, "https://thumbor.unica.ro/unsafe/700x536/smart/filters:format(webp):contrast(8):quality(75)/https://retete.unica.ro/wp-content/uploads/2014/10/langosi2-e1516973451620.jpg" },
                    { 10, 5, "https://thumbor.unica.ro/unsafe/800x0/smart/filters:contrast(8):quality(75)/http://retete.unica.ro/wp-content/uploads/2018/01/langosi-cu-diferite-umpluturi-1024x683.jpg" },
                    { 11, 6, "https://thumbor.unica.ro/unsafe/700x536/smart/filters:format(webp):contrast(8):quality(75)/https://retete.unica.ro/wp-content/uploads/2017/11/ciorba-de-burta-ardeleneasca-e1511286039947.jpg" },
                    { 12, 6, "https://img-global.cpcdn.com/recipes/c5df8471684618d9/1360x964cq70/ciorba-de-burta-fotografie-re%C8%9Beta.webp" },
                    { 13, 7, "https://thumbor.unica.ro/unsafe/700x536/smart/filters:format(webp):contrast(8):quality(75)/https://retete.unica.ro/wp-content/uploads/2010/12/cozo-ardelenesc-colaj-e1481047445166.jpg" },
                    { 14, 7, "https://img.spynews.ro/?u=https%3A%2F%2Fspynews.ro%2Fuploads%2Fmodules%2Fnews%2F0%2F2022%2F4%2F12%2F276417%2Fmedia146105652769019000.jpg&w=700" },
                    { 15, 8, "https://thumbor.unica.ro/unsafe/700x536/smart/filters:format(webp):contrast(8):quality(75)/https://retete.unica.ro/wp-content/uploads/2010/12/shutterstock_7595512.jpg" },
                    { 16, 8, "https://cdn.temananc.ro/tm/f/864x514/b8egaxte/jkfrj7a.jpg" },
                    { 17, 9, "https://lh3.googleusercontent.com/38hUynHD5xJYMyK-BLIi-F1anSQZv7SUqeioEqkLxfK9_NgH_OZpgNlyQDHeSdM_Uxr3BN6v979t6I6fWXyQPFEiqIJU-b3ze8g9yDA3DKg3VqWFoUywOOOkzY9FZBkOWRzhkqga" },
                    { 18, 9, "https://jamilacuisine.ro/wp-content/uploads/2021/07/Ghiveci-de-legume-ca-la-bunica-696x392.jpg.webp" },
                    { 19, 10, "https://thumbor.unica.ro/unsafe/700x536/smart/filters:format(webp):contrast(8):quality(75)/https://retete.unica.ro/wp-content/uploads/2015/06/shutterstock_133342199-e1435664898337.jpg" },
                    { 20, 10, "https://retete-cochete.ro/wp-content/uploads/2015/01/IMG_2667.jpg" },
                    { 21, 11, "https://thumbor.unica.ro/unsafe/700x536/smart/filters:format(webp):contrast(8):quality(75)/https://retete.unica.ro/wp-content/uploads/2010/11/shutterstock_52717264.jpg" },
                    { 22, 11, "http://acasalaromani.ro/wp-content/uploads/2017/08/supa-banateana-k-1021x1024.jpg" },
                    { 23, 12, "http://www.skytrip.ro/images/retete/400x230/471.jpg" },
                    { 24, 12, "https://ghidulbanatului.ro/wp-content/uploads/2020/10/cepe-umplute-caransebes-750x460.jpg" },
                    { 25, 13, "https://www.lauralaurentiu.ro/wp-content/uploads/2011/10/gomboti-galuste-knedle-cu-prune-sectiune-reteta-galuste-cu-prune-pas-cu-pas-lauralaurentiu.jpg" },
                    { 26, 13, "https://www.gustos.ro/img.php?u=https%3A%2F%2Fwww.gustos.ro%2Fuploads%2Fmodules%2Fnews%2F0%2F2010%2F8%2F14%2F41236%2Fprune_024.jpg&w=800" },
                    { 27, 14, "https://divainbucatarie.ro/wp-content/uploads/2011/10/ciorba-radauteana.jpg" },
                    { 28, 14, "https://divainbucatarie.ro/wp-content/uploads/2011/10/ciorba-radauteana-reteta-diva-in-bucatarie-p.jpg" },
                    { 29, 15, "https://divainbucatarie.ro/wp-content/uploads/2012/04/bors-de-pui-cu-legume.jpg" },
                    { 30, 15, "https://pofta-buna.com/wp-content/uploads/2019/10/Ciorba-de-pui-bors-de-pui-cu-taitei-de-casa-reteta-moldoveneasca-gina-bradea-1-700x525.jpg" },
                    { 31, 16, "https://divainbucatarie.ro/wp-content/uploads/2011/03/mucenici-moldovenesti-0.jpg" },
                    { 32, 16, "https://www.bucatariamamei.ro/wp-content/uploads/2021/03/5clarendon-Mucenici-Moldovenesti-cu-Miere-si-Nuca-696x392.png" },
                    { 33, 17, "https://www.bucovinacazare.ro/wp-content/uploads/2018/07/reteta_de_balmos_ciobanesc_autentic_bucovina.jpg" },
                    { 34, 17, "https://media.dcnews.ro/image/202002/full/balmos-bucovina_73780900.jpg" },
                    { 35, 18, "https://thumbor.unica.ro/unsafe/700x536/smart/filters:format(webp):contrast(8):quality(75)/https://retete.unica.ro/wp-content/uploads/2015/07/shutterstock_235905862-e1435835695715.jpg" },
                    { 36, 18, "https://pe-zona.ro/wp-content/uploads/2022/06/alivenci.jpg" },
                    { 37, 19, "https://dulciurifeldefel.ro/wp-content/uploads/2018/11/placinte-poale-in-brau-5.jpg" },
                    { 38, 19, "https://retete-culinare-cu-dana-valery.ro/cdn/recipes/poale-2.jpeg" },
                    { 39, 20, "https://jamilacuisine.ro/wp-content/uploads/2022/03/Parjoale-moldovenesti-500x500.jpg" },
                    { 40, 20, "https://prajituricisialtele.ro/wp-content/uploads/2020/06/parjoale-moldovenesti.jpg" },
                    { 41, 21, "https://thumbor.unica.ro/unsafe/700x536/smart/filters:format(webp):contrast(8):quality(75)/https://retete.unica.ro/wp-content/uploads/2017/03/Muncenici-muntene%C8%99ti-cu-nuc%C4%83.jpg" },
                    { 42, 21, "https://www.teoskitchen.ro/wp-content/uploads/2016/03/mucenici-muntenesti-1-520x344.jpg" },
                    { 43, 22, "https://thumbor.unica.ro/unsafe/700x536/smart/filters:format(webp):contrast(8):quality(75)/https://retete.unica.ro/wp-content/uploads/2014/07/R%C4%83citur%C4%83-munteneasc%C4%83.jpg" },
                    { 44, 22, "https://www.lauralaurentiu.ro/wp-content/uploads/2019/03/piftie-de-porc-piftii-de-porc-racitura-de-porc-racituri-de-porc-reteta-laura-laurentiu-960x640.jpg" },
                    { 45, 23, "https://jamilacuisine.ro/wp-content/uploads/2017/11/Taci-si-inghite-Mamaliga-in-straturi.jpg.webp" },
                    { 46, 23, "https://blogger.googleusercontent.com/img/a/AVvXsEi1tIiZ23ncK_L1rkXXuqSL2fKxL9FFDpmKHP2bhAs6cNboaqNYnt93kbDROBxym5PV1aId0VztI0kqKxJ3Aa3W1xm56LoWbOCOdV7v4R6u4SUW7O3fOFCNZY5_rrht6jULvAM2kOlTEi3_93qBT8VhSyOBAe9gMk9T1NtlO8SvvTF4K2KANzn0SbiY=w640-h427" },
                    { 47, 24, "https://luckycake.ro/wp-content/uploads/2015/01/DSC_1911.jpg" },
                    { 48, 24, "https://www.lauralaurentiu.ro/wp-content/uploads/2012/10/papanasi-cu-branza-fierti-reteta-pas-cu-pas-cum-se-fac-papanasi-fierti-960x640.jpg" },
                    { 49, 25, "https://pofta-buna.com/wp-content/uploads/2015/11/Ciorba-de-fasole-in-paine-pofta-buna-cu-gina-bradea-2.jpg" },
                    { 50, 25, "https://www.reteteculinare.ro/img.php?u=https%3A%2F%2Fwww.reteteculinare.ro%2Fuploads%2Fmodules%2Fnews%2F0%2F2019%2F2%2F17%2F11176%2Ffdb_1550413511_dscf7010.jpg&w=800&v=2" },
                    { 51, 26, "https://raftulbunicii.ro/wp-content/uploads/2018/10/17-copy-4-1.png" },
                    { 52, 26, "https://retete.unica.ro/wp-content/uploads/2010/08/specialitate-munteneasca.jpg" },
                    { 53, 27, "https://www.retetepractice.ro/wp-content/uploads/2015/08/bors-cu-leurda.png" },
                    { 54, 27, "https://4.bp.blogspot.com/-FcxOsVESQZw/WK1YF5AakBI/AAAAAAAAN0M/f5DDeC52OvouumB0821y5Er_qGAW2OelwCLcB/s1600/10.jpg" },
                    { 55, 28, "https://www.papamond.ro/wp-content/uploads/2015/03/Mamaliga-toponita-Papamond-5.jpg" },
                    { 56, 28, "https://retete.unica.ro/wp-content/uploads/2015/10/26052325_m.jpg" },
                    { 57, 29, "https://static.alinacuisine.ro/uploads/2015/08/cornuri-extra-pufoase-cu-gem-de-zmeura-featured-image-638x423.jpg" },
                    { 58, 29, "https://i0.wp.com/zicemami.ro/wp-content/uploads/2021/02/77BAD4A9-FFC3-46C0-9C73-32B4D9C4CB23.jpeg?resize=750%2C748&ssl=1" },
                    { 59, 30, "https://retete-culinare-cu-dana-valery.ro/cdn/recipes/ciorba-de-gulii-cu-smantana-si-marar-reteta-simpla.jpg" },
                    { 60, 30, "https://teoskitchen.ro/wp-content/uploads/2021/08/ciorba-de-gulii-4.jpg" },
                    { 61, 31, "https://traditiiculinareromanesti.files.wordpress.com/2013/09/121.jpg" },
                    { 62, 31, "https://www.cefacemimi.ro/wp-content/uploads/2013/10/7-3.jpg" },
                    { 63, 32, "https://savoriurbane.com/wp-content/uploads/2019/01/Sup%C4%83-crem%C4%83-de-praz-cu-cartofi-%C8%99i-sm%C3%A2nt%C3%A2n%C4%83-fin%C4%83-%C8%99i-cremoas%C4%83-reteta-savori-urbane.jpg" },
                    { 64, 32, "https://lecturisiarome.ro/wp-content/uploads/2020/03/supa-de-praz.jpg" },
                    { 65, 33, "https://pofta-buna.com/wp-content/uploads/2021/02/ciorba-de-praz-reteta-pas-cu-pas-2.jpg" },
                    { 66, 33, "https://retete.unica.ro/wp-content/uploads/2013/10/ciorba-pray.jpg" },
                    { 67, 34, "https://lh6.googleusercontent.com/KEBzOl9hAc2pfh_i_LPXYPNBBk-EQRi-h0VK1o5AEIAWEwxWP5nFmHOy7MUuL7JEHf7_98D-YwXt5qxk_XNwwOb9NGg1a4-WhX2-ouj2OI2240gQEd040S-ryfXInf5TpW0zBkb0" },
                    { 68, 34, "https://retete.unica.ro/wp-content/uploads/2013/10/tarta-praz-morcovi.jpg" },
                    { 69, 35, "https://jamilacuisine.ro/wp-content/uploads/2015/10/Saramura-de-pui-500x375.jpg" },
                    { 70, 35, "https://4.bp.blogspot.com/-wAga6JltCks/V_CxG-fyb8I/AAAAAAAA0I8/kE6VkUTWlZsNCKhorc5MrFQkSSjATG_0QCLcB/s1600/saramura-de-pui.JPG" },
                    { 71, 36, "https://i2.wp.com/www.deliciiraw.ro/wp-content/uploads/2017/03/turta-de-malai-olteneasca.jpg?fit=2165%2C1491&ssl=1" },
                    { 72, 36, "https://www.exquis.ro/wp-content/uploads/2017/09/c57c7f37054602e4a26f50fd45d732a2.jpg" },
                    { 73, 37, "https://www.gustos.ro/img.php?u=https%3A%2F%2Fwww.gustos.ro%2Fuploads%2Fmodules%2Fnews%2F0%2F2010%2F7%2F13%2F40893%2Fdscf3568.jpg&w=800" },
                    { 74, 37, "https://cdn.temananc.ro/tm/f/864x514/b8egaxte/3dt7l3k.jpg" },
                    { 75, 38, "https://www.petitchef.ro/imgupl/recipe/placinta-dobrogeana--43927p53569.jpg" },
                    { 76, 38, "https://suntdelicioase.ro/wp-content/uploads/2021/12/placinta-DOBROGEANA-2.jpg" },
                    { 77, 39, "https://louloucuisine.ro/wp-content/uploads/2017/04/peste-alb-sos-rosii.jpg" },
                    { 78, 39, "https://1.bp.blogspot.com/-mgkoxJLQU5Q/Xywnbum9WLI/AAAAAAAAEDk/pTAZDlMMKtkriRuD5DxwmuEgr_9m2EULwCLcBGAsYHQ/s1600/peste-la-cuptor-cu-sos-de-rosii.JPG" },
                    { 79, 40, "https://i.ytimg.com/vi/dJmzQfwNPAU/maxresdefault.jpg" },
                    { 80, 40, "https://www.lauralaurentiu.ro/wp-content/uploads/2019/03/saramura-de-crap-reteta-saramura-de-peste-reteta-laura-laurentiu.jpg" },
                    { 81, 41, "https://www.gustos.ro/uploads/modules/news/0/2013/12/3/49602/dsc00483.jpg" },
                    { 82, 41, "https://retete.unica.ro/wp-content/uploads/2013/10/bors-macrou.jpg" },
                    { 83, 42, "https://simonacallas.com/wp-content/uploads/2015/06/Cherdele-dobrogene.jpg" },
                    { 84, 42, "https://i.pinimg.com/originals/e0/c9/0c/e0c90c1fd70e7f030aa892b2b0ab8a4f.jpg" },
                    { 85, 43, "https://teoskitchen.ro/wp-content/uploads/2020/03/clatite-cu-urda-si-marar-1.jpg" },
                    { 86, 43, "https://www.bucataras.ro/uploads/modules/news/79887/656x440_clatite-cu-urda-si-marar-463349.jpg" },
                    { 87, 44, "https://retetefeldefel.ro/wp-content/uploads/2019/10/coltunasi-cu-carne-tocata-si-legume-4-1024x684.jpg" },
                    { 88, 44, "https://retete.unica.ro/wp-content/uploads/2010/10/shutterstock_7626319.jpg" },
                    { 89, 45, "https://acasalaromani.ro/wp-content/uploads/2017/04/Supa-cu-porumb-si-cascaval.jpg" },
                    { 90, 45, "https://chefnicolaietomescu.ro/wp-content/uploads/2021/07/03FDF13F-8D9C-4676-B7FF-44E6A02B6F2A.jpeg" }
                });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Type",
                value: "Desert");

            migrationBuilder.CreateIndex(
                name: "IX_Images_RecipeId",
                table: "Images",
                column: "RecipeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Type",
                value: "Aperitiv");
        }
    }
}
