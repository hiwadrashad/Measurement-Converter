﻿using Measurement_Converter_Library.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Library.Interfaces
{
    public interface IResultDataService
    {
        Task<ConversionTypeResult> Get(double value);
    }
}
