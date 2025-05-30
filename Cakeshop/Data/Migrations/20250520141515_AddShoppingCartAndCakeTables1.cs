﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cakeshop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddShoppingCartAndCakeTables1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersDetials_Cakes_CakeId",
                table: "OrdersDetials");

            migrationBuilder.AlterColumn<int>(
                name: "CakeId",
                table: "OrdersDetials",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersDetials_Cakes_CakeId",
                table: "OrdersDetials",
                column: "CakeId",
                principalTable: "Cakes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersDetials_Cakes_CakeId",
                table: "OrdersDetials");

            migrationBuilder.AlterColumn<int>(
                name: "CakeId",
                table: "OrdersDetials",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersDetials_Cakes_CakeId",
                table: "OrdersDetials",
                column: "CakeId",
                principalTable: "Cakes",
                principalColumn: "Id");
        }
    }
}
