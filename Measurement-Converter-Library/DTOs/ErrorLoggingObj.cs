using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Library.DTOs
{
    public class ErrorLoggingObj
    {
        [Key]
        public int Id { get; set; }
        public string Error { get; set; }
        public string Date { get; set; }
    }
}
