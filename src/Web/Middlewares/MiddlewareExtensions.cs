using Microsoft.AspNetCore.Builder;

namespace Web.Middlewares
{
    public static class MiddlewareExtensions
    {
        public static void UseBasketTransfer(this IApplicationBuilder app)
        {
            app.UseMiddleware<BasketTransferMiddleware>();
        }
    }
}
