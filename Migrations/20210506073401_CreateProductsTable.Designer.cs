﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet.Data;

namespace dotnet.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20210506073401_CreateProductsTable")]
    partial class CreateProductsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("dotnet.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Image")
                        .HasColumnType("longtext");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Voluptatem qui non atque quae ex natus. Et exercitationem non ab quia enim officiis. Voluptatem optio quas repellat dignissimos minus non. Qui et et velit suscipit. Voluptatum nihil et. Sed quia doloremque qui atque nisi optio accusantium voluptatem.",
                            Image = "http://lorempixel.com/640/480/nature",
                            Price = 74f,
                            Title = "dolores"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Voluptas veritatis consequatur laborum harum nulla odit. Inventore velit aperiam dolor cumque. Numquam esse illum tempora magnam.",
                            Image = "http://lorempixel.com/640/480/city",
                            Price = 77f,
                            Title = "iste"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Numquam nesciunt corporis quam esse. Dolorum saepe voluptas veritatis ea enim sed et architecto. Facilis dolore veritatis eum optio corporis rerum sit consequatur ut. Deleniti nemo minus vero sunt provident sint in rem ut. Officiis magnam culpa eos esse rerum alias earum.",
                            Image = "http://lorempixel.com/640/480/business",
                            Price = 96f,
                            Title = "facere"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Corrupti est optio mollitia voluptates sint aut est. Voluptates eos officia doloremque sed ut quod. Laudantium animi esse a autem vel magnam iste. Repellat sit accusamus est hic voluptas aut aut consequatur in.",
                            Image = "http://lorempixel.com/640/480/sports",
                            Price = 93f,
                            Title = "voluptatem"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Beatae ea laboriosam odio omnis eum odio. Sed non corrupti omnis aut voluptas fugit debitis. Ipsa sit sint rerum quod qui. Consequatur culpa voluptatem quo et et voluptas aut facilis nulla. Perferendis rem consequatur consequatur molestias natus deserunt nam neque praesentium. Consequuntur et aliquam cupiditate iure debitis rem odio molestiae.",
                            Image = "http://lorempixel.com/640/480/city",
                            Price = 58f,
                            Title = "quos"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Ea id accusamus ullam omnis sint et eaque rerum aut. Rerum eaque excepturi tenetur ab architecto. Quas doloremque qui dolor qui nisi sint necessitatibus. Sed sint ut voluptatum explicabo dolor. Ratione a quisquam.",
                            Image = "http://lorempixel.com/640/480/city",
                            Price = 46f,
                            Title = "vel"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Ex voluptatem sed. Voluptas sapiente atque debitis voluptatem debitis debitis animi. Culpa sit non dolor officiis sit cumque. Nisi fuga enim. Consequatur commodi repellat voluptas nihil quaerat. Nesciunt ea nihil et modi assumenda quae.",
                            Image = "http://lorempixel.com/640/480/nightlife",
                            Price = 75f,
                            Title = "earum"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Eius culpa molestias similique itaque consectetur officia. Molestiae ipsum aut aut non aut quis. Mollitia corrupti unde natus et ipsam odio neque sequi. Nemo aut dolorem deleniti voluptatibus architecto et.",
                            Image = "http://lorempixel.com/640/480/abstract",
                            Price = 18f,
                            Title = "ipsa"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Inventore eos fugit minus quidem doloribus iure esse ut. Atque non earum incidunt dolores porro. Ut eos nisi velit aliquid rerum culpa cumque dignissimos amet. Earum quas quo ea suscipit et et velit dignissimos rerum.",
                            Image = "http://lorempixel.com/640/480/people",
                            Price = 51f,
                            Title = "aut"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Necessitatibus cupiditate et ut placeat in aliquid ipsa. Maxime sequi eum nihil. Sed doloremque consectetur et corrupti. In nihil vitae officiis eos et. Ad aspernatur modi.",
                            Image = "http://lorempixel.com/640/480/people",
                            Price = 61f,
                            Title = "omnis"
                        },
                        new
                        {
                            Id = 11,
                            Description = "Illo dicta et iusto voluptatem deserunt laudantium occaecati distinctio sit. Est nesciunt et at corrupti et. Enim quis sit dignissimos quod. Hic quos architecto earum ut inventore. Quo ipsa magnam atque rerum quis commodi.",
                            Image = "http://lorempixel.com/640/480/business",
                            Price = 89f,
                            Title = "tempore"
                        },
                        new
                        {
                            Id = 12,
                            Description = "Eligendi est beatae molestiae consequatur dolore. Aperiam ad ea autem illum est nisi quas. Eum sint cupiditate omnis id mollitia.",
                            Image = "http://lorempixel.com/640/480/nature",
                            Price = 71f,
                            Title = "recusandae"
                        },
                        new
                        {
                            Id = 13,
                            Description = "Sed quis consequuntur reprehenderit ex repellat voluptatem ab cum officiis. Impedit optio labore voluptatem enim nemo libero. Officiis id dolor debitis suscipit ea. Harum illum aspernatur sit qui sit.",
                            Image = "http://lorempixel.com/640/480/transport",
                            Price = 40f,
                            Title = "et"
                        },
                        new
                        {
                            Id = 14,
                            Description = "Aut voluptatem illum officia. Eum laborum voluptatem consequatur dolorem. Culpa veniam qui perferendis rem. Corporis nihil velit temporibus doloremque earum consequatur. Tenetur expedita deleniti perspiciatis.",
                            Image = "http://lorempixel.com/640/480/nature",
                            Price = 42f,
                            Title = "non"
                        },
                        new
                        {
                            Id = 15,
                            Description = "Ullam est dolorum quis. Hic voluptatem architecto omnis qui. Ut vel dolorum eum unde. Aperiam odit sit commodi reiciendis beatae.",
                            Image = "http://lorempixel.com/640/480/food",
                            Price = 44f,
                            Title = "impedit"
                        },
                        new
                        {
                            Id = 16,
                            Description = "Porro ab totam est. Quia aspernatur consequatur pariatur voluptatem. Rem voluptatem quo deleniti ex ab ut eos aperiam explicabo.",
                            Image = "http://lorempixel.com/640/480/transport",
                            Price = 43f,
                            Title = "laboriosam"
                        },
                        new
                        {
                            Id = 17,
                            Description = "Autem voluptatem similique ipsum et ut omnis consequuntur ex quas. Impedit recusandae est. Perferendis optio dolores eaque harum sit est. Quisquam qui velit velit eos eaque. Nobis qui alias commodi voluptas omnis quibusdam cum.",
                            Image = "http://lorempixel.com/640/480/city",
                            Price = 12f,
                            Title = "quia"
                        },
                        new
                        {
                            Id = 18,
                            Description = "Reiciendis labore nisi eaque qui. Vitae ullam tempora quis ut omnis ratione. Nulla omnis dolores assumenda rerum sunt harum illum aut.",
                            Image = "http://lorempixel.com/640/480/nature",
                            Price = 61f,
                            Title = "optio"
                        },
                        new
                        {
                            Id = 19,
                            Description = "Voluptatem dolor perferendis itaque. Nostrum occaecati atque illo. Placeat fuga a nihil blanditiis. Aperiam animi sit tenetur tenetur ut vero aliquam illo. Est neque ut quidem totam sunt voluptas et minima ducimus.",
                            Image = "http://lorempixel.com/640/480/cats",
                            Price = 13f,
                            Title = "ea"
                        },
                        new
                        {
                            Id = 20,
                            Description = "Commodi est quia voluptatem perferendis. Non ea sed tempore. Quia temporibus voluptatem sed et possimus aut incidunt error ea. Esse voluptates expedita eos. Ratione aut culpa. Consequatur sit et.",
                            Image = "http://lorempixel.com/640/480/fashion",
                            Price = 26f,
                            Title = "mollitia"
                        },
                        new
                        {
                            Id = 21,
                            Description = "Et sint et. Sapiente dolores repudiandae aut. Nesciunt cupiditate sint voluptatem consequatur nostrum rerum.",
                            Image = "http://lorempixel.com/640/480/animals",
                            Price = 37f,
                            Title = "id"
                        },
                        new
                        {
                            Id = 22,
                            Description = "Eaque veritatis ut sed. Delectus nulla eos tempore earum sit cupiditate nulla. Quae iste quasi qui velit quod. Quos doloribus corrupti veritatis pariatur quidem eaque impedit ducimus officiis.",
                            Image = "http://lorempixel.com/640/480/nightlife",
                            Price = 89f,
                            Title = "numquam"
                        },
                        new
                        {
                            Id = 23,
                            Description = "Qui est nostrum provident quasi quo. Numquam laboriosam doloribus nemo itaque et iure quasi at aut. Enim perspiciatis architecto eos rem qui voluptas. Et modi quasi distinctio expedita sapiente nam deserunt odit. Neque debitis tempore ab error est. Architecto perspiciatis optio quibusdam.",
                            Image = "http://lorempixel.com/640/480/city",
                            Price = 44f,
                            Title = "aut"
                        },
                        new
                        {
                            Id = 24,
                            Description = "Laborum eius eum deserunt. Totam quia voluptatem ea. Ratione soluta suscipit nisi enim est veniam est. Molestiae hic eius reiciendis ullam impedit in minima. Aut fugit nulla ab earum voluptate ut ducimus.",
                            Image = "http://lorempixel.com/640/480/business",
                            Price = 56f,
                            Title = "voluptatem"
                        },
                        new
                        {
                            Id = 25,
                            Description = "Velit facilis vero fuga rem id velit nihil. Eaque assumenda sit autem. Reprehenderit labore vitae aut id. In aliquam nostrum eos. Id molestiae repellat.",
                            Image = "http://lorempixel.com/640/480/sports",
                            Price = 50f,
                            Title = "quia"
                        },
                        new
                        {
                            Id = 26,
                            Description = "Aliquam ut in quia cum labore nam beatae quia eos. Beatae porro ratione. Tenetur quia magni. Officia quas aspernatur sequi ex repellat cupiditate minus.",
                            Image = "http://lorempixel.com/640/480/sports",
                            Price = 28f,
                            Title = "assumenda"
                        },
                        new
                        {
                            Id = 27,
                            Description = "Atque suscipit sed omnis illum. Ea rerum architecto. Consequatur reprehenderit numquam. Eum deserunt vel ipsa dolorum enim eos optio corrupti. Eum eius quia voluptatem.",
                            Image = "http://lorempixel.com/640/480/nightlife",
                            Price = 87f,
                            Title = "mollitia"
                        },
                        new
                        {
                            Id = 28,
                            Description = "Consequatur mollitia vel est. Eos dicta est doloribus sint. Qui voluptas eos non qui eos. Nesciunt reiciendis qui consequuntur repellendus pariatur vel vel animi asperiores. Dolores modi ut omnis ut.",
                            Image = "http://lorempixel.com/640/480/food",
                            Price = 27f,
                            Title = "debitis"
                        },
                        new
                        {
                            Id = 29,
                            Description = "Et provident qui voluptatem sit explicabo. Et beatae voluptates aut quis at. Et omnis nobis consequatur provident incidunt ut sed. Rem at nostrum. Ut provident minus voluptatem. Sequi provident aliquam ducimus.",
                            Image = "http://lorempixel.com/640/480/sports",
                            Price = 98f,
                            Title = "alias"
                        },
                        new
                        {
                            Id = 30,
                            Description = "Voluptas occaecati dicta et voluptas consequatur sint magni rem quisquam. Rem facere quos consequatur odio aut. Necessitatibus recusandae laudantium vitae nisi. Accusamus numquam quia laudantium sit hic impedit quia omnis veniam. Sit consequatur incidunt sunt. Facilis quo inventore perferendis facilis libero ea eaque rerum consequatur.",
                            Image = "http://lorempixel.com/640/480/nature",
                            Price = 71f,
                            Title = "animi"
                        },
                        new
                        {
                            Id = 31,
                            Description = "Soluta dolor velit quis unde ipsa. Hic cupiditate perferendis. Optio totam veniam aliquid. Aut quia delectus nostrum fuga voluptatem. Et sed consequatur veniam in. Magnam aperiam dolores tenetur.",
                            Image = "http://lorempixel.com/640/480/sports",
                            Price = 58f,
                            Title = "quo"
                        },
                        new
                        {
                            Id = 32,
                            Description = "Ut aut officia necessitatibus sed repellat rem aut recusandae. Sed sunt illum rem placeat provident eos expedita nulla. Ipsum quod omnis deleniti est enim reiciendis tempore quod libero. Molestias fuga accusantium nam vitae cumque id corrupti sit. Incidunt debitis provident eaque animi et error placeat nihil. Accusamus asperiores vero est et quia aut fugit voluptatem voluptatem.",
                            Image = "http://lorempixel.com/640/480/sports",
                            Price = 31f,
                            Title = "voluptas"
                        },
                        new
                        {
                            Id = 33,
                            Description = "Hic autem aut. Eum quia ipsum sint sit earum et incidunt. Ipsum quo esse et voluptatem minus. Sint assumenda laboriosam eos sapiente deserunt dolorum modi enim ut. Laborum provident aut et rerum possimus dicta deserunt vel cumque. Tempore maxime itaque saepe libero rerum.",
                            Image = "http://lorempixel.com/640/480/food",
                            Price = 65f,
                            Title = "voluptatem"
                        },
                        new
                        {
                            Id = 34,
                            Description = "Aut excepturi sit blanditiis earum nihil labore. Rerum sed numquam earum aliquam optio molestiae. Velit expedita quo est sint sit aperiam. Deserunt molestiae et. Tempore et nihil explicabo vitae beatae nihil et rem amet. Vel ex enim possimus ad praesentium et nobis velit.",
                            Image = "http://lorempixel.com/640/480/cats",
                            Price = 48f,
                            Title = "debitis"
                        },
                        new
                        {
                            Id = 35,
                            Description = "Consectetur et molestiae. Dicta eos sit quidem ipsam eum. Et quia vero quia. Non quae aut nulla praesentium. Est molestiae omnis quidem temporibus. Accusamus nobis dolore sunt.",
                            Image = "http://lorempixel.com/640/480/nature",
                            Price = 15f,
                            Title = "tempora"
                        },
                        new
                        {
                            Id = 36,
                            Description = "Voluptatem eum quia quibusdam quod ipsa. Laborum omnis suscipit rerum molestias molestiae. Vel numquam aut in qui. Et porro qui.",
                            Image = "http://lorempixel.com/640/480/abstract",
                            Price = 80f,
                            Title = "saepe"
                        },
                        new
                        {
                            Id = 37,
                            Description = "Sunt quod et delectus porro omnis voluptates. Est quae porro voluptas consequuntur illum voluptatibus ullam. Minus earum autem et ex expedita deleniti quasi ducimus. Corporis recusandae magnam sit aut velit saepe eaque aperiam enim. Autem voluptatem in porro non inventore vero dolores aut nobis.",
                            Image = "http://lorempixel.com/640/480/nature",
                            Price = 23f,
                            Title = "assumenda"
                        },
                        new
                        {
                            Id = 38,
                            Description = "Aliquam quisquam eius dicta officia saepe ut dolor est. Odio accusantium maxime sint ut dolor hic accusantium. Itaque autem reiciendis voluptatem eum mollitia dolorum in similique.",
                            Image = "http://lorempixel.com/640/480/city",
                            Price = 61f,
                            Title = "incidunt"
                        },
                        new
                        {
                            Id = 39,
                            Description = "Ratione sequi quia qui hic nobis vitae non consequatur temporibus. Sunt doloremque fugit in est et repellendus quia commodi odit. Ad similique iure.",
                            Image = "http://lorempixel.com/640/480/nightlife",
                            Price = 98f,
                            Title = "dolor"
                        },
                        new
                        {
                            Id = 40,
                            Description = "Eaque hic quam illo animi voluptas. Sapiente alias nisi. Velit nihil amet dolorem quod similique quas alias sint. Repellendus distinctio expedita et fugit debitis. Et praesentium porro voluptas eum eveniet facere.",
                            Image = "http://lorempixel.com/640/480/abstract",
                            Price = 70f,
                            Title = "voluptatem"
                        },
                        new
                        {
                            Id = 41,
                            Description = "Deserunt rerum dolor dolor in eligendi est sunt ea. Et laudantium voluptatem dolor veritatis magnam nostrum omnis. Atque rerum qui non. Fuga sit qui cupiditate et magni quasi. Doloribus amet voluptas laudantium alias debitis beatae.",
                            Image = "http://lorempixel.com/640/480/business",
                            Price = 56f,
                            Title = "reiciendis"
                        },
                        new
                        {
                            Id = 42,
                            Description = "Sed aliquam ducimus quae quo quas maxime voluptates autem. Non eos esse. Sequi natus aut vitae.",
                            Image = "http://lorempixel.com/640/480/people",
                            Price = 34f,
                            Title = "temporibus"
                        },
                        new
                        {
                            Id = 43,
                            Description = "Magni qui animi dolore velit nobis. Reiciendis explicabo magnam. Consequatur quis sunt sed est non iure neque. A quaerat consectetur quae omnis est occaecati veritatis nihil.",
                            Image = "http://lorempixel.com/640/480/animals",
                            Price = 94f,
                            Title = "in"
                        },
                        new
                        {
                            Id = 44,
                            Description = "Ipsam deserunt ut aliquam sit tempora omnis illo fugiat. Tempore ut dolor maiores sunt qui est rerum esse provident. Officiis voluptatem iste atque est neque hic.",
                            Image = "http://lorempixel.com/640/480/fashion",
                            Price = 97f,
                            Title = "quia"
                        },
                        new
                        {
                            Id = 45,
                            Description = "Deserunt quaerat earum qui cum illo itaque voluptatem et. Corporis quis non earum sed corrupti. Voluptate ipsa temporibus. Ut dignissimos sit soluta assumenda rerum veritatis dolorem. Accusamus natus dolores iusto consectetur qui.",
                            Image = "http://lorempixel.com/640/480/people",
                            Price = 95f,
                            Title = "quia"
                        },
                        new
                        {
                            Id = 46,
                            Description = "Excepturi est dignissimos a sit a. Fuga laudantium non iste veniam maxime quia voluptas. Laborum est et velit officiis adipisci voluptate iste quod. Explicabo facere consequatur vero. Ex quia enim. Expedita repellat quis dolores.",
                            Image = "http://lorempixel.com/640/480/sports",
                            Price = 91f,
                            Title = "ab"
                        },
                        new
                        {
                            Id = 47,
                            Description = "Ipsam minima iure enim eos repudiandae sit dolorem qui nihil. Ipsam velit necessitatibus numquam rerum eos repellat. Id odio velit architecto iusto a libero vel labore. Explicabo sint odio eum iusto.",
                            Image = "http://lorempixel.com/640/480/cats",
                            Price = 52f,
                            Title = "iusto"
                        },
                        new
                        {
                            Id = 48,
                            Description = "Saepe voluptas et numquam repellendus impedit pariatur praesentium aut nesciunt. Hic eveniet dolorum omnis provident fugit sed. Aliquid adipisci aspernatur omnis necessitatibus quae et dolorem atque omnis. Facere explicabo beatae odit et omnis occaecati maiores. Qui aut non nihil vitae. Ratione dolorum illum quasi et consequuntur quaerat eveniet.",
                            Image = "http://lorempixel.com/640/480/food",
                            Price = 73f,
                            Title = "pariatur"
                        },
                        new
                        {
                            Id = 49,
                            Description = "Dolorem aut ut. Optio laudantium ea blanditiis accusamus. Optio repellat perferendis magni repudiandae tempora et voluptatibus qui.",
                            Image = "http://lorempixel.com/640/480/nature",
                            Price = 25f,
                            Title = "quibusdam"
                        },
                        new
                        {
                            Id = 50,
                            Description = "Esse vero occaecati dolores velit. Velit consequuntur cumque corrupti illum voluptate amet maxime. Labore cum ut minima fugiat quia quasi. Repellat nisi libero consectetur quo in consequatur eos ut animi.",
                            Image = "http://lorempixel.com/640/480/business",
                            Price = 96f,
                            Title = "ut"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
