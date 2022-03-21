using web_api.Contracts;
using web_api.Model;

namespace web_api.Services
{
	public class ShoppingCartService : IShoppingCartService
	{
        /*public ShoppingItem Add(ShoppingItem newItem) => throw new NotImplementedException();

		public IEnumerable<ShoppingItem> GetAllItems() => throw new NotImplementedException();

		public ShoppingItem GetById(Guid id) => throw new NotImplementedException();

		public void Remove(Guid id) => throw new NotImplementedException();*/
        private readonly List<ShoppingItem> _shoppingCart;

        public ShoppingCartService            ()
        {
            _shoppingCart = new List<ShoppingItem>()
            {
                new ShoppingItem() { Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c200"),
                    Name = "Orange Juice", Manufacturer="Orange Tree", Price = 5.00M },
                new ShoppingItem() { Id = new Guid("815accac-fd5b-478a-a9d6-f171a2f6ae7f"),
                    Name = "Diary Milk", Manufacturer="Mad Cow", Price = 4.00M },
                new ShoppingItem() { Id = new Guid("33704c4a-5b87-464c-bfb6-51971b4d18ad"),
                    Name = "Frozen Pizza", Manufacturer="Uncle Mickey's", Price = 12.00M }
            };
        }

        public IEnumerable<ShoppingItem> GetAllItems()
        {
            return _shoppingCart;
        }

        public ShoppingItem Add(ShoppingItem newItem)
        {
            newItem.Id = Guid.NewGuid();
            _shoppingCart.Add(newItem);
            return newItem;
        }

        public ShoppingItem GetById(Guid id)
        {
            return _shoppingCart.Where(a => a.Id == id).FirstOrDefault();
        }

        public void Remove(Guid id)
        {
            var existing = _shoppingCart.First(a => a.Id == id);
            _shoppingCart.Remove(existing);
        }
    }
}
