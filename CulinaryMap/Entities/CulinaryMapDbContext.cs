using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CulinaryMap.Entities
{
    public class CulinaryMapDbContext : IdentityDbContext
        <User, Role, string, IdentityUserClaim<string>,
        UserRole, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public CulinaryMapDbContext(DbContextOptions<CulinaryMapDbContext> options) : base(options) { }
        public DbSet<Recipe> Recipes { get; init; }
        public DbSet<IngredientDetails> IngredientDetails { get; init; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; init; }
        public DbSet<Region> Regions { get; init; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Recipe>()
                .HasOne(recipe => recipe.Region)
                .WithMany(region => region.Recipes)
                .HasForeignKey(recipe => recipe.RegionId);

            builder.Entity<RecipeIngredient>()
                .HasOne(recipeIngredient => recipeIngredient.Recipe)
                .WithMany(recipe => recipe.RecipeIngredients)
                .HasForeignKey(recipeIngredient => recipeIngredient.RecipeId);
             
            builder.Entity<RecipeIngredient>()
                .HasOne(recipeIngredient => recipeIngredient.Ingredient)
                .WithMany(ingredient => ingredient.RecipeIngredients)
                .HasForeignKey(recipeIngredient => recipeIngredient.IngredientId);

            builder.Entity<Region>().HasData(GetSeedRegions());
            builder.Entity<Recipe>().HasData(GetSeedRecipes());
            builder.Entity<RecipeIngredient>().HasData(GetSeedRecipeIngredients());
            builder.Entity<IngredientDetails>().HasData(GetSeedIngredientDetails());

        }

        private Recipe[] GetSeedRecipes()
        {
            int id = 1;
            int nextId() => id++;

            return new[]
            {
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 1,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Ciorba Ardeleneasca de fasole cu afumatura si tarhon",
                    PrepMode = "Fasolea o punem la inmuiat peste noapte, astfel incat sa fie acoperita de apa.\r\nPunem apoi fasolea la fiert, schimband apa de 3 ori – la 10 minute de fiert aruncam apa si o punem sa fiarba in alta apa fierbinte. In ultima apa in care o punem la final adaugam 2 morcovi si un pastarnac (folosim in jur de 3 l apa – mai adaugam daca va fi nevoie). Separat calim o ceapa mare impreuna cu afumatura. Adaugam apoi afumatura calita in oala, sucul de rosii, faina, boia de ardei, frunzele de dafin, tarhonul, boabele de piper, putina sare si continuam sa fierbem pana fasolea este suficient de moale .\r\nCand bobul de fasole este fiert dregem cioba. Amestecam laptele cald cu smantana, galbenusul si o lingura otet. Daca este nevoie mai adaugam si zeama din supa de pe pe foc, apoi incoporam aceasta compozitie in ciorba amestecand cat timp turnam laptele cu smantana. O mai lasam 2-3 minute sa fiarba, avand grija sa amestecam din cand in cand. La final gustam pentru a vedea daca mai are nevoie de sare.\r\nO servim fierbinte, cu putin patrunjel verde si ceapa rosie!\r\n",
                    History = "NA",
                    PrepTime = "NA",
                    Type = "Fel principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 1,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Ciorba Ardeleneasca de miel",
                    PrepMode = "Pentru a pregati ciorba ardeleneasca de miel folosim capul si bucati de carne de la miel.\r\nSpalam si curatam carnea. Pentru inceput o oparim in apa cu otet. Aruncam apa si punem carnea iar la fiert in apa rece cu sare.\r\nAvem grija sa fie acoperita Vom indeparta spuma de cate ori este nevoie.\r\nLegumele le taiem marunt si le calim in ulei, apoi le inabusim cu putina apa.\r\nLe punem la fiert in oala in care fierbem carnea, adaugand si usturoiul, frunza de dafin, frunzele de leustean si boabele de piper. Orezul il vom fierbe separat.\r\nCand este fiarta carnea o scoatem si o alegem de pe oase, portionam bucatile mai mari, apoi le punem inapoi in oala. Adaugam orezul, otet dupa gust (zeama de lamaie sau bors) fierbem 4-5 minute, apoi punem dressingul din faina, galbenusuri si smantana de gatit. Dressingul este diluat in prealabil cu 4-5 polonice de zeama fierbinte si abia dupa aceasta operatiune se pune in oala.\r\nEste important ca dressingul sa ajunga la o temperatura apropiata de a ciorbei, asa ca zeama calda o punem treptat peste smantana cu oua si faina, iar in oala se pune tot treptat, nu se toarna tot lichidul dintr-o singura miscare.\r\nMai lasam sa fiarba  cateva clocote (nu se va branzi pentru ca avem si faina!), saram cat este nevoie si ciorba este gata.\r\n",
                    History = "NA",
                    PrepTime = "NA",
                    Type = "Fel principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 1,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Supa de mazare Ardeleneasca",
                    PrepMode = "In primul rand am pus 120 ml de apa la fiert.\r\nAm taiat morcovii in rondele subtiri  si ceapa cat mai fin.\r\nAm calit morcovii cu ceapa un putin ulei incins in prealabil.\r\nAm pus morcovii si ceapa calita in apa care a inceput sa clocoteasca si am lasat sa fiarba 5 minute.\r\nDupa caest interval de timp am turnat supa concentrata de legume si am condimentat supa de mazare, reteta ardeleneasca, cu piper si sare.\r\nDintr-un ou, 4 lingurite de faina si 1-2 lingurite de apa am realizat un aluat moale.\r\nDin acesta am luat cu lingurita umezita foarte putin si l-am pus in supa de mazare fierbinte.\r\nObtinem niste galusti foarte mici. Cand acestea se ridica la suprafata se adauga mazarea si se mai fierbe inca 5 minute.\r\nMazarea este congelata, asa ca nu are nevoie de timp mare de gatire.\r\nAm turnat smantana de gatit si am luat de pe foc.\r\nAm presarat patrunjelul tocat marunt.\r\n",
                    History = "NA",
                    PrepTime = "NA",
                    Type = "Fel Principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 1,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Varza ala Cluj",
                    PrepMode = "Varza murata o spalam in cateva ape apoi o taiem fideluta, avand grija sa eliminam nervurile groase din fiecare frunza. Calim varza in 4 linguri ulei de masline, adaugand apoi putina apa (o cana ar trebui sa fie suficienta) si foaia de dafin, la foc mic acoperita, sau la cuptor, pentru 1 ora.\r\nOrezul il calim deasemena in 3 linguri ulei de masline, apoi stingem cu 1/2 l apa fierbinte. Ii facem loc in cuptor, langa varza, unde il lasam acoperit sa fiarba in jur de 15-20 minute.\r\nCat timp acestea stau in cuptor, calim ceapa tocata marunt in 4-5 linguri ulei masline, adaugam carnea tocata si incepem sa o perpelim la foc mic cam 30 de minute. Asezonam cu sare, piper si putin cimbru. Punem din cand in cand putina apa, sa nu se arda.\r\nCand toate sunt gata, amestecam carnea cu orezul. Intr-un vas termorezistent punem un rand subtire de varza, il acoperim cu unul de carne, apoi iar varza, carne, termanand cu un strat de varza.\r\nAcoperim totul cu sos de rosii si decoram cu felii de rosii taiate rotund. Dam totul la cuptor pentru inca 15-20 minute, cat sa se imbine aromele.\r\n",
                    History = "NA",
                    PrepTime = "NA",
                    Type = "Fel principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 1,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Langosi",
                    PrepMode = "Dizolvă într-un castron drojdia şi amestecă cu apă călduţă, sare şi zahăr.  Adaugă făina şi frământă bine preparatul.\r\nPune aluatul frământat într-un vas uns cu ulei,  acoperă cu un prosop. Lasă la cald, ferit de curent, să crească, pentru aproximativ 30 de minute.\r\nPune ulei la încins într-o tigaie şi desfă cu o lingură, sau cu mâna, bucăţi din aluat crescut.\r\nSe aplatizează (turtesc) bucăţile de aluat și, dacă nu le vrei simple, pune umplutura (de brânză, brânză cu verdeţuri, stafide, fructe, gem, etc.).\r\nLipește marginile, ca într-un plic şi pune în uleiul încins, la prăjit, circa 2 minute pe fiecare parte, până devin aurii.\r\nSe scot langoşile pe șervețele de hârtie şi se lasă la scurs. Fiecare bucățică de langoși se pudrează cu zahăr sau scorţişoară, după gust.\r\n",
                    History = "NA",
                    PrepTime = "NA",
                    Type = "Desert"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 1,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Ciorba de burta ardeleneasca",
                    PrepMode = "Ciorbă de burtă ardelenească – diferența dintre ea și ciorba de burtă tradițională este adăugarea rasolului sau/și picioarelor de porc.\r\nSe spală și curăță bine rasolul sau/și picioarele de porc. IMPORTANT: Când începe să fiarbă, îndepărtează spuma formată cu o spumieră.\r\nÎntre timp curăță legumele și pune, separat, la fiert, burta cu puțin oțet și las-o să dea în clocot.\r\nAdaugă legumele peste rasolul sau/și picioarele de porc și lasă la fiert în continuare până când carnea se desprinde singură de pe oase.\r\nScoate bucățile de carne și lasă-le la răcit. Când s-au răcit îndeajuns, taie-le bucățele și pune-le înapoi în oală cu legumele. Adaugă și burta și extra apă, dacă se cere. Mai lasă pe foc până când burta este foarte bine fiartă.\r\nÎntre timp curăță usturoiul zdrobește-l. Freacă-l cu sare ca pentru mujdei (până obții o pastă albicioasă, adică). Separat bate ouăle cu un vârf de sare și vreo 3 linguri de smântână.\r\nAdaugă în ciorbă ouăle bătute și jumătate din crema de usturoi. Opreste focul, acrește cu oțet, după gust.\r\n",
                    History = "NA",
                    PrepTime = "NA",
                    Type = "Fel Principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 1,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Cozonac Ardelenesc",
                    PrepMode = "1. Se cerne făina şi se lasă la temperatura camerei 3-4 ore împreună cu celelalte ingrediente. Se separă ouăle iar uleiul se încălzeşte 5-10 minute. Se incalzeste putin laptele şi se amestecă cu 2 linguri de zahăr, cu drojdia şi se lasă la dospit acoperit cu un şervet.\r\n2. În bolul cu făină, se adaugă restul de zahăr, gălbenuşurile frecate cu sarea, zahărul vanilat, coaja de lămâie şi de portocală, drojdia dospită şi albuşurile bătute spumă.\r\n3. Toate ingredientele se amestecă până se obţine o cocă nici prea vârtoasă, nici prea moale. Se adaugă lapte dacă e prea tare şi apoi se frământă 30 de minute adăugându-se uleiul, câte puţin. După ce s-a încorporat tot uleiul, se acoperă şi se lasă la crescut o oră sau chiar mai mult.\r\n4. Între timp, se pregăteşte crema de nucă. Se amestecă nuca măcinată şi coaptă cu zahărul şi cu laptele fierbinte. Se adaugă o esenţă de vanilie şi 2-3 picături de rom, coaja de lămâie şi cacaoa. Crema se lasă la temperatura camerei. Se ung tăvile cu unt din abundenţă. Se împarte coca în două părţi şi se întind. Se umplu cu crema de nucă şi se rulează. Se aranjează în tavă una lângă alta şi se mai lasă 20 de minute la crescut. Se ung cu galbenuş şi se coc la aceeaşi temperatură.\r\n",
                    History = "NA",
                    PrepTime = "120 min",
                    Type = "Desert"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 1,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Ciorba Ardeleneasca",
                    PrepMode = "1. Se curăţă rasolul de viţel şi se pune la fiert într-o oală cu apă și puţină sare. Se spumează în timpul fierberii şi se lasă la foc potrivit, acoperit cu un capac.\r\n2. Separat, se curăţă morcovii, ceapa, ardeii, fasolea şi cartofii. Se spală, se taie bucăţi mari şi se pun să fiarbă împreună cu rasolul de viţel. Se condimentează cu sare, piper şi paprika şi se fierb la foc potrivit.\r\n3. Borşul se strecoară şi se fierbe separat în câteva clocote. În borş, se adaugă câteva frunze de leuştean pentru a-i da o aromă mai specială.\r\n4. După ce au fiert toate legumele, se scoate rasolul, se desface carnea de pe os şi se taie bucăţele. Se adaugă borşul şi se serveşte ornată cu leuştean şi pătrunjel.",
                    History = "NA",
                    PrepTime = "40 min",
                    Type = "Fel principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 1,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Ghiveci Ardelenesc",
                    PrepMode = "1. Pentru început, se alege fasolea uscată şi se lasă câteva ore să se înmoaie. După ce a stat în apă călduţă, se scoate şi se pune să fiarbă. Se fierbe în câteva ape până se elimină toxinele apoi se scoate în sită să se scurgă.\r\n2. Carnea se taie cubuleţe şi se căleşte în uleiul încins. Se înăbuşe uşor la foc mediu şi se adaugă ceapa şi ardeii tăiaţi cubuleţe.\r\n3. Morcovii, fasolea verde şi cartofii se spală, se curăţă şi se taie cubuleţe. Se adaugă în cratiţa cu carne şi se lasă să fiarbă la foc potrivit.\r\n4. După ce au fiert şi legumele, şi ceapa, se adaugă piureul de roşii şi fasolea fiartă. Ghiveciul se lasă să scadă în cuptor şi se serveşte cu mărar şi cimbru.",
                    History = "NA",
                    PrepTime = "40 min",
                    Type = "Fel Principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 2,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Clatite Banatene",
                    PrepMode = "Ungeți o tavă cu unt. Preîncălziți cuptorul.\r\nÎntr-un bol mediu, omogenizați umplutura pentru clătite – brânza de vaci cu oul, zahărul, stafidele și esențele.\r\nSeparați celelalte 4 ouă necesare – deoarece pentru sosul de vanilie veți folosi gălbenușurile, iar pentru bezea albușurile. Amestecați cu mixerul gălbenușurile cu smântâna, zahărul tos și cel  vanilat. Bateți albușurile  – tot cu mixerul – până se întăresc și apoi adăugați zahărul rămas și sarea. Gata și bezeaua!\r\nUmpleți clătitele cu umplutură și împăturiți-le pe rând, ca pe sarmale. Așezați-le în vasul uns cu unt. Turnați crema de vanilie deasupra. Dați la cuptor pentru 10 minute sau până când vedeți că începe să se închege sosul. Scoateți vasul și turnați deasupra compoziția de bezea. Dați la cuptor pentru alte 10 minute sau până când încep să se rumenească crusta de bezea.\r\n",
                    History = "NA",
                    PrepTime = "40 min",
                    Type = "Desert"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 2,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Ciorba Banateana",
                    PrepMode = "1. Se lasă fasolea la înmuiat în apă călduţă, timp de 3-4 ore. Se scoate din apă şi se pune să fiarbă în câteva ape, până elimină toxinele.\r\n2. După ce s-a fiert, se scoate din apă şi se lasă în sită să se scurgă. Separat, se curăţă ceapa, ardeii, morcovul şi cartofii. Se taie cubuleţe, ca pentru ciorbă şi se înăbuşe câteva minute în uleiul de floarea-soarelui.\r\n3. Se adaugă aproximativ 2 litri de apă şi se pun să fiarbă la foc mediu, acoperite cu un capac. În acest timp, se taie cârnaţii felii şi se călesc în sucul propriu.\r\n4. După ce au fiert legumele, se adaugă sucul de roşii, sarea, piperul, boiaua iute, se mai lasă să clocotească 10 minute şi se serveşte cu bucăţile de cârnaţi şi pătrunjel proaspăt tocat mărunt.",
                    History = "NA",
                    PrepTime = "40 min",
                    Type = "Fel Principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 2,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Ceapa umpluta ca la Caransebes",
                    PrepMode = "Ceapa se curata si se fierbe intreaga. Se da apoi la rece si i se scoate miezul. Se realizeaza apoi o compozitie din: nucile pisate bine in mojar, pâinea inmuiata in lapte si stoarsa bine, maslinele jumatati, sare, piper, miezul cepelor si patrunjelul tocat marunt.Cu aceasta compozitie se umplu cepele, care se aseaza apoi intr-o tava unsa.Separat se face un sos, astfel: se rumeneste faina in uleiul bine incins, pana ce faina capata o culoare aurie. Se stinge apoi cu bulionul de rosii si cu un pic de vin alb. Se presara apoi zaharul si se mai da in câteva clocote. Cand sosul este gata se toarna peste cepele din tava.Se baga apoi tava la cuptor pentru circa 15 minute. Preparatul se serveste fierbinte cu smantana deasupra.",
                    History = "NA",
                    PrepTime = "NA",
                    Type = "Aperitiv"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 2,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Gomboti cu prune",
                    PrepMode = "Preparare aluat:\r\n1. Pentru inceput, se aleg cartofi mai degraba fainosi, din cei care sunt potriviti pentru piure, nu pentru prajit. Cartofii cu tot cu coaja se spala bine si se pun la fiert. Cand sunt bine fierti, se scurg de apa si se lasa sa se racoreasca atat cat sa se poata atinge si se curata de coaja.\r\n2. Se zdrobesc bine cartofii.\r\n3. Se adauga pe rand cele doua oua intregi, un praf de sare, cele 4 linguri de gris si 8 linguri de faina varfuite.\r\n4. Se framanta rapid aluatul, fara a insista foarte mult. Ideea e sa se obtina un aluat molcut, care sa se adune intr-o bila si sa se desfaca de pe peretii vasului, dar care e inca usor lipicios fata de maini. La nevoie, mai adaugati cate o lingura de faina, dar fara exagerare, nu trebuie sa se obtina un aluat greu.\r\n(Aluatul trebuie sa fie moale, poate e ceva mai greu de lucrat cu el, insa rezultatul e de o mare fragezime. Daca se adauga faina pana la obtinerea unui aluat care nu se mai lipeste, galustele vor fi tari oricat le-am fierbe).\r\nPrepararea pesmetului aromat\r\n3. Cat timp au fiert cartofii, eu am pregatit pesmetul. Am incins uleiul intr-o tigaie, apoi am adaugat untul.\r\n4. Cand untul s-a topit complet, am adaugat pesmetul si l-am rumenit, amestecand frecvent ca sa nu se arda.\r\n5. adaugam zaharul tos (dupa gust) si semintele dintr-o pastaie de vanilie.\r\nAm amestecat bine si am acoperit cu un capac, pentru ca semintele de vanilie sa isi dezvolte aroma in pesmetul inca fierbinte.\r\nFierberea galustelor\r\n6. Am pus o oala incapatoare (5-6 litri) plina cu apa, la fiert.\r\n7. Cand apa aproape clocoteste, se adauga in oala o lingura rasa de sare si se trece la modelarea galustelor. Cu mainile in permanenta udate cu apa (eu tin un castronel cu apa la indemana) se rup bucati din aluat cam de dimensiunea unei prune. Se aplatizeaza aluatul in palma si se adauga jumatatile de prune dinainte pregatite. Unii prefera sa adauge in interiorul prunelor zahar amestecat cu arome (scortisoara), altii pun un cubulet mic de unt. Eu le prefer simple. \r\nObservație: in timpul iernii gombotii se pot pregati identic, folosind jumatati de prune congelate. Nu le decongelam, ci le invelim cat sunt inghetate bine in aluat, apoi continuam ca in pasii urmatori.\r\n8. Se inchide cu grija aluatul peste pruna, se rotunjesc galustele in palmele ude si se plonjeaza pe rand in apa clocotita.\r\n9. In scurt timp, galustele cu prune se vor ridica la suprafata. In acest moment se reduce focul la minimum si se mai fierb in clocote mici 4-7 minute, pentru ca grisul din compozitie sa absoarba umiditate, fragezind aluatul, si pentru ca pruna din interior sa fiarba si ea (daca doriti pruna mai cruda, scoateti galustele mai repede).\r\n10. Cand sunt gata, galustele cu prune se scot cu o\r\n",
                    History = "NA",
                    PrepTime = "NA",
                    Type = "Desert"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 7,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Ciorba Radauteana",
                    PrepMode = "Pentru inceput am pus puiul intr-o oala si am adaugat apa rece (am folosit 3.5l ). Apa se pune pana cand acesta va fi acoperit, in functie de marimea oalei in care fierbeti. Am adaugat o lingura varfuita de sare si boabele de piper si am lasat sa fiarba 15 minute, la foc mic, din momentul in care apa a inceput sa clocoteasca. Am indepartat spuma formata si am pus capacul.\r\nIn acest timp am curatat si taiat morcovii, pastarnacul, patrunjelul si felia de ardei in jumatate. Ceapa si felia de telina le-am lasat intregi. Le-am pus in oala, langa pui, am pus capacul si am lasat sa fiarba in jur de 45 minute.\r\nAm dat usturoiul presa. Am luat oala de pe foc si am oparit usturoiul cu 4 polonice de supa. Am acoperit bolul cu o farfurie.\r\nAm strecurat supa. Legumele le voi pastra pentru o salata olivier (salata a la Russe).\r\nAm indepartat oasele si pielea de pe carne, apoi am rupt-o in fasii.\r\nAm pregatit liezonul, adica dressingul din galbenusuri si smantana cu care se drege ciorba. Pentru ingrosare am folosit faina.\r\nAm amestecat galbenusurile cu sare, am adaugat faina, apoi smantana pentru gatit. Am avut grija sa nu ramana cocoloase.\r\nAm adaugat treptat cate un polonic de supa, pana cand liezonul a avut o temperatura apropiata de a ciorbei. In acest mod ma asigur ca nu se branzeste.\r\nAm pus fasiile de carne in oala. Am strecurat lichidul cu usturoi si am presat putin usturoiul.\r\nAm adaugat in supa treptat cate un polonic din dressingul de oua cu smantana.\r\nAm pus oala pe foc si am mai lasat sa fiarba in jur de 5 minute, astfel incat faina sa fie gatita.\r\n",
                    History = "",
                    PrepTime = "NA",
                    Type = "Fel principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 7,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Bors Moldovenesc de pui cu legume",
                    PrepMode = "In primul rand punem carnea la foc, in apa cu putina sare. Cand incepe sa fiarba luam spuma de cate ori este necesar si lasam sa fiarba in continuare la foc mic.\r\nCalim ceapa tocata marunt cu morcovii taiati rondele si ardeiul tocat cubulete intr-o lingura de ulei.\r\nLe punem peste carne impreuna cu telina, gulia si cartofii taiati in cuburi. Dupa 5 minute adaugam buchetele de conopida si dovleceii taiati in cuburi. Continuam sa fierbem acoperind cu un capac.\r\nCand au fiert legumele si carnea, adaugam borsul fiert in prealabil, frunzele de leustean si mai lasam sa fiarba 2-3 minute.\r\nServim borsul fierbinte cu ptarunjel sau leustean proaspat tocat.\r\n",
                    History = "",
                    PrepTime = "",
                    Type = "Fel principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 7,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Mucenici Moldovenesti",
                    PrepMode = "",
                    History = "Sarbatoarea crestina a celor 40 de Mucenici poate sa cada si in perioada postului, asa ca in acest caz veti pregati un aluat de cozonac fara oua.\r\nIn aceasta zi pe vremuri oamenii obisnuiau sa faca ritualiri de indepartarea gerului, se face curatenie de primavara si se incheie perioada „babelor” si incep pregatirile pentru arat.\r\nIn traditiile vechi populare se spune ca se deschid mormintele si portile Raiului, dar mai sunt inca multe alte obiceiuri ce aduc aminte de perioada in cei 40 mucenici aflati in slujba imparatului roman Licinius.\r\nAcestia au fost condamnati la moarte dupa ce au fost chinuiti si torturati pentru ca nu s-au inchinat idolilor.\r\nIn lacul in care au condamnati la moarte prin inghetare s-au petrecut minuni, apa lacului s-a incalzit, s-a topit ghetata si 40 de cununi stralucitoare  au pogarat peste mucenici.\r\nPentru ca au fost scosi vii din lac comandantii au poruncit sa li se zdrobeasca picioarele cu ciocanele, apoi au fost arsi.\r\n",
                    PrepTime = "Preparam maiaua din drojdie, o lingurita zahar si una de faina. Dupa 10 minute o amestecam cu restul ingredientelor enumerate mai sus pentru aluat.\r\nFramantam bine aluatul. Vom obtine un aluat moale pe care il lasam sa creasca la loc caldut.\r\nCand acesta creste (si va creste mult), il impartim in 8 bucati din care modelam in snusruri lungi subtiri, pe care le indoim la jumatate, le rulam  si le impletim, apoi le suprapunem in forma de 8. Punem mucenicii intr-o tava tapetata cu hartie de copt.\r\nIi vom coace timp de 20-30 de minute in cuptor electric preincalzit la 180°C (in functie d eputerea cuptorului).\r\nCat timp acestia se coc pregatim siropul: fierbem apa cu zaharul si aromele timp de 5 minute. Lasam sa se raceasca putin si adaugam mierea de albine si esenta de vanilie.\r\nCand mucenicii sunt gata ii scoatem din cuptor, ii lasam sa se raceasca foarte putin, apoi ii inmuiem bine in sirop, dar cat sa fie coaja umeda, iar interiorul inca pufos. Ii ungem cu miere si presaram nuca.\r\nIi servim proaspeti, cu nuci presarate din belsug.\r\n",
                    Type = "Desert"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 7,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Balmos",
                    PrepMode = "În primul rând vă spunem că dacă nu aveți de unde lua zer, îl puteți înlocui cu o smântână mai ușoară, cât mai apoasă. Astfel, într-o oală înaltă puneți untul la topit, asezonat cu un pic de sare. Apoi turnați deasupra zerul/smântâna și lăsați la fiert, la foc mic. Când începe să clocotească, turnați mălaiul treptat și cernut – ca pentru mămăligă. Amestecați un pic să nu facă deloc cocoloașe și lăsați la fiert 15 minute. Puneți oul, amestecați. Radeți brânza peste balmoșul care se formează în oală și amestecați temeinic. Când începe să se desprindă de pe oală, mai lăsați 5 minute și dați la o parte de pe foc.\r\nSe servește cu caș fărâmițat deasupra și cu lapte acru din belșug.\r\n",
                    History = "Una din mâncărurile de bază ale ciobanilor din pitoreasca zonă a Bucovinei, balmoșul este de multe ori confundat cu o banală mămăligă. Da, are la bază tot mălaiul, dar nu se fierbe în apă ci în zer (sau jintuială).",
                    PrepTime = "75 min",
                    Type = "Fel principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 7,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Alivenci Moldovenesti",
                    PrepMode = "Laptele se pune la fiert cu un praf de sare., amestecând din când în când să nu se lipească. Atunci când dă în clocot, adăugați mălaiul, cernut treptat, ca atunci când faceți mămăligă. Amestecați, amestecați, ca să nu se formeze cocoloașe. După 10 minute, dați de pe foc și lăsați la răcit.\r\nÎntre timp, preîncălziți cuptorul. Într-un castron mic, separați ouăle. Într-un bol mediu amestecați brânza cu smântâna și adăugați gălbenușurile. Bateți albușurile cu un vârf de linguriță de sare până se întăresc.\r\nAmestecați terciul de mămăligă cu crema de brânză. Încorporați albușurile, cu mișcări ample. Ungeți o tavă care nu lipește cu unt (sau tapetați-o cu hârtie de copt).  Turnați compoziția și nivelați-o. Dacă doriți, puteți presăra deasupra cașcaval ras.\r\nDați la cuptor pentru 35-40 minute sau până când vedeți că se rumenește apetisant la suprafață. Serviți calde, cu smântână cremoasă deasupra.\r\n",
                    History = "",
                    PrepTime = "65 min",
                    Type = "Aperitiv"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 7,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Poale-n Brau",
                    PrepMode = "Se încinge cuptorul la 200 de grade şi se unge o tavă mare cu ulei.\r\nSe dizolvă drojdia în apă călduţă şi se amestecă cu 2 linguri de zahăr, apoi se lasă la dizolvat 10 minute.\r\nSe amestecă laptele cu ouăle, uleiul, restul de zahăr şi aromele. Se adaugă un paf de sare şi drojdia dizolvată,apoi se incorporează făina treptat şi se frământă bine aluatul, până devine un pic poros.\r\nSe unge un castron mare cu ulei, se pune bila de aluat, acoperită cu un strat de ulei şi o cârpă şi se lasă la dospit până se dublează în cantitate.\r\nSe pregăteşte umplutura de brânză, astfel încât ultimul să fie turnat grişul, care se mai ajustează în funcţie de cât de densă vreţi să fie la final crema.\r\nSe întinde bila de aluat dospit cu un făcăleţ şi se taie în pătrate, care se umplu cu cremă de brânză şi se împăturesc de colţuri, care se presează deasupra, ca un plic.\r\nAmestecaţi ouăle cu lapte pentru uns şi daţi pe deasupra plăcintelor cu o pensulă de gătit.\r\nSe dau poalele-n brâu la cuptor pentru circa 30 de minute, după care se ung cu apă cu zahăr şi se pudrează sau nu cu zahăr.\r\n",
                    History = "",
                    PrepTime = "NA",
                    Type = "Desert"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 7,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Parjoale Moldovenesti",
                    PrepMode = "Punem feliile de paine (folosim paine mai uscata, veche de 2-3 zile) la inmuiat in lapte pentru cca 10 minute.\r\nAmestecam ambele tipuri de carne tocata, apoi adaugam cartoful crud, usturoiul si ceapa, date toate prin razatoarea cu gauri foarte mici. Adaugam ouale, mararul si patrunjelul, dupa gust, tocate foarte marunt, si painea stoarsa bine. Condimentam cu sare si piper si framantam pana obtinem un amestec omogen.\r\nAcoperim vasul cu o folie de plastic alimentara si il punem in frigider pentru 1 ora.\r\nDupa repaus, punem intr-o farfurie pesmetul si faina si le amestecam.\r\nCu mainile umede, formam parjoale lunguiete de circa 50-60 g si le asezam in farfurie. Le presam, astfel incat parjoala finala sa aiba o grosime de circa 1,5 cm.\r\nTavalim parjoalele moldovenesti pe ambele parti prin amestecul de pesmet.\r\nPunem ulei intr-o tigaie antiaderenta (circa un deget de ulei) si cand acesta s-a incins, adaugam parjoalele. Inainte de a pune parjoalele in tigaie, le mai alungim putin. Facem acest lucru, pentru ca in timp ce se prajesc, se mai strang.\r\nLe prajim la foc mic spre mediu, cate 5-6 minute pe fiecare parte (timpul este relativ, depinde foarte mult de marimea parjoalelor si tigaia folosita).\r\nLe scoatem pe o farfurie tapetata cu hartie absorbanta de bucatarie si dupa ce s-au scurs, le servim.\r\n",
                    History = "",
                    PrepTime = "NA",
                    Type = "Aperitiv"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 4,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Mucenici Muntenesti",
                    PrepMode = "Amestecă făina, apa și sarea și frământă pentru a obține un aluat potrivit de tare. Întinde aluatul într-o foaie nu mai groasă de 1/2 cm. Taie mucenicii cu aparatul special în formă de 8.\r\nPune mucenicii tăiaţi pe hârtie (sau într-o tavă), răsfiraţi. Lasă-i să se usuce timp de o oră.\r\nPune pe foc o oala cu 2-3 litri de apa, cu sare si zahăr – după gust. Când apa începe sa fiarbă, micșoreaza focul și pune mucenicii cu grijă. Adaugă răzătura de citrice, esenţele și zahărul vanilat si lasă-i la fiert în jur de 20-25 de minute.\r\nMucenicii se servesc reci sau calzi, cu nucă si scorţisoară presărate deasupra.\r\n",
                    History = "",
                    PrepTime = "90 min",
                    Type = "Desert"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 4,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Racitura de porc Munteneasca",
                    PrepMode = "1. Picioarele şi capul se pârlesc la flacăra aragazului, se răzuie şi se spală în mai multe rânduri în apă rece, până ce sunt albe şi curate. Apoi, capul se taie.\r\n2. Carnea şi extremităţile porcului se pun la fiert în 6 litri de apă rece cu sare. După ce s-a luat spuma care se va forma la suprafaţă, se pun cepele şi morcovii, care se scot înainte de a fi fiartă carnea.\r\n3. Se lasă la fiert până ce carnea se ia de pe oase şi zeama scade la jumătate. Carnea se scoate, se aruncă oasele şi ceapa şi ce rămâne se taie bucăţi mici. Usturoiul se pisează şi se pune în zeama în care a fiert carnea. Se lasă aşa 15-20 de minute, după care se strecoară şi se potriveşte gustul de piper.\r\n3. În patru vase se pune pe fund o felie de ou fiert şi apoi mazăre şi rondele de morcovi. Se pun carnea şi bastonaşe de morcovi şi apoi se toarnă zeamă. Se acoperă şi se dau la rece, dacă este posibil nu în frigider.\r\n",
                    History = "",
                    PrepTime = "6 ore",
                    Type = "Aperitiv"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 4,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Mamaliga in straturi",
                    PrepMode = "Pune apa pentru mămăligă la fiert, adaugă-i sare și cele 700 g de iaurt. Amestecă până devine omogen și începe să clocotească. Presară treptat mălaiul și cu o lingură de lemn amestecă vioi pentru a nu se forma cocoloașe.\r\nDupă ce compoziția se îngroașă și se dezlipește cu ușurință de pe vas, oprește focul.\r\nImediat ce ai luat mămăliga de pe foc, încorporează smântâna în ea printr-o amestecare continuă.\r\nÎncinge o tigaie antiaderentă pe foc, pune uleiul în ea și călește cârnații sau afumătura de porc, în funcție de ce tip de carne dorești să ai în mămăligă.\r\nÎntr-un vas de yena sau într-o tavă, întinde cu o lingură de lemn primul strat de mămăligă, peste care pune o jumătate din cantitatea de telemea răzuită, dar și jumătate din cantitatea de urdă.\r\nDeasupra, așază câteva bucățele de cârnat/ afumătură, iar apoi învelește acest strat cu unul de mămăligă. Întinde iar un strat de telemea, unul de urdă și unul de afumătură, pe care îl vei acoperi cu încă un strat de mămăligă fierbinte. Păstrează cârnați/ afumătură și pentru ornare.\r\nFolosește o lingură pentru a face 4 cuiburi la suprafața ultimului strat de mămăligă, și sparge acolo câte un ou. La final, aruncă la întâmplare cârnații rămași.\r\nBagă tava cu mămăligă în straturi în cuptorul preîncălzit la 180 de grade Celsius, las-o jumătate de oră și după acest timp scoate-o din cuptor.\r\nDă-i voie mămăligii în straturi să se odihnească preț de 10 minute, apoi bucură-te de ea din plin.\r\n",
                    History = "",
                    PrepTime = "40 min",
                    Type = "Fel principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 4,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Papanasi fierti cu branza de vaci si pesmet",
                    PrepMode = "Pentru ca papanașii fierți să fie gustoși, e important să respecți cantitățile de ingrediente recomandate. Bineînțeles, dacă vrei un rezultat cu un gust desăvârșit, trebuie să pui și un strop de dragoste pe lângă ingredientele folosite.\r\nÎntr-un vas încăpător, amestecă vioi grișul din grâu Raftul Bunicii cu brânza bine scursă înainte, zahărul pudră, un praf de sare, ouăle, dar și coaja de lămâie rasă și zahărul vanilat. După ce amestecul devine omogen, dă-i răgaz jumătate de oră, timp în care acesta va crește de bucurie.\r\nClătește-ți mâinile cu apă rece, ia aluatul și modelează-l în 20 de biluțe aproximativ egale. Lasă-le să se odihnească pe o tavă cât timp pui apa la fiert și pregătești toppingul.\r\nToppingul de pesmet prăjit pentru papanași se prepară foarte rapid. Topește untul într-o tigaie și amestecă ușor. La final, după ce pesmetul capătă o nuanță maro, se adaugă și zahărul și se mai lasă cel mult 3 minute pe foc.\r\nCând apa începe să clocotească, dizolvă în ea sare și apoi adaugă biluțele de aluat, una câte una, în apă. Se lasă focul mai mic și se așteaptă să se ridice la suprafață papanașii. Din acel moment, se mai lasă la fiert maxim 3-4 minute și se scot cu ajutorul unei spumiere.\r\nPapanașii sunt transferați imediat în tigaia cu pesmet proaspăt prăjit. Cu o lingură de lemn, rostogolește-i prin pesmet, astfel încât să fie complet acoperiți de acesta.\r\nSunt gata de servire, îți mai rămâne să-i înnobilezi cu smântână rece și puțină dulceață.\r\n",
                    History = "",
                    PrepTime = "40 min",
                    Type = "Desert"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 4,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Ciorba de fasole in paine",
                    PrepMode = "Pasul 1\r\nPregătește fasolea cu o seară înainte. Aceasta trebuie spălată și curățată foarte bine, apoi lăsată într-un bol cu apă la înmuiat. Ai grijă ca apa din vas să acopere integral fasolea.\r\nPasul 2 – Pregătirea pâinii\r\nIa un bol micuț și amestecă bine drojdia, sarea și puțină apă călduță. Toată această compoziție adaugă peste Făina Standard 650 Raftul Bunicii. Suflecă-ți bine mânecile și începe să alinți cu grijă aluatul de pâine. Treptat, adaugă apă și continuă să frămânți până când obții un aluat care se dezlipește de pe mâni. După ce ai terminat, lasă-l la odihnit pentru aproximativ o oră.\r\nDupă ce aluatul a crescut vesel și frumos, împarte-l în patru părți egale și așază-l în tot atâtea tăvi rotunde tapetate în prealabil cu ulei și făină. După ce ai așezat aluatul în forme, mai lasă-l puțin să crească, apoi lasă-l la cuptor pentru o oră.\r\nDupă ce pâinicile sunt gata, le poți unge cu un ou pentru a prinde un aspect auriu și minunat, iar apoi lasă-le la cuptor pentru încă 5 minute.\r\nPasul 3 – Pregătirea ciorbei\r\nDupă ce ai terminat pâinica, este timpul să te apuci de pregătit ciorba. Ia mai întâi o oală mare și pune la fiert fasolea pe care ai lăsat-o cu o seară înainte la înmuiat. Ea trebuie să fiarbă aproximativ 10 minute. Într-o oală separată, pune la fiert și carnea din ciolanul afumat sau costița și fierbe-o tot în jur de 10 minute.\r\nAcum trebuie să iei o altă oală mai mare și călește ceapa, morcovii, ardeiul și condimentele ( boia, sare, piper) în ea. După ce toate legumele au prins o culoare frumoasă, poți adăuga apa, țelina, apoi fasolea și carnea fierte. Lasă totul pe foc și când apa începe să danseze, adaugă sucul de roșii, cimbrul și tarhonul. Mai fierbe apoi ciorba pentru aproximativ 10 minute și poți opri focul.\r\nPasul 4 – Servirea\r\nIa fiecare pâinică și taie vârful acesteia pentru a forma un capac. Scoate miezul, astfel încât pâinica să rămână goală. Pune pâinea pe o farfurie, umple-o cu ciorbița de fasole realizată anterior, apoi acoperă totul cu capacul din coajă.\r\n",
                    History = "",
                    PrepTime = "2 ore",
                    Type = "Fel principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 4,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Specialitate munteneasca cu ciuperci",
                    PrepMode = "Primul pas constă în pregătirea unui aluat de clătite și înarmarea cu multă răbdare pentru a prăji uniform, fiecare clătită în tigaia încinsă, de teflon.\r\nLasă clătitele aurii la odihnit și pregătește, între timp, compoziția. Într-un bol încăpător, amestecă făina, sarea și ouăle, încorporează laptele și apa minerală carbogazoasă, responsabilă de aspectul pufos și de consistența aerată a umpluturii. Taie ceapa mărunt-mărunt și călește-o rapid în ulei; adaugă peste ea ciupercile tăiate în felii subțiri și lasă totul pe foc pentru 15 minute, amestecând din când în când. Adaugă compoziția peste ceapă și ciuperci și mai lasă la foc mic, pentru maximum 10 minute, amestecând continuu cu o spatulă din lemn.\r\nÎntr-un vas termorezistent și suficient de înalt, așază prima clătită, peste care pune un strat uniform de umplutură. Repetă acest pas până consumi toate ingredientele. Poți strecura printre straturi și felii subțiri de roșii ori de castraveți murați ori după cum te ghidează pofta. Dă la cuptor, la 175 de grade Celsius, pentru aproximativ 15 minute.\r\nOrnează cu pătrunjel proaspăt, cu roșii-cherry sau frunze de salvie.\r\n",
                    History = "",
                    PrepTime = "NA",
                    Type = "Fel principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 4,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Bors de Leurda",
                    PrepMode = "cartofii se taie cubulete si se pun la fiert in 2 l de apa cu sare, timp de 10 minute;\r\nseparat, se pune la fiert borsul;\r\nceapa se toaca, iar leuda se taie fideluta, apoi se adauga peste cartofi si se mai lasa pe foc, acoperit, inca 15 minute;\r\nse adauga apoi si borsul si se mai lasa pentru cateva clocote;\r\nse sareaza si se pipereaza;\r\nleusteanul se toaca si se presara peste fiertura;\r\nse drege cu ou batut cu smantana.\r\n",
                    History = "",
                    PrepTime = "NA",
                    Type = "Fel principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 3,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Mamaliga Toponita",
                    PrepMode = "Începe să preîncălzești cuptorul.\r\nPe aragaz, pune într-un ceaun apa cu sare la fiert. Cu zâmbetul pe buze, îndreaptă-te spre blatul de lucru din bucătărie și începe să tai în cuburi mărunte toate tipurile de carne. Apucă degrabă o tigaie întinsă, toarnă ulei în ea și pune-o pe un alt ochi de aragaz. În ea vei prăji cubulețele de carne.\r\nCând apa din ceaun dă în clocot, începe să presari din abundență Mălai Extra Gold Raftul bunicii, pentru a face mămăliga. Este bine să o faci cât mai moale în această etapă.\r\nDupă ce carnea s-a prăjit bine, pune cubulețele într-un alt vas. Cu o parte din untura topită rămasă în tigaie, unge tava în care vei pune la cuptor toponita. Cealaltă parte o vei adăuga în compoziție.\r\nPe tava tapetată cu untură, așază primul strat de mămăligă moale, cât de subțire poți. Peste acest strat, adaugă unul format din carnea friptă în tigaie. Continuă cu încă un strat de mămăligă, după care adaugă unul de brânză telemea, de oaie sau vacă, după preferințe. Peste stratul de brânză, toarnă unul de untură topită, apoi un alt strat de carne friptă, unul de mămăligă, unul de brânză, și continuă tot așa, până când observi că ai terminat ingredientele. Aplică secretul care va asigura reușita toponitei: ai grijă ca ultimul strat de deasupra să fie cel format din mămăligă.\r\nAcum, bate oul și unge cu el mămăliga. Ia tava și așaz-o drăgăstos în cuptor, unde toponita se va rumeni voioasă, în aproximativ 20 sau 30 de minute. Servește-o cât e caldă, de preferat cu smântână rece!\r\n",
                    History = "",
                    PrepTime = "40 min",
                    Type = "Fel principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 3,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Cornuri cu magiun",
                    PrepMode = "Ia un castron mic din bucătărie și freacă drojdia cu 1 lingură de zahăr, până când se lichefiază. Pentru drojdia uscată, folosește 3-4 linguri de lapte cald și 1 lingură de zahăr.\r\nIa un bol încăpător și cerne cu dedicare Făina Superioară 000 Raftul bunicii, peste care adaugă coaja de lămâie fin răzuită, amestecă bine ingredientele, după care toarnă drojdia.\r\nÎntr-un mic bol, bate oul întreg cu 3 dintre gălbenușuri, laolaltă cu zahărul rămas, apoi incorporează treptat extractul de vanilie, sarea și laptele cald. Toarnă această compoziție peste făină.\r\nCu o spatulă sau o lingură de lemn, amestecă bine compoziția, până când făina absoarbe lichidele, iar apoi frământă cu grijă timp de 10 minute, până când vei obține un aluat omogen.\r\nEste momentul să adaugi untul moale, treptat, și să continui frământatul până rezultă un aluat fin și moale. Pune aluatul obținut la odihnit într-un castron, la căldură, și lasă-l așa până când își dublează volumul. Îi va lua în jur de 45 de minute sau 1 oră.\r\nPe blatul de lucru, toarnă puțin ulei și răstoarnă aluatul crescut, pe care apoi îl întinzi cu palmele sau un sucitor, în formă rotundă, de 1 cm grosime.\r\nÎmparte cercul în 12 triunghiuri egale, cu ajutorul unui cuțit cu vârf ascuțit. La baza triunghiurilor, pune în cantitate egală o bilă de magiun. Acum, rulează aluatul de la bază spre vârf, astfel încât magiunul să rămână protejat, la mijloc. Formează cornulețele și așază-le pe o tavă de copt tapetată cu hârtie, cu vârful aluatului dedesubt, pentru a nu se desface în cuptor.\r\nMai lasă cornurile în tavă, pentru a-și mări volumul, iar după aceea unge-le cu gălbenușul de ou rămas, bătut cu 3 linguri de apă.\r\nÎncinge cuptorul la 190 de grade Celsius, așază tava în interiorul acestuia la o înălțime medie, iar apoi redu temperatura la 180 de grade. În 25 de minute, cornurile vor căpăta rumeneala mult dorită.\r\nÎn timpul coacerii, aplică secretul care te va ajuta să obții cornuri bine coapte și crocante: acoperă-le cu o folie de aluminiu sau o coală de hârtie de copt umezită, asta deoarece aluatul dulce se va rumeni mai repede decât se va coace în interior.\r\nLa final, scoate cornurile pe tava, presară-le cu zahăr pudră și adună pofticioșii în jurul mesei, pentru a se răsfăța cu o delicatesă splendidă, culeasă tocmai din Crișana.\r\n",
                    History = "",
                    PrepTime = "2 ore",
                    Type = "Desert"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 3,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Supa de gulii",
                    PrepMode = "Taie morcovii rondele și ceapa mărunt, apoi, călește-le în ulei. În timp ce se rumenesc, rade deasupra lor guliile─ pe dinții mari─ și mai lasă totul pe foc, timp de 5 minute.\r\nAdaugă supa și potrivește de sare. Din făină, ou și apă, pregătește găluște de mărimea unui ou de porumbel, pe care le adaugi în supă, când legumele s-au fiert.\r\nAșteaptă ca găluștele să capete consistență, apoi, adaugă mărar și pătrunjel și stinge focul. Acoperă pentru câteva minute, apoi servește cu smântână.\r\n",
                    History = "",
                    PrepTime = "NA",
                    Type = "Fel principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 3,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Gimicus",
                    PrepMode = "Slanina sau costita afumata se taie feliute si se prajeste in tigaie (in tipsie din tuci), in ulei Arpis.\r\nCarnatul afumat se taie rondele si se adauga si el peste slaninuta, impreuna cu caltabosul taiat felii.\r\nSe prepara malaiul copt din faina Arpis, pe baza retetei folosite in Banat si Crisana \r\nDupa ce s-a racit malaiul copt, se sfarama peste ingredientele de mai sus si se amesteca totul astfel incat sa absoarba malaiul din grasimea lasata de la prajit, dupa care se poate servi cu muraturi.\r\n",
                    History = "",
                    PrepTime = "NA",
                    Type = "Fel principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 5,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Supa crema de praz",
                    PrepMode = "1. În oala de fiert supa se topeşte untul şi se pun prazul tăiat rondele şi ceapa tăiată peştişori. Se amestecă şi se lasă 10 minute să se înmoaie.\r\n2. Se adaugă cartofii curăţaţi şi tăiaţi rondele foarte subţiri. Se lasă 2 minute să se călească uşor.\r\n3. Se adaugă sare, piper, nucşoară, lapte şi apă şi se lasă la fiert 30 de minute.\r\n4. Apoi, se mixează ingredientele şi se aduce supa imediat la masă presărată cu mărar.\r\n",
                    History = "",
                    PrepTime = "45 min",
                    Type = "Fel principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 5,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Ciorba de praz",
                    PrepMode = "1. În oala de fiert ciorba se încinge uleiul şi se căleşte un pic afumătura. Apoi se scoate.\r\n2. În acelaşi ulei se pun la călit întâi bulionul şi, după un minut, se adaugă ceapa, morcovul şi prazul tăiate mărunt.\r\n3. Se adaugă afumătura, se pun doi litri de apă şi se lasă la fiert pentru 20 de minute.\r\n4. Când prazul şi carnea au fiert, se pun roşiile fără pieliţe şi se mai lasă pe foc 10 minute, potrivind gustul de sare.\r\n",
                    History = "",
                    PrepTime = "40 min",
                    Type = "Fel principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 5,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Tarta de praz cu morcovi",
                    PrepMode = "1. Morcovii se răzuiesc şi se trec prin răzătoarea cu ochiuri mari. Prazul se curăţă şi se taie rondele fine.\r\n2. Într-o lingură de ulei, se călesc legumele până devin translucide şi apoi se lasă să se răcească.\r\n3. Ouăle se bat ca pentru omletă, se adaugă laptele şi brânza trecută prin răzătoare.\r\n4. Se amestecă ouăle cu legumele, sare şi piper, după gust, şi se toarnă într-o formă rotundă sau o cratiţă care merge la cuptor. Se dă la copt pentru 45 de minute până ce o scobitoare introdusă iese curată.",
                    History = "",
                    PrepTime = "65 min",
                    Type = "Aperitiv"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 5,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Saramura de pui",
                    PrepMode = "Începe prin a spăla bine și prin a porționa puiul. Masează apoi bucățile de pui cu sare și piper din belșug. Pune bucățile de carne pe grătarul încins, apoi spală roșiile și ardeii grași și așază-i tacticos lângă carne. Ai grijă să nu se ardă nici legumele, nici puiul, acestea trebuie să rămână suculente, așa că, le poți întoarce de oricâte ori este nevoie, pentru a se pătrunde bine.\r\nÎntre timp, cât se rumenesc legumele și puiul, umple cu apă o oală potrivită, adaugă sare și las-o la foc mic, până ce începe să clocotească. Atunci când ardeii grași și roșiile s-au copt, pune-le cu grijă, rând pe rând, în apa care clocotește. Poți toca mărunt aceste legume sau le poți lăsa întregi, după cum știi că vă plac în familie.\r\nCurăță usturoiul și pisează-l, apoi adaugă-l în oală, alături de boabele de piper, ardeiul iute tocat mărunt, dar și de tarhon. După ce acest amestec dă iar în clocot, este momentul să oprești focul, pentru că toate aromele s-au întrepătruns și este exact ce trebuie să fie.\r\nCât ai clipi, iată că și puiul de pe grătar este rumenit și arată delicios!  Așază-l tacticos într-o tavă sau într-un vas de yena și toarnă peste el toată saramura de legume și condimente pregătită mai devreme. Lasă-l să se mai odihnească la cuptor, vreme de 15 minute, la o temperatură de maximum 180 de grade.\r\nImediat ce scoți saramura de pui din cuptor, presară pe deasupra pătrunjelul și leușteanul tocate mărunt.\r\n",
                    History = "",
                    PrepTime = "70 min",
                    Type = "Fel principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 5,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Turta de malai",
                    PrepMode = "Pasul 1\r\nPrimul pas pentru a realiza o turtă de mălai este pregătirea unui păsat (a unei mămăligi moi). Acestea fiind spuse, pregătește o oală cu apă pe care trebuie să o pui la fiert și presară 2 lingurițe de sare în ea. Apa trebuie să ajungă la aproximativ 70 de grade.\r\nAsigură-te că nu va da în clocot, altfel există posibilitatea ca mălaiul să facă multe cocoloașe. Când apa s-a încălzit suficient, toarnă două polonice de Mălai Extra Gold Raftul bunicii și amestecă în mod constant și cu multă grijă, timp de aproximativ 10 minute, pentru ca păsatul să nu adune cocoloașe. În timp ce amesteci, adaugă treptat mai mult mălai, până când obții consistența unei mămăligi moi.\r\nPasul 2\r\nPregătește un bol mare în care să pui toată Făina Superioară 000 Raftul bunicii. După ce ai pregătit mămăliga, pune-o, așa fierbinte cum este, peste făina din bol. Amestecă apoi totul foarte bine până când obții o compoziție omogenă și fină.\r\nPasul 3\r\nDupă ce ai terminat de amestecat, lasă puțin compoziția la răcit, apoi suflecă-ți bine mânecile și începe să modelezi frumos turta. Pregătește o tavă unsă cu puțin unt, iar apoi așază turta în ea cu mare grijă. Umezește-ți mâinile cu puțină apă și modelează partea de sus a turtei pentru a închide crăpăturile de la suprafață.\r\nPasul 4\r\nPune tava la cuptorul încins în prealabil la 180 de grade, pentru aproximativ o oră, până când turta se coace foarte bine și prinde o culoare rumenă frumoasă.\r\nDupă ce se răcește te poți bucura de o turtă tradițională gustoasă și fragedă realizată în doar 4 pași simpli. Nu uita să-i chemi și pe cei dragi la masă.\r\n",
                    History = "Turta de mălai sau pâinea bunicilor este o rețetă oltenească mai puțin cunoscută în zilele noastre. Cu toate acestea, dacă o întrebi pe bunica, o să-ți povestească nostalgică despre vremurile în care aceasta era aproape nelipsită din bucătăria țărănească.\r\nConsumată atât pe timp de vară, cât și pe timp de iarnă, coaptă la cuptor de cărămidă sau țest, turta de mălai însoțea pe vremuri orice fel de mâncare și era frecvent consumată de gospodari. Acest lucru se datora faptului că oamenii nu puteau mânca numai mămăligă, iar pâinea era mult prea scumpă. Astfel, turta de mălai era cel mai bun înlocuitor.\r\nÎn zilele noastre, tinerii curioși încă testează această rețetă delicioasă și ușor de făcut. Iar pentru cine știe să facă mămăligă sau pâine, este floare la ureche să prepare turta de mălai.\r\nȘi pentru că astăzi este despre amintiri, despre tradiție și despre nostalgia vremurilor trecute, te invităm mai aproape de copilăria bunicilor, testând și tu această rețetă simplă și gustoasă, ce are o tradiție românească îndelungată.\r\n",
                    PrepTime = "80 min",
                    Type = "Aperitiv"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 6,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Tochitura Dobrogeana",
                    PrepMode = "Pasul 1\r\nPrima dată, ia carnea de porc, pe care o tai în cubulețe medii. Pregătește o tigaie încăpătoare și pune uleiul sau untura la încins. Când a devenit suficient de fierbinte, adaugă bucățelele de carne și lasă-le pe foc până când încep să albească. Adaugă acum cele două căni de apă, piperul boabe și foile de dafin.\r\nPasul 2\r\nLasă totul la fiert la foc mic pentru aproximativ 30 de minute, până când carnea devine moale, iar sosul scade. După ce sosul a scăzut suficient, iar carnea este numai bună, poți adăuga vinul, pasta de roșii și usturoiul tocat mărunțel. Amestecă totul foarte bine, apoi potrivește gustul preparatului cu sare, boia, cimbru și piper. Mai lasă totul pe foc aproximativ 10 minute, apoi poți pune tochitura deoparte.\r\nPasul 3\r\nAcum este timpul să te pregătești mămăliguța cremoasă alături de care vei servi tochitura dobrogeană. Pentru aceasta ai nevoie de:\r\n1 pahar de Mălai Extra Gold Raftul Bunicii - good\r\n4 pahare cu apă - good\r\n1 praf de sare\r\n1 lingură de unt\r\nMod de preparare mămăligă cremoasă\r\nPasul 1\r\nDupă ce ai făcut rost de toate ingredientele, pune apa la fiert până când începe să fiarbă, toarnă apoi mălaiul în ploaie și amestecă continuu pentru a nu forma cocoloașe.\r\nPasul 2\r\nPăstrează mămăliga la foc mic până când devine cremoasă și se desprinde de marginile vasului. Răstoarn-o apoi pe o farfurie mare și ai terminat.\r\nPasul 3\r\nDupă ce mămăliguța este gata, pregătește câte un ou ochi pentru fiecare porție de tochitură și rade deasupra acestuia brânza de vaci.\r\nAșază toate elementele pe farfurie și apoi îi poți chema pe cei dragi pentru a servi o masă tradițională delicioasă, așa cum se servește și în zona Dobrogei.\r\n",
                    History = "",
                    PrepTime = "50 min",
                    Type = "Fel principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 6,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Placinta Dobrogeana",
                    PrepMode = "Pasul 1\r\nPrima dată vei începe cu prepararea foii de plăcintă. Pentru aceasta ai nevoie de un bol micuț, în care trebuie să amesteci drojdia cu o linguriță de zahăr, până când obții o pastă lichidă.\r\nSeparat, într-un bol mai mare, adaugă un kg de Făină Superioară 000 Raftul bunicii, pasta pe care ai preparat-o anterior, două linguri de ulei, două linguri de oțet și două-trei lingurițe de sare.\r\nAcum este timpul să îți sufleci bine mânecile, și cu zâmbetul pe buze, să te apuci de frământat. Dacă ți se pare că aluatul devine foarte lipicios, adaugă treptat mai multă făină, până când observi că ți se desprinde de pe mâini. După de ai terminat de frământat, împarte coca în două bucăți mari și lasă-le la odihnit în timp ce te ocupi de compoziție.\r\nPasul 2\r\nPentru a prepara compoziția, pregătește un bol mare în care vei începe să razi brânza sărată. Peste aceasta adaugă cele trei ouă, pliculețele de zahăr vanilat, coaja rasă de la o lămâie și cana cu zahăr. Apoi, începe să amesteci toate ingredientele foarte bine.\r\nPasul 3\r\nIa cele două două bucăți de aluat pe care le-ai lăsat la dospit și împarte-le pe jumătate, astfel încât, să obții patru mingiuțe de cocă.\r\nPresară puțină făină pe blatul de lucru și cu ajutorul unui sucitor, întinde prima foaie de plăcintă. Stropește-o cu puțin ulei, apoi adaugă câteva linguri din compoziția cu brânză doar în partea de jos a foii. Întinde foarte bine compoziția, apoi, apucă partea de foaie liberă și acoperă cu ea cealaltă parte care conține crema de brânză.\r\nAstfel, vei obține un pachețel delicios gata de pus în tavă. Procedează în același fel și cu celelalte trei foi de plăcintă.\r\nPasul 4\r\nPregătește o tavă încăpătoare și așază cele patru foi de plăcintă umplute cu brânză, după ce ai uns-o în prealabil cu ulei. Înainte de a pune totul la cuptor, ia un bol micuț și amestecă foarte bine două ouă și o cană de iaurt. După ce ai obținut un mix omogen, întinde totul peste plăcintă și asigură-te că întinzi uniform compoziția.\r\nPasul 5\r\nAcum, plăcinta este gata să stea la cuptor aproximativ 40-50 de minute, la foc mic. La final, vei obține o plăcintă aromată și gustoasă, de care cei dragi cu greu se vor putea sătura.\r\n",
                    History = "Cu brânză sărată, dulce sau simplă, plăcinta dobrogeană este un preparat de mare tradiție în familiile românești, nelipsit de pe mesele de sărbătoare.\r\nÎn Dobrogea, există chiar o tradiție culinară, care continuă să fie transmisă din generație în generație, în care mireasa, a doua zi după nuntă, trebuie să pregătească o plăcintă dobrogeană pentru toți musafirii și să demonstreze că poate face cea mai subțire foaie de plăcintă. În acest fel, rețeta bunicii poate fi transmisă mai departe și poate bucura generațiile viitoare.\r\n",
                    PrepTime = "90 min",
                    Type = "Desert"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 6,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Peste cu sos de rosii",
                    PrepMode = "1. Ceapa şi ardeii se taie cubuleţe mici care se pun la călit în ulei. Se presară cu un praf de sare.\r\n2. Se taie şi roşiile, cât se poate de mici, şi se adaugă. Se lasă 10 minute să-şi lase apa şi apoi se adaugă bulionul desfăcut şi el cu puţină apă. Se lasă la fiert alte 10 minute.\r\n3. Se pune peştele curăţat de cap şi coadă, chiar fileuri dacă se poate, şi se lasă să fiarbă în acest sos de legume timp de 10 minute.\r\n4. Se aduce la masă cu pătrunjel.\r\n",
                    History = "",
                    PrepTime = "30 min",
                    Type = "Fel principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 6,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Saramura de Crap",
                    PrepMode = "1. Într-o oală, se pune un litru de apă la fiert cu boabele de piper, sare, frunze de dafin, ardei iute tocat şi roşioare. Se lasă să fiarbă 10 minute şi se dă deoparte. Se adaugă mărarul tocat mărunt.\r\n2. Pe grătarul încins se frig medalioanele de peşte şi, pe măsură ce se rumenesc, se scot şi se pun într-un vas. Se presară felioare de usturoi.\r\n3. Se toarnă zeama fiartă cu roşiile şi se lasă 10 minute înainte de a-l aduce la masă.\r\n",
                    History = "",
                    PrepTime = "55 min",
                    Type = "Fel principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 6,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Bors de Macrou",
                    PrepMode = "1. Pestele se spala si se taie bucaţi nu mai late de doua degete.\r\n2. Ardeiul se taie fâsii, iar morcovul si radacina de patrunjel se trec prin razatoare. Se pun la fiert legumele cu 1,5 litri de apa si sare.\r\n3. Între timp, se da borsul într-un clocot si se toarna în oala alaturi de legume. Se adauga pestele si rosiile, se potriveste de gust cu sare si piper si se lasa la fiert înca 10 minute. Pentru ca macroul este gras, nu se adauga ulei.\r\n4. Se stinge focul, se presara patrunjelul si se aduce borsul la masa.\r\n",
                    History = "",
                    PrepTime = "70 min",
                    Type = "Fel principal"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 6,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Cherdele",
                    PrepMode = "Se face un aluat simplu din făină, apă, sare, drojdie și puțin ulei.\r\nCât se lasă aluatul la dospit, se face umplutura care este din brânză amestecată cu ou ,smântână și verdeață (mărar și foi de ceapă verde) tocată mărunt.\r\nCând coca a dospit, se întind foi late cât palma, pe mijlocul acestora se pune umplutura, se rulează odată pe lățime și se porționează în bucăți. Se așează pe o tavă unsă cu untură (sau ulei), apoi se bagă în cuptorul bine încins. Când cherdelele sunt aproape coapte, se ung pe deasupra cu un amestec de iaurt, smântână sau lapte dulce și ouă astfel la 400 g de iaurt se bat 3-4 ouă. Se reintroduce tava din nou în cuptor și se mai lasă până se rumenesc frumos.\r\n",
                    History = "",
                    PrepTime = "NA",
                    Type = "Desert"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 9,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Clatite cu Urda si verdeata",
                    PrepMode = "Se bat ouale cu un varf de sare timp de 1 – 2 minute. Se toarna de sus si imprastiat faina pana cand se obtine un aluat fin, apoi se adauga apa minerala si laptele. Compozitia se lasa in frigider pentru 30 de minute.\r\nSe pregateste separat umplutura din verdeata tocata marunt, untul lasat la inmuiat, urda, ceapa verde, leurda si sare dupa gust.\r\nDupa ce compozitia a fost racita, se unge o tigaie cu ulei si se lasa la incins apoi se toarna cate un polonic din compozitie in maniera obisnuita pentru prepararea clatitelor.\r\nClatitele astfel obtinute se umplu cu crema de urda si verdeturi.\r\n",
                    History = "Urda este ridicata la rang de mare cinste in Maramures. Pe vreme rece, mamaliguta calda cu urda este nelipsita de pe mese, dar atunci cand vine primavara, urda isi gaseste alte utilizari in bucataria maramureseana, utilizari cel putin la fel de delicioase. O gustare rapida cu urda este perfecta pentru perioada de primavara cand legumele incep sa capete gustul acela aparte de proaspat iar aroma de ceapa verde face orice masa mai imbietoare. Acesta este momentul in care in Maramures incep sa se pregateasca clatite cu urda si verdeata.\r\n",
                    PrepTime = "NA",
                    Type = "Desert"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 9,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Coltunasi cu legume",
                    PrepMode = "Se framanta untul cu faina si se adauga 5 – 6 linguri de apa, o lingurita de otet si un praf de sare. Aluatul framantat astfel obtinut se pune la rece pentru jumatate de zi.\r\nCu 30 de minute inainte ca aluatul sa fie scos de la frigider se taie legumele in cubulete cat mai marunte si se pun la fiert in apa cu sare si piper.\r\nAluatul luat de la frigider se intinde si se taie in forma de cercuri ce se umplu cu legumele fierte se impaturesc pe jumatate si se lipesc cu apa sau cu albus de ou. Marginile coltunasilor se cresteaza cu furculita din motive de prezentare.\r\nScoicile de aluat cu legume se prajesc in ulei incins pana cand capata o culoare aurie.\r\n",
                    History = "",
                    PrepTime = "NA",
                    Type = "Desert"
                },
                new Recipe
                {
                    Id = nextId(),
                    RegionId = 9,
                    Latitude = 0,
                    Longitude = 0,
                    Name = "Supa cu porumb si cascaval",
                    PrepMode = "Pentru a prepara supa de porumb cu cascaval se incepe de la o baza de supa de legume clasica, strecurata.\r\nIntr-o oala incinsa cu unt topit se calesc ceapa uscata, bulbii de ceapa verde si usturoiul pana devin transparente.\r\nSe adauga supa fierbinte de legume impreuna cu chimenul.\r\nSe adauga porumbul (de preferinta porumb congelat) impreuna cu cartofii taiati cuburi si se lasa la fiert 15 minute dupa care se aduna intr-un vas separat cartofii si 200 grame de porumb. Cartofii si porumbul scosi din oala se piseaza si se amesteca cu cascavalul ras si smantana.\r\nDupa ce supa ramasa in oala da in clocot se adauga piureul nou obtinut din cascaval, porumb, cartofi si smantana si se mai lasa la clocotit 4 – 5 minute timp in care se amesteca in continuu.\r\nSe condimenteaza dupa gust.\r\nSe serveste alaturi de cascaval ras si cozi de ceapa verde pentru a fi adaugate in farfurie in functie de gustul fiecarui mesean.\r\n",
                    History = "",
                    PrepTime = "NA",
                    Type = "Fel principal"
                }
            };
        }

        private RecipeIngredient[] GetSeedRecipeIngredients()
        {
            int id = 1;
            int nextId() => id++;

            return new[]
            {
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 1,
                    IngredientId = 1,
                    Quantity = "500 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 1,
                    IngredientId = 2,
                    Quantity = "2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 1,
                    IngredientId = 3,
                    Quantity = "O bucata"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 1,
                    IngredientId = 4,
                    Quantity = "1/4 Bucata"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 1,
                    IngredientId = 5,
                    Quantity = "1/2 Bucata"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 1,
                    IngredientId = 6,
                    Quantity = "4 Bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 1,
                    IngredientId = 7,
                    Quantity = "O bucata"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 1,
                    IngredientId = 8,
                    Quantity = "O bucata"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 1,
                    IngredientId = 9,
                    Quantity = "1/2 lingurita"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 1,
                    IngredientId = 10,
                    Quantity = "200 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 1,
                    IngredientId = 11,
                    Quantity = "2 crengute"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 1,
                    IngredientId = 12,
                    Quantity = "O lingurita"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 1,
                    IngredientId = 13,
                    Quantity = "4 linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 1,
                    IngredientId = 14,
                    Quantity = "Un"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 1,
                    IngredientId = 15,
                    Quantity = "o lingurita"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 1,
                    IngredientId = 16,
                    Quantity = ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 1,
                    IngredientId = 17,
                    Quantity = ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 1,
                    IngredientId = 18,
                    Quantity = ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 1,
                    IngredientId = 19,
                    Quantity = ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 2,
                    IngredientId = 2,
                    Quantity = "3 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 2,
                    IngredientId = 21,
                    Quantity = "O legatura"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 2,
                    IngredientId = 22,
                    Quantity = "O bucata"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 2,
                    IngredientId = 8,
                    Quantity = "O bucata"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 2,
                    IngredientId = 23,
                    Quantity = "2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 2,
                    IngredientId = 24,
                    Quantity = "Un catel"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 2,
                    IngredientId = 15,
                    Quantity = "300 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 2,
                    IngredientId = 14,
                    Quantity = "3 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 2,
                    IngredientId = 16,
                    Quantity = "2 linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 2,
                    IngredientId = 25,
                    Quantity = "3 linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 2,
                    IngredientId = 12,
                    Quantity = "4 linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 2,
                    IngredientId = 9,
                    Quantity = "O lingura"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 2,
                    IngredientId = 17,
                    Quantity = ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 2,
                    IngredientId = 18,
                    Quantity = ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 2,
                    IngredientId = 7,
                    Quantity = "O"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 3,
                    IngredientId = 26,
                    Quantity = "300 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 3,
                    IngredientId = 8,
                    Quantity = "O bucata"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 3,
                    IngredientId = 2,
                    Quantity = "Doua bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 3,
                    IngredientId = 27,
                    Quantity = "Un"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 3,
                    IngredientId = 9,
                    Quantity = "4 linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 3,
                    IngredientId = 28,
                    Quantity = "800 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 3,
                    IngredientId = 29,
                    Quantity = "500 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 3,
                    IngredientId = 21,
                    Quantity = ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 3,
                    IngredientId = 15,
                    Quantity = "100 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 4,
                    IngredientId = 30,
                    Quantity = "700 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 4,
                    IngredientId = 8,
                    Quantity = "O"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 4,
                    IngredientId = 31,
                    Quantity = "Doua bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 4,
                    IngredientId = 32,
                    Quantity = ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 4,
                    IngredientId = 33,
                    Quantity = "200 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 4,
                    IngredientId = 7,
                    Quantity = "O"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 4,
                    IngredientId = 34,
                    Quantity = "1/4 lingurita"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 4,
                    IngredientId = 18,
                    Quantity = ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 4,
                    IngredientId = 17,
                    Quantity = ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 4,
                    IngredientId = 10,
                    Quantity = "3-4 linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 4,
                    IngredientId = 35,
                    Quantity = "2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 5,
                    IngredientId = 9,
                    Quantity = "250 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 5,
                    IngredientId = 29,
                    Quantity = "150 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 5,
                    IngredientId = 36,
                    Quantity = "1/2 cub"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 5,
                    IngredientId = 17,
                    Quantity = ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 5,
                    IngredientId = 38,
                    Quantity = "2 linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 5,
                    IngredientId = 16,
                    Quantity = "2 cani"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 5,
                    IngredientId = 40,
                    Quantity = "200 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 6,
                    IngredientId = 44,
                    Quantity = "1 kg"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 6,
                    IngredientId = 29,
                    Quantity = "5 L"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 6,
                    IngredientId = 88,
                    Quantity = "4"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 6,
                    IngredientId = 8,
                    Quantity= "2"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 6,
                    IngredientId = 45,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 6,
                    IngredientId = 33,
                    Quantity= "250 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 6,
                    IngredientId = 24,
                    Quantity= "O capatana"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 6,
                    IngredientId = 12,
                    Quantity= "2-4 linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 6,
                    IngredientId = 27,
                    Quantity= "2-3 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 6,
                    IngredientId = 18,
                    Quantity = ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 6,
                    IngredientId = 17,
                    Quantity = ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 7,
                    IngredientId = 46,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 7,
                    IngredientId = 47,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 7,
                    IngredientId = 38,
                    Quantity= "350 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 7,
                    IngredientId = 13,
                    Quantity= "600 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 7,
                    IngredientId = 48,
                    Quantity= "10 lingurite"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 7,
                    IngredientId = 49,
                    Quantity= "500 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 7,
                    IngredientId = 50,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 7,
                    IngredientId = 39,
                    Quantity= "2 pliculete"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 7,
                    IngredientId = 17,
                    Quantity= "O lingurita"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 7,
                    IngredientId = 16,
                    Quantity= "8 Linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 7,
                    IngredientId = 38,
                    Quantity= "10 Linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 7,
                    IngredientId = 37,
                    Quantity= "50 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 7,
                    IngredientId = 27,
                    Quantity= "6 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 7,
                    IngredientId = 9,
                    Quantity= "1 kg"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 7,
                    IngredientId = 14,
                    Quantity= "Un"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 8,
                    IngredientId = 52,
                    Quantity= "6 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 8,
                    IngredientId = 53,
                    Quantity= "1 kg"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 8,
                    IngredientId = 54,
                    Quantity= "200 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 8,
                    IngredientId = 55,
                    Quantity= "1 L"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 8,
                    IngredientId = 2,
                    Quantity= "2-3 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 8,
                    IngredientId = 23,
                    Quantity= "2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 8,
                    IngredientId = 45,
                    Quantity= "1-2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 8,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 8,
                    IngredientId = 18,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 8,
                    IngredientId = 19,
                    Quantity= "o lingurita"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 8,
                    IngredientId = 21,
                    Quantity= "o legatura"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 9,
                    IngredientId = 89,
                    Quantity= "400 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 9,
                    IngredientId = 52,
                    Quantity= "6 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 9,
                    IngredientId = 54,
                    Quantity= "300 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 9,
                    IngredientId = 56,
                    Quantity= "300 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 9,
                    IngredientId = 2,
                    Quantity= "3- 4 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 9,
                    IngredientId = 8,
                    Quantity= "2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 9,
                    IngredientId = 45,
                    Quantity= "2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 9,
                    IngredientId = 10,
                    Quantity= "400 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 9,
                    IngredientId = 16,
                    Quantity= "3-4 linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 9,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 9,
                    IngredientId = 18,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 9,
                    IngredientId = 57,
                    Quantity= "O legatura"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 9,
                    IngredientId = 34,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 10,
                    IngredientId = 62,
                    Quantity= "8"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 10,
                    IngredientId = 63,
                    Quantity= "50 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 10,
                    IngredientId = 27,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 10,
                    IngredientId = 41,
                    Quantity= "250 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 10,
                    IngredientId = 47,
                    Quantity= "2 fiole"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 10,
                    IngredientId = 39,
                    Quantity= "1 plic"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 10,
                    IngredientId = 38,
                    Quantity= "50 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 10,
                    IngredientId = 64,
                    Quantity= "50 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 10,
                    IngredientId = 14,
                    Quantity= "4 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 10,
                    IngredientId = 15,
                    Quantity= "200 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 10,
                    IngredientId = 38,
                    Quantity= "175 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 10,
                    IngredientId = 39,
                    Quantity= "1 plic"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 10,
                    IngredientId = 65,
                    Quantity= "4 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 10,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 11,
                    IngredientId = 1,
                    Quantity= "300 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 11,
                    IngredientId = 52,
                    Quantity= "4 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 11,
                    IngredientId = 66,
                    Quantity= "1-2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 11,
                    IngredientId = 2,
                    Quantity= "Un"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 11,
                    IngredientId = 45,
                    Quantity= "1-2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 11,
                    IngredientId = 10,
                    Quantity= "500 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 11,
                    IngredientId = 20,
                    Quantity= "O lingurita"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 11,
                    IngredientId = 67,
                    Quantity= "300 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 11,
                    IngredientId = 21,
                    Quantity= "O legatura"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 11,
                    IngredientId = 16,
                    Quantity= "O lingurita"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 12,
                    IngredientId = 8,
                    Quantity= "600 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 12,
                    IngredientId = 68,
                    Quantity= "100 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 12,
                    IngredientId = 49,
                    Quantity= "100 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 12,
                    IngredientId = 16,
                    Quantity= "150 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 12,
                    IngredientId = 72,
                    Quantity= "100 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 12,
                    IngredientId = 9,
                    Quantity= "20 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 12,
                    IngredientId = 38,
                    Quantity= "10g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 12,
                    IngredientId = 70,
                    Quantity= "25 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 12,
                    IngredientId = 21,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 12,
                    IngredientId = 33,
                    Quantity= "100 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 12,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 12,
                    IngredientId = 18,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 12,
                    IngredientId = 71,
                    Quantity= "Putin"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 13,
                    IngredientId = 52,
                    Quantity= "4 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 13,
                    IngredientId = 27,
                    Quantity= "Doua bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 13,
                    IngredientId = 9,
                    Quantity= "200 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 13,
                    IngredientId = 60,
                    Quantity= "50 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 13,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 13,
                    IngredientId = 16,
                    Quantity= "O lingura"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 13,
                    IngredientId = 63,
                    Quantity= "40 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 13,
                    IngredientId = 73,
                    Quantity= "150 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 13,
                    IngredientId = 38,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 13,
                    IngredientId = 82,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 13,
                    IngredientId = 74,
                    Quantity= "11-12"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 14,
                    IngredientId = 75,
                    Quantity= "Un"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 14,
                    IngredientId = 2,
                    Quantity= "6 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 14,
                    IngredientId = 3,
                    Quantity= "1 radacina"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 14,
                    IngredientId = 76,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 14,
                    IngredientId = 22,
                    Quantity= "O felie"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 14,
                    IngredientId = 77,
                    Quantity= "1 lingurita"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 14,
                    IngredientId = 8,
                    Quantity= "1 bucata"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 14,
                    IngredientId = 14,
                    Quantity= "4 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 14,
                    IngredientId = 9,
                    Quantity= "O lingura"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 14,
                    IngredientId = 15,
                    Quantity= "400 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 14,
                    IngredientId = 24,
                    Quantity= "O capatana"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 14,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 15,
                    IngredientId = 75,
                    Quantity= "500 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 15,
                    IngredientId = 8,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 15,
                    IngredientId = 2,
                    Quantity= "2-3 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 15,
                    IngredientId = 22,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 15,
                    IngredientId = 78,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 15,
                    IngredientId = 80,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 15,
                    IngredientId = 79,
                    Quantity= "Cateva buchete de"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 15,
                    IngredientId = 52,
                    Quantity= "2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 15,
                    IngredientId = 23,
                    Quantity= "O legatura"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 15,
                    IngredientId = 45,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 15,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 15,
                    IngredientId = 18,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 15,
                    IngredientId = 16,
                    Quantity= "1-2 linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 15,
                    IngredientId = 55,
                    Quantity= "500 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 16,
                    IngredientId = 9,
                    Quantity= "600 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 16,
                    IngredientId = 38,
                    Quantity= "160 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 16,
                    IngredientId = 14,
                    Quantity= "3 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 16,
                    IngredientId = 37,
                    Quantity= "20 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 16,
                    IngredientId = 50,
                    Quantity= "Putina"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 16,
                    IngredientId = 63,
                    Quantity= "60 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 16,
                    IngredientId = 17,
                    Quantity= "1/2 lingurita"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 16,
                    IngredientId = 13,
                    Quantity= "300 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 16,
                    IngredientId = 81,
                    Quantity= "O ceasca"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 16,
                    IngredientId = 29,
                    Quantity= "300 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 16,
                    IngredientId = 47,
                    Quantity= "1/2 lingurita"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 16,
                    IngredientId = 51,
                    Quantity= "O felie"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 16,
                    IngredientId = 82,
                    Quantity= "Un bat"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 16,
                    IngredientId = 49,
                    Quantity= "250 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 17,
                    IngredientId = 83,
                    Quantity= "1 kg"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 17,
                    IngredientId = 63,
                    Quantity= "350 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 17,
                    IngredientId = 33,
                    Quantity= "2 L"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 17,
                    IngredientId = 27,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 17,
                    IngredientId = 42,
                    Quantity= "600 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 17,
                    IngredientId = 84,
                    Quantity= "250 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 17,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 18,
                    IngredientId = 83,
                    Quantity= "250 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 18,
                    IngredientId = 13,
                    Quantity= "1 L"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 18,
                    IngredientId = 27,
                    Quantity= "4 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 18,
                    IngredientId = 41,
                    Quantity= "550 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 18,
                    IngredientId = 42,
                    Quantity= "100 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 18,
                    IngredientId = 33,
                    Quantity= "200 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 18,
                    IngredientId = 63,
                    Quantity= "70 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 18,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 19,
                    IngredientId = 9,
                    Quantity= "500 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 19,
                    IngredientId = 13,
                    Quantity= "200 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 19,
                    IngredientId = 27,
                    Quantity= "5 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 19,
                    IngredientId = 16,
                    Quantity= "100 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 19,
                    IngredientId = 38,
                    Quantity= "350 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 19,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 19,
                    IngredientId = 37,
                    Quantity= "25 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 19,
                    IngredientId = 41,
                    Quantity= "350 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 19,
                    IngredientId = 39,
                    Quantity= "2 plicuri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 19,
                    IngredientId = 46,
                    Quantity= "O fiola"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 19,
                    IngredientId = 60,
                    Quantity= "3 linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 20,
                    IngredientId = 86,
                    Quantity= "200 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 20,
                    IngredientId = 30,
                    Quantity= "300 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 20,
                    IngredientId = 8,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 20,
                    IngredientId = 24,
                    Quantity= "2 catei"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 20,
                    IngredientId = 52,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 20,
                    IngredientId = 85,
                    Quantity= "2 felii"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 20,
                    IngredientId = 13,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 20,
                    IngredientId = 27,
                    Quantity= "2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 20,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 20,
                    IngredientId = 18,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 20,
                    IngredientId = 57,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 20,
                    IngredientId = 21,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 20,
                    IngredientId = 73,
                    Quantity= "150 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 20,
                    IngredientId = 9,
                    Quantity= "3 linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 21,
                    IngredientId = 9,
                    Quantity= "500 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 21,
                    IngredientId = 29,
                    Quantity= "(Aluat) 200 ml, (Fiert) 2L"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 21,
                    IngredientId = 17,
                    Quantity= "1/2 lingurita"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 21,
                    IngredientId = 38,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 21,
                    IngredientId = 49,
                    Quantity= "300 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 21,
                    IngredientId = 46,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 21,
                    IngredientId = 50,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 21,
                    IngredientId = 51,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 21,
                    IngredientId = 39,
                    Quantity= "Un plic"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 21,
                    IngredientId = 82,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 22,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 22,
                    IngredientId = 27,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 22,
                    IngredientId = 26,
                    Quantity= "200 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 22,
                    IngredientId = 24,
                    Quantity= "O capatana"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 22,
                    IngredientId = 2,
                    Quantity= "4 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 22,
                    IngredientId = 8,
                    Quantity= "2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 22,
                    IngredientId = 89,
                    Quantity= "400 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 22,
                    IngredientId = 87,
                    Quantity= "1/2"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 22,
                    IngredientId = 88,
                    Quantity= "4"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 22,
                    IngredientId = 18,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 23,
                    IngredientId = 83,
                    Quantity= "300 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 23,
                    IngredientId = 90,
                    Quantity= "700 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 23,
                    IngredientId = 29,
                    Quantity= "300 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 23,
                    IngredientId = 5,
                    Quantity= "300 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 23,
                    IngredientId = 91,
                    Quantity= "200 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 23,
                    IngredientId = 43,
                    Quantity= "200 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 23,
                    IngredientId = 33,
                    Quantity= "200 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 23,
                    IngredientId = 27,
                    Quantity= "4 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 23,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 24,
                    IngredientId = 60,
                    Quantity= "150 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 24,
                    IngredientId = 41,
                    Quantity= "350 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 24,
                    IngredientId = 39,
                    Quantity= "30 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 24,
                    IngredientId = 27,
                    Quantity= "2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 24,
                    IngredientId = 50,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 24,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 24,
                    IngredientId = 73,
                    Quantity= "100 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 24,
                    IngredientId = 63,
                    Quantity= "20 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 24,
                    IngredientId = 33,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 25,
                    IngredientId = 9,
                    Quantity= "1.5 kg"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 25,
                    IngredientId = 36,
                    Quantity= "3 cubulete"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 25,
                    IngredientId = 29,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 25,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 25,
                    IngredientId = 1,
                    Quantity= "500 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 25,
                    IngredientId = 4,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 25,
                    IngredientId = 8,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 25,
                    IngredientId = 4,
                    Quantity= "2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 25,
                    IngredientId = 45,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 25,
                    IngredientId = 22,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 25,
                    IngredientId = 11,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 25,
                    IngredientId = 34,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 25,
                    IngredientId = 18,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 25,
                    IngredientId = 19,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 25,
                    IngredientId = 10,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 26,
                    IngredientId = 9,
                    Quantity= "250 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 26,
                    IngredientId = 13,
                    Quantity= "500 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 26,
                    IngredientId = 27,
                    Quantity= "3 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 26,
                    IngredientId = 92,
                    Quantity= "3 linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 26,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 26,
                    IngredientId = 16,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 26,
                    IngredientId = 18,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 26,
                    IngredientId = 93,
                    Quantity= "500 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 26,
                    IngredientId = 8,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 26,
                    IngredientId = 33,
                    Quantity= "350 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 27,
                    IngredientId = 94,
                    Quantity= "O farfurie"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 27,
                    IngredientId = 52,
                    Quantity= "2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 27,
                    IngredientId = 27,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 27,
                    IngredientId = 55,
                    Quantity= "1 L"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 27,
                    IngredientId = 33,
                    Quantity= "1 cana"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 27,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 27,
                    IngredientId = 18,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 28,
                    IngredientId = 83,
                    Quantity= "500 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 28,
                    IngredientId = 43,
                    Quantity= "200 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 28,
                    IngredientId = 5,
                    Quantity= "180 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 28,
                    IngredientId = 89,
                    Quantity= "100 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 28,
                    IngredientId = 27,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 28,
                    IngredientId = 95,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 28,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 29,
                    IngredientId = 9,
                    Quantity= "500 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 29,
                    IngredientId = 96,
                    Quantity= "350 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 29,
                    IngredientId = 13,
                    Quantity= "200 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 29,
                    IngredientId = 38,
                    Quantity= "100 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 29,
                    IngredientId = 63,
                    Quantity= "70 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 29,
                    IngredientId = 36,
                    Quantity= "20 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 29,
                    IngredientId = 14,
                    Quantity= "4 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 29,
                    IngredientId = 27,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 29,
                    IngredientId = 47,
                    Quantity= "1 lingurinta"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 29,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 29,
                    IngredientId = 50,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 30,
                    IngredientId = 8,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 30,
                    IngredientId = 78,
                    Quantity= "5-6 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 30,
                    IngredientId = 2,
                    Quantity= "1-2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 30,
                    IngredientId = 27,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 30,
                    IngredientId = 16,
                    Quantity= "100 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 30,
                    IngredientId = 9,
                    Quantity= "2 linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 30,
                    IngredientId = 28,
                    Quantity= "1.5 L"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 30,
                    IngredientId = 57,
                    Quantity= "O legatura"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 30,
                    IngredientId = 21,
                    Quantity= "O legatura"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 30,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 30,
                    IngredientId = 33,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 31,
                    IngredientId = 83,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 31,
                    IngredientId = 6,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 31,
                    IngredientId = 5,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 31,
                    IngredientId = 98,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 31,
                    IngredientId = 16,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 32,
                    IngredientId = 58,
                    Quantity= "2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 32,
                    IngredientId = 8,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 32,
                    IngredientId = 52,
                    Quantity= "4-5 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 32,
                    IngredientId = 63,
                    Quantity= "20 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 32,
                    IngredientId = 29,
                    Quantity= "1/2 L"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 32,
                    IngredientId = 13,
                    Quantity= "200 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 32,
                    IngredientId = 57,
                    Quantity= "Cateva fire"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 32,
                    IngredientId = 97,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 32,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 32,
                    IngredientId = 18,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 33,
                    IngredientId = 8,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 33,
                    IngredientId = 58,
                    Quantity= "2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 33,
                    IngredientId = 5,
                    Quantity= "200 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 33,
                    IngredientId = 35,
                    Quantity= "6 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 33,
                    IngredientId = 10,
                    Quantity= "1 lingura"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 33,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 33,
                    IngredientId = 16,
                    Quantity= "2 linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 34,
                    IngredientId = 58,
                    Quantity= "2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 34,
                    IngredientId = 2,
                    Quantity= "4 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 34,
                    IngredientId = 27,
                    Quantity= "4 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 34,
                    IngredientId = 13,
                    Quantity= "200 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 34,
                    IngredientId = 43,
                    Quantity= "100 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 34,
                    IngredientId = 16,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 34,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 34,
                    IngredientId = 18,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 35,
                    IngredientId = 75,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 35,
                    IngredientId = 35,
                    Quantity= "5"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 35,
                    IngredientId = 45,
                    Quantity= "3 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 35,
                    IngredientId = 99,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 35,
                    IngredientId = 24,
                    Quantity= "5 catei"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 35,
                    IngredientId = 77,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 35,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 35,
                    IngredientId = 21,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 35,
                    IngredientId = 11,
                    Quantity= "Un praf"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 36,
                    IngredientId = 83,
                    Quantity= "750 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 36,
                    IngredientId = 9,
                    Quantity= "250 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 36,
                    IngredientId = 29,
                    Quantity= "2 L"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 36,
                    IngredientId = 17,
                    Quantity= "2 lingurite"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 37,
                    IngredientId = 89,
                    Quantity= "1 kg"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 37,
                    IngredientId = 16,
                    Quantity= "50 ml"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 37,
                    IngredientId = 7,
                    Quantity= "2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 37,
                    IngredientId = 77,
                    Quantity= "15"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 37,
                    IngredientId = 29,
                    Quantity= "2 cani"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 37,
                    IngredientId = 69,
                    Quantity= "1 pahar"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 37,
                    IngredientId = 10,
                    Quantity= "3 linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 37,
                    IngredientId = 24,
                    Quantity= "1 capatana"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 37,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 37,
                    IngredientId = 18,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 37,
                    IngredientId = 20,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 38,
                    IngredientId = 9,
                    Quantity= "1 kg"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 38,
                    IngredientId = 36,
                    Quantity= "1 cub"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 38,
                    IngredientId = 38,
                    Quantity= "1 lingurita"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 38,
                    IngredientId = 12,
                    Quantity= "2 linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 38,
                    IngredientId = 16,
                    Quantity= "2 linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 38,
                    IngredientId = 29,
                    Quantity= "1 cana"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 38,
                    IngredientId = 17,
                    Quantity= "2-3 lingurite"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 38,
                    IngredientId = 27,
                    Quantity= "3 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 38,
                    IngredientId = 39,
                    Quantity= "2 pliculete"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 38,
                    IngredientId = 38,
                    Quantity= "O cana"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 38,
                    IngredientId = 40,
                    Quantity= "1 kg"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 38,
                    IngredientId = 50,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 39,
                    IngredientId = 21,
                    Quantity= "Cateva fire"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 39,
                    IngredientId = 16,
                    Quantity= "2 linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 39,
                    IngredientId = 45,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 39,
                    IngredientId = 8,
                    Quantity= "2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 39,
                    IngredientId = 70,
                    Quantity= "2 linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 39,
                    IngredientId = 35,
                    Quantity= "1 kg"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 39,
                    IngredientId = 100,
                    Quantity= "3-4 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 39,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 40,
                    IngredientId = 101,
                    Quantity= "4 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 40,
                    IngredientId = 99,
                    Quantity= "O bucata"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 40,
                    IngredientId = 35,
                    Quantity= "4"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 40,
                    IngredientId = 57,
                    Quantity= "o legatura"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 40,
                    IngredientId = 24,
                    Quantity= "2 catei"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 40,
                    IngredientId = 77,
                    Quantity= "10"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 40,
                    IngredientId = 7,
                    Quantity= "2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 40,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 41,
                    IngredientId = 102,
                    Quantity= "2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 41,
                    IngredientId = 2,
                    Quantity= "2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 41,
                    IngredientId = 76,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 41,
                    IngredientId = 45,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 41,
                    IngredientId = 35,
                    Quantity= "2"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 41,
                    IngredientId = 55,
                    Quantity= "1 L"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 41,
                    IngredientId = 21,
                    Quantity= "O legatura"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 41,
                    IngredientId = 17,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 41,
                    IngredientId = 18,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 42,
                    IngredientId = 9,
                    Quantity= "1 kg"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 42,
                    IngredientId = 17,
                    Quantity= "1 lingurita"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 42,
                    IngredientId = 16,
                    Quantity= "1 ceasca"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 42,
                    IngredientId = 37,
                    Quantity= "50 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 42,
                    IngredientId = 41,
                    Quantity= "1 kg"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 42,
                    IngredientId = 40,
                    Quantity= "400 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 42,
                    IngredientId = 33,
                    Quantity= "400 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 42,
                    IngredientId = 23,
                    Quantity= "3 legaturi"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 42,
                    IngredientId = 57,
                    Quantity= "3 legaturi"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 42,
                    IngredientId = 90,
                    Quantity= "400 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 42,
                    IngredientId = 27,
                    Quantity= "3-4 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 43,
                    IngredientId = 9,
                    Quantity= "100 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 43,
                    IngredientId = 91,
                    Quantity= "300 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 43,
                    IngredientId = 92,
                    Quantity= "1 pahar"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 43,
                    IngredientId = 13,
                    Quantity= "O cana"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 43,
                    IngredientId = 27,
                    Quantity= "3 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 43,
                    IngredientId = 23,
                    Quantity= "O legatura"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 43,
                    IngredientId = 94,
                    Quantity= "O legatura"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 43,
                    IngredientId = 57,
                    Quantity= "1/2 legatura"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 43,
                    IngredientId = 33,
                    Quantity= "1 ceasca"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 43,
                    IngredientId = 63,
                    Quantity= "4 linguri"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 44,
                    IngredientId = 9,
                    Quantity= "400 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 44,
                    IngredientId = 63,
                    Quantity= "250 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 44,
                    IngredientId = 2,
                    Quantity= "200 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 44,
                    IngredientId = 22,
                    Quantity= "150 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 44,
                    IngredientId = 52,
                    Quantity= "150 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 44,
                    IngredientId = 12,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 45,
                    IngredientId = 103,
                    Quantity= "400 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 45,
                    IngredientId = 104,
                    Quantity= "250 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 45,
                    IngredientId = 8,
                    Quantity= "2 bucati"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 45,
                    IngredientId = 23,
                    Quantity= "1"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 45,
                    IngredientId = 24,
                    Quantity= "1-2 catei"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 45,
                    IngredientId = 52,
                    Quantity= "200 g"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 45,
                    IngredientId = 21,
                    Quantity= "2 legaturi"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 45,
                    IngredientId = 63,
                    Quantity= "Jumatate pachet"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 45,
                    IngredientId = 33,
                    Quantity= "Un pahar"
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 45,
                    IngredientId = 105,
                    Quantity= ""
                },
                new RecipeIngredient
                {
                    Id = nextId(),
                    RecipeId = 45,
                    IngredientId = 28,
                    Quantity= ""
                }
            };
        }

        private IngredientDetails[] GetSeedIngredientDetails()
        {
            int id = 1;
            int nextId() => id++;

            return new[]
            {
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Fasole alba boabe",
                    Kcal = 132
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Morcov",
                    Kcal = 41.3
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Pastarnac",
                    Kcal = 72
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Ciolan Afumat",
                    Kcal = 337
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Carnat Afumat",
                    Kcal = 301
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Costita Afumata",
                    Kcal = 237.6
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Foaie Dafin",
                    Kcal = 0
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Ceapa alba",
                    Kcal = 40
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Faina",
                    Kcal = 364
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Suc de rosii",
                    Kcal = 17.4
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Tarhon",
                    Kcal = 295
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Otet",
                    Kcal = 0
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Lapte cald",
                    Kcal = 50
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Galbenus",
                    Kcal = 55
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Smantana de gatit",
                    Kcal = 216
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Ulei",
                    Kcal = 840
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Sare",
                    Kcal = 0
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Piper",
                    Kcal = 0
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Boia de ardei dulce",
                    Kcal = 0
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Boia de ardei iute",
                    Kcal = 0
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Patrunjel",
                    Kcal = 0
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Telina",
                    Kcal = 16
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Ceapa verde",
                    Kcal = 32.3
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Usturoi",
                    Kcal = 149
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Orez",
                    Kcal = 260
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Mazare",
                    Kcal = 84
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Ou",
                    Kcal = 155
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Supa de legume",
                    Kcal = 13.4
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Apa",
                    Kcal = 0
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Carne tocata porc",
                    Kcal = 566
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Varza Murata",
                    Kcal = 18.6
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Ulei de masline",
                    Kcal = 884
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Smantana",
                    Kcal = 195.5
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Cimbru",
                    Kcal = 0
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Rosie",
                    Kcal = 18
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Drojdie Proaspata",
                    Kcal = 105
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Drojdie Uscata",
                    Kcal = 295
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Zahar",
                    Kcal =  386
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Zahar Vanilat",
                    Kcal = 398
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Branza Sarata",
                    Kcal = 273
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Branza de vaci",
                    Kcal = 200
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Branza de oaie",
                    Kcal = 283
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Branza Telemea",
                    Kcal = 273
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Burta de vita",
                    Kcal = 168
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Ardei gras",
                    Kcal = 20.1
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Esenta de rom",
                    Kcal = 231
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Esenta de vanilie",
                    Kcal = 288
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Cacao",
                    Kcal = 229
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Nuca",
                    Kcal = 654
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Coaja de lamaie",
                    Kcal = 47.1
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Coaja de portocala",
                    Kcal = 97
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Cartof",
                    Kcal = 87
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Rasol de vitel",
                    Kcal = 132
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Fasole verde",
                    Kcal = 30.8
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Bors",
                    Kcal = 0
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Fasole Rosie Boabe",
                    Kcal = 332.9
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Marar",
                    Kcal = 0
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Praz",
                    Kcal = 60.9
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Slanina",
                    Kcal = 538
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Gris",
                    Kcal = 359.9
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Carne de miel",
                    Kcal = 294
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Clatite",
                    Kcal = 121
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Unt",
                    Kcal = 716.8
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Stafide",
                    Kcal = 299.2
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Albus",
                    Kcal = 51.6
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Ceapa rosie",
                    Kcal = 39
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Carnat iute",
                    Kcal = 203.4
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Masline",
                    Kcal = 115
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Vin Rosu",
                    Kcal = 85.1
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Bulion",
                    Kcal = 267
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Vin Alb",
                    Kcal = 81.7
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Paine inmuiata in lapte",
                    Kcal = 365
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Pesmet",
                    Kcal = 395.1
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Prune",
                    Kcal = 240.4
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Pui",
                    Kcal = 239
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Radacina de patrunjel",
                    Kcal = 29
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Boabe de piper",
                    Kcal = 0
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Gulie",
                    Kcal = 27
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Conopida",
                    Kcal = 24.9
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Dovlecel",
                    Kcal = 12
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Miere",
                    Kcal = 304
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Scortisoara",
                    Kcal = 0
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Malai",
                    Kcal = 369.7
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Cas",
                    Kcal = 254
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Paine",
                    Kcal = 264.6
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Carne tocata vita",
                    Kcal = 245
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Cap de porc",
                    Kcal = 0
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Picioare de porc",
                    Kcal = 232
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Carne de porc",
                    Kcal = 242.1
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Iaurt",
                    Kcal = 58.8
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Urda",
                    Kcal = 136
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Apa Carbogazificata",
                    Kcal = 0
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Ciuperci",
                    Kcal = 22.2
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Leurda",
                    Kcal = 0
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Jumari",
                    Kcal = 638
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Magiun",
                    Kcal = 276
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Nucsoara",
                    Kcal = 0
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Caltabos Afumat",
                    Kcal = 307
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Ardei iute",
                    Kcal = 39.7
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Peste (la alegere)",
                    Kcal = 0
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Medalion Crap",
                    Kcal = 127
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Macrou",
                    Kcal = 260
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Porumb",
                    Kcal = 377
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Cascaval",
                    Kcal = 283
                },
                new IngredientDetails
                {
                    Id = nextId(),
                    Name = "Chimen",
                    Kcal = 0
                },

            };
        }
        
        private Region[] GetSeedRegions()
        {
            int id = 1;
            int nextId() => id++;

            return new[]
            {
                new Region
                {
                    Id = nextId(),
                    Name = "Transilvania",
                    CulinaryHistory = "In Transilvania, Banat si Crisana, influenta germana se face simtita prin varietatea de carnati si mezeluri, cum ar fi virsli sau casul de cap de porc, dar și în consumul de ciorbe groase și varza. Branza de burduf este una dintre specialitatile acestei regiuni, la fel ca si casul de Nasal, o alta branza, maturata intr-o pestera din Taga, Cluj. Influentele bucatariilor maghiare si sarbe sunt si ele simtite prin prezenta cozonacului secuiesc, gulasului sau a multor bauturi tari precum palinca, horinca si slibovita."
                },
                new Region
                {
                    Id = nextId(),
                    Name = "Banat",
                    CulinaryHistory = "In Transilvania, Banat si Crisana, influenta germana se face simtita prin varietatea de carnati si mezeluri, cum ar fi virsli sau casul de cap de porc, dar și în consumul de ciorbe groase și varza. Branza de burduf este una dintre specialitatile acestei regiuni, la fel ca si casul de Nasal, o alta branza, maturata intr-o pestera din Taga, Cluj. Influentele bucatariilor maghiare si sarbe sunt si ele simtite prin prezenta cozonacului secuiesc, gulasului sau a multor bauturi tari precum palinca, horinca si slibovita."
                },
                new Region
                {
                    Id = nextId(),
                    Name = "Crisana",
                    CulinaryHistory = "In Transilvania, Banat si Crisana, influenta germana se face simtita prin varietatea de carnati si mezeluri, cum ar fi virsli sau casul de cap de porc, dar și în consumul de ciorbe groase și varza. Branza de burduf este una dintre specialitatile acestei regiuni, la fel ca si casul de Nasal, o alta branza, maturata intr-o pestera din Taga, Cluj. Influentele bucatariilor maghiare si sarbe sunt si ele simtite prin prezenta cozonacului secuiesc, gulasului sau a multor bauturi tari precum palinca, horinca si slibovita."
                },
                new Region
                {
                    Id = nextId(),
                    Name = "Muntenia",
                    CulinaryHistory = "Oltenia si Muntenia sunt cele doua provincii care au format in trecut Tara Romaneasca, vecina cu Bulgaria, Transilvania și Dobrogea. Cele doua regiuni au o lunga istorie de productie a vinului, cu trei regiuni mari viticole impartite in 13 mari podgorii. Din aceste regiuni provin mancaruri precum ostropelul, ciorba de burta, tuslamaua si ciorba de potroace. Oltenia este renumita pentru carnatii sai. Din Muntenia provin covrigii din Buzau, babicul, carnații de Plescoi, magiunul de Topoloveni si Salamul de Sibiu (originar, de fapt, din Sinaia)."
                },
                new Region
                {
                    Id = nextId(),
                    Name = "Oltenia",
                    CulinaryHistory = "Oltenia si Muntenia sunt cele doua provincii care au format in trecut Tara Romaneasca, vecina cu Bulgaria, Transilvania și Dobrogea. Cele doua regiuni au o lunga istorie de productie a vinului, cu trei regiuni mari viticole impartite in 13 mari podgorii. Din aceste regiuni provin mancaruri precum ostropelul, ciorba de burta, tuslamaua si ciorba de potroace. Oltenia este renumita pentru carnatii sai. Din Muntenia provin covrigii din Buzau, babicul, carnații de Plescoi, magiunul de Topoloveni si Salamul de Sibiu (originar, de fapt, din Sinaia)."
                },
                new Region
                {
                    Id = nextId(),
                    Name = "Dobrogea",
                    CulinaryHistory = "Diversitatea etnica a Dobrogei ofera regiunii un caracter diferit de Muntenia vecina, bucataria regionala incorporand elementele aduse de turcii, tatarii, grecii, aromanii si lipovenii din regiune. Din judetul Tulcea unde se afla Delta Dunarii, bogata in specii de pesti, provin specialitati precum borșul de pește lipovenesc, storceagul sau saramura de sturion. În județul Constanța se produce vinul Murfatlar din Regiunea Viticolă a Colinelor Dobrogei. Datorită influenței orientale, sunt comune deserturile precum baclavaua, halvaua și sarailiile, mâncăruri precum șuberecul umplut cu carne prăjită cu ceapă, și mezeluri precum ghiudemul și sugiucul. Dobrogea a fost istoric străbătută de păstori, produsele din carne de oaie fiind comune, mai ales în rețetele împrumutate din bucătăriile orientale sau din bucătăria aromână, cât și în rețete autohtone, precum cea de pastramă."
                },
                new Region
                {
                    Id = nextId(),
                    Name = "Moldova",
                    CulinaryHistory = "Moldova occidentală, Bucovina, Republica Moldova și Bugeacul au format cândva Moldova istorică, a cărei bucătării a fost influențată de cea poloneză, austriacă, rusă și ucraineană. Bucătăria moldovenească este un amestec de arome acide și texturi cremoase, cu o mai abundentă utilizare a verzei, a cartofilor și a cepei. Printre specialitățile locale se numără ciulamaua și tochitura moldovenească. În aceste regiuni, sarmalele se prepară și cu frunze de viță de vie. Pârjoalele moldovenești sunt chifteluțe tocate la grătar, cu usturoi și ierburi aromatice."
                },
                new Region
                {
                    Id = nextId(),
                    Name = "Bucovina",
                    CulinaryHistory = "Moldova occidentală, Bucovina, Republica Moldova și Bugeacul au format cândva Moldova istorică, a cărei bucătării a fost influențată de cea poloneză, austriacă, rusă și ucraineană. Bucătăria moldovenească este un amestec de arome acide și texturi cremoase, cu o mai abundentă utilizare a verzei, a cartofilor și a cepei. Printre specialitățile locale se numără ciulamaua și tochitura moldovenească. În aceste regiuni, sarmalele se prepară și cu frunze de viță de vie. Pârjoalele moldovenești sunt chifteluțe tocate la grătar, cu usturoi și ierburi aromatice."
                },
                new Region
                {
                    Id = nextId(),
                    Name = "Maramures",
                    CulinaryHistory = "Bucătăria maramureșeană tradițională poate fi considerată o bucătărie rustică pastorală, relativ simplă, care folosește un număr mic de ingrediente de bază (lapte de oaie, caș, urdă, jintiță, mălai, carne de porc sau de oaie, jumări, ouă, cartofi, varză, miere și prune) și care impresionează mai ales prin calitatea produselor finale.\r\nUn rol foarte important în bucătăria locală îl au prunele, folosite proaspete în rețete precum cea de gomboți cu prune, dar mai adesea conservate prin fierbere sau uscare. Din acestea se face horinca, versiunea locală a pălincii, băutură alcoolică dublu distilată, cu o tărie de 50–55%, uneori îndulcită cu miere de albine. Conserva consacrată de prune este magiunul, consumată cu mămăligă sau inclusă în prăjituri precum cornulețele, găluștele de aur sau porloșele. La fel ca în restul Ardealului, prunele uscate se folosesc în supe dulci sau sărate, sosuri pentru fripturi, tocănițe, mâncăruri de orez și în prăjituri."
                }
            };
        }
    }
}
