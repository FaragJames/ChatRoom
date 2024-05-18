using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatRoom.Models
{
	[Index(nameof(Username), IsUnique = true)]
	public class User
	{
		public int Id { get; set; }

		[Required]
		[Column(TypeName = "varchar(25)"), StringLength(25)]
		public string Username { get; set; } = string.Empty;

		[Required]
		[Column(TypeName = "varchar(20)"), StringLength(20, MinimumLength = 8)]
		[DataType(DataType.Password)]
		public string Password { get; set; } = string.Empty;

		public virtual ICollection<Message>? Messages { get; set; }
	}
}
