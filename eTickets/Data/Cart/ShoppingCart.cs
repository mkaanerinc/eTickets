using eTickets.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eTickets.Data.Cart
{
    public class ShoppingCart
    {
        private readonly AppDbContext _context;
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public ShoppingCart(AppDbContext context)
        {
            _context = context;
        }

        public static ShoppingCart GetShoppingCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId};
        }

        public void AddItemToCart(Movie movie)
        {
            var shoppingCartItem = _context.Set<ShoppingCartItem>().FirstOrDefault(x => x.Movie.Id == movie.Id && x.ShoppingCartId == ShoppingCartId);

            if(shoppingCartItem is null)
            {
                shoppingCartItem = new ShoppingCartItem()
                {
                    Movie = movie,
                    ShoppingCartId = ShoppingCartId,
                    Amount = 1,
                };

                _context.Set<ShoppingCartItem>().Add(shoppingCartItem);
            } else
            {
                shoppingCartItem.Amount++;
            }

            _context.SaveChanges();
        }

        public void RemoveItemFromCart(Movie movie)
        {
            var shoppingCartItem = _context.Set<ShoppingCartItem>().FirstOrDefault(x => x.Movie.Id == movie.Id && x.ShoppingCartId == ShoppingCartId);

            if(shoppingCartItem is not null)
            {
                if(shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                } else
                {
                    _context.Set<ShoppingCartItem>().Remove(shoppingCartItem);
                }
                
            }
            _context.SaveChanges();
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _context.Set<ShoppingCartItem>().Where(x => x.ShoppingCartId == ShoppingCartId).Include(x => x.Movie).ToList());
        }

        public double GetShoppingCartTotal()
        {
            return _context.Set<ShoppingCartItem>().Where(x => x.ShoppingCartId == ShoppingCartId).Select(x => x.Movie.Price * x.Amount).Sum();
        }
    }
}
