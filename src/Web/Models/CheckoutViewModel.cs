using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
	public class CheckoutViewModel
	{
		[Required, MaxLength(90)]
		public string Country { get; set; }
		[Required, MaxLength(100)]
		public string City { get; set; }
		[Required, MaxLength(60)]
		public string State { get; set; }
		[Required, MaxLength(180)]
		public string Street { get; set; }
		[Required, MaxLength(18)]
		public string ZipCode { get; set; }
		[Required, MaxLength(50)]
		public string CCOwner { get; set; }
		[Required, MaxLength(16)]
		public string CCNumber { get; set; }
		[Required, MaxLength(5)]
		public string CCExpiration { get; set; }
		[Required, MaxLength(4)]
		public string CCCvv { get; set; }
	}
}