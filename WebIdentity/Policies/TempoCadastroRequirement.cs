using Microsoft.AspNetCore.Authorization;

namespace WebIdentity.Policies
{
    public class TempoCadastroRequirement : IAuthorizationRequirement
    {
        public int TempoCadastroMinimo { get; set; }

        public TempoCadastroRequirement(int tempoCadastroMinimo)
        {
            TempoCadastroMinimo = tempoCadastroMinimo;
        }
    }
}
