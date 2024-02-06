using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
	public class Customer : BaseDomainModel
	{
		[Required]
		[RegularExpression(@"^[STFGstfg]\d{7}[A-Za-z]", ErrorMessage = "License does not meet requirements.")]
		public string? DrivingLicense { get; set; }
		public string? Address { get; set; }
		[Required]
		[DataType(DataType.PhoneNumber, ErrorMessage = "Phone Number does not meet requirements.")]
		public string? ContactNumber { get; set; }
		[Required]
		[DataType(DataType.EmailAddress, ErrorMessage = "Email does not meet requirements.")]
		[EmailAddress]
		public string? EmailAddress { get; set; }
		public virtual List<Booking>? Bookings { get; set; }
		[Required]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "First Name does not meet requirements.")]
		public string? FirstName { get; set; }
		[Required]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "Last Name does not meet requirements.")]
		public string? LastName { get; set;}
	}
}