using AutoMapper;
using Core.IUnitOfWorks;
using Core.Models;
using Core.Repositories;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IGenericRepository<Product> repository,IProductRepository productRepository,IMapper mapper) : base(unitOfWork, repository)
        {
            _repository = productRepository;
            _mapper = mapper;
        }


    }
}
