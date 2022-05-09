﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Catalog.Dtos.CQRS
{
    public class CourseCreateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Picture { get; set; }
        public string UserId { get; set; }
        public FeatureDto Feature { get; set; }
        public string CategoryId { get; set; }
        public CategoryDto Category { get; set; }
    }
}
