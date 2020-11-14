using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Введите свое имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Введите корректный адрес Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введите свой номер телефона")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Укажите, будете ли участвовать")]
        public bool? WillAttend { get; set; }
    }
}
