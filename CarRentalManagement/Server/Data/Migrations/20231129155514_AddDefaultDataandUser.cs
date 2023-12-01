using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultDataandUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Colors_ColorID",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Models_ModelID",
                table: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "ModelID",
                table: "Vehicles",
                newName: "ModelId");

            migrationBuilder.RenameColumn(
                name: "ColorID",
                table: "Vehicles",
                newName: "ColorId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Vehicles",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_ModelID",
                table: "Vehicles",
                newName: "IX_Vehicles_ModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_ColorID",
                table: "Vehicles",
                newName: "IX_Vehicles_ColorId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Models",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Makes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Customers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Colors",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Bookings",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "124c4246-6a35-405e-8be2-64e595ddde8c", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEI+c8H0xSqwUTjXUFPAjp0ZoMt1f7uAvmw3QVruJAdC78DdxcqimG/SWcIdcEbG2cA==", null, false, "ab73cee6-1c49-45e7-af9e-3129feaee91a", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 29, 23, 55, 13, 818, DateTimeKind.Local).AddTicks(8839), new DateTime(2023, 11, 29, 23, 55, 13, 818, DateTimeKind.Local).AddTicks(8853), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 29, 23, 55, 13, 818, DateTimeKind.Local).AddTicks(8856), new DateTime(2023, 11, 29, 23, 55, 13, 818, DateTimeKind.Local).AddTicks(8856), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 29, 23, 55, 13, 818, DateTimeKind.Local).AddTicks(9636), new DateTime(2023, 11, 29, 23, 55, 13, 818, DateTimeKind.Local).AddTicks(9636), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 29, 23, 55, 13, 818, DateTimeKind.Local).AddTicks(9639), new DateTime(2023, 11, 29, 23, 55, 13, 818, DateTimeKind.Local).AddTicks(9639), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 29, 23, 55, 13, 818, DateTimeKind.Local).AddTicks(9326), new DateTime(2023, 11, 29, 23, 55, 13, 818, DateTimeKind.Local).AddTicks(9328), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 29, 23, 55, 13, 818, DateTimeKind.Local).AddTicks(9329), new DateTime(2023, 11, 29, 23, 55, 13, 818, DateTimeKind.Local).AddTicks(9330), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 29, 23, 55, 13, 818, DateTimeKind.Local).AddTicks(9331), new DateTime(2023, 11, 29, 23, 55, 13, 818, DateTimeKind.Local).AddTicks(9332), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 29, 23, 55, 13, 818, DateTimeKind.Local).AddTicks(9333), new DateTime(2023, 11, 29, 23, 55, 13, 818, DateTimeKind.Local).AddTicks(9334), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Colors_ColorId",
                table: "Vehicles",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Models_ModelId",
                table: "Vehicles",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Colors_ColorId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Models_ModelId",
                table: "Vehicles");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.RenameColumn(
                name: "ModelId",
                table: "Vehicles",
                newName: "ModelID");

            migrationBuilder.RenameColumn(
                name: "ColorId",
                table: "Vehicles",
                newName: "ColorID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vehicles",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_ModelId",
                table: "Vehicles",
                newName: "IX_Vehicles_ModelID");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_ColorId",
                table: "Vehicles",
                newName: "IX_Vehicles_ColorID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Models",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Makes",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Colors",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Bookings",
                newName: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Colors_ColorID",
                table: "Vehicles",
                column: "ColorID",
                principalTable: "Colors",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Models_ModelID",
                table: "Vehicles",
                column: "ModelID",
                principalTable: "Models",
                principalColumn: "ID");
        }
    }
}
