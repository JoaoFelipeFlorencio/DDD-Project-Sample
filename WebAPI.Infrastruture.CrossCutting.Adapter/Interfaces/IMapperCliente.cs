using WebAPI.Application.DTO.DTO;
using WebAPI.Domain.Models;
using System.Collections.Generic;



namespace WebAPI.Infrastruture.CrossCutting.Adapter.Interfaces
{
	public interface IMapperCliente
	{
		#region Mappers

		Cliente MapperToEntity(ClienteDTO clienteDTO);

		IEnumerable<ClienteDTO> MapperListClientes(IEnumerable<Cliente> clientes);

		ClienteDTO MapperToDTO(Cliente Cliente);

		#endregion
	}
}
