using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokemon.Migrations
{
    /// <inheritdoc />
    public partial class Primeira_Migration_Pokemon_DB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AbilityTable",
                columns: table => new
                {
                    AbilityId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityTable", x => x.AbilityId);
                });

            migrationBuilder.CreateTable(
                name: "PokemonTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    FrontDefault = table.Column<string>(type: "TEXT", nullable: false),
                    Height = table.Column<int>(type: "INTEGER", nullable: false),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbilityEntityPokemonEntity",
                columns: table => new
                {
                    AbilitiesAbilityId = table.Column<int>(type: "INTEGER", nullable: false),
                    PokemonsEntityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityEntityPokemonEntity", x => new { x.AbilitiesAbilityId, x.PokemonsEntityId });
                    table.ForeignKey(
                        name: "FK_AbilityEntityPokemonEntity_AbilityTable_AbilitiesAbilityId",
                        column: x => x.AbilitiesAbilityId,
                        principalTable: "AbilityTable",
                        principalColumn: "AbilityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AbilityEntityPokemonEntity_PokemonTable_PokemonsEntityId",
                        column: x => x.PokemonsEntityId,
                        principalTable: "PokemonTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonAbilityTable",
                columns: table => new
                {
                    PokemonAbilityId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PokemonId = table.Column<int>(type: "INTEGER", nullable: false),
                    AbilityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonAbilityTable", x => x.PokemonAbilityId);
                    table.ForeignKey(
                        name: "FK_PokemonAbilityTable_AbilityTable_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "AbilityTable",
                        principalColumn: "AbilityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonAbilityTable_PokemonTable_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "PokemonTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonEntityTypeEntity",
                columns: table => new
                {
                    PokemonEntitiesId = table.Column<int>(type: "INTEGER", nullable: false),
                    TypesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonEntityTypeEntity", x => new { x.PokemonEntitiesId, x.TypesId });
                    table.ForeignKey(
                        name: "FK_PokemonEntityTypeEntity_PokemonTable_PokemonEntitiesId",
                        column: x => x.PokemonEntitiesId,
                        principalTable: "PokemonTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonEntityTypeEntity_TypeTable_TypesId",
                        column: x => x.TypesId,
                        principalTable: "TypeTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonTypeTable",
                columns: table => new
                {
                    PokemonTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PokemonId = table.Column<int>(type: "INTEGER", nullable: false),
                    TypeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonTypeTable", x => x.PokemonTypeId);
                    table.ForeignKey(
                        name: "FK_PokemonTypeTable_PokemonTable_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "PokemonTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonTypeTable_TypeTable_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TypeTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbilityEntityPokemonEntity_PokemonsEntityId",
                table: "AbilityEntityPokemonEntity",
                column: "PokemonsEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonAbilityTable_AbilityId",
                table: "PokemonAbilityTable",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonAbilityTable_PokemonId",
                table: "PokemonAbilityTable",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonEntityTypeEntity_TypesId",
                table: "PokemonEntityTypeEntity",
                column: "TypesId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTypeTable_PokemonId",
                table: "PokemonTypeTable",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTypeTable_TypeId",
                table: "PokemonTypeTable",
                column: "TypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbilityEntityPokemonEntity");

            migrationBuilder.DropTable(
                name: "PokemonAbilityTable");

            migrationBuilder.DropTable(
                name: "PokemonEntityTypeEntity");

            migrationBuilder.DropTable(
                name: "PokemonTypeTable");

            migrationBuilder.DropTable(
                name: "AbilityTable");

            migrationBuilder.DropTable(
                name: "PokemonTable");

            migrationBuilder.DropTable(
                name: "TypeTable");
        }
    }
}
