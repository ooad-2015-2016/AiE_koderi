using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using Detektor.Models;

namespace DetektorMigrations
{
    [ContextType(typeof(DetektorLaziDbContext))]
    partial class DetektorLaziDbContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder.Annotation("ProductVersion", "7.0.0-beta6-13815");
            builder.Entity("Detektor.Models.DetektorLazi", b =>
                {
                    b.Property<int>("id").ValueGeneratedOnAdd();
                    b.Property<string>("sifra");
                    b.Property<string>("Ime");

                    b.Key("id");
                });
        }
    }
}
