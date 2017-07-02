using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfMVVMApp.Entity
{   
	public  partial class MaterialCategoriesRepository : EFRepository<MaterialCategories>, IMaterialCategoriesRepository
	{

	}

	public  partial interface IMaterialCategoriesRepository : IRepositoryBase<MaterialCategories>
	{

	}
}