using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
namespace tester.Models
{
    public class CarModel
    {
        [Key]
        public int CarId { get; set; }
        public string CarBrand { get; set; }
        public string CarType { get; set; }
        public string CarColor { get; set; }
        public string Ready { get; set; }
    }
}
