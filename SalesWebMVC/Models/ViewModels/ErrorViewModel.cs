using System;

// Atencao pois no projeto do curso eh namespace SalesWebMVC.Models.ViewModels
namespace SalesWebMVC.Models {
    public class ErrorViewModel {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}