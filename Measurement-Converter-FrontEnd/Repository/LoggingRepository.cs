﻿using Measurement_Converter_FrontEnd.Database;
using Measurement_Converter_Library.DTOs;
using Measurement_Converter_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Measurement_Converter_FrontEnd.Repository
{
    public class LoggingRepository : ILoggingRepository
    {
        private readonly LoggingDbContext _loggingDbContext;

        public LoggingRepository(LoggingDbContext logcontext)
        {
            _loggingDbContext = logcontext;
        }

        public void Add(LoggingObj DTO)
        {
            _loggingDbContext.Logs.Add(DTO);
            _loggingDbContext.SaveChanges();
        }

        public string GetFirstLog()
        {
           return _loggingDbContext.Logs.FirstOrDefault().Calculation;
        }
    }
}
