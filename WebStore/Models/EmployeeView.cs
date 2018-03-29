using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class EmployeeView
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Не указано имя")]
        [RegularExpression(@"^[а-яА-ЯёЁa-zA-Z]+$")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Не указана фамилия")]
        [RegularExpression(@"^[а-яА-ЯёЁa-zA-Z]+$")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Не указано отчество")]
        [RegularExpression(@"^[а-яА-ЯёЁa-zA-Z]+$")]
        public string Patronymic { get; set; }

        [Required(ErrorMessage = "Не указан возраст")]
        [Range(18, 100)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Не указано место работы")]
        [RegularExpression(@"^[а-яА-ЯёЁa-zA-Z]+$")]
        public string Departament { get; set; }
    }
}
