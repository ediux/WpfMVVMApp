using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfMVVMApp.Entity
{   
	public  partial class TicketPeriodRepository : EFRepository<TicketPeriod>, ITicketPeriodRepository
	{

	}

	public  partial interface ITicketPeriodRepository : IRepositoryBase<TicketPeriod>
	{

	}
}