using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfMVVMApp.Entity
{   
	public  partial class BOMRepository : EFRepository<BOM>, IBOMRepository
	{

	}

	public  partial interface IBOMRepository : IRepositoryBase<BOM>
	{

	}
}