using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Domain.Model.Base
{
    public class BaseEntity: IBaseEntity
    {
        public int Id { get; set; }

    }
}
