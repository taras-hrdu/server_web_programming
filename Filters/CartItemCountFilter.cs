using AppOrmEntity.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

public class CartItemCountFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        if (context.Controller is Controller controller)
        {
            var cart = context.HttpContext.Session.GetObjectFromJson<ShoppingCart>("Cart") ?? new ShoppingCart();
            controller.ViewData["CartItemCount"] = cart.Items.Sum(item => item.Quantity);
        }
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
    }
}
