using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfMVVMApp.Entity
{   
	public  partial class FormsRepository : EFRepository<Forms>, IFormsRepository
	{

	}

	public  partial interface IFormsRepository : IRepositoryBase<Forms>
	{

	}
}