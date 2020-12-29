using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Domain.Core.Interfaces.Repositories;
using WebAPI.Domain.Models;
using WebAPI.Infrastructure.Data;

namespace WebAPI.Infrastructure.Repository.Repositories
{
	public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
	{
		private readonly SqlContext _context;
		public RepositoryProduto(SqlContext context) : base(context)
		{
			_context = context;
		}
	}
}
