using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfMVVMApp.Entity
{   
	public  partial class ManufacturersBussinessItemsRepository : EFRepository<ManufacturersBussinessItems>, IManufacturersBussinessItemsRepository
	{

	}

	public  partial interface IManufacturersBussinessItemsRepository : IRepositoryBase<ManufacturersBussinessItems>
	{

	}
}