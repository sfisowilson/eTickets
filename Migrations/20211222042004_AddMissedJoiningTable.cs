﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace eTickets.Migrations
{
    public partial class AddMissedJoiningTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movie_Actors_ActorId",
                table: "Actor_Movie");

            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movie_Movies_MovieId",
                table: "Actor_Movie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actor_Movie",
                table: "Actor_Movie");

            migrationBuilder.RenameTable(
                name: "Actor_Movie",
                newName: "Actors_Movies");

            migrationBuilder.RenameIndex(
                name: "IX_Actor_Movie_MovieId",
                table: "Actors_Movies",
                newName: "IX_Actors_Movies_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors_Movies",
                table: "Actors_Movies",
                columns: new[] { "ActorId", "MovieId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors_Movies",
                table: "Actors_Movies");

            migrationBuilder.RenameTable(
                name: "Actors_Movies",
                newName: "Actor_Movie");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_Movies_MovieId",
                table: "Actor_Movie",
                newName: "IX_Actor_Movie_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actor_Movie",
                table: "Actor_Movie",
                columns: new[] { "ActorId", "MovieId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movie_Actors_ActorId",
                table: "Actor_Movie",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movie_Movies_MovieId",
                table: "Actor_Movie",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
