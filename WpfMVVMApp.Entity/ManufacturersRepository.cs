using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfMVVMApp.Entity
{   
	public  partial class ManufacturersRepository : EFRepository<Manufacturers>, IManufacturersRepository
	{

	}

	public  partial interface IManufacturersRepository : IRepositoryBase<Manufacturers>
	{

	}
}