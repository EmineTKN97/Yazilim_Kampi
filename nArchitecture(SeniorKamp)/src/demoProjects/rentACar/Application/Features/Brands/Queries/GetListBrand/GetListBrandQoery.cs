using Application.Features.Brands.Models;
using Application.Features.Brands.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Queries.GetListBrand
{
  

    public class GetListBrandQoery : IRequest<BrandListModel>
    {
        public PageRequest PageRequest { get; set; }
        public class GetListBrandQoeryHandler : IRequestHandler<GetListBrandQoery, BrandListModel>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;
        
            public GetListBrandQoeryHandler(IBrandRepository brandRepository, IMapper mapper)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
          
            }

            public async Task<BrandListModel> Handle(GetListBrandQoery request, CancellationToken cancellationToken)
            {
                
               IPaginate<Brand>  brands = await _brandRepository.GetListAsync(index:request.PageRequest.Page,size:request.PageRequest.PageSize);
               BrandListModel mappedbrandListModel =_mapper.Map<BrandListModel>(brands);  
                return mappedbrandListModel;    

            }
        }
    }
}
 

