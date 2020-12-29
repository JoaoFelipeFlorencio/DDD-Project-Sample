using System.Collections.Generic;
using WebAPI.Application.DTOs;

namespace WebAPI.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDTO produtoDto);

        void Update(ProdutoDTO produtoDto);

        void Remove(ProdutoDTO produtoDto);

        IEnumerable<ProdutoDTO> GetAll();

        ProdutoDTO GetById(int id);
    }
}