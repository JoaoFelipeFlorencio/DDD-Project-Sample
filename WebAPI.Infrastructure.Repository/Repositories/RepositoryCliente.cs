using WebAPI.Domain.Core.Interfaces.Repositories;
using WebAPI.Domain.Models;
using WebAPI.Infrastructure.Data;

namespace WebAPI.Infrastructure.Repository.Repositories
{
	public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
	{
		private readonly SqlContext _context;

		public RepositoryCliente(SqlContext context) : base(context)
		{
			_context = context;
		}
	}
}
