using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace employeeRegister.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor informe o nome do funcionário.")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Por favor informe um endereço.")]
        [Display(Name = "Endereço")]
        public string Address { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Data Nascimento")]
        [Required(ErrorMessage = "Por favor informe uma data válida.")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Salário (R$)")]
        [Required(ErrorMessage = "Por favor informe um valor moeda. (utilize apenas vírgula como separador)")]
        public float Salary { get; set; }
    }
}