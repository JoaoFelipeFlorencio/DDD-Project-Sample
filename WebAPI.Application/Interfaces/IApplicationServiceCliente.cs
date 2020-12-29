using System.Collections.Generic;
using WebAPI.Application.DTOs;

namespace WebAPI.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDTO clienteDto);

        void Update(ClienteDTO clienteDto);

        void Remove(ClienteDTO clienteDto);

        IEnumerable<ClienteDTO> GetAll();

        ClienteDTO GetById(int id);
    }
}