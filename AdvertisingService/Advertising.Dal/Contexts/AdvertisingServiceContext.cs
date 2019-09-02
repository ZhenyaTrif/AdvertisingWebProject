using Common.Entity;
using Microsoft.EntityFrameworkCore;

namespace Advertising.Dal.Contexts
{
    public class AdvertisingServiceContext : DbContext
    {
        public AdvertisingServiceContext(DbContextOptions<AdvertisingServiceContext> options)
            : base(options)
        {
            
        }

        public DbSet<AdvertisingModel> Advertisings { get; set; }

        public DbSet<AdvertisingCategory> AdvertisingCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdvertisingCategory>().HasData(
                new AdvertisingCategory[]
                {
                new AdvertisingCategory { Id=1, CategoryName="Недвижимость"},
                new AdvertisingCategory { Id=2, CategoryName="Авто и транспорт"},
                new AdvertisingCategory { Id=3, CategoryName="Техника"},
                new AdvertisingCategory { Id=4, CategoryName="Мода и стиль"},
                new AdvertisingCategory { Id=5, CategoryName="Всё для дома"},
                new AdvertisingCategory { Id=6, CategoryName="Ремонт и стройка"},
                new AdvertisingCategory { Id=7, CategoryName="Сад и огород"},
                new AdvertisingCategory { Id=8, CategoryName="Хобби, спорт и туризм"}
                });
            modelBuilder.Entity<AdvertisingModel>().HasData(
                new AdvertisingModel[]
                {
                new AdvertisingModel { Id=1, AdvertisingName="Сдам квартиру 1 комнатную", Text="Сдам 1 комнатную квартиру 100м2 на длительный срок, за подробностями обращаться по телефону +12345678945",
                    ImagePath ="https://www.pufikhomes.com/wp-content/uploads/2018/11/smart-small-white-apartment-in-sweden-32sqm-pufikhomes-1.jpg", ItemPrice="Договорная", AdvertisingCategoryId=1},
                new AdvertisingModel { Id=2, AdvertisingName="Продам гараж", Text="Продам гараж, ул. Терёхина, по вопросам звонить +1234567890978",
                    ImagePath ="https://garage.abw.by/assets/gallery_thumbnails/c9/c91d8e781c2e514dc7c747f9c6cee4d5.jpg", ItemPrice="5000 р.", AdvertisingCategoryId=1},
                new AdvertisingModel { Id=3, AdvertisingName="Колпаки R15 Opel", Text="Продам набор колпаков 4 шт. +1234567890978",
                    ImagePath ="https://images.by.prom.st/144841415_w640_h640_kolpak-kolesnyj-r15.jpg", ItemPrice="60", AdvertisingCategoryId=2},
                new AdvertisingModel { Id=4, AdvertisingName="Прицеп бортовой легковой ССT 7132-08", Text="Прицеп новый. Полностью оцинкованный кузов.Подвеска рессоры+амортизаторы. Обращаться +12345678945",
                    ImagePath ="http://images.slanet.by/~src8356904/Pricep_bortovoj_legkovoj_SST-7132-08_K.jpg", ItemPrice="1750 р.", AdvertisingCategoryId=2},
                new AdvertisingModel { Id=5, AdvertisingName="Смартфон Redmi Note 7 3/32", Text="Продаю за ненадобностью, так как подвернулся телефон получше, а сам телефон без царапин, использовался недолго звонить +127498236598",
                    ImagePath ="https://img.letgo.com/images/9e/6a/f4/7b/9e6af47b14f096302b59d17826a094be.jpeg?impolicy=img_600", ItemPrice="430 р.", AdvertisingCategoryId=3},
                new AdvertisingModel { Id=6, AdvertisingName="Наушники Plantronics RIG 600", Text="Звук отличный, микрофон съемный на 5, уши не устают, легкие, провод длинный. Стоит отметить отличное качество материалов, емкое звучание и шумоизоляцию. +4638764862934",
                    ImagePath ="https://img.mvideo.ru/Pdb/50049239b.jpg", ItemPrice="140 р.", AdvertisingCategoryId=3},
                new AdvertisingModel { Id=7, AdvertisingName="Часы мужские Tissot S9009", Text="Продам срочно +823692863596",
                    ImagePath ="https://images.by.prom.st/108330101_chasy-muzhskie-tissot.jpg", ItemPrice="Договорная", AdvertisingCategoryId=4},
                new AdvertisingModel { Id=8, AdvertisingName="Серебряное кольцо с живописью", Text="Серебряное кольцо с живописью, собственного производства +473289472394",
                    ImagePath ="https://i.pinimg.com/originals/b3/4d/d2/b34dd21927a6652f77bba24be7b66931.jpg", ItemPrice="Договорная", AdvertisingCategoryId=4},
                new AdvertisingModel { Id=9, AdvertisingName="Ванильная орхидея (ваниль)", Text="Ее нежные цветочки могут быть окрашены в желтый, белоснежный либо светло-зеленый цвет. +71382946127",
                    ImagePath ="http://cvetochki.net/sites/default/files/u736/orh1.jpg", ItemPrice="15 р.", AdvertisingCategoryId=5},
                new AdvertisingModel { Id=10, AdvertisingName="Диван-кровать", Text="Продам новый диван-кровать, так как не подошел по размерам, а возможности вернуть нет +124534645745",
                    ImagePath ="https://www.ikea.com/ru/ru/images/products/gessberg-divan-krovat-mestnyj-bezevyj__0532403_PE648047_S4.JPG", ItemPrice="150 р.", AdvertisingCategoryId=5},
                new AdvertisingModel { Id=11, AdvertisingName="Цемент М-400", Text="После ремонта осталось 3 мешка 25 кг +425673542734",
                    ImagePath ="https://angio.com.ua/files/angio/reg_images/m-400_2.jpg", ItemPrice="12 р.", AdvertisingCategoryId=6},
                new AdvertisingModel { Id=12, AdvertisingName="Продам краску", Text="Продам краску, цвет не того тона +4623756237564",
                    ImagePath ="https://aura.if.ua/image/cache/catalog/tovary/kraski/tovar/chast1/luxpro9tr-500x500.jpg", ItemPrice="120", AdvertisingCategoryId=6},
                new AdvertisingModel { Id=13, AdvertisingName="Корзина", Text="Отличная корзина для сбора урожая, лёгкая, удобная. +758345783465",
                    ImagePath ="https://content.kufar.by/gallery/34/3461009376.jpg", ItemPrice="15 р.", AdvertisingCategoryId=7},
                new AdvertisingModel { Id=14, AdvertisingName="Дрова", Text="Дрова ель-сосна, береза-осина, дуб, можно смешанные,Колотые и чурками с доставкой 5 кубов (навал в кузове 6,5кубов). +472836576564",
                    ImagePath ="https://content.kufar.by/gallery/41/4126985343.jpg", ItemPrice="Договорная", AdvertisingCategoryId=7},
                new AdvertisingModel { Id=15, AdvertisingName="Серия книг « Песнь льда и пламени»", Text="Набор из четырех книг в отличном состоянии. +47287365723",
                    ImagePath ="https://content.kufar.by/gallery/34/3430032145.jpg", ItemPrice="70 р.", AdvertisingCategoryId=8},
                new AdvertisingModel { Id=16, AdvertisingName="Нож Ganzo Firebird FH21", Text="Сталь D2 (твердость 60 ед HRC) флиппер на подшипниках,рукоять из G10 +47236482634623",
                    ImagePath ="https://content.kufar.by/gallery/38/3833302936.jpg", ItemPrice="80 р.", AdvertisingCategoryId=8}
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
