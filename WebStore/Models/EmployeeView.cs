﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class EmployeeView
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string SurName { get; set; }

        public string Patronymic { get; set; }

        public int Age { get; set; }

        public string Departament { get; set; }
    }
}