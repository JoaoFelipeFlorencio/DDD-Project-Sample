using WebAPI.Application.DTO.DTO;
using WebAPI.Domain.Models;
using System.Collections.Generic;

namespace WebAPI.Infrastruture.CrossCutting.Adapter.Interfaces
{
	public interface IMapperProduto
	{
		#region Interfaces Mappers
		Produto MapperToEntity(ProdutoDTO produtoDTO);

		IEnumerable<ProdutoDTO> MapperListProdutos(IEnumerable<Produto> clientes);

		ProdutoDTO MapperToDTO(Produto produto);

		#endregion
	}
}
