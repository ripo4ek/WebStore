using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Model.Base;

namespace WebStore.Domain.Model
{
    public class Section : NamedEntity, IOrderedEntity
    {
        /// <summary>
        /// Родительская секция (при наличии)
        /// </summary>
        public int? ParentId { get; set; }
        public int Order { get; set; }
    }

}
