using WebAPI.Domain.Core.Interfaces.Repositories;
using WebAPI.Domain.Core.Interfaces.Services;
using WebAPI.Domain.Entities;

namespace WebAPI.Domain.Services.Services
{
	public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
	{
		public readonly IRepositoryProduto _repositoryProduto;

		public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
		{
			_repositoryProduto = repositoryProduto;
		}
	}
}
