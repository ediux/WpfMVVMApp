using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfMVVMApp.Entity
{   
	public  partial class ShopFlowDetailRepository : EFRepository<ShopFlowDetail>, IShopFlowDetailRepository
	{

	}

	public  partial interface IShopFlowDetailRepository : IRepositoryBase<ShopFlowDetail>
	{

	}
}