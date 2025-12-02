using System.ComponentModel.DataAnnotations;

namespace POS.DTOs
{
    public class CreateSalesOrderDTO
    {
        [Required(ErrorMessage = "Debe seleccionar un comprador")]
        public int CustomerId { get; set; }

        public string? Notes { get; set; }

        [Required(ErrorMessage = "Es necesario agregar al menos un artículo")]
        [MinLength(1, ErrorMessage = "Es necesario agregar al menos un artículo")]
        public List<SalesOrderDetailDTO> OrderDetails { get; set; } = new();
    }

    public class SalesOrderDetailDTO
    {
        [Required(ErrorMessage = "Debe especificar el producto")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "La cantidad es obligatoria")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad mínima debe ser 1")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "El precio unitario es obligatorio")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El valor debe ser superior a cero")]
        public decimal UnitPrice { get; set; }

        // Additional properties for display
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal LineTotal { get; set; }
    }

    public class SalesOrderViewModel
    {
        public int SalesOrderId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Subtotal { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public string? Notes { get; set; }

        // Customer information
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerIdentification { get; set; }
        public string? CustomerEmail { get; set; }
        public string? CustomerPhone { get; set; }
        public string? CustomerAddress { get; set; }

        // Order details
        public List<SalesOrderDetailViewModel> OrderDetails { get; set; } = new();
    }

    public class SalesOrderDetailViewModel
    {
        public int SalesOrderDetailId { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }
    }

    public class SalesOrderSearchDTO
    {
        public string SearchTerm { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public int TotalRecords { get; set; }
        public List<SalesOrderSummaryDTO> Results { get; set; } = new();
    }

    public class SalesOrderSummaryDTO
    {
        public int SalesOrderId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public string CustomerName { get; set; }
    }

    public class TransactionResultDTO
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int? OrderId { get; set; }
        public string OrderNumber { get; set; }
    }
}
