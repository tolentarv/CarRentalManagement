﻿using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
	public class Booking : BaseDomainModel, IValidatableObject
	{
		public DateTime DateOut { get; set; }
		public DateTime? DateIn { get; set; }
		public int VehicleId { get; set; }
		public virtual Vehicle? Vehicle { get; set; }
		public int CustomerId { get; set; }
		public virtual Customer? Customer { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			//throw new NotImplementedException();
			if(DateIn !=null)
			{
				if(DateIn<= DateOut)
				{
					yield return new ValidationResult("DateIn must be greater than DateOut", new[] { "DateIn" });
				}
			}
		}
	}
}