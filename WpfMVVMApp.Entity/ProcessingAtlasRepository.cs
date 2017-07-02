using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfMVVMApp.Entity
{   
	public  partial class ProcessingAtlasRepository : EFRepository<ProcessingAtlas>, IProcessingAtlasRepository
	{

	}

	public  partial interface IProcessingAtlasRepository : IRepositoryBase<ProcessingAtlas>
	{

	}
}