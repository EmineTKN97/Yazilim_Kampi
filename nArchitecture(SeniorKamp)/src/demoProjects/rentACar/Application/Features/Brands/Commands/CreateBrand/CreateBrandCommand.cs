using Application.Features.Brands.DTOs;
using Application.Features.Brands.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.CreateBrand
{
    //apiden gelen sorguya Dto dön .Command kullanıcının bize göndereceği dataları içerir
    public  class CreateBrandCommand:IRequest<CreatedBrandDto>
    {
        public string Name { get; set; }
        //boyle bir comnandolursa hangi handler çalışacak onu yazıyouruz<Handle edilcek istek ve dönecek cevap>
        public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandDto>
        {
           private readonly  IBrandRepository _brandRepository;
           private readonly IMapper _mapper;
            private readonly BrandBusinessRules _brandBusinessRules;

            public  CreateBrandCommandHandler(IBrandRepository brandRepository,IMapper mapper,BrandBusinessRules brandBusinessRules  )
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
                _brandBusinessRules = brandBusinessRules;
            }

            public async  Task<CreatedBrandDto> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
            {
                await _brandBusinessRules.BrandNameCanNotBeDuplicatedWhenInserted(request.Name);
                // Komutu işle, veritabanına ekle, sonuçları bir DTO'ya dönüştür ve geri döndür.
                //veritabanına requeste gönderdiğim commandın propertiesini eşitler(Gelen isteği brande çeviririm)
                Brand mappedBrand = _mapper.Map<Brand>(request);
                //veritabanındanda kullanıcıya geri veri döndürür.//ekleme işlemi yapıyorum
                Brand createdBrand = await _brandRepository.AddAsync(mappedBrand);
                //veritabanımı direk döndürmemeliyiz bu yüzden dto kullanırız.Kullanıcıya başka nesne vermiş oluyorum
                CreatedBrandDto createdBrandDto = _mapper.Map<CreatedBrandDto>(createdBrand);
                return createdBrandDto;
            }
        }
    }
}
