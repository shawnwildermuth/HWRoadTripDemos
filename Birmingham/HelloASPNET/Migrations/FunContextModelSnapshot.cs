using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using HelloASPNET.Data;

namespace HelloASPNET.Migrations
{
    [DbContext(typeof(FunContext))]
    partial class FunContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16341")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HelloASPNET.Data.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("PersonId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("HelloASPNET.Data.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("HelloASPNET.Data.Color", b =>
                {
                    b.HasOne("HelloASPNET.Data.Person")
                        .WithMany()
                        .HasForeignKey("PersonId");
                });
        }
    }
}
