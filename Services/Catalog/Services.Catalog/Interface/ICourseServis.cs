using Services.Catalog.Dtos;
using Services.Catalog.Dtos.CQRS;
using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Catalog.Interface
{
    public interface ICourseServis
    {
        Task<ResponseDto<List<CourseDto>>> GetAllAsync();

        Task<ResponseDto<CourseDto>> GetByIdAsync(string id);

        Task<ResponseDto<List<CourseDto>>> GetAllByUserIdAsync(string userId);

        Task<ResponseDto<CourseDto>> CreateAsync(CourseCreateDto courseCreateDto);
        Task<ResponseDto<NoContent>> UpdateAsync(CourseUpdateDto courseUpdateDto);
        Task<ResponseDto<NoContent>> DeleteAsync(string id);


    }
}
