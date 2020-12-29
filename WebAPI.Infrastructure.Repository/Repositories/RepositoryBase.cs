using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebAPI.Domain.Core.Interfaces.Repositories;
using WebAPI.Infrastructure.Data;

namespace WebAPI.Infrastructure.Repository.Repositories
{
	public abstract class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
	{

		private readonly SqlContext _context;

		public RepositoryBase(SqlContext context) 
		{
			_context = context;
		}

		public void Add(TEntity obj)
		{
			try
			{
				_context.Set<TEntity>().Add(obj);
				_context.SaveChanges();

			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public void Dispose()
		{
			_context.Dispose();
		}

		public IEnumerable<TEntity> GetAll()
		{
			return _context.Set<TEntity>().ToList();
		}

		public TEntity GetById(int id)
		{
			return _context.Set<TEntity>().Find(id);
		}

		public void Remove(TEntity obj)
		{
			try
			{
				_context.Set<TEntity>().Remove(obj);
				_context.SaveChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public void Update(TEntity obj)
		{
			try
			{
				_context.Entry(obj).State = EntityState.Modified;
				_context.SaveChanges();

			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
	}
}
