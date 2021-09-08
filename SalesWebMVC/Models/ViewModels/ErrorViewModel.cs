using System;

namespace SalesWebMVC.Models.ViewModels
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string Mesage { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}