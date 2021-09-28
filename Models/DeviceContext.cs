using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesApi.Models
{
    public class DeviceContext : DbContext
    {
        public DeviceContext(DbContextOptions<DeviceContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeviceRelation>()
                .HasKey(dr => new { dr.RootDeviceId, dr.RelatedDeviceId });

            modelBuilder.Entity<DeviceRelation>()
                .HasOne(dr => dr.RootDevice)
                .WithMany(dr => dr.RelatedDevices)
                .HasForeignKey(dr => dr.RootDeviceId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Device>().HasOne<DeviceType>(d => d.DeviceType);
            modelBuilder.Entity<Device>().HasOne<DeviceStatusType>(d => d.DeviceStatus);


            // Seed data
            modelBuilder.Entity<DeviceStatusType>()
                .HasData(
                    new DeviceStatusType
                    {
                        Id = 1,
                        Name = "Available"
                    },
                    new DeviceStatusType
                    {
                        Id = 2,
                        Name = "Offline"
                    }
                );

            modelBuilder.Entity<DeviceType>()
                .HasData(
                    new DeviceType
                    {
                        Id = 1,
                        Name = "Mobile"
                    },
                    new DeviceType
                    {
                        Id = 2,
                        Name = "Tablet"
                    },
                    new DeviceType
                    {
                        Id = 3,
                        Name = "Desktop"
                    }
                );

            modelBuilder.Entity<Device>()
                .HasData(
                    new Device()
                    {
                        Id = 1,
                        Name = "Device 1",
                        DeviceStatusId = 1,
                        DeviceTypeId = 1,
                        Temperature = 15,
                        RelatedDevices = new List<DeviceRelation>()
                    },
                    new Device()
                    {
                        Id = 2,
                        Name = "Device 2",
                        DeviceStatusId = 2,
                        DeviceTypeId = 3,
                        Temperature = 18,
                        RelatedDevices = new List<DeviceRelation>()
                    },
                    new Device()
                    {
                        Id = 3,
                        Name = "Device 3",
                        DeviceStatusId = 1,
                        DeviceTypeId = 3,
                        Temperature = 48,
                        RelatedDevices = new List<DeviceRelation>()
                    }, new Device()
                    {
                        Id = 4,
                        Name = "Device 4",
                        DeviceStatusId = 2,
                        DeviceTypeId = 1,
                        Temperature = 35,
                        RelatedDevices = new List<DeviceRelation>()
                    },
                    new Device()
                    {
                        Id = 5,
                        Name = "Device 5",
                        DeviceStatusId = 1,
                        DeviceTypeId = 2,
                        Temperature = 23,
                        RelatedDevices = new List<DeviceRelation>()
                    },
                    new Device()
                    {
                        Id = 6,
                        Name = "Device 6",
                        DeviceStatusId = 1,
                        DeviceTypeId = 3,
                        Temperature = 11,
                        RelatedDevices = new List<DeviceRelation>()
                    },
                    new Device()
                    {
                        Id = 7,
                        Name = "Device 7",
                        DeviceStatusId = 2,
                        DeviceTypeId = 2,
                        Temperature = 32,
                        RelatedDevices = new List<DeviceRelation>()
                    },
                    new Device()
                    {
                        Id = 8,
                        Name = "Device 8",
                        DeviceStatusId = 2,
                        DeviceTypeId = 2,
                        Temperature = 38,
                        RelatedDevices = new List<DeviceRelation>()
                    },
                    new Device()
                    {
                        Id = 9,
                        Name = "Device 9",
                        DeviceStatusId = 1,
                        DeviceTypeId = 1,
                        Temperature = 22,
                        RelatedDevices = new List<DeviceRelation>()
                    },
                    new Device()
                    {
                        Id = 10,
                        Name = "Device 10",
                        DeviceStatusId = 2,
                        DeviceTypeId = 3,
                        Temperature = 11,
                        RelatedDevices = new List<DeviceRelation>()
                    },
                    new Device()
                    {
                        Id = 11,
                        Name = "Device 11",
                        DeviceStatusId = 2,
                        DeviceTypeId = 2,
                        Temperature = 18,
                        RelatedDevices = new List<DeviceRelation>()
                    }
                ); ;

            modelBuilder.Entity<DeviceRelation>()
                .HasData(
                    new DeviceRelation() { RootDeviceId = 1, RelatedDeviceId = 6 },
                    new DeviceRelation() { RootDeviceId = 1, RelatedDeviceId = 7 },
                    new DeviceRelation() { RootDeviceId = 1, RelatedDeviceId = 8 },

                    new DeviceRelation() { RootDeviceId = 2, RelatedDeviceId = 8 },
                    new DeviceRelation() { RootDeviceId = 2, RelatedDeviceId = 9 },
                    new DeviceRelation() { RootDeviceId = 2, RelatedDeviceId = 10 },

                    new DeviceRelation() { RootDeviceId = 3, RelatedDeviceId = 4 },
                    new DeviceRelation() { RootDeviceId = 3, RelatedDeviceId = 7 },
                    new DeviceRelation() { RootDeviceId = 3, RelatedDeviceId = 8 },

                    new DeviceRelation() { RootDeviceId = 4, RelatedDeviceId = 9 },
                    new DeviceRelation() { RootDeviceId = 4, RelatedDeviceId = 10 },
                    new DeviceRelation() { RootDeviceId = 4, RelatedDeviceId = 11 },

                    new DeviceRelation() { RootDeviceId = 5, RelatedDeviceId = 6 },
                    new DeviceRelation() { RootDeviceId = 5, RelatedDeviceId = 7 },
                    new DeviceRelation() { RootDeviceId = 5, RelatedDeviceId = 10 },

                    new DeviceRelation() { RootDeviceId = 6, RelatedDeviceId = 3 },
                    new DeviceRelation() { RootDeviceId = 6, RelatedDeviceId = 2 },
                    new DeviceRelation() { RootDeviceId = 6, RelatedDeviceId = 9 },

                    new DeviceRelation() { RootDeviceId = 7, RelatedDeviceId = 4 },
                    new DeviceRelation() { RootDeviceId = 7, RelatedDeviceId = 5 },
                    new DeviceRelation() { RootDeviceId = 7, RelatedDeviceId = 6 },

                    new DeviceRelation() { RootDeviceId = 8, RelatedDeviceId = 11 },
                    new DeviceRelation() { RootDeviceId = 8, RelatedDeviceId = 9 },
                    new DeviceRelation() { RootDeviceId = 8, RelatedDeviceId = 3 },

                    new DeviceRelation() { RootDeviceId = 9, RelatedDeviceId = 7 },
                    new DeviceRelation() { RootDeviceId = 9, RelatedDeviceId = 10 },
                    new DeviceRelation() { RootDeviceId = 9, RelatedDeviceId = 4 },

                    new DeviceRelation() { RootDeviceId = 10, RelatedDeviceId = 1 },
                    new DeviceRelation() { RootDeviceId = 10, RelatedDeviceId = 2 },
                    new DeviceRelation() { RootDeviceId = 10, RelatedDeviceId = 3 },

                    new DeviceRelation() { RootDeviceId = 11, RelatedDeviceId = 7 },
                    new DeviceRelation() { RootDeviceId = 11, RelatedDeviceId = 8 },
                    new DeviceRelation() { RootDeviceId = 11, RelatedDeviceId = 9 }

                );
        }

        public DbSet<Device> Devices { get; set; }
        public DbSet<DeviceRelation> DeviceRelations { get; set; }
        public DbSet<DeviceType> DeviceTypes { get; set; }
        public DbSet<DeviceStatusType> DeviceStatusTypes { get; set; }
    }
}
