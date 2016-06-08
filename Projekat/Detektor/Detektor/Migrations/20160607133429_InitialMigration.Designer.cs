using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using Detektor.Models;

namespace DetektorMigrations
{
    [ContextType(typeof(DetektorLaziDbContext))]
    partial class InitialMigration
    {
        public override string Id
        {
            get { return "20160607133429_InitialMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("Detektor.Models.DetektorLazi", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Key("id");
                });
        }
    }
}
