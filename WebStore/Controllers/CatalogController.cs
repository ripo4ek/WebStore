﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Domain.Model;
using WebStore.Infrastructure.Implementations;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Shop(int? sectionId, int? brandId)
        {
            
            var products = new InMemoryProductData().GetProducts(new ProductFilter
            {
                BrandId = brandId,
                SectionId =
                    sectionId
            });
            var model = new CatalogViewModel()
            {
                BrandId = brandId,
                SectionId = sectionId,
                Products = products.Select(p => new ProductViewModel()
                {
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                    Name = p.Name,
                    Order = p.Order,
                    Price = p.Price
                }).OrderBy(p => p.Order).ToList()
            };
            return View(model);
        }
    public IActionResult ProductDetails()
        {
            return View();
        }
    }
}