using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Drawing;

namespace CarRentalManagement.Server.Configurations.Entities
{
	public class ModelSeedConfiguration : IEntityTypeConfiguration<Shared.Domain.Model>
	{
		public void Configure(EntityTypeBuilder<Shared.Domain.Model> builder)
		{
			builder.HasData(
				new Model
				{
					Id = 1,
					Name = "3 Series",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Model
				{
					Id = 2,
					Name = "X5",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Model
				{
					Id = 3,
					Name = "Prius",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Model
				{
					Id = 4,
					Name = "Rav4",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}
				);
		}
	}
}
