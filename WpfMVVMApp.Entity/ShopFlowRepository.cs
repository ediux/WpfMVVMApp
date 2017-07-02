using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfMVVMApp.Entity
{   
	public  partial class ShopFlowRepository : EFRepository<ShopFlow>, IShopFlowRepository
	{

	}

	public  partial interface IShopFlowRepository : IRepositoryBase<ShopFlow>
	{

	}
}