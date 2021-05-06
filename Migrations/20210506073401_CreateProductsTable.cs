using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet.Migrations
{
    public partial class CreateProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Image = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Voluptatem qui non atque quae ex natus. Et exercitationem non ab quia enim officiis. Voluptatem optio quas repellat dignissimos minus non. Qui et et velit suscipit. Voluptatum nihil et. Sed quia doloremque qui atque nisi optio accusantium voluptatem.", "http://lorempixel.com/640/480/nature", 74f, "dolores" },
                    { 28, "Consequatur mollitia vel est. Eos dicta est doloribus sint. Qui voluptas eos non qui eos. Nesciunt reiciendis qui consequuntur repellendus pariatur vel vel animi asperiores. Dolores modi ut omnis ut.", "http://lorempixel.com/640/480/food", 27f, "debitis" },
                    { 29, "Et provident qui voluptatem sit explicabo. Et beatae voluptates aut quis at. Et omnis nobis consequatur provident incidunt ut sed. Rem at nostrum. Ut provident minus voluptatem. Sequi provident aliquam ducimus.", "http://lorempixel.com/640/480/sports", 98f, "alias" },
                    { 30, "Voluptas occaecati dicta et voluptas consequatur sint magni rem quisquam. Rem facere quos consequatur odio aut. Necessitatibus recusandae laudantium vitae nisi. Accusamus numquam quia laudantium sit hic impedit quia omnis veniam. Sit consequatur incidunt sunt. Facilis quo inventore perferendis facilis libero ea eaque rerum consequatur.", "http://lorempixel.com/640/480/nature", 71f, "animi" },
                    { 31, "Soluta dolor velit quis unde ipsa. Hic cupiditate perferendis. Optio totam veniam aliquid. Aut quia delectus nostrum fuga voluptatem. Et sed consequatur veniam in. Magnam aperiam dolores tenetur.", "http://lorempixel.com/640/480/sports", 58f, "quo" },
                    { 32, "Ut aut officia necessitatibus sed repellat rem aut recusandae. Sed sunt illum rem placeat provident eos expedita nulla. Ipsum quod omnis deleniti est enim reiciendis tempore quod libero. Molestias fuga accusantium nam vitae cumque id corrupti sit. Incidunt debitis provident eaque animi et error placeat nihil. Accusamus asperiores vero est et quia aut fugit voluptatem voluptatem.", "http://lorempixel.com/640/480/sports", 31f, "voluptas" },
                    { 33, "Hic autem aut. Eum quia ipsum sint sit earum et incidunt. Ipsum quo esse et voluptatem minus. Sint assumenda laboriosam eos sapiente deserunt dolorum modi enim ut. Laborum provident aut et rerum possimus dicta deserunt vel cumque. Tempore maxime itaque saepe libero rerum.", "http://lorempixel.com/640/480/food", 65f, "voluptatem" },
                    { 34, "Aut excepturi sit blanditiis earum nihil labore. Rerum sed numquam earum aliquam optio molestiae. Velit expedita quo est sint sit aperiam. Deserunt molestiae et. Tempore et nihil explicabo vitae beatae nihil et rem amet. Vel ex enim possimus ad praesentium et nobis velit.", "http://lorempixel.com/640/480/cats", 48f, "debitis" },
                    { 35, "Consectetur et molestiae. Dicta eos sit quidem ipsam eum. Et quia vero quia. Non quae aut nulla praesentium. Est molestiae omnis quidem temporibus. Accusamus nobis dolore sunt.", "http://lorempixel.com/640/480/nature", 15f, "tempora" },
                    { 36, "Voluptatem eum quia quibusdam quod ipsa. Laborum omnis suscipit rerum molestias molestiae. Vel numquam aut in qui. Et porro qui.", "http://lorempixel.com/640/480/abstract", 80f, "saepe" },
                    { 37, "Sunt quod et delectus porro omnis voluptates. Est quae porro voluptas consequuntur illum voluptatibus ullam. Minus earum autem et ex expedita deleniti quasi ducimus. Corporis recusandae magnam sit aut velit saepe eaque aperiam enim. Autem voluptatem in porro non inventore vero dolores aut nobis.", "http://lorempixel.com/640/480/nature", 23f, "assumenda" },
                    { 38, "Aliquam quisquam eius dicta officia saepe ut dolor est. Odio accusantium maxime sint ut dolor hic accusantium. Itaque autem reiciendis voluptatem eum mollitia dolorum in similique.", "http://lorempixel.com/640/480/city", 61f, "incidunt" },
                    { 39, "Ratione sequi quia qui hic nobis vitae non consequatur temporibus. Sunt doloremque fugit in est et repellendus quia commodi odit. Ad similique iure.", "http://lorempixel.com/640/480/nightlife", 98f, "dolor" },
                    { 40, "Eaque hic quam illo animi voluptas. Sapiente alias nisi. Velit nihil amet dolorem quod similique quas alias sint. Repellendus distinctio expedita et fugit debitis. Et praesentium porro voluptas eum eveniet facere.", "http://lorempixel.com/640/480/abstract", 70f, "voluptatem" },
                    { 41, "Deserunt rerum dolor dolor in eligendi est sunt ea. Et laudantium voluptatem dolor veritatis magnam nostrum omnis. Atque rerum qui non. Fuga sit qui cupiditate et magni quasi. Doloribus amet voluptas laudantium alias debitis beatae.", "http://lorempixel.com/640/480/business", 56f, "reiciendis" },
                    { 42, "Sed aliquam ducimus quae quo quas maxime voluptates autem. Non eos esse. Sequi natus aut vitae.", "http://lorempixel.com/640/480/people", 34f, "temporibus" },
                    { 43, "Magni qui animi dolore velit nobis. Reiciendis explicabo magnam. Consequatur quis sunt sed est non iure neque. A quaerat consectetur quae omnis est occaecati veritatis nihil.", "http://lorempixel.com/640/480/animals", 94f, "in" },
                    { 44, "Ipsam deserunt ut aliquam sit tempora omnis illo fugiat. Tempore ut dolor maiores sunt qui est rerum esse provident. Officiis voluptatem iste atque est neque hic.", "http://lorempixel.com/640/480/fashion", 97f, "quia" },
                    { 45, "Deserunt quaerat earum qui cum illo itaque voluptatem et. Corporis quis non earum sed corrupti. Voluptate ipsa temporibus. Ut dignissimos sit soluta assumenda rerum veritatis dolorem. Accusamus natus dolores iusto consectetur qui.", "http://lorempixel.com/640/480/people", 95f, "quia" },
                    { 46, "Excepturi est dignissimos a sit a. Fuga laudantium non iste veniam maxime quia voluptas. Laborum est et velit officiis adipisci voluptate iste quod. Explicabo facere consequatur vero. Ex quia enim. Expedita repellat quis dolores.", "http://lorempixel.com/640/480/sports", 91f, "ab" },
                    { 47, "Ipsam minima iure enim eos repudiandae sit dolorem qui nihil. Ipsam velit necessitatibus numquam rerum eos repellat. Id odio velit architecto iusto a libero vel labore. Explicabo sint odio eum iusto.", "http://lorempixel.com/640/480/cats", 52f, "iusto" },
                    { 48, "Saepe voluptas et numquam repellendus impedit pariatur praesentium aut nesciunt. Hic eveniet dolorum omnis provident fugit sed. Aliquid adipisci aspernatur omnis necessitatibus quae et dolorem atque omnis. Facere explicabo beatae odit et omnis occaecati maiores. Qui aut non nihil vitae. Ratione dolorum illum quasi et consequuntur quaerat eveniet.", "http://lorempixel.com/640/480/food", 73f, "pariatur" },
                    { 27, "Atque suscipit sed omnis illum. Ea rerum architecto. Consequatur reprehenderit numquam. Eum deserunt vel ipsa dolorum enim eos optio corrupti. Eum eius quia voluptatem.", "http://lorempixel.com/640/480/nightlife", 87f, "mollitia" },
                    { 26, "Aliquam ut in quia cum labore nam beatae quia eos. Beatae porro ratione. Tenetur quia magni. Officia quas aspernatur sequi ex repellat cupiditate minus.", "http://lorempixel.com/640/480/sports", 28f, "assumenda" },
                    { 25, "Velit facilis vero fuga rem id velit nihil. Eaque assumenda sit autem. Reprehenderit labore vitae aut id. In aliquam nostrum eos. Id molestiae repellat.", "http://lorempixel.com/640/480/sports", 50f, "quia" },
                    { 24, "Laborum eius eum deserunt. Totam quia voluptatem ea. Ratione soluta suscipit nisi enim est veniam est. Molestiae hic eius reiciendis ullam impedit in minima. Aut fugit nulla ab earum voluptate ut ducimus.", "http://lorempixel.com/640/480/business", 56f, "voluptatem" },
                    { 2, "Voluptas veritatis consequatur laborum harum nulla odit. Inventore velit aperiam dolor cumque. Numquam esse illum tempora magnam.", "http://lorempixel.com/640/480/city", 77f, "iste" },
                    { 3, "Numquam nesciunt corporis quam esse. Dolorum saepe voluptas veritatis ea enim sed et architecto. Facilis dolore veritatis eum optio corporis rerum sit consequatur ut. Deleniti nemo minus vero sunt provident sint in rem ut. Officiis magnam culpa eos esse rerum alias earum.", "http://lorempixel.com/640/480/business", 96f, "facere" },
                    { 4, "Corrupti est optio mollitia voluptates sint aut est. Voluptates eos officia doloremque sed ut quod. Laudantium animi esse a autem vel magnam iste. Repellat sit accusamus est hic voluptas aut aut consequatur in.", "http://lorempixel.com/640/480/sports", 93f, "voluptatem" },
                    { 5, "Beatae ea laboriosam odio omnis eum odio. Sed non corrupti omnis aut voluptas fugit debitis. Ipsa sit sint rerum quod qui. Consequatur culpa voluptatem quo et et voluptas aut facilis nulla. Perferendis rem consequatur consequatur molestias natus deserunt nam neque praesentium. Consequuntur et aliquam cupiditate iure debitis rem odio molestiae.", "http://lorempixel.com/640/480/city", 58f, "quos" },
                    { 6, "Ea id accusamus ullam omnis sint et eaque rerum aut. Rerum eaque excepturi tenetur ab architecto. Quas doloremque qui dolor qui nisi sint necessitatibus. Sed sint ut voluptatum explicabo dolor. Ratione a quisquam.", "http://lorempixel.com/640/480/city", 46f, "vel" },
                    { 7, "Ex voluptatem sed. Voluptas sapiente atque debitis voluptatem debitis debitis animi. Culpa sit non dolor officiis sit cumque. Nisi fuga enim. Consequatur commodi repellat voluptas nihil quaerat. Nesciunt ea nihil et modi assumenda quae.", "http://lorempixel.com/640/480/nightlife", 75f, "earum" },
                    { 8, "Eius culpa molestias similique itaque consectetur officia. Molestiae ipsum aut aut non aut quis. Mollitia corrupti unde natus et ipsam odio neque sequi. Nemo aut dolorem deleniti voluptatibus architecto et.", "http://lorempixel.com/640/480/abstract", 18f, "ipsa" },
                    { 9, "Inventore eos fugit minus quidem doloribus iure esse ut. Atque non earum incidunt dolores porro. Ut eos nisi velit aliquid rerum culpa cumque dignissimos amet. Earum quas quo ea suscipit et et velit dignissimos rerum.", "http://lorempixel.com/640/480/people", 51f, "aut" },
                    { 10, "Necessitatibus cupiditate et ut placeat in aliquid ipsa. Maxime sequi eum nihil. Sed doloremque consectetur et corrupti. In nihil vitae officiis eos et. Ad aspernatur modi.", "http://lorempixel.com/640/480/people", 61f, "omnis" },
                    { 11, "Illo dicta et iusto voluptatem deserunt laudantium occaecati distinctio sit. Est nesciunt et at corrupti et. Enim quis sit dignissimos quod. Hic quos architecto earum ut inventore. Quo ipsa magnam atque rerum quis commodi.", "http://lorempixel.com/640/480/business", 89f, "tempore" },
                    { 49, "Dolorem aut ut. Optio laudantium ea blanditiis accusamus. Optio repellat perferendis magni repudiandae tempora et voluptatibus qui.", "http://lorempixel.com/640/480/nature", 25f, "quibusdam" },
                    { 12, "Eligendi est beatae molestiae consequatur dolore. Aperiam ad ea autem illum est nisi quas. Eum sint cupiditate omnis id mollitia.", "http://lorempixel.com/640/480/nature", 71f, "recusandae" },
                    { 14, "Aut voluptatem illum officia. Eum laborum voluptatem consequatur dolorem. Culpa veniam qui perferendis rem. Corporis nihil velit temporibus doloremque earum consequatur. Tenetur expedita deleniti perspiciatis.", "http://lorempixel.com/640/480/nature", 42f, "non" },
                    { 15, "Ullam est dolorum quis. Hic voluptatem architecto omnis qui. Ut vel dolorum eum unde. Aperiam odit sit commodi reiciendis beatae.", "http://lorempixel.com/640/480/food", 44f, "impedit" },
                    { 16, "Porro ab totam est. Quia aspernatur consequatur pariatur voluptatem. Rem voluptatem quo deleniti ex ab ut eos aperiam explicabo.", "http://lorempixel.com/640/480/transport", 43f, "laboriosam" },
                    { 17, "Autem voluptatem similique ipsum et ut omnis consequuntur ex quas. Impedit recusandae est. Perferendis optio dolores eaque harum sit est. Quisquam qui velit velit eos eaque. Nobis qui alias commodi voluptas omnis quibusdam cum.", "http://lorempixel.com/640/480/city", 12f, "quia" },
                    { 18, "Reiciendis labore nisi eaque qui. Vitae ullam tempora quis ut omnis ratione. Nulla omnis dolores assumenda rerum sunt harum illum aut.", "http://lorempixel.com/640/480/nature", 61f, "optio" },
                    { 19, "Voluptatem dolor perferendis itaque. Nostrum occaecati atque illo. Placeat fuga a nihil blanditiis. Aperiam animi sit tenetur tenetur ut vero aliquam illo. Est neque ut quidem totam sunt voluptas et minima ducimus.", "http://lorempixel.com/640/480/cats", 13f, "ea" },
                    { 20, "Commodi est quia voluptatem perferendis. Non ea sed tempore. Quia temporibus voluptatem sed et possimus aut incidunt error ea. Esse voluptates expedita eos. Ratione aut culpa. Consequatur sit et.", "http://lorempixel.com/640/480/fashion", 26f, "mollitia" },
                    { 21, "Et sint et. Sapiente dolores repudiandae aut. Nesciunt cupiditate sint voluptatem consequatur nostrum rerum.", "http://lorempixel.com/640/480/animals", 37f, "id" },
                    { 22, "Eaque veritatis ut sed. Delectus nulla eos tempore earum sit cupiditate nulla. Quae iste quasi qui velit quod. Quos doloribus corrupti veritatis pariatur quidem eaque impedit ducimus officiis.", "http://lorempixel.com/640/480/nightlife", 89f, "numquam" },
                    { 23, "Qui est nostrum provident quasi quo. Numquam laboriosam doloribus nemo itaque et iure quasi at aut. Enim perspiciatis architecto eos rem qui voluptas. Et modi quasi distinctio expedita sapiente nam deserunt odit. Neque debitis tempore ab error est. Architecto perspiciatis optio quibusdam.", "http://lorempixel.com/640/480/city", 44f, "aut" },
                    { 13, "Sed quis consequuntur reprehenderit ex repellat voluptatem ab cum officiis. Impedit optio labore voluptatem enim nemo libero. Officiis id dolor debitis suscipit ea. Harum illum aspernatur sit qui sit.", "http://lorempixel.com/640/480/transport", 40f, "et" },
                    { 50, "Esse vero occaecati dolores velit. Velit consequuntur cumque corrupti illum voluptate amet maxime. Labore cum ut minima fugiat quia quasi. Repellat nisi libero consectetur quo in consequatur eos ut animi.", "http://lorempixel.com/640/480/business", 96f, "ut" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
