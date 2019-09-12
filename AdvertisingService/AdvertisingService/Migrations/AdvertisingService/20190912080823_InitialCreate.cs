using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvertisingService.Migrations.AdvertisingService
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdvertisingCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertisingCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Advertisings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdvertisingName = table.Column<string>(nullable: false),
                    Text = table.Column<string>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    ItemPrice = table.Column<string>(nullable: true),
                    AdvertisingCategoryId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AdvertisingCategories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Недвижимость" },
                    { 2, "Авто и транспорт" },
                    { 3, "Техника" },
                    { 4, "Мода и стиль" },
                    { 5, "Всё для дома" },
                    { 6, "Ремонт и стройка" },
                    { 7, "Сад и огород" },
                    { 8, "Хобби, спорт и туризм" }
                });

            migrationBuilder.InsertData(
                table: "Advertisings",
                columns: new[] { "Id", "AdvertisingCategoryId", "AdvertisingName", "ImagePath", "ItemPrice", "Text", "UserId" },
                values: new object[,]
                {
                    { 14, 7, "Дрова", "https://content.kufar.by/gallery/41/4126985343.jpg", "Договорная", "Дрова ель-сосна, береза-осина, дуб, можно смешанные,Колотые и чурками с доставкой 5 кубов (навал в кузове 6,5кубов). +472836576564", null },
                    { 13, 7, "Корзина", "https://content.kufar.by/gallery/34/3461009376.jpg", "15 р.", "Отличная корзина для сбора урожая, лёгкая, удобная. +758345783465", null },
                    { 12, 6, "Продам краску", "https://aura.if.ua/image/cache/catalog/tovary/kraski/tovar/chast1/luxpro9tr-500x500.jpg", "120", "Продам краску, цвет не того тона +4623756237564", null },
                    { 11, 6, "Цемент М-400", "https://angio.com.ua/files/angio/reg_images/m-400_2.jpg", "12 р.", "После ремонта осталось 3 мешка 25 кг +425673542734", null },
                    { 10, 5, "Диван-кровать", "https://www.ikea.com/ru/ru/images/products/gessberg-divan-krovat-mestnyj-bezevyj__0532403_PE648047_S4.JPG", "150 р.", "Продам новый диван-кровать, так как не подошел по размерам, а возможности вернуть нет +124534645745", null },
                    { 9, 5, "Ванильная орхидея (ваниль)", "http://cvetochki.net/sites/default/files/u736/orh1.jpg", "15 р.", "Ее нежные цветочки могут быть окрашены в желтый, белоснежный либо светло-зеленый цвет. +71382946127", null },
                    { 8, 4, "Серебряное кольцо с живописью", "https://i.pinimg.com/originals/b3/4d/d2/b34dd21927a6652f77bba24be7b66931.jpg", "Договорная", "Серебряное кольцо с живописью, собственного производства +473289472394", null },
                    { 4, 2, "Прицеп бортовой легковой ССT 7132-08", "http://images.slanet.by/~src8356904/Pricep_bortovoj_legkovoj_SST-7132-08_K.jpg", "1750 р.", "Прицеп новый. Полностью оцинкованный кузов.Подвеска рессоры+амортизаторы. Обращаться +12345678945", null },
                    { 6, 3, "Наушники Plantronics RIG 600", "https://img.mvideo.ru/Pdb/50049239b.jpg", "140 р.", "Звук отличный, микрофон съемный на 5, уши не устают, легкие, провод длинный. Стоит отметить отличное качество материалов, емкое звучание и шумоизоляцию. +4638764862934", null },
                    { 5, 3, "Смартфон Redmi Note 7 3/32", "https://img.letgo.com/images/9e/6a/f4/7b/9e6af47b14f096302b59d17826a094be.jpeg?impolicy=img_600", "430 р.", "Продаю за ненадобностью, так как подвернулся телефон получше, а сам телефон без царапин, использовался недолго звонить +127498236598", null },
                    { 15, 8, "Серия книг « Песнь льда и пламени»", "https://content.kufar.by/gallery/34/3430032145.jpg", "70 р.", "Набор из четырех книг в отличном состоянии. +47287365723", null },
                    { 3, 2, "Колпаки R15 Opel", "https://images.by.prom.st/144841415_w640_h640_kolpak-kolesnyj-r15.jpg", "60", "Продам набор колпаков 4 шт. +1234567890978", null },
                    { 2, 1, "Продам гараж", "https://garage.abw.by/assets/gallery_thumbnails/c9/c91d8e781c2e514dc7c747f9c6cee4d5.jpg", "5000 р.", "Продам гараж, ул. Терёхина, по вопросам звонить +1234567890978", null },
                    { 1, 1, "Сдам квартиру 1 комнатную", "https://www.pufikhomes.com/wp-content/uploads/2018/11/smart-small-white-apartment-in-sweden-32sqm-pufikhomes-1.jpg", "Договорная", "Сдам 1 комнатную квартиру 100м2 на длительный срок, за подробностями обращаться по телефону +12345678945", null },
                    { 7, 4, "Часы мужские Tissot S9009", "https://images.by.prom.st/108330101_chasy-muzhskie-tissot.jpg", "Договорная", "Продам срочно +823692863596", null },
                    { 16, 8, "Нож Ganzo Firebird FH21", "https://content.kufar.by/gallery/38/3833302936.jpg", "80 р.", "Сталь D2 (твердость 60 ед HRC) флиппер на подшипниках,рукоять из G10 +47236482634623", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvertisingCategories");

            migrationBuilder.DropTable(
                name: "Advertisings");
        }
    }
}
