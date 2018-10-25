using Microsoft.EntityFrameworkCore.Migrations;

namespace MoreVideotapesGalore.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Borrows",
                columns: table => new
                {
                    borrowId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    userId = table.Column<int>(nullable: false),
                    videotapeId = table.Column<int>(nullable: false),
                    borrow_date = table.Column<string>(nullable: true),
                    return_date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrows", x => x.borrowId);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    reviewId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    userId = table.Column<int>(nullable: false),
                    videotapeId = table.Column<int>(nullable: false),
                    rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.reviewId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    first_name = table.Column<string>(nullable: true),
                    last_name = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    phone_number = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "Videotapes",
                columns: table => new
                {
                    videotapeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    title = table.Column<string>(nullable: true),
                    director_first_name = table.Column<string>(nullable: true),
                    director_last_name = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true),
                    release_date = table.Column<string>(nullable: true),
                    eidr = table.Column<string>(nullable: true),
                    isRented = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videotapes", x => x.videotapeId);
                });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 1, "2017-04-13", "2017-05-25", 3, 342 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 28, "2015-12-02", null, 91, 718 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 27, "2018-08-01", "2018-09-07", 89, 280 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 25, "2016-05-13", null, 89, 922 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 24, "2016-11-01", null, 79, 17 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 23, "2016-05-15", "2016-06-02", 79, 467 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 22, "2017-10-01", "2017-11-23", 78, 415 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 21, "2016-03-08", "2016-05-11", 67, 641 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 20, "2016-09-17", "2016-10-15", 67, 588 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 19, "2017-02-11", null, 67, 215 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 18, "2017-03-17", "2017-04-05", 62, 335 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 17, "2015-12-15", null, 62, 928 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 16, "2016-04-17", "2016-05-19", 62, 624 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 15, "2016-05-04", null, 34, 134 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 26, "2015-10-03", null, 89, 550 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 13, "2016-02-06", null, 32, 493 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 14, "2016-05-05", null, 32, 274 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 2, "2017-01-08", "2017-03-22", 3, 558 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 4, "2016-02-27", "2016-03-31", 12, 203 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 5, "2017-09-12", "2017-10-04", 12, 839 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 6, "2017-10-22", null, 12, 731 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 3, "2016-08-04", "2016-08-08", 10, 156 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 8, "2018-02-24", null, 17, 724 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 9, "2016-07-17", null, 18, 999 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 10, "2018-06-30", "2018-08-10", 18, 340 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 11, "2016-10-10", "2016-12-13", 19, 50 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 12, "2016-05-21", null, 19, 417 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "borrowId", "borrow_date", "return_date", "userId", "videotapeId" },
                values: new object[] { 7, "2018-03-12", "2018-06-20", 17, 894 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 73, "354 Autumn Leaf Court", "sbosquet20@unesco.org", "Sarina", "Bosquet", "883 379 1736" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 65, "96728 Buena Vista Road", "kyeaman1s@amazon.co.jp", "Knox", "Yeaman", "656 390 8339" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 72, "91584 Alpine Parkway", "aseacroft1z@naver.com", "Angela", "Seacroft", "699 962 9285" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 71, "9 Melrose Trail", "bhyne1y@yellowbook.com", "Birgit", "Hyne", "780 573 0796" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 70, "40 Almo Lane", "rreddy1x@cam.ac.uk", "Roxane", "Reddy", "417 543 9450" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 69, "5049 Ryan Lane", "nmoiser1w@xing.com", "Nikola", "Moiser", "932 128 2273" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 68, "88814 Grover Terrace", "mchrippes1v@bbb.org", "Merell", "Chrippes", "632 229 7225" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 67, "413 Maple Wood Alley", "sbenettelli1u@desdev.cn", "Sigismond", "Benettelli", "569 500 4102" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 66, "1021 Waubesa Drive", "rlekeux1t@senate.gov", "Rolf", "le Keux", "644 106 6716" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 64, "557 Grim Street", "myesenin1r@vimeo.com", "Mack", "Yesenin", "175 486 4455" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 57, "25 Dunning Court", "bpurser1k@ibm.com", "Barron", "Purser", "226 202 9970" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 62, "62 Portage Terrace", "ebransgrove1p@nymag.com", "Evaleen", "Bransgrove", "680 902 4974" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 61, "3023 Green Lane", "brimington1o@cornell.edu", "Brandice", "Rimington", "716 955 9661" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 60, "275 Mosinee Court", "epeppin1n@sfgate.com", "Elton", "Peppin", "698 692 8097" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 59, "4760 Veith Point", "mbackes1m@uol.com.br", "Milissent", "Backes", "855 530 9334" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 58, "6484 Village Pass", "kspilisy1l@phoca.cz", "Keelby", "Spilisy", "424 646 7482" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 56, "45 Maple Wood Junction", "ytopper1j@cisco.com", "Yevette", "Topper", "722 759 3636" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 55, "860 Luster Park", "cgraham1i@statcounter.com", "Claudette", "Graham", "841 623 2385" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 54, "12979 Dexter Court", "bgeggie1h@google.com.br", "Barny", "Geggie", "530 939 9894" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 53, "82874 Muir Place", "agillet1g@meetup.com", "Angela", "Gillet", "755 894 3631" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 74, "41894 Sherman Point", "glugton21@quantcast.com", "Grant", "Lugton", "920 869 3191" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 63, "858 Thierer Park", "lbath1q@prlog.org", "Luke", "Bath", "962 990 0522" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 75, "483 Ridgeview Crossing", "rfrise22@springer.com", "Rozalin", "Frise", "776 252 8334" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 89, "36 Scott Drive", "kogormley2g@woothemes.com", "Kippar", "O'Gormley", "740 676 1502" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 77, "60 Randy Parkway", "jgowan24@imageshack.us", "Jervis", "Gowan", "382 400 8486" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 100, "2928 Badeau Junction", "dnice2r@home.pl", "Del", "Nice", "973 950 4911" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 99, "74893 Loomis Lane", "jfairbanks2q@guardian.co.uk", "Joelynn", "Fairbanks", "560 776 4035" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 97, "62 Steensland Way", "mheel2o@vinaora.com", "Mahmud", "Heel", "780 186 8437" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 96, "341 Northland Parkway", "dsteanyng2n@unesco.org", "Daloris", "Steanyng", "682 243 5362" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 95, "203 Heffernan Park", "tmandrey2m@cornell.edu", "Trenton", "Mandrey", "689 998 2939" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 94, "3655 Fallview Court", "rvacher2l@multiply.com", "Romeo", "Vacher", "315 525 7047" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 93, "3 Glendale Plaza", "irichardes2k@csmonitor.com", "Indira", "Richardes", "960 143 9268" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 92, "3881 Northfield Pass", "khyrons2j@google.es", "Karlen", "Hyrons", "314 756 0428" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 91, "9252 Hallows Parkway", "rsutherden2i@fda.gov", "Raimondo", "Sutherden", "281 428 4690" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 90, "9520 Eliot Avenue", "lletson2h@cyberchimps.com", "Linn", "Letson", "365 469 1422" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 76, "03657 Gateway Way", "zleball23@sun.com", "Zilvia", "Le Ball", "410 679 4651" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 52, "50 Mifflin Trail", "strundell1f@patch.com", "Stesha", "Trundell", "956 777 7350" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 87, "7281 Prairieview Court", "eceyssen2e@merriam-webster.com", "Eadmund", "Ceyssen", "762 413 3797" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 86, "9903 Vidon Plaza", "rbeachamp2d@friendfeed.com", "Renae", "Beachamp", "786 762 0327" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 85, "22537 Nova Court", "ghallard2c@reverbnation.com", "Giovanna", "Hallard", "720 298 4740" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 84, "8160 Blaine Pass", "cdraisey2b@prlog.org", "Constantine", "Draisey", "593 941 2186" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 83, "5859 Anderson Circle", "jrumens2a@cnn.com", "Julio", "Rumens", "710 525 4502" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 82, "66 Carey Crossing", "ndumke29@edublogs.org", "Nevin", "Dumke", "850 671 6523" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 81, "8 Graedel Terrace", "elamblin28@ucoz.com", "Eugenio", "Lamblin", "177 747 9435" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 80, "5 Cascade Place", "msweetmore27@ehow.com", "Marlon", "Sweetmore", "407 254 6300" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 79, "9014 Main Crossing", "ngallardo26@networksolutions.com", "Nils", "Gallardo", "475 294 2722" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 78, "6365 Nelson Pass", "cniset25@businessinsider.com", "Caryn", "Niset", "211 873 8064" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 88, "38 Moulton Center", "mcharlotte2f@mashable.com", "Maighdiln", "Charlotte", "302 550 6284" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 51, "613 Hermina Hill", "lcastagnone1e@gov.uk", "Lanna", "Castagnone", "187 998 0069" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 98, "8329 East Hill", "gspeakman2p@ibm.com", "Gareth", "Speakman", "477 374 5217" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 49, "3238 Mendota Drive", "cpozzi1c@google.de", "Catriona", "Pozzi", "842 965 7263" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 22, "566 Crownhardt Trail", "afilipiakl@jalbum.net", "Alvinia", "Filipiak", "866 172 4708" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 21, "60 Aberg Road", "pdrueryk@columbia.edu", "Prisca", "Druery", "199 831 0859" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 20, "1195 Veith Street", "bbremondj@nydailynews.com", "Bibbie", "Bremond", "532 583 5005" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 19, "1 Laurel Point", "aridwoodi@aol.com", "Amelie", "Ridwood", "156 808 5740" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 18, "4824 Mariners Cove Point", "dodunniomh@acquirethisname.com", "Dre", "O'Dunniom", "370 436 8195" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 17, "62831 Northridge Drive", "zdavysg@mtv.com", "Zondra", "Davys", "456 763 1657" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 16, "18 Glacier Hill Parkway", "gbarkesf@constantcontact.com", "Georgine", "Barkes", "625 849 1018" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 15, "478 Sutteridge Alley", "dmcgarrahane@google.com.hk", "Davey", "McGarrahan", "665 323 6133" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 14, "304 Dovetail Trail", "hpreddyd@flickr.com", "Helsa", "Preddy", "136 918 4763" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 13, "51580 Waywood Junction", "mbelchambersc@psu.edu", "Masha", "Belchambers", "408 478 2150" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 23, "80 Iowa Trail", "rlambethm@virginia.edu", "Reginald", "Lambeth", "520 889 6027" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 12, "91 Hazelcrest Circle", "kebbersb@histats.com", "Krystyna", "Ebbers", "605 473 5297" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 9, "7 Steensland Terrace", "iblue8@ustream.tv", "Inger", "Blue", "524 992 4864" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 8, "444 Montana Trail", "bpetts7@usnews.com", "Bentlee", "Petts", "757 808 9389" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 7, "0 Northland Crossing", "ajeram6@theglobeandmail.com", "Alexandr", "Jeram", "596 156 4767" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 6, "180 Pepper Wood Drive", "gkubelka5@weather.com", "Geri", "Kubelka", "308 762 2181" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 5, "38 Burning Wood Road", "jbenka4@usnews.com", "Jake", "Benka", "758 121 0236" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 4, "48221 Lawn Hill", "slambdon3@squarespace.com", "Shaughn", "Lambdon", "534 915 3848" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 3, "2 Melvin Hill", "goldaker2@theguardian.com", "Giff", "Oldaker", "902 598 8400" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 2, "7 Becker Circle", "achisholme1@hao123.com", "Aylmer", "Chisholme", "826 251 6448" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 1, "57 Eggendart Trail", "rwraith0@drupal.org", "Romain", "Wraith", "156 570 5006" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 50, "3 Gateway Parkway", "salenin1d@github.com", "Sammy", "Alenin", "678 554 5835" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 10, "2 Butterfield Road", "tlarwood9@cocolog-nifty.com", "Tomasine", "Larwood", "340 280 3722" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 24, "94342 Kensington Hill", "scahanin@naver.com", "Shelby", "Cahani", "962 642 3390" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 11, "4 Everett Terrace", "fwartersa@businesswire.com", "Ford", "Warters", "243 795 8123" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 26, "9 Ludington Road", "kcarlissop@pagesperso-orange.fr", "Kaitlynn", "Carlisso", "190 797 7748" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 48, "46 Grasskamp Circle", "lsang1b@cnet.com", "Lorianna", "Sang", "886 432 1073" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 25, "2875 Elgar Parkway", "rgummeo@ehow.com", "Riki", "Gumme", "246 837 7867" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 47, "76 Jackson Point", "ctrenholm1a@clickbank.net", "Carlina", "Trenholm", "861 111 6292" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 46, "66 Florence Terrace", "ddigby19@blogspot.com", "Doralynne", "Digby", "436 813 4449" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 45, "06837 Blue Bill Park Alley", "smorpeth18@mozilla.com", "Sascha", "Morpeth", "204 143 4716" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 44, "5767 Heath Crossing", "esheekey17@cbsnews.com", "Emlyn", "Sheekey", "842 522 4308" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 43, "98580 Lakewood Pass", "tallawy16@merriam-webster.com", "Tierney", "Allawy", "727 145 2082" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 41, "78 Beilfuss Trail", "rknowlson14@rediff.com", "Rosie", "Knowlson", "323 821 5072" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 40, "7 Autumn Leaf Alley", "acassam13@google.pl", "Amity", "Cassam", "461 377 1898" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 39, "6 Granby Drive", "fordemann12@list-manage.com", "Faustine", "Ordemann", "567 246 1822" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 38, "54760 Hauk Avenue", "naleksandrev11@fastcompany.com", "Normie", "Aleksandrev", "543 888 8042" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 42, "7 Monica Point", "lhelder15@imdb.com", "Libbi", "Helder", "759 265 0322" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 37, "986 Hintze Plaza", "sbortolotti10@bizjournals.com", "Stephie", "Bortolotti", "495 380 3529" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 36, "1053 Schmedeman Avenue", "mrockhillz@ameblo.jp", "Mead", "Rockhill", "107 546 6321" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 35, "97 Tennyson Junction", "galteny@businessweek.com", "Gilberto", "Alten", "496 960 6502" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 34, "5520 High Crossing Park", "cfoxx@feedburner.com", "Chan", "Fox", "933 745 6129" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 33, "0892 Holmberg Alley", "rmyfordw@so-net.ne.jp", "Reina", "Myford", "526 730 3888" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 32, "8790 Dunning Drive", "grotheryv@aboutads.info", "Gloriane", "Rothery", "861 624 9262" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 31, "004 Schmedeman Court", "msteanyngu@marketwatch.com", "Morey", "Steanyng", "117 267 0932" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 30, "64 Jenna Circle", "wprielt@google.com.hk", "Walt", "Priel", "253 655 9879" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 29, "4164 Sloan Terrace", "joveys@google.co.uk", "Jeffry", "Ovey", "922 635 8474" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 28, "0 Duke Park", "rcussenr@sciencedaily.com", "Roxi", "Cussen", "474 224 8319" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "address", "email", "first_name", "last_name", "phone_number" },
                values: new object[] { 27, "2104 Kings Road", "scheesworthq@123-reg.co.uk", "Sampson", "Cheesworth", "367 357 0472" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 668, "Johnsey", "Elisabet", "10.5240/9FEE-EEEE-EEEF-FDDF-FFFF-C", false, "1999-04-25", "Assimilated user-facing matrices", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 667, "Slinger", "Hestia", "10.5240/DDEF-F9E5-BFEF-DDEF-FFDF-C", false, "2002-01-16", "Multi-layered fresh-thinking encryption", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 666, "Pitbladdo", "Lilllie", "10.5240/CCEC-EF8E-DFFF-EDFE-EDFE-C", false, "2005-05-04", "Operative scalable capacity", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 665, "Monelle", "Anya", "10.5240/DCFF-FEEF-DFFF-DFFF-FEFE-C", false, "1998-06-17", "Networked executive moratorium", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 664, "Le Pruvost", "Lanae", "10.5240/FFDF-FFFF-EEFF-CFD7-FFEE-C", false, "2011-12-23", "Persistent scalable local area network", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 661, "Brecken", "Helen", "10.5240/EFDB-FBFF-EFEC-8EFD-FD9F-C", false, "2001-10-18", "Triple-buffered optimal project", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 662, "Elson", "Jori", "10.5240/CECF-F9ED-CEFE-EEEF-EEDF-C", false, "1999-01-21", "Pre-emptive discrete migration", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 659, "Bollon", "Ardelis", "10.5240/DEFE-EFBF-EEFF-FBFE-DFFF-C", false, "1997-11-22", "Front-line intangible framework", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 660, "Bamford", "Lenee", "10.5240/EFFF-ECEF-DFDE-FEFF-BFFF-C", false, "2009-03-24", "Implemented methodical projection", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 669, "Gorvin", "Una", "10.5240/FFEF-BFFC-FFFE-FFAF-FFEF-C", false, "1992-01-07", "Reactive zero tolerance projection", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 663, "Smorfit", "Chadd", "10.5240/DECF-FEFF-EFDE-FFFF-BEEF-C", false, "1999-06-11", "Diverse transitional projection", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 670, "Balthasar", "Frederick", "10.5240/AEFF-FFED-EFEE-FFFF-CFFF-C", false, "2018-07-18", "Programmable transitional emulation", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 682, "Matton", "Husain", "10.5240/EEFF-EFDD-FEEF-CECE-FFEE-C", false, "2010-12-01", "Assimilated executive initiative", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 672, "Siddons", "Nataniel", "10.5240/EEFF-FFFF-FE8F-EDF7-ECFE-C", false, "2018-07-25", "Total dynamic budgetary management", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 673, "Coldrick", "Bryn", "10.5240/DFEF-EDBD-BFFE-FEFF-FDEF-C", false, "2012-02-11", "Expanded optimal alliance", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 674, "Echallie", "Oren", "10.5240/FFFD-EFEA-DEFF-FDFF-FFEF-C", false, "2017-01-03", "Realigned optimal process improvement", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 675, "Kedie", "Eleanor", "10.5240/FFFB-8EDF-FEDF-FEFD-FCFF-C", false, "2009-04-15", "Robust secondary hub", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 676, "Courage", "Aloin", "10.5240/FEEC-EFFF-FDFD-FFFD-EFFD-C", false, "1998-12-08", "Synergized impactful capacity", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 677, "Hollows", "Hoebart", "10.5240/DFDB-FEEF-FFEF-ECEE-DFEF-C", false, "2006-09-22", "Proactive composite parallelism", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 678, "Scrymgeour", "Adamo", "10.5240/9DFD-FFFF-FCFE-EFDF-6EFE-C", false, "2014-10-14", "Reactive upward-trending website", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 679, "Seeger", "Sven", "10.5240/F9FF-CDFF-FDFF-FF99-FEFE-C", false, "1990-10-23", "Reverse-engineered next generation internet solution", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 680, "Gaskoin", "Kimberly", "10.5240/FFFE-FFFD-FDEF-FCEF-EDFF-C", false, "2006-12-23", "Innovative actuating capability", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 681, "Siviour", "Melita", "10.5240/FDAE-FFFF-FCDC-FEFF-AFFD-C", false, "2001-04-13", "Front-line local array", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 683, "Mix", "Moe", "10.5240/FFDD-DFFE-EDEF-FFEF-FEFE-C", false, "2013-06-26", "Synergistic bottom-line database", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 684, "MacGorrie", "Sayre", "10.5240/FFEF-FDED-EFEC-FFFE-FFFF-C", false, "2000-04-19", "Multi-layered optimal strategy", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 658, "Greathead", "Tersina", "10.5240/EEFF-FFFF-DEEB-FFFF-FEBE-C", false, "2002-06-26", "Reactive dedicated forecast", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 671, "Quinell", "Geneva", "10.5240/CEFE-EFFE-CEEF-EEDF-FDEF-C", false, "1996-03-23", "Visionary dynamic strategy", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 657, "Burbudge", "Rutherford", "10.5240/FEFF-FFDD-EEFF-FFDE-EFFD-C", false, "1997-10-14", "Extended executive project", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 632, "Caswill", "Mylo", "10.5240/FFFE-FFCF-DFFD-FDEF-FFEE-C", false, "1999-10-17", "Centralized full-range access", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 655, "Hanretty", "Wandie", "10.5240/FDCC-DFEE-FFFE-AEFB-FFFE-C", false, "1995-01-11", "Programmable reciprocal concept", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 627, "Izkovitch", "Bord", "10.5240/FE9F-EDDE-FFFF-FFCF-EEFC-C", false, "2001-05-21", "Assimilated intermediate challenge", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 628, "Kell", "Ulick", "10.5240/BDCE-FFFC-EFEF-EFFC-EFDC-C", false, "1999-05-06", "Down-sized multimedia flexibility", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 629, "Dunbobbin", "Angelle", "10.5240/BFFF-FFCF-FAE9-FEFD-EDEF-C", false, "2012-10-26", "Streamlined next generation productivity", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 630, "Calverley", "Greta", "10.5240/DFFF-FFCC-FEFC-FDDE-FFFC-C", false, "2001-08-06", "Configurable mission-critical initiative", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 631, "Truett", "Guglielmo", "10.5240/EEEF-FCFE-DFEE-FEAE-FFEC-C", false, "2001-06-16", "Adaptive exuding concept", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 685, "Tomblett", "Philbert", "10.5240/E9FE-FEFF-EACF-FDFC-ECFF-C", false, "2014-05-31", "Profound global secured line", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 633, "Hydes", "Corinne", "10.5240/FFFE-ECEF-FEEE-CFFE-FFFF-C", false, "2010-11-03", "Multi-tiered dedicated solution", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 634, "Gulleford", "Angelina", "10.5240/FEFF-CFFF-FFCF-DDFF-EFFF-C", false, "2007-02-08", "Future-proofed even-keeled monitoring", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 635, "Bruckental", "Arlena", "10.5240/FDFF-DFFD-FFDF-FECE-BDDF-C", false, "1999-01-15", "Secured impactful model", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 636, "Blaxley", "Jeana", "10.5240/FDEF-EFEF-EDFE-FCFF-FFFF-C", false, "2005-09-27", "Extended multi-tasking Graphical User Interface", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 637, "Blacker", "Casar", "10.5240/EEFF-EDDE-FEDD-FCBE-DBF8-C", false, "2000-04-05", "Configurable optimizing installation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 638, "Apperley", "Murry", "10.5240/FFEE-EFFF-FFFE-FFDF-DFEF-C", false, "2006-02-26", "User-centric human-resource knowledge base", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 639, "Legrand", "Alic", "10.5240/DECF-DFCE-FBEB-ECEC-EFEF-C", false, "1991-05-17", "Seamless radical toolset", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 656, "Atlee", "Saundra", "10.5240/EDEF-7FEE-ECFF-FAFE-FFF9-C", false, "2000-01-31", "Assimilated intermediate focus group", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 640, "Egle of Germany", "Michal", "10.5240/DFDF-BDEF-FEFE-FEED-FEEF-C", false, "2002-06-29", "Adaptive system-worthy infrastructure", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 642, "Turbill", "Kirbee", "10.5240/FEFD-FEEE-FEFF-EFFF-EFFF-C", false, "2013-01-28", "Function-based reciprocal synergy", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 643, "Sheddan", "Melamie", "10.5240/DEEF-DFFF-EFFF-EFDF-EFFC-C", false, "2013-05-28", "Team-oriented stable database", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 644, "Manueau", "Bette", "10.5240/FEFF-FDFD-EDED-FDDB-FFFC-C", false, "2008-02-11", "Integrated disintermediate matrix", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 645, "Hannant", "Rae", "10.5240/FEFD-EFFF-FFDF-EDFE-FEFF-C", false, "2016-09-06", "Networked fault-tolerant capability", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 646, "Orsman", "Devin", "10.5240/FDFD-FACF-FBFE-FFFF-C8EF-C", false, "1998-01-10", "Profit-focused fault-tolerant neural-net", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 647, "Killough", "Arch", "10.5240/EFFF-CEEF-9EFB-EBCE-FFEE-C", false, "2005-12-01", "Streamlined bifurcated synergy", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 648, "Stickles", "Beverie", "10.5240/FFFE-CFCB-FFFD-FFFD-EEEF-C", false, "2004-02-28", "Realigned solution-oriented model", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 649, "Bayston", "Jillian", "10.5240/FECF-FEFD-EFFF-FFFE-FFFE-C", false, "2017-04-23", "Universal analyzing circuit", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 650, "Espinay", "Darby", "10.5240/8DFF-EEEA-EEFF-CEFD-EE9C-C", false, "1991-08-13", "Future-proofed local info-mediaries", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 651, "Andriuzzi", "Tedie", "10.5240/FEEE-CDEC-FEFE-FECE-FFDF-C", false, "1994-06-20", "Visionary optimizing flexibility", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 652, "Marle", "Freemon", "10.5240/FDFF-AFFB-DFBD-EFEC-EBEC-C", false, "2001-08-18", "Optimized explicit hierarchy", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 653, "Bowmen", "Samuel", "10.5240/FFEF-FFFC-FFEF-FFEF-EAFE-C", false, "2006-03-30", "Cross-group intermediate concept", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 654, "Rome", "Hartwell", "10.5240/EFFF-DEDE-FEFE-CCFE-FEEF-C", false, "2014-11-25", "Cross-platform scalable strategy", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 641, "Pitkaithly", "Erin", "10.5240/FEBE-EEFF-CFEF-FFFE-CEEB-C", false, "2000-07-01", "Multi-channelled maximized array", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 686, "Coules", "Dukey", "10.5240/FEFF-CFFF-FFFF-FDFF-FF8B-C", false, "1992-07-16", "Automated full-range alliance", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 711, "Braybrook", "Mariann", "10.5240/FFFC-EEFF-FEED-DFEE-FFEC-C", false, "2016-08-05", "Function-based mission-critical interface", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 688, "Deverose", "Adelaide", "10.5240/EEFF-FFCF-FFFB-DFEE-FFED-C", false, "2005-11-25", "Proactive asynchronous productivity", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 722, "Gabbidon", "Stephannie", "10.5240/FEFE-EECB-EC9C-EDDC-FDEF-C", false, "2013-08-08", "Configurable regional forecast", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 723, "Ledeker", "Jameson", "10.5240/EDFE-DFFF-EFDD-EFDE-FFFC-C", false, "1997-06-19", "Customizable uniform knowledge base", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 724, "Pleass", "Clarie", "10.5240/FDAE-EFED-FFFF-FCFF-CFBF-C", true, "2002-03-24", "Cloned tertiary concept", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 725, "Nilges", "Brigid", "10.5240/EAFE-FEEF-DFFF-BBEF-DEEF-C", false, "1999-08-09", "Grass-roots non-volatile toolset", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 726, "Goggins", "Max", "10.5240/EEEF-FEFD-FFEF-FFFD-DFFE-C", false, "2007-03-25", "Synchronised leading edge open architecture", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 727, "Fielders", "Clayborne", "10.5240/FEFE-FFFE-FFCE-FFFC-FEDD-C", false, "2016-11-30", "Diverse clear-thinking hub", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 728, "Malthus", "Murry", "10.5240/FFFE-CFFE-FFFE-EEED-FFFE-C", false, "2016-01-03", "Optimized mobile migration", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 729, "Skeermor", "Debera", "10.5240/CFCF-DFFE-EEFF-FDDE-FFFE-C", false, "2017-09-20", "Fully-configurable dynamic forecast", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 730, "Hoogendorp", "Erma", "10.5240/DEEE-EFFF-FFFE-BFED-CEFF-C", false, "2007-06-20", "Mandatory demand-driven open system", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 731, "Fratczak", "Teodor", "10.5240/BEEF-DEFF-FFDE-EEEE-FFED-C", true, "2012-05-30", "Profound multimedia productivity", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 732, "Davydenko", "Erena", "10.5240/FFEF-CFBC-EFEF-FFFE-FFFF-C", false, "2002-05-31", "Configurable next generation encryption", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 733, "Hulett", "Melesa", "10.5240/EECF-EDFC-FFDF-EFFE-FFEF-C", false, "2016-04-08", "Persevering holistic contingency", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 734, "Kenwood", "Mal", "10.5240/FDFE-CFEC-FEFF-FEEC-FFBD-C", false, "2018-04-04", "Synergized intangible matrices", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 735, "Kelk", "Christy", "10.5240/EFFE-FFEF-FFDF-FFFF-CFFE-C", false, "2014-01-07", "Team-oriented content-based intranet", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 736, "Aujean", "Fielding", "10.5240/DAFC-DEDE-FFFF-FFFE-EEEF-C", false, "2016-01-28", "Persevering upward-trending database", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 737, "MacCorley", "Noel", "10.5240/CFEF-EDEF-FEFF-FEFD-FFFE-C", false, "2004-08-12", "Organic upward-trending process improvement", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 738, "Seefeldt", "Lilith", "10.5240/FCFF-EFBF-DAFE-FEEF-EEFC-C", false, "2017-09-04", "Programmable bottom-line toolset", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 739, "Minchinton", "Rickard", "10.5240/FFFF-F98C-FFFE-EADF-DFDC-C", false, "2006-01-22", "Streamlined 3rd generation model", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 740, "Cantillon", "Vernon", "10.5240/FFFF-FEEF-FCEE-FFFF-FFEF-C", false, "1998-03-26", "De-engineered zero tolerance archive", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 741, "Roj", "Salome", "10.5240/FFEE-FDDE-FFFF-FDFF-EFFD-C", false, "2003-05-31", "Distributed tangible internet solution", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 742, "Elstub", "Krystle", "10.5240/F9ED-DEDD-FFFB-DCAD-FEFF-C", false, "2007-11-21", "De-engineered encompassing product", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 743, "Burke", "Claudine", "10.5240/CEEF-DFEE-FDFD-BEED-DFDF-C", false, "2008-02-11", "Optimized zero tolerance secured line", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 744, "Roman", "Laurella", "10.5240/EABF-FFFF-EFFC-FFEE-CFFF-C", false, "1995-01-21", "Reactive real-time adapter", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 745, "Bottrill", "Jackie", "10.5240/FDEE-FFFF-EFEF-FBFD-DEEE-C", false, "1991-05-13", "Profound intermediate focus group", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 746, "Toppas", "Thatch", "10.5240/EEFF-FEDF-FCFF-FFEF-FF8F-C", false, "1994-04-26", "Synchronised heuristic pricing structure", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 747, "Ticehurst", "Harper", "10.5240/EBFF-FFCE-FDFD-DCFF-EEEF-C", false, "2003-11-09", "Self-enabling motivating attitude", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 626, "Haet", "Grayce", "10.5240/EEFB-FFBF-FBEE-FFEF-EEFF-C", false, "2008-07-02", "Operative fault-tolerant project", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 721, "Heinlein", "Sidonnie", "10.5240/FEFF-EFFF-DECF-FFEF-ECFE-C", false, "2009-11-27", "Operative zero tolerance access", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 720, "Garahan", "Mil", "10.5240/FFC9-FFFF-96FF-EFED-FEFF-C", false, "2017-11-29", "Down-sized foreground parallelism", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 719, "McGilvray", "Brandise", "10.5240/DFBF-DCFF-ADFE-CDFF-FAAF-C", false, "2009-01-12", "Proactive holistic data-warehouse", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 718, "Balham", "Kimberly", "10.5240/FCFF-FFFF-FFEF-FFED-FFFF-C", true, "1990-12-06", "Multi-channelled value-added benchmark", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 689, "Gilvary", "Shurlocke", "10.5240/FCFF-FFEF-EBFE-FEFE-FCDE-C", false, "2008-07-13", "Configurable explicit neural-net", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 690, "Boulter", "Taylor", "10.5240/EFCF-FFFE-EBED-CF8D-FDFE-C", false, "2010-05-24", "Innovative foreground time-frame", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 691, "Pendlenton", "Binni", "10.5240/FEFF-FEDF-FFEF-FFFF-FFFD-C", false, "2006-12-31", "Cloned upward-trending success", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 692, "Pelman", "Anabal", "10.5240/FFFB-FFDD-DEFE-FDFF-EEEF-C", false, "2013-05-08", "Pre-emptive impactful benchmark", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 693, "Dingley", "Arabele", "10.5240/FFFF-EFED-EFFF-FFFB-EFFE-C", false, "2014-05-22", "Persevering coherent internet solution", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 694, "Joppich", "Klaus", "10.5240/EDFE-FDF9-FCEF-FCFF-EBFD-C", false, "2013-12-31", "Adaptive zero administration neural-net", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 695, "McDarmid", "Morganica", "10.5240/FFFE-CEFE-CFEF-FEFB-FCBE-C", false, "2013-02-18", "Automated needs-based forecast", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 696, "Beere", "Carce", "10.5240/BDFC-EDFF-DEEF-FFEF-EEFF-C", false, "2012-10-13", "Reduced 5th generation open system", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 697, "Rolinson", "Brennen", "10.5240/DFBF-FECF-DDFF-ECDF-FFFC-C", false, "2015-08-19", "Assimilated value-added installation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 698, "Hainge", "Nicol", "10.5240/FFFC-FDFE-DDFF-FFEF-FFDE-C", false, "2009-06-13", "Triple-buffered transitional parallelism", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 699, "MacCurtain", "Hodge", "10.5240/DFFF-FEDF-EDDF-EFFE-FFFE-C", false, "2004-02-05", "Object-based non-volatile benchmark", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 700, "Wellstead", "Rhody", "10.5240/D8EF-F6EE-EFEE-FDFE-FDDF-C", false, "2015-10-05", "Programmable content-based function", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 701, "Gudeman", "Dorothea", "10.5240/FCEF-CDFE-EFED-CBFF-EFFE-C", false, "1993-12-12", "Synchronised clear-thinking capacity", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 687, "Breston", "Mendy", "10.5240/DFDF-FFEE-FEFF-FFEE-AEEE-C", false, "2012-09-01", "Face to face non-volatile synergy", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 702, "Pigden", "Sigismund", "10.5240/EDFF-DEEF-7EFD-FDFF-FFFF-C", false, "2006-11-18", "Re-engineered content-based installation", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 704, "Jodlkowski", "Bert", "10.5240/CEFF-EFCF-FFFF-FDFD-EFFE-C", false, "2007-11-01", "Synergistic homogeneous service-desk", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 705, "Sweedland", "Terrell", "10.5240/CDCF-EDDF-DDEF-DFCB-FCFF-C", false, "2015-01-07", "Team-oriented 24 hour infrastructure", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 706, "Henriet", "Harlie", "10.5240/EFFF-EFFF-CFCF-DFDD-EDFB-C", false, "2012-07-06", "Grass-roots solution-oriented parallelism", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 707, "Courvert", "Shane", "10.5240/FCEE-FDFE-CFFF-FEEE-EEFF-C", false, "2010-08-01", "Future-proofed holistic function", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 708, "Braundt", "Bev", "10.5240/DFCD-FFFF-FEEE-EBEF-BFFC-C", false, "1998-07-20", "Assimilated radical success", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 709, "Showler", "Herta", "10.5240/FBEF-EAFE-FFFD-ECFB-C9FE-C", false, "2002-05-16", "Cloned even-keeled encoding", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 710, "Vasyutochkin", "Millicent", "10.5240/FFFC-FFFE-AFEF-CBCD-FFFE-C", false, "1993-05-26", "Visionary tertiary ability", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 712, "Puttan", "Jillene", "10.5240/FFFE-EFFF-FFEE-FFFE-CFEE-C", false, "2014-04-21", "Streamlined clear-thinking initiative", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 713, "Ivanonko", "Rodi", "10.5240/EBDF-EEEE-FEDE-FFFD-EEBE-C", false, "2008-11-13", "Diverse tertiary benchmark", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 714, "Lenchenko", "Willard", "10.5240/FFEE-CECE-FFFD-FDCF-FAEF-C", false, "2014-02-19", "Future-proofed intangible installation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 715, "Sangwin", "Suzanna", "10.5240/FFFF-FFFC-FFAC-CFDF-FCEF-C", false, "1991-12-17", "Function-based stable moratorium", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 716, "Jedrzejewski", "Friedrich", "10.5240/FEDF-ECFD-FDFF-DFEE-CFFC-C", false, "2016-05-13", "Inverse demand-driven application", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 717, "Bugdale", "Cherish", "10.5240/EFFE-DEFF-FFEF-FFFE-FE8F-C", false, "2003-02-13", "Phased motivating database", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 703, "Barnewille", "Florance", "10.5240/EFFC-EEEC-CFFF-EFFF-FEFE-C", false, "1993-04-10", "Pre-emptive multi-state hub", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 625, "Gipps", "Fiona", "10.5240/FAFF-FCFE-F9FF-FFFF-FFDF-C", false, "2003-11-02", "Compatible mission-critical hardware", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 561, "Primak", "Mortie", "10.5240/ECC7-FEFE-FFEF-FFEF-FFFB-C", false, "2014-12-24", "Multi-channelled grid-enabled analyzer", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 623, "Jolly", "Nehemiah", "10.5240/FCCF-9AAD-CFFF-FFFE-ECFE-C", false, "2008-05-19", "Focused responsive customer loyalty", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 533, "Siene", "Anna-maria", "10.5240/EEFE-DEEF-FFEF-FFFF-DEEF-C", false, "1998-08-29", "Automated transitional budgetary management", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 534, "Sander", "Trixi", "10.5240/EEFE-FEAF-EFFF-CFFF-FEEF-C", false, "2003-01-15", "Down-sized attitude-oriented installation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 535, "Franklyn", "Temp", "10.5240/FFFF-EFDE-FEEF-FFFF-AFFF-C", false, "1999-05-15", "Multi-layered next generation time-frame", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 536, "Duckitt", "Doralynn", "10.5240/FFFE-EFFE-DFEF-EFED-FEEF-C", false, "2003-11-21", "Stand-alone non-volatile orchestration", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 537, "Nurcombe", "Towny", "10.5240/EFFF-FFFF-FFEB-FFFD-EDDD-C", false, "2014-10-08", "User-friendly local migration", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 538, "McPartling", "Dante", "10.5240/FEEF-FDCF-FFED-EFFF-DCFF-C", false, "2003-12-02", "Inverse bottom-line framework", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 539, "Sawney", "Brendon", "10.5240/EFFE-FFDE-BFEE-9EFE-CF8F-C", false, "2016-02-01", "Devolved holistic functionalities", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 540, "Negri", "Blithe", "10.5240/FFCF-DEFF-FFFE-AFDF-EFCF-C", false, "1995-04-26", "Enhanced encompassing artificial intelligence", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 541, "Bowkley", "Julian", "10.5240/FEFC-FFF8-EEEF-FFEE-DEEF-C", false, "2017-02-15", "Quality-focused user-facing groupware", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 542, "Biggins", "Esmeralda", "10.5240/FFDF-FFFF-FFEE-FEFE-EFFE-C", false, "2003-12-17", "Enhanced multi-tasking forecast", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 543, "Wasling", "Kennan", "10.5240/EEE8-FFFE-FEEF-CFDF-EFDE-C", false, "2010-12-20", "Reverse-engineered empowering intranet", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 544, "Korneichuk", "Stephenie", "10.5240/FDFF-FFEE-DEFF-BDFE-FCAF-C", false, "2000-09-07", "Public-key directional methodology", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 545, "Newell", "Inglebert", "10.5240/BFEF-FFEF-FEBE-DFFF-DFEF-C", false, "2012-02-04", "Distributed solution-oriented circuit", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 546, "Lemerie", "Zedekiah", "10.5240/EEFC-FAFF-FFEE-FEB9-FECE-C", false, "2010-02-01", "Team-oriented stable secured line", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 547, "Chasmoor", "Virginie", "10.5240/F9FF-FFED-FBFE-FBDF-9FFB-C", false, "1999-02-11", "Vision-oriented user-facing info-mediaries", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 548, "Whild", "Lester", "10.5240/EEED-FFDE-EEBF-FFFF-DEEE-C", false, "2006-11-01", "Focused zero tolerance conglomeration", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 549, "Swindlehurst", "Georgeta", "10.5240/FDFF-FFEE-EFFE-DBFF-DEEC-C", false, "2009-03-02", "Organized bandwidth-monitored support", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 550, "Sancto", "Andres", "10.5240/EBEF-EFFF-FFFF-FFDE-FDFF-C", true, "2006-04-16", "Balanced full-range website", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 551, "Garrals", "Lottie", "10.5240/EFFF-AFFF-FDFF-FF9D-FAFF-C", false, "1992-09-12", "Seamless disintermediate emulation", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 552, "Jodlkowski", "Pet", "10.5240/CCFF-FBDF-DEFF-BDEF-ECFE-C", false, "1998-05-29", "Reduced exuding portal", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 553, "McGinny", "Colman", "10.5240/DCEF-FFFF-FDFF-EBFE-CEFF-C", false, "1998-11-11", "Optimized incremental archive", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 554, "Leal", "Chaddie", "10.5240/EFFE-EDCF-EFDF-EEBF-FFAF-C", false, "2009-01-08", "Front-line maximized solution", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 555, "Marin", "Adda", "10.5240/FFCF-BEFE-FDFC-FCFF-FFDB-C", false, "1991-06-07", "Programmable demand-driven process improvement", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 556, "Chesser", "Umeko", "10.5240/FFEE-EFFF-BAEF-BEDF-FFFF-C", false, "1996-03-14", "Multi-tiered tertiary capacity", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 557, "Cleghorn", "Lishe", "10.5240/DCAD-FFDF-BFFF-CFEF-CDEF-C", false, "2009-12-19", "Customizable bifurcated circuit", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 558, "Mateja", "Sebastiano", "10.5240/CFFF-FCEE-DEEE-FEFE-FFEF-C", false, "2016-10-04", "Self-enabling user-facing throughput", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 559, "Longbottom", "Ekaterina", "10.5240/FFDF-FEFE-EFFF-EFDD-EEAE-C", false, "2012-04-07", "Integrated user-facing monitoring", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 532, "Kelling", "Harwilll", "10.5240/AFFA-FEEE-FFDF-EDCD-EFAF-C", false, "2015-06-16", "Face to face executive encryption", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 560, "O'Ferris", "Aguistin", "10.5240/8EEF-9FEF-FAFE-FFED-EFFF-C", false, "2015-11-24", "Enhanced analyzing adapter", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 531, "Gooderidge", "Isabel", "10.5240/EFFF-FFFE-FCBF-DDFF-FDBF-C", false, "2007-12-11", "Cloned content-based array", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 529, "Bertomeu", "Nerita", "10.5240/FDFF-EFFF-FFEF-FBFF-FFFA-C", false, "1993-04-30", "Streamlined cohesive protocol", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 502, "Lindenboim", "Corrina", "10.5240/DFED-DFFE-FFFD-FFEF-FCBF-C", false, "2002-06-05", "Quality-focused human-resource capability", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 503, "Duignan", "Cathie", "10.5240/FEFE-DE8E-FDFF-ECEF-ECEE-C", false, "2014-05-20", "Assimilated didactic extranet", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 504, "Crozier", "Ruddy", "10.5240/FEDE-EEEF-FFFF-CFFA-EEBF-C", false, "2009-01-10", "Phased user-facing approach", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 505, "Ahern", "Gwyneth", "10.5240/ADFE-EEEB-FFFE-EFDE-FFFD-C", false, "2002-03-04", "Re-contextualized interactive approach", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 506, "Tieman", "Garrik", "10.5240/EFFF-FF9E-EEFF-EFFF-EFFC-C", false, "2007-05-29", "Synchronised empowering monitoring", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 507, "Starkings", "Cindy", "10.5240/EFCE-EEFF-FFDF-EDEF-EFFE-C", false, "1993-12-02", "Distributed zero tolerance emulation", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 508, "Bare", "Eberhard", "10.5240/ECEF-FFEE-FF9E-FFFF-ECFF-C", false, "2015-04-30", "Streamlined client-server time-frame", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 509, "Defond", "Roxanne", "10.5240/FFFB-DEFE-EEFF-DFFE-CFCD-C", false, "1992-03-15", "Realigned context-sensitive model", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 510, "Riglar", "Veda", "10.5240/DEDF-BFDF-FEEF-DFFD-DFFD-C", false, "2018-03-14", "Front-line optimal toolset", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 511, "Maxwaile", "Christoper", "10.5240/FFFF-FBFB-FFCD-FEEF-CDDD-C", false, "1996-08-02", "Configurable attitude-oriented benchmark", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 512, "Berthouloume", "Thaddus", "10.5240/FEFE-FDFC-FFAE-EDEF-FEFD-C", false, "1999-04-08", "Robust analyzing time-frame", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 513, "Drayson", "Libbey", "10.5240/FEFE-CFEF-DE9F-DADF-DCFF-C", false, "1995-11-11", "Reverse-engineered full-range strategy", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 514, "Baccus", "Imogene", "10.5240/FDFE-EEFA-EEFE-FCFF-DEBF-C", false, "2003-05-20", "Team-oriented well-modulated solution", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 515, "Ludye", "Devinne", "10.5240/EEFF-FFDF-FEEE-FDFE-EFAD-C", false, "1991-01-06", "Reduced tertiary neural-net", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 516, "Guitton", "Jasen", "10.5240/EFEF-FEEA-BEFD-BAE3-FEEF-C", false, "1998-03-03", "Balanced zero administration archive", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 517, "Piecha", "Chrissy", "10.5240/BFFF-FFFF-EFFF-EFFE-FDDF-C", false, "1995-10-03", "Cloned asynchronous parallelism", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 518, "Yegorshin", "Ruddie", "10.5240/EDED-FFDC-EFFF-EBFE-ECCF-C", false, "2002-11-10", "Customer-focused 24/7 capability", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 519, "Howford", "Innis", "10.5240/FFFF-FFFC-FFCF-CEEC-FFFF-C", false, "1995-01-09", "Synchronised heuristic productivity", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 520, "Crowden", "Doreen", "10.5240/FEEF-CFE9-FDFD-FFEC-DDFF-C", false, "2015-10-28", "Proactive uniform product", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 521, "Stitt", "Sonny", "10.5240/FFCB-DFEF-EFFE-EFEF-FECC-C", false, "1996-08-27", "Upgradable mission-critical conglomeration", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 522, "Brookes", "Martin", "10.5240/FECF-FEEE-F8FF-EFDF-FFFF-C", false, "1990-12-20", "Switchable discrete project", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 523, "Goodisson", "Eduino", "10.5240/FDEF-FFEE-FFFF-EFEF-CFBE-C", false, "1998-10-25", "Exclusive clear-thinking implementation", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 524, "Bingall", "Sabrina", "10.5240/EBFA-FFFB-FDEF-EFDD-CFFD-C", false, "1994-07-27", "Reverse-engineered zero tolerance hierarchy", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 525, "MacAndrew", "Rebekkah", "10.5240/EFEF-AFCC-FEFF-9DEB-FEFE-C", false, "2015-09-07", "Public-key holistic firmware", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 526, "Ayree", "Broderic", "10.5240/FFAF-FF6F-FCEE-EFEE-EFCB-C", false, "1999-11-16", "Object-based bottom-line function", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 527, "Sedman", "Gipsy", "10.5240/FF8C-FEFE-FDFB-CCFF-FEEF-C", false, "2010-02-19", "Grass-roots secondary internet solution", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 528, "Hounsham", "Elisa", "10.5240/EBFF-EFEF-ECEE-FEFE-FECF-C", false, "2007-06-07", "Vision-oriented background frame", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 530, "Ortega", "Kerrin", "10.5240/FFFC-DFFF-FFFC-FDFC-FBFF-C", false, "1995-06-29", "Devolved transitional definition", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 748, "Keaveny", "Jody", "10.5240/DCDF-CCEF-FDEF-ECCF-FFFF-C", false, "2007-08-21", "Triple-buffered zero defect system engine", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 562, "Bartolijn", "Hestia", "10.5240/FDFF-EFBD-EFFD-BDBE-FFCF-C", false, "2009-11-27", "Monitored next generation workforce", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 563, "Veness", "Analise", "10.5240/FDFF-FDDF-BFFC-DFDF-DCFC-C", false, "2001-05-15", "Seamless foreground adapter", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 596, "Palke", "Suzanne", "10.5240/FEFC-BC8F-FFFF-FDDF-ECFD-C", false, "1991-11-18", "Reverse-engineered explicit info-mediaries", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 597, "Reinisch", "Mabelle", "10.5240/EFBF-9DEE-FBEF-DEEF-FEFE-C", false, "2005-04-26", "Business-focused human-resource encoding", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 598, "Courage", "Reggy", "10.5240/FE9E-EEFD-CFDF-FFFD-FDFD-C", false, "2018-02-04", "Implemented 5th generation help-desk", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 599, "Matias", "Ashlie", "10.5240/DFFF-EFDE-CFEF-FFEF-FFFF-C", false, "2008-07-28", "Focused uniform array", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 600, "Radford", "Robb", "10.5240/EFCE-EFEF-EFFE-FC7F-B8EB-C", false, "1992-03-13", "Front-line executive encryption", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 601, "Deane", "Briana", "10.5240/CFFE-CECD-FEEF-EEFC-FEFF-C", false, "2012-02-23", "Synchronised zero administration circuit", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 602, "McMyler", "Chuck", "10.5240/FEEF-FFFD-DEFF-FCFF-FEEF-C", false, "2007-05-17", "Robust asynchronous paradigm", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 603, "Lambillion", "Chan", "10.5240/FFFF-CEDF-FDEF-DEFF-FCDF-C", false, "2001-06-15", "Front-line zero defect access", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 604, "Tieman", "Biron", "10.5240/CDFF-BFEA-CAFF-DDFA-FBEC-C", false, "2002-07-07", "User-friendly national core", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 605, "Joscelin", "Xavier", "10.5240/FDFC-EEEE-DDFF-FFEC-FDFF-C", false, "2002-04-23", "Multi-tiered empowering service-desk", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 606, "Henbury", "Porter", "10.5240/BDFE-EFFE-DDEA-BFBC-FBDF-C", false, "2006-10-09", "Reactive tangible knowledge base", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 607, "Stockings", "Crystie", "10.5240/9FFE-FFFE-EFFF-AEFF-FEFF-C", false, "1995-03-01", "Open-architected reciprocal forecast", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 608, "Dungey", "Bentley", "10.5240/EBDF-7EFE-FFEF-FFD9-FAEF-C", false, "2009-12-31", "Face to face systematic service-desk", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 609, "Altamirano", "Rustie", "10.5240/EFFF-FFFF-FDFF-FEDC-EDFF-C", false, "2013-01-01", "Optional motivating throughput", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 610, "De Cruce", "Randy", "10.5240/EFFE-CCDE-DFCE-DEEE-DEBF-C", false, "2018-08-07", "Front-line fresh-thinking definition", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 611, "Bruhn", "Peter", "10.5240/FFFB-DCFF-EFFF-FFFF-FFD8-C", false, "2010-12-04", "Business-focused systemic alliance", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 612, "Scorrer", "Birgit", "10.5240/FFFF-EFDF-DF9F-ABFF-FFFF-C", false, "2007-04-26", "Operative upward-trending collaboration", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 613, "Fruchon", "Starlene", "10.5240/FEFD-FFEF-FCFF-DEFF-EEEF-C", false, "2002-05-22", "Balanced 24/7 budgetary management", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 614, "Ramsden", "Louie", "10.5240/FDDF-FDFE-EFFE-FFD9-CCEF-C", false, "2000-05-09", "Decentralized actuating intranet", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 615, "Lindenbluth", "Trudie", "10.5240/FEFF-EDED-FDFA-DFFF-FFFC-C", false, "1993-06-21", "Vision-oriented multi-tasking solution", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 616, "Danslow", "Hagan", "10.5240/FCFF-EFFE-FEFF-FBFE-FFDE-C", false, "1999-01-01", "Multi-channelled empowering capacity", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 617, "Doble", "Lindsey", "10.5240/FEED-CFFE-FADF-FFEC-FFED-C", false, "1995-12-23", "Assimilated national strategy", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 618, "MacTrusty", "Lewiss", "10.5240/FFEE-FEFF-FCFF-FFDF-DEED-C", false, "2001-08-21", "Reduced client-server interface", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 619, "Daughtry", "Devon", "10.5240/FDBF-FEFF-EEED-EEEE-BEF9-C", false, "2011-08-09", "Down-sized impactful support", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 620, "Brabbins", "Olive", "10.5240/CFDF-DFDE-FFFE-FFFE-FCFC-C", false, "2016-12-10", "Reduced zero administration local area network", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 621, "Erni", "Barnebas", "10.5240/FEFF-FFEE-FFFF-FEEF-FCEF-C", false, "2006-10-17", "Persevering grid-enabled knowledge base", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 622, "Gentile", "Matthus", "10.5240/DFCF-F9FE-DFEF-FFFF-FEDF-C", false, "2011-11-28", "Sharable attitude-oriented workforce", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 595, "Trebilcock", "Iago", "10.5240/FFEE-EBE7-DFFC-AEFE-EDEA-C", false, "2009-05-27", "Ameliorated optimizing data-warehouse", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 594, "Gatcliff", "Beverlie", "10.5240/EADF-FEDE-FFAF-EEED-F9DE-C", false, "1997-09-29", "Open-source systemic matrix", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 593, "Somersett", "Corbet", "10.5240/EDEF-DFCE-DEDD-DFDC-EFEF-C", false, "2008-03-21", "Extended dynamic task-force", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 592, "O'Shiel", "Kelley", "10.5240/CEFF-DDFE-FFED-BCFF-F9E8-C", false, "1999-02-07", "Devolved grid-enabled adapter", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 564, "Arnke", "Kristien", "10.5240/DFEE-FEFA-DDFC-FEDE-FDFD-C", false, "2008-12-29", "Horizontal upward-trending Graphic Interface", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 565, "Bellhanger", "Betty", "10.5240/FCDF-FFEF-FFFE-EEEE-FFFE-C", false, "2015-01-12", "Focused hybrid task-force", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 566, "Selley", "Linzy", "10.5240/EEFF-FDDD-CFEE-FFFD-FFFE-C", false, "2010-01-31", "Customer-focused global project", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 567, "Barwick", "Kayley", "10.5240/DBDF-FFBE-FFFF-CFFF-7EEE-C", false, "1999-09-09", "Adaptive needs-based flexibility", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 568, "Waite", "Larine", "10.5240/FFFE-FFEF-FDBA-FFDF-CFF9-C", false, "2017-10-01", "Operative context-sensitive toolset", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 569, "Copozio", "Daphene", "10.5240/FECF-FFFF-FDFF-EFFE-FEDE-C", false, "2005-09-01", "Profit-focused impactful array", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 570, "Halworth", "Brittani", "10.5240/EEDF-FFEB-DFCF-DFDE-BBF9-C", false, "2013-11-14", "Profound background open architecture", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 571, "Kilius", "Raphael", "10.5240/EFEF-EEEF-EFFE-FDEF-EFCF-C", false, "2012-12-13", "Versatile 5th generation contingency", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 572, "Mower", "Axel", "10.5240/FFFF-DFDD-FDDF-DFFE-FFFF-C", false, "1994-11-04", "Synchronised heuristic structure", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 573, "Allen", "Valerie", "10.5240/EFEF-FFCF-EFFE-AFFF-EFFF-C", false, "2000-12-16", "Programmable radical internet solution", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 574, "Heinig", "Joshua", "10.5240/EFDE-FFDE-EEDE-EEDE-FEFF-C", false, "2016-03-25", "Focused uniform task-force", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 575, "Corsan", "Thorsten", "10.5240/FCFF-FFFF-DFFF-DFEE-DFCF-C", false, "2018-03-27", "Synergized empowering internet solution", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 576, "Gisbey", "Evan", "10.5240/FEDE-DCEF-FFDE-CEEF-FEFA-C", false, "2001-07-04", "Customer-focused contextually-based artificial intelligence", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 624, "Yushankin", "Cordula", "10.5240/FFFD-CFFF-FFFF-FEFF-FFFC-C", false, "2018-06-05", "De-engineered multi-state knowledge user", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 577, "Syphas", "Minne", "10.5240/FFFC-BCEF-FCE9-EFFF-EEFB-C", false, "1992-11-27", "Re-contextualized 6th generation productivity", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 579, "Munkley", "Kaitlyn", "10.5240/EFAF-FFC7-EFFF-FDEF-FFEF-C", false, "1990-09-07", "Implemented tertiary model", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 580, "Cracie", "Donia", "10.5240/BFCF-EFFD-CFEF-FFDB-FEFF-C", false, "2013-06-18", "Function-based well-modulated analyzer", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 581, "Ship", "Padriac", "10.5240/EFFE-EBDF-EEEE-FFDF-DEEE-C", false, "2013-07-26", "Up-sized bi-directional secured line", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 582, "Corday", "Stace", "10.5240/FEFF-FFFF-FDFF-CFFF-FFEE-C", false, "2009-07-12", "Universal optimal function", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 583, "Korneichik", "Gretna", "10.5240/FFCE-EFCD-EFFE-ECEF-FFEF-C", false, "2017-09-29", "Ergonomic solution-oriented toolset", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 584, "Stanluck", "Armand", "10.5240/FBCF-FDEF-DEFE-BEFE-EFEF-C", false, "1995-10-31", "Visionary directional product", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 585, "Samsworth", "Tisha", "10.5240/EAFF-ECEE-ECEF-EEFF-CDAE-C", false, "2014-11-03", "Exclusive zero defect infrastructure", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 586, "Ellison", "Benyamin", "10.5240/DEFC-EEED-E9BD-DDFC-FEFD-C", false, "1995-08-23", "Configurable human-resource open system", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 587, "Selbie", "Angeline", "10.5240/FFFD-FFFF-DDFB-DEBF-DFCE-C", false, "2001-09-23", "Up-sized solution-oriented help-desk", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 588, "Colloby", "Shaughn", "10.5240/DFEF-DFFC-8FEF-DECE-FFFF-C", false, "1990-11-04", "Synchronised clear-thinking matrices", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 589, "McBeth", "Delainey", "10.5240/CFFF-DEDE-FFFF-CFED-EEEF-C", false, "2016-06-10", "Self-enabling zero tolerance adapter", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 590, "Tournie", "Kizzee", "10.5240/DFEF-FDFD-DFFB-FEFE-DFFE-C", false, "2005-02-25", "Pre-emptive mobile methodology", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 591, "Angeau", "Denys", "10.5240/BBFE-FBEB-FFFE-FFFD-CEFF-C", false, "1995-02-10", "Customer-focused 24/7 open system", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 578, "Thurman", "Lev", "10.5240/FFEF-DDFF-FEFE-EFFE-CFFF-C", false, "1992-02-19", "Expanded user-facing process improvement", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 749, "Simpkin", "Royce", "10.5240/EFEE-DBDF-EFDF-FDFF-FBEF-C", false, "2016-09-24", "Customer-focused national utilisation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 813, "Espinos", "Umeko", "10.5240/FFFF-DCDA-DFEF-FFBE-FFFF-C", false, "1990-12-20", "Reduced system-worthy superstructure", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 751, "Cunney", "Veriee", "10.5240/CFFE-FFFE-EFEF-FFFF-FCFF-C", false, "1998-11-18", "Robust client-server complexity", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 909, "Eake", "Gilda", "10.5240/FEDD-DFED-FFDE-EFFF-FFFC-C", false, "2018-05-11", "Multi-channelled fault-tolerant customer loyalty", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 910, "Cockney", "Lynnell", "10.5240/BEFF-EEAE-FFFD-FDFF-BFFB-C", false, "2012-10-18", "Customizable neutral secured line", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 911, "Mee", "Archibold", "10.5240/FFDF-FFFA-EFFF-ECFF-DDEF-C", false, "1995-01-26", "Decentralized mission-critical knowledge base", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 912, "Olivet", "Archie", "10.5240/FFFD-CDFE-EDEC-FFEF-FFFD-C", false, "1992-04-19", "Programmable neutral collaboration", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 913, "Brion", "Aurora", "10.5240/9EEB-DEEF-FFFF-EDFE-DEEE-C", false, "2008-01-16", "Stand-alone leading edge standardization", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 914, "Mccaull", "Rhianna", "10.5240/FEFE-8DEA-DFFF-FEDE-FFDF-C", false, "1996-09-04", "Proactive fault-tolerant task-force", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 915, "Goodwyn", "Darnall", "10.5240/EFEE-FFEE-FDFF-FEFF-DEBE-C", false, "2015-04-17", "Up-sized national Graphic Interface", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 916, "Khadir", "Evey", "10.5240/FDFF-EEBD-DFFD-FFFD-DEEF-C", false, "2016-01-29", "Centralized attitude-oriented projection", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 917, "Crimpe", "Fania", "10.5240/FFFF-A8EF-ECEF-BFDF-EBFF-C", false, "2013-12-31", "User-friendly client-driven data-warehouse", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 918, "Hummerston", "Jesselyn", "10.5240/FEFF-EDFC-FFFF-FCFF-FFFE-C", false, "1998-06-10", "Reverse-engineered 4th generation product", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 919, "Hazzard", "Meyer", "10.5240/FFFD-DFEF-FFFE-FEFE-E8EF-C", false, "2004-06-10", "Synergized multi-state policy", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 920, "Skiggs", "Tabby", "10.5240/FCFE-EFEF-FFBD-9DFE-FFFF-C", false, "1998-05-30", "Synchronised high-level ability", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 921, "Iacopetti", "Jareb", "10.5240/FEFF-EFFF-FEDC-F9FF-FFDD-C", false, "1992-10-15", "Team-oriented fault-tolerant synergy", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 922, "Ainscough", "Mei", "10.5240/BBDE-FEEF-FFEF-FEFF-CEFF-C", true, "2012-01-30", "Object-based motivating core", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 923, "Martindale", "Wilfred", "10.5240/FDFE-EEDF-EFB7-FEFC-FEFF-C", false, "2002-08-22", "Progressive global pricing structure", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 924, "MacGarrity", "Butch", "10.5240/FFFF-EFFE-FEAE-CDDC-EFFD-C", false, "2000-04-02", "Vision-oriented client-server neural-net", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 925, "Pleuman", "Dominick", "10.5240/FFEF-DDEF-FEEF-DDFF-FFFC-C", false, "1998-09-04", "Profit-focused 3rd generation portal", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 926, "Iacomini", "Amil", "10.5240/DFFF-DCFC-FFEE-FFDE-FEFF-C", false, "2000-07-30", "Mandatory regional adapter", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 927, "Kilmary", "Elisha", "10.5240/EDFF-FDFF-EEDC-FEEF-E9EF-C", false, "1990-09-28", "Progressive human-resource interface", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 928, "Gallant", "Ronica", "10.5240/FFFF-AEFF-FFEF-FEFF-DDFF-C", true, "2018-08-23", "Networked 3rd generation moratorium", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 929, "De Haven", "York", "10.5240/FFFE-FEFC-BFDD-EEED-FEFC-C", false, "1992-07-20", "Virtual bandwidth-monitored protocol", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 930, "McFetrich", "Sybila", "10.5240/FEFF-FFFC-DFFF-CDFE-DED9-C", false, "1993-10-01", "Operative full-range model", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 931, "Faunt", "Adelina", "10.5240/EECF-FDBC-FFFF-DFFE-FFDE-C", false, "1996-03-27", "De-engineered zero tolerance methodology", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 932, "Gladstone", "Brana", "10.5240/FCED-FFFF-FEDB-FF9F-FDFE-C", false, "2014-08-14", "Fully-configurable leading edge customer loyalty", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 933, "Stennard", "Darby", "10.5240/FFFF-DFEE-FDDF-FDFF-E8EF-C", false, "1990-09-23", "Digitized empowering knowledge base", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 934, "Perocci", "Wernher", "10.5240/FFFF-FFEE-EFFE-CD8E-FFEE-C", false, "2017-12-31", "Organized regional analyzer", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 935, "Woodcroft", "Joannes", "10.5240/DDAF-EDEE-FFFF-BFFF-DDDF-C", false, "2013-12-18", "Universal non-volatile matrix", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 908, "Smallpiece", "Carmelle", "10.5240/FFDF-EEEF-DEFE-AFEE-CFEE-C", false, "2007-04-23", "Visionary static protocol", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 936, "McCawley", "Mikkel", "10.5240/FDDC-DDFF-FFDE-FDEE-EFDE-C", false, "2015-06-21", "User-friendly 6th generation installation", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 907, "Jeffreys", "Etti", "10.5240/CFFD-EEFF-FEFF-EEFD-FFFF-C", false, "2003-03-23", "User-friendly heuristic solution", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 905, "Dormand", "Hildy", "10.5240/ADFF-FEEF-EDFF-FEDE-FEFF-C", false, "2002-04-01", "User-centric system-worthy protocol", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 878, "Sharples", "Edmund", "10.5240/ACDE-FEFF-FFFF-FFCD-FDFE-C", false, "2002-12-01", "Optional cohesive migration", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 879, "Gabriel", "Arleen", "10.5240/FEFF-CFFD-FEEF-EFDC-DFFC-C", false, "1992-02-19", "Versatile value-added solution", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 880, "Grzeskowski", "Emmi", "10.5240/CEBE-FFCF-FFFF-EFFF-FFEC-C", false, "1997-03-21", "Up-sized non-volatile architecture", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 881, "Bastock", "Aurlie", "10.5240/FFDC-FFEE-EEFC-EEEE-BEFE-C", false, "2007-07-17", "Intuitive clear-thinking orchestration", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 882, "Rayworth", "Linus", "10.5240/CCFF-FF6D-FFEF-CE9E-FFFD-C", false, "2008-02-15", "Open-architected user-facing interface", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 883, "Wison", "Meriel", "10.5240/FEEF-CFFF-FFED-EFDD-BFFF-C", false, "2017-10-05", "Synchronised reciprocal flexibility", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 884, "Crusham", "Nollie", "10.5240/DEEF-EDFF-EFFF-FFFF-EFFD-C", false, "2013-04-26", "Customer-focused holistic solution", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 885, "Erdely", "Fay", "10.5240/EFEE-FDDE-FEEF-FCDE-EDFE-C", false, "2016-10-09", "Ergonomic systemic structure", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 886, "Ambler", "Major", "10.5240/FFFE-9EEF-FFEF-ECFE-FFFF-C", false, "2002-01-07", "Horizontal systemic extranet", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 887, "Martineau", "Kaylil", "10.5240/AFDF-EFED-EEDF-FEFC-DFDF-C", false, "2010-09-14", "Re-engineered interactive moratorium", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 888, "Smorthit", "Marcellina", "10.5240/EFFB-CFFC-FBFE-FEFD-FEEF-C", false, "2000-06-13", "Decentralized composite artificial intelligence", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 889, "Flageul", "Dagny", "10.5240/F8CD-EEFE-DEDD-BFEF-EFFF-C", false, "2011-11-03", "Triple-buffered modular orchestration", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 890, "Camelli", "Marty", "10.5240/CDEE-EDFE-CFED-FFFF-FEFE-C", false, "1998-06-05", "Versatile needs-based architecture", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 891, "Gavrielly", "Rochell", "10.5240/DFFF-FFEF-FEEF-EEEE-9E9F-C", false, "1994-12-30", "Face to face mobile budgetary management", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 892, "Karlicek", "Myrtle", "10.5240/6EDF-FFFF-EFFF-FFBF-CFEF-C", false, "1994-12-11", "Switchable 24/7 help-desk", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 893, "Smallbone", "August", "10.5240/FDFF-FFFC-DFEA-EEAF-DEFC-C", false, "2016-06-16", "Optional modular model", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 894, "Luipold", "Desi", "10.5240/FFDF-FFFF-FEFF-F9FF-FFDE-C", false, "2001-03-20", "Multi-layered national middleware", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 895, "Whates", "Mina", "10.5240/EFFE-9FDD-FFFF-FFFF-CDDF-C", false, "2014-08-30", "Phased analyzing conglomeration", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 896, "Rickaert", "Fidelia", "10.5240/FFDE-EFFF-EDEF-FEDF-FEDD-C", false, "2002-08-10", "Future-proofed optimizing framework", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 897, "Vecard", "Persis", "10.5240/FFDF-FFFF-FFDD-FFEF-CFEF-C", false, "2008-06-02", "Distributed secondary capacity", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 898, "Hamlett", "Conroy", "10.5240/DFFF-BEFF-FFEE-EDFF-FEEF-C", false, "2000-02-29", "Triple-buffered optimal functionalities", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 899, "Stobbs", "Myrwyn", "10.5240/FFFC-EEFE-FEFC-FDFF-FBFE-C", false, "1992-09-23", "Advanced grid-enabled capability", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 900, "Pawelek", "Rodrique", "10.5240/EDFE-CFCD-FFFE-EEEE-FEFF-C", false, "1997-10-30", "Optimized impactful hub", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 901, "Gino", "Vanda", "10.5240/FFED-CFFF-FFEE-BFFE-FFFF-C", false, "1998-03-23", "Realigned directional capacity", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 902, "Exeter", "Gussi", "10.5240/FFEE-FFDE-FFFF-FEDE-FEFE-C", false, "1991-07-11", "Multi-layered client-driven orchestration", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 903, "Zanuciolii", "Celestyn", "10.5240/FCCF-EFEF-FFFF-EFDE-EDBE-C", false, "1991-04-30", "Function-based encompassing superstructure", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 904, "Creasy", "Elana", "10.5240/FECD-DFDF-EFFE-ECFE-DFFF-C", false, "2004-07-21", "Monitored multi-tasking moderator", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 906, "Klaiser", "Robbi", "10.5240/ABAF-EFEF-FDCE-FAEF-DFFC-C", false, "2001-11-06", "Extended user-facing structure", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 937, "Malpas", "Bell", "10.5240/DEBC-CFFB-7EBF-EFFF-EEDC-C", false, "2005-07-18", "Open-source contextually-based knowledge base", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 938, "Spratt", "Franz", "10.5240/FEEF-FFFF-EEDC-FDDB-DFFA-C", false, "2004-12-19", "Switchable 4th generation projection", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 939, "Fryatt", "Joice", "10.5240/EF9E-EFFD-DFCF-EFDF-FFFF-C", false, "2012-11-11", "User-friendly hybrid framework", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 972, "Waters", "Nerissa", "10.5240/FFCF-ECFF-FFFF-FFEF-EEFE-C", false, "1998-01-22", "Fundamental client-server parallelism", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 973, "Dulinty", "Tobias", "10.5240/FEFF-FFCF-FCFE-FE8D-FFEE-C", false, "2014-05-18", "Fully-configurable clear-thinking help-desk", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 974, "Brise", "Douglass", "10.5240/FDFF-DEFE-FFFE-FEFD-FFFF-C", false, "1991-02-07", "Business-focused explicit hub", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 975, "Coopper", "Bobbie", "10.5240/EFDB-EEFF-B8FD-FFDF-DFCF-C", false, "2001-10-27", "Synergized tangible framework", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 976, "Dubois", "Marylin", "10.5240/EFFD-FFDF-FDBF-EFFE-FEFF-C", false, "2011-04-03", "Switchable multimedia solution", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 977, "Twizell", "Stanly", "10.5240/FCEF-EFDE-FFFF-FEFE-EFDE-C", false, "1991-12-19", "Multi-lateral interactive extranet", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 978, "Flahy", "Emmi", "10.5240/FFFC-EEFE-FEFF-FBDA-FFEA-C", false, "2011-02-17", "Diverse real-time synergy", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 979, "Grossier", "Danita", "10.5240/BFFF-EEEE-AFFE-FEEF-DEFF-C", false, "1991-04-20", "Mandatory tangible architecture", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 980, "Stalley", "Gifford", "10.5240/CFFF-FCEE-CEFF-FFEF-EFFC-C", false, "2016-11-21", "Customer-focused multi-tasking flexibility", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 981, "Balaam", "Elwin", "10.5240/ECAE-AFEA-EDFF-EEFF-EFDF-C", false, "1993-03-13", "Sharable methodical complexity", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 982, "Sleney", "Muriel", "10.5240/EFFF-CFEA-DAFE-EFFF-DEEF-C", false, "1991-06-27", "Optimized object-oriented complexity", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 983, "Whorall", "Georgianne", "10.5240/EBCC-FFFF-FFEE-F9FF-FEEE-C", false, "2006-04-19", "Multi-layered zero tolerance archive", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 984, "Suller", "Queenie", "10.5240/DFFF-FFED-FFFF-EFFE-FFEF-C", false, "2015-05-16", "Advanced context-sensitive archive", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 985, "Stannis", "Daloris", "10.5240/EAFC-DDEC-DDFD-EECD-FEFC-C", false, "2014-09-11", "Reactive homogeneous initiative", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 986, "Gritskov", "Killy", "10.5240/9CFE-DFEF-FEFF-FFFD-DEFA-C", false, "2012-08-03", "Grass-roots zero administration local area network", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 987, "Ginty", "Maddy", "10.5240/EEDD-DFCF-FFFE-FFBF-CEDB-C", false, "2013-04-02", "Fundamental stable orchestration", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 988, "Spino", "North", "10.5240/EFAF-BDFD-FFEF-FFEF-FFEE-C", false, "2014-08-10", "Streamlined interactive pricing structure", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 989, "Cogley", "Meyer", "10.5240/EEEF-EEFD-EFED-DFFF-DFFB-C", false, "1994-02-15", "Open-source solution-oriented framework", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 990, "MacIntyre", "Roselle", "10.5240/EEFE-FDDF-EFFF-FFDF-FFEE-C", false, "2014-08-30", "Total intermediate data-warehouse", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 991, "Barradell", "Glori", "10.5240/FFFF-FEFF-FEFE-FECF-FFFF-C", false, "2017-08-16", "Profit-focused well-modulated implementation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 992, "Mablestone", "Dore", "10.5240/FFFC-FFEF-FDDF-FDFB-FECF-C", false, "2004-11-11", "Profound background secured line", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 993, "Fores", "Stern", "10.5240/FEFF-CFFF-8FFF-FDFF-DEF8-C", false, "2016-11-02", "Open-architected methodical solution", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 994, "Bachelar", "Tammy", "10.5240/FDFE-CDEF-EFFF-BEEF-DFDF-C", false, "2013-03-09", "Customer-focused national matrix", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 995, "Bentall", "Corene", "10.5240/FFDE-FDEC-FBEE-F9EF-EEFE-C", false, "2018-07-01", "Networked dedicated standardization", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 996, "Blackburn", "Annemarie", "10.5240/FEFE-EFFD-F9EF-EFFF-FEFE-C", false, "1991-05-25", "Re-contextualized responsive migration", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 997, "Schule", "Jemmy", "10.5240/EFEA-FFFC-DFDC-FFFE-DBBF-C", false, "2010-03-21", "Automated solution-oriented moratorium", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 998, "Undy", "Sherry", "10.5240/DEF9-FEBE-8FFF-FCFF-EFFC-C", false, "2004-03-23", "Fully-configurable dynamic time-frame", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 971, "Coull", "Aundrea", "10.5240/FEDE-FFFF-DFCF-EFFE-FEFF-C", false, "1999-09-05", "Business-focused mission-critical local area network", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 970, "Kaplan", "Cris", "10.5240/EBDF-FFDF-CFFE-FFFB-DFF9-C", false, "2009-04-22", "Upgradable exuding benchmark", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 969, "Conneely", "Donny", "10.5240/FFFF-CFDD-DFEF-6ECE-EEEE-C", false, "1993-11-17", "Open-source 3rd generation challenge", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 968, "Brissard", "Arden", "10.5240/CEFF-DFEF-EDFF-FEDE-FDCC-C", false, "2006-08-17", "Synchronised 6th generation time-frame", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 940, "Costan", "Jecho", "10.5240/FDFE-EEFE-F8EF-EEED-FFFD-C", false, "2014-05-18", "Persevering leading edge capacity", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 941, "Rodear", "Melania", "10.5240/FBFE-CFFF-EFFC-FFEF-DEFE-C", false, "2014-07-09", "Stand-alone mission-critical migration", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 942, "Spreadbury", "Johnny", "10.5240/FEDF-FEFE-FFEF-FDFD-DFCE-C", false, "1996-09-13", "Reduced encompassing info-mediaries", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 943, "Gerardet", "Marguerite", "10.5240/FDFF-EFCF-FBDF-CFFF-DDFF-C", false, "1998-12-06", "Enhanced 3rd generation website", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 944, "Freeland", "Dana", "10.5240/FEEE-F7EC-FCFE-FEFD-EBFE-C", false, "1991-10-27", "Automated interactive circuit", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 945, "MacKaig", "Ettie", "10.5240/EFFD-FFFF-EFEF-FBF9-FCCF-C", false, "2017-06-07", "Synergized zero defect hardware", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 946, "Farn", "Yetty", "10.5240/DFEE-EFE9-FFFF-FFEF-FCEF-C", false, "2016-12-17", "Virtual intermediate product", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 947, "Kaemena", "Diana", "10.5240/EFFB-EFEE-CEEF-FFEF-FFEF-C", false, "2002-08-29", "Synchronised empowering product", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 948, "Gaddesby", "Adah", "10.5240/FEFE-EFFF-FFAE-FBDE-FFFF-C", false, "2014-03-01", "Ergonomic hybrid middleware", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 949, "Brimmell", "Meredithe", "10.5240/FDFD-DCED-FEFE-EFFC-FCFF-C", false, "2003-02-26", "Profound 6th generation attitude", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 950, "Mussared", "Robinett", "10.5240/ECFF-EEBF-FFEF-FEEE-EFCE-C", false, "2007-02-04", "Horizontal global toolset", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 951, "Chesterman", "Brody", "10.5240/CFDE-FEFF-FFDF-CCFE-DCFD-C", false, "2007-06-15", "Intuitive hybrid knowledge user", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 952, "Timby", "Ring", "10.5240/DFEF-EEFF-DBEE-FDEF-FFEC-C", false, "2017-09-23", "Organic hybrid support", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 877, "Castelluzzi", "Brittni", "10.5240/FEFF-FFFF-FDCF-EEFE-DFCC-C", false, "2013-04-05", "Devolved logistical array", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 953, "Edgell", "Misti", "10.5240/EEFE-FBEE-EFDF-FFCF-ECEF-C", false, "2005-10-17", "Open-architected optimizing emulation", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 955, "Bilsford", "Maddie", "10.5240/EEEB-EDFE-FDFF-FFEE-FFFD-C", false, "2004-06-25", "Ameliorated multi-tasking success", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 956, "Ferron", "Shalom", "10.5240/FFEF-FCEF-EFFF-6FED-FFFF-C", false, "1999-06-22", "Secured object-oriented utilisation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 957, "Kike", "Matelda", "10.5240/FFFE-FEDF-FEED-BEFD-FFFC-C", false, "2008-03-06", "Automated next generation approach", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 958, "Kester", "Nertie", "10.5240/EDFE-FFEF-BDDF-FDFF-FFFE-C", false, "2002-12-24", "Realigned stable portal", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 959, "Hubeaux", "Emerson", "10.5240/FEBD-EFFB-FFFF-FEDD-FFEC-C", false, "1991-12-16", "User-friendly object-oriented parallelism", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 960, "Briffett", "Margot", "10.5240/EFFE-BBFD-FFCF-FFEF-DEFF-C", false, "1993-03-12", "Proactive grid-enabled instruction set", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 961, "Shingler", "Prentice", "10.5240/EFFF-CFFE-FCEF-EEEF-EEFE-C", false, "1994-02-19", "Switchable multi-tasking array", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 962, "Stollmeier", "Mordy", "10.5240/AFFE-AFFF-F8CE-AECF-DEFE-C", false, "2002-06-01", "Profit-focused grid-enabled data-warehouse", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 963, "McAirt", "Gratia", "10.5240/DFFF-EDFF-FFEF-FFFC-FEDD-C", false, "1995-01-06", "Optional radical emulation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 964, "Lewin", "Matias", "10.5240/FBCF-FFFE-FBEF-EFDF-FEED-C", false, "2002-09-28", "Enhanced composite Graphical User Interface", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 965, "Cheetam", "Lodovico", "10.5240/EFDF-CCBC-FCDF-FEFF-FFDE-C", false, "1997-03-26", "Re-contextualized bi-directional matrix", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 966, "Hessing", "Hobie", "10.5240/FECE-EECD-DEEE-DFFA-AFFE-C", false, "2011-09-17", "Switchable asynchronous secured line", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 967, "Quare", "Kenyon", "10.5240/BEEE-EEFF-FFFF-DFCE-7EFF-C", false, "1992-01-09", "Multi-layered impactful toolset", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 954, "Woolmington", "Reggie", "10.5240/EFDF-FEED-EEAE-FEDF-FFED-C", false, "2015-02-12", "Object-based systemic artificial intelligence", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 876, "Batterson", "Yasmin", "10.5240/EFFF-FDFC-BFEE-FEFC-DFED-C", false, "1991-12-20", "Future-proofed multi-tasking solution", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 875, "Petegrew", "Efrem", "10.5240/FFFF-FFFE-DEEF-EFED-BFED-C", false, "2014-01-18", "Intuitive needs-based array", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 874, "Aasaf", "Cirstoforo", "10.5240/DFFE-FFEF-EEBB-FEFF-FDFE-C", false, "2010-12-08", "Polarised static extranet", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 784, "Wakeley", "Hortense", "10.5240/EFFE-DFFD-FEFF-FFFB-FFEF-C", false, "2006-07-22", "Integrated 24/7 analyzer", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 785, "Akers", "Dannye", "10.5240/EDFA-CBFE-FEFF-DFFF-FFFF-C", false, "2012-10-19", "Universal value-added flexibility", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 786, "Crudgington", "Haskell", "10.5240/EDEF-FFFE-FFDE-DDFF-DECF-C", false, "2014-05-25", "Progressive analyzing installation", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 787, "O'Shee", "Faustine", "10.5240/DDEF-FFEE-FAFF-EFFE-FCFF-C", false, "2011-03-02", "Automated content-based service-desk", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 788, "Dumbreck", "Nikki", "10.5240/CFED-FAFF-FAFE-EEFF-EDFE-C", false, "1992-07-09", "Profound content-based Graphical User Interface", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 789, "Rispen", "Viviyan", "10.5240/FFEF-FFFE-EFEF-FBDE-DFFF-C", false, "2011-10-12", "Reactive bottom-line attitude", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 790, "Sheaber", "Meridel", "10.5240/FFFE-DFEE-FFCF-FEEE-CFCE-C", false, "1991-09-20", "Horizontal 4th generation monitoring", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 791, "Ranyelld", "Caitrin", "10.5240/FEFE-CFFD-EDEF-ECFE-FFBF-C", false, "1994-12-31", "Sharable actuating encoding", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 792, "Bracci", "Tuesday", "10.5240/DFFF-FEFF-FFFD-ADFE-FFFC-C", false, "1992-04-23", "Distributed system-worthy pricing structure", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 793, "Godmer", "Vasily", "10.5240/FFCF-BAEE-FFDF-EFFB-FFDF-C", false, "2001-05-13", "Profit-focused interactive ability", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 794, "Harlin", "Zenia", "10.5240/FFFC-FEFF-FDDD-EEED-FFFE-C", false, "2000-02-01", "Distributed executive portal", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 795, "Peter", "Minerva", "10.5240/CFFC-FFFD-FFFF-EFCE-FFFE-C", false, "2016-10-17", "Switchable optimal Graphic Interface", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 796, "Silkston", "Lay", "10.5240/BDDE-FFFE-EDDB-BECF-DDFF-C", false, "2017-01-11", "Self-enabling discrete functionalities", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 797, "Philippson", "Blakelee", "10.5240/FFFD-E7FF-DFFF-FEFE-FEAD-C", false, "2011-10-20", "Horizontal context-sensitive access", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 798, "Jennens", "Curt", "10.5240/DCFF-FEED-FEFE-EEBF-CD9F-C", false, "2001-11-23", "Configurable composite moratorium", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 799, "Landon", "Sharona", "10.5240/CEEF-FFEF-FEFF-EFFA-FFFF-C", false, "1993-03-09", "Multi-layered executive function", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 800, "Mulholland", "Augie", "10.5240/EFEF-DFFE-DEFF-FFCE-FECD-C", false, "1995-02-22", "Upgradable zero defect encryption", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 801, "Bolle", "Fabian", "10.5240/FFDF-EEAF-DEFE-FCFE-EFCF-C", false, "2014-09-22", "Triple-buffered bottom-line utilisation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 802, "Bergeon", "Odilia", "10.5240/FFFD-9EDF-FEFF-EFFF-DFFF-C", false, "1992-10-17", "Switchable motivating leverage", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 803, "Carthy", "Bailie", "10.5240/FEFF-DFED-FCFC-EFFE-EBFF-C", false, "2014-12-05", "Organic attitude-oriented focus group", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 804, "Acuna", "Daryle", "10.5240/AFFC-DFFF-DEEE-EFEC-CDCF-C", false, "2009-01-02", "Decentralized 24/7 frame", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 805, "Le-Good", "Tailor", "10.5240/9BEF-FDEE-FEEC-CEDF-EFED-C", false, "2009-04-05", "Compatible 5th generation circuit", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 806, "Arington", "Jarret", "10.5240/AFFF-FEEC-CFFD-DEDE-DE3F-C", false, "2015-09-15", "Programmable real-time hierarchy", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 807, "Hindrick", "Ross", "10.5240/FFEC-FEDF-CEEF-F9FE-EDEF-C", false, "2011-03-25", "Integrated full-range analyzer", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 808, "Pheasey", "Findley", "10.5240/EFBE-CDFC-FEDE-EFEF-EEEE-C", false, "2007-05-18", "Sharable national capacity", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 809, "Lowdyane", "Saleem", "10.5240/EFFB-FDEF-FFDD-FDDF-DFEF-C", false, "1993-10-11", "Organic grid-enabled groupware", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 810, "Twelves", "Nanete", "10.5240/EFFE-BFFE-BEFB-FEBC-FDDF-C", false, "2013-11-27", "Profound zero administration neural-net", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 783, "Goare", "Margie", "10.5240/FFEF-FECE-FEEE-CFE8-FFFF-C", false, "2008-03-30", "Optimized 6th generation info-mediaries", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 782, "Seawright", "Emmalynn", "10.5240/CFCD-FFDE-ECAD-FFFD-DECF-C", false, "2012-11-12", "Diverse solution-oriented definition", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 781, "Palmby", "Elizabeth", "10.5240/DFCF-CFCF-FEFF-FFFF-DFEF-C", false, "1992-10-16", "Sharable 3rd generation interface", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 780, "Rock", "Lea", "10.5240/FDFE-EECE-DEDF-DFFF-FFEF-C", false, "2005-01-29", "Robust high-level paradigm", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 752, "McCudden", "Sal", "10.5240/FDEE-FCFD-DDEF-CDEF-DFFF-C", false, "1991-09-06", "Horizontal intangible moderator", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 753, "Piwall", "Rowney", "10.5240/F9FF-F9FE-FFCD-EEEF-EFEF-C", false, "2017-10-20", "Assimilated user-facing architecture", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 754, "Innott", "Annora", "10.5240/DDEF-DFFE-FCDE-FF7E-FEFF-C", false, "1999-08-13", "Self-enabling composite system engine", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 755, "Attwoull", "Doy", "10.5240/FFEF-BFEF-EEFF-FFFF-EDEE-C", false, "2007-08-13", "Diverse intangible knowledge user", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 756, "Clemits", "Wayne", "10.5240/DFDF-ECFD-FFDF-FFFF-EFFE-C", false, "2009-10-26", "Customizable bandwidth-monitored infrastructure", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 757, "Douty", "Leland", "10.5240/DEDF-FFCB-FEFF-FFFE-EFFF-C", false, "1995-11-30", "Ameliorated hybrid encoding", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 758, "Keable", "Bette", "10.5240/FFFF-BFEF-FDFF-FFAE-FCFF-C", false, "2013-09-23", "Front-line multi-state focus group", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 759, "Jaquemar", "Kennedy", "10.5240/FFDF-FFFD-FEED-FCFF-FFFE-C", false, "2005-12-11", "Customer-focused actuating support", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 760, "Skyram", "Walker", "10.5240/FFEE-FFFE-DFEF-FFFF-FFFD-C", false, "1995-11-17", "Seamless optimal array", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 761, "Schlagh", "Thadeus", "10.5240/BFBF-FDEF-AEDF-FFDE-FFFE-C", false, "2017-11-26", "Reactive empowering challenge", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 762, "O'Lagene", "Piggy", "10.5240/EFFF-FFFB-FFCF-EFDF-FCEF-C", false, "2017-04-30", "Proactive national instruction set", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 763, "Surgener", "Eleanora", "10.5240/CEBF-EFEE-EDFB-CEFE-EEEE-C", false, "2000-10-17", "Down-sized needs-based capability", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 764, "Neumann", "Kirby", "10.5240/AAFE-FDEE-8FFF-FCFD-FEDF-C", false, "2007-06-21", "Distributed national installation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 811, "Minichillo", "Tatiania", "10.5240/FEBE-AAEF-FFFE-DFFF-FCFE-C", false, "2008-08-25", "Right-sized systemic benchmark", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 765, "Blaylock", "Ignacius", "10.5240/FEEE-FDFE-FCDF-FDDD-FFFB-C", false, "2012-11-13", "Reduced empowering leverage", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 767, "Yonge", "Morie", "10.5240/BFF9-FFCF-FFCD-FFFF-FF9F-C", false, "2012-09-13", "Down-sized systematic internet solution", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 768, "Wyss", "Reinald", "10.5240/FFBD-FEEF-EDFE-FEFF-FEDF-C", false, "2002-08-06", "Fully-configurable asynchronous array", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 769, "Swalwel", "Lodovico", "10.5240/FFDE-FFFF-EFDE-DFDD-FFEF-C", false, "2015-02-18", "Visionary responsive challenge", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 770, "Crossgrove", "Rodger", "10.5240/FFFF-FDFF-CFFF-FEEF-FFFF-C", false, "1998-02-21", "Networked multi-state internet solution", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 771, "Oxenbury", "Mandi", "10.5240/FDDD-DFEF-BAFF-FFEF-DFFE-C", false, "2015-07-11", "Multi-lateral asynchronous website", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 772, "McRuvie", "Stanley", "10.5240/FDEF-EFED-FEFE-FEDF-EBFF-C", false, "2011-09-27", "Persevering explicit collaboration", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 773, "Stuck", "Cassandry", "10.5240/CDFF-DFEF-FEEF-FFFD-FDFF-C", false, "2013-02-02", "Upgradable bandwidth-monitored infrastructure", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 774, "Bubbear", "Timmy", "10.5240/FFBF-DEEF-EFDF-CBFF-DBFE-C", false, "2010-09-09", "Virtual intangible workforce", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 775, "Wynes", "Bucky", "10.5240/FCFF-FFDF-DEEF-FFEC-FFEF-C", false, "2015-12-12", "Business-focused incremental contingency", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 776, "Medcraft", "Garrek", "10.5240/DBFE-FAEE-CEFF-CCDE-DFFF-C", false, "1997-10-26", "Advanced web-enabled projection", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 777, "Sweating", "Marillin", "10.5240/FEFF-EFDE-EDFF-CFAC-FFDD-C", false, "1994-06-05", "Organized optimizing Graphical User Interface", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 778, "Isaacs", "Dorelia", "10.5240/DFAF-DFFE-FCFF-BEDF-FDFE-C", false, "2001-10-24", "Persistent next generation migration", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 779, "Bromwich", "Ardys", "10.5240/FFED-D3EF-EEFE-FCCF-ECDF-C", false, "2017-03-25", "Persevering zero administration help-desk", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 766, "Klempke", "John", "10.5240/FFFF-FFEF-FBFF-FEEF-EDFF-C", false, "2005-06-14", "Front-line tangible encoding", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 750, "Khomich", "Chlo", "10.5240/FEEE-ABEE-EFEF-FFEE-FFFE-C", false, "1997-10-07", "Multi-lateral hybrid matrices", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 812, "Como", "Celesta", "10.5240/FEED-ECED-FEFB-EFDF-FFED-C", false, "2017-06-13", "Stand-alone web-enabled protocol", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 814, "Gammet", "Akim", "10.5240/FFAC-EFFE-FFEF-FEEF-FDFE-C", false, "1996-09-05", "Customizable dedicated help-desk", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 847, "Semmence", "Vincenz", "10.5240/EEEF-CFCF-EFEE-EFFF-FFFE-C", false, "2004-03-26", "Sharable neutral local area network", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 848, "Warren", "Phylis", "10.5240/FDFD-EBED-FFEF-EEFF-EFFF-C", false, "1998-01-27", "Diverse zero defect productivity", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 849, "Kitson", "Ramsey", "10.5240/EFEF-DFFE-FF9F-FCFF-FFFF-C", false, "1994-05-20", "Function-based homogeneous time-frame", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 850, "Thompstone", "Haze", "10.5240/FDDC-DEBF-CFFE-DFEE-FFEC-C", false, "1994-02-26", "Re-engineered analyzing groupware", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 851, "Deboy", "Collette", "10.5240/EEFC-EFF4-EEBD-EFFF-FFEF-C", false, "2012-01-16", "Grass-roots global pricing structure", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 852, "Mixhel", "Claudie", "10.5240/FFEF-FFDD-FFDF-EFEF-EEEC-C", false, "2015-12-06", "Universal neutral initiative", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 853, "Mapstone", "Abran", "10.5240/FDFE-BFDE-EFFF-FECF-9EFD-C", false, "2012-03-23", "Cloned intangible archive", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 854, "Ebrall", "Isabelita", "10.5240/EFFF-EFEE-FEED-FBDD-FEFE-C", false, "2018-04-05", "Mandatory multi-state flexibility", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 855, "Lovegrove", "Carey", "10.5240/AFFF-FFFE-DDEC-D7EF-FAFF-C", false, "2017-02-20", "Multi-tiered multi-tasking help-desk", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 856, "Dumbrill", "Brunhilde", "10.5240/BBFB-BEFF-FEFE-9EFF-FDEF-C", false, "2001-08-12", "Profit-focused didactic methodology", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 857, "Phelp", "Bernice", "10.5240/FEFF-CCFD-FFFF-EFDD-FFFE-C", false, "2015-08-08", "Diverse 24 hour forecast", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 858, "Illingsworth", "Alexa", "10.5240/FFEE-BFED-FEFC-FEEF-8EFF-C", false, "2013-04-04", "Intuitive client-driven info-mediaries", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 859, "Becks", "Shirley", "10.5240/FEFD-EFCD-FFFC-DEDE-FEFF-C", false, "2013-11-05", "Profound web-enabled function", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 860, "Kill", "Sallyann", "10.5240/FFCF-FACF-EAFD-FEDD-DFEE-C", false, "1999-04-16", "Expanded grid-enabled ability", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 861, "Cready", "Samara", "10.5240/FBFE-FEFE-FEDF-EFDF-FFCF-C", false, "1995-04-21", "Multi-tiered client-driven monitoring", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 862, "Clemas", "Tiebold", "10.5240/FFFE-F9FF-FEFE-CFFB-FEDE-C", false, "2014-04-03", "Focused clear-thinking initiative", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 863, "Garnar", "Cass", "10.5240/FFEC-FFCC-FEFF-EFBE-FFFC-C", false, "1996-12-28", "Proactive 24 hour initiative", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 864, "Simonini", "Trefor", "10.5240/EFFF-EFDF-FEFF-FEFD-FFFE-C", false, "2016-12-08", "Ergonomic client-server open system", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 865, "Leitch", "Fletch", "10.5240/FCBF-CFFF-FFDF-CFDB-ECCF-C", false, "1999-03-10", "Profit-focused actuating definition", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 866, "Antoni", "Augy", "10.5240/EECC-FFEF-ECCC-FDEE-EFFF-C", false, "1997-06-23", "Diverse transitional database", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 867, "Glisenan", "Dot", "10.5240/FEFF-FEDD-EFDF-FFEE-DFED-C", false, "2014-12-08", "Integrated client-driven access", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 868, "Chivrall", "Torry", "10.5240/DFCF-7FFF-EEEC-BFEE-CDBE-C", false, "1992-04-10", "Configurable well-modulated Graphical User Interface", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 869, "Elcock", "Trueman", "10.5240/FDCF-FFDD-DEEF-FEFF-FFDD-C", false, "2003-10-21", "Open-architected attitude-oriented paradigm", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 870, "Leffek", "Jacquelin", "10.5240/DEED-FEFD-FEDF-FFFE-EFEE-C", false, "2011-12-23", "Mandatory asymmetric extranet", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 871, "Bilton", "Trumaine", "10.5240/FFCF-EFEE-D9EF-EFD8-FEDE-C", false, "2012-06-29", "Re-contextualized modular website", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 872, "Yegorev", "Claretta", "10.5240/EFEF-FEFD-FEFF-DFFF-FCFB-C", false, "2014-03-03", "Vision-oriented didactic encoding", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 873, "Baptie", "Audie", "10.5240/EFFF-FFDF-DFFE-FFFF-DFEF-C", false, "2001-10-13", "Profit-focused web-enabled workforce", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 846, "Crannage", "Samson", "10.5240/BDFF-FEFE-AFEE-DFFF-FEFF-C", false, "2011-10-09", "User-centric optimizing application", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 845, "Grevile", "Roth", "10.5240/BFEE-EDFE-EEFF-EEDE-DDAC-C", false, "1992-05-28", "Cross-group content-based ability", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 844, "Knightsbridge", "Web", "10.5240/EFFF-FDFF-DDFF-FDDF-EFDE-C", false, "1991-10-15", "Realigned solution-oriented Graphic Interface", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 843, "Goodered", "Daune", "10.5240/FFFF-FFFE-FFEB-FEFE-9FED-C", false, "2002-04-17", "Persistent optimal toolset", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 815, "Orts", "Christan", "10.5240/FEED-FEFF-ECFE-EEFE-FFFF-C", false, "2011-07-03", "Monitored optimal portal", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 816, "Gokes", "Wait", "10.5240/FCAF-FEEE-CFDE-FFEE-EEFD-C", false, "2000-04-25", "User-centric full-range time-frame", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 817, "Allenson", "Sheree", "10.5240/EDC9-EDFF-FEFB-FDEE-ED9D-C", false, "1995-11-12", "Total discrete workforce", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 818, "Norquoy", "Nikolai", "10.5240/9FFC-8EFB-9FFF-CDFF-FFFD-C", false, "1993-11-01", "Front-line responsive artificial intelligence", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 819, "Britner", "Chic", "10.5240/EECF-AFFE-FDEE-EFFF-FCEF-C", false, "2007-03-28", "Persevering uniform core", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 820, "Tamblingson", "Wang", "10.5240/EFFD-EE9F-EFFE-FFFE-CCED-C", false, "2004-04-04", "Triple-buffered multi-tasking open architecture", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 821, "Tudhope", "Dawn", "10.5240/DAED-FFFD-DDDF-FEFF-DFFF-C", false, "2009-11-22", "Grass-roots system-worthy parallelism", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 822, "Petrashkov", "Rasia", "10.5240/EFAE-FFEB-EFEF-FCFC-CEFD-C", false, "2004-10-15", "Persevering directional utilisation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 823, "Dryden", "Tana", "10.5240/FFFE-FFEF-8EFF-FEFE-FFFF-C", false, "2018-06-04", "Visionary uniform protocol", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 824, "Destouche", "Bren", "10.5240/FEEE-EEFD-FEBF-FFFE-FDDE-C", false, "1999-05-21", "Networked actuating capacity", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 825, "Boyett", "Christen", "10.5240/FEFB-EFFF-ECCF-EEFF-DFFF-C", false, "1999-10-17", "Decentralized multi-tasking service-desk", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 826, "Meys", "Chrotoem", "10.5240/EFFD-EFFD-FCFD-9FFF-EE9E-C", false, "1993-02-25", "Sharable executive interface", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 827, "Domanek", "Ryann", "10.5240/EFCE-FEBD-BF9D-FFED-FFFB-C", false, "2004-08-26", "Distributed zero defect array", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 501, "Bradlaugh", "Alfonso", "10.5240/FFFE-DFDF-CEFE-FFFF-FEFE-C", false, "1991-01-25", "Streamlined fresh-thinking archive", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 828, "Yakobowitch", "Brewster", "10.5240/CCEF-FBFF-9EEE-EEEA-EFE7-C", false, "2007-07-20", "Compatible well-modulated implementation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 830, "Buckeridge", "Tades", "10.5240/FEFF-EDFD-DDEF-FFFF-FEDD-C", false, "1994-12-30", "Fundamental uniform analyzer", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 831, "Hinchon", "Julina", "10.5240/FBDF-DEFD-FDEE-FBEF-FFEF-C", false, "2003-07-18", "Secured web-enabled Graphic Interface", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 832, "Nuccii", "Richard", "10.5240/DEEF-FFEF-CFEF-FEEF-CEBF-C", false, "2007-04-06", "Compatible incremental strategy", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 833, "Thornhill", "Madalena", "10.5240/FFFE-DFFF-CEF9-FD8E-EFFF-C", false, "1998-03-06", "Public-key background matrices", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 834, "Thornhill", "Carol", "10.5240/EFEF-FEEE-FBFB-DEDC-FFFD-C", false, "2009-06-28", "Multi-channelled web-enabled website", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 835, "Beaven", "Frederik", "10.5240/DDFE-FFBE-CFAF-FFEF-FFAE-C", false, "1998-04-19", "Progressive disintermediate capability", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 836, "Gallager", "Nathan", "10.5240/EFFF-FFFF-FFFE-FFEF-EFFA-C", false, "1991-07-06", "Enhanced modular adapter", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 837, "Slarke", "Lulita", "10.5240/EEBC-DEEF-FCEF-FACF-EBFF-C", false, "1998-02-14", "Grass-roots incremental concept", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 838, "Vel", "Wini", "10.5240/EDED-EFEF-FEEC-FEFF-FDED-C", false, "2000-06-30", "Total eco-centric standardization", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 839, "Edgehill", "Yoko", "10.5240/8FEF-FFEF-EDDE-DCFF-EFFF-C", false, "1997-11-22", "Integrated incremental standardization", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 840, "Grimston", "Sophronia", "10.5240/DE8C-EFDF-FEEE-FFCF-EBFE-C", false, "2001-08-10", "Polarised local encoding", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 841, "Voisey", "Thedric", "10.5240/FDFF-DEEC-ECEF-FFDE-DFEE-C", false, "2008-12-17", "Cross-group attitude-oriented policy", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 842, "Gogerty", "Demetrius", "10.5240/EEEC-DCF7-EDFF-CEFF-FFFF-C", false, "2011-06-15", "Synergistic neutral implementation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 829, "Muff", "Kai", "10.5240/EEFF-DFFE-FFEE-DEFF-FE9B-C", false, "1994-09-01", "Public-key disintermediate neural-net", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 500, "Standish", "Alessandro", "10.5240/EEFC-EEFE-EFEF-CBEF-BFFE-C", false, "1993-03-27", "Persevering attitude-oriented middleware", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 436, "Maisey", "Rog", "10.5240/FDEE-BBFF-FFFF-EEFC-EEEF-C", false, "2009-10-31", "Vision-oriented composite algorithm", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 498, "Ruckhard", "Benny", "10.5240/EFFF-FEEF-BCEE-FEFE-FFFF-C", false, "1993-05-13", "Fundamental multi-state policy", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 157, "Twaite", "Sophronia", "10.5240/FFFF-FFEE-EEFF-BFEF-DFFF-C", false, "2009-02-26", "Right-sized 24 hour process improvement", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 158, "Adamolli", "Geneva", "10.5240/EFEF-FCDF-EDFE-EEFF-FEEE-C", false, "2007-01-06", "Public-key secondary open system", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 159, "Boyles", "Krysta", "10.5240/EFEF-FFEF-FEFE-FEEF-FFEF-C", false, "2011-09-29", "Cloned executive adapter", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 160, "Slorance", "Dela", "10.5240/EFFF-FDEF-DFED-DDB8-AEEF-C", false, "2013-01-06", "Progressive stable implementation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 161, "Dutt", "Gwendolin", "10.5240/EFED-FFFF-FCCF-EDFE-EBFF-C", false, "2003-09-15", "Ameliorated client-server emulation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 162, "Simonel", "Gavin", "10.5240/EFED-EDEE-F9EF-FFFF-FFFE-C", false, "1993-07-20", "Team-oriented 4th generation implementation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 163, "Popple", "Eirena", "10.5240/CCFF-AEFF-EEDF-FFFF-ECFB-C", false, "2011-03-04", "Devolved needs-based emulation", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 164, "Kitchiner", "Wyatt", "10.5240/FFEF-FEEE-CFFE-FEFF-FDEF-C", false, "2001-09-23", "Seamless contextually-based throughput", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 165, "Huckell", "Kristofer", "10.5240/FEFF-FEFF-EDDF-FDEF-DFFD-C", false, "2018-05-17", "Profound solution-oriented focus group", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 166, "Alelsandrowicz", "Antonia", "10.5240/DBFF-FFEE-FFFD-EEFE-FEBE-C", false, "2016-02-08", "Progressive actuating concept", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 167, "Quirk", "Devy", "10.5240/FFFF-DFCF-CBFF-BFCF-EEFF-C", false, "2003-04-21", "Self-enabling asynchronous forecast", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 168, "Bussell", "Val", "10.5240/FDFF-DBDE-FCDF-EBAF-FDEE-C", false, "2001-01-24", "Decentralized national local area network", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 169, "Hutsby", "Gaspar", "10.5240/FEFE-CFEF-FFDE-CFFF-EEDE-C", false, "2004-01-21", "Face to face uniform website", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 170, "Hamill", "Marylee", "10.5240/EFEB-FFFF-EDBF-FEFF-DEDF-C", false, "1992-01-29", "User-friendly tertiary strategy", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 171, "Martusov", "Jeanette", "10.5240/EFEE-EDEF-FDFE-FFDE-EEBF-C", false, "1996-08-26", "Configurable asymmetric support", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 172, "Tapenden", "Algernon", "10.5240/ECFE-CDFC-FFCF-EDFF-EFEE-C", false, "2000-05-18", "Business-focused bottom-line focus group", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 173, "Fasset", "Del", "10.5240/FEDF-FFEE-FEFE-CEFF-EFFE-C", false, "2013-02-26", "Realigned full-range product", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 174, "Byram", "Elsworth", "10.5240/FFBF-EDDF-CFEF-CEFD-EFEF-C", false, "2005-04-04", "Total bottom-line toolset", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 175, "Ianetti", "Redford", "10.5240/EDFE-EFCF-ADFE-FFEF-FFFF-C", false, "2002-11-11", "Implemented bifurcated ability", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 176, "Friedman", "Myrah", "10.5240/EFFE-FFFE-FDFB-EEED-FDFF-C", false, "1998-08-24", "Multi-layered value-added functionalities", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 177, "Lombardo", "Adella", "10.5240/FFFE-EFFC-EAFF-FFFB-CEFF-C", false, "2012-05-25", "Right-sized holistic task-force", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 178, "Bennough", "Palmer", "10.5240/FDFF-FAFF-BCFF-9DEF-DEFF-C", false, "2009-04-13", "Integrated full-range middleware", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 179, "Melin", "Curry", "10.5240/EFFE-FFFF-FDDC-FEFF-FFFD-C", false, "2012-10-24", "Distributed explicit groupware", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 180, "Raynham", "Vilma", "10.5240/DFEF-FFEE-FFCF-FFFF-DFEF-C", false, "1999-01-27", "Cross-platform explicit knowledge user", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 181, "Brookfield", "Dorine", "10.5240/FFFE-EFDF-FAFD-F9FA-FDFF-C", false, "2008-04-15", "Self-enabling discrete access", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 182, "Bryer", "Allene", "10.5240/FFFD-FEFF-EDEC-FFEF-CDDF-C", false, "1992-10-03", "Enhanced homogeneous application", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 183, "Ambridge", "Carey", "10.5240/AFF9-EFFF-EFFE-EEDF-FFFF-C", false, "2002-01-23", "Function-based non-volatile artificial intelligence", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 156, "Lambal", "Pace", "10.5240/BEFA-FECF-EEFF-CEFD-FDFF-C", false, "1993-12-19", "Horizontal fault-tolerant access", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 184, "Balshen", "Jillane", "10.5240/CFFF-FFFD-FBEF-FEE8-FEFF-C", false, "1995-10-28", "Configurable client-server application", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 155, "Gowdridge", "Thorin", "10.5240/EDCE-EFFF-EF9F-FCEF-EFFE-C", false, "2000-01-04", "Object-based uniform firmware", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 153, "Shore", "Beitris", "10.5240/FCFF-FDDF-EF9E-EEFF-DF9B-C", false, "2003-11-10", "Synergized fault-tolerant initiative", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 126, "McGuinley", "Conroy", "10.5240/DFCF-FFEF-EEED-DFBF-FDFC-C", false, "2016-01-05", "Visionary 3rd generation moratorium", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 127, "Dimbylow", "Sammy", "10.5240/DCEE-BEFF-FDFD-BDF8-FFEE-C", false, "1994-07-31", "Inverse optimizing circuit", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 128, "Dudderidge", "Tony", "10.5240/DFDF-EFFE-FDD3-AFF6-FCDF-C", false, "2018-06-23", "Enhanced disintermediate attitude", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 129, "McMenemy", "Noell", "10.5240/FFFF-FDEE-DFDD-EFEE-FFFF-C", false, "1999-08-17", "Inverse zero defect Graphic Interface", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 130, "Ffoulkes", "Blake", "10.5240/CECB-BFFE-DFFC-FDFE-FFFF-C", false, "2016-08-26", "Function-based local pricing structure", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 131, "Nary", "Edwina", "10.5240/FDFF-DFBE-FDFD-EEEF-FFFF-C", false, "2005-05-17", "Focused tangible superstructure", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 132, "Matschke", "Babita", "10.5240/EFED-EEFE-EFFE-FFDE-EEFE-C", false, "1998-07-01", "Organized bandwidth-monitored workforce", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 133, "Donoher", "Shelby", "10.5240/FFFF-FCEC-EEFE-EFFE-BFAF-C", false, "1998-12-24", "Digitized impactful moderator", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 134, "Pavolillo", "Dionisio", "10.5240/FEEB-DCCE-EDCE-EFFF-FFFF-C", true, "1994-08-14", "Public-key client-server internet solution", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 135, "Battabee", "Keenan", "10.5240/FFFC-EEFD-ECFD-FCEF-F9FC-C", false, "2009-08-11", "Expanded tangible firmware", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 136, "Kennham", "Maddy", "10.5240/EFFF-FE6E-EEEE-FFFE-F9FE-C", false, "2006-03-20", "Programmable full-range structure", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 137, "Taffurelli", "Jarid", "10.5240/9FFF-FFCD-FEFF-FFFD-ECEF-C", false, "2006-05-11", "Expanded national structure", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 138, "Flatley", "Gipsy", "10.5240/FFFC-FFBF-DFFD-ECEA-DDEF-C", false, "2010-08-14", "Pre-emptive multi-state collaboration", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 139, "Coatsworth", "Ruby", "10.5240/EEDC-FFEE-FEFE-EEEF-FE8E-C", false, "2005-07-24", "Seamless systematic application", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 140, "Putten", "Pauli", "10.5240/FFEE-FFFD-FDFF-FFEF-DFFF-C", false, "1996-06-08", "Front-line directional architecture", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 141, "But", "Nara", "10.5240/FEEF-FDDF-DFEF-EDBE-FEBD-C", false, "1993-12-30", "Customer-focused stable extranet", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 142, "Goathrop", "Tanny", "10.5240/EFEE-FFFF-FFDE-8BFE-FFEE-C", false, "2003-09-05", "Synergized methodical benchmark", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 143, "Pybus", "Webster", "10.5240/FEEF-CFEC-EEFD-EDDF-EFFF-C", false, "2004-06-01", "Streamlined exuding internet solution", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 144, "Vatini", "Francine", "10.5240/EFFF-BFAF-FFFE-DDCD-EECF-C", false, "2018-03-02", "Decentralized tertiary circuit", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 145, "Kleinhandler", "Brena", "10.5240/ACEE-FFEF-DFFD-AEFF-FFFE-C", false, "2008-02-19", "Networked 6th generation neural-net", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 146, "Illwell", "Ross", "10.5240/ECDE-EEEE-F9FF-FDFD-FFDE-C", false, "2017-03-14", "Profound needs-based interface", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 147, "Bulfoy", "Stacee", "10.5240/FEFE-6EFF-CEBE-FDEC-FD9E-C", false, "2008-06-23", "Stand-alone systematic portal", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 148, "Jacques", "Sid", "10.5240/EDFC-DEEF-EBFF-EEDF-FEEA-C", false, "2009-10-03", "Cloned encompassing hierarchy", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 149, "Esson", "Stefano", "10.5240/EFEF-FDCF-FBDE-FCFF-FEDF-C", false, "2003-05-24", "Realigned stable hardware", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 150, "Isaq", "Aylmer", "10.5240/F8FC-FCFF-DEEE-DFFE-FDFD-C", false, "2012-04-19", "Managed background flexibility", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 151, "Kraft", "Sheff", "10.5240/CFEF-EFEF-FFFF-BF8F-EFFD-C", false, "2004-02-03", "Cross-platform next generation structure", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 152, "Aimson", "Thurston", "10.5240/FEDF-EEFF-FECE-EDFC-FECC-C", false, "2017-08-17", "Synergized cohesive groupware", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 154, "Plimmer", "Gina", "10.5240/FEEE-FEAE-FFDE-EECF-FDFF-C", false, "2005-03-09", "Advanced solution-oriented benchmark", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 185, "Ely", "Fredia", "10.5240/DFEF-CEEC-ECDF-EFFB-FFFD-C", false, "2004-03-18", "Intuitive neutral info-mediaries", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 186, "Handrock", "Dur", "10.5240/FFDF-EFCD-EEBD-FFFD-EEEE-C", false, "2011-04-05", "Centralized logistical functionalities", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 187, "Czadla", "Tripp", "10.5240/EFFE-EEBE-FEBF-FDFE-EDFF-C", false, "2013-09-15", "Total dedicated methodology", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 220, "Tinmouth", "Sheilah", "10.5240/BEFF-FFFF-FFFE-CFEF-FBEF-C", false, "2000-04-03", "Persevering systematic help-desk", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 221, "Challoner", "Katrinka", "10.5240/EAFF-FFFE-CDED-FFFF-EFEF-C", false, "2014-10-22", "Self-enabling object-oriented task-force", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 222, "Chastenet", "Stafford", "10.5240/EFB8-EEEF-EFFF-DEDF-FFFF-C", false, "2010-04-06", "Robust upward-trending extranet", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 223, "Cuttle", "Kiersten", "10.5240/CEBF-FFB9-FEDE-EDFF-FFCE-C", false, "2018-07-25", "Seamless global interface", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 224, "Hegdonne", "Perren", "10.5240/FEFF-AFEF-EFFD-FEFF-EFFF-C", false, "1994-11-19", "Distributed zero defect protocol", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 225, "Scardifield", "Felice", "10.5240/DFFE-FFDF-FDAF-FFFB-EEEF-C", false, "2012-06-20", "Reactive fresh-thinking intranet", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 226, "Crockett", "Mela", "10.5240/EFFE-FFDF-6EFF-FDEF-DFFF-C", false, "1995-05-05", "Virtual user-facing encryption", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 227, "Fairholme", "Bobinette", "10.5240/FFFD-DEBF-FEFA-ECCB-EDFE-C", false, "2011-10-25", "Secured maximized workforce", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 228, "Garman", "Leilah", "10.5240/CFFE-9FDF-FEEE-FFEF-BFFD-C", false, "2000-10-24", "Organic regional groupware", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 229, "Marczyk", "Galina", "10.5240/FFFD-EFBF-FFF7-CFDE-FCED-C", false, "2014-06-15", "Synergistic secondary approach", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 230, "Woodeson", "Dottie", "10.5240/DFFF-FDCF-BFFF-FCFE-9DFE-C", false, "2017-02-07", "Universal multi-tasking complexity", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 231, "Berthome", "Ashlan", "10.5240/FFEE-CECF-FEDF-DEC9-CDFF-C", false, "1991-07-25", "Team-oriented mission-critical software", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 232, "Fulton", "Mandie", "10.5240/CEFF-CFFC-FECF-FCFC-FFCF-C", false, "2018-03-27", "Compatible foreground solution", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 233, "MacGilpatrick", "Lettie", "10.5240/FFEF-DCDF-FFFF-FFFF-FDEF-C", false, "1991-10-02", "Centralized coherent monitoring", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 234, "Yerborn", "Jeana", "10.5240/EFCD-DFEF-FFCF-BAEE-FFFF-C", false, "2007-06-29", "Front-line multi-state software", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 235, "Bolingbroke", "Jack", "10.5240/FFFD-CFFF-EFFE-FFFF-FFFF-C", false, "1997-08-24", "Upgradable zero tolerance budgetary management", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 236, "Von Gladbach", "Hal", "10.5240/CFFF-FEDF-FDFF-DFBF-FFFB-C", false, "1999-08-09", "Diverse regional moderator", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 237, "Squibbs", "Odetta", "10.5240/FFFE-EFFF-DEEF-DFDF-EDDF-C", false, "1993-05-08", "Monitored multi-tasking middleware", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 238, "Ebsworth", "Alison", "10.5240/FBFD-DEFF-EFDF-DEBF-FFFE-C", false, "2005-04-20", "De-engineered scalable capability", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 239, "Rochford", "Berkley", "10.5240/FFFF-EEDF-DCEF-FDDE-EDDE-C", false, "2017-10-08", "Object-based clear-thinking application", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 240, "McLarnon", "Ingaborg", "10.5240/FF9F-DF9F-FFCE-FFFF-8FFC-C", false, "1993-01-03", "Assimilated scalable standardization", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 241, "Swett", "Andie", "10.5240/DEEF-FCFD-CFEF-CCEF-FEBF-C", false, "2000-03-13", "Team-oriented client-server Graphic Interface", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 242, "Maud", "Celestyn", "10.5240/FDFE-FEFC-FBFD-EECF-CEFE-C", false, "1996-08-26", "Inverse disintermediate core", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 243, "Eustis", "Paxton", "10.5240/FFCF-EDDF-FFFD-DFFF-FFEE-C", false, "2006-02-12", "Configurable scalable projection", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 244, "Delue", "Tedman", "10.5240/BFFB-FDFF-FFFE-DBFF-FDFF-C", false, "2010-12-30", "Business-focused intermediate hardware", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 245, "Swann", "Edsel", "10.5240/EDEF-FBFF-FFFA-EEEE-FFBF-C", false, "2008-07-26", "Reduced well-modulated complexity", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 246, "Bukac", "Alick", "10.5240/EFEF-FBFE-DDFF-DFFF-FFBF-C", false, "2016-05-24", "Customer-focused optimizing parallelism", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 219, "Galego", "Allianora", "10.5240/EEBF-DFFD-FBDB-FEFD-FFCF-C", false, "2004-06-20", "Future-proofed systematic standardization", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 218, "Dod", "Reiko", "10.5240/CCFE-DDFB-DFFF-FEEE-FCFE-C", false, "1996-01-21", "Fully-configurable tangible extranet", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 217, "Stopp", "Roderick", "10.5240/FFBC-ED9D-FFED-EDEF-DDFD-C", false, "2005-08-08", "Multi-channelled 3rd generation protocol", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 216, "Ockwell", "Bryce", "10.5240/EFDF-FECF-AEDF-CEFE-FFEF-C", false, "2014-03-17", "Seamless zero defect matrices", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 188, "Goulter", "Kiley", "10.5240/DAFF-FFFF-EDFF-F5EF-ECFE-C", false, "2018-01-18", "User-centric client-server secured line", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 189, "Janes", "Nadine", "10.5240/FDEF-ECFE-DFBE-FDED-DFFF-C", false, "2018-05-11", "Right-sized radical standardization", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 190, "Denecamp", "Erastus", "10.5240/FEFF-FFFD-FBEF-EEEE-DCCF-C", false, "2015-04-14", "Enterprise-wide directional alliance", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 191, "Howler", "Hartley", "10.5240/FF8F-CFDE-CDCE-EEEE-CFCA-C", false, "2012-07-02", "Business-focused real-time support", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 192, "Teas", "Marla", "10.5240/E9EF-FEFF-FEFF-FFCF-FFFF-C", false, "2009-10-03", "Managed foreground intranet", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 193, "Flasby", "Cecilio", "10.5240/FEFF-EFCD-FDBF-FFEF-DFFF-C", false, "2018-01-10", "Triple-buffered scalable encoding", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 194, "Calbreath", "Marcelia", "10.5240/DEFF-EF8F-FDBF-FEFF-FEEE-C", false, "2007-04-20", "Innovative user-facing artificial intelligence", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 195, "Ernshaw", "Baillie", "10.5240/FBAF-FFEC-FFFE-FFFF-8EEF-C", false, "2003-08-24", "Integrated asymmetric analyzer", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 196, "Woolland", "Enos", "10.5240/CFDE-CFDC-CEFE-DDDF-FFFE-C", false, "2008-04-22", "Monitored radical array", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 197, "Lebang", "Cynthy", "10.5240/FCFF-AEED-EFEE-EEFF-EFDA-C", false, "2009-03-24", "Team-oriented needs-based groupware", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 198, "Schulke", "Warden", "10.5240/FDBF-EEFF-FCFF-FFDE-AEEF-C", false, "2008-01-02", "Up-sized asymmetric groupware", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 199, "Sayle", "Saxe", "10.5240/FFEF-EFCC-DFFE-FFFD-EEEF-C", false, "2009-04-04", "Streamlined secondary leverage", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 200, "MacTrustrie", "Alie", "10.5240/FDFF-EFEB-FFED-DFDF-DEDE-C", false, "1998-01-05", "Streamlined contextually-based standardization", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 125, "Vance", "Karel", "10.5240/CEDF-FBDE-FFDF-FEFF-FE9F-C", false, "1995-01-14", "Seamless full-range help-desk", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 201, "Stoneley", "Harley", "10.5240/3FFF-FFEE-FFCD-FFFE-FDFF-C", false, "1998-11-06", "Right-sized exuding productivity", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 203, "Merrell", "Aggi", "10.5240/FFFF-9FFD-FFEE-FFFE-FFAF-C", false, "1991-11-19", "Down-sized next generation info-mediaries", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 204, "Wedlake", "Frankie", "10.5240/FEFF-DAED-FEDF-FBDF-FDED-C", false, "2017-03-23", "Visionary multi-state encryption", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 205, "Shires", "Eveleen", "10.5240/FCFF-DDFF-FFDF-FDDE-EFEE-C", false, "1994-01-22", "Open-architected radical hardware", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 206, "Sedman", "Josephine", "10.5240/FFFF-FFFF-FFFF-AFFE-EDEF-C", false, "2007-03-26", "Self-enabling human-resource strategy", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 207, "Farney", "Sidoney", "10.5240/FFFE-FEEF-EFDF-BFDF-DFFF-C", false, "2003-05-30", "Reactive eco-centric orchestration", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 208, "Farrin", "Trip", "10.5240/FFFE-CFEB-AEFD-BFFD-FFCB-C", false, "1999-09-11", "Synergistic needs-based artificial intelligence", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 209, "Pirie", "Della", "10.5240/FFFF-EFDF-EDFF-FEEA-FBFE-C", false, "2010-01-03", "User-friendly tertiary migration", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 210, "Binstead", "Fidela", "10.5240/FFFC-DFCD-FFFF-FEAF-FFDF-C", false, "1998-11-15", "Object-based optimizing internet solution", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 211, "Clubley", "Shannon", "10.5240/CFEC-FCDE-FEFE-AFFD-FFFF-C", false, "2009-12-24", "Virtual heuristic capability", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 212, "Buckam", "Bridie", "10.5240/FCFF-FECF-FFCF-DFEF-FEDF-C", false, "2006-11-24", "Open-source bandwidth-monitored intranet", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 213, "Rollinshaw", "Mattie", "10.5240/DFFF-FEEA-BFFE-FEEC-FFED-C", false, "2002-12-06", "Horizontal mobile internet solution", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 214, "Horsey", "Tonya", "10.5240/FFFF-FEFE-EECE-DEDD-FFEE-C", false, "1998-06-04", "Vision-oriented maximized infrastructure", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 215, "Berends", "Arabele", "10.5240/EFFF-EDEF-DEFF-FFF9-FFFF-C", true, "1991-01-02", "Customer-focused bottom-line artificial intelligence", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 202, "Saull", "Genni", "10.5240/FFFE-FFFD-CFCF-EEFD-DFCF-C", false, "1991-02-04", "Persistent neutral secured line", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 247, "Gutridge", "Angie", "10.5240/CCEE-FFCE-EFFE-BFFF-FCFF-C", false, "2016-11-22", "Persistent background data-warehouse", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 124, "Kuhnwald", "Gawen", "10.5240/FDDE-FBEF-FFFA-EFFA-FEEC-C", false, "2004-05-06", "Object-based systematic protocol", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 122, "Pollett", "Miquela", "10.5240/CFFE-CFEE-FFCF-EFEF-FDFE-C", false, "2008-10-01", "Optional bi-directional challenge", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 32, "O'Dennehy", "Perren", "10.5240/FFFF-FEFD-DFFD-FFFE-FFED-C", false, "2011-09-03", "Customer-focused leading edge approach", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 33, "Albisser", "Amandy", "10.5240/EFFF-DE8E-ECED-FFFA-CCCE-C", false, "1995-05-27", "Triple-buffered radical budgetary management", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 34, "Orgee", "Laina", "10.5240/E9FE-EFFE-FDFE-FFFF-FEFF-C", false, "2000-12-31", "Innovative maximized help-desk", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 35, "Saiens", "Courtney", "10.5240/8CFF-FDFF-FFEF-FFDE-FEBF-C", false, "2014-05-12", "User-centric methodical budgetary management", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 36, "Baylay", "Catharine", "10.5240/FFFF-EFDB-EEDF-FFEE-DCFE-C", false, "1998-06-06", "Triple-buffered transitional frame", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 37, "Olijve", "Archibaldo", "10.5240/FEFF-EFFF-EFFE-EDFF-FEFE-C", false, "2009-07-24", "Triple-buffered zero administration leverage", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 38, "Hilhouse", "Leila", "10.5240/CFFB-FEF7-DFF6-FFFF-BFAF-C", false, "2018-02-28", "Programmable composite hardware", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 39, "Spaduzza", "Laurette", "10.5240/ACFF-FFDD-DFFF-FFFF-FFDC-C", false, "1999-11-26", "Pre-emptive 6th generation application", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 40, "Norres", "Bernardine", "10.5240/EFFF-FDDB-FCEE-EEFE-FFEE-C", false, "2018-08-24", "Stand-alone needs-based hardware", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 41, "Dubery", "Emmye", "10.5240/FEC9-C9EF-EFEB-BFCF-EDEE-C", false, "1998-01-31", "Ergonomic systematic knowledge user", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 42, "Whitear", "Genny", "10.5240/DEFF-FFFD-FEEE-FFBD-DFFE-C", false, "2018-04-13", "Synchronised encompassing contingency", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 43, "Matthieson", "Raynor", "10.5240/FFFD-EEFC-FEDF-EEFF-FDFE-C", false, "1996-01-07", "Persistent needs-based forecast", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 44, "Kettridge", "Paule", "10.5240/EEFE-BCFF-CF8F-FFFF-DEFF-C", false, "1991-11-22", "Distributed explicit infrastructure", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 45, "Le Guin", "Brendan", "10.5240/FEDE-EEEC-FEDF-BCFD-EBEF-C", false, "2016-02-23", "Profound even-keeled complexity", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 46, "Duesbury", "Otho", "10.5240/FFBF-EFFF-DEBA-FFBD-DEFF-C", false, "2007-06-19", "Cross-platform multimedia adapter", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 47, "Shieldon", "Tori", "10.5240/E8FE-CFEB-EFEF-FEFE-EEFF-C", false, "2015-08-13", "Centralized dedicated moderator", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 48, "Mannion", "Marcy", "10.5240/FEBE-EFEE-FFDF-FEFF-F7EB-C", false, "2004-10-06", "Networked value-added monitoring", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 49, "Leeke", "Dorolisa", "10.5240/FFFF-FEFE-EFEE-FEDF-ECFF-C", false, "1991-01-07", "Visionary multi-state functionalities", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 50, "Phillcock", "Boothe", "10.5240/FFEF-FFDF-FEDE-FFFB-A9FE-C", false, "2000-04-06", "Object-based intangible artificial intelligence", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 51, "Gheraldi", "Callean", "10.5240/CEEE-FF8E-FEDE-EEEC-FEFD-C", false, "2000-03-28", "Quality-focused contextually-based pricing structure", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 52, "Fissenden", "Nariko", "10.5240/FFDF-FFFF-FEFD-EFFD-9FFF-C", false, "1993-01-24", "Up-sized leading edge hierarchy", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 53, "Millgate", "Ezekiel", "10.5240/DFEF-FFDE-FFDC-FFFD-FDFF-C", false, "1994-03-21", "Exclusive mobile portal", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 54, "Waycot", "Ninnette", "10.5240/FEFE-DDFE-FFFC-FFFE-CFFE-C", false, "2002-09-21", "Intuitive attitude-oriented instruction set", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 55, "Flukes", "Dory", "10.5240/CDEE-FDFF-FEED-FCEB-FBDE-C", false, "2007-03-14", "Function-based homogeneous portal", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 56, "McKellen", "Waylan", "10.5240/FFFF-FEEF-FEEF-FFFC-EDDF-C", false, "2010-09-05", "Total needs-based software", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 57, "Binny", "Sheelagh", "10.5240/DEFE-EFEE-FEDF-FDEF-DFEB-C", false, "2013-02-06", "Future-proofed regional open architecture", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 58, "Meehan", "Judye", "10.5240/F8EC-FEED-FECF-DE9F-EFFF-C", false, "2009-04-03", "Assimilated systematic policy", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 31, "Moncarr", "Flo", "10.5240/CFED-DFFF-FFFE-DEEF-EFDF-C", false, "2010-04-01", "Fundamental well-modulated Graphical User Interface", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 59, "Obey", "Austen", "10.5240/FEED-FFFF-DFEF-DFEF-EFFD-C", false, "1994-10-13", "Expanded maximized instruction set", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 30, "Cuniam", "Tod", "10.5240/FEFF-FFEE-EDFF-FCFF-FAFE-C", false, "2006-11-25", "Automated transitional framework", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 28, "Angric", "Marnie", "10.5240/DCFF-DDFF-EFFC-FDFF-FFFF-C", false, "2001-08-16", "Innovative even-keeled archive", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 1, "Kitcatt", "Ethan", "10.5240/FFEF-FFCF-FE9E-AFFD-EFFF-C", false, "2001-09-01", "Face to face methodical throughput", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 2, "Faraday", "Babbie", "10.5240/FFFC-CDCF-EEFF-ADDC-CFFF-C", false, "2009-11-21", "Persistent hybrid implementation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 3, "Matiewe", "Wes", "10.5240/FDED-EFFF-FFDF-FDDF-FFEC-C", false, "2013-02-06", "Persevering solution-oriented hierarchy", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 4, "Harrop", "Maudie", "10.5240/FDC8-FFFA-FFFF-EFFF-FCED-C", false, "2012-12-13", "Visionary maximized internet solution", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 5, "Haugen", "Eydie", "10.5240/CFDF-7CCE-FFEF-FEFC-CDDF-C", false, "1996-09-07", "Optional optimal capacity", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 6, "Cheeney", "Lenee", "10.5240/FFCF-EFEF-EDFE-DFFE-FCFF-C", false, "1993-11-29", "Organic intermediate protocol", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 7, "Lemmon", "Edeline", "10.5240/FDDD-ED9F-EFED-CBEF-FDAD-C", false, "2009-07-09", "Integrated leading edge collaboration", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 8, "Aylwin", "Aurelea", "10.5240/FFFF-DEE6-FADC-EFFF-EEFC-C", false, "2001-05-19", "Multi-channelled heuristic attitude", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 9, "Esterbrook", "Alexandrina", "10.5240/CEFF-FCEE-EDEF-EDCF-FEEE-C", false, "1993-08-21", "Expanded national adapter", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 10, "Yegorovnin", "Grier", "10.5240/9FFD-FFFF-FFEE-ECFC-DAFC-C", false, "2008-06-11", "Decentralized explicit interface", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 11, "Cohalan", "Waring", "10.5240/FFFD-EFDF-FECF-AFFF-EFFE-C", false, "2002-07-06", "Fully-configurable attitude-oriented instruction set", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 12, "Christophle", "Othilia", "10.5240/CDFE-FEEF-FDBF-DEFC-FEFF-C", false, "1993-01-23", "Front-line encompassing database", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 13, "Tourry", "Immanuel", "10.5240/E9DF-BFFE-EBDF-FE9F-FFFF-C", false, "2011-03-10", "Cross-platform secondary leverage", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 14, "Chrestien", "Ivory", "10.5240/8FEF-FFEF-FFEF-EDFC-CEEE-C", false, "2012-09-29", "Re-engineered client-server migration", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 15, "Seefus", "Clim", "10.5240/FFFE-FFFC-FDDF-FFDB-FEFF-C", false, "1999-04-06", "Virtual human-resource info-mediaries", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 16, "Cavee", "Chev", "10.5240/FFDE-FEDC-FFCE-FFEF-EFEF-C", false, "1998-04-10", "Business-focused zero administration matrices", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 17, "Nisuis", "Phylis", "10.5240/FCFB-FFEE-EFFF-FEBB-A8FE-C", true, "2009-01-20", "Extended radical parallelism", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 18, "Bartholat", "Shelagh", "10.5240/EFFF-FEEE-FBFF-CFEF-FEFF-C", false, "2016-10-03", "Versatile stable open system", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 19, "Paulucci", "Rosmunda", "10.5240/EFDF-FDFE-CFFF-FDEF-FDAF-C", false, "2016-12-11", "Digitized impactful frame", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 20, "Leonardi", "Lesly", "10.5240/EEEE-EFFF-FECD-EEFF-FFFE-C", false, "2011-06-28", "Programmable 5th generation concept", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 21, "Lissandri", "Jaquith", "10.5240/E9EC-DD8D-FFDE-EEFF-FFDE-C", false, "2005-01-09", "Face to face responsive access", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 22, "Lucchi", "Bride", "10.5240/EDEF-FFCF-FFFF-EFBD-FE9F-C", false, "1998-05-30", "Realigned full-range leverage", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 23, "Novelli", "Ester", "10.5240/FFFF-DFDF-FDFE-EFFF-FEDB-C", false, "2016-01-23", "Advanced coherent approach", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 24, "Scallon", "Torin", "10.5240/FEFE-FEBF-FEDF-CBFF-FFFF-C", false, "2014-04-27", "User-centric responsive extranet", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 25, "Coomer", "Vern", "10.5240/ECFF-EFCF-ADEF-FCFF-EFEF-C", false, "2003-06-09", "Optional executive installation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 26, "Stonestreet", "Fabien", "10.5240/CFEB-EEEE-FFEE-FFFE-FFFF-C", false, "1998-04-17", "Stand-alone regional benchmark", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 27, "Geekie", "Anabal", "10.5240/DFCD-EEFE-FFFD-FFCC-BEFF-C", false, "2015-02-04", "Reverse-engineered local circuit", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 29, "Wilkenson", "Lonni", "10.5240/CCFD-EFFF-EEF9-FDFF-FDFF-C", false, "2011-04-18", "Versatile holistic throughput", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 60, "Bruty", "Roch", "10.5240/EFFE-EEDF-FFFF-FFBF-DFEE-C", false, "1996-12-17", "Customer-focused zero defect moderator", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 61, "Patterson", "Darline", "10.5240/FFFE-FFFC-EDCF-CEED-EFFF-C", false, "2018-05-25", "Ergonomic static support", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 62, "Schnieder", "Whittaker", "10.5240/D9FE-FFFF-FEEF-DEFD-EFFE-C", false, "1990-10-26", "Synergized 5th generation time-frame", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 95, "Nowill", "Rene", "10.5240/EEDE-FEFE-FDFF-FFED-FFEE-C", false, "2002-06-10", "Function-based mission-critical interface", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 96, "Dowglass", "Celestyna", "10.5240/FBCF-BFCF-DFFE-EFCF-AEDD-C", false, "2005-03-27", "Up-sized multi-tasking matrices", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 97, "Redshaw", "Kayle", "10.5240/EFFF-FFAF-FEFE-DFFF-CDFF-C", false, "2018-04-22", "Cloned zero tolerance product", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 98, "Britner", "Marice", "10.5240/BEEE-ECFE-FBDE-FCEF-FFCD-C", false, "2001-09-17", "Progressive fault-tolerant monitoring", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 99, "Kimber", "Erik", "10.5240/FFEE-FFFF-DFFE-FDFE-FDDF-C", false, "2004-11-21", "Adaptive intermediate focus group", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 100, "Leeke", "Gwenore", "10.5240/EEFF-EEFE-CEBF-EEFF-CEEF-C", false, "2010-03-26", "Persistent local time-frame", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 101, "Coddrington", "Laural", "10.5240/EEFD-FEFE-EDFE-FFEE-9EFE-C", false, "2017-05-13", "Exclusive asymmetric archive", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 102, "Ambler", "Shaylyn", "10.5240/EFCF-FFEF-DFFF-FFED-FFFD-C", false, "2000-05-11", "Business-focused responsive info-mediaries", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 103, "Stirrip", "Marrilee", "10.5240/FBEF-EFFE-DFCF-FFFF-FEFE-C", false, "2008-01-24", "Open-architected asynchronous Graphical User Interface", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 104, "Last", "Tally", "10.5240/FEFA-EFED-DDEF-FDEE-EFFE-C", false, "2008-11-14", "Programmable reciprocal data-warehouse", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 105, "Marcinkowski", "Fancie", "10.5240/DDFC-DEBD-FDCF-FFEF-E7DF-C", false, "2016-12-22", "Reactive optimizing open system", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 106, "Milsted", "Amelina", "10.5240/DEFE-FFFD-FEEF-EEFE-EFFA-C", false, "2008-06-06", "Enterprise-wide radical standardization", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 107, "Raymond", "Jacobo", "10.5240/FFDE-EFFF-EFEE-FFED-EFBE-C", false, "2012-06-28", "Expanded national ability", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 108, "Farrens", "Codee", "10.5240/EFED-BFFE-EDCF-FDEF-FDFF-C", false, "2015-01-20", "Team-oriented human-resource implementation", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 109, "Abrashkov", "Ty", "10.5240/FFFD-EEEF-FFFF-EEDF-EFFF-C", false, "1994-04-01", "Quality-focused high-level standardization", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 110, "Potteril", "Tamar", "10.5240/FFFF-FFFE-EFEF-FEFE-EFFE-C", false, "2009-05-21", "Networked bi-directional conglomeration", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 111, "Corssen", "Wendel", "10.5240/EFEE-FDFF-EFEE-FDFF-5CFF-C", false, "2002-07-28", "Distributed disintermediate process improvement", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 112, "Rogliero", "Desi", "10.5240/EDED-DFFF-FFDE-FFFF-AFFF-C", false, "1991-02-13", "Team-oriented foreground flexibility", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 113, "Aldhous", "Beltran", "10.5240/FEAF-EFEC-EFFE-FEF9-FEFF-C", false, "2000-08-19", "Customizable content-based adapter", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 114, "Ricco", "Teena", "10.5240/FFFF-CFFE-EEDF-CFEF-9FFE-C", false, "2003-06-21", "Seamless content-based analyzer", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 115, "Fitch", "Kala", "10.5240/FFFF-EFFF-BFFE-FFFF-AFFF-C", false, "1999-07-14", "Intuitive intermediate adapter", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 116, "Bruton", "Morganne", "10.5240/FEFD-FEFE-EFFF-DFFF-FDFF-C", false, "1992-04-30", "Enterprise-wide optimizing attitude", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 117, "Handes", "Tomlin", "10.5240/DFCF-FEFF-FDFF-D9FD-FEFF-C", false, "2004-02-15", "Reduced systemic intranet", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 118, "Groome", "Gisela", "10.5240/FFDE-FEBD-EBFD-FDFF-EFFF-C", false, "1994-09-21", "Optimized human-resource functionalities", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 119, "Gareisr", "Westbrooke", "10.5240/FDFF-EFDF-EFFE-FFFF-FFFE-C", false, "2000-10-08", "Business-focused global budgetary management", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 120, "Sancto", "Fanya", "10.5240/CCFD-FFDF-DEFF-CFEB-EFFE-C", false, "1991-06-26", "Multi-lateral uniform process improvement", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 121, "Bradd", "El", "10.5240/DFFF-FFDD-FDEF-EFFF-DAFE-C", false, "2001-04-08", "Integrated multimedia infrastructure", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 94, "Ensor", "Eba", "10.5240/CEFD-DFFE-6EFE-DDFF-DCFF-C", false, "2014-04-19", "Automated tertiary database", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 93, "Buntin", "Linc", "10.5240/FEFE-BDDF-FFEF-ECFF-FEFF-C", false, "1992-09-08", "Seamless regional benchmark", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 92, "Ladel", "Reube", "10.5240/EFFF-DFFE-FDEF-DF8D-EFED-C", false, "1993-03-22", "Polarised needs-based structure", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 91, "Redish", "Emilie", "10.5240/FFFF-FEFD-FFFE-FDFF-DDFE-C", false, "1991-09-16", "Reactive multi-state architecture", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 63, "Corbould", "Chloette", "10.5240/FD9F-DFFF-FAFE-FFFF-FEFF-C", false, "1996-01-24", "Persistent multi-state core", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 64, "Tremontana", "Esra", "10.5240/EFED-DFED-FEBD-F9FF-EEE9-C", false, "2012-08-07", "Universal intangible neural-net", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 65, "Hartfleet", "Lusa", "10.5240/FDF9-FDFF-EEFF-F9FE-FFFF-C", false, "1997-10-29", "Automated disintermediate emulation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 66, "Greguol", "Ebonee", "10.5240/AFDB-FDFF-FFED-FEBD-EDEF-C", false, "2015-03-20", "Devolved web-enabled support", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 67, "Raisbeck", "Paola", "10.5240/FFBF-FBFE-EFFF-FEEF-FBFA-C", false, "1998-03-10", "Cross-group exuding protocol", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 68, "Gifkins", "Timmi", "10.5240/FEED-FFFF-DDFD-FEFF-DDAF-C", false, "2015-10-06", "Synchronised 3rd generation ability", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 69, "Lilly", "Dareen", "10.5240/FEFF-DDFE-FEFD-EFFE-FDFD-C", false, "1992-12-21", "Exclusive neutral hardware", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 70, "Shapero", "Mersey", "10.5240/DFEF-EFEF-FFFD-EFEE-EDDB-C", false, "1998-05-15", "Seamless non-volatile matrices", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 71, "Whild", "Rainer", "10.5240/EFFC-EDDF-DFEF-D9EF-FDEF-C", false, "1997-12-09", "Networked solution-oriented functionalities", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 72, "Becket", "Paquito", "10.5240/FFEE-EFED-EFFE-FFFF-FFCF-C", false, "2002-01-18", "Robust next generation approach", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 73, "Geering", "Christabella", "10.5240/FCFE-FFFE-CFFD-DEEE-EFFB-C", false, "2013-06-26", "Persevering zero tolerance intranet", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 74, "Harbach", "Hank", "10.5240/ECFE-DFEF-EFBF-EDFF-EFFF-C", false, "1997-06-26", "Monitored next generation utilisation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 75, "Ockland", "Kris", "10.5240/DFFC-EFCE-DFEF-EFCE-EFCE-C", false, "1997-01-20", "Expanded multi-state forecast", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 123, "Carncross", "Skye", "10.5240/F7FC-EDFE-FFEF-FFED-EFAD-C", false, "2005-12-24", "Advanced even-keeled benchmark", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 76, "Tumasian", "Renado", "10.5240/EFBE-FFFA-EBFF-FEEE-FFFD-C", false, "2004-08-06", "Phased transitional process improvement", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 78, "Milesop", "Putnam", "10.5240/FFEE-FEFF-CFDF-FDEB-EEFF-C", false, "2003-06-14", "Expanded asymmetric challenge", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 79, "Eake", "Stoddard", "10.5240/FEEF-FFCF-EFCF-FDEC-FFFD-C", false, "2011-11-25", "Focused bandwidth-monitored conglomeration", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 80, "Daudray", "Aluin", "10.5240/DECE-9FD8-DBCE-FEED-FEDF-C", false, "2017-12-11", "Robust directional local area network", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 81, "Levene", "Clerkclaude", "10.5240/FFFF-FEEC-FFCD-FCFF-EFEF-C", false, "2000-05-20", "Monitored dynamic policy", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 82, "Broomhall", "Kaja", "10.5240/FECF-EEFF-BFFF-FEEF-DBFD-C", false, "2016-05-04", "Balanced directional definition", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 83, "Patridge", "Henderson", "10.5240/CECF-CEFF-FDFF-FEEF-EEFF-C", false, "1991-12-25", "Intuitive optimizing array", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 84, "Somner", "Ev", "10.5240/FC9F-FFFD-CCFD-DFFC-FDBF-C", false, "2004-08-14", "Future-proofed secondary info-mediaries", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 85, "Pedreschi", "Lonna", "10.5240/DEFA-FEFE-FDEF-F8DD-CEEE-C", false, "1998-05-08", "Implemented full-range database", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 86, "Kingdon", "Osborne", "10.5240/EFFF-FFEF-8FFE-FFFD-EFFF-C", false, "2014-08-10", "User-friendly local infrastructure", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 87, "Cassy", "Pryce", "10.5240/FDEF-FFFF-FCBD-EEFF-EEF4-C", false, "2014-04-11", "Customer-focused real-time groupware", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 88, "Grayshan", "Jolynn", "10.5240/C9FF-FBFD-DEED-FFFC-FFFE-C", false, "2003-08-09", "Open-source clear-thinking leverage", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 89, "Tibbetts", "Stormie", "10.5240/FFFF-CFFF-FEFE-EFED-FEFF-C", false, "1996-08-10", "Open-architected radical task-force", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 90, "Windybank", "Loraine", "10.5240/FFFA-FFFB-FDFF-FEFF-FFFE-C", false, "2003-11-20", "Profit-focused web-enabled portal", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 77, "Tullot", "Jennifer", "10.5240/FFCE-FF9C-EEFC-EFFF-DECC-C", false, "1999-11-03", "Enhanced multi-tasking architecture", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 248, "Saladin", "Nanci", "10.5240/CFFF-EEFE-EEDE-FFFF-FDEE-C", false, "1991-12-27", "Vision-oriented object-oriented initiative", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 249, "Kilfedder", "Hedwig", "10.5240/FEDD-ECFE-FEFD-AFEF-DDCF-C", false, "2014-09-10", "Profound analyzing project", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 250, "Inkle", "Serena", "10.5240/EFFF-AFDE-EE9F-DFDF-FEFD-C", false, "1993-04-29", "Reactive motivating open system", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 408, "Tubritt", "Doloritas", "10.5240/FEDF-EEFF-FCCF-FEFC-FEFE-C", false, "2014-04-18", "Organized methodical definition", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 409, "McShirrie", "Red", "10.5240/DFFD-FFFD-EFFE-CCFF-FEFD-C", false, "1999-11-10", "De-engineered motivating leverage", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 410, "Raggett", "Cthrine", "10.5240/CFEE-EEEF-FEDE-FFEF-EFFD-C", false, "2016-05-28", "Business-focused system-worthy project", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 411, "Maberley", "Bernadina", "10.5240/FCFE-FFDF-EFEF-CFFE-FFFF-C", false, "2017-05-30", "Innovative intermediate interface", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 412, "Dive", "Booth", "10.5240/FFEE-EBFD-FFEE-EFED-FFBE-C", false, "1996-12-01", "Managed full-range collaboration", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 413, "Moakes", "Karleen", "10.5240/ADED-FFFE-FECF-DFFD-FECE-C", false, "2008-08-26", "Open-source object-oriented artificial intelligence", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 414, "Inseal", "Ruben", "10.5240/EFEF-9FFF-FFFE-FFED-9FFF-C", false, "2007-06-17", "Total stable success", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 415, "Biskupiak", "Laetitia", "10.5240/FDFD-EDFD-FFFE-DECC-BFFF-C", false, "1992-09-05", "Distributed coherent website", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 416, "Reinhardt", "Rudolf", "10.5240/FFEF-FEFF-DDFD-BCEE-FFFB-C", false, "2000-11-26", "Centralized discrete challenge", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 417, "Starrs", "Ardeen", "10.5240/EFDD-FEFF-FEFF-DDFF-DFEF-C", true, "2000-01-25", "Switchable eco-centric moratorium", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 418, "Money", "Francyne", "10.5240/FCFF-DFFF-EEDC-FEFE-FEEF-C", false, "1996-12-08", "Horizontal logistical customer loyalty", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 419, "Florey", "Rodolphe", "10.5240/DFED-FCDB-EFFF-CCFD-FDBE-C", false, "2001-09-16", "Customer-focused stable neural-net", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 420, "Bruniges", "Harper", "10.5240/FCEF-BDFE-DCEA-FFFF-EFEF-C", false, "2006-12-04", "Expanded well-modulated methodology", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 421, "Strang", "Masha", "10.5240/EEFE-FEF9-FFFE-FCEC-8CFF-C", false, "1995-09-15", "Synchronised dedicated time-frame", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 422, "Densumbe", "Sarajane", "10.5240/FFAD-DCCE-DDFF-D6FF-EEFE-C", false, "2007-11-16", "Multi-layered background encryption", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 423, "Bellany", "Nady", "10.5240/EDDE-FFEF-FFDC-CFFD-ECFF-C", false, "2009-11-27", "Multi-channelled dedicated solution", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 424, "Jimson", "Estelle", "10.5240/FFFE-EFDF-DEFF-DDED-EDEF-C", false, "1999-06-15", "Progressive analyzing capability", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 425, "Croson", "Allyn", "10.5240/DFFE-FEDD-FFDE-EFEF-EEFD-C", false, "1996-09-09", "Diverse 5th generation installation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 426, "Chestle", "Vida", "10.5240/FFFE-CDFC-BDEE-EFEE-EEDF-C", false, "2018-03-03", "Customer-focused empowering circuit", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 427, "Spatoni", "Ariel", "10.5240/FFBD-EFEF-FFFF-CD9D-FBFD-C", false, "2014-08-22", "Sharable well-modulated middleware", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 428, "Flade", "Lorin", "10.5240/DEFF-CEFD-FBDD-DBFF-CFEF-C", false, "2004-03-23", "Reactive high-level process improvement", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 429, "Deverill", "Osmond", "10.5240/C9DE-DDFC-FFEF-EEED-EEDF-C", false, "2007-10-30", "Robust zero administration pricing structure", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 430, "Wildbore", "Ursulina", "10.5240/F6FF-EBEF-FFDE-CFFF-FEEE-C", false, "2009-05-11", "Robust encompassing application", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 431, "Verryan", "Victoir", "10.5240/FFDE-FEFE-FFED-FD9C-DFEB-C", false, "2000-11-01", "Organic dedicated secured line", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 432, "Dreger", "Patrizio", "10.5240/FDFF-CEDF-FFC8-FEDE-FEEF-C", false, "2016-01-06", "Front-line systemic policy", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 433, "Titcumb", "Berni", "10.5240/FEEF-FEEE-DFCC-EEFE-EEEF-C", false, "2007-02-05", "Expanded multi-tasking secured line", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 434, "Moiser", "Anjela", "10.5240/EFFF-FFEF-FFEC-DEFA-AEFF-C", false, "1996-07-23", "Multi-layered optimal challenge", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 407, "Pemble", "Wilfrid", "10.5240/FFEF-FECD-F8EE-FFED-EFFE-C", false, "2012-05-23", "Horizontal well-modulated framework", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 435, "Burker", "Ase", "10.5240/F9FF-EFFE-9EDF-EDFF-FFFF-C", false, "2002-01-05", "Expanded object-oriented protocol", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 406, "Backson", "Kellia", "10.5240/EFFF-FEED-FECC-FEFE-DEEF-C", false, "1992-09-02", "Vision-oriented global alliance", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 404, "De Witt", "Larisa", "10.5240/FFFF-EDFF-FE8F-FEEF-DEEF-C", false, "1999-03-15", "Down-sized responsive toolset", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 377, "Archbutt", "Lucie", "10.5240/FEEF-FFBF-FEDD-FCFF-EDDD-C", false, "2018-07-09", "Public-key uniform synergy", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 378, "Charman", "Angus", "10.5240/FAFB-EEED-FCFF-FFEB-DCFE-C", false, "2012-06-23", "Programmable client-server utilisation", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 379, "Donnelly", "Nancy", "10.5240/EEFF-FEDD-EEDD-DDFF-BEFE-C", false, "2007-11-15", "Phased methodical migration", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 380, "Barhem", "Englebert", "10.5240/FFFF-FAEB-CFFD-DFDE-CFFC-C", false, "2012-09-18", "Right-sized methodical capacity", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 381, "Burditt", "Dona", "10.5240/FFEF-FFDD-FECF-FFFF-EFEF-C", false, "1993-03-21", "Centralized actuating structure", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 382, "Portigall", "Latisha", "10.5240/FFEF-FFEF-DFFF-FEEE-FEFF-C", false, "2000-07-24", "Inverse multi-state support", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 383, "Zorer", "Tonnie", "10.5240/EFEF-EEEF-EFEF-EFEF-FEDE-C", false, "2017-09-02", "Up-sized intermediate workforce", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 384, "Broschek", "Melloney", "10.5240/EFBF-FFFF-CEFF-CFFF-FFDF-C", false, "1995-08-07", "Future-proofed directional process improvement", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 385, "Rickersey", "Allianora", "10.5240/FDDF-F9EC-FEFD-FFEE-DFEF-C", false, "2012-09-25", "Advanced full-range concept", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 386, "Dundredge", "Wren", "10.5240/FDFE-FFCE-FFFF-FDFF-FFFE-C", false, "1996-02-04", "Managed analyzing throughput", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 387, "Titcumb", "Ofella", "10.5240/EFFE-FEEF-FDCF-ECFF-FCEC-C", false, "2008-12-15", "Diverse high-level paradigm", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 388, "Stearndale", "Roanne", "10.5240/FEFE-EFBF-FFFE-FF8D-FDCD-C", false, "1999-09-19", "De-engineered neutral superstructure", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 389, "Grinikhinov", "Law", "10.5240/CFFF-FEDF-AEFE-FECF-FFFE-C", false, "1992-07-25", "Total empowering capacity", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 390, "Mayger", "Rollins", "10.5240/FFEE-DFEF-EFFF-FDFF-ECEE-C", false, "2013-11-17", "Integrated responsive adapter", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 391, "Boddice", "Lanie", "10.5240/FFFF-FEFD-FFFF-EECE-AFEF-C", false, "2000-11-20", "Object-based exuding help-desk", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 392, "Ughi", "Marie-jeanne", "10.5240/F7EC-EEDD-FCEF-FFFF-DFFF-C", false, "2010-04-14", "De-engineered real-time collaboration", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 393, "Easthope", "Erin", "10.5240/FFBF-DEFE-DFEF-FFED-FFFF-C", false, "2009-07-07", "Open-architected maximized application", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 394, "Romanelli", "Chilton", "10.5240/FECE-FEFD-FFFE-DFEE-DDDE-C", false, "2009-02-11", "Monitored high-level encoding", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 395, "Wheildon", "Juditha", "10.5240/F8FD-FFFF-FFFE-FFFF-FDA3-C", false, "1990-10-20", "Public-key user-facing framework", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 396, "Bedberry", "Gerrard", "10.5240/DEFE-FDFF-FFFF-F9EF-FFFC-C", false, "2010-05-19", "Multi-lateral fault-tolerant secured line", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 397, "Barron", "Ardra", "10.5240/EEFD-CAFC-EDCD-FBFF-FCFF-C", false, "1993-10-05", "Cloned eco-centric artificial intelligence", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 398, "Melsome", "Gonzales", "10.5240/EFEF-FEFE-FFFD-FFFF-FDFF-C", false, "1991-02-05", "Configurable static encryption", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 399, "Carrabot", "Viviene", "10.5240/DFFB-FBEF-FCDD-EE9D-CEFE-C", false, "2003-09-01", "Adaptive client-driven emulation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 400, "Hamlyn", "Bentlee", "10.5240/EFFD-EEFE-FEFE-ECEF-FE7F-C", false, "1997-01-22", "Implemented tertiary framework", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 401, "Ferrarese", "Ulrika", "10.5240/EEFF-CEEE-FBF7-BFAD-FEFE-C", false, "1991-10-04", "Inverse user-facing groupware", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 402, "Stallebrass", "Bette", "10.5240/EFFF-FFDF-FEEF-FFBF-FFFF-C", false, "2012-11-28", "Optional real-time hub", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 403, "Isaaksohn", "Mendy", "10.5240/EECE-DEEF-FACF-7FFF-DFEF-C", false, "2016-12-29", "Profit-focused heuristic knowledge user", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 405, "Geall", "Kessiah", "10.5240/FFDE-FEEF-FDAF-EFCC-CFFF-C", false, "2003-08-15", "Multi-layered transitional knowledge base", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 999, "Swancock", "Jard", "10.5240/FDDB-AEFC-DEEE-FFDF-BDFF-C", true, "1998-06-03", "Up-sized methodical policy", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 437, "Spadazzi", "Lolita", "10.5240/FCAF-FFFF-FFCF-EFDF-DDEF-C", false, "2008-01-24", "Cross-group dedicated middleware", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 438, "Craigg", "Harriott", "10.5240/EBFF-CFFD-EFEE-CEDF-EFCF-C", false, "1991-07-18", "User-friendly non-volatile hierarchy", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 471, "Addicott", "Rennie", "10.5240/DEEF-FFFD-D8FF-EFEF-EDFF-C", false, "1991-02-25", "Optional local open system", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 472, "Delgadillo", "Anissa", "10.5240/FFFF-EFEB-FEFF-FFFF-CEEA-C", false, "1991-05-15", "Compatible dedicated architecture", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 473, "Geddes", "Fey", "10.5240/FFEE-FDED-9FDF-F5AE-FFEF-C", false, "2014-10-22", "Ameliorated optimal process improvement", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 474, "Kinvig", "Cortney", "10.5240/FDFE-FFFE-FEEF-EDFE-DEFE-C", false, "2001-07-02", "Future-proofed cohesive help-desk", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 475, "Daniely", "Lezley", "10.5240/FFEA-CDBF-FFFD-FFDF-EFFF-C", false, "2005-04-08", "User-friendly reciprocal function", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 476, "Diddams", "Barthel", "10.5240/FEFF-FECE-EFFE-EFEF-BEED-C", false, "1994-03-29", "Multi-layered bandwidth-monitored local area network", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 477, "Byk", "Susana", "10.5240/FE9D-FFFF-EEEF-FFEA-FDAE-C", false, "2006-06-02", "Universal background capacity", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 478, "Von Helmholtz", "Merna", "10.5240/EBFF-FEEF-CFFE-FFDF-FE8F-C", false, "1993-02-10", "Virtual analyzing collaboration", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 479, "Form", "Rodrique", "10.5240/CDEC-DEFD-EDEF-DFFE-EEED-C", false, "2013-12-07", "Reduced upward-trending product", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 480, "Hundal", "Margot", "10.5240/FFE7-CDBF-DFEF-FEFF-DEEF-C", false, "2009-12-26", "Up-sized foreground structure", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 481, "Miners", "Zaria", "10.5240/EF4F-EFFC-EFED-EFF9-FDEF-C", false, "1992-05-02", "Ameliorated zero administration encryption", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 482, "Norker", "Pegeen", "10.5240/DCFD-FDFF-FCEF-DEFF-EFEF-C", false, "2003-01-23", "Operative clear-thinking pricing structure", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 483, "Figg", "Burke", "10.5240/FFCE-EFEE-FFEF-FFFC-FFED-C", false, "2015-09-13", "Switchable radical leverage", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 484, "Olivia", "Gaspar", "10.5240/FFEF-EEFD-FEEF-FECF-FFFF-C", false, "1994-01-07", "Organized responsive forecast", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 485, "Arnholz", "Joann", "10.5240/EDFE-FEFE-ECCF-FEEF-FEFE-C", false, "1996-05-25", "Cross-group maximized firmware", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 486, "Hammond", "Dorine", "10.5240/FDEE-EFCF-ECEE-FFCF-F9DA-C", false, "1996-01-12", "Enterprise-wide modular concept", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 487, "Nassau", "Cherye", "10.5240/FDEE-EDFF-EFFE-CEFF-EFEF-C", false, "2007-05-13", "Expanded hybrid service-desk", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 488, "Terlinden", "Gwendolin", "10.5240/FEDE-FFFE-EFEF-EDFE-EFFE-C", false, "1998-12-10", "Centralized content-based adapter", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 489, "Horsewood", "Barny", "10.5240/DEFD-FDBC-DEFE-EEEE-DEEF-C", false, "1995-01-27", "Operative user-facing local area network", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 490, "Castellet", "Nisse", "10.5240/FDFE-ECFF-FEEF-FEDD-CDEF-C", false, "2006-11-12", "Triple-buffered 5th generation internet solution", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 491, "Freddi", "Constantine", "10.5240/FFDF-CFFF-DFFD-FFAE-FFFB-C", false, "2017-05-12", "Synchronised user-facing complexity", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 492, "Clougher", "Lydon", "10.5240/FFFE-AEEF-EEFE-EFFC-FBFC-C", false, "2015-01-09", "Profound attitude-oriented workforce", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 493, "Heynel", "Nichol", "10.5240/DDEE-FEFF-BBEE-CFFF-FFFF-C", true, "2007-09-21", "Realigned 24/7 emulation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 494, "Stailey", "Noni", "10.5240/FFEF-FEFF-FEFE-FFFC-EFFF-C", false, "2011-08-31", "Cross-platform non-volatile task-force", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 495, "Corrie", "Tarrah", "10.5240/FED6-FDFF-E9FE-DFED-FDFD-C", false, "1994-06-26", "Monitored incremental encryption", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 496, "Goodlatt", "Bernardina", "10.5240/FFED-EFFF-EEEE-DFFF-EFFA-C", false, "1995-11-04", "Horizontal methodical help-desk", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 497, "Chesser", "Chris", "10.5240/FFDE-BEEF-FFDF-FBDD-FCFD-C", false, "2006-09-29", "Customer-focused exuding archive", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 470, "Humbles", "Mirilla", "10.5240/FEFF-FEFF-BEFF-DEFF-FDBE-C", false, "2009-10-17", "Multi-layered solution-oriented artificial intelligence", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 469, "MacHarg", "Merle", "10.5240/FEEF-EFFC-EDFE-EDDF-BFFF-C", false, "2005-04-18", "Public-key content-based pricing structure", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 468, "Merrywether", "Ichabod", "10.5240/CDFF-FFFF-EEFF-FFFF-FEFB-C", false, "2000-11-11", "Business-focused contextually-based focus group", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 467, "Knolles-Green", "Percival", "10.5240/FDEF-AEEF-EFFF-FCFB-FFDF-C", false, "2002-07-22", "Re-engineered leading edge functionalities", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 439, "Cromack", "Gaile", "10.5240/FFFE-EFBF-FBFF-FDFF-DEFF-C", false, "2001-06-01", "Multi-tiered solution-oriented collaboration", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 440, "Jockle", "Chantal", "10.5240/FFFF-CFFF-EDEC-EEEE-EBDE-C", false, "2015-08-15", "Automated empowering portal", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 441, "Chaudron", "Emmott", "10.5240/EEFD-DBFD-FFAE-FFFE-FFFF-C", false, "1998-10-04", "Open-architected mobile parallelism", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 442, "Gaiter", "Alasdair", "10.5240/EDFE-EFFE-FFFB-DCEB-FEFE-C", false, "1991-04-04", "Synchronised 4th generation Graphical User Interface", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 443, "Ilyunin", "Traver", "10.5240/FEEE-FFCF-FFED-FBFF-FFFF-C", false, "2004-10-26", "Implemented eco-centric extranet", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 444, "Poacher", "Meris", "10.5240/FFDE-FFFF-FEEB-EEFF-FBFE-C", false, "2017-06-23", "Synergized demand-driven attitude", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 445, "Caddick", "Raff", "10.5240/EADF-FEFE-DFEF-FEEE-FFAD-C", false, "1991-07-04", "Balanced bandwidth-monitored protocol", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 446, "Gillan", "Bartolomeo", "10.5240/EFFE-FEFF-FEDE-7FFD-DDFE-C", false, "2006-05-24", "Profit-focused intermediate installation", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 447, "Kerrod", "Gram", "10.5240/FFCD-FFEF-9FFF-FFAF-EFDE-C", false, "1998-06-23", "Open-source mobile support", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 448, "Tschirasche", "Arri", "10.5240/BFEF-CDFF-DFFF-FECF-EFEE-C", false, "2000-04-05", "Streamlined systematic database", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 449, "Lukins", "Zola", "10.5240/FDFF-9DED-FAFF-FFFE-FFFE-C", false, "2004-05-31", "Future-proofed maximized core", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 450, "Castelyn", "Den", "10.5240/FEEF-FDFE-FFEA-EEDF-EFAA-C", false, "1996-07-12", "Multi-channelled maximized capability", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 451, "Mackstead", "Dom", "10.5240/FFDF-EEEF-DEFD-FDCC-EFFF-C", false, "1999-01-16", "Networked bifurcated application", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 376, "Greeve", "Ellene", "10.5240/EFFF-DFFF-EFFF-FFEE-9FCE-C", false, "2002-12-02", "Adaptive bi-directional internet solution", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 452, "Lewington", "Evered", "10.5240/FEFE-FEBE-FEBE-FFFE-AEFE-C", false, "1997-05-07", "Compatible even-keeled extranet", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 454, "Benettelli", "Angelico", "10.5240/EEDF-EEFD-FFFF-FDDF-EFFE-C", false, "2001-12-02", "Horizontal demand-driven implementation", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 455, "Olechnowicz", "Caren", "10.5240/FCFF-EEBE-FECF-EEEF-FEFE-C", false, "2000-03-11", "Distributed explicit moratorium", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 456, "Breeze", "Leda", "10.5240/DFFF-FFEE-FE8E-FEFE-FFFF-C", false, "2005-09-05", "Configurable executive hierarchy", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 457, "Gouldsmith", "Desirae", "10.5240/FFFF-FFDE-9EFF-FFFF-EDDD-C", false, "1998-12-08", "Virtual bandwidth-monitored time-frame", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 458, "Orvis", "Wandie", "10.5240/BEDF-ECFD-FFDE-ECFD-DEEE-C", false, "2001-06-09", "Cross-group web-enabled moderator", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 459, "Crossingham", "Trstram", "10.5240/EEED-FCFF-FFFC-FDCF-DCEE-C", false, "1994-11-26", "Streamlined upward-trending strategy", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 460, "Littlewood", "Hans", "10.5240/DFFE-DFFF-AFFF-EFFE-FFDF-C", false, "2017-11-28", "Profit-focused reciprocal capacity", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 461, "Easun", "Ann", "10.5240/ECFC-CFEE-FFEE-FEFF-FEEC-C", false, "1996-01-31", "De-engineered clear-thinking benchmark", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 462, "Vasyunin", "Foster", "10.5240/FF9F-FFFF-DFEC-FFFE-FEDF-C", false, "1998-03-15", "Mandatory radical strategy", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 463, "Eakeley", "Trixie", "10.5240/FFFF-EFFF-FFEF-FDFE-CEDE-C", false, "2011-01-13", "Optimized holistic structure", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 464, "Hyslop", "Berti", "10.5240/CFFD-FEFF-EEFF-CFFF-EEFD-C", false, "1991-09-02", "Reactive web-enabled initiative", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 465, "Louiset", "Edmon", "10.5240/FEBF-EFFE-AFFD-FDEF-DFAE-C", false, "1995-08-25", "Exclusive tangible alliance", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 466, "O'Scandall", "Ivan", "10.5240/EDFD-EEFF-8FFF-DDFD-FCEA-C", false, "1999-06-15", "User-centric background open architecture", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 453, "Orrick", "Ive", "10.5240/FDDE-ECEF-FEFE-FFFE-EFDF-C", false, "2007-11-07", "Focused bottom-line Graphic Interface", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 375, "Poel", "Jackie", "10.5240/EFFE-EFEE-FE8F-FDE9-EEFF-C", false, "1991-01-20", "Multi-channelled clear-thinking monitoring", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 374, "Quested", "Claiborne", "10.5240/FEDA-9ECC-FFFF-CE9F-FDED-C", false, "1992-05-30", "Digitized directional concept", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 373, "Ambrozewicz", "Alane", "10.5240/CFFE-EFFE-DEFE-FCDA-FFEE-C", false, "1997-12-23", "Ameliorated systematic function", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 283, "MacCarter", "Colan", "10.5240/DDFE-EFFF-FFFF-FEEE-CDFE-C", false, "1995-09-08", "Assimilated zero tolerance access", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 284, "Hamil", "Borden", "10.5240/FFFF-CFFE-EFDF-FCCF-EEDB-C", false, "1997-10-31", "Reverse-engineered web-enabled attitude", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 285, "Rustman", "Lottie", "10.5240/DAED-FBFE-FFDF-FFEF-F5EE-C", false, "2011-08-13", "Sharable explicit intranet", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 286, "Menlove", "Dorothee", "10.5240/FDED-FEFF-BFF9-EFAF-FEFF-C", false, "2013-07-12", "Focused non-volatile knowledge user", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 287, "Knok", "Jimmie", "10.5240/EEBE-FFFE-BFEA-FDFF-F9FF-C", false, "2014-12-06", "Assimilated stable orchestration", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 288, "Coners", "Lewiss", "10.5240/FDFE-FDED-DFDD-DFFE-EFDD-C", false, "1993-05-18", "Re-engineered methodical forecast", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 289, "Sowter", "Kamilah", "10.5240/FFEC-FFFE-EFFB-EEFF-BDDE-C", false, "2005-07-14", "Optimized homogeneous help-desk", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 290, "Roscamps", "Oberon", "10.5240/EDEF-FFEE-EDEE-EECE-E9FF-C", false, "1992-07-17", "Object-based leading edge open architecture", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 291, "Creek", "Hobard", "10.5240/FDFF-DDDF-FBDE-FFEF-BFFF-C", false, "2015-07-23", "Up-sized explicit forecast", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 292, "Sibbald", "Desmund", "10.5240/FFFF-EECE-EFFE-EEEE-BDBB-C", false, "2000-12-02", "Enhanced bifurcated emulation", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 293, "Graveney", "Christal", "10.5240/FFFE-EEFF-FFFD-EFFE-EFFE-C", false, "2006-05-21", "Vision-oriented web-enabled matrix", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 294, "Windows", "Donni", "10.5240/EFFE-EEFF-BEED-EBEE-FEDE-C", false, "2001-08-06", "Automated static neural-net", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 295, "Snowling", "Elga", "10.5240/AFFE-FFCE-FBFF-FBFF-BEFF-C", false, "1998-04-30", "Cross-group fault-tolerant groupware", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 296, "Given", "Thomasa", "10.5240/FFCF-DEFF-EBEC-EAFF-DBEF-C", false, "1992-07-27", "Re-contextualized high-level framework", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 297, "Jobin", "Zacherie", "10.5240/FDEF-EDFF-F9CD-DEDE-FDDF-C", false, "2001-11-22", "Reactive multi-state benchmark", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 298, "Wainwright", "Gaby", "10.5240/7CFB-FAFF-FFFE-FCFF-FDFB-C", false, "1991-10-25", "Inverse mobile complexity", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 299, "Erlam", "Isador", "10.5240/EEBC-FECD-FDEE-DFDF-BFEF-C", false, "1999-01-15", "Face to face incremental core", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 300, "Smeal", "Millisent", "10.5240/FEFF-BFDF-FFFE-FFFF-FEFF-C", false, "1994-08-23", "User-friendly value-added adapter", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 301, "Easterby", "Ilysa", "10.5240/DDFC-BEFF-DFFF-BFEF-FFFD-C", false, "2005-06-04", "Configurable demand-driven parallelism", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 302, "Spurdon", "Yorker", "10.5240/FFCB-FECD-EFBE-DFED-EFBF-C", false, "1992-02-20", "Inverse 5th generation workforce", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 303, "Beardsley", "Obidiah", "10.5240/FFEA-FFEF-FFFF-FEEE-DFBE-C", false, "1990-09-10", "Synergistic impactful capability", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 304, "Raggitt", "Dorena", "10.5240/FFDF-DFDF-FEEF-FCFF-FFED-C", false, "1992-08-17", "Implemented user-facing concept", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 305, "Bowick", "Kerr", "10.5240/FEFF-DDFF-FFED-ECEE-FFFE-C", false, "1992-08-02", "Versatile asynchronous initiative", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 306, "Cowburn", "Heather", "10.5240/FFDF-FEFA-DFDC-EDE9-FEDF-C", false, "2000-03-28", "Adaptive context-sensitive time-frame", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 307, "Whettleton", "Lolita", "10.5240/FFFF-FFFB-EDDE-FEFE-FFDC-C", false, "2017-03-09", "Extended stable definition", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 308, "Sharplin", "Robby", "10.5240/FEFE-BFEB-DFFF-CCCF-DCFF-C", false, "1992-12-08", "Centralized systematic methodology", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 309, "Bracegirdle", "Earle", "10.5240/EFFF-EEEF-FFEF-FFCE-FFFF-C", false, "2012-09-23", "Implemented multimedia implementation", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 282, "McKerrow", "Gretel", "10.5240/AFEF-DDCF-DFEF-BF8F-EFFF-C", false, "1998-11-15", "Operative real-time collaboration", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 281, "Brislan", "Boy", "10.5240/DEFE-EFDE-EBFF-FEED-CEBF-C", false, "2003-11-27", "Mandatory radical info-mediaries", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 280, "Syrie", "Hastings", "10.5240/DDFF-FDEC-EFEE-DFDE-CFFE-C", false, "2015-08-29", "Expanded empowering interface", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 279, "Burgett", "Berty", "10.5240/DECE-FFFC-EBFF-EFFE-DCDE-C", false, "2002-08-31", "Visionary incremental Graphic Interface", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 251, "Eves", "Janeczka", "10.5240/DEFF-DFFD-FFFE-FDFE-FDFD-C", false, "1993-07-07", "Balanced well-modulated matrices", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 252, "Hawkswood", "Faith", "10.5240/FEFF-EFED-FFFE-DF9E-EF7F-C", false, "2003-02-22", "De-engineered 5th generation benchmark", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 253, "Brogan", "Consuela", "10.5240/EEEF-FFFF-FECF-BFEF-FEFE-C", false, "1992-03-29", "Managed 3rd generation website", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 254, "Ivanikov", "Maddy", "10.5240/DFEF-FFFF-DEEF-FFFE-FFCF-C", false, "1999-12-06", "Cross-group empowering function", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 255, "Cornil", "Daffi", "10.5240/FFCD-FFFF-FFCD-CEDD-DCFE-C", false, "2016-02-16", "Sharable holistic superstructure", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 256, "Trevaskus", "Killian", "10.5240/EFEE-FDBD-EFFF-FCBF-DFFE-C", false, "2011-03-14", "Cross-platform high-level help-desk", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 257, "Marcam", "Davie", "10.5240/DFDF-FFFB-FEFF-EFFE-FEED-C", false, "1998-02-11", "Business-focused actuating intranet", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 258, "Anderson", "Drucie", "10.5240/FEFE-FECF-EF9D-BFFD-EFED-C", false, "2018-06-04", "Balanced systematic local area network", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 259, "Andreazzi", "Miof mela", "10.5240/EFFF-CFCF-FEFF-AEFF-FDFF-C", false, "2018-06-15", "Persevering non-volatile matrix", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 260, "Iddon", "Camel", "10.5240/FFFE-FFFE-EADF-9FEE-EFED-C", false, "2000-10-27", "Customizable background projection", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 261, "Macallam", "Gavrielle", "10.5240/FFFF-FEDC-EEFE-DCFD-FEFE-C", false, "1997-01-23", "Organic fresh-thinking moratorium", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 262, "Hars", "Maurise", "10.5240/FEFF-FFDE-ECFF-EFFD-FEEF-C", false, "2015-06-19", "Customizable next generation instruction set", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 263, "Atkins", "Alissa", "10.5240/CFFE-EDEE-FFAF-EECF-FEEF-C", false, "2012-02-09", "Distributed encompassing projection", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 310, "Korfmann", "Harrietta", "10.5240/EFFF-FEFB-EFBF-D5FF-DCDF-C", false, "2013-01-15", "Exclusive 24 hour initiative", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 264, "Conry", "Dirk", "10.5240/EEFD-FFFD-FBCC-FEEE-CFFE-C", false, "1993-12-30", "Inverse fault-tolerant methodology", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 266, "Shreeve", "Brewer", "10.5240/FEFE-DFFF-EEFB-FCFE-FFFF-C", false, "2003-06-21", "Switchable dedicated intranet", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 267, "Renny", "Antin", "10.5240/EFFF-EEFC-FEFD-FEFE-FCBE-C", false, "2018-03-27", "Sharable value-added hub", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 268, "Featherstone", "Berni", "10.5240/EEEE-FFFE-EFEE-FFEE-FEFE-C", false, "2009-08-24", "Virtual scalable protocol", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 269, "Beckmann", "Carmine", "10.5240/FFFF-BFAF-EFFF-FFFF-FFFE-C", false, "2010-07-13", "Reduced multi-tasking monitoring", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 270, "Boerder", "Ellery", "10.5240/CDDA-EFFF-FFDF-DDEF-FDFE-C", false, "2003-02-21", "Re-engineered attitude-oriented challenge", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 271, "Chopping", "Ase", "10.5240/FBEE-FEDF-FDDF-EDAF-DFEF-C", false, "2010-12-05", "Open-architected incremental concept", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 272, "Deamer", "Rudolf", "10.5240/EEEF-ECEF-EAFE-FEFE-FFDF-C", false, "2004-09-22", "Future-proofed dedicated algorithm", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 273, "Hebburn", "Gannie", "10.5240/FFFF-FDEF-DFCC-FCEF-EDFD-C", false, "1995-10-03", "Right-sized composite analyzer", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 274, "Callander", "Tiler", "10.5240/CEFF-FFFF-FFEF-EEFD-DFDF-C", true, "2014-06-08", "Synergistic regional core", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 275, "Bonnyson", "Chris", "10.5240/EFDF-FEEF-EDFF-EFFD-FEEF-C", false, "2004-01-24", "Monitored actuating flexibility", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 276, "Rivelin", "Drona", "10.5240/ECFB-EFFF-BFFF-FDFF-FFEC-C", false, "2010-07-19", "Profit-focused object-oriented functionalities", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 277, "Wilden", "Duffy", "10.5240/FFFF-EFFF-FEEF-EEDF-FFEE-C", false, "2000-03-23", "Multi-lateral radical local area network", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 278, "Whetnall", "Dunstan", "10.5240/BCFF-EEDF-DEAE-FEEF-FFFF-C", false, "1998-06-04", "Profit-focused 24/7 Graphic Interface", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 265, "Dollard", "Stoddard", "10.5240/FFFF-FEEE-FFFE-FCEE-FEFF-C", false, "2017-03-11", "Reactive logistical workforce", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 499, "Whitemarsh", "Sly", "10.5240/FFDF-FFED-FFAE-DDDE-EEFE-C", false, "2018-01-05", "Customer-focused encompassing model", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 311, "Gaunson", "Shellysheldon", "10.5240/EDFF-FFFF-EFFF-CFFE-ED9F-C", false, "2008-12-29", "Visionary exuding parallelism", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 313, "Otteridge", "Winnie", "10.5240/FFFD-DDDF-EDFF-EFFF-FCEF-C", false, "2015-05-21", "Innovative uniform process improvement", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 346, "Buesden", "Ivette", "10.5240/FFFE-FFFE-EEFF-EFEF-FFCF-C", false, "1997-07-24", "Upgradable foreground neural-net", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 347, "Groneway", "Leigh", "10.5240/FEEE-FDFF-FFED-DEEE-DEFE-C", false, "2000-03-01", "Right-sized multimedia secured line", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 348, "Bohlin", "Win", "10.5240/FCCE-AFFE-FFFF-FFEE-FFCE-C", false, "2013-01-02", "Proactive dynamic approach", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 349, "Grundwater", "Frieda", "10.5240/FFFE-FFFF-BEEF-FFFF-BDFC-C", false, "2006-04-23", "Realigned discrete interface", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 350, "Crew", "Kristofer", "10.5240/FEFF-FBFE-FECF-EEED-FEFE-C", false, "1998-03-25", "Focused hybrid adapter", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 351, "Gartsyde", "Noel", "10.5240/FFFC-DEDE-BFFD-FBFE-FDFE-C", false, "1998-01-15", "Future-proofed 6th generation hardware", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 352, "Archibould", "Carolee", "10.5240/FCDD-DCEF-CFFE-FFCE-FCBF-C", false, "2013-05-23", "Advanced bi-directional framework", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 353, "Got", "Caron", "10.5240/FFEE-FFDF-FBFF-FEEE-ECCF-C", false, "2004-09-01", "Function-based cohesive open system", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 354, "Byforth", "Karrah", "10.5240/EEED-DDEE-EDED-FEFF-EFFF-C", false, "1995-08-03", "Secured impactful project", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 355, "Mattke", "Janelle", "10.5240/FFDF-FCFE-FBEE-CEFF-EEEF-C", false, "2007-10-25", "Grass-roots zero defect matrix", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 356, "Halmkin", "Arnold", "10.5240/9CFF-DFED-DFDF-EFFE-FFFF-C", false, "2012-11-06", "Quality-focused 3rd generation implementation", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 357, "Pebworth", "Janenna", "10.5240/FFFE-FFBF-FEFF-FFFF-EDDF-C", false, "1996-10-04", "Synergized regional moderator", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 358, "Benedyktowicz", "Jayme", "10.5240/CFCE-FFDF-FFDD-EFFC-FEFF-C", false, "2013-09-20", "Ameliorated system-worthy product", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 359, "Moreton", "Tonye", "10.5240/FDED-CFFE-EEFF-EFFD-FEEE-C", false, "1994-01-27", "Cross-platform interactive encoding", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 360, "Le Merchant", "Fedora", "10.5240/EFFD-DFEF-FEDF-FBBF-FCFE-C", false, "2003-05-08", "Open-source disintermediate parallelism", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 361, "Bultitude", "Hillel", "10.5240/FEEF-DFFF-FEFF-FFDD-EFFE-C", false, "2017-08-01", "Down-sized 6th generation service-desk", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 362, "Haffner", "Selinda", "10.5240/FEFE-FEEC-FFEF-AEBF-FFFF-C", false, "1996-11-06", "Horizontal intermediate approach", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 363, "Currall", "Breanne", "10.5240/FFEF-FDFE-DCEF-BFBF-DFEF-C", false, "2010-05-28", "Automated transitional Graphical User Interface", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 364, "McBeath", "Maritsa", "10.5240/FDDE-EFAF-FCDC-DCEC-FFFD-C", false, "2002-04-28", "User-centric mobile circuit", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 365, "Discombe", "Kalie", "10.5240/DF5F-9FBF-FFEE-FEFF-EFFF-C", false, "1997-10-12", "Switchable multi-state matrices", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 366, "Ciccoloi", "Cort", "10.5240/DCFF-FCFE-EFCF-EEFF-FECF-C", false, "1992-06-20", "Advanced upward-trending application", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 367, "Quirk", "Silva", "10.5240/FFFB-EFFF-DEFA-DFEF-BAFF-C", false, "2005-01-10", "Synergistic regional methodology", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 368, "Tassell", "Jackelyn", "10.5240/EFFB-FEEF-DFFD-FDFE-FEFF-C", false, "2001-11-05", "Virtual motivating leverage", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 369, "Burchatt", "Rodie", "10.5240/EDEF-CFEF-FECD-FEEF-DFFB-C", false, "2003-01-19", "Reverse-engineered methodical capability", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 370, "Fairlie", "Ninette", "10.5240/EFEF-FBEF-FEFA-EEFF-EFFF-C", false, "2008-08-02", "Fundamental static archive", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 371, "Domanek", "Lurette", "10.5240/EEFF-EEDD-FFEC-FFFE-EEED-C", false, "2009-01-16", "Progressive value-added infrastructure", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 372, "Beddard", "Giles", "10.5240/BFCF-BFFF-FEEF-EFFC-FFDE-C", false, "2010-12-25", "Inverse local methodology", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 345, "Broadwell", "Kacie", "10.5240/FEDF-FBFF-CFCF-BFFE-FFEF-C", false, "2006-04-16", "Front-line modular utilisation", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 344, "Tomala", "Siobhan", "10.5240/FFFB-FEDE-EFFF-FDFE-FFEF-C", false, "1993-06-10", "Mandatory uniform paradigm", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 343, "Drohun", "Ysabel", "10.5240/FEDD-FFFF-FEEF-FDDE-EEEE-C", false, "1993-02-16", "Multi-layered intermediate frame", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 342, "Winspeare", "Merrili", "10.5240/FFEE-FFEF-DFF9-FEEE-FCDF-C", false, "2008-12-14", "User-friendly cohesive extranet", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 314, "Ragdale", "Jillian", "10.5240/EEFD-DFEF-FFFF-DEEE-FCEF-C", false, "2010-11-02", "Profound secondary Graphical User Interface", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 315, "Cowen", "Xaviera", "10.5240/FBFE-FFFD-EFFD-EDFF-FCFD-C", false, "1998-10-23", "Customer-focused user-facing application", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 316, "Cheltnam", "Misha", "10.5240/EFFF-E7ED-DFCD-FFEF-FFFE-C", false, "2000-01-12", "Object-based national complexity", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 317, "Lanigan", "Cam", "10.5240/FFFF-DDFE-DFEF-DFDD-DFFE-C", false, "2005-12-20", "Robust fault-tolerant hierarchy", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 318, "Crompton", "Bess", "10.5240/FFEF-EBEF-FFCF-FEEF-FEFF-C", false, "2005-10-15", "Multi-lateral mission-critical capability", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 319, "Starbucke", "Florette", "10.5240/FD8D-EFEE-DEFE-DBFE-EFFE-C", false, "2007-11-18", "Up-sized coherent task-force", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 320, "Lints", "Fairfax", "10.5240/FEEB-FFEB-DFFF-EF6F-EFFF-C", false, "1999-02-04", "Seamless systematic structure", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 321, "Stolz", "Basilio", "10.5240/EFFE-EFDE-FEEA-FCCF-EEEF-C", false, "2009-08-28", "Compatible global conglomeration", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 322, "Coumbe", "Caril", "10.5240/DFFC-FBFF-FFFE-FEFF-FF9E-C", false, "2006-03-12", "Reduced actuating process improvement", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 323, "Yakunkin", "Willa", "10.5240/FEEC-DFDC-FDFE-FEFE-EEFD-C", false, "2011-01-13", "Ameliorated multi-state capacity", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 324, "Aronowitz", "Arel", "10.5240/CFFF-FCFE-EAFC-DFFE-CAFD-C", false, "2005-09-13", "De-engineered discrete interface", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 325, "Banasik", "Robb", "10.5240/FDED-EEDF-BFCF-EDFF-EDEF-C", false, "1996-11-28", "Switchable uniform analyzer", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 326, "Mariotte", "Boyce", "10.5240/FFDF-ACEE-FFEE-FDFF-EEEE-C", false, "1993-09-04", "Sharable didactic capacity", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 312, "Ick", "Reina", "10.5240/EDFE-FFFF-FDFF-ECFF-FDFF-C", false, "1995-05-24", "Quality-focused encompassing leverage", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 327, "Angove", "Hillary", "10.5240/EFFF-FEEE-CFFB-FFFF-FFDF-C", false, "2013-12-11", "Managed system-worthy adapter", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 329, "Inchboard", "Barbee", "10.5240/CBFF-EFEF-EFFE-EEFE-FCD6-C", false, "1992-05-12", "Right-sized composite emulation", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 330, "Tamplin", "Constantin", "10.5240/FE9C-FFFF-FDDF-FDAF-FFEF-C", false, "2014-05-23", "Business-focused stable knowledge base", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 331, "Shewsmith", "Jess", "10.5240/FECE-EFCF-F9FF-EEFC-FFCF-C", false, "1997-03-18", "Organized background system engine", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 332, "Downes", "Jdavie", "10.5240/FEEE-EFFF-EDFE-FEFE-EFAE-C", false, "1992-03-29", "Configurable fresh-thinking analyzer", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 333, "Thurber", "Gracia", "10.5240/EFDF-EBFE-EFFB-FEFD-FFCF-C", false, "2003-04-28", "Exclusive foreground product", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 334, "Boxen", "Erhart", "10.5240/FEFB-E9DF-BEAF-DEDD-9CFF-C", false, "2017-06-19", "Inverse foreground software", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 335, "Douch", "Tully", "10.5240/EFCF-FDDF-EFFF-FFFE-BFFB-C", false, "2007-07-26", "Managed secondary matrices", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 336, "Yusupov", "Kippie", "10.5240/FE8F-FFFC-FDFD-CFFF-FFEF-C", false, "1999-09-20", "Profit-focused bi-directional matrix", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 337, "Rankine", "Barny", "10.5240/DEED-FECA-CFDD-FCFE-EFFF-C", false, "1992-06-13", "Up-sized tangible adapter", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 338, "Koppe", "Eveline", "10.5240/DEEF-FDDD-BEFF-FFFC-DDFF-C", false, "2000-09-25", "Assimilated exuding matrix", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 339, "Kenwood", "Milzie", "10.5240/FEEF-EBAE-DEBF-FDAE-EDFE-C", false, "1999-10-15", "Visionary neutral moderator", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 340, "Curwood", "Ardis", "10.5240/FF8F-FDFF-FEEF-DFFD-FFFF-C", false, "2002-01-17", "Focused even-keeled moderator", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 341, "Maseyk", "Pat", "10.5240/FFFE-EFFC-FDFF-FEEE-FEEA-C", false, "2017-04-01", "Adaptive asymmetric neural-net", "VHS" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 328, "Neasam", "Reyna", "10.5240/FDFA-FDEE-FFFE-EAFE-FFEB-C", false, "1991-05-28", "Secured executive policy", "Betamax" });

            migrationBuilder.InsertData(
                table: "Videotapes",
                columns: new[] { "videotapeId", "director_first_name", "director_last_name", "eidr", "isRented", "release_date", "title", "type" },
                values: new object[] { 1000, "Busk", "Katee", "10.5240/CFFF-EFFE-EFFE-CFCF-EEFF-C", false, "1995-05-08", "Integrated tangible hierarchy", "VHS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Borrows");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Videotapes");
        }
    }
}
