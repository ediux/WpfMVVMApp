using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfMVVMApp.Entity
{   
	public  partial class ShopFlowHistoryRepository : EFRepository<ShopFlowHistory>, IShopFlowHistoryRepository
	{

	}

	public  partial interface IShopFlowHistoryRepository : IRepositoryBase<ShopFlowHistory>
	{

	}
}