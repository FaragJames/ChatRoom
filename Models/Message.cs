using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatRoom.Models
{
	public class Message
	{
		public int Id { get; set; }

		[Required, HiddenInput(DisplayValue = false)]
		public int UserId { get; set; }

		[Required]
		[Column(TypeName = "varchar(100)"), StringLength(100)]
		public string Content { get; set; } = string.Empty;

		[Required, HiddenInput(DisplayValue = false)]
		public DateTime DateTime { get; set; }

		public virtual User? User { get; set; }
	}
}