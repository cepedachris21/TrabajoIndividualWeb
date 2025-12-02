using System.ComponentModel.DataAnnotations;

namespace POS.DTOs
{
    public class CustomerDTO
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "El número de identificación es obligatorio")]
        [RegularExpression(@"^\d{10,13}$", ErrorMessage = "Formato de documento inválido, debe contener entre 10-13 dígitos")]
        public string IdentificationNumber { get; set; }

        [Required(ErrorMessage = "Debe ingresar el primer nombre")]
        [RegularExpression(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$", ErrorMessage = "Solo se permiten caracteres alfabéticos")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Debe ingresar el apellido")]
        [RegularExpression(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$", ErrorMessage = "Solo se permiten caracteres alfabéticos")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "El número telefónico ingresado no es válido")]
        public string Phone { get; set; }

        public string Address { get; set; }
        public string FullName { get; set; }
    }

    public class CustomerSearchDTO
    {
        public string SearchTerm { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public int TotalRecords { get; set; }
        public List<CustomerDTO> Results { get; set; } = new();
    }
}
