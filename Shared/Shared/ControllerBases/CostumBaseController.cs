using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.ControllerBases
{
    public class CostumBaseController : ControllerBase
    {
        public IActionResult CreateActionResultInstance<T>(ResponseDto<T> response)
        {
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }


    }
}
