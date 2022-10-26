using Core.CrossCuttingConcerns.Exceptions;
using Core.Persistence.Paging;
using rentACar.Application.Services.Repositories;
using rentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar.Application.Features.Brands.Rules
{
    public class BrandBusinessRules
    {
        private readonly IBrandRepository _brandRepository;
        public BrandBusinessRules(IBrandRepository brandRepository)
        {
            _brandRepository=brandRepository;
        }

        public async Task BrandNameCannotB_eDuplicatedWhenInserted(string name)
        {
            IPaginate<Brand> result = await _brandRepository.GetListAsync(b => b.Name == name);
            if (result.Items.Any()) throw new BusinessException("some feature entity name exists.");
        }
    }
}
