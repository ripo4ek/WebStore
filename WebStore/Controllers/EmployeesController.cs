using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeesData _employeesData;
        public EmployeesController(IEmployeesData employeesData)
        {
            _employeesData = employeesData;
        }
        public IActionResult Index()
        {
            return View(_employeesData.GetAll());
        }
        public IActionResult Details(int id)
        {
            return View(_employeesData.GetById(id));
        }
        public IActionResult Edit(int? id)
        {
            EmployeeView model;
            if (id.HasValue)
            {
                model = _employeesData.GetById(id.Value);
                if (ReferenceEquals(model, null))
                    return NotFound();// возвращаем результат 404 Not Found
            }
            else
            {
                model = new EmployeeView();
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(EmployeeView model)
        {
            if (model.Id > 0)
            {
                var dbItem = _employeesData.GetById(model.Id);
                if (ReferenceEquals(dbItem, null))
                    return NotFound();
                dbItem.FirstName = model.FirstName;
                dbItem.SurName = model.SurName;
                dbItem.Age = model.Age;
                dbItem.Patronymic = model.Patronymic;
                dbItem.Departament = dbItem.Departament;
            }
            else
            {
                _employeesData.AddNew(model);
            }
            _employeesData.Commit();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            _employeesData.Delete(id);
            return RedirectToAction(nameof(Index));
        }



    }
}