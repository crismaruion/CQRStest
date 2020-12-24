using System;
using System.ComponentModel.DataAnnotations;

namespace TestApi.Core.DtoModels
{
    public class CreateUpdateToDoDto
    {
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTimeOffset Deadline { get; set; }
    }
}
