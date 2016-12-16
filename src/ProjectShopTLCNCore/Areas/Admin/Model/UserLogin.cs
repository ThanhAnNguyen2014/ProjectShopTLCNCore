using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectShopTLCNCore.Areas.Admin.Model
{
    public class UserLogin
    {
		[Required]
		[DataType(DataType.EmailAddress)]
		[StringLength(50,ErrorMessage ="{0} bạn nhập phải lớn hơn {2} ký tự!",MinimumLength =3)]
		public string Email { get; set; }
		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		public bool RememberMe { get; set; }

		public UserLogin() { }
		public UserLogin(string email, string pass)
		{
			Email = email;
			Password = pass;
		}
		
	}
}
