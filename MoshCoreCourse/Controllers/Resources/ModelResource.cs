using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MoshCoreCourse.Models;

namespace MoshCoreCourse.Controllers.Resources
{
    public class ModelResource
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
