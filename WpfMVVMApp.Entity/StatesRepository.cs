using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfMVVMApp.Entity
{   
	public  partial class StatesRepository : EFRepository<States>, IStatesRepository
	{

	}

	public  partial interface IStatesRepository : IRepositoryBase<States>
	{

	}
}