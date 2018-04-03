﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebStore.Domain.Model.Base;

namespace WebStore.Domain.Model
{
    [Table("Brands")]
    public class Brand: NamedEntity , IOrderedEntity
    {
        

        public int Order { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
