﻿using System.ComponentModel.DataAnnotations;

namespace MoshCoreCourse.Controllers.Resources
{
    public class ContactResource
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public string Email { get; set; }
        [Required]
        [StringLength(255)] 
        public string Phone { get; set; }
    }
}