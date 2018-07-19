﻿using System.Collections.Generic;
using Kentico.Dto.Company;
using Kentico.Dto.Sections;

namespace MedioClinic.Models.Home
{
    public class HomeViewModel : IViewModel
    {
        public IEnumerable<CompanyServiceDto> CompanyServices { get; set; }

        public HomeSectionDto HomeSection { get; set; }
    }
}