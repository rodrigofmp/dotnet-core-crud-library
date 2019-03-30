using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Models.Resources
{
    public class SaveBookResource
    {
        [Required]
        public string Title { get; set; }
    }
}