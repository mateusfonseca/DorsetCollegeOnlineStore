using Microsoft.EntityFrameworkCore;
using DorsetCollegeOnlineStore.Data;

namespace DorsetCollegeOnlineStore.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new DorsetCollegeOnlineStoreContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<DorsetCollegeOnlineStoreContext>>());
        if (!context.User.Any())
        {
            context.User.AddRange(
                new User
                {
                    Email = "john@gmail.com",
                    Password = "m38rmF$",
                    FirstName = "john",
                    LastName = "doe",
                    PhoneNumber = "1-570-236-7033",
                    Image = "https://thispersondoesnotexist.com/image"
                },
                new User
                {
                    Email = "morrison@gmail.com",
                    Password = "83r5^_",
                    FirstName = "david",
                    LastName = "morrison",
                    PhoneNumber = "1-570-236-7033",
                    Image = "https://thispersondoesnotexist.com/image"
                },
                new User
                {
                    Email = "kevin@gmail.com",
                    Password = "kev02937@",
                    FirstName = "kevin",
                    LastName = "ryan",
                    PhoneNumber = "1-567-094-1345",
                    Image = "https://thispersondoesnotexist.com/image"
                },
                new User
                {
                    Email = "don@gmail.com",
                    Password = "ewedon",
                    FirstName = "don",
                    LastName = "romer",
                    PhoneNumber = "1-765-789-6734",
                    Image = "https://thispersondoesnotexist.com/image"
                },
                new User
                {
                    Email = "derek@gmail.com",
                    Password = "jklg*_56",
                    FirstName = "derek",
                    LastName = "powell",
                    PhoneNumber = "1-956-001-1945",
                    Image = "https://thispersondoesnotexist.com/image"
                },
                new User
                {
                    Email = "david_r@gmail.com",
                    Password = "3478*#54",
                    FirstName = "david",
                    LastName = "russell",
                    PhoneNumber = "1-678-345-9856",
                    Image = "https://thispersondoesnotexist.com/image"
                },
                new User
                {
                    Email = "miriam@gmail.com",
                    Password = "f238&@*$",
                    FirstName = "miriam",
                    LastName = "snyder",
                    PhoneNumber = "1-123-943-0563",
                    Image = "https://thispersondoesnotexist.com/image"
                },
                new User
                {
                    Email = "william@gmail.com",
                    Password = "William56$hj",
                    FirstName = "william",
                    LastName = "hopkins",
                    PhoneNumber = "1-478-001-0890",
                    Image = "https://thispersondoesnotexist.com/image"
                },
                new User
                {
                    Email = "kate@gmail.com",
                    Password = "kfejk@*_",
                    FirstName = "kate",
                    LastName = "hale",
                    PhoneNumber = "1-678-456-1934",
                    Image = "https://thispersondoesnotexist.com/image"
                },
                new User
                {
                    Email = "jimmie@gmail.com",
                    Password = "klein*#%*",
                    FirstName = "jimmie",
                    LastName = "klein",
                    PhoneNumber = "1-104-001-4567",
                    Image = "https://thispersondoesnotexist.com/image"
                }
            );
        }
        
        if (!context.Product.Any())
        {
            context.Product.AddRange(
                new Product
                {
                    Title = "Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops",
                    Price = 109.95M,
                    Description =
                        "Your perfect pack for everyday use and walks in the forest. Stash your laptop (up to 15 inches) in the padded sleeve, your everyday",
                    Category = "men's clothing",
                    Image = "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg",
                    Rate = 3.9,
                    Count = 120
                },
                new Product
                {
                    Title = "Mens Casual Premium Slim Fit T-Shirts ",
                    Price = 22.3M,
                    Description =
                        "Slim-fitting style, contrast raglan long sleeve, three-button henley placket, light weight & soft fabric for breathable and comfortable wearing. And Solid stitched shirts with round neck made for durability and a great fit for casual fashion wear and diehard baseball fans. The Henley style round neckline includes a three-button placket.",
                    Category = "men's clothing",
                    Image = "https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg",
                    Rate = 4.1,
                    Count = 259
                },
                new Product
                {
                    Title = "Mens Cotton Jacket",
                    Price = 55.99M,
                    Description =
                        "great outerwear jackets for Spring/Autumn/Winter, suitable for many occasions, such as working, hiking, camping, mountain/rock climbing, cycling, traveling or other outdoors. Good gift choice for you or your family member. A warm hearted love to Father, husband or son in this thanksgiving or Christmas Day.",
                    Category = "men's clothing",
                    Image = "https://fakestoreapi.com/img/71li-ujtlUL._AC_UX679_.jpg",
                    Rate = 4.7,
                    Count = 500
                },
                new Product
                {
                    Title = "Mens Casual Slim Fit",
                    Price = 15.99M,
                    Description =
                        "The color could be slightly different between on the screen and in practice. / Please note that body builds vary by person, therefore, detailed size information should be reviewed below on the product description.",
                    Category = "men's clothing",
                    Image = "https://fakestoreapi.com/img/71YXzeOuslL._AC_UY879_.jpg",
                    Rate = 2.1,
                    Count = 430
                },
                new Product
                {
                    Title = "John Hardy Women's Legends Naga Gold & Silver Dragon Station Chain Bracelet",
                    Price = 695M,
                    Description =
                        "From our Legends Collection, the Naga was inspired by the mythical water dragon that protects the ocean's pearl. Wear facing inward to be bestowed with love and abundance, or outward for protection.",
                    Category = "jewelery",
                    Image = "https://fakestoreapi.com/img/71pWzhdJNwL._AC_UL640_QL65_ML3_.jpg",
                    Rate = 4.6,
                    Count = 400
                },
                new Product
                {
                    Title = "Solid Gold Petite Micropave ",
                    Price = 168M,
                    Description =
                        "Satisfaction Guaranteed. Return or exchange any order within 30 days.Designed and sold by Hafeez Center in the United States. Satisfaction Guaranteed. Return or exchange any order within 30 days.",
                    Category = "jewelery",
                    Image = "https://fakestoreapi.com/img/61sbMiUnoGL._AC_UL640_QL65_ML3_.jpg",
                    Rate = 3.9,
                    Count = 70
                },
                new Product
                {
                    Title = "White Gold Plated Princess",
                    Price = 9.99M,
                    Description =
                        "Classic Created Wedding Engagement Solitaire Diamond Promise Ring for Her. Gifts to spoil your love more for Engagement, Wedding, Anniversary, Valentine's Day...",
                    Category = "jewelery",
                    Image = "https://fakestoreapi.com/img/71YAIFU48IL._AC_UL640_QL65_ML3_.jpg",
                    Rate = 3,
                    Count = 400
                },
                new Product
                {
                    Title = "Pierced Owl Rose Gold Plated Stainless Steel Double",
                    Price = 10.99M,
                    Description =
                        "Rose Gold Plated Double Flared Tunnel Plug Earrings. Made of 316L Stainless Steel",
                    Category = "jewelery",
                    Image = "https://fakestoreapi.com/img/51UDEzMJVpL._AC_UL640_QL65_ML3_.jpg",
                    Rate = 1.9,
                    Count = 100
                },
                new Product
                {
                    Title = "WD 2TB Elements Portable External Hard Drive - USB 3.0 ",
                    Price = 64M,
                    Description =
                        "USB 3.0 and USB 2.0 Compatibility Fast data transfers Improve PC Performance High Capacity; Compatibility Formatted NTFS for Windows 10, Windows 8.1, Windows 7; Reformatting may be required for other operating systems; Compatibility may vary depending on user’s hardware configuration and operating system",
                    Category = "electronics",
                    Image = "https://fakestoreapi.com/img/61IBBVJvSDL._AC_SY879_.jpg",
                    Rate = 3.3,
                    Count = 203
                },
                new Product
                {
                    Title = "SanDisk SSD PLUS 1TB Internal SSD - SATA III 6 Gb/s",
                    Price = 109M,
                    Description =
                        "Easy upgrade for faster boot up, shutdown, application load and response (As compared to 5400 RPM SATA 2.5” hard drive; Based on published specifications and internal benchmarking tests using PCMark vantage scores) Boosts burst write performance, making it ideal for typical PC workloads The perfect balance of performance and reliability Read/write speeds of up to 535MB/s/450MB/s (Based on internal testing; Performance may vary depending upon drive capacity, host device, OS and application.)",
                    Category = "electronics",
                    Image = "https://fakestoreapi.com/img/61U7T1koQqL._AC_SX679_.jpg",
                    Rate = 2.9,
                    Count = 470
                },
                new Product
                {
                    Title = "Silicon Power 256GB SSD 3D NAND A55 SLC Cache Performance Boost SATA III 2.5",
                    Price = 109M,
                    Description =
                        "3D NAND flash are applied to deliver high transfer speeds Remarkable transfer speeds that enable faster bootup and improved overall system performance. The advanced SLC Cache Technology allows performance boost and longer lifespan 7mm slim design suitable for Ultrabooks and Ultra-slim notebooks. Supports TRIM command, Garbage Collection technology, RAID, and ECC (Error Checking & Correction) to provide the optimized performance and enhanced reliability.",
                    Category = "electronics",
                    Image = "https://fakestoreapi.com/img/71kWymZ+c+L._AC_SX679_.jpg",
                    Rate = 4.8,
                    Count = 319
                },
                new Product
                {
                    Title = "WD 4TB Gaming Drive Works with Playstation 4 Portable External Hard Drive",
                    Price = 114M,
                    Description =
                        "Expand your PS4 gaming experience, Play anywhere Fast and easy, setup Sleek design with high capacity, 3-year manufacturer's limited warranty",
                    Category = "electronics",
                    Image = "https://fakestoreapi.com/img/61mtL65D4cL._AC_SX679_.jpg",
                    Rate = 4.8,
                    Count = 400
                },
                new Product
                {
                    Title = "Acer SB220Q bi 21.5 inches Full HD (1920 x 1080) IPS Ultra-Thin",
                    Price = 599M,
                    Description =
                        "21. 5 inches Full HD (1920 x 1080) widescreen IPS display And Radeon free Sync technology. No compatibility for VESA Mount Refresh Rate: 75Hz - Using HDMI port Zero-frame design | ultra-thin | 4ms response time | IPS panel Aspect ratio - 16: 9. Color Supported - 16. 7 million colors. Brightness - 250 nit Tilt angle -5 degree to 15 degree. Horizontal viewing angle-178 degree. Vertical viewing angle-178 degree 75 hertz",
                    Category = "electronics",
                    Image = "https://fakestoreapi.com/img/81QpkIctqPL._AC_SX679_.jpg",
                    Rate = 2.9,
                    Count = 250
                },
                new Product
                {
                    Title =
                        "Samsung 49-Inch CHG90 144Hz Curved Gaming Monitor (LC49HG90DMNXZA) – Super Ultrawide Screen QLED ",
                    Price = 999.99M,
                    Description =
                        "49 INCH SUPER ULTRAWIDE 32:9 CURVED GAMING MONITOR with dual 27 inch screen side by side QUANTUM DOT (QLED) TECHNOLOGY, HDR support and factory calibration provides stunningly realistic and accurate color and contrast 144HZ HIGH REFRESH RATE and 1ms ultra fast response time work to eliminate motion blur, ghosting, and reduce input lag",
                    Category = "electronics",
                    Image = "https://fakestoreapi.com/img/81Zt42ioCgL._AC_SX679_.jpg",
                    Rate = 2.2,
                    Count = 140
                },
                new Product
                {
                    Title = "BIYLACLESEN Women's 3-in-1 Snowboard Jacket Winter Coats",
                    Price = 56.99M,
                    Description =
                        "Note:The Jackets is US standard size, Please choose size as your usual wear Material: 100% Polyester; Detachable Liner Fabric: Warm Fleece. Detachable Functional Liner: Skin Friendly, Lightweigt and Warm.Stand Collar Liner jacket, keep you warm in cold weather. Zippered Pockets: 2 Zippered Hand Pockets, 2 Zippered Pockets on Chest (enough to keep cards or keys)and 1 Hidden Pocket Inside.Zippered Hand Pockets and Hidden Pocket keep your things secure. Humanized Design: Adjustable and Detachable Hood and Adjustable cuff to prevent the wind and water,for a comfortable fit. 3 in 1 Detachable Design provide more convenience, you can separate the coat and inner as needed, or wear it together. It is suitable for different season and help you adapt to different climates",
                    Category = "women's clothing",
                    Image = "https://fakestoreapi.com/img/51Y5NI-I5jL._AC_UX679_.jpg",
                    Rate = 2.6,
                    Count = 235
                },
                new Product
                {
                    Title = "Lock and Love Women's Removable Hooded Faux Leather Moto Biker Jacket",
                    Price = 29.95M,
                    Description =
                        "100% POLYURETHANE(shell) 100% POLYESTER(lining) 75% POLYESTER 25% COTTON (SWEATER), Faux leather material for style and comfort / 2 pockets of front, 2-For-One Hooded denim style faux leather jacket, Button detail on waist / Detail stitching at sides, HAND WASH ONLY / DO NOT BLEACH / LINE DRY / DO NOT IRON",
                    Category = "women's clothing",
                    Image = "https://fakestoreapi.com/img/81XH0e8fefL._AC_UY879_.jpg",
                    Rate = 2.9,
                    Count = 340
                },
                new Product
                {
                    Title = "Rain Jacket Women Windbreaker Striped Climbing Raincoats",
                    Price = 39.99M,
                    Description =
                        "Lightweight perfet for trip or casual wear---Long sleeve with hooded, adjustable drawstring waist design. Button and zipper front closure raincoat, fully stripes Lined and The Raincoat has 2 side pockets are a good size to hold all kinds of things, it covers the hips, and the hood is generous but doesn't overdo it.Attached Cotton Lined Hood with Adjustable Drawstrings give it a real styled look.",
                    Category = "women's clothing",
                    Image = "https://fakestoreapi.com/img/71HblAHs5xL._AC_UY879_-2.jpg",
                    Rate = 3.8,
                    Count = 679
                },
                new Product
                {
                    Title = "MBJ Women's Solid Short Sleeve Boat Neck V ",
                    Price = 9.85M,
                    Description =
                        "95% RAYON 5% SPANDEX, Made in USA or Imported, Do Not Bleach, Lightweight fabric with great stretch for comfort, Ribbed on sleeves and neckline / Double stitching on bottom hem",
                    Category = "women's clothing",
                    Image = "https://fakestoreapi.com/img/71z3kpMAYsL._AC_UY879_.jpg",
                    Rate = 4.7,
                    Count = 130
                },
                new Product
                {
                    Title = "Opna Women's Short Sleeve Moisture",
                    Price = 7.95M,
                    Description =
                        "100% Polyester, Machine wash, 100% cationic polyester interlock, Machine Wash & Pre Shrunk for a Great Fit, Lightweight, roomy and highly breathable with moisture wicking fabric which helps to keep moisture away, Soft Lightweight Fabric with comfortable V-neck collar and a slimmer fit, delivers a sleek, more feminine silhouette and Added Comfort",
                    Category = "women's clothing",
                    Image = "https://fakestoreapi.com/img/51eg55uWmdL._AC_UX679_.jpg",
                    Rate = 4.5,
                    Count = 146
                },
                new Product
                {
                    Title = "DANVOUY Womens T Shirt Casual Cotton Short",
                    Price = 12.99M,
                    Description =
                        "95%Cotton,5%Spandex, Features: Casual, Short Sleeve, Letter Print,V-Neck,Fashion Tees, The fabric is soft and has some stretch., Occasion: Casual/Office/Beach/School/Home/Street. Season: Spring,Summer,Autumn,Winter.",
                    Category = "women's clothing",
                    Image = "https://fakestoreapi.com/img/61pHAEJ4NML._AC_UX679_.jpg",
                    Rate = 3.6,
                    Count = 145
                }
            );
        }

        context.SaveChanges();
        
        if (!context.Cart.Any())
        {
            context.Cart.AddRange(
                new Cart
                {
                    UserId = 1
                },
                new Cart
                {
                    UserId = 2
                },
                new Cart
                {
                    UserId = 3
                },
                new Cart
                {
                    UserId = 4
                },
                new Cart
                {
                    UserId = 5
                },
                new Cart
                {
                    UserId = 6
                },
                new Cart
                {
                    UserId = 7
                },
                new Cart
                {
                    UserId = 8
                },
                new Cart
                {
                    UserId = 9
                },
                new Cart
                {
                    UserId = 10
                }
            );
        }
        
        context.SaveChanges();

        if (!context.CartProduct.Any())
        {
            context.CartProduct.AddRange(
                new CartProduct
                {
                    CartId = 1,
                    ProductId = 1,
                    Quantity = 4
                },
                new CartProduct
                {
                    CartId = 1,
                    ProductId = 2,
                    Quantity = 1
                },
                new CartProduct
                {
                    CartId = 1,
                    ProductId = 3,
                    Quantity = 6
                },
                new CartProduct
                {
                    CartId = 2,
                    ProductId = 1,
                    Quantity = 2
                },
                new CartProduct
                {
                    CartId = 2,
                    ProductId = 9,
                    Quantity = 1
                },
                new CartProduct
                {
                    CartId = 3,
                    ProductId = 1,
                    Quantity = 4
                },
                new CartProduct
                {
                    CartId = 4,
                    ProductId = 10,
                    Quantity = 2
                },
                new CartProduct
                {
                    CartId = 4,
                    ProductId = 12,
                    Quantity = 3
                },
                new CartProduct
                {
                    CartId = 8,
                    ProductId = 18,
                    Quantity = 1
                }
            );
        }

        if (!context.Order.Any())
        {
            context.Order.AddRange(
                new Order
                {
                    UserId = 1,
                    Date = new DateTime(2020, 01, 02)
                },
                new Order
                {
                    UserId = 3,
                    Date = new DateTime(2020, 03, 01)
                }
            );
        }
        
        context.SaveChanges();

        if (!context.OrderProduct.Any())
        {
            context.OrderProduct.AddRange(
                new OrderProduct
                {
                    OrderId = 1,
                    ProductId = 2,
                    Quantity = 4
                },
                new OrderProduct
                {
                    OrderId = 1,
                    ProductId = 1,
                    Quantity = 10
                },
                new OrderProduct
                {
                    OrderId = 1,
                    ProductId = 5,
                    Quantity = 2
                }
                ,
                new OrderProduct
                {
                    OrderId = 2,
                    ProductId = 7,
                    Quantity = 1
                },
                new OrderProduct
                {
                    OrderId = 2,
                    ProductId = 8,
                    Quantity = 1
                }
            );
        }

        context.SaveChanges();
    }
}