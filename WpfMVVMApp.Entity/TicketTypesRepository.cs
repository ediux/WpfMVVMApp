using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfMVVMApp.Entity
{   
	public  partial class TicketTypesRepository : EFRepository<TicketTypes>, ITicketTypesRepository
	{

	}

	public  partial interface ITicketTypesRepository : IRepositoryBase<TicketTypes>
	{

	}
}