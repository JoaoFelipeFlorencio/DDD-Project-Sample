using System.Collections.Generic;
using WebAPI.Application.DTO.DTO;
using WebAPI.Domain.Models;
using WebAPI.Infrastruture.CrossCutting.Adapter.Interfaces;

namespace WebAPI.Infrastruture.CrossCutting.Adapter.Map
{
    public class MapperCliente : IMapperCliente
    {

        #region properties

        List<ClienteDTO> clienteDTOs = new List<ClienteDTO>();

        #endregion


        #region methods

        public Cliente MapperToEntity(ClienteDTO clienteDTO)
        {
            Cliente cliente = new Cliente
            {
                Id = clienteDTO.Id
                ,
                Nome = clienteDTO.Nome
                ,
                Email = clienteDTO.Email
            };

            return cliente;

        }


        public IEnumerable<ClienteDTO> MapperListClientes(IEnumerable<Cliente> clientes)
        {
            foreach (var item in clientes)
            {


                ClienteDTO clienteDTO = new ClienteDTO
                {
                    Id = item.Id
                   ,
                    Nome = item.Nome
                   ,
                    Email = item.Email
                };



                clienteDTOs.Add(clienteDTO);

            }

            return clienteDTOs;
        }

        public ClienteDTO MapperToDTO(Cliente Cliente)
        {

            ClienteDTO clienteDTO = new ClienteDTO
            {
                Id = Cliente.Id
                ,
                Nome = Cliente.Nome
                ,
                Email = Cliente.Email
            };

            return clienteDTO;

        }

        #endregion

    }
}
