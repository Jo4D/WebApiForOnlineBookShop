using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryPattern.EF.Migrations
{
    public partial class now : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ShoppingSession",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 14, 27, 54, 488, DateTimeKind.Utc).AddTicks(2957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 13, 35, 52, 443, DateTimeKind.Utc).AddTicks(275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 14, 27, 54, 488, DateTimeKind.Utc).AddTicks(1979),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 13, 35, 52, 442, DateTimeKind.Utc).AddTicks(9127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OrderItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 14, 27, 54, 486, DateTimeKind.Utc).AddTicks(5568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 13, 35, 52, 441, DateTimeKind.Utc).AddTicks(2915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "OrderDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 14, 27, 54, 486, DateTimeKind.Utc).AddTicks(4489),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 13, 35, 52, 441, DateTimeKind.Utc).AddTicks(1641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OrderDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 14, 27, 54, 486, DateTimeKind.Utc).AddTicks(4183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 13, 35, 52, 441, DateTimeKind.Utc).AddTicks(1336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 14, 27, 54, 486, DateTimeKind.Utc).AddTicks(3106),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 13, 35, 52, 441, DateTimeKind.Utc).AddTicks(89));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CaretItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 14, 27, 54, 485, DateTimeKind.Utc).AddTicks(9553),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 13, 35, 52, 440, DateTimeKind.Utc).AddTicks(7882));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 14, 27, 54, 485, DateTimeKind.Utc).AddTicks(3079),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 13, 35, 52, 440, DateTimeKind.Utc).AddTicks(4349));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ShoppingSession",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 13, 35, 52, 443, DateTimeKind.Utc).AddTicks(275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 14, 27, 54, 488, DateTimeKind.Utc).AddTicks(2957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 13, 35, 52, 442, DateTimeKind.Utc).AddTicks(9127),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 14, 27, 54, 488, DateTimeKind.Utc).AddTicks(1979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OrderItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 13, 35, 52, 441, DateTimeKind.Utc).AddTicks(2915),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 14, 27, 54, 486, DateTimeKind.Utc).AddTicks(5568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "OrderDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 13, 35, 52, 441, DateTimeKind.Utc).AddTicks(1641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 14, 27, 54, 486, DateTimeKind.Utc).AddTicks(4489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OrderDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 13, 35, 52, 441, DateTimeKind.Utc).AddTicks(1336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 14, 27, 54, 486, DateTimeKind.Utc).AddTicks(4183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 13, 35, 52, 441, DateTimeKind.Utc).AddTicks(89),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 14, 27, 54, 486, DateTimeKind.Utc).AddTicks(3106));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CaretItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 13, 35, 52, 440, DateTimeKind.Utc).AddTicks(7882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 14, 27, 54, 485, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 13, 35, 52, 440, DateTimeKind.Utc).AddTicks(4349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 14, 27, 54, 485, DateTimeKind.Utc).AddTicks(3079));
        }
    }
}
