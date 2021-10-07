using web_api.Contracts;
using web_api.Model;

namespace web_api.Services
{
	public class ShoppingCartService : IShoppingCartService
	{
		public ShoppingItem Add(ShoppingItem newItem) => throw new NotImplementedException();

		public IEnumerable<ShoppingItem> GetAllItems() => throw new NotImplementedException();

		public ShoppingItem GetById(Guid id) => throw new NotImplementedException();

		public void Remove(Guid id) => throw new NotImplementedException();
	}
}
