using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfMVVMApp.Entity
{   
	public  partial class TranscationCategoriesRepository : EFRepository<TranscationCategories>, ITranscationCategoriesRepository
	{

	}

	public  partial interface ITranscationCategoriesRepository : IRepositoryBase<TranscationCategories>
	{

	}
}