using System.ComponentModel.DataAnnotations;

namespace POS.DTOs
{
    public class ProductDTO
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "El código del artículo es requerido")]
        public string ProductCode { get; set; }

        [Required(ErrorMessage = "Debe especificar el nombre del producto")]
        public string ProductName { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "El precio unitario es obligatorio")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El valor debe ser superior a cero")]
        public decimal UnitPrice { get; set; }

        public int StockQuantity { get; set; }
        public bool Taxable { get; set; }
    }

    public class ProductSearchDTO
    {
        public string SearchTerm { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public int TotalRecords { get; set; }
        public List<ProductDTO> Results { get; set; } = new();
    }
}
