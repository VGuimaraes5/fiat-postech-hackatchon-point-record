using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hackathon.Point.Record.Api.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_point_record",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    RegisterDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserIdentification = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_point_record", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "tb_point_record",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "RegisterDate", "Type", "UpdatedAt", "UserIdentification" },
                values: new object[,]
                {
                    { new Guid("03e71b59-96b8-4b27-b1d9-8153b1aef3d4"), null, false, new DateTime(2024, 3, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("07b4b703-7beb-4e92-8ae8-ef379338353d"), null, false, new DateTime(2024, 3, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("083111be-cf4c-4708-abe9-f538710e99f9"), null, false, new DateTime(2024, 3, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("0a7bd7c2-f305-4856-86bd-dd6b3d88a070"), null, false, new DateTime(2024, 3, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("0b28416a-785c-44f1-95cb-1e3082f42e13"), null, false, new DateTime(2024, 3, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("0dddf8ea-27c3-4454-ad9d-73f4c6c128d8"), null, false, new DateTime(2024, 3, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("1210ac90-bb5e-4634-8c8f-73ca54eb81a1"), null, false, new DateTime(2024, 3, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("17276f13-757a-4a08-a58e-67fdbd789453"), null, false, new DateTime(2024, 3, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("17a3e086-7e06-4e47-a8b3-151413fe40dd"), null, false, new DateTime(2024, 3, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("192754d4-b43b-4990-aa6e-a7618f7d9fe8"), null, false, new DateTime(2024, 3, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("1bce55b5-758d-4031-8152-42743511df3d"), null, false, new DateTime(2024, 3, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("1f397566-62fe-433f-8460-586c3bc7e92b"), null, false, new DateTime(2024, 3, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("2013d626-fa6c-4bb1-9af5-cb06ea3de101"), null, false, new DateTime(2024, 3, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("22ddc5fc-ccf6-404f-b3e6-892771ec7c74"), null, false, new DateTime(2024, 3, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("26f31777-f572-48cd-a96e-83e3587f2102"), null, false, new DateTime(2024, 3, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("2879ed3c-1890-4195-97b4-3ea376a18838"), null, false, new DateTime(2024, 3, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("2d1020ea-1dd9-4f6f-a55f-160335bf9c0d"), null, false, new DateTime(2024, 3, 22, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("2d535fe8-a73b-4ef7-878e-fadca7c2ef24"), null, false, new DateTime(2024, 3, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("2fe428cd-cac0-4100-b5f2-48a309c0ae85"), null, false, new DateTime(2024, 3, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("324ed053-0d94-4d77-ae34-0cecb55b4e8e"), null, false, new DateTime(2024, 3, 7, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("33cf79c1-aeb8-42a4-8b43-41c5cf314cd9"), null, false, new DateTime(2024, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("3491be9c-9967-4156-9f1f-edbe30ccb489"), null, false, new DateTime(2024, 3, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("37208e23-4ae7-432d-8b36-b9b4d9259c88"), null, false, new DateTime(2024, 3, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("38cfef33-1056-41e2-8a8c-7c8438baa14f"), null, false, new DateTime(2024, 3, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("462924a1-0ad1-4149-94a1-4362bbad7f4a"), null, false, new DateTime(2024, 3, 26, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("471c9de9-b0bb-4a5f-bb06-d065e127f649"), null, false, new DateTime(2024, 3, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("474a1b2c-9e82-42c8-b4bf-b42d64740a34"), null, false, new DateTime(2024, 3, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("4bab8109-c515-4f60-8630-e02922dc4fcf"), null, false, new DateTime(2024, 3, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("4cf49a6f-11ce-45a6-b50e-9c4551f632d0"), null, false, new DateTime(2024, 3, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("4eefeb84-90ff-48c7-aea8-042e47d64418"), null, false, new DateTime(2024, 3, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("4fa08f00-f463-4a43-b8ba-9809f75210ee"), null, false, new DateTime(2024, 3, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("52663bab-6b79-47ea-b04b-dc9e19c70b52"), null, false, new DateTime(2024, 3, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("5b7be4f6-7648-47ad-9a84-6613b459e178"), null, false, new DateTime(2024, 3, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("5b92a00b-9f83-4a55-ac69-8add0c232034"), null, false, new DateTime(2024, 3, 18, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("5e860dd8-20f6-49be-a8be-e42702a0e061"), null, false, new DateTime(2024, 3, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("5f97a7c3-6952-41e8-bfb8-9ce0b0f24c91"), null, false, new DateTime(2024, 3, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("61d78fc2-54fb-4a80-a71a-b1a41a000c5c"), null, false, new DateTime(2024, 3, 25, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("623c2fb1-3ad8-4896-a06d-8c06c8976766"), null, false, new DateTime(2024, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("6848f3eb-3188-4b5a-8e79-66ddd1a807f0"), null, false, new DateTime(2024, 3, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("702fbed6-71aa-418c-8c2a-5acc94b80857"), null, false, new DateTime(2024, 3, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("71e88a17-5c91-4c48-b732-c57520975903"), null, false, new DateTime(2024, 3, 4, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("7305adb7-424a-4f8b-97d9-94e997dad86c"), null, false, new DateTime(2024, 3, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("77787db3-7240-4ff2-9873-79de2861a8da"), null, false, new DateTime(2024, 3, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("79c48793-7a04-48a2-8741-2deea77d718b"), null, false, new DateTime(2024, 3, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("7d6b9ffb-227b-4dd7-99bc-74d7562d2b8a"), null, false, new DateTime(2024, 3, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("83b476ba-f301-4cb6-ba1d-c7ba23084d08"), null, false, new DateTime(2024, 3, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("83f0c7f9-2e0e-4e91-a83b-86a5d68c6ae4"), null, false, new DateTime(2024, 3, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("87227f95-e62d-45ed-8090-320de4cc91bb"), null, false, new DateTime(2024, 3, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("87baf2f9-53cd-4265-b5ec-e538114060eb"), null, false, new DateTime(2024, 3, 14, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("87d08a0a-bc25-4a19-9f3a-af32f972fea5"), null, false, new DateTime(2024, 3, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("89916415-8b1f-4a1d-906a-41ac4ab5cec9"), null, false, new DateTime(2024, 3, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("8eca92fa-582a-4759-9a6c-36c060b176e6"), null, false, new DateTime(2024, 3, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("90a76d5d-2dac-4a87-bda4-a621f13218d9"), null, false, new DateTime(2024, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("90d36b71-07a4-4710-a280-c173db2a8760"), null, false, new DateTime(2024, 3, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("951e55b5-204e-489c-9544-9639fbba3305"), null, false, new DateTime(2024, 3, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("9db6b107-9d8a-4218-8df5-c7faf7cfaadf"), null, false, new DateTime(2024, 3, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("a0ef5ef7-ebe1-4cf7-a879-d438d42dc9bd"), null, false, new DateTime(2024, 3, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("a32cdcb7-c047-401a-8061-640394aacf89"), null, false, new DateTime(2024, 3, 8, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("a33c4855-867c-46be-b2a1-2cd0e57fd995"), null, false, new DateTime(2024, 3, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("a68876e4-2054-4c9f-af6b-1b57337067d1"), null, false, new DateTime(2024, 3, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("a6da8a97-b61a-4a92-ad1e-4bd299c71dc2"), null, false, new DateTime(2024, 3, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("a78fe2da-d28f-4259-aeac-8948d8711961"), null, false, new DateTime(2024, 3, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("a8ea6435-cce6-434d-aea2-6fe7206ce8f6"), null, false, new DateTime(2024, 3, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("a90d6d6b-0bb3-4d15-abe5-44cc644cdb7c"), null, false, new DateTime(2024, 3, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("b05cfeb9-432c-4f9e-8e09-20f2ff609b7b"), null, false, new DateTime(2024, 3, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("b4802d16-5297-4622-b572-1ba76b9cc651"), null, false, new DateTime(2024, 3, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("b71874e5-1bf3-4da0-96b0-3953b3f108ce"), null, false, new DateTime(2024, 3, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("b9d10818-266e-45ae-a41b-185a365bd696"), null, false, new DateTime(2024, 3, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("c89ca8d0-3a58-46d4-a14c-38e1aee19808"), null, false, new DateTime(2024, 3, 28, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("ccb234e7-c66f-47a6-872f-1a4571849a19"), null, false, new DateTime(2024, 3, 12, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("d12b7ed0-6217-4c5c-a39f-0918f0bb4cb2"), null, false, new DateTime(2024, 3, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("d3fcef63-ddf5-42db-80a8-3cf2cdb3e6bd"), null, false, new DateTime(2024, 3, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("d4fa3c68-3096-4f61-8b24-36e0e7452635"), null, false, new DateTime(2024, 3, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("d4fbfc00-fd06-4435-9644-5e83f264deea"), null, false, new DateTime(2024, 3, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("e45244fe-2106-43bc-a30c-9a45661e9742"), null, false, new DateTime(2024, 3, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("e768f02a-fa26-4cd9-b7ef-340161c9ea45"), null, false, new DateTime(2024, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("eb421818-066e-4802-85f9-081ed1d004de"), null, false, new DateTime(2024, 3, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("eef42ef6-7a8e-4823-a11b-b3bcc01074c7"), null, false, new DateTime(2024, 3, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("f3f9651b-3530-4058-80e7-8510fccad7e3"), null, false, new DateTime(2024, 3, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("f4d868f8-3238-42ab-bbb8-1c18e847530c"), null, false, new DateTime(2024, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" },
                    { new Guid("f828ec14-7d49-43a6-90d6-df7c40cb3cd6"), null, false, new DateTime(2024, 3, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("fbab73bf-c523-4683-8d28-749af91c7a32"), null, false, new DateTime(2024, 3, 29, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("fe29c121-3bd7-438c-b1da-7ee1a52d9864"), null, false, new DateTime(2024, 3, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "seed" },
                    { new Guid("fe7b2a77-a0b5-4cb7-81b6-1c10217173bd"), null, false, new DateTime(2024, 3, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "seed" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_point_record_UserIdentification",
                table: "tb_point_record",
                column: "UserIdentification");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_point_record");
        }
    }
}
