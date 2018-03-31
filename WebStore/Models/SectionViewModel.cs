﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Model.Base;

namespace WebStore.Models
{
    public class SectionViewModel : INamedEntity, IOrderedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }

        public SectionViewModel()
        {
            ChildSections = new List<SectionViewModel>();
        }

        /// <summary> 
        /// Дочерние	 секции	 
        /// </summary> 
        public List<SectionViewModel> ChildSections { get; set; }

        /// <summary> 
        /// Родительская	 секция	 
        /// </summary> 
        public SectionViewModel ParentSection { get; set; }


    }
}