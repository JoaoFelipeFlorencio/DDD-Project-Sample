using AutoMapper;
using System.Collections.Generic;
using WebAPI.Application.DTOs;
using WebAPI.Application.Interfaces;
using WebAPI.Domain.Core.Interfaces.Services;
using WebAPI.Domain.Entities;

namespace WebAPI.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente _serviceCliente;
        private readonly IMapper _mapper;
        public ApplicationServiceCliente(IServiceCliente serviceCliente
                                       , IMapper mapper)
        {
            _serviceCliente = serviceCliente;
            _mapper = mapper;
        }
        public void Add(ClienteDTO clienteDto)
        {
            var cliente = _mapper.Map<Cliente>(clienteDto);
            _serviceCliente.Add(cliente);
        }

        public IEnumerable<ClienteDTO> GetAll()
        {
            var clientes = _serviceCliente.GetAll();
            var clientesDto = _mapper.Map<IEnumerable<ClienteDTO>>(clientes);

            return clientesDto;
        }

        public ClienteDTO GetById(int id)
        {
            var cliente = _serviceCliente.GetById(id);
            var clienteDto = _mapper.Map<ClienteDTO>(cliente);

            return clienteDto;
        }

        public void Remove(ClienteDTO clienteDto)
        {
            var cliente = _mapper.Map<Cliente>(clienteDto);
            _serviceCliente.Remove(cliente);
        }

        public void Update(ClienteDTO clienteDto)
        {
            var cliente = _mapper.Map<Cliente>(clienteDto);
            _serviceCliente.Update(cliente);
        }
    }
}
