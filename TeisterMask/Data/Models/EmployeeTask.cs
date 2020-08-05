
using System;
using System.Collections.Generic;
using System.Text;

namespace TeisterMask.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class EmployeeTask
    {        
        public int EmployeeId  { get; set; }

        public Employee Employee { get; set; }

        public int TaskId { get; set; }

        public Task Task { get; set; }

    }
}
