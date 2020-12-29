using WebAPI.Domain.Core.Interfaces.Repositories;
using WebAPI.Domain.Core.Interfaces.Services;
using WebAPI.Domain.Entities;

namespace WebAPI.Domain.Services.Services
{
	public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
	{
		public readonly IRepositoryCliente _repositoryCliente;

		public ServiceCliente(IRepositoryCliente repositoryCliente) : base(repositoryCliente)
		{
			_repositoryCliente = repositoryCliente;
		}
	}
}
