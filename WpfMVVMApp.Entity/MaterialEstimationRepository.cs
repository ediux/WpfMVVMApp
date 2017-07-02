using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfMVVMApp.Entity
{   
	public  partial class MaterialEstimationRepository : EFRepository<MaterialEstimation>, IMaterialEstimationRepository
	{

	}

	public  partial interface IMaterialEstimationRepository : IRepositoryBase<MaterialEstimation>
	{

	}
}