using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfMVVMApp.Entity
{   
	public  partial class MaterialsRepository : EFRepository<Materials>, IMaterialsRepository
	{

	}

	public  partial interface IMaterialsRepository : IRepositoryBase<Materials>
	{

	}
}