using Services.Catalog.Dtos;
using Services.Catalog.Models;
using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Catalog.Interface
{
    public interface ICategoryService
    {
        Task<ResponseDto<List<CategoryDto>>> GetAllAsync();

        Task<ResponseDto<CategoryDto>> GetByIdAsync(string id);

        Task<ResponseDto<CategoryDto>> CreateAsync(CategoryDto categoryDto);

    }
}
