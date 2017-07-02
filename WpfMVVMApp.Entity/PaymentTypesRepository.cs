using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfMVVMApp.Entity
{   
	public  partial class PaymentTypesRepository : EFRepository<PaymentTypes>, IPaymentTypesRepository
	{

	}

	public  partial interface IPaymentTypesRepository : IRepositoryBase<PaymentTypes>
	{

	}
}