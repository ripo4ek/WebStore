using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Model.Base;

namespace WebStore.Domain.Model
{
    public class Brand: NamedEntity , IOrderedEntity
    {
        public int Order { get; set; }
    }
}
