using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace WebIdentity.Areas.Admin.Models
{
    public class EditUserViewModel
    {
        public string? Id { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public List<Claim>? Claims { get; set; }

        public EditUserViewModel()
        {
            Claims = new List<Claim>();
        }
    }
}
