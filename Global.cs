using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace ChatRoom
{
    public static class Global
    {
        public static async Task SignInAsync(HttpContext context, int id, string username)
        {
            List<Claim> claims =
            [
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.NameIdentifier, id.ToString())
            ];
            ClaimsIdentity identity = new(claims, "Authenticated");
            ClaimsPrincipal principal = new(identity);

            await context.SignInAsync(principal);
        }
    }
}
