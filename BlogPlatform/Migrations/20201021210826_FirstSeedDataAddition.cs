using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class FirstSeedDataAddition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "MMO" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "RPG" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Shooter" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "Leeroy Jenkins", "One of the most prominent MMOs out there, you’d think there’s more memes than players at this point. If you don’t have a life, or a significant other… Welcome home. If you have either of those things, when you pick up this game, buy them something nice to compensate for your soon-to-be missing presence.", 1, "10/21/2020", "World of Warcraft" },
                    { 2, "ILeftMyStoveOn", "Do you like crafting? Do you like running around, cutting down trees, heaving a metal object at rocks for hours at end? Well… you’ll like this. Sure you can fight things, but why do that when you can literally live your best life in this game?", 1, "10/21/2020", "New World" },
                    { 3, "HanShotFirst", "Oldie but goldie. Do you want to be a Sith, frying your boss with lightning to get a promotion? We got you. Do you want to be a Jedi who makes mildly amusing comments to your enemies? We got you. You’ve got a ship, a galaxy to explore and crewmates to romance. No excuses.", 1, "10/21/2020", "Star Wars: The Old Republic" },
                    { 4, "Order 66", "I expected this to be terrible in typical EA fashion. It turned out to be one of the best Star Wars games in recent memory. Congratulations. If they had given us less ponchos and more sith magic, it’d be a 10/10.", 2, "10/21/2020", "Jedi: Fallen Order" },
                    { 5, "DudeSomeoneStoleMySweetRoll", "Do I even need to say anything? I Fus Ro Dah’d my horse off a cliff. Top that.", 2, "10/21/2020", "Skyrim" },
                    { 6, "Boy", "Most commonly referred to as ‘Disappointed Father Simulator 2018’. Also, there’s a giant talking snake that is friendly.", 2, "10/21/2020", "God of War" },
                    { 7, "Activision", "I don’t even have time to explain why I don’t have time to explain. That’s it. Go away.", 3, "10/21/2020", "Destiny 2" },
                    { 8, "Don’t Get Cocky, Kid", "You get to live out your fantasies of flying Star Wars ships, killing opposing faction pilots. You get to have a cute little dangly mini Ewok in your cockpit.", 3, "10/21/2020", "Star Wars: Squadrons" },
                    { 9, "ReviveMePls", "Lack of originality meets tons of Activision money. They made something that has few original ideas, but has enough polish to put other games to shame. Good job, I guess?", 3, "10/21/2020", "Warzone" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
