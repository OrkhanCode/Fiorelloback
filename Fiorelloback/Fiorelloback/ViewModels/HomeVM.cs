﻿using Fiorelloback.Models;
namespace Fiorelloback.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Expert> Experts { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
