using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfMVVMApp.Entity
{   
	public  partial class MoldsInProjectsRepository : EFRepository<MoldsInProjects>, IMoldsInProjectsRepository
	{

	}

	public  partial interface IMoldsInProjectsRepository : IRepositoryBase<MoldsInProjects>
	{

	}
}