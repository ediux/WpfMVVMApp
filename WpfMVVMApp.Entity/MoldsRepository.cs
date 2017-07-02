using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfMVVMApp.Entity
{   
	public  partial class MoldsRepository : EFRepository<Molds>, IMoldsRepository
	{

	}

	public  partial interface IMoldsRepository : IRepositoryBase<Molds>
	{

	}
}