using AutoMapper;
using System.Collections.Generic;
using WebAPI.Application.DTOs;
using WebAPI.Application.Interfaces;
using WebAPI.Domain.Core.Interfaces.Services;
using WebAPI.Domain.Entities;

namespace WebAPI.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto _serviceProduto;
        private readonly IMapper _mapper;

        public ApplicationServiceProduto(IServiceProduto serviceProduto
                                        , IMapper mapper)
        {
            _serviceProduto = serviceProduto;
            _mapper = mapper;
        }

        public void Add(ProdutoDTO produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            _serviceProduto.Add(produto);
        }

        public IEnumerable<ProdutoDTO> GetAll()
        {
            var produtos = _serviceProduto.GetAll();
            var produtosDto = _mapper.Map<IEnumerable<ProdutoDTO>>(produtos);
            return produtosDto;
        }

        public ProdutoDTO GetById(int id)
        {
            var produto = _serviceProduto.GetById(id);
            var produtoDto = _mapper.Map<ProdutoDTO>(produto);
            return produtoDto;
        }

        public void Remove(ProdutoDTO produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            _serviceProduto.Remove(produto);
        }

        public void Update(ProdutoDTO produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            _serviceProduto.Update(produto);
        }
    }
}