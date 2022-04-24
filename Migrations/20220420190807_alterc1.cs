﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Poke.Migrations
{
    public partial class alterc1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Picture",
                table: "Trainers",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Trainers");
        }
    }
}
